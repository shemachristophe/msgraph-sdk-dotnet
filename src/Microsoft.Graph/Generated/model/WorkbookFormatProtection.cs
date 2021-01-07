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
    /// The type Workbook Format Protection.
    /// </summary>
    
    public partial class WorkbookFormatProtection : Entity
    {
    
		///<summary>
		/// The WorkbookFormatProtection constructor
		///</summary>
        public WorkbookFormatProtection()
        {
            this.ODataType = "microsoft.graph.workbookFormatProtection";
        }
	
        /// <summary>
        /// Gets or sets formula hidden.
        /// Indicates if Excel hides the formula for the cells in the range. A null value indicates that the entire range doesn't have uniform formula hidden setting.
        /// </summary>
        [JsonPropertyName("formulaHidden")]
        public bool? FormulaHidden { get; set; }
    
        /// <summary>
        /// Gets or sets locked.
        /// Indicates if Excel locks the cells in the object. A null value indicates that the entire range doesn't have uniform lock setting.
        /// </summary>
        [JsonPropertyName("locked")]
        public bool? Locked { get; set; }
    
    }
}

