# DNN vNext Prototype
The DNN vNext Prototype is created to test feasibility of running DNN (formerly DotNetNuke) in the context of .NET Core. This project is 1 piece of a 3-pronged approach

## Built for Testing Feasibility
The DNN vNext Prototype (this project) has been created to layout the initial DNN vNext project in .NET Core. The 3 pieces of this project are:

1. The current version of DNN running on webforms 
2. DNN Razor Pages Module
3. This project which is a vNext prototype for DNN running on .NET Core

The theory being tested is that the DNN Razor pages module will run in both the current DNN (web forms) and the vNext DNN (this project) running in .NET Core. Having a module type that runs in both contexts will serve as a "bridge" for users seeking to migrate from the web forms version of DNN to the new .NET Core version of DNN. 

The bridge created via the Razor Pages module will significantly reduce the effects of "breaking changes" considered in the migration from the older system to the new. DNN module developers could potentially update their modules to the Razor pages module type to future-proof their modules for the vNext version of DNN. 

Also, vNext DNN will run in other environments such as on a Mac/Linux.

## Limitations
This prototype is designed for testing and will not have feature parity with the current web forms implementation of DNN.

## Setup
- Ensure .NET Core is installed on your machine
- Download/Fork the project and install it into your local development location
- Build it and run it with Visual Studio

## Platform	Supported	Version
- .NET Core 2.0+

## Created By: @Andrew_Hoefling
Twitter: @Andrew_Hoefling
Blog: andrewhoefling.com
License
The MIT License (MIT) see License File
