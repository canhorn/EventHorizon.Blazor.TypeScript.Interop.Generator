namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

public static class ArgumentIdentifier
{
    private static readonly IRule IsOptionalRule = new IsOptional();

    internal static IList<ArgumentStatement> Identify(
        Node node,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        var methodTypeParameters = TypeParameterIdentifier.Identify(node);
        var parameters = node
            .Children.Where(childNode => childNode.Kind == SyntaxKind.Parameter)
            .Select(parameter =>
            {
                var type = GenericTypeIdentifier.Identify(
                    parameter.Last,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
                if (
                    UnionTypeIdentifier.Identify(
                        parameter,
                        classMetadata,
                        ast,
                        typeOverrideDetails,
                        out var unionType
                    )
                )
                {
                    type = unionType;
                }
                if (type.Name == GenerationIdentifiedTypes.CachedEntity)
                {
                    type.Name = GenerationIdentifiedTypes.Object;
                }
                if (type.Name == GenerationIdentifiedTypes.Action)
                {
                    type.GenericTypes = type.Arguments.Select(a => a.Type);
                }

                var name = parameter.IdentifierStr;
                var methodOrConstructorName = node.IdentifierStr;
                if (node.Kind == SyntaxKind.Constructor)
                {
                    methodOrConstructorName = Constants.TYPESCRIPT_CONSTRUCTOR_NAME;
                }
                if (
                    TypeOverrideIdentifier.Identify(
                        TypeOverrideDeclarationIdentifier.IdentifyArgument(
                            classMetadata,
                            typeOverrideDetails.IsStatic,
                            methodOrConstructorName,
                            name
                        ),
                        typeOverrideDetails.TypeOverrideMap,
                        type,
                        out var overrideType
                    )
                )
                {
                    type = overrideType;
                }

                return new ArgumentStatement
                {
                    Name = parameter.IdentifierStr,
                    Type = type,
                    IsOptional = IsOptionalRule.Check(parameter),
                    UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                };
            })
            .ToList();

        return parameters;
    }
}
