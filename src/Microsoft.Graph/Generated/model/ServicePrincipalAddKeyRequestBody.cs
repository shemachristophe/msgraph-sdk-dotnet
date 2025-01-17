// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ServicePrincipalAddKeyRequestBody.
    /// </summary>
    public partial class ServicePrincipalAddKeyRequestBody
    {
    
        /// <summary>
        /// Gets or sets KeyCredential.
        /// </summary>
        [JsonPropertyName("keyCredential")]
        public KeyCredential KeyCredential { get; set; }
    
        /// <summary>
        /// Gets or sets PasswordCredential.
        /// </summary>
        [JsonPropertyName("passwordCredential")]
        public PasswordCredential PasswordCredential { get; set; }
    
        /// <summary>
        /// Gets or sets Proof.
        /// </summary>
        [JsonPropertyName("proof")]
        public string Proof { get; set; }
    
    }
}
