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
    /// The type Workforce Integration.
    /// </summary>
    
    public partial class WorkforceIntegration : ChangeTrackedEntity
    {
    
		///<summary>
		/// The WorkforceIntegration constructor
		///</summary>
        public WorkforceIntegration()
        {
            this.ODataType = "microsoft.graph.workforceIntegration";
        }
	
        /// <summary>
        /// Gets or sets api version.
        /// API version for the call back URL. Start with 1.
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public Int32? ApiVersion { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the workforce integration.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets encryption.
        /// The workforce integration encryption resource.
        /// </summary>
        [JsonPropertyName("encryption")]
        public WorkforceIntegrationEncryption Encryption { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// Indicates whether this workforce integration is currently active and available.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets supported entities.
        /// The Shifts entities supported for synchronous change notifications. Shifts will make a call back to the url provided on client changes on those entities added here. By default, no entities are supported for change notifications. Possible values are: none, shift, swapRequest, openshift, openShiftRequest, userShiftPreferences
        /// </summary>
        [JsonPropertyName("supportedEntities")]
        public WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// Workforce Integration URL for callbacks from the Shifts service.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    }
}

