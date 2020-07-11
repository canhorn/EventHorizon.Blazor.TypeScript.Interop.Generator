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
        static readonly IRule IsObservablePropertyRule = new IsObservableProperty();
        static readonly IRule IsTypeLiteralRule = new IsTypeLiteral();
        static readonly IRule IsArrayResponseTypeRule = new IsArrayResponseType();

        public static string Identify(
            Node node,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList
        )
        {
            if (node.Last == null)
            {
                return GenerationIdentifiedTypes.Unknown;
            }
            var type = GetFromNode(
                node,
                node.Last.Kind,
                classMetadata,
                usedTypeParamterList
            );
            if (JavaScriptProvidedApiIdentifier.Identify(
                type, out var jsType
            ))
            {
                type = jsType;
            }
            if (NullableTypeIdentifier.Identify(
                type, 
                node.Last,
                classMetadata,
                usedTypeParamterList,
                out var nullableType
            ))
            {
                type = nullableType;
            }

            return type;
        }


        public static string GetFromNode(
            Node node,
            SyntaxKind kind,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList
        )
        {
            return kind switch
            {
                SyntaxKind.UnionType => UnionTypeCheck(
                    node,
                    classMetadata,
                    usedTypeParamterList
                ),
                SyntaxKind.ParenthesizedType => ParenthesizedTypeCheck(
                    node,
                    classMetadata,
                    usedTypeParamterList
                ),
                SyntaxKind.FunctionType => GenerationIdentifiedTypes.Action,
                SyntaxKind.VoidKeyword => GenerationIdentifiedTypes.Void,
                SyntaxKind.StringKeyword => GenerationIdentifiedTypes.String,
                SyntaxKind.BooleanKeyword => GenerationIdentifiedTypes.Bool,
                SyntaxKind.NumberKeyword => GenerationIdentifiedTypes.Number,
                // All Other Types
                _ => AllOtherTypeChecks(
                    node,
                    classMetadata,
                    usedTypeParamterList
                ),
            };
        }

        private static string UnionTypeCheck(
            Node node,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList
        )
        {
            if (node.Last.First != null)
            {
                return GetFromNode(
                    node,
                    node.Last.First.Kind,
                    classMetadata,
                    usedTypeParamterList
                );
            }
            return GenerationIdentifiedTypes.Unknown;
        }

        private static string ParenthesizedTypeCheck(
            Node node,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList
        )
        {
            if (node.Last.First.Kind == SyntaxKind.FunctionType)
            {
                return GetFromNode(
                    node,
                    node.Last.First.Kind,
                    classMetadata,
                    usedTypeParamterList
                );
            }
            return GetFromNode(
                node,
                node.Last.First.First.Kind,
                classMetadata,
                usedTypeParamterList
            );
        }

        private static string AllOtherTypeChecks(
            Node node,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList
        )
        {
            if (IsObservablePropertyRule.Check(node))
            {
                return JavaScriptTypes.Observable;
            }
            if (IsTypeLiteralRule.Check(node))
            {
                return GenerationIdentifiedTypes.Object;
            }
            if (IsArrayResponseTypeRule.Check(node))
            {
                return ArrayTypeIdentifier.Identify(
                    node,
                    classMetadata
                );
            }
            if (node.Last.Kind == SyntaxKind.AnyKeyword)
            {
                return GenerationIdentifiedTypes.Object;
            }
            if (node.Last.Kind == SyntaxKind.ThisType)
            {
                return classMetadata.Name;
            }
            if (node.Kind == SyntaxKind.SetAccessor)
            {
                var getClassName = GetClassName(
                    node,
                    classMetadata,
                    usedTypeParamterList
                );
                if (getClassName != GenerationIdentifiedTypes.Unknown)
                {
                    return getClassName;
                }
                return GenerationIdentifiedTypes.Object;
            }
            if (node.Kind == SyntaxKind.GetAccessor)
            {
                var getClassName = GetClassName(
                    node,
                    classMetadata,
                    usedTypeParamterList
                );
                if (getClassName != GenerationIdentifiedTypes.Unknown)
                {
                    return getClassName;
                }
                return GenerationIdentifiedTypes.Void;
            }

            var referenceNode = node.OfKind(SyntaxKind.TypeReference)
                .LastOrDefault();
            // Check if generic
            if (referenceNode is TypeReferenceNode typed)
            {
                if (typed.TypeArguments != null && typed.TypeArguments.Any())
                {
                    return GetFromNode(
                        node,
                        typed.TypeArguments.Last().Kind,
                        classMetadata,
                        usedTypeParamterList
                    );
                }
            }
            var nodeClassName = GetClassName(
                node,
                classMetadata,
                usedTypeParamterList
            );
            return nodeClassName;
        }

        private static string GetClassName(
            Node node,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList
        )
        {
            var reference = node.OfKind(SyntaxKind.TypeReference)
                .LastOrDefault()
                ?.OfKind(SyntaxKind.Identifier)
                .LastOrDefault();
            if (reference == null)
            {
                // Check the TypeQuery
                reference = node.OfKind(SyntaxKind.TypeQuery)
                    .LastOrDefault()
                    ?.OfKind(SyntaxKind.Identifier)
                    .LastOrDefault();
                if (reference == null)
                {
                    return GenerationIdentifiedTypes.Unknown;
                }
            }
            if (classMetadata.TypeIdentifier.Any(a => a == reference.IdentifierStr)
                || usedTypeParamterList.Any(a => a == reference.IdentifierStr))
            {
                if (
                    reference.Parent.Kind == SyntaxKind.TypeReference
                    && reference.Parent.Parent.Kind == SyntaxKind.TypeReference
                )
                {
                    if (reference.Parent.Parent is Node parentReference)
                    {
                        return parentReference.IdentifierStr;
                    }
                }
                return GenerationIdentifiedTypes.Object;
            }
            if (reference.IdentifierStr != null)
            {
                return reference.IdentifierStr;
            }
            return GenerationIdentifiedTypes.Unknown;
        }
    }
}
