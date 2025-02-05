// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NamespaceTopicEventSubscription.
/// </summary>
public partial class NamespaceTopicEventSubscription : ProvisionableResource
{
    /// <summary>
    /// Name of the event subscription to be created. Event subscription names
    /// must be between 3 and 50 characters in length and use alphanumeric
    /// letters only.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Information about the delivery configuration of the event subscription.
    /// </summary>
    public BicepValue<DeliveryConfiguration> DeliveryConfiguration { get => _deliveryConfiguration; set => _deliveryConfiguration.Assign(value); }
    private readonly BicepValue<DeliveryConfiguration> _deliveryConfiguration;

    /// <summary>
    /// The event delivery schema for the event subscription.
    /// </summary>
    public BicepValue<DeliverySchema> EventDeliverySchema { get => _eventDeliverySchema; set => _eventDeliverySchema.Assign(value); }
    private readonly BicepValue<DeliverySchema> _eventDeliverySchema;

    /// <summary>
    /// Expiration time of the event subscription.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; set => _expireOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Information about the filter for the event subscription.
    /// </summary>
    public BicepValue<FiltersConfiguration> FiltersConfiguration { get => _filtersConfiguration; set => _filtersConfiguration.Assign(value); }
    private readonly BicepValue<FiltersConfiguration> _filtersConfiguration;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the event subscription.
    /// </summary>
    public BicepValue<SubscriptionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<SubscriptionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent NamespaceTopic.
    /// </summary>
    public NamespaceTopic? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<NamespaceTopic> _parent;

    /// <summary>
    /// Creates a new NamespaceTopicEventSubscription.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the NamespaceTopicEventSubscription
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the NamespaceTopicEventSubscription.</param>
    public NamespaceTopicEventSubscription(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/namespaces/topics/eventSubscriptions", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _deliveryConfiguration = BicepValue<DeliveryConfiguration>.DefineProperty(this, "DeliveryConfiguration", ["properties", "deliveryConfiguration"]);
        _eventDeliverySchema = BicepValue<DeliverySchema>.DefineProperty(this, "EventDeliverySchema", ["properties", "eventDeliverySchema"]);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["properties", "expirationTimeUtc"]);
        _filtersConfiguration = BicepValue<FiltersConfiguration>.DefineProperty(this, "FiltersConfiguration", ["properties", "filtersConfiguration"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<SubscriptionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<NamespaceTopic>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing NamespaceTopicEventSubscription.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the NamespaceTopicEventSubscription
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the NamespaceTopicEventSubscription.</param>
    /// <returns>The existing NamespaceTopicEventSubscription resource.</returns>
    public static NamespaceTopicEventSubscription FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
