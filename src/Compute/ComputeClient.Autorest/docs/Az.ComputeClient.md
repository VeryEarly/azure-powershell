---
Module Name: Az.ComputeClient
Module Guid: 94b9a416-8821-4cf9-bf15-8e39b3bba009
Download Help Link: https://docs.microsoft.com/powershell/module/az.computeclient
Help Version: 1.0.0.0
Locale: en-US
---

# Az.ComputeClient Module
## Description
Microsoft Azure PowerShell: Compute cmdlets

## Az.ComputeClient Cmdlets
### [Convert-AzVirtualMachineToManagedDisk](Convert-AzVirtualMachineToManagedDisk.md)
Converts virtual machine disks from blob-based to managed disks.
Virtual machine must be stop-deallocated before invoking this operation.

### [Export-AzVirtualMachine](Export-AzVirtualMachine.md)
Captures the VM by copying virtual hard disks of the VM and outputs a template that can be used to create similar VMs.

### [Get-AzUsage](Get-AzUsage.md)
Gets, for the specified location, the current compute resource usage information as well as the limits for compute resources under the subscription.

### [Get-AzVirtualMachine](Get-AzVirtualMachine.md)
Retrieves information about the model view or the instance view of a virtual machine.

### [Get-AzVirtualMachineAvailableSize](Get-AzVirtualMachineAvailableSize.md)
Lists all available virtual machine sizes to which the specified virtual machine can be resized.

### [Get-AzVirtualMachineBootDiagnosticData](Get-AzVirtualMachineBootDiagnosticData.md)
The operation to retrieve SAS URIs for a virtual machine's boot diagnostic logs.

### [Get-AzVirtualMachineExtension](Get-AzVirtualMachineExtension.md)
The operation to get the extension.

### [Get-AzVirtualMachineSize](Get-AzVirtualMachineSize.md)
This API is deprecated.
Use [Resources Skus](https://docs.microsoft.com/rest/api/compute/resourceskus/list)

### [Install-AzVirtualMachinePatch](Install-AzVirtualMachinePatch.md)
Installs patches on the VM.

### [Invoke-AzAssessVirtualMachinePatch](Invoke-AzAssessVirtualMachinePatch.md)
Assess patches on the VM.

### [Invoke-AzDeallocateVirtualMachine](Invoke-AzDeallocateVirtualMachine.md)
Shuts down the virtual machine and releases the compute resources.
You are not billed for the compute resources that this virtual machine uses.

### [Invoke-AzPerformVirtualMachineMaintenance](Invoke-AzPerformVirtualMachineMaintenance.md)
The operation to perform maintenance on a virtual machine.

### [Invoke-AzReapplyVirtualMachine](Invoke-AzReapplyVirtualMachine.md)
The operation to reapply a virtual machine's state.

### [Invoke-AzRedeployVirtualMachine](Invoke-AzRedeployVirtualMachine.md)
Shuts down the virtual machine, moves it to a new node, and powers it back on.

### [Invoke-AzSimulateVirtualMachineEviction](Invoke-AzSimulateVirtualMachineEviction.md)
The operation to simulate the eviction of spot virtual machine.

### [Invoke-AzViewVirtualMachineInstance](Invoke-AzViewVirtualMachineInstance.md)
Retrieves information about the run-time state of a virtual machine.

### [New-AzVirtualMachine](New-AzVirtualMachine.md)
The operation to create or update a virtual machine.
Please note some properties can be set only during virtual machine creation.

### [New-AzVirtualMachineExtension](New-AzVirtualMachineExtension.md)
The operation to create or update the extension.

### [Remove-AzVirtualMachine](Remove-AzVirtualMachine.md)
The operation to delete a virtual machine.

### [Remove-AzVirtualMachineExtension](Remove-AzVirtualMachineExtension.md)
The operation to delete the extension.

### [Reset-AzVirtualMachine](Reset-AzVirtualMachine.md)
Sets the OS state of the virtual machine to generalized.
It is recommended to sysprep the virtual machine before performing this operation.

For Windows, please refer to [Create a managed image of a generalized VM in Azure](https://docs.microsoft.com/azure/virtual-machines/windows/capture-image-resource).
For Linux, please refer to [How to create an image of a virtual machine or VHD](https://docs.microsoft.com/azure/virtual-machines/linux/capture-image).

### [Restart-AzVirtualMachine](Restart-AzVirtualMachine.md)
The operation to restart a virtual machine.

### [Set-AzVirtualMachine](Set-AzVirtualMachine.md)
The operation to create or update a virtual machine.
Please note some properties can be set only during virtual machine creation.

### [Set-AzVirtualMachineExtension](Set-AzVirtualMachineExtension.md)
The operation to create or update the extension.

### [Start-AzVirtualMachine](Start-AzVirtualMachine.md)
The operation to start a virtual machine.

### [Stop-AzVirtualMachine](Stop-AzVirtualMachine.md)
The operation to power off (stop) a virtual machine.
The virtual machine can be restarted with the same provisioned resources.
You are still charged for this virtual machine.

### [Update-AzVirtualMachine](Update-AzVirtualMachine.md)
Reimages the virtual machine which has an ephemeral OS disk back to its initial state.

### [Update-AzVirtualMachineExtension](Update-AzVirtualMachineExtension.md)
The operation to update the extension.

