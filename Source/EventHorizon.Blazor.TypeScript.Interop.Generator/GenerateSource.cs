namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;
    using Sdcb.TypeScript;

    public class GenerateSource
    {
        public bool Run(
            string projectAssembly,
            string sourceDirectory,
            IList<string> sourceFiles,
            IList<string> generationList,
            IWriter writer,
            IDictionary<string, string> typeOverrideMap
        )
        {
            var sourceFilesAsText = GetSourceFilesAsSingleTextString(
                sourceDirectory,
                sourceFiles
            );
            var ast = new TypeScriptAST(
                sourceFilesAsText,
                "source-combined.ts"
            );
            GlobalLogger.Info("Generated AST");
            var notGeneratedClassNames = new List<string>();

            var generatedStatements = new List<GeneratedStatement>();
            var cachedEntityObject = GenerateCachedEntityObject.GenerateClassStatement();
            generatedStatements.Add(
                new GeneratedStatement(
                    cachedEntityObject,
                    GenerateCachedEntityObject.GenerateString()
                )
            );
            GlobalLogger.Info("Generate Cached Entity Object");

            var generatedClassStatements = GenerateClassFromList(
                ast,
                projectAssembly,
                generationList,
                notGeneratedClassNames,
                typeOverrideMap,
                new List<ClassStatement> { cachedEntityObject }
            );
            GlobalLogger.Info("Generate Class From List");

            generatedClassStatements.Remove(cachedEntityObject);
            foreach (var generatedStatement in generatedClassStatements)
            {
                generatedStatements.Add(
                    new GeneratedStatement(
                        generatedStatement,
                        GenerateClassStatementString.Generate(
                            generatedStatement
                        )
                    )
                );
            }
            GlobalLogger.Info("Generated Statements");

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
                            GenerateClassShim.GenerateString(
                                classShim
                            )
                        )
                    );
                }
            }
            GlobalLogger.Info("Generated NOT Generated Class Names");

            // Write Generated Statements to Passed in Writer
            writer.Write(
                generatedStatements
            );
            GlobalLogger.Warning("Writer Finished");

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
                (acc, sourceFile) => acc.Append(
                    File.ReadAllText(
                        Path.Combine(
                            sourceDirectory,
                            sourceFile
                        )
                    )
                )
            );

            return stringBuilder.ToString();
        }

        private static IList<ClassStatement> GenerateClassFromList(
            TypeScriptAST ast,
            string projectAssembly,
            IList<string> generationList,
            IList<string> notGeneratedClassNames,
            IDictionary<string, string> typeOverrideMap,
            IList<ClassStatement> generatedStatements
        )
        {
            var stopwatch = Stopwatch.StartNew();
            if (generatedStatements == null)
            {
                generatedStatements = new List<ClassStatement>();
            }
            foreach (var classIdentifier in generationList)
            {
                if (generatedStatements.Any(a => a.Name == classIdentifier)
                    || notGeneratedClassNames.Contains(classIdentifier))
                {
                    continue;
                }
                if (JavaScriptProvidedApiIdentifier.Identify(classIdentifier, out _))
                {
                    if (!notGeneratedClassNames.Contains(classIdentifier))
                    {
                        notGeneratedClassNames.Contains(classIdentifier);
                    }
                    continue;
                }
                if (classIdentifier == null)
                {
                    GlobalLogger.Error(
                        $"Was 'null' classIdentifier."
                    );
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
                        GlobalLogger.Error(
                            $"Was not found in AST. classIdentifier: {classIdentifier}"
                        );
                        notGeneratedClassNames.Add(
                            classIdentifier
                        );
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
            foreach (var className in generated.ExtendedClassNames)
            {
                if (!list.Contains(className))
                {
                    list.Add(className);
                }
            }
            foreach (var className in generated.ImplementedInterfaceNames)
            {
                if (!list.Contains(className))
                {
                    list.Add(className);
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
