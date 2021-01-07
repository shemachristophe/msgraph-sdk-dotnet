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
    /// The type User Install State Summary.
    /// </summary>
    
    public partial class UserInstallStateSummary : Entity
    {
    
		///<summary>
		/// The UserInstallStateSummary constructor
		///</summary>
        public UserInstallStateSummary()
        {
            this.ODataType = "microsoft.graph.userInstallStateSummary";
        }
	
        /// <summary>
        /// Gets or sets failed device count.
        /// Failed Device Count.
        /// </summary>
        [JsonPropertyName("failedDeviceCount")]
        public Int32? FailedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets installed device count.
        /// Installed Device Count.
        /// </summary>
        [JsonPropertyName("installedDeviceCount")]
        public Int32? InstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed device count.
        /// Not installed device count.
        /// </summary>
        [JsonPropertyName("notInstalledDeviceCount")]
        public Int32? NotInstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// User name.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets device states.
        /// The install state of the eBook.
        /// </summary>
        [JsonPropertyName("deviceStates")]
        public IUserInstallStateSummaryDeviceStatesCollectionPage DeviceStates { get; set; }
    
    }
}

