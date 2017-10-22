param (
	[string]$webAppName,
	[string]$productionSlotName,
	[string]$canarySlotName,
	[string]$percentage
)
Write-Host "Setting slot on webapp $webAppName slotname $canarySlotName to $percentage % trafic"
Add-Type -Path 'C:\Program Files (x86)\Microsoft SDKs\Azure\PowerShell\ServiceManagement\Azure\Services\Microsoft.WindowsAzure.Commands.Utilities.dll'
$rule = New-Object Microsoft.WindowsAzure.Commands.Utilities.Websites.Services.WebEntities.RampUpRule
$rule.ActionHostName = "$webAppName-$canarySlotName.azurewebsites.net"
$rule.ReroutePercentage = $percentage
$rule.Name = $canarySlotName

Set-AzureWebsite $webAppName -Slot $productionSlotName -RoutingRules $rule