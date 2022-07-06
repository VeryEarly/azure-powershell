@{
  GUID = '94b9a416-8821-4cf9-bf15-8e39b3bba009'
  RootModule = './Az.ComputeClient.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Compute cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.ComputeClient.private.dll'
  FormatsToProcess = './Az.ComputeClient.format.ps1xml'
  FunctionsToExport = 'Convert-AzVirtualMachineToManagedDisk', 'Export-AzVirtualMachine', 'Get-AzUsage', 'Get-AzVirtualMachine', 'Get-AzVirtualMachineAvailableSize', 'Get-AzVirtualMachineBootDiagnosticData', 'Get-AzVirtualMachineExtension', 'Get-AzVirtualMachineSize', 'Install-AzVirtualMachinePatch', 'Invoke-AzAssessVirtualMachinePatch', 'Invoke-AzDeallocateVirtualMachine', 'Invoke-AzPerformVirtualMachineMaintenance', 'Invoke-AzReapplyVirtualMachine', 'Invoke-AzRedeployVirtualMachine', 'Invoke-AzSimulateVirtualMachineEviction', 'Invoke-AzViewVirtualMachineInstance', 'New-AzVirtualMachine', 'New-AzVirtualMachineExtension', 'Remove-AzVirtualMachine', 'Remove-AzVirtualMachineExtension', 'Reset-AzVirtualMachine', 'Restart-AzVirtualMachine', 'Set-AzVirtualMachine', 'Set-AzVirtualMachineExtension', 'Start-AzVirtualMachine', 'Stop-AzVirtualMachine', 'Update-AzVirtualMachine', 'Update-AzVirtualMachineExtension', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Compute'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
