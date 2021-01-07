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
    /// The type Role Definition.
    /// </summary>
    
    public partial class RoleDefinition : Entity
    {
    
		///<summary>
		/// The RoleDefinition constructor
		///</summary>
        public RoleDefinition()
        {
            this.ODataType = "microsoft.graph.roleDefinition";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// Description of the Role definition.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display Name of the Role definition.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is built in.
        /// Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
        /// </summary>
        [JsonPropertyName("isBuiltIn")]
        public bool? IsBuiltIn { get; set; }
    
        /// <summary>
        /// Gets or sets role permissions.
        /// List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
        /// </summary>
        [JsonPropertyName("rolePermissions")]
        public IEnumerable<RolePermission> RolePermissions { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// List of Role assignments for this role definition.
        /// </summary>
        [JsonPropertyName("roleAssignments")]
        public IRoleDefinitionRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
    }
}

