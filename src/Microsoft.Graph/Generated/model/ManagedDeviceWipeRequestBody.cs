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
    /// The type ManagedDeviceWipeRequestBody.
    /// </summary>
    
    public partial class ManagedDeviceWipeRequestBody
    {
    
        /// <summary>
        /// Gets or sets KeepEnrollmentData.
        /// </summary>
        [JsonPropertyName("keepEnrollmentData")]
        public bool? KeepEnrollmentData { get; set; }
    
        /// <summary>
        /// Gets or sets KeepUserData.
        /// </summary>
        [JsonPropertyName("keepUserData")]
        public bool? KeepUserData { get; set; }
    
        /// <summary>
        /// Gets or sets MacOsUnlockCode.
        /// </summary>
        [JsonPropertyName("macOsUnlockCode")]
        public string MacOsUnlockCode { get; set; }
    
    }
}
