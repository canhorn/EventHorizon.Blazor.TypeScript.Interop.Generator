namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

public class GenericTypeIdentifier
{
    private static readonly IsArrayResponseType IsArrayResponseTypeRule = new();
    private static readonly IsMapResponseType IsMapResponseTypeRule = new();
    private static readonly IsExcludeResponseType IsExcludeResponseTypeRule = new();
    private static readonly IsNumericArray IsNumericArrayRule = new();
    private static readonly IsTypeLiteral IsTypeLiteralRule = new();
    private static readonly IsVoidType IsVoidTypeRule = new();
    private static readonly IsTypeQuery IsTypeQueryRule = new();
    private static readonly IsTypeOperator IsTypeOperatorRule = new();
    private static readonly IsTypeParameter IsTypeParameterRule = new();
    private static readonly IsTypeReferenceIdentifier IsTypeReferenceIdentifierRule = new();
    private static readonly IsParameterIdentifier IsParameterIdentifierRule = new();

    public static TypeStatement Identify(
        Node node,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        var isParameter = IsParameterIdentifierRule.Check(node);
        var isExclude = IsExcludeResponseTypeRule.Check(node);
        if (isExclude && node.TypeArguments.Count != 0)
        {
            return Identify(node.TypeArguments.First(), classMetadata, ast, typeOverrideDetails);
        }
        else if (isParameter)
        {
            return Identify(node.Type, classMetadata, ast, typeOverrideDetails);
        }

        var typeIdentifier = TypeIdentifier.Identify(node, classMetadata);
        var isTypeReference = IsTypeReferenceIdentifierRule.Check(node);
        var isMap = IsMapResponseTypeRule.Check(node);
        var isAction = ActionTypeIdentifier.Identify(typeIdentifier);
        var isNullable = NullableTypeIdentifier.Identify(typeIdentifier);
        var isModifier = ModifierTypeIdentifier.Identify(typeIdentifier);
        var isTypeQuery = IsTypeQueryRule.Check(node);
        var isTypeOperator = IsTypeOperatorRule.Check(node);
        var isTypeAlias = AliasTypeIdentifier.Identify(node, ast);
        var isThisType = ThisTypeIdentifier.Identify(node);
        var isTypeParameter = IsTypeParameterRule.Check(node);
        var aliasType = isTypeAlias
            ? AliasTypeStatementIdentifier.Identify(
                typeIdentifier,
                classMetadata,
                ast,
                typeOverrideDetails
            )
            : null;
        var isLiteral =
            IsTypeLiteralRule.Check(node) || TypeLiteralIdentifier.Identify(typeIdentifier);
        var actionResultType = default(TypeStatement);
        var typeReferenceGenericTypes = new List<TypeStatement>();

        if (!isNullable && !isModifier && isTypeReference)
        {
            typeReferenceGenericTypes.AddRange(
                TypeReferenceGenericTypesIdentifier.Identify(
                    node,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                )
            );
        }

        var genericTypes = new List<TypeStatement>();
        if (typeReferenceGenericTypes.Count > 0)
        {
            genericTypes.AddRange(typeReferenceGenericTypes);
        }
        else if (node.TypeArguments != null && node.TypeArguments.Count != 0)
        {
            foreach (var typeArgument in node.TypeArguments)
            {
                genericTypes.Add(Identify(typeArgument, classMetadata, ast, typeOverrideDetails));
            }
        }
        else if (node.Parameters != null && node.Parameters.Count != 0)
        {
            foreach (var functionParameter in node.Parameters)
            {
                genericTypes.Add(
                    Identify(functionParameter, classMetadata, ast, typeOverrideDetails)
                );
            }
        }
        else if (node.TypeParameters != null && node.TypeParameters.Count != 0)
        {
            foreach (var typeParameter in node.TypeParameters)
            {
                genericTypes.Add(Identify(typeParameter, classMetadata, ast, typeOverrideDetails));
            }
        }
        else if (isTypeOperator && node.Type != null && node.Type.Kind == SyntaxKind.ArrayType)
        {
            // This Type is an Array, so we will take the ElementType and use that as the result.
            return Identify(node.Type, classMetadata, ast, typeOverrideDetails);
        }
        else if (
            typeIdentifier == GenerationIdentifiedTypes.Array
            && node.Type != null
            && node.Type.Kind == SyntaxKind.ArrayType
        )
        {
            // This Type is an Array, so we will take the ElementType and use that as the result.
            var resultType = Identify(
                node.Type.ElementType,
                classMetadata,
                ast,
                typeOverrideDetails
            );
            resultType.IsArray = true;
            return resultType;
        }
        else if (IsNumericArrayRule.Check(node))
        {
            genericTypes.Add(new TypeStatement { Name = GenerationIdentifiedTypes.Number, });
        }
        else if (IsArrayResponseTypeRule.Check(node))
        {
            genericTypes.Add(Identify(node.First, classMetadata, ast, typeOverrideDetails));
        }
        else if (IsVoidTypeRule.Check(node))
        {
            if (node.Kind == SyntaxKind.Identifier && node.IdentifierStr == typeIdentifier)
            {
                typeIdentifier = GenerationIdentifiedTypes.Void;
            }
        }
        else if (
            isNullable
            && node.Type is not null
            && node.Type.TypeArguments is not null
            && node.Type.TypeArguments.Count != 0
            && node.Type.TypeArguments.First() is Node typeArgumentFirst
        )
        {
            genericTypes.Add(Identify(typeArgumentFirst, classMetadata, ast, typeOverrideDetails));
        }
        else if (
            UnionTypeIdentifier.Identify(
                node,
                classMetadata,
                ast,
                typeOverrideDetails,
                out var typeStatement
            )
            && typeStatement.Name != GenerationIdentifiedTypes.Unknown
        )
        {
            return typeStatement;
        }

        if (isMap || typeIdentifier == GenerationIdentifiedTypes.Void)
        {
            genericTypes.Clear();
        }

        if (isAction)
        {
            actionResultType = Identify(node.Last, classMetadata, ast, typeOverrideDetails);
        }

        if (isLiteral)
        {
            typeIdentifier = GenerationIdentifiedTypes.CachedEntity;
        }

        if (typeIdentifier == GenerationIdentifiedTypes.Unknown)
        {
            typeIdentifier = GenerationIdentifiedTypes.CachedEntityObject;
        }

        return new TypeStatement
        {
            Name = DotNetClassNormalizer.Normalize(typeIdentifier),
            IsArray = IsArrayResponseTypeRule.Check(node),
            IsTypeAlias = isTypeAlias && aliasType != null,
            IsTypeReference = isTypeReference,
            AliasType = aliasType,
            IsNullable = isNullable,
            IsReadonly = ReadonlyTypeIdentifier.Identify(typeIdentifier),
            IsAction = isAction,
            IsVoid = VoidTypeIdentifier.Identify(typeIdentifier),
            ActionResultType = actionResultType,
            IsTask = TaskTypeIdentifier.Identify(typeIdentifier),
            IsLiteral = isLiteral,
            IsModifier = ModifierTypeIdentifier.Identify(typeIdentifier),
            IsInterface = InterfaceResponseTypeIdentifier.Identify(typeIdentifier, ast),
            IsEnum = EnumTypeIdentifier.Identify(typeIdentifier, ast),
            IsThisType = isThisType,
            GenericTypes = genericTypes,
            IsTypeQuery = isTypeQuery,
            IsTypeOperator = isTypeOperator,
            IsTypeParameter = isTypeParameter,
            TypeQuery = TypeQueryIdentifier.Identify(node, classMetadata, ast, typeOverrideDetails),
            Arguments = ArgumentIdentifier.Identify(node, classMetadata, ast, typeOverrideDetails),
        };
    }
}
