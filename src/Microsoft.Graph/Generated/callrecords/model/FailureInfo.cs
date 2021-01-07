// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type FailureInfo.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<FailureInfo>))]
    public partial class FailureInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailureInfo"/> class.
        /// </summary>
        public FailureInfo()
        {
            this.ODataType = "microsoft.graph.callRecords.failureInfo";
        }

        /// <summary>
        /// Gets or sets reason.
        /// Classification of why a call or portion of a call failed.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or sets stage.
        /// The stage when the failure occurred. Possible values are: unknown, callSetup, midcall, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("stage")]
        public FailureStage? Stage { get; set; }
    
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
