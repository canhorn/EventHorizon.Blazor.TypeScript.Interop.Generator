//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;
//using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
//using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
//using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
//using EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project;
//using Microsoft.CodeAnalysis.CSharp;
//using Sdcb.TypeScript;

//namespace EventHorizon.Blazor.TypeScript.Interop.Generator
//{
//    public class Program
//    {
//        public static string ProjectAssembly = "EventHorizon.Blazor.BabylonJS.WASM";
//        static void Main(string[] args)
//        {
//            var projectGenerationLocation = @"C:\Users\codya\Source\GitHub\EventHorizon\_generated";

//            var sourceDirectory = Path.Combine(
//                ".",
//                "SourceFiles"
//            );
//            var babylonSourceFile = "babylon.d.ts";
//            var babylonGuiSourceFile = "babylon.gui.d.ts";
//            //var sourceFile = "observable.ts";
//            var sourceFiles = new List<string>
//            {
//                babylonSourceFile,
//                babylonGuiSourceFile,
//            };
//            var generationList = new List<string>
//            {
//                "Scene",
//                "VertexBuffer",
//                "ICameraInput",
//                "AbstractActionManager",
//                "ICustomAnimationFrameRequester",
//                "IAction",
//                "Vector3",
//                "EventState",
//                "Observable",
//                "Container",
//                "Control",
//                "Button",
//                "UniversalCamera",
//                "PointLight",
//                "Grid",
//                "StackPanel",
//            };




//            var sourceFilesAsText = GetSourceFilesAsSingleTextString(
//                sourceDirectory,
//                sourceFiles
//            );
//            var ast = new TypeScriptAST(
//                sourceFilesAsText,
//                "source-combined.ts"
//            );
//            GlobalLogger.Info("Generated AST");
//            var notGeneratedClassNames = new List<string>();

//            var generatedStatements = new List<GeneratedStatement>();
//            var cachedEntityObject = GenerateCachedEntityObject.GenerateClassStatement();
//            generatedStatements.Add(
//                new GeneratedStatement(
//                    cachedEntityObject,
//                    GenerateCachedEntityObject.GenerateString()
//                )
//            );
//            GlobalLogger.Info("Generate Cached Entity Object");

//            var generatedClassStatements = GenerateClassFromList(
//                ast,
//                generationList,
//                notGeneratedClassNames,
//                new List<ClassStatement> { cachedEntityObject }
//            );
//            GlobalLogger.Info("Generate Class From List");

//            generatedClassStatements.Remove(cachedEntityObject);
//            foreach (var generatedStatement in generatedClassStatements)
//            {
//                generatedStatements.Add(
//                    new GeneratedStatement(
//                        generatedStatement,
//                        GenerateClassStatementString.Generate(
//                            generatedStatement
//                        )
//                    )
//                );
//            }
//            GlobalLogger.Info("Generated Statements");

//            foreach (var notGeneratedInterfaceName in notGeneratedClassNames)
//            {
//                var classShim = GenerateClassShim.GenerateClassStatement(
//                    notGeneratedInterfaceName
//                );
//                generatedStatements.Add(
//                    new GeneratedStatement(
//                        classShim,
//                        GenerateClassShim.GenerateString(
//                            classShim
//                        )
//                    )
//                );
//            }
//            GlobalLogger.Info("Generated NOT Generated Class Names");

//            if (Directory.Exists(Path.Combine(
//                projectGenerationLocation,
//                "BabylonJS.Generated"
//            )))
//            {
//                Directory.Delete(
//                    Path.Combine(
//                        projectGenerationLocation,
//                        "BabylonJS.Generated"
//                    ),
//                    true
//                );
//            }
//            GlobalLogger.Warning("Removed Generation Directory");

//            // Create Project
//            new ProjectWriter(
//                projectGenerationLocation,
//                "BabylonJS.Generated"
//            ).Write(
//                generatedStatements
//            );
//            GlobalLogger.Warning("Created Project");

//            //foreach (var message in GlobalLogger.Messages)
//            //{
//            //    //Console.WriteLine(message);
//            //}
//            //GenerateInteropClassStatement.Generate("Button", ast);
//            //GenerateInteropClassStatement.Generate(new List<string> { "BABYLON", "Observable" }, ast);
//        }

//        private static string GetSourceFilesAsSingleTextString(
//            string sourceDirectory,
//            IList<string> sourceFiles
//        )
//        {
//            var stringBuilder = new StringBuilder();

//            sourceFiles.Aggregate(
//                stringBuilder,
//                (acc, sourceFile) => acc.Append(
//                    File.ReadAllText(
//                        Path.Combine(
//                            sourceDirectory,
//                            sourceFile
//                        )
//                    )
//                )
//            );

//            return stringBuilder.ToString();
//        }

//        public static List<ClassStatement> GenerateClassFromList(
//            TypeScriptAST ast,
//            List<string> generationList,
//            List<string> notGeneratedClassNames,
//            List<ClassStatement> generatedStatements
//        )
//        {
//            var stopwatch = Stopwatch.StartNew();
//            if (generatedStatements == null)
//            {
//                generatedStatements = new List<ClassStatement>();
//            }
//            foreach (var classIdentifier in generationList)
//            {
//                if (generatedStatements.Any(a => a.Name == classIdentifier))
//                {
//                    continue;
//                }
//                if (classIdentifier == null)
//                {
//                    GlobalLogger.Error(
//                        $"Was 'null' classIdentifier."
//                    );
//                    continue;
//                }
//                stopwatch.Restart();
//                var generated = GenerateInteropClassStatement.Generate(classIdentifier, ast);
//                stopwatch.Stop();
//                GlobalLogger.Info(
//                    $"Took {stopwatch.ElapsedMilliseconds}ms to generate {classIdentifier}"
//                );
//                if (generated == null)
//                {
//                    GlobalLogger.Error(
//                        $"Was not found in AST. classIdentifier: {classIdentifier}"
//                    );
//                    notGeneratedClassNames.Add(
//                        classIdentifier
//                    );
//                    continue;
//                }
//                generatedStatements.Add(generated);
//                // Add Used Classes and add Generated List
//                var usesClasses = GetAllUsedClasses(generated);
//                var toGenerateList = new List<string>();
//                foreach (var className in usesClasses)
//                {
//                    if (!generatedStatements.Any(a => a.Name == className))
//                    {
//                        toGenerateList.Add(className);
//                    }
//                }
//                generatedStatements = GenerateClassFromList(
//                    ast,
//                    toGenerateList,
//                    notGeneratedClassNames,
//                    generatedStatements
//                );
//            }

//            return generatedStatements;
//        }

//        private static IEnumerable<string> GetAllUsedClasses(ClassStatement generated)
//        {
//            var list = new List<string>();
//            foreach (var className in generated.ExtendedClassNames)
//            {
//                if (!list.Contains(className))
//                {
//                    list.Add(className);
//                }
//            }
//            foreach (var className in generated.ImplementedInterfaceNames)
//            {
//                if (!list.Contains(className))
//                {
//                    list.Add(className);
//                }
//            }
//            foreach (var argument in generated.ConstructorStatement.Arguments)
//            {
//                foreach (var argClassName in argument.UsedClassNames)
//                {
//                    if (!list.Contains(argClassName))
//                    {
//                        list.Add(argClassName);
//                    }
//                }
//            }
//            foreach (var statement in generated.AccessorStatements)
//            {
//                foreach (var className in statement.UsedClassNames)
//                {
//                    if (!list.Contains(className))
//                    {
//                        list.Add(className);
//                    }
//                }
//            }
//            foreach (var statement in generated.PublicMethodStatements)
//            {
//                foreach (var className in statement.UsedClassNames)
//                {
//                    if (!list.Contains(className))
//                    {
//                        list.Add(className);
//                    }
//                }
//                foreach (var argument in statement.Arguments)
//                {
//                    foreach (var argClassName in argument.UsedClassNames)
//                    {
//                        if (!list.Contains(argClassName))
//                        {
//                            list.Add(argClassName);
//                        }
//                    }
//                }
//            }
//            foreach (var statement in generated.PublicPropertyStatements)
//            {
//                foreach (var className in statement.UsedClassNames)
//                {
//                    if (!list.Contains(className))
//                    {
//                        list.Add(className);
//                    }
//                }
//            }
//            return list;
//        }
//    }

//}
