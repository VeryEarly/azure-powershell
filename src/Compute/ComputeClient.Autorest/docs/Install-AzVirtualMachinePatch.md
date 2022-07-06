---
external help file:
Module Name: Az.ComputeClient
online version: https://docs.microsoft.com/powershell/module/az.computeclient/install-azvirtualmachinepatch
schema: 2.0.0
---

# Install-AzVirtualMachinePatch

## SYNOPSIS
Installs patches on the VM.

## SYNTAX

### InstallExpanded (Default)
```
Install-AzVirtualMachinePatch -ResourceGroupName <String> -VMName <String>
 -RebootSetting <VMGuestPatchRebootSetting> [-SubscriptionId <String>]
 [-LinuxParameterClassificationsToInclude <VMGuestPatchClassificationLinux[]>]
 [-LinuxParameterMaintenanceRunId <String>] [-LinuxParameterPackageNameMasksToExclude <String[]>]
 [-LinuxParameterPackageNameMasksToInclude <String[]>] [-MaximumDuration <String>]
 [-WindowParameterClassificationsToInclude <VMGuestPatchClassificationWindows[]>]
 [-WindowParameterExcludeKbsRequiringReboot] [-WindowParameterKbNumbersToExclude <String[]>]
 [-WindowParameterKbNumbersToInclude <String[]>] [-WindowParameterMaxPatchPublishDate <DateTime>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Install
```
Install-AzVirtualMachinePatch -ResourceGroupName <String> -VMName <String>
 -InstallPatchesInput <IVirtualMachineInstallPatchesParameters> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InstallViaIdentity
```
Install-AzVirtualMachinePatch -InputObject <IComputeClientIdentity>
 -InstallPatchesInput <IVirtualMachineInstallPatchesParameters> [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InstallViaIdentityExpanded
```
Install-AzVirtualMachinePatch -InputObject <IComputeClientIdentity> -RebootSetting <VMGuestPatchRebootSetting>
 [-LinuxParameterClassificationsToInclude <VMGuestPatchClassificationLinux[]>]
 [-LinuxParameterMaintenanceRunId <String>] [-LinuxParameterPackageNameMasksToExclude <String[]>]
 [-LinuxParameterPackageNameMasksToInclude <String[]>] [-MaximumDuration <String>]
 [-WindowParameterClassificationsToInclude <VMGuestPatchClassificationWindows[]>]
 [-WindowParameterExcludeKbsRequiringReboot] [-WindowParameterKbNumbersToExclude <String[]>]
 [-WindowParameterKbNumbersToInclude <String[]>] [-WindowParameterMaxPatchPublishDate <DateTime>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Installs patches on the VM.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.IComputeClientIdentity
Parameter Sets: InstallViaIdentity, InstallViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InstallPatchesInput
Input for InstallPatches as directly received by the API
To construct, see NOTES section for INSTALLPATCHESINPUT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IVirtualMachineInstallPatchesParameters
Parameter Sets: Install, InstallViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LinuxParameterClassificationsToInclude
The update classifications to select when installing patches for Linux.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.VMGuestPatchClassificationLinux[]
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LinuxParameterMaintenanceRunId
This is used as a maintenance run identifier for Auto VM Guest Patching in Linux.

```yaml
Type: System.String
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LinuxParameterPackageNameMasksToExclude
packages to exclude in the patch operation.
Format: packageName_packageVersion

```yaml
Type: System.String[]
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LinuxParameterPackageNameMasksToInclude
packages to include in the patch operation.
Format: packageName_packageVersion

```yaml
Type: System.String[]
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumDuration
Specifies the maximum amount of time that the operation will run.
It must be an ISO 8601-compliant duration string such as PT4H (4 hours)

```yaml
Type: System.String
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RebootSetting
Defines when it is acceptable to reboot a VM during a software update operation.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.VMGuestPatchRebootSetting
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: Install, InstallExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription credentials which uniquely identify Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Install, InstallExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMName
The name of the virtual machine.

```yaml
Type: System.String
Parameter Sets: Install, InstallExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowParameterClassificationsToInclude
The update classifications to select when installing patches for Windows.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.VMGuestPatchClassificationWindows[]
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowParameterExcludeKbsRequiringReboot
Filters out Kbs that don't have an InstallationRebootBehavior of 'NeverReboots' when this is set to true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowParameterKbNumbersToExclude
Kbs to exclude in the patch operation

```yaml
Type: System.String[]
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowParameterKbNumbersToInclude
Kbs to include in the patch operation

```yaml
Type: System.String[]
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowParameterMaxPatchPublishDate
This is used to install patches that were published on or before this given max published date.

```yaml
Type: System.DateTime
Parameter Sets: InstallExpanded, InstallViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IVirtualMachineInstallPatchesParameters

### Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.IComputeClientIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IVirtualMachineInstallPatchesResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IComputeClientIdentity>: Identity Parameter
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: The location for which resource usage is queried.
  - `[ResourceGroupName <String>]`: The name of the resource group.
  - `[SubscriptionId <String>]`: Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
  - `[VMExtensionName <String>]`: The name of the virtual machine extension.
  - `[VMName <String>]`: The name of the virtual machine where the extension should be created or updated.

INSTALLPATCHESINPUT <IVirtualMachineInstallPatchesParameters>: Input for InstallPatches as directly received by the API
  - `RebootSetting <VMGuestPatchRebootSetting>`: Defines when it is acceptable to reboot a VM during a software update operation.
  - `[LinuxParameterClassificationsToInclude <VMGuestPatchClassificationLinux[]>]`: The update classifications to select when installing patches for Linux.
  - `[LinuxParameterMaintenanceRunId <String>]`: This is used as a maintenance run identifier for Auto VM Guest Patching in Linux.
  - `[LinuxParameterPackageNameMasksToExclude <String[]>]`: packages to exclude in the patch operation. Format: packageName_packageVersion
  - `[LinuxParameterPackageNameMasksToInclude <String[]>]`: packages to include in the patch operation. Format: packageName_packageVersion
  - `[MaximumDuration <String>]`: Specifies the maximum amount of time that the operation will run. It must be an ISO 8601-compliant duration string such as PT4H (4 hours)
  - `[WindowParameterClassificationsToInclude <VMGuestPatchClassificationWindows[]>]`: The update classifications to select when installing patches for Windows.
  - `[WindowParameterExcludeKbsRequiringReboot <Boolean?>]`: Filters out Kbs that don't have an InstallationRebootBehavior of 'NeverReboots' when this is set to true.
  - `[WindowParameterKbNumbersToExclude <String[]>]`: Kbs to exclude in the patch operation
  - `[WindowParameterKbNumbersToInclude <String[]>]`: Kbs to include in the patch operation
  - `[WindowParameterMaxPatchPublishDate <DateTime?>]`: This is used to install patches that were published on or before this given max published date.

## RELATED LINKS

