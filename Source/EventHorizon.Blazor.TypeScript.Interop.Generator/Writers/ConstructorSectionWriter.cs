namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    using System.Collections.Generic;
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

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
                    argumentStrings.Add(
                        ArgumentWriter.Write(
                            argument,
                            true,
                            " = null",
                            ignorePrefix: true
                        )
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

                if (entityNamespace == @"""""")
                {
                    entityNamespace = string.Empty;
                }

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
