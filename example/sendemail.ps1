$executing_script_directory = Split-Path -Path $MyInvocation.MyCommand.Definition -Parent
$emailmanager_server_token = "token"

function Load-Module([string] $assembly_lib_path)
{
    if(!$assembly_lib_path)
    {
        throw "argument"
    }

    $lib_folder_path = Join-Path $executing_script_directory "lib"
    $full_lib_path =  Join-Path $lib_folder_path $assembly_lib_path
    Import-Module $full_lib_path
}

function Load-Emailmanager-Lib()
{
    Load-Module "Hammock.dll"
    Load-Module "Newtonsoft.Json.dll"
    Load-Module "EmailmanagerDotNet.dll"
    Load-Module "AppHarbor.PowerShell.Emailmanager.PSSnapIn.dll"
}

function Send-Email()
{
    $emailmanager_client = Get-EmailmanagerClient -ServerToken $emailmanager_server_token
    $response = $emailmanager_client | Send-EmailmanagerEmail "from@example.com" "to@example.com" "subject" "body"
}

function Main()
{
    Load-Emailmanager-Lib
    Send-Email
}

Main
