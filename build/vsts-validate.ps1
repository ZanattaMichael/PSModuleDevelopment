﻿# Guide for available variables and working with secrets:
# https://docs.microsoft.com/en-us/vsts/build-release/concepts/definitions/build/variables?tabs=powershell

# Needs to ensure things are Done Right and only legal commits to master get built
& "$($env:SYSTEM_DEFAULTWORKINGDIRECTORY)\PSModuleDevelopment\tests\pester.ps1"