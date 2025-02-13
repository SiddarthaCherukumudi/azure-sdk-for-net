// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AgriculturePlatform.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAgriculturePlatformResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAgriculturePlatformResourceGroupResource"/> class for mocking. </summary>
        protected MockableAgriculturePlatformResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAgriculturePlatformResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAgriculturePlatformResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AgriServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AgriServiceResources and their operations over a AgriServiceResource. </returns>
        public virtual AgriServiceResourceCollection GetAgriServiceResources()
        {
            return GetCachedClient(client => new AgriServiceResourceCollection(client, Id));
        }

        /// <summary>
        /// Get a AgriServiceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgriculturePlatform/agriServices/{agriServiceResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgriServiceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgriServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agriServiceResourceName"> The name of the AgriService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agriServiceResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agriServiceResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AgriServiceResource>> GetAgriServiceResourceAsync(string agriServiceResourceName, CancellationToken cancellationToken = default)
        {
            return await GetAgriServiceResources().GetAsync(agriServiceResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a AgriServiceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgriculturePlatform/agriServices/{agriServiceResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgriServiceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgriServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agriServiceResourceName"> The name of the AgriService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agriServiceResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agriServiceResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AgriServiceResource> GetAgriServiceResource(string agriServiceResourceName, CancellationToken cancellationToken = default)
        {
            return GetAgriServiceResources().Get(agriServiceResourceName, cancellationToken);
        }
    }
}
