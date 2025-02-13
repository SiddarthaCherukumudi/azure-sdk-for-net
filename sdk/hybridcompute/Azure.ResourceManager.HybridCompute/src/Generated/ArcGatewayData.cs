// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the ArcGateway data model.
    /// Describes an Arc Gateway.
    /// </summary>
    public partial class ArcGatewayData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArcGatewayData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ArcGatewayData(AzureLocation location) : base(location)
        {
            AllowedFeatures = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ArcGatewayData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="gatewayId"> A unique, immutable, identifier for the Gateway. </param>
        /// <param name="gatewayType"> The type of the Gateway resource. </param>
        /// <param name="gatewayEndpoint"> The endpoint fqdn for the Gateway. </param>
        /// <param name="allowedFeatures"> Specifies the list of features that are enabled for this Gateway. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArcGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HybridComputeProvisioningState? provisioningState, ResourceIdentifier gatewayId, ArcGatewayType? gatewayType, string gatewayEndpoint, IList<string> allowedFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            GatewayId = gatewayId;
            GatewayType = gatewayType;
            GatewayEndpoint = gatewayEndpoint;
            AllowedFeatures = allowedFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ArcGatewayData"/> for deserialization. </summary>
        internal ArcGatewayData()
        {
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        [WirePath("properties.provisioningState")]
        public HybridComputeProvisioningState? ProvisioningState { get; }
        /// <summary> A unique, immutable, identifier for the Gateway. </summary>
        [WirePath("properties.gatewayId")]
        public ResourceIdentifier GatewayId { get; }
        /// <summary> The type of the Gateway resource. </summary>
        [WirePath("properties.gatewayType")]
        public ArcGatewayType? GatewayType { get; set; }
        /// <summary> The endpoint fqdn for the Gateway. </summary>
        [WirePath("properties.gatewayEndpoint")]
        public string GatewayEndpoint { get; }
        /// <summary> Specifies the list of features that are enabled for this Gateway. </summary>
        [WirePath("properties.allowedFeatures")]
        public IList<string> AllowedFeatures { get; }
    }
}
