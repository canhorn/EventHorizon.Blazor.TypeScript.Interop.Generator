using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript.TsTypes;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using System.Diagnostics;
using Sdcb.TypeScript;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class ArgumentIdentifier
    {
        private static readonly IRule IsOptionalRule = new IsOptional();

        internal static IList<ArgumentStatement> Identify(
            Node node,
            ClassMetadata classMetadata,
            IDictionary<string, string> typeOverrideMap,
            bool isStatic = false
        )
        {
            var methodTypeParameters = TypeParameterIdentifier.Identify(node);
            var parameters = node.Children
                .Where(childNode => childNode.Kind == SyntaxKind.Parameter)
                .Cast<ParameterDeclaration>()
                .Select(parameter =>
                {
                    var type = GenericTypeIdentifier.Identify(
                        parameter.Last,
                        classMetadata
                    );
                    if (UnionTypeIdentifier.Identify(
                        parameter,
                        classMetadata,
                        methodTypeParameters,
                        out var typeName
                    ))
                    {
                        type = new TypeStatement
                        {
                            Name = typeName,
                        };
                    }
                    if (type.Name == GenerationIdentifiedTypes.CachedEntity)
                    {
                        type.Name = GenerationIdentifiedTypes.Object;
                    }

                    ConvertIdentifiedActionTypes(
                        type
                    );

                    var name = parameter.IdentifierStr;
                    var methodOrConstructorName = node.IdentifierStr;
                    if (node.Kind == SyntaxKind.Constructor)
                    {
                        methodOrConstructorName = Constants.TYPESCRIPT_CONSTRUCTOR_NAME;
                    }
                    if (TypeOverrideIdentifier.Identify(
                        TypeOverrideDeclarationIdentifier.IdentifyArgument(
                            classMetadata,
                            isStatic,
                            methodOrConstructorName,
                            name
                        ),
                        typeOverrideMap,
                        type,
                        out var overrideType
                    ))
                    {
                        type = overrideType;
                    }

                    return new ArgumentStatement
                    {
                        Name = parameter.IdentifierStr,
                        Type = type,
                        IsOptional = IsOptionalRule.Check(
                            parameter
                        ),
                        UsedClassNames = UsedClassNamesIdentifier.Identify(
                            type
                        ),
                    };
                }).ToList();

            return parameters;
        }

        private static void ConvertIdentifiedActionTypes(
            TypeStatement type
        )
        {
            if (type.Name == GenerationIdentifiedTypes.Action)
            {
                // TODO: [ACTION] : Callback action implementation
            }
            foreach (var genericType in type.GenericTypes)
            {
                ConvertIdentifiedActionTypes(
                    genericType
                );
            }
        }
    }
}
