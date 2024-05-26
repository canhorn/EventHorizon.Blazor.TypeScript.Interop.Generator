namespace EventHorizon.Blazor.TypeScript.Interop.Generator.ConsoleApp
{
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
            //Run(AstParser.Model.ASTParserType.NodeJS, true); //  75084ms/71877ms to generate.
            Run(AstParser.Model.ASTParserType.Sdcb, true, "EventHorizon.Blazor.BabylonJS.WASM"); //  22027ms/19835ms/18236ms to generate.
            //Run(
            //    AstParser.Model.ASTParserType.Sdcb,
            //    false,
            //    "EventHorizon.Blazor.BabylonJS.Server"
            //);
        }

        static void Run(AstParser.Model.ASTParserType type, bool useWasm, string projectAssembly)
        {
            var stopwatch = Stopwatch.StartNew();
            //var projectAssembly = "EventHorizon.Blazor.BabylonJS.WASM";
            var projectGenerationLocation = Path.Combine("..", "_generated");

            var sourceDirectory = Path.Combine(".", "SourceFiles");
            var textFormatter = new NoFormattingTextFormatter();
            var sourceFiles = new List<string>
            {
                //"testing.d.ts",
                "babylon.d.ts",
                "babylon.gui.d.ts",
            };
            var generationList = new List<string>
            {
                //"Everything",
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
                    new Dictionary<string, string> { { "BABYLON.PointerInfoBase | type", "int" } },
                    type
                );
            }
            else
            {
                GlobalLogger.Info("Running Server Generator");
                var writer = new ServerProjectWriter(projectGenerationLocation, projectAssembly);
                new ServerGenerator().Run(
                    projectAssembly,
                    sourceDirectory,
                    sourceFiles,
                    generationList,
                    writer,
                    textFormatter,
                    new Dictionary<string, string> { { "BABYLON.PointerInfoBase | type", "int" } },
                    type
                );
            }
            stopwatch.Stop();
            GlobalLogger.Info("Removed Generation Directory");
            GlobalLogger.Info($"Took {stopwatch.ElapsedMilliseconds}ms to generate.");
        }
    }
}
