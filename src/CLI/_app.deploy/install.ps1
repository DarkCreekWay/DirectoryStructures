# Copytight (c) 2017 by DarkCreekWay (https://github.com/DarkCreekWay)

<#
  .Synopsis
  XCopy deployment of DarkCreekWay's Tool for Directory Structures to
  current user's profile

  .Description
  DarkCreekWay's tool for Directory Strucures gets deployed by coping all 
  required files to the following directory:
  %localappdata%\Programs\DarkCreekWay\DirectoryStructurs 

  For finishing the deployment, run ds.xonfig.exe
#>

# $sourceDirectory = 'p:\DirectoryStructures\src\CLI\.Build\artefacts\net6.0-windows\*'
$sourceDirectory = $PSScriptRoot
$targetDirectory = Join-Path -Path $env:LOCALAPPDATA -ChildPath 'Programs\DarkCreekWay\DirectoryStructures'

New-Item $targetDirectory -ItemType Directory -Force | Out-Null
Copy-Item -Path $sourceDirectory -Destination $targetDirectory -Recurse -Force

Start-Process (Join-Path -Path $targetDirectory -ChildPath 'ds.config.exe')