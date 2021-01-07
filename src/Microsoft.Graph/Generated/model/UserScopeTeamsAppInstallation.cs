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
    /// The type User Scope Teams App Installation.
    /// </summary>
    
    public partial class UserScopeTeamsAppInstallation : TeamsAppInstallation
    {
    
		///<summary>
		/// The UserScopeTeamsAppInstallation constructor
		///</summary>
        public UserScopeTeamsAppInstallation()
        {
            this.ODataType = "microsoft.graph.userScopeTeamsAppInstallation";
        }
	
        /// <summary>
        /// Gets or sets chat.
        /// The chat between the user and Teams app.
        /// </summary>
        [JsonPropertyName("chat")]
        public Chat Chat { get; set; }
    
    }
}

