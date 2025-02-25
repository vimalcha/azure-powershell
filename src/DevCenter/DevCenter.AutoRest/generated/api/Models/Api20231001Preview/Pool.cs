// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>A pool of Virtual Machines.</summary>
    public partial class Pool :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPool,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.TrackedResource();

        /// <summary>Indicates the number of provisioned Dev Boxes in this pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public int? DevBoxCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).DevBoxCount; }

        /// <summary>Name of a Dev Box definition in parent Project of this Pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string DevBoxDefinitionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).DevBoxDefinitionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).DevBoxDefinitionName = value ?? null; }

        /// <summary>The display name of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>
        /// Overall health status of the Pool. Indicates whether or not the Pool is available to create Dev Boxes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthStatus? HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).HealthStatus; }

        /// <summary>
        /// Details on the Pool health status to help diagnose issues. This is only populated when the pool status indicates the pool
        /// is in a non-healthy state
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IHealthStatusDetail[] HealthStatusDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).HealthStatusDetail; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Id; }

        /// <summary>
        /// Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType? LicenseType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).LicenseType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).LicenseType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType)""); }

        /// <summary>
        /// Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus? LocalAdministrator { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).LocalAdministrator; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).LocalAdministrator = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus)""); }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>
        /// The regions of the managed virtual network (required when managedNetworkType is Managed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string[] ManagedVirtualNetworkRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).ManagedVirtualNetworkRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).ManagedVirtualNetworkRegion = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DevBoxCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal.DevBoxCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).DevBoxCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).DevBoxCount = value; }

        /// <summary>Internal Acessors for HealthStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthStatus? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal.HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).HealthStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).HealthStatus = value; }

        /// <summary>Internal Acessors for HealthStatusDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IHealthStatusDetail[] Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal.HealthStatusDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).HealthStatusDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).HealthStatusDetail = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolProperties Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.PoolProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for StopOnDisconnect</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IStopOnDisconnectConfiguration Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolInternal.StopOnDisconnect { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).StopOnDisconnect; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).StopOnDisconnect = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Name; }

        /// <summary>Name of a Network Connection in parent Project of this Pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string NetworkConnectionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).NetworkConnectionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).NetworkConnectionName = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolProperties _property;

        /// <summary>Pool properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.PoolProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Indicates whether Dev Boxes in this pool are created with single sign on enabled. The also requires that single sign on
        /// be enabled on the tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus? SingleSignOnStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).SingleSignOnStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).SingleSignOnStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus)""); }

        /// <summary>
        /// The specified time in minutes to wait before stopping a Dev Box once disconnect is detected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public int? StopOnDisconnectGracePeriodMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).StopOnDisconnectGracePeriodMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).StopOnDisconnectGracePeriodMinute = value ?? default(int); }

        /// <summary>
        /// Whether the feature to stop the Dev Box on disconnect once the grace period has lapsed is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus? StopOnDisconnectStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).StopOnDisconnectStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).StopOnDisconnectStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus)""); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)__trackedResource).Type; }

        /// <summary>
        /// Indicates whether the pool uses a Virtual Network managed by Microsoft or a customer provided network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType? VirtualNetworkType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).VirtualNetworkType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolUpdatePropertiesInternal)Property).VirtualNetworkType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType)""); }

        /// <summary>Creates an new <see cref="Pool" /> instance.</summary>
        public Pool()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// A pool of Virtual Machines.
    public partial interface IPool :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResource
    {
        /// <summary>Indicates the number of provisioned Dev Boxes in this pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the number of provisioned Dev Boxes in this pool.",
        SerializedName = @"devBoxCount",
        PossibleTypes = new [] { typeof(int) })]
        int? DevBoxCount { get;  }
        /// <summary>Name of a Dev Box definition in parent Project of this Pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of a Dev Box definition in parent Project of this Pool",
        SerializedName = @"devBoxDefinitionName",
        PossibleTypes = new [] { typeof(string) })]
        string DevBoxDefinitionName { get; set; }
        /// <summary>The display name of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the pool.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Overall health status of the Pool. Indicates whether or not the Pool is available to create Dev Boxes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Overall health status of the Pool. Indicates whether or not the Pool is available to create Dev Boxes.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthStatus? HealthStatus { get;  }
        /// <summary>
        /// Details on the Pool health status to help diagnose issues. This is only populated when the pool status indicates the pool
        /// is in a non-healthy state
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Details on the Pool health status to help diagnose issues. This is only populated when the pool status indicates the pool is in a non-healthy state",
        SerializedName = @"healthStatusDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IHealthStatusDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IHealthStatusDetail[] HealthStatusDetail { get;  }
        /// <summary>
        /// Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType? LicenseType { get; set; }
        /// <summary>
        /// Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box.",
        SerializedName = @"localAdministrator",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus? LocalAdministrator { get; set; }
        /// <summary>
        /// The regions of the managed virtual network (required when managedNetworkType is Managed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The regions of the managed virtual network (required when managedNetworkType is Managed).",
        SerializedName = @"managedVirtualNetworkRegions",
        PossibleTypes = new [] { typeof(string) })]
        string[] ManagedVirtualNetworkRegion { get; set; }
        /// <summary>Name of a Network Connection in parent Project of this Pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of a Network Connection in parent Project of this Pool",
        SerializedName = @"networkConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkConnectionName { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Indicates whether Dev Boxes in this pool are created with single sign on enabled. The also requires that single sign on
        /// be enabled on the tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether Dev Boxes in this pool are created with single sign on enabled. The also requires that single sign on be enabled on the tenant.",
        SerializedName = @"singleSignOnStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus? SingleSignOnStatus { get; set; }
        /// <summary>
        /// The specified time in minutes to wait before stopping a Dev Box once disconnect is detected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The specified time in minutes to wait before stopping a Dev Box once disconnect is detected.",
        SerializedName = @"gracePeriodMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? StopOnDisconnectGracePeriodMinute { get; set; }
        /// <summary>
        /// Whether the feature to stop the Dev Box on disconnect once the grace period has lapsed is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the feature to stop the Dev Box on disconnect once the grace period has lapsed is enabled.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus? StopOnDisconnectStatus { get; set; }
        /// <summary>
        /// Indicates whether the pool uses a Virtual Network managed by Microsoft or a customer provided network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the pool uses a Virtual Network managed by Microsoft or a customer provided network.",
        SerializedName = @"virtualNetworkType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType? VirtualNetworkType { get; set; }

    }
    /// A pool of Virtual Machines.
    internal partial interface IPoolInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal
    {
        /// <summary>Indicates the number of provisioned Dev Boxes in this pool.</summary>
        int? DevBoxCount { get; set; }
        /// <summary>Name of a Dev Box definition in parent Project of this Pool</summary>
        string DevBoxDefinitionName { get; set; }
        /// <summary>The display name of the pool.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Overall health status of the Pool. Indicates whether or not the Pool is available to create Dev Boxes.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthStatus? HealthStatus { get; set; }
        /// <summary>
        /// Details on the Pool health status to help diagnose issues. This is only populated when the pool status indicates the pool
        /// is in a non-healthy state
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IHealthStatusDetail[] HealthStatusDetail { get; set; }
        /// <summary>
        /// Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType? LicenseType { get; set; }
        /// <summary>
        /// Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus? LocalAdministrator { get; set; }
        /// <summary>
        /// The regions of the managed virtual network (required when managedNetworkType is Managed).
        /// </summary>
        string[] ManagedVirtualNetworkRegion { get; set; }
        /// <summary>Name of a Network Connection in parent Project of this Pool</summary>
        string NetworkConnectionName { get; set; }
        /// <summary>Pool properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IPoolProperties Property { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Indicates whether Dev Boxes in this pool are created with single sign on enabled. The also requires that single sign on
        /// be enabled on the tenant.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus? SingleSignOnStatus { get; set; }
        /// <summary>Stop on disconnect configuration settings for Dev Boxes created in this pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IStopOnDisconnectConfiguration StopOnDisconnect { get; set; }
        /// <summary>
        /// The specified time in minutes to wait before stopping a Dev Box once disconnect is detected.
        /// </summary>
        int? StopOnDisconnectGracePeriodMinute { get; set; }
        /// <summary>
        /// Whether the feature to stop the Dev Box on disconnect once the grace period has lapsed is enabled.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus? StopOnDisconnectStatus { get; set; }
        /// <summary>
        /// Indicates whether the pool uses a Virtual Network managed by Microsoft or a customer provided network.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType? VirtualNetworkType { get; set; }

    }
}