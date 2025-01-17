// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsInformationProtectionPolicyRequest.
    /// </summary>
    public partial interface IWindowsInformationProtectionPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsInformationProtectionPolicy using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionPolicyToCreate">The WindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionPolicy> CreateAsync(WindowsInformationProtectionPolicy windowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WindowsInformationProtectionPolicy using POST and returns a <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionPolicyToCreate">The WindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionPolicy>> CreateResponseAsync(WindowsInformationProtectionPolicy windowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsInformationProtectionPolicy and returns a <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionPolicy using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionPolicyToUpdate">The WindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionPolicy> UpdateAsync(WindowsInformationProtectionPolicy windowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionPolicy using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionPolicyToUpdate">The WindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionPolicy>> UpdateResponseAsync(WindowsInformationProtectionPolicy windowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionPolicy using PUT.
        /// </summary>
        /// <param name="windowsInformationProtectionPolicyToUpdate">The WindowsInformationProtectionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionPolicy> PutAsync(WindowsInformationProtectionPolicy windowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionPolicy using PUT and returns a <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionPolicyToUpdate">The WindowsInformationProtectionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsInformationProtectionPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionPolicy>> PutResponseAsync(WindowsInformationProtectionPolicy windowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionPolicyRequest Expand(Expression<Func<WindowsInformationProtectionPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionPolicyRequest Select(Expression<Func<WindowsInformationProtectionPolicy, object>> selectExpression);

    }
}
