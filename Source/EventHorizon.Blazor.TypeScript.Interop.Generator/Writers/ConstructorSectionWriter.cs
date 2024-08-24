namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;
using Microsoft.CodeAnalysis;

public static class ConstructorSectionWriter
{
    public static string Write(
        ClassStatement classStatement,
        ConstructorStatement constructorDetails,
        ConcurrentDictionary<string, ClassStatement> generatedClassStatements,
        ClassGenerationTemplates templates,
        string overrideClassName = null
    )
    {
        var processedStatements = new List<ClassStatement>() { classStatement };
        var generatedConstructors = new List<string>();
        var constructorSection = WriteClassConstructor(
            classStatement,
            constructorDetails,
            templates,
            overrideClassName
        );
        generatedConstructors.Add(constructorSection);

        if (classStatement.ExtendedType != null)
        {
            var extendedTypeClassStatements = GetConstructorSections(
                classStatement,
                generatedClassStatements,
                templates
            );
            foreach (var extendedStatement in extendedTypeClassStatements)
            {
                var generatedConstructor = WriteClassConstructor(
                    extendedStatement,
                    extendedStatement.ConstructorStatement,
                    templates,
                    classStatement.Name,
                    true
                );
                if (
                    generatedConstructors.Contains(generatedConstructor)
                    // Check for same parameter types
                    || processedStatements.Contains(extendedStatement)
                    || processedStatements.Any(statement =>
                        statement
                            .ConstructorStatement.Arguments?.Select(a => a.Type.ToType())
                            .OrderBy(t => t)
                            .SequenceEqual(
                                extendedStatement
                                    .ConstructorStatement?.Arguments?.Select(a => a.Type.ToType())
                                    ?.OrderBy(t => t)
                            ) ?? false
                    )
                )
                {
                    continue;
                }
                constructorSection += Environment.NewLine;
                constructorSection += Environment.NewLine;
                constructorSection += generatedConstructor;
                processedStatements.Add(extendedStatement);
                generatedConstructors.Add(generatedConstructor);
            }

            static List<ClassStatement> GetConstructorSections(
                ClassStatement classStatement,
                ConcurrentDictionary<string, ClassStatement> generatedClassStatements,
                ClassGenerationTemplates templates
            )
            {
                if (classStatement.ExtendedType == null)
                {
                    return [];
                }

                var extendedTypeClassStatements = new List<ClassStatement>();
                if (
                    generatedClassStatements.TryGetValue(
                        classStatement.ExtendedType.Name,
                        out var extendedTypeClassStatementResult
                    )
                )
                {
                    extendedTypeClassStatements.Add(extendedTypeClassStatementResult);
                    extendedTypeClassStatements.AddRange(
                        GetConstructorSections(
                            extendedTypeClassStatementResult,
                            generatedClassStatements,
                            templates
                        )
                    );
                }
                return extendedTypeClassStatements;
            }
        }

        return constructorSection;
    }

    private static string WriteClassConstructor(
        ClassStatement classStatement,
        ConstructorStatement constructorDetails,
        ClassGenerationTemplates templates,
        string overrideClassName,
        bool extendsClassOverride = false
    )
    {
        var arguments = constructorDetails.Arguments;
        var constructorSection = string.Empty;
        if (!arguments.Any())
        {
            return constructorSection;
        }
        GlobalLogger.Info(
            $"Generating Argument Constructor: {classStatement.Name}.{constructorDetails}"
        );
        var template = templates.ConstructorWithArgumentsTemplate;
        var extendsClass = extendsClassOverride || classStatement.ExtendedType != null;

        // Argument String Generation
        var argumentStrings = new List<string>();
        foreach (var argument in arguments.OrderBy(a => a.IsOptional))
        {
            argumentStrings.Add(
                ArgumentWriter.Write(argument, true, " = null", ignorePrefix: true)
            );
        }
        var constructorArguments = string.Join(", ", argumentStrings);
        var propertyArguments = string.Join(
            ", ",
            arguments.Select(argument => DotNetNormalizer.Normalize(argument.Name))
        );

        // Generate Namespace
        var entityNamespace =
            string.Join(", ", classStatement.Namespace.Split(".").Select(part => @$"""{part}"""))
            + ", ";

        if (entityNamespace == @""""", ")
        {
            entityNamespace = string.Empty;
        }

        constructorSection += template
            .Replace("[[CLASS_NAME]]", overrideClassName ?? classStatement.Name)
            .Replace("[[ARGUMENTS]]", constructorArguments)
            .Replace("[[PROPERTY_NAMESPACE]]", entityNamespace)
            .Replace("[[PROPERTY_ARGUMENTS]]", propertyArguments)
            .Replace("[[BASE_CLASS_CALL]]", extendsClass ? " : base()" : string.Empty);

        return constructorSection;
    }
}
