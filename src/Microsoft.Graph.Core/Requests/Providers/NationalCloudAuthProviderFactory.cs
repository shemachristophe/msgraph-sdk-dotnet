using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static Microsoft.Graph.CoreConstants;

namespace Microsoft.Graph
{
    public class NationalCloudAuthProviderFactory
    {
        private Dictionary<string, Func<IAuthenticationProvider>> _authProviders;
        private IGraphStorageProvider _graphStorageProvider;
        private const string _nationalCloudCacheKey = "graph_national_cloud";
        public NationalCloudAuthProviderFactory(IGraphStorageProvider graphStorageProvider)
        {
            _authProviders = new Dictionary<string, Func<IAuthenticationProvider>>();
            _graphStorageProvider = graphStorageProvider;
        }

        public void AddProvider(string nationalCloud, IAuthenticationProvider authenticationProvider)
        {
            _authProviders.Add(nationalCloud, () => authenticationProvider);
        }

        public void AddProvider(string nationalCloud, Func<IAuthenticationProvider> authenticationProvider)
        {
            _authProviders.Add(nationalCloud, authenticationProvider);
        }

        public async Task<IAuthenticationProvider> GetProviderForUserAsync(string domainIdentifier)
        {
            if (string.IsNullOrEmpty(domainIdentifier)) return null;

            int atIndex = domainIdentifier.IndexOf('@');
            string usersDomain = string.Empty;

            if (atIndex != -1)
                usersDomain = domainIdentifier.Substring(atIndex + 1);
            else
                usersDomain = domainIdentifier;

            // check if tenant is in our cache
            string nationalCloudCache = (await _graphStorageProvider.GetStorageItemAsync(usersDomain + _nationalCloudCacheKey)) as string;

            if (nationalCloudCache == null)
                // if null, get openid config
                nationalCloudCache = await GetDomainNationalCloudAsync(usersDomain);

            _authProviders.TryGetValue(nationalCloudCache, out Func<IAuthenticationProvider> authenticationProviderDelegate);

            return authenticationProviderDelegate?.Invoke();
        }

        private async Task<string> GetDomainNationalCloudAsync(string usersDomain)
        {
            string nationalCloud = CoreConstants.NationalClouds.Global;
            // if not, is it mooncake?
            if (usersDomain.EndsWith(".cn"))
                nationalCloud = NationalClouds.China;
            else
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync("https://login.microsoftonline.com/" + usersDomain + "/v2.0/.well-known/openid-configuration");

                // get openid config
                string responseString = await response.Content.ReadAsStringAsync();

                OpenIdConfiguration openIdConfig = JsonConvert.DeserializeObject<OpenIdConfiguration>(responseString);

                switch (openIdConfig.CloudInstanceName)
                {
                    case "microsoftonline.de":
                        nationalCloud = NationalClouds.Germany;
                        break;
                    case "microsoftonline.us":
                        if (openIdConfig.TenantRegionSubScope != "DODC")
                            nationalCloud = NationalClouds.USGov;
                        break;
                    case "microsoftonline.com":
                        if (openIdConfig.TenantRegionSubScope == "USG" || openIdConfig.TenantRegionSubScope == "DODC")
                            nationalCloud = NationalClouds.USGov;
                        break;
                }
            }
            return nationalCloud;
        }
    }
}
