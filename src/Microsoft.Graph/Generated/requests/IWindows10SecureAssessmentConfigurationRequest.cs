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
    /// The interface IWindows10SecureAssessmentConfigurationRequest.
    /// </summary>
    public partial interface IWindows10SecureAssessmentConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10SecureAssessmentConfiguration using POST.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToCreate">The Windows10SecureAssessmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> CreateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Windows10SecureAssessmentConfiguration using POST and returns a <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToCreate">The Windows10SecureAssessmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10SecureAssessmentConfiguration>> CreateResponseAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Windows10SecureAssessmentConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Windows10SecureAssessmentConfiguration and returns a <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10SecureAssessmentConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> UpdateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PATCH and returns a <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10SecureAssessmentConfiguration>> UpdateResponseAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PUT.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> PutAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PUT and returns a <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Windows10SecureAssessmentConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10SecureAssessmentConfiguration>> PutResponseAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Expand(Expression<Func<Windows10SecureAssessmentConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Select(Expression<Func<Windows10SecureAssessmentConfiguration, object>> selectExpression);

    }
}
