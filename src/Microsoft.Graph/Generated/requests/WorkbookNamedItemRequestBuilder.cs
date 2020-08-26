// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookNamedItemRequestBuilder.
    /// </summary>
    public partial class WorkbookNamedItemRequestBuilder : EntityRequestBuilder, IWorkbookNamedItemRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookNamedItemRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookNamedItemRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookNamedItemRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookNamedItemRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookNamedItemRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Worksheet.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        public IWorkbookWorksheetRequestBuilder Worksheet
        {
            get
            {
                return new WorkbookWorksheetRequestBuilder(this.AppendSegmentToRequestUrl("worksheet"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookNamedItemRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookNamedItemRangeRequestBuilder"/>.</returns>
        public IWorkbookNamedItemRangeRequestBuilder Range()
        {
            return new WorkbookNamedItemRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.range"),
                this.Client);
        }
    
    }
}