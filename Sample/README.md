# EventHorizon TypeScript Interop Generator - Sample

This solution includes a few projects that display the usage of the Generator functionality. 

## API Generation

The EventHorizon.BabylonJS.Interop.Generator.ConsoleApp console project can generate the C# proxy project. It uses the BabylonJS TypeScript deinition for the API generation. 

Update the generationList variable in the Project.cs file to generate more Class/Interface API's.

~~~ bash
# Run this from the EventHorizon.BabylonJS.Interop.Generator.ConsoleApp project root
dotnet run
~~~

## Website Example

The EventHorizon.Blazor.BabylonJS project is a ASP.NET Core Blazor WASM (client side) project, the website uses the generated BabylonJS project to show of creating a BabylonJS Scene using just C# on a Razor page.
