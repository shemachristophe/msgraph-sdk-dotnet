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
    /// The type IosNetworkUsageRule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosNetworkUsageRule>))]
    public partial class IosNetworkUsageRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosNetworkUsageRule"/> class.
        /// </summary>
        public IosNetworkUsageRule()
        {
            this.ODataType = "microsoft.graph.iosNetworkUsageRule";
        }

        /// <summary>
        /// Gets or sets cellularDataBlocked.
        /// If set to true, corresponding managed apps will not be allowed to use cellular data at any time.
        /// </summary>
        [JsonPropertyName("cellularDataBlocked")]
        public bool? CellularDataBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets cellularDataBlockWhenRoaming.
        /// If set to true, corresponding managed apps will not be allowed to use cellular data when roaming.
        /// </summary>
        [JsonPropertyName("cellularDataBlockWhenRoaming")]
        public bool? CellularDataBlockWhenRoaming { get; set; }
    
        /// <summary>
        /// Gets or sets managedApps.
        /// Information about the managed apps that this rule is going to apply to. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("managedApps")]
        public IEnumerable<AppListItem> ManagedApps { get; set; }
    
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
