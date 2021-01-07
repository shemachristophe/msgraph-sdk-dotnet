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
    /// The type EdgeSearchEngine.
    /// </summary>
    
    public partial class EdgeSearchEngine : EdgeSearchEngineBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeSearchEngine"/> class.
        /// </summary>
        public EdgeSearchEngine()
        {
            this.ODataType = "microsoft.graph.edgeSearchEngine";
        }

        /// <summary>
        /// Gets or sets edgeSearchEngineType.
        /// Allows IT admins to set a predefined default search engine for MDM-Controlled devices. Possible values are: default, bing.
        /// </summary>
        [JsonPropertyName("edgeSearchEngineType")]
        public EdgeSearchEngineType? EdgeSearchEngineType { get; set; }
    
    }
}
