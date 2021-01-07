// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type OAuth2Permission Grant.
    /// </summary>
    
    public partial class OAuth2PermissionGrant : Entity
    {
    
		///<summary>
		/// The OAuth2PermissionGrant constructor
		///</summary>
        public OAuth2PermissionGrant()
        {
            this.ODataType = "microsoft.graph.oAuth2PermissionGrant";
        }
	
        /// <summary>
        /// Gets or sets client id.
        /// The id of the client service principal for the application which is authorized to act on behalf of a signed-in user when accessing an API. Required. Supports $filter (eq only).
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets consent type.
        /// Indicates if authorization is granted for the client application to impersonate all users or only a specific user. AllPrincipals indicates authorization to impersonate all users. Principal indicates authorization to impersonate a specific user. Consent on behalf of all users can be granted by an administrator. Non-admin users may be authorized to consent on behalf of themselves in some cases, for some delegated permissions. Required. Supports $filter (eq only).
        /// </summary>
        [JsonPropertyName("consentType")]
        public string ConsentType { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// The id of the user on behalf of whom the client is authorized to access the resource, when consentType is Principal. If consentType is AllPrincipals this value is null. Required when consentType is Principal.
        /// </summary>
        [JsonPropertyName("principalId")]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// The id of the resource service principal to which access is authorized. This identifies the API which the client is authorized to attempt to call on behalf of a signed-in user.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// A space-separated list of the claim values for delegated permissions which should be included in access tokens for the resource application (the API). For example, openid User.Read GroupMember.Read.All. Each claim value should match the value field of one of the delegated permissions defined by the API, listed in the publishedPermissionScopes property of the resource service principal.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    
    }
}

