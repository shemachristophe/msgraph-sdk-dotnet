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
    /// The type ConditionalAccessLocations.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessLocations>))]
    public partial class ConditionalAccessLocations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessLocations"/> class.
        /// </summary>
        public ConditionalAccessLocations()
        {
            this.ODataType = "microsoft.graph.conditionalAccessLocations";
        }

        /// <summary>
        /// Gets or sets excludeLocations.
        /// Location IDs excluded from scope of policy.
        /// </summary>
        [JsonPropertyName("excludeLocations")]
        public IEnumerable<string> ExcludeLocations { get; set; }
    
        /// <summary>
        /// Gets or sets includeLocations.
        /// Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
        /// </summary>
        [JsonPropertyName("includeLocations")]
        public IEnumerable<string> IncludeLocations { get; set; }
    
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
