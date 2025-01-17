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
    /// The type GroupAssignmentTarget.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<GroupAssignmentTarget>))]
    public partial class GroupAssignmentTarget : DeviceAndAppManagementAssignmentTarget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAssignmentTarget"/> class.
        /// </summary>
        public GroupAssignmentTarget()
        {
            this.ODataType = "microsoft.graph.groupAssignmentTarget";
        }

        /// <summary>
        /// Gets or sets groupId.
        /// The group Id that is the target of the assignment.
        /// </summary>
        [JsonPropertyName("groupId")]
        public string GroupId { get; set; }
    
    }
}
