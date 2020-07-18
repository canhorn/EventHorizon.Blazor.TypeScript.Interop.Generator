using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class TypeIdentifier
    {
        public static string Identify(
            Node node,
            ClassMetadata classMetadata
        )
        {
            var type = GetFromNode(
                node,
                node.Kind,
                classMetadata
            );
            if (JavaScriptProvidedApiIdentifier.Identify(
                type,
                out var jsType
            ))
            {
                type = jsType;
            }
            if (VoidTypeParameterIdentifier.Identify(
                node,
                type,
                out var voidType
            ))
            {
                type = voidType;
            }

            return type;
        }


        public static string GetFromNode(
            Node node,
            SyntaxKind kind,
            ClassMetadata classMetadata
        )
        {
            return kind switch
            {
                SyntaxKind.UnionType => UnionTypeCheck(
                    node,
                    classMetadata
                ),
                SyntaxKind.ParenthesizedType => ParenthesizedTypeCheck(
                    node,
                    classMetadata
                ),
                SyntaxKind.FunctionType => GenerationIdentifiedTypes.Action,
                SyntaxKind.VoidKeyword => GenerationIdentifiedTypes.Void,
                SyntaxKind.StringKeyword => GenerationIdentifiedTypes.String,
                SyntaxKind.BooleanKeyword => GenerationIdentifiedTypes.Bool,
                SyntaxKind.NumberKeyword => GenerationIdentifiedTypes.Number,
                SyntaxKind.ObjectKeyword => GenerationIdentifiedTypes.CachedEntity,
                SyntaxKind.LiteralType => GenerationIdentifiedTypes.Literal,
                SyntaxKind.TypeLiteral => GenerationIdentifiedTypes.Literal,
                SyntaxKind.ArrayType => GenerationIdentifiedTypes.Array,
                // All Other Types
                _ => AllOtherTypeChecks(
                    node,
                    classMetadata
                ),
            };
        }

        private static string UnionTypeCheck(
            Node node,
            ClassMetadata classMetadata
        )
        {
            var firstNode = node.Children.FirstOrDefault(
                childNode => childNode.Kind != SyntaxKind.NullKeyword
                    && childNode.Kind != SyntaxKind.UndefinedKeyword
            );
            if (firstNode == null)
            {
                return GenerationIdentifiedTypes.Unknown;
            }
            return GetFromNode(
                firstNode,
                firstNode.Kind,
                classMetadata
            );
        }

        private static string ParenthesizedTypeCheck(
            Node node,
            ClassMetadata classMetadata
        )
        {
            if (node is ParenthesizedTypeNode typedNode)
            {
                return GetFromNode(
                    node.First,
                    node.First.Kind,
                    classMetadata
                );
            }
            if (node.Kind == SyntaxKind.FunctionType)
            {
                return GetFromNode(
                    node,
                    node.First.Kind,
                    classMetadata
                );
            }
            return GetFromNode(
                node,
                node.First.First.Kind,
                classMetadata
            );
        }

        private static string AllOtherTypeChecks(
            Node node,
            ClassMetadata classMetadata
        )
        {
            if (node.Kind == SyntaxKind.AnyKeyword)
            {
                return GenerationIdentifiedTypes.CachedEntity;
            }
            else if (node.Kind == SyntaxKind.ThisType)
            {
                return classMetadata.Name;
            }
            else if (node.IdentifierStr != null)
            {
                return node.IdentifierStr;
            }
            else if (IsNamespace(node))
            {
                return GetNamespacesType(node);
            }
            return GenerationIdentifiedTypes.Unknown;
        }

        private static bool IsNamespace(
            Node node
        )
        {
            return node is TypeReferenceNode typedNode
                && typedNode.TypeName != null;
        }

        private static string GetNamespacesType(
            Node node
        )
        {
            if (node is TypeReferenceNode typedNode)
            {
                if (typedNode.TypeArguments != null
                    && typedNode.TypeArguments.Any())
                {
                    return typedNode.First.Last.IdentifierStr;
                }
            }
            return node.Last.Last.IdentifierStr;
        }
    }
}
