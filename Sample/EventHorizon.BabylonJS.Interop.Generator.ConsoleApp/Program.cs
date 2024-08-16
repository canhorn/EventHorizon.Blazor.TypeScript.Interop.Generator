namespace EventHorizon.Blazor.TypeScript.Interop.Generator.ConsoleApp;

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using ServerGenerator = Blazor.Interop.Generator.GenerateInteropSource;
using ServerProjectWriter = Blazor.Interop.Generator.Writers.Project.ServerProjectWriter;
using WasmGenerator = GenerateSource;
using WasmProjectWriter = Writers.Project.ProjectWriter;

public class Program
{
    static void Main(string[] args)
    {
        // pre-05/26/2024 - 75084ms/71877ms to generate.
        // 05/26/2024 - 26662ms/27904ms/27486ms to generate. This is with a smaller data set.
        // 08/16/2024 - 37792ms to generate.
        Run(AstParser.Model.ASTParserType.NodeJS, true, "EventHorizon.Blazor.BabylonJS.NodeJS", 4);

        // pre-05/26/2024 - 22027ms/19835ms/18236ms to generate.
        // 05/26/2024 - 10116ms/9721ms/9762ms to generate.
        // Run(AstParser.Model.ASTParserType.Sdcb, true, "EventHorizon.Blazor.BabylonJS.WASM", 1);

        // 05/26/2024 - 10545ms/10603ms/10318ms to generate.
        // Run(AstParser.Model.ASTParserType.Sdcb, false, "EventHorizon.Blazor.BabylonJS.Server", 4);

        // 08/16/2024 - 35424ms to generate.
        // Run(AstParser.Model.ASTParserType.NodeJS, false, "EventHorizon.Blazor.BabylonJS.ServerNodeJs", 4);
     }

    static void Run(
        AstParser.Model.ASTParserType type,
        bool useWasm,
        string projectAssembly,
        int maxDegreeOfParallelism
    )
    {
        var stopwatch = Stopwatch.StartNew();
        //var projectAssembly = "EventHorizon.Blazor.BabylonJS.WASM";
        var projectGenerationLocation = Path.Combine("..", "_generated");

        var sourceDirectory = Path.Combine(".", "SourceFiles");
        var textFormatter = new CSharpTextFormatter();
        var sourceFiles = new List<string>
        {
            //"testing.d.ts",
            "babylon.d.ts",
            "babylon.gui.d.ts",
        };
        var generationList = new List<string>
        {
            // "Everything",
            "Scene",
            "VertexBuffer",
            "ICameraInput",
            "AbstractActionManager",
            "ICustomAnimationFrameRequester",
            "IAction",
            "Vector3",
            "EventState",
            "Observable",
            "Container",
            "Control",
            "Button",
            "UniversalCamera",
            "ArcRotateCamera",
            "PointLight",
            "Grid",
            "StackPanel",
            "MeshBuilder",
            "StandardMaterial",
            "Texture",
            "HemisphericLight",
            "PointerInfo",
            "PointerInfoBase",
            "SceneLoader",
            "ParticleHelper",
            "ParticleSystem",
            "Sound",
            "Tools",
        };

        // Remove any already Generated Source.
        if (Directory.Exists(Path.Combine(projectGenerationLocation, projectAssembly)))
        {
            Directory.Delete(Path.Combine(projectGenerationLocation, projectAssembly), true);
        }
        GlobalLogger.Info("Removed Generation Directory");

        if (useWasm)
        {
            GlobalLogger.Info("Running Wasm Generator");
            var writer = new WasmProjectWriter(projectGenerationLocation, projectAssembly);
            new WasmGenerator().Run(
                projectAssembly,
                sourceDirectory,
                sourceFiles,
                generationList,
                writer,
                textFormatter,
                new Dictionary<string, string>
                {
                    ["BABYLON.PointerInfoBase | type"] = "int",
                },
                ["BABYLON.Tensor.R[PropertySignature]", "BABYLON.Matrix.T[PropertyDeclaration]",],
                type,
                maxDegreeOfParallelism
            );
        }
        else
        {
            GlobalLogger.Info("Running Server Generator");
            // For the Server Generator, we don't want to format the text. So we use the NoFormattingTextFormatter.
            // We want to let the Server Project Writer handle the formatting.
            var noFormattingTextFormatter = new NoFormattingTextFormatter();
            var writer = new ServerProjectWriter(
                projectGenerationLocation,
                projectAssembly,
                textFormatter
            );
            new ServerGenerator().Run(
                projectAssembly,
                sourceDirectory,
                sourceFiles,
                generationList,
                writer,
                noFormattingTextFormatter,
                new Dictionary<string, string> { { "BABYLON.PointerInfoBase | type", "int" } },
                ["BABYLON.Tensor.R[PropertySignature]", "BABYLON.Matrix.T[PropertyDeclaration]",],
                type,
                maxDegreeOfParallelism
            );
        }
        stopwatch.Stop();
        GlobalLogger.Info("Removed Generation Directory");
        GlobalLogger.Info($"Took {stopwatch.ElapsedMilliseconds}ms to generate.");
    }
}
