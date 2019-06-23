// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ResourceLinksOperations.
    /// </summary>
    public static partial class ResourceLinksOperationsExtensions
    {
            /// <summary>
            /// Deletes a resource link with the specified ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified ID of the resource link. Use the format,
            /// /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}.
            /// For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            public static void Delete(this IResourceLinksOperations operations, string linkId)
            {
                operations.DeleteAsync(linkId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a resource link with the specified ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified ID of the resource link. Use the format,
            /// /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}.
            /// For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IResourceLinksOperations operations, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(linkId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a resource link between the specified resources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified ID of the resource link. Use the format,
            /// /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}.
            /// For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='parameters'>
            /// Parameters for creating or updating a resource link.
            /// </param>
            public static ResourceLink CreateOrUpdate(this IResourceLinksOperations operations, string linkId, ResourceLink parameters)
            {
                return operations.CreateOrUpdateAsync(linkId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a resource link between the specified resources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified ID of the resource link. Use the format,
            /// /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}.
            /// For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='parameters'>
            /// Parameters for creating or updating a resource link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceLink> CreateOrUpdateAsync(this IResourceLinksOperations operations, string linkId, ResourceLink parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(linkId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a resource link with the specified ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            public static ResourceLink Get(this IResourceLinksOperations operations, string linkId)
            {
                return operations.GetAsync(linkId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a resource link with the specified ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceLink> GetAsync(this IResourceLinksOperations operations, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(linkId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the linked resources for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSubscription(this IResourceLinksOperations operations, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>))
            {
                return operations.ListAtSubscriptionAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the linked resources for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSubscriptionAsync(this IResourceLinksOperations operations, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSubscriptionWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The fully qualified ID of the scope for getting the resource links. For
            /// example, to list resource links at and under a resource group, set the
            /// scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSourceScope(this IResourceLinksOperations operations, string scope, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>))
            {
                return operations.ListAtSourceScopeAsync(scope, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The fully qualified ID of the scope for getting the resource links. For
            /// example, to list resource links at and under a resource group, set the
            /// scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSourceScopeAsync(this IResourceLinksOperations operations, string scope, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSourceScopeWithHttpMessagesAsync(scope, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the linked resources for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSubscriptionNext(this IResourceLinksOperations operations, string nextPageLink)
            {
                return operations.ListAtSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the linked resources for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSubscriptionNextAsync(this IResourceLinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSourceScopeNext(this IResourceLinksOperations operations, string nextPageLink)
            {
                return operations.ListAtSourceScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSourceScopeNextAsync(this IResourceLinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSourceScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}