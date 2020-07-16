using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    class UnionTypeIdentifier
    {
        private static IRule IsUnionTypeRule = new IsUnionType();
        internal static bool Identify(
            ParameterDeclaration parameter,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList,
            out string type
        )
        {
            type = GenerationIdentifiedTypes.Literal;
            if (IsUnionTypeRule.Check(parameter))
            {
                var children = parameter.OfKind(
                    SyntaxKind.UnionType
                ).FirstOrDefault()
                .Children.Where(
                    // Make sure does not contain undefined
                    a => a.Kind != SyntaxKind.UndefinedKeyword
                        && a.Kind != SyntaxKind.NullKeyword
                ).ToList();
                // Find type of nonObject when contains class
                if (!children.All(a => a.Kind == SyntaxKind.TypeReference))
                {
                    var identifiedChild = children.Where(
                        a => a.Kind != SyntaxKind.TypeReference
                    ).Select(
                        a => TypeIdentifier.Identify(
                            a.Last != null ? a : new Node()
                            {
                                Children = new List<Node> { a }
                            },
                            classMetadata,
                            usedTypeParamterList
                        )
                    ).FirstOrDefault();
                    if (identifiedChild != null)
                    {
                        type = identifiedChild;
                    }
                }
                else if (children.Count(a => a.Kind == SyntaxKind.TypeReference) == 1)
                {
                    var identifiedChild = children.Where(
                        a => a.Kind == SyntaxKind.TypeReference
                    ).Select(
                        a => a.IdentifierStr
                    ).FirstOrDefault();
                    if (identifiedChild != null)
                    {
                        type = identifiedChild;
                    }
                }
                if (type == GenerationIdentifiedTypes.Unknown)
                {
                    return false;
                }

                return true;
            }
            return false;
        }
    }
}
