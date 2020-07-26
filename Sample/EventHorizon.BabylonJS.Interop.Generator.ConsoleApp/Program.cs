namespace EventHorizon.Blazor.TypeScript.Interop.Generator.ConsoleApp
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project;

    public class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            var projectAssembly = "EventHorizon.Blazor.BabylonJS.WASM";
            var projectGenerationLocation = Path.Combine(
                "..",
                "_generated"
            );

            var sourceDirectory = Path.Combine(
                ".",
                "SourceFiles"
            );
            var textFormatter = new NoFormattingTextFormatter();
            var writer = new ProjectWriter(
                projectGenerationLocation,
                projectAssembly
            );
            var sourceFiles = new List<string>
            {
                "babylon.d.ts",
                "babylon.gui.d.ts",
            };
            var generationList = new List<string>
            {
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
            };

            // Remove any already Generated Source.
            if (Directory.Exists(Path.Combine(
                projectGenerationLocation,
                projectAssembly
            )))
            {
                Directory.Delete(
                    Path.Combine(
                        projectGenerationLocation,
                        projectAssembly
                    ),
                    true
                );
            }
            GlobalLogger.Info("Removed Generation Directory");

            new GenerateSource().Run(
                projectAssembly,
                sourceDirectory,
                sourceFiles,
                generationList,
                writer,
                textFormatter,
                new Dictionary<string, string>
                {
                    { "BABYLON.PointerInfoBase | type", "int" }
                }
            );
            stopwatch.Stop();
            GlobalLogger.Info("Removed Generation Directory");
            GlobalLogger.Info($"Took {stopwatch.ElapsedMilliseconds}ms to generate.");

        }
    }
}
