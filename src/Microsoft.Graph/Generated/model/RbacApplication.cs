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
    /// The type Rbac Application.
    /// </summary>
    public partial class RbacApplication : Entity
    {
    
        /// <summary>
        /// Gets or sets role assignments.
        /// Resource to grant access to users or groups.
        /// </summary>
        [JsonPropertyName("roleAssignments")]
        public IRbacApplicationRoleAssignmentsCollectionPage RoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets roleAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("roleAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleAssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.
        /// </summary>
        [JsonPropertyName("roleDefinitions")]
        public IRbacApplicationRoleDefinitionsCollectionPage RoleDefinitions { get; set; }

        /// <summary>
        /// Gets or sets roleDefinitionsNextLink.
        /// </summary>
        [JsonPropertyName("roleDefinitions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleDefinitionsNextLink { get; set; }
    
    }
}

