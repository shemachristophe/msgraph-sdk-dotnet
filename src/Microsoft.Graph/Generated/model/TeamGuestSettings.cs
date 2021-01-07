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
    /// The type TeamGuestSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamGuestSettings>))]
    public partial class TeamGuestSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamGuestSettings"/> class.
        /// </summary>
        public TeamGuestSettings()
        {
            this.ODataType = "microsoft.graph.teamGuestSettings";
        }

        /// <summary>
        /// Gets or sets allowCreateUpdateChannels.
        /// If set to true, guests can add and update channels.
        /// </summary>
        [JsonPropertyName("allowCreateUpdateChannels")]
        public bool? AllowCreateUpdateChannels { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteChannels.
        /// If set to true, guests can delete channels.
        /// </summary>
        [JsonPropertyName("allowDeleteChannels")]
        public bool? AllowDeleteChannels { get; set; }
    
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
