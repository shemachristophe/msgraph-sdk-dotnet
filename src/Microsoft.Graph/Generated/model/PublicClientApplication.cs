// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PublicClientApplication.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PublicClientApplication>))]
    public partial class PublicClientApplication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicClientApplication"/> class.
        /// </summary>
        public PublicClientApplication()
        {
            this.ODataType = "microsoft.graph.publicClientApplication";
        }

        /// <summary>
        /// Gets or sets redirectUris.
        /// Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
        /// </summary>
        [JsonPropertyName("redirectUris")]
        public IEnumerable<string> RedirectUris { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
