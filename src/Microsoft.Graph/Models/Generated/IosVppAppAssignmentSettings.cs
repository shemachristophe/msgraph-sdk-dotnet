// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosVppAppAssignmentSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosVppAppAssignmentSettings : MobileAppAssignmentSettings
    {
    
        /// <summary>
        /// Gets or sets useDeviceLicensing.
        /// Whether or not to use device licensing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useDeviceLicensing", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseDeviceLicensing { get; set; }
    
        /// <summary>
        /// Gets or sets vpnConfigurationId.
        /// The VPN Configuration Id to apply for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vpnConfigurationId", Required = Newtonsoft.Json.Required.Default)]
        public string VpnConfigurationId { get; set; }
    
    }
}
