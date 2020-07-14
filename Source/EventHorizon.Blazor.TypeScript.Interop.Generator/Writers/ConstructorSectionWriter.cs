using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

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
                var extendsClass = classStatement.ExtendedClassNames.Any();

                // Argument String Generation
                var argumentStrings = new List<string>();
                foreach (var argument in arguments.OrderBy(a => a.IsOptional))
                {
                    // Method Signature String
                    // Standard: [[TYPE]][[IS_ARRAY]] [[NAME]]
                    // Optional: System.Nullable<[[TYPE]][[IS_ARRAY]]> [[NAME]]
                    var argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]]";
                    if (argument.IsOptional)
                    {
                        argumentsTemplate = "System.Nullable<[[TYPE]][[IS_ARRAY]]> [[NAME]] = null";
                        if (ClassIdentifier.Identify(
                            argument.UsedClassNames,
                            argument.Type
                        ) || argument.IsArrayResponse)
                        {
                            argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]] = null";
                        }
                    }
                    var argumentString = argumentsTemplate.Replace(
                        "[[NAME]]",
                        argument.Name
                    ).Replace(
                        "[[TYPE]]",
                        argument.Type
                    ).Replace(
                        "[[IS_ARRAY]]",
                        argument.IsArrayResponse ? "[]" : string.Empty
                    );
                    argumentStrings.Add(argumentString);
                }
                var constructorArguments = string.Join(
                    ", ",
                    argumentStrings
                );
                var propertyArguments = string.Join(
                    ", ",
                    arguments.Select(
                        argument => argument.Name
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
