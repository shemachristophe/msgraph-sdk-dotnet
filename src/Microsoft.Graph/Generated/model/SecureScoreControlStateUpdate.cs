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
    /// The type SecureScoreControlStateUpdate.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SecureScoreControlStateUpdate>))]
    public partial class SecureScoreControlStateUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureScoreControlStateUpdate"/> class.
        /// </summary>
        public SecureScoreControlStateUpdate()
        {
            this.ODataType = "microsoft.graph.secureScoreControlStateUpdate";
        }

        /// <summary>
        /// Gets or sets assignedTo.
        /// Assigns the control to the user who will take the action.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets comment.
        /// Provides optional comment about the control.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// State of the control, which can be modified via a PATCH command (for example, ignored, thirdParty).
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets updatedBy.
        /// ID of the user who updated tenant state.
        /// </summary>
        [JsonPropertyName("updatedBy")]
        public string UpdatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets updatedDateTime.
        /// Time at which the control state was updated.
        /// </summary>
        [JsonPropertyName("updatedDateTime")]
        public DateTimeOffset? UpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
