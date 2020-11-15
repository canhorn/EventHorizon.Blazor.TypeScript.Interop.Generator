using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    class ArgumentWriter
    {
        public static string Write(
            ArgumentStatement argument,
            bool includeName,
            string defaultValue,
            bool ignorePrefix = true
        )
        {
            var argumentsTemplate = "[[TYPE]] [[NAME]]";
            if (argument.IsOptional)
            {
                argumentsTemplate = GenericTypeWriter(
                    argument.Type,
                    argument.UsedClassNames,
                    includeName
                ).Replace(
                    "[[DEFAULT_VALUE]]",
                    defaultValue
                );
            }
            return argumentsTemplate.Replace(
                "[[NAME]]",
                DotNetNormalizer.Normalize(argument.Name)
            ).Replace(
                "[[TYPE]]",
                TypeStatementWriter.Write(
                    argument.Type,
                    true,
                    ignorePrefix
                )
            );
        }

        private static string GenericTypeWriter(
            TypeStatement typeStatement,
            IList<string> usedClassNames,
            bool includeName
        )
        {
            var argumentsTemplate = "System.Nullable<[[TYPE]]>[[NAME]][[DEFAULT_VALUE]]";
            if (typeStatement.IsTypeAlias)
            {
                return GenericTypeWriter(
                    typeStatement.AliasType,
                    usedClassNames,
                    includeName
                );
            }
            else if (typeStatement.IsNullable)
            {
                var genericType = typeStatement.GenericTypes.First();

                if (!genericType.IsEnum
                    && (ClassIdentifier.Identify(
                        usedClassNames,
                        genericType.Name
                    ) || genericType.IsNullable
                        || genericType.IsArray
                        || genericType.IsModifier
                        || genericType.IsAction
                        || genericType.IsTypeAlias
                        || genericType.Name == GenerationIdentifiedTypes.String
                        || genericType.Name == GenerationIdentifiedTypes.CachedEntity
                    )
                )
                {
                    argumentsTemplate = "[[TYPE]][[NAME]][[DEFAULT_VALUE]]";
                }
            }
            else if (!typeStatement.IsEnum 
                && (ClassIdentifier.Identify(
                    usedClassNames,
                    typeStatement.Name
                ) || typeStatement.IsNullable
                    || typeStatement.IsArray
                    || typeStatement.IsModifier
                    || typeStatement.IsAction
                    || typeStatement.Name == GenerationIdentifiedTypes.String
                    || typeStatement.Name == GenerationIdentifiedTypes.CachedEntity
                )
            )
            {
                argumentsTemplate = "[[TYPE]][[NAME]][[DEFAULT_VALUE]]";
            }

            return argumentsTemplate.Replace(
                "[[NAME]]",
                includeName ? " [[NAME]]" : string.Empty
            );
        }
    }
}
