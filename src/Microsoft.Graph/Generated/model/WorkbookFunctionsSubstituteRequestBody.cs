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
    /// The type WorkbookFunctionsSubstituteRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsSubstituteRequestBody
    {
    
        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonPropertyName("text")]
        public System.Text.Json.JsonDocument Text { get; set; }
    
        /// <summary>
        /// Gets or sets OldText.
        /// </summary>
        [JsonPropertyName("oldText")]
        public System.Text.Json.JsonDocument OldText { get; set; }
    
        /// <summary>
        /// Gets or sets NewText.
        /// </summary>
        [JsonPropertyName("newText")]
        public System.Text.Json.JsonDocument NewText { get; set; }
    
        /// <summary>
        /// Gets or sets InstanceNum.
        /// </summary>
        [JsonPropertyName("instanceNum")]
        public System.Text.Json.JsonDocument InstanceNum { get; set; }
    
    }
}
