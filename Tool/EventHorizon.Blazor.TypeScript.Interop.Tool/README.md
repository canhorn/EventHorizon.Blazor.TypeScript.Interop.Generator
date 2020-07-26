[![EventHorizon.Blazor.TypeScript.Interop.Tool](https://img.shields.io/nuget/vpre/EventHorizon.Blazor.TypeScript.Interop.Tool?style=for-the-badge&label=Tool)](https://www.nuget.org/packages/EventHorizon.Blazor.TypeScript.Interop.Tool)

# About EventHorizon Blazor TypeScript Interop Tool

This dotnet tool encapsulates project generation for TypeScript Blazor Interop proxy abstraction. 

## Install

~~~ bash
dotnet tool install -g EventHorizon.Blazor.TypeScript.Interop.Tool
~~~

## Command Line Options

Identifier | Details | Required/Default
--- | --- | ---
-s, --source &lt;source&gt; | TypeScript Definition to generate from, can be a File or URL, accepts multiple or as Array |  REQUIRED
-c, --class-to-generate &lt;class-to-generate&gt; | A Class to generate, accepts multiple or as Array |  REQUIRED
-a, --project-assembly &lt;project-assembly&gt; | The project name of the Assembly that will be generated | Default: "Generated.WASM"
-l, --project-generation-location &lt;project-generation-location&gt; | The directory where the Generated Project assembly will be saved | Default: "_generated"
-f, --force | This will force generation, by deleting --project-generation-location | Default: (False)

## Usage

~~~ bash
# Generated BabylonJS project with interop to Vector3 class.
# Created with a project assembly of Blazor.BabylonJS.
ehz-generate --project-assembly Blazor.BabylonJS --class-to-generate Vector3 --source https://raw.githubusercontent.com/BabylonJS/Babylon.js/master/dist/babylon.d.ts
~~~

~~~ bash
# (using shorthand alias) Generated BabylonJS project with interop to Vector3 class.
# Created with a project assembly of Blazor.BabylonJS.
ehz-generate -a Blazor.BabylonJS -c Vector3 -s https://raw.githubusercontent.com/BabylonJS/Babylon.js/master/dist/babylon.d.ts
~~~

~~~ bash
# Generated BabylonJS project interop with multiple classes.
ehz-generate -c Vector3 -c Mesh -c Engine -c Scene -s https://raw.githubusercontent.com/BabylonJS/Babylon.js/master/dist/babylon.d.ts
~~~

~~~ bash
# Generated BabylonJS project interop with multiple sources.
ehz-generate -c Button -s https://raw.githubusercontent.com/BabylonJS/Babylon.js/master/dist/babylon.d.ts -s https://raw.githubusercontent.com/BabylonJS/Babylon.js/master/dist/gui/babylon.gui.d.ts
~~~