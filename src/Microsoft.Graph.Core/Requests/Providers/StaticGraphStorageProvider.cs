using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Graph
{
    public class StaticGraphStorageProvider : IGraphStorageProvider
    {
        private static IDictionary<string, object> _cache = new Dictionary<string, object>();
        public async Task<object> GetStorageItemAsync(string itemId)
        {
            _cache.TryGetValue(itemId, out object item);

            return await Task.FromResult(item);
        }

        public async Task SetStorageItemAsync(string itemId, object item)
        {
            _cache.Add(itemId, item);

            await Task.FromResult(0);
        }
    }
}
