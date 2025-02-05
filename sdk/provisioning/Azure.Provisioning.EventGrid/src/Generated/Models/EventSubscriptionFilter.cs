// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Filter for the Event Subscription.
/// </summary>
public partial class EventSubscriptionFilter : ProvisionableConstruct
{
    /// <summary>
    /// An optional string to filter events for an event subscription based on
    /// a resource path prefix.             The format of this depends on the
    /// publisher of the events.             Wildcard characters are not
    /// supported in this path.
    /// </summary>
    public BicepValue<string> SubjectBeginsWith { get => _subjectBeginsWith; set => _subjectBeginsWith.Assign(value); }
    private readonly BicepValue<string> _subjectBeginsWith;

    /// <summary>
    /// An optional string to filter events for an event subscription based on
    /// a resource path suffix.             Wildcard characters are not
    /// supported in this path.
    /// </summary>
    public BicepValue<string> SubjectEndsWith { get => _subjectEndsWith; set => _subjectEndsWith.Assign(value); }
    private readonly BicepValue<string> _subjectEndsWith;

    /// <summary>
    /// A list of applicable event types that need to be part of the event
    /// subscription. If it is desired to subscribe to all default event
    /// types, set the IncludedEventTypes to null.
    /// </summary>
    public BicepList<string> IncludedEventTypes { get => _includedEventTypes; set => _includedEventTypes.Assign(value); }
    private readonly BicepList<string> _includedEventTypes;

    /// <summary>
    /// Specifies if the SubjectBeginsWith and SubjectEndsWith properties of
    /// the filter             should be compared in a case sensitive manner.
    /// </summary>
    public BicepValue<bool> IsSubjectCaseSensitive { get => _isSubjectCaseSensitive; set => _isSubjectCaseSensitive.Assign(value); }
    private readonly BicepValue<bool> _isSubjectCaseSensitive;

    /// <summary>
    /// Allows advanced filters to be evaluated against an array of values
    /// instead of expecting a singular value.
    /// </summary>
    public BicepValue<bool> IsAdvancedFilteringOnArraysEnabled { get => _isAdvancedFilteringOnArraysEnabled; set => _isAdvancedFilteringOnArraysEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAdvancedFilteringOnArraysEnabled;

    /// <summary>
    /// An array of advanced filters that are used for filtering event
    /// subscriptions.             Please note
    /// Azure.ResourceManager.EventGrid.Models.AdvancedFilter is the base
    /// class. According to the scenario, a derived class of the base class
    /// might need to be assigned here, or this property needs to be casted to
    /// one of the possible derived classes.             The available derived
    /// classes include
    /// Azure.ResourceManager.EventGrid.Models.BoolEqualsAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.IsNotNullAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.IsNullOrUndefinedAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberGreaterThanAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberGreaterThanOrEqualsAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberInAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberInRangeAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberLessThanAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberLessThanOrEqualsAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberNotInAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.NumberNotInRangeAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringBeginsWithAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringContainsAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringEndsWithAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringInAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringNotBeginsWithAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringNotContainsAdvancedFilter,
    /// Azure.ResourceManager.EventGrid.Models.StringNotEndsWithAdvancedFilter
    /// and Azure.ResourceManager.EventGrid.Models.StringNotInAdvancedFilter.
    /// </summary>
    public BicepList<AdvancedFilter> AdvancedFilters { get => _advancedFilters; set => _advancedFilters.Assign(value); }
    private readonly BicepList<AdvancedFilter> _advancedFilters;

    /// <summary>
    /// Creates a new EventSubscriptionFilter.
    /// </summary>
    public EventSubscriptionFilter()
    {
        _subjectBeginsWith = BicepValue<string>.DefineProperty(this, "SubjectBeginsWith", ["subjectBeginsWith"]);
        _subjectEndsWith = BicepValue<string>.DefineProperty(this, "SubjectEndsWith", ["subjectEndsWith"]);
        _includedEventTypes = BicepList<string>.DefineProperty(this, "IncludedEventTypes", ["includedEventTypes"]);
        _isSubjectCaseSensitive = BicepValue<bool>.DefineProperty(this, "IsSubjectCaseSensitive", ["isSubjectCaseSensitive"]);
        _isAdvancedFilteringOnArraysEnabled = BicepValue<bool>.DefineProperty(this, "IsAdvancedFilteringOnArraysEnabled", ["enableAdvancedFilteringOnArrays"]);
        _advancedFilters = BicepList<AdvancedFilter>.DefineProperty(this, "AdvancedFilters", ["advancedFilters"]);
    }
}
