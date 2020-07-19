using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class GenericTypeIdentifier
    {
        private static IRule IsArrayResposneTypeRule = new IsArrayResponseType();
        private static IRule IsNumericArrayRule = new IsNumericArray();
        private static IRule IsTypeLiteralRule = new IsTypeLiteral();
        private static IRule IsVoidTypeRule = new IsVoidType();

        public static TypeStatement Identify(
            Node node,
            ClassMetadata classMetadata,
            TypeScriptAST ast
        )
        {
            // Observer<SomeTypeData>
            //var template = "[[NAME]]<[[CHILDREN_TYPES]]>";
            var typeIdentifier = TypeIdentifier.Identify(
                node,
                classMetadata
            );
            var isLiteral = IsTypeLiteralRule.Check(
                node
            ) || TypeLiteralIdentifier.Identify(
                typeIdentifier
            );
            var genericTypes = new List<TypeStatement>();
            if (node is TypeReferenceNode referenceNode
                && referenceNode.TypeArguments != null
                && referenceNode.TypeArguments.Any())
            {
                foreach (var typeArgument in referenceNode.TypeArguments)
                {
                    if (typeArgument is Node typeArgumentNode)
                    {
                        genericTypes.Add(
                            Identify(
                                typeArgumentNode,
                                classMetadata,
                                ast
                            )
                        );
                    }
                }
            }
            else if (node is ExpressionWithTypeArguments expressNode
                && expressNode.TypeArguments != null
                && expressNode.TypeArguments.Any())
            {
                foreach (var typeArgument in expressNode.TypeArguments)
                {
                    if (typeArgument is Node typeArgumentNode)
                    {
                        genericTypes.Add(
                            Identify(
                                typeArgumentNode,
                                classMetadata,
                                ast
                            )
                        );
                    }
                }
            }
            else if (IsNumericArrayRule.Check(node))
            {
                genericTypes.Add(
                    new TypeStatement
                    {
                        Name = GenerationIdentifiedTypes.Number,
                    }
                );
            }
            else if (IsArrayResposneTypeRule.Check(node))
            {
                genericTypes.Add(
                    Identify(
                        node.First,
                        classMetadata,
                        ast
                    )
                );
            }
            else if (IsVoidTypeRule.Check(node))
            {
                if (node.Kind == SyntaxKind.Identifier
                    && node.IdentifierStr == typeIdentifier)
                {
                    typeIdentifier = GenerationIdentifiedTypes.Void;
                }
            }

            if (typeIdentifier == GenerationIdentifiedTypes.Void)
            {
                genericTypes.Clear();
            }

            if (isLiteral)
            {
                typeIdentifier = GenerationIdentifiedTypes.Object;
            }

            return new TypeStatement
            {
                Name = typeIdentifier,
                IsArray = IsArrayResposneTypeRule.Check(
                    node
                ),
                IsNullable = NullableTypeIdentifier.Identify(
                    typeIdentifier
                ),
                IsAction = ActionTypeIdentifier.Identify(
                    typeIdentifier
                ),
                IsLiteral = isLiteral,
                IsModifier = ModifierTypeIdentifier.Identify(
                    typeIdentifier
                ),
                IsInterface = InterfaceResponseTypeIdentifier.Identify(
                    typeIdentifier,
                    ast
                ),
                GenericTypes = genericTypes,
            };
        }
    }
}
