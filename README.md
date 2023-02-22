# DevDebug
A wrapper class for Unity Debug, this will contain most of the methods
from Debug for logging purposes. It uses the Conditional attribute
to only log when 'DEV_BUILD' is defined.

## How-To:

### Installation

> Installing **DevDebug** can be done in two different methods:

1. Installing DevDebug as a `Unity Package`. This method will allow you to use
the DevDebug class directly but won't allow you to click your 
outputs from the Unity Console and to be directed to the origin of that output.

2. (**Recommended Method**) Installing DevDebug as a 
`Unity Managed Plugin (DLL)`. This method will use the DevDebug class still
but instead allow you to click your outputs from the Unity Console
and be directed to the origin of your outputs.


### Usage
> The Unity package installation will work outside the box as package.
> 
> The Unity Managed  Plugin (DLL) requires some extra steps which will be described below:
> 
> If you auto reference the DLL you will be set to just use DevDebug; however,
if your like me and you like to manually reference the DLL from each assembly
that will use it you will want to manually reference the DLL.

To **auto reference** the DLL you need to go in Unity and place the DLL
somewhere in your Assets and then select the DLL and within the Inspector
make sure **Auto Reference** is ticked.

To **manually reference** the DLL you need to instead create a folder
named `DevDebug` and insert the DLL into that folder and inspect the DLL in
Unity's Inspector and ensure that **Auto Reference** is not ticked. You
will also need the assembly definition file included in the release version
placing it inside the `DevDebug` folder. All files needed for manually
referencing the DLL can be found in the release version.

[The latest release can be found here](https://github.com/dev-syn/dev-debug/releases/latest)


#### Changelog
[![Changelog](https://img.shields.io/badge/Changelog-Keep%20A%20Changelog-yellow)](CHANGELOG.md)
#### License
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL_v3-blue.svg)](LICENSE.md)

