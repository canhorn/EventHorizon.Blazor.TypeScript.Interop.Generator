using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    public static class ConstructorSectionWriter
    {
        public static string Write(
            ClassStatement classStatement,
            ConstructorStatement constructorDetails,
            ClassGenerationTemplates templates
        )
        {
            var arguments = constructorDetails.Arguments;
            if (arguments.Any())
            {
                GlobalLogger.Info($"Generating Argument Constructor: {constructorDetails}");
                var template = templates.ConstructorWithArgumentsTemplate;
                var extendsClass = classStatement.ExtendedType != null;

                // Argument String Generation
                var argumentStrings = new List<string>();
                foreach (var argument in arguments.OrderBy(a => a.IsOptional))
                {
                    var argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]]";
                    if (argument.IsOptional)
                    {
                        argumentsTemplate = "System.Nullable<[[TYPE]][[IS_ARRAY]]> [[NAME]] = null";
                        if (argument.Type.IsNullable)
                        {
                            var genericType = argument.Type.GenericTypes.First();
                            if (ClassIdentifier.Identify(
                                argument.UsedClassNames,
                                genericType.Name
                            ) || genericType.IsNullable
                                || genericType.IsArray
                                || genericType.IsModifier
                                || genericType.Name == GenerationIdentifiedTypes.Action
                                || genericType.Name == GenerationIdentifiedTypes.String
                                || genericType.Name == GenerationIdentifiedTypes.CachedEntity)
                            {
                                argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]] = null";
                            }
                        }
                        else if (ClassIdentifier.Identify(
                            argument.UsedClassNames,
                            argument.Type.Name
                        ) || argument.Type.IsNullable
                            || argument.Type.IsArray
                            || argument.Type.IsModifier
                            || argument.Type.Name == GenerationIdentifiedTypes.Action
                            || argument.Type.Name == GenerationIdentifiedTypes.String
                            || argument.Type.Name == GenerationIdentifiedTypes.CachedEntity)
                        {
                            argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]] = null";
                        }
                    }
                    var argumentString = argumentsTemplate.Replace(
                        "[[NAME]]",
                        DotNetNormalizer.Normalize(argument.Name)
                    ).Replace(
                        "[[TYPE]]",
                        TypeStatementWriter.Write(
                            argument.Type
                        )
                    ).Replace(
                        "[[ARRAY_TYPE]]",
                        TypeStatementWriter.Write(
                            argument.Type,
                            true
                        )
                    ).Replace(
                        "[[NEW_TYPE]]",
                        TypeStatementWriter.Write(
                            argument.Type,
                            true
                        )
                    ).Replace(
                        "[[IS_ARRAY]]",
                        string.Empty
                    );
                    argumentStrings.Add(
                        argumentString
                    );
                }
                var constructorArguments = string.Join(
                    ", ",
                    argumentStrings
                );
                var propertyArguments = string.Join(
                    ", ",
                    arguments.Select(
                        argument => DotNetNormalizer.Normalize(
                            argument.Name
                        )
                    )
                );

                // Generate Namespace
                var entityNamespace = string.Join(
                    ", ",
                    classStatement.Namespace
                        .Split(".")
                        .Select(part => @$"""{part}""")
                );

                return template.Replace(
                    "[[CLASS_NAME]]",
                    classStatement.Name
                ).Replace(
                    "[[ARGUMENTS]]",
                    constructorArguments
                ).Replace(
                    "[[PROPERTY_NAMESPACE]]",
                    entityNamespace
                ).Replace(
                    "[[PROPERTY_ARGUMENTS]]",
                    propertyArguments
                ).Replace(
                    "[[BASE_CLASS_CALL]]",
                    extendsClass ? " : base()" : string.Empty
                );
            }
            return string.Empty;
        }
    }
}
