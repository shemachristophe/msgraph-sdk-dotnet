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
    /// The type Ip Named Location.
    /// </summary>
    
    public partial class IpNamedLocation : NamedLocation
    {
    
		///<summary>
		/// The IpNamedLocation constructor
		///</summary>
        public IpNamedLocation()
        {
            this.ODataType = "microsoft.graph.ipNamedLocation";
        }
	
        /// <summary>
        /// Gets or sets ip ranges.
        /// List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596.
        /// </summary>
        [JsonPropertyName("ipRanges")]
        public IEnumerable<IpRange> IpRanges { get; set; }
    
        /// <summary>
        /// Gets or sets is trusted.
        /// True if this location is explicitly trusted.
        /// </summary>
        [JsonPropertyName("isTrusted")]
        public bool? IsTrusted { get; set; }
    
    }
}

