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
    /// The type Windows Information Protection App Locker File.
    /// </summary>
    
    public partial class WindowsInformationProtectionAppLockerFile : Entity
    {
    
		///<summary>
		/// The WindowsInformationProtectionAppLockerFile constructor
		///</summary>
        public WindowsInformationProtectionAppLockerFile()
        {
            this.ODataType = "microsoft.graph.windowsInformationProtectionAppLockerFile";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The friendly name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets file.
        /// File as a byte array
        /// </summary>
        [JsonPropertyName("file")]
        public byte[] File { get; set; }
    
        /// <summary>
        /// Gets or sets file hash.
        /// SHA256 hash of the file
        /// </summary>
        [JsonPropertyName("fileHash")]
        public string FileHash { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the entity.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

