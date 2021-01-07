// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IDriveSearchCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<DriveSearchCollectionPage>))]
    public interface IDriveSearchCollectionPage : ICollectionPage<DriveItem>
    {
        /// <summary>
        /// Gets the next page <see cref="IDriveSearchRequest"/> instance.
        /// </summary>
        IDriveSearchRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
