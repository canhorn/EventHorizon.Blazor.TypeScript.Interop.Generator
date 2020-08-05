using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
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

            return type;
        }


        public static string GetFromNode(
            Node node,
            SyntaxKind kind,
            ClassMetadata classMetadata
        )
        {
            switch (kind)
            {
                case SyntaxKind.UnionType:
                    return UnionTypeCheck(
                        node,
                        classMetadata
                    );
                case SyntaxKind.ParenthesizedType:
                    return ParenthesizedTypeCheck(
                        node,
                        classMetadata
                    );
                case SyntaxKind.FunctionType:
                    return GenerationIdentifiedTypes.Action;
                case SyntaxKind.VoidKeyword:
                    return GenerationIdentifiedTypes.Void;
                case SyntaxKind.StringKeyword:
                    return GenerationIdentifiedTypes.String;
                case SyntaxKind.BooleanKeyword:
                    return GenerationIdentifiedTypes.Bool;
                case SyntaxKind.NumberKeyword:
                    return GenerationIdentifiedTypes.Number;
                case SyntaxKind.ObjectKeyword:
                    return GenerationIdentifiedTypes.CachedEntity;
                case SyntaxKind.LiteralType:
                case SyntaxKind.TypeLiteral:
                    return GenerationIdentifiedTypes.Literal;
                case SyntaxKind.ArrayType:
                    return GenerationIdentifiedTypes.Array;
                default:
                    return AllOtherTypeChecks(
                        node,
                        classMetadata
                    );
            }
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
            return GetFromNode(
                node.First,
                node.First.Kind,
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
            else if (node.Kind == SyntaxKind.Parameter)
            {
                if (node is ParameterDeclaration parameterDeclaration)
                {
                    return GetFromNode(
                        parameterDeclaration.Type as Node,
                        parameterDeclaration.Type.Kind,
                        classMetadata
                    );
                }
                return classMetadata.Name;
            }
            else if (node.IdentifierStr != null)
            {
                return node.IdentifierStr;
            }
            // Is Probably a Namespace
            return GetNamespacesType(node);
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
            return node.OfKind(
                SyntaxKind.Identifier
            ).LastOrDefault()?.IdentifierStr ?? GenerationIdentifiedTypes.Unknown;
        }
    }
}
