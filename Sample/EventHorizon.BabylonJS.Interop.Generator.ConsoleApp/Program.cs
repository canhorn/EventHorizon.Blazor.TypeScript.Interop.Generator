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
            Run(AstParser.Model.ASTParserType.NodeJS);
            //Run(AstParser.Model.ASTParserType.Sdcb);
        }
        static void Run(AstParser.Model.ASTParserType type)
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
                "testing.d.ts",
                //"babylon.d.ts",
                //"babylon.gui.d.ts",
            };
            var generationList = new List<string>
            {
                "Everything",
                //"Scene",
                //"VertexBuffer",
                //"ICameraInput",
                //"AbstractActionManager",
                //"ICustomAnimationFrameRequester",
                //"IAction",
                //"Vector3",
                //"EventState",
                //"Observable",
                //"Container",
                //"Control",
                //"Button",
                //"UniversalCamera",
                //"ArcRotateCamera",
                //"PointLight",
                //"Grid",
                //"StackPanel",
                //"MeshBuilder",
                //"StandardMaterial",
                //"Texture",
                //"HemisphericLight",
                //"PointerInfo",
                //"PointerInfoBase",
                //"SceneLoader",
                //"ParticleHelper",
                //"Sound",
                //"Tools",
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
                },
                type
            );
            stopwatch.Stop();
            GlobalLogger.Info("Removed Generation Directory");
            GlobalLogger.Info($"Took {stopwatch.ElapsedMilliseconds}ms to generate.");
        }
    }
}
