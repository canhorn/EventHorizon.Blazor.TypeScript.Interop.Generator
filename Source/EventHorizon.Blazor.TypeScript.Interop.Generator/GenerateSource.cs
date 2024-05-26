namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;

    public class GenerateSource
    {
        public static void DisableCache()
        {
            InterfaceResponseTypeIdentifier.DisableCache();
            EnumTypeIdentifier.DisableCache();
            AliasTypeIdentifier.DisableCache();
        }

        public bool Run(
            string projectAssembly,
            string sourceDirectory,
            IList<string> sourceFiles,
            IList<string> generationList,
            IWriter writer,
            TextFormatter textFormatter,
            IDictionary<string, string> typeOverrideMap,
            ASTParserType parserType = ASTParserType.Sdcb
        )
        {
            var overallStopwatch = Stopwatch.StartNew();
            var stopwatch = Stopwatch.StartNew();
            GlobalLogger.Info($"=== Consolidate Source Files");
            var sourceFilesAsText = GetSourceFilesAsSingleTextString(sourceDirectory, sourceFiles);
            GlobalLogger.Info(
                $"=== Consolidated Source Files | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );

            stopwatch.Restart();
            GlobalLogger.Info($"=== Generated AST - {parserType}");
            var ast = ASTParser.ParseText(
                sourceFilesAsText,
                new ASTParserOptions { ParserType = parserType, }
            );
            GlobalLogger.Info(
                $"=== Generated AST | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );
            var notGeneratedClassNames = new List<string>();

            var generatedStatements = new List<GeneratedStatement>();
            stopwatch.Restart();
            GlobalLogger.Info($"=== Generate Cached Entity Object");
            var cachedEntityObject = GenerateCachedEntityObject.GenerateClassStatement();
            generatedStatements.Add(
                new GeneratedStatement(
                    cachedEntityObject,
                    GenerateCachedEntityObject.GenerateString()
                )
            );
            GlobalLogger.Info(
                $"=== Generated Cached Entity Object | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );

            stopwatch.Restart();
            GlobalLogger.Info($"=== Generate Class Statements");
            var generatedClassStatements = GenerateClassFromList(
                ast,
                projectAssembly,
                generationList,
                notGeneratedClassNames,
                typeOverrideMap,
                new List<ClassStatement> { cachedEntityObject }
            );
            generatedClassStatements.Remove(cachedEntityObject);
            GlobalLogger.Info(
                $"=== Generated Class Statements | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );

            stopwatch.Restart();
            GlobalLogger.Info($"=== Generate Statements");
            foreach (var generatedStatement in generatedClassStatements)
            {
                generatedStatements.Add(
                    new GeneratedStatement(
                        generatedStatement,
                        GenerateClassStatementString.Generate(generatedStatement, textFormatter)
                    )
                );
            }
            GlobalLogger.Info(
                $"=== Generated Statements | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );

            stopwatch.Restart();
            GlobalLogger.Info($"=== Generating Shimmed Classes");
            foreach (var notGeneratedInterfaceName in notGeneratedClassNames)
            {
                if (!JavaScriptProvidedApiIdentifier.Identify(notGeneratedInterfaceName, out _))
                {
                    var classShim = GenerateClassShim.GenerateClassStatement(
                        notGeneratedInterfaceName
                    );
                    generatedStatements.Add(
                        new GeneratedStatement(
                            classShim,
                            textFormatter.Format(GenerateClassShim.GenerateString(classShim))
                        )
                    );
                    GlobalLogger.Info($"=== Generated Shimmed Class: {notGeneratedInterfaceName}");
                }
            }
            GlobalLogger.Info(
                $"=== Generated Shimmed Classes | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );

            // Write Generated Statements to Passed in Writer
            stopwatch.Restart();
            GlobalLogger.Info($"=== Writing Generated Statements");
            writer.Write(generatedStatements);
            GlobalLogger.Info(
                $"=== Finished Writing Generated Statements | ElapsedTime: {stopwatch.ElapsedMilliseconds}ms"
            );

            GlobalLogger.Success(
                $"=== Finished Run | ElapsedTime: {overallStopwatch.ElapsedMilliseconds}ms"
            );

            return true;
        }

        private static string GetSourceFilesAsSingleTextString(
            string sourceDirectory,
            IList<string> sourceFiles
        )
        {
            var stringBuilder = new StringBuilder();

            sourceFiles.Aggregate(
                stringBuilder,
                (acc, sourceFile) =>
                    acc.Append(File.ReadAllText(Path.Combine(sourceDirectory, sourceFile)))
            );

            return stringBuilder.ToString();
        }

        private static IList<ClassStatement> GenerateClassFromList(
            AbstractSyntaxTree ast,
            string projectAssembly,
            IList<string> generationList,
            IList<string> notGeneratedClassNames,
            IDictionary<string, string> typeOverrideMap,
            IList<ClassStatement> generatedStatements
        )
        {
            var stopwatch = Stopwatch.StartNew();
            foreach (var classIdentifier in generationList)
            {
                if (
                    generatedStatements.Any(a => a.Name == classIdentifier)
                    || notGeneratedClassNames.Contains(classIdentifier)
                )
                {
                    continue;
                }
                stopwatch.Restart();
                var generated = GenerateInteropClassStatement.Generate(
                    projectAssembly,
                    classIdentifier,
                    ast,
                    typeOverrideMap
                );
                stopwatch.Stop();
                GlobalLogger.Info(
                    $"Took {stopwatch.ElapsedMilliseconds}ms to generate {classIdentifier}"
                );
                if (generated == null)
                {
                    if (!notGeneratedClassNames.Contains(classIdentifier))
                    {
                        GlobalLogger.Warning(
                            $"Was not found in AST. Adding to Shim Generation List. classIdentifier: {classIdentifier}"
                        );
                        notGeneratedClassNames.Add(classIdentifier);
                    }
                    continue;
                }
                generatedStatements.Add(generated);
                // Add Used Classes and add Generated List
                var usesClasses = GetAllUsedClasses(generated);
                var toGenerateList = new List<string>();
                foreach (var className in usesClasses)
                {
                    if (!generatedStatements.Any(a => a.Name == className))
                    {
                        toGenerateList.Add(className);
                    }
                }
                generatedStatements = GenerateClassFromList(
                    ast,
                    projectAssembly,
                    toGenerateList,
                    notGeneratedClassNames,
                    typeOverrideMap,
                    generatedStatements
                );
            }

            return generatedStatements;
        }

        private static IEnumerable<string> GetAllUsedClasses(ClassStatement generated)
        {
            var list = new List<string>();
            if (generated.ExtendedType != null)
            {
                var usedClassNames = UsedClassNamesIdentifier.Identify(generated.ExtendedType);
                foreach (var usedClassName in usedClassNames)
                {
                    if (!list.Contains(usedClassName))
                    {
                        list.Add(usedClassName);
                    }
                }
            }
            foreach (var extendedType in generated.GenericTypes)
            {
                var usedClassNames = UsedClassNamesIdentifier.Identify(extendedType);
                foreach (var usedClassName in usedClassNames)
                {
                    if (!list.Contains(usedClassName))
                    {
                        list.Add(usedClassName);
                    }
                }
            }
            foreach (var interfaceType in generated.ImplementedInterfaces)
            {
                var usedClassNames = UsedClassNamesIdentifier.Identify(interfaceType);
                foreach (var usedClassName in usedClassNames)
                {
                    if (!list.Contains(usedClassName))
                    {
                        list.Add(usedClassName);
                    }
                }
            }
            foreach (var argument in generated.ConstructorStatement.Arguments)
            {
                foreach (var argClassName in argument.UsedClassNames)
                {
                    if (!list.Contains(argClassName))
                    {
                        list.Add(argClassName);
                    }
                }
            }
            foreach (var statement in generated.AccessorStatements)
            {
                foreach (var className in statement.UsedClassNames)
                {
                    if (!list.Contains(className))
                    {
                        list.Add(className);
                    }
                }
            }
            foreach (var statement in generated.PublicMethodStatements)
            {
                foreach (var className in statement.UsedClassNames)
                {
                    if (!list.Contains(className))
                    {
                        list.Add(className);
                    }
                }
                foreach (var argument in statement.Arguments)
                {
                    foreach (var argClassName in argument.UsedClassNames)
                    {
                        if (!list.Contains(argClassName))
                        {
                            list.Add(argClassName);
                        }
                    }
                }
            }
            foreach (var statement in generated.PublicPropertyStatements)
            {
                foreach (var className in statement.UsedClassNames)
                {
                    if (!list.Contains(className))
                    {
                        list.Add(className);
                    }
                }
            }
            return list;
        }
    }
}
