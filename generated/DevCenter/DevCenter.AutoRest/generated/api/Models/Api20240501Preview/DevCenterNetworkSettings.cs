// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Network settings for the Dev Center.</summary>
    public partial class DevCenterNetworkSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterNetworkSettings,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterNetworkSettingsInternal
    {

        /// <summary>Backing field for <see cref="MicrosoftHostedNetworkEnableStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.MicrosoftHostedNetworkEnableStatus? _microsoftHostedNetworkEnableStatus;

        /// <summary>
        /// Indicates whether pools in this Dev Center can use Microsoft Hosted Networks. Defaults to Enabled if not set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.MicrosoftHostedNetworkEnableStatus? MicrosoftHostedNetworkEnableStatus { get => this._microsoftHostedNetworkEnableStatus; set => this._microsoftHostedNetworkEnableStatus = value; }

        /// <summary>Creates an new <see cref="DevCenterNetworkSettings" /> instance.</summary>
        public DevCenterNetworkSettings()
        {

        }
    }
    /// Network settings for the Dev Center.
    public partial interface IDevCenterNetworkSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates whether pools in this Dev Center can use Microsoft Hosted Networks. Defaults to Enabled if not set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether pools in this Dev Center can use Microsoft Hosted Networks. Defaults to Enabled if not set.",
        SerializedName = @"microsoftHostedNetworkEnableStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.MicrosoftHostedNetworkEnableStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.MicrosoftHostedNetworkEnableStatus? MicrosoftHostedNetworkEnableStatus { get; set; }

    }
    /// Network settings for the Dev Center.
    internal partial interface IDevCenterNetworkSettingsInternal

    {
        /// <summary>
        /// Indicates whether pools in this Dev Center can use Microsoft Hosted Networks. Defaults to Enabled if not set.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.MicrosoftHostedNetworkEnableStatus? MicrosoftHostedNetworkEnableStatus { get; set; }

    }
}