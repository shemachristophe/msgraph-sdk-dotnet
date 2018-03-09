// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedAppRegistrationRequest.
    /// </summary>
    public partial class ManagedAppRegistrationRequest : BaseRequest, IManagedAppRegistrationRequest
    {
        /// <summary>
        /// Constructs a new ManagedAppRegistrationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedAppRegistrationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate)
        {
            return this.CreateAsync(managedAppRegistrationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The ManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <returns>The updated ManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate)
        {
            return this.UpdateAsync(managedAppRegistrationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Expand(Expression<Func<ManagedAppRegistration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Select(Expression<Func<ManagedAppRegistration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="managedAppRegistrationToInitialize">The <see cref="ManagedAppRegistration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedAppRegistration managedAppRegistrationToInitialize)
        {

            if (managedAppRegistrationToInitialize != null && managedAppRegistrationToInitialize.AdditionalData != null)
            {

                if (managedAppRegistrationToInitialize.AppliedPolicies != null && managedAppRegistrationToInitialize.AppliedPolicies.CurrentPage != null)
                {
                    managedAppRegistrationToInitialize.AppliedPolicies.AdditionalData = managedAppRegistrationToInitialize.AdditionalData;

                    object nextPageLink;
                    managedAppRegistrationToInitialize.AdditionalData.TryGetValue("appliedPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedAppRegistrationToInitialize.AppliedPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (managedAppRegistrationToInitialize.IntendedPolicies != null && managedAppRegistrationToInitialize.IntendedPolicies.CurrentPage != null)
                {
                    managedAppRegistrationToInitialize.IntendedPolicies.AdditionalData = managedAppRegistrationToInitialize.AdditionalData;

                    object nextPageLink;
                    managedAppRegistrationToInitialize.AdditionalData.TryGetValue("intendedPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedAppRegistrationToInitialize.IntendedPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (managedAppRegistrationToInitialize.Operations != null && managedAppRegistrationToInitialize.Operations.CurrentPage != null)
                {
                    managedAppRegistrationToInitialize.Operations.AdditionalData = managedAppRegistrationToInitialize.AdditionalData;

                    object nextPageLink;
                    managedAppRegistrationToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        managedAppRegistrationToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
