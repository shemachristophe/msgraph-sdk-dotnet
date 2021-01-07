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
    /// The type ChatMessagePolicyViolationPolicyTip.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChatMessagePolicyViolationPolicyTip>))]
    public partial class ChatMessagePolicyViolationPolicyTip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagePolicyViolationPolicyTip"/> class.
        /// </summary>
        public ChatMessagePolicyViolationPolicyTip()
        {
            this.ODataType = "microsoft.graph.chatMessagePolicyViolationPolicyTip";
        }

        /// <summary>
        /// Gets or sets complianceUrl.
        /// The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what users shouldn't say in chats)
        /// </summary>
        [JsonPropertyName("complianceUrl")]
        public string ComplianceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets generalText.
        /// Explanatory text shown to the sender of the message.
        /// </summary>
        [JsonPropertyName("generalText")]
        public string GeneralText { get; set; }
    
        /// <summary>
        /// Gets or sets matchedConditionDescriptions.
        /// The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own conditions, examples include 'Credit Card Number' and 'Social Security Number'.
        /// </summary>
        [JsonPropertyName("matchedConditionDescriptions")]
        public IEnumerable<string> MatchedConditionDescriptions { get; set; }
    
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
