---
external help file:
Module Name: Az.ComputeClient
online version: https://docs.microsoft.com/powershell/module/az.computeclient/new-azvirtualmachine
schema: 2.0.0
---

# New-AzVirtualMachine

## SYNOPSIS
The operation to create or update a virtual machine.
Please note some properties can be set only during virtual machine creation.

## SYNTAX

```
New-AzVirtualMachine -ResourceGroupName <String> -VMName <String> -Location <String>
 [-SubscriptionId <String>] [-AdditionalCapabilityHibernationEnabled] [-AdditionalCapabilityUltraSsdEnabled]
 [-ApplicationProfileGalleryApplication <IVMGalleryApplication[]>] [-AvailabilitySetId <String>]
 [-BillingProfileMaxPrice <Double>] [-BootDiagnosticEnabled] [-BootDiagnosticStorageUri <String>]
 [-CapacityReservationGroupId <String>] [-EvictionPolicy <VirtualMachineEvictionPolicyTypes>]
 [-ExtendedLocationName <String>] [-ExtendedLocationType <ExtendedLocationTypes>]
 [-ExtensionsTimeBudget <String>] [-HardwareProfileVMSize <VirtualMachineSizeTypes>] [-HostGroupId <String>]
 [-HostId <String>] [-IdentityType <ResourceIdentityType>] [-IdentityUserAssignedIdentity <Hashtable>]
 [-ImageReferenceCommunityGalleryImageId <String>] [-ImageReferenceId <String>]
 [-ImageReferenceOffer <String>] [-ImageReferencePublisher <String>]
 [-ImageReferenceSharedGalleryImageId <String>] [-ImageReferenceSku <String>]
 [-ImageReferenceVersion <String>] [-LicenseType <String>]
 [-NetworkProfileNetworkApiVersion <NetworkApiVersion>]
 [-NetworkProfileNetworkInterface <INetworkInterfaceReference[]>]
 [-NetworkProfileNetworkInterfaceConfiguration <IVirtualMachineNetworkInterfaceConfiguration[]>]
 [-OSProfile <IOSProfile>] [-PlanName <String>] [-PlanProduct <String>] [-PlanPromotionCode <String>]
 [-PlanPublisher <String>] [-PlatformFaultDomain <Int32>] [-Priority <VirtualMachinePriorityTypes>]
 [-ProximityPlacementGroupId <String>] [-SecurityProfileEncryptionAtHost]
 [-SecurityProfileSecurityType <SecurityTypes>] [-StorageProfileDataDisk <IDataDisk[]>]
 [-StorageProfileOSDisk <IOSDisk>] [-Tag <Hashtable>] [-TerminateNotificationProfileEnable]
 [-TerminateNotificationProfileNotBeforeTimeout <String>] [-UefiSettingSecureBootEnabled]
 [-UefiSettingVTpmEnabled] [-UserData <String>] [-VirtualMachineScaleSetId <String>]
 [-VMSizePropertyVcpUsAvailable <Int32>] [-VMSizePropertyVcpUsPerCore <Int32>] [-Zone <String[]>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The operation to create or update a virtual machine.
Please note some properties can be set only during virtual machine creation.

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

### -AdditionalCapabilityHibernationEnabled
The flag that enables or disables hibernation capability on the VM.

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

### -AdditionalCapabilityUltraSsdEnabled
The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS.
Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled.

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

### -ApplicationProfileGalleryApplication
Specifies the gallery applications that should be made available to the VM/VMSS
To construct, see NOTES section for APPLICATIONPROFILEGALLERYAPPLICATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IVMGalleryApplication[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -AvailabilitySetId
Resource Id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BillingProfileMaxPrice
Specifies the maximum price you are willing to pay for a Azure Spot VM/VMSS.
This price is in US Dollars.


 This price will be compared with the current Azure Spot price for the VM size.
Also, the prices are compared at the time of create/update of Azure Spot VM/VMSS and the operation will only succeed if the maxPrice is greater than the current Azure Spot price.


 The maxPrice will also be used for evicting a Azure Spot VM/VMSS if the current Azure Spot price goes beyond the maxPrice after creation of VM/VMSS.


 Possible values are: 

 - Any decimal value greater than zero.
Example: 0.01538 

 -1 – indicates default price to be up-to on-demand.


 You can set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS should not be evicted for price reasons.
Also, the default max price is -1 if it is not provided by you.


Minimum api-version: 2019-03-01.

```yaml
Type: System.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BootDiagnosticEnabled
Whether boot diagnostics should be enabled on the Virtual Machine.

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

### -BootDiagnosticStorageUri
Uri of the storage account to use for placing the console output and screenshot.


If storageUri is not specified while enabling boot diagnostics, managed storage will be used.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CapacityReservationGroupId
Resource Id

```yaml
Type: System.String
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

### -EvictionPolicy
Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.


For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01.


For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.VirtualMachineEvictionPolicyTypes
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtendedLocationName
The name of the extended location.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtendedLocationType
The type of the extended location.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.ExtendedLocationTypes
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtensionsTimeBudget
Specifies the time alloted for all extensions to start.
The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format.
The default value is 90 minutes (PT1H30M).


 Minimum api-version: 2020-06-01

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HardwareProfileVMSize
Specifies the size of the virtual machine.


 The enum data type is currently deprecated and will be removed by December 23rd 2023.


 Recommended way to get the list of available sizes is using these APIs: 

 [List all available virtual machine sizes in an availability set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes) 

 [List all available virtual machine sizes in a region]( https://docs.microsoft.com/rest/api/compute/resourceskus/list) 

 [List all available virtual machine sizes for resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes).
For more information about virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/azure/virtual-machines/sizes).


 The available VM sizes depend on region and availability set.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.VirtualMachineSizeTypes
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostGroupId
Resource Id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostId
Resource Id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityType
The type of identity used for the virtual machine.
The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities.
The type 'None' will remove any identities from the virtual machine.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.ResourceIdentityType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityUserAssignedIdentity
The list of user identities associated with the Virtual Machine.
The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceCommunityGalleryImageId
Specified the community gallery image unique id for vm deployment.
This can be fetched from community gallery image GET call.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceId
Resource Id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceOffer
Specifies the offer of the platform image or marketplace image used to create the virtual machine.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferencePublisher
The image publisher.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceSharedGalleryImageId
Specified the shared gallery image unique id for vm deployment.
This can be fetched from shared gallery image GET call.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceSku
The image SKU.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceVersion
Specifies the version of the platform image or marketplace image used to create the virtual machine.
The allowed formats are Major.Minor.Build or 'latest'.
Major, Minor, and Build are decimal numbers.
Specify 'latest' to use the latest version of an image available at deploy time.
Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.
Please do not use field 'version' for gallery image deployment, gallery image should always use 'id' field for deployment, to use 'latest' version of gallery image, just set '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}' in the 'id' field without version input.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LicenseType
Specifies that the image or disk that is being used was licensed on-premises.


 Possible values for Windows Server operating system are: 

 Windows_Client 

 Windows_Server 

 Possible values for Linux Server operating system are: 

 RHEL_BYOS (for RHEL) 

 SLES_BYOS (for SUSE) 

 For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) 

 [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) 

 Minimum api-version: 2015-06-15

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
Resource location

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfileNetworkApiVersion
specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.NetworkApiVersion
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfileNetworkInterface
Specifies the list of resource Ids for the network interfaces associated with the virtual machine.
To construct, see NOTES section for NETWORKPROFILENETWORKINTERFACE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.INetworkInterfaceReference[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfileNetworkInterfaceConfiguration
Specifies the networking configurations that will be used to create the virtual machine networking resources.
To construct, see NOTES section for NETWORKPROFILENETWORKINTERFACECONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IVirtualMachineNetworkInterfaceConfiguration[]
Parameter Sets: (All)
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

### -OSProfile
Specifies the operating system settings used while creating the virtual machine.
Some of the settings cannot be changed once VM is provisioned.
To construct, see NOTES section for OSPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IOSProfile
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanName
The plan ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanProduct
Specifies the product of the image from the marketplace.
This is the same value as Offer under the imageReference element.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanPromotionCode
The promotion code.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanPublisher
The publisher ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlatformFaultDomain
Specifies the scale set logical fault domain into which the Virtual Machine will be created.
By default, the Virtual Machine will by automatically assigned to a fault domain that best maintains balance across available fault domains.
\<li\>This is applicable only if the 'virtualMachineScaleSet' property of this Virtual Machine is set.\<li\>The Virtual Machine Scale Set that is referenced, must have 'platformFaultDomainCount' &gt; 1.\<li\>This property cannot be updated once the Virtual Machine is created.\<li\>Fault domain assignment can be viewed in the Virtual Machine Instance View.

Minimum api‐version: 2020‐12‐01

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
Specifies the priority for the virtual machine.


Minimum api-version: 2019-03-01

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.VirtualMachinePriorityTypes
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProximityPlacementGroupId
Resource Id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityProfileEncryptionAtHost
This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set.
This will enable the encryption for all the disks including Resource/Temp disk at host itself.


 Default: The Encryption at host will be disabled unless this property is set to true for the resource.

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

### -SecurityProfileSecurityType
Specifies the SecurityType of the virtual machine.
It has to be set to any specified value to enable UefiSettings.


 Default: UefiSettings will not be enabled unless this property is set.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Support.SecurityTypes
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageProfileDataDisk
Specifies the parameters that are used to add a data disk to a virtual machine.


 For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
To construct, see NOTES section for STORAGEPROFILEDATADISK properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IDataDisk[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageProfileOSDisk
Specifies information about the operating system disk used by the virtual machine.


 For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
To construct, see NOTES section for STORAGEPROFILEOSDISK properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IOSDisk
Parameter Sets: (All)
Aliases:

Required: False
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TerminateNotificationProfileEnable
Specifies whether the Terminate Scheduled event is enabled or disabled.

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

### -TerminateNotificationProfileNotBeforeTimeout
Configurable length of time a Virtual Machine being deleted will have to potentially approve the Terminate Scheduled Event before the event is auto approved (timed out).
The configuration must be specified in ISO 8601 format, the default value is 5 minutes (PT5M)

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UefiSettingSecureBootEnabled
Specifies whether secure boot should be enabled on the virtual machine.


Minimum api-version: 2020-12-01

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

### -UefiSettingVTpmEnabled
Specifies whether vTPM should be enabled on the virtual machine.


Minimum api-version: 2020-12-01

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

### -UserData
UserData for the VM, which must be base-64 encoded.
Customer should not pass any secrets in here.


Minimum api-version: 2021-03-01

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualMachineScaleSetId
Resource Id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMName
The name of the virtual machine.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMSizePropertyVcpUsAvailable
Specifies the number of vCPUs available for the VM.


 When this property is not specified in the request body the default behavior is to set it to the value of vCPUs available for that VM size exposed in api response of [List all available virtual machine sizes in a region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) .

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMSizePropertyVcpUsPerCore
Specifies the vCPU to physical core ratio.


 When this property is not specified in the request body the default behavior is set to the value of vCPUsPerCore for the VM Size exposed in api response of [List all available virtual machine sizes in a region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) 

 Setting this property to 1 also means that hyper-threading is disabled.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Zone
The virtual machine zones.

```yaml
Type: System.String[]
Parameter Sets: (All)
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ComputeClient.Models.Api20220301.IVirtualMachine

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLICATIONPROFILEGALLERYAPPLICATION <IVMGalleryApplication[]>: Specifies the gallery applications that should be made available to the VM/VMSS
  - `PackageReferenceId <String>`: Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
  - `[ConfigurationReference <String>]`: Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided
  - `[EnableAutomaticUpgrade <Boolean?>]`: If set to true, when a new Gallery Application version is available in PIR/SIG, it will be automatically updated for the VM/VMSS
  - `[Order <Int32?>]`: Optional, Specifies the order in which the packages have to be installed
  - `[Tag <String>]`: Optional, Specifies a passthrough value for more generic context.
  - `[TreatFailureAsDeploymentFailure <Boolean?>]`: Optional, If true, any failure for any operation in the VmApplication will fail the deployment

NETWORKPROFILENETWORKINTERFACE <INetworkInterfaceReference[]>: Specifies the list of resource Ids for the network interfaces associated with the virtual machine.
  - `[Id <String>]`: Resource Id
  - `[DeleteOption <DeleteOptions?>]`: Specify what happens to the network interface when the VM is deleted
  - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more than 1 network interface.

NETWORKPROFILENETWORKINTERFACECONFIGURATION <IVirtualMachineNetworkInterfaceConfiguration[]>: Specifies the networking configurations that will be used to create the virtual machine networking resources.
  - `Name <String>`: The network interface configuration name.
  - `[DeleteOption <DeleteOptions?>]`: Specify what happens to the network interface when the VM is deleted
  - `[DnsSettingDnsServer <String[]>]`: List of DNS servers IP addresses
  - `[DscpConfigurationId <String>]`: Resource Id
  - `[EnableAcceleratedNetworking <Boolean?>]`: Specifies whether the network interface is accelerated networking-enabled.
  - `[EnableFpga <Boolean?>]`: Specifies whether the network interface is FPGA networking-enabled.
  - `[EnableIPForwarding <Boolean?>]`: Whether IP forwarding enabled on this NIC.
  - `[IPConfiguration <IVirtualMachineNetworkInterfaceIPConfiguration[]>]`: Specifies the IP configurations of the network interface.
    - `Name <String>`: The IP configuration name.
    - `[ApplicationGatewayBackendAddressPool <ISubResource[]>]`: Specifies an array of references to backend address pools of application gateways. A virtual machine can reference backend address pools of multiple application gateways. Multiple virtual machines cannot use the same application gateway.
      - `[Id <String>]`: Resource Id
    - `[ApplicationSecurityGroup <ISubResource[]>]`: Specifies an array of references to application security group.
    - `[DeleteOption <DeleteOptions?>]`: Specify what happens to the public IP address when the VM is deleted
    - `[DnsSettingDomainNameLabel <String>]`: The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the domain name label and vm network profile unique ID.
    - `[IPTag <IVirtualMachineIPTag[]>]`: The list of IP tags associated with the public IP address.
      - `[IPTagType <String>]`: IP tag type. Example: FirstPartyUsage.
      - `[Tag <String>]`: IP tag associated with the public IP. Example: SQL, Storage etc.
    - `[IdleTimeoutInMinute <Int32?>]`: The idle timeout of the public IP address.
    - `[LoadBalancerBackendAddressPool <ISubResource[]>]`: Specifies an array of references to backend address pools of load balancers. A virtual machine can reference backend address pools of one public and one internal load balancer. [Multiple virtual machines cannot use the same basic sku load balancer].
    - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more than 1 network interface.
    - `[PrivateIPAddressVersion <IPVersions?>]`: Available from Api-Version 2017-03-30 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: 'IPv4' and 'IPv6'.
    - `[PublicIPAddressConfigurationName <String>]`: The publicIP address configuration name.
    - `[PublicIPAddressVersion <IPVersions?>]`: Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: 'IPv4' and 'IPv6'.
    - `[PublicIPAllocationMethod <PublicIPAllocationMethod?>]`: Specify the public IP allocation type
    - `[PublicIPPrefixId <String>]`: Resource Id
    - `[SkuName <PublicIPAddressSkuName?>]`: Specify public IP sku name
    - `[SkuTier <PublicIPAddressSkuTier?>]`: Specify public IP sku tier
    - `[SubnetId <String>]`: Resource Id
  - `[NetworkSecurityGroupId <String>]`: Resource Id
  - `[Primary <Boolean?>]`: Specifies the primary network interface in case the virtual machine has more than 1 network interface.

OSPROFILE <IOSProfile>: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot be changed once VM is provisioned.
  - `[AdminPassword <String>]`: Specifies the password of the administrator account.    **Minimum-length (Windows):** 8 characters    **Minimum-length (Linux):** 6 characters    **Max-length (Windows):** 123 characters    **Max-length (Linux):** 72 characters    **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled   Has lower characters  Has upper characters   Has a digit   Has a special character (Regex match [\W_])    **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!"    For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)    For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
  - `[AdminUsername <String>]`: Specifies the name of the administrator account.    This property cannot be updated after the VM is created.    **Windows-only restriction:** Cannot end in "."    **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".    **Minimum-length (Linux):** 1  character    **Max-length (Linux):** 64 characters    **Max-length (Windows):** 20 characters.
  - `[AllowExtensionOperation <Boolean?>]`: Specifies whether extension operations should be allowed on the virtual machine.   This may only be set to False when no extensions are present on the virtual machine.
  - `[ComputerName <String>]`: Specifies the host OS name of the virtual machine.    This name cannot be updated after the VM is created.    **Max-length (Windows):** 15 characters    **Max-length (Linux):** 64 characters.    For naming conventions and restrictions see [Azure infrastructure services implementation guidelines](https://docs.microsoft.com/azure/azure-resource-manager/management/resource-name-rules).
  - `[CustomData <String>]`: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.    **Note: Do not pass any secrets or passwords in customData property**    This property cannot be updated after the VM is created.    customData is passed to the VM to be saved as a file, for more information see [Custom Data on Azure VMs](https://azure.microsoft.com/blog/custom-data-and-cloud-init-on-windows-azure/)    For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
  - `[LinuxConfigurationDisablePasswordAuthentication <Boolean?>]`: Specifies whether password authentication should be disabled.
  - `[LinuxConfigurationPatchSettingsAssessmentMode <LinuxPatchAssessmentMode?>]`: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You control the timing of patch assessments on a virtual machine. <br /><br /> **AutomaticByPlatform** - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
  - `[LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <LinuxVMGuestPatchAutomaticByPlatformRebootSetting?>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.
  - `[LinuxConfigurationPatchSettingsPatchMode <LinuxVMGuestPatchMode?>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual machine scale set with OrchestrationMode as Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The virtual machine's default patching configuration is used. <br /><br /> **AutomaticByPlatform** - The virtual machine will be automatically updated by the platform. The property provisionVMAgent must be true
  - `[LinuxConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual machine.    When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later.
  - `[PatchSettingEnableHotpatching <Boolean?>]`: Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode' must be set to 'AutomaticByPlatform'.
  - `[RequireGuestProvisionSignal <Boolean?>]`: Optional property which must either be set to True or omitted.
  - `[Secret <IVaultSecretGroup[]>]`: Specifies set of certificates that should be installed onto the virtual machine. To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    - `[SourceVaultId <String>]`: Resource Id
    - `[VaultCertificate <IVaultCertificate[]>]`: The list of key vault references in SourceVault which contain certificates.
      - `[CertificateStore <String>]`: For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The specified certificate store is implicitly in the LocalMachine account.   For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem formatted.
      - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8:    {   "data":"<Base64-encoded-certificate>",   "dataType":"pfx",   "password":"<pfx-file-password>" }   To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
  - `[SshPublicKey <ISshPublicKey[]>]`: The list of SSH public keys used to authenticate with linux based VMs.
    - `[KeyData <String>]`: SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in ssh-rsa format.    For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
    - `[Path <String>]`: Specifies the full path on the created VM where ssh public key is stored. If the file already exists, the specified key is appended to the file. Example: /home/user/.ssh/authorized_keys
  - `[WinRmListener <IWinRmListener[]>]`: The list of Windows Remote Management listeners
    - `[CertificateUrl <String>]`: This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8:    {   "data":"<Base64-encoded-certificate>",   "dataType":"pfx",   "password":"<pfx-file-password>" }   To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    - `[Protocol <ProtocolTypes?>]`: Specifies the protocol of WinRM listener.    Possible values are:  **http**    **https**
  - `[WindowConfigurationAdditionalUnattendContent <IAdditionalUnattendContent[]>]`: Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup.
    - `[ComponentName <ComponentNames?>]`: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.
    - `[Content <String>]`: Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted.
    - `[PassName <PassNames?>]`: The pass name. Currently, the only allowable value is OobeSystem.
    - `[SettingName <SettingNames?>]`: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon.
  - `[WindowConfigurationEnableAutomaticUpdate <Boolean?>]`: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is true.    For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
  - `[WindowConfigurationProvisionVMAgent <Boolean?>]`: Indicates whether virtual machine agent should be provisioned on the virtual machine.    When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later.
  - `[WindowConfigurationTimeZone <String>]`: Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".    Possible values can be [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time zones returned by [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
  - `[WindowsConfigurationPatchSettingsAssessmentMode <WindowsPatchAssessmentMode?>]`: Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You control the timing of patch assessments on a virtual machine.<br /><br /> **AutomaticByPlatform** - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true. 
  - `[WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting <WindowsVMGuestPatchAutomaticByPlatformRebootSetting?>]`: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.
  - `[WindowsConfigurationPatchSettingsPatchMode <WindowsVMGuestPatchMode?>]`: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual machine scale set with OrchestrationMode as Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true 

STORAGEPROFILEDATADISK <IDataDisk[]>: Specifies the parameters that are used to add a data disk to a virtual machine.    For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
  - `CreateOption <DiskCreateOptionTypes>`: Specifies how the virtual machine should be created.   Possible values are:   **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.   **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
  - `Lun <Int32>`: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
  - `[Caching <CachingTypes?>]`: Specifies the caching requirements.    Possible values are:    **None**    **ReadOnly**    **ReadWrite**    Default: **None for Standard storage. ReadOnly for Premium storage**
  - `[DeleteOption <DiskDeleteOptionTypes?>]`: Specifies whether data disk should be deleted or detached upon VM deletion.   Possible values:    **Delete** If this value is used, the data disk is deleted when VM is deleted.   **Detach** If this value is used, the data disk is retained after VM is deleted.   The default value is set to **detach**
  - `[DetachOption <DiskDetachOptionTypes?>]`: Specifies the detach behavior to be used while detaching a disk or which is already in the process of detachment from the virtual machine. Supported values: **ForceDetach**.    detachOption: **ForceDetach** is applicable only for managed data disks. If a previous detachment attempt of the data disk did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed when using this detach behavior.    This feature is still in preview mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk update toBeDetached to 'true' along with setting detachOption: 'ForceDetach'.
  - `[DiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image.    This value cannot be larger than 1023 GB
  - `[ImageUri <String>]`: Specifies the virtual hard disk's uri.
  - `[ManagedDiskId <String>]`: Resource Id
  - `[ManagedDiskStorageAccountType <StorageAccountTypes?>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
  - `[Name <String>]`: The disk name.
  - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
  - `[SecurityProfileSecurityEncryptionType <SecurityEncryptionTypes?>]`: Specifies the EncryptionType of the managed disk.   It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly for encryption of just the VMGuestState blob.    NOTE: It can be set for only Confidential VMs.
  - `[SubResourceId <String>]`: Resource Id
  - `[ToBeDetached <Boolean?>]`: Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset
  - `[VhdUri <String>]`: Specifies the virtual hard disk's uri.
  - `[WriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.

STORAGEPROFILEOSDISK <IOSDisk>: Specifies information about the operating system disk used by the virtual machine.    For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
  - `CreateOption <DiskCreateOptionTypes>`: Specifies how the virtual machine should be created.   Possible values are:   **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.   **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
  - `[Caching <CachingTypes?>]`: Specifies the caching requirements.    Possible values are:    **None**    **ReadOnly**    **ReadWrite**    Default: **None** for Standard storage. **ReadOnly** for Premium storage.
  - `[DeleteOption <DiskDeleteOptionTypes?>]`: Specifies whether OS Disk should be deleted or detached upon VM deletion.    Possible values:    **Delete** If this value is used, the OS disk is deleted when VM is deleted.   **Detach** If this value is used, the os disk is retained after VM is deleted.    The default value is set to **detach**. For an ephemeral OS Disk, the default value is set to **Delete**. User cannot change the delete option for ephemeral OS Disk.
  - `[DiffDiskSettingOption <DiffDiskOptions?>]`: Specifies the ephemeral disk settings for operating system disk.
  - `[DiffDiskSettingPlacement <DiffDiskPlacement?>]`: Specifies the ephemeral disk placement for operating system disk.   Possible values are:    **CacheDisk**    **ResourceDisk**    Default: **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk** is used.   Refer to VM size documentation for Windows VM at https://docs.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM sizes exposes a cache disk.
  - `[DiskEncryptionKeySecretUrl <String>]`: The URL referencing a secret in a Key Vault.
  - `[DiskEncryptionKeySourceVaultId <String>]`: Resource Id
  - `[DiskSizeGb <Int32?>]`: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image.    This value cannot be larger than 1023 GB
  - `[EncryptionSettingEnabled <Boolean?>]`: Specifies whether disk encryption should be enabled on the virtual machine.
  - `[ImageUri <String>]`: Specifies the virtual hard disk's uri.
  - `[KeyEncryptionKeySourceVaultId <String>]`: Resource Id
  - `[KeyEncryptionKeyUrl <String>]`: The URL referencing a key encryption key in Key Vault.
  - `[ManagedDiskId <String>]`: Resource Id
  - `[ManagedDiskStorageAccountType <StorageAccountTypes?>]`: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
  - `[Name <String>]`: The disk name.
  - `[OSType <OperatingSystemTypes?>]`: This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD.    Possible values are:    **Windows**    **Linux**
  - `[SecurityProfileDiskEncryptionSetId <String>]`: Resource Id
  - `[SecurityProfileSecurityEncryptionType <SecurityEncryptionTypes?>]`: Specifies the EncryptionType of the managed disk.   It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly for encryption of just the VMGuestState blob.    NOTE: It can be set for only Confidential VMs.
  - `[SubResourceId <String>]`: Resource Id
  - `[VhdUri <String>]`: Specifies the virtual hard disk's uri.
  - `[WriteAcceleratorEnabled <Boolean?>]`: Specifies whether writeAccelerator should be enabled or disabled on the disk.

## RELATED LINKS

