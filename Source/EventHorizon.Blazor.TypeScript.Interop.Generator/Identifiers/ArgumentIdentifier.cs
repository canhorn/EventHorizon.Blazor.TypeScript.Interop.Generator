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
        private static readonly IRule IsArrayResponseTypeRule = new IsArrayResponseType();
        private static readonly IRule IsOptionalRule = new IsOptional();

        internal static IList<ArgumentStatement> Identify(
            Node node,
            ClassMetadata classMetadata
        )
        {
            var methodTypeParameters = TypeParameterIdentifier.Identify(node);
            var parameters = node.Children
                .Where(childNode => childNode.Kind == SyntaxKind.Parameter)
                .Cast<ParameterDeclaration>()
                .Select(parameter =>
                {
                    var type = GenerationIdentifiedTypes.Literal;
                    if (!UnionTypeIdentifier.Identify(
                        parameter,
                        classMetadata,
                        methodTypeParameters,
                        out type
                    ))
                    {
                        type = TypeIdentifier.Identify(
                            parameter,
                            classMetadata,
                            methodTypeParameters
                        );
                    }
                    if (type == GenerationIdentifiedTypes.Object)
                    {
                        type = GenerationIdentifiedTypes.Literal;
                    }

                    return new ArgumentStatement
                    {
                        Name = parameter.IdentifierStr,
                        Type = type,
                        IsArrayResponse = IsArrayResponseTypeRule.Check(
                            parameter
                        ),
                        IsOptional = IsOptionalRule.Check(
                            parameter
                        ),
                        UsedClassNames = UsedClassNamesIdentifier.Identify(
                            parameter,
                            classMetadata
                        ),
                    };
                }).ToList();

            return parameters;
        }
    }
}
