![.NET Core](https://github.com/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator/workflows/.NET%20Core/badge.svg) [![codecov](https://codecov.io/gh/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator/branch/main/graph/badge.svg)](https://codecov.io/gh/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator) 

# About EventHorizon Blazor TypeScript Interop Generator

This project generates a C# Blazor Interop proxy using a TypeScript definition file. 

## Details

The generated project can be used with Blazor WASM to interface from C# into the JavaScript layer, this gives most JavaScript libraries an easy to use interface from C#. 
It uses the JSRuntime to interop directly with the underlying JavaScript from C#, this is done with a custom interop abstraction. 

The interop project is also included in this repository, it gives the generated code access to a common set of access patterns that can be used to interface with JavaScript from C#.

## Tech Used

* [.NET Core](https://dotnet.microsoft.com/)
* [TypeScript](https://www.typescriptlang.org/)

## Example

Checkout /Sample for a BabylonJS working example solution. The solution includes a BabylonJS generated proxy, with a working Blazor WASM site. You can also checkout the website on this repository for deployed website using the generated BabylonJS.
