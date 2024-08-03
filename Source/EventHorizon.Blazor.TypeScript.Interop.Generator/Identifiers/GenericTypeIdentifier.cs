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
    private static readonly IsNumericArray IsNumericArrayRule = new();
    private static readonly IsTypeLiteral IsTypeLiteralRule = new();
    private static readonly IsVoidType IsVoidTypeRule = new();
    private static readonly IsTypeQuery IsTypeQueryRule = new();

    public static TypeStatement Identify(
        Node node,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        var typeIdentifier = TypeIdentifier.Identify(node, classMetadata);
        var isAction = ActionTypeIdentifier.Identify(typeIdentifier);
        var isTypeQuery = IsTypeQueryRule.Check(node);
        var isTypeAlias = AliasTypeIdentifier.Identify(node, ast);
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
        var genericTypes = new List<TypeStatement>();
        if (node.TypeArguments != null && node.TypeArguments.Any())
        {
            foreach (var typeArgument in node.TypeArguments)
            {
                genericTypes.Add(Identify(typeArgument, classMetadata, ast, typeOverrideDetails));
            }
        }
        else if (node.Parameters != null && node.Parameters.Any())
        {
            foreach (var functionParamerter in node.Parameters)
            {
                genericTypes.Add(
                    Identify(functionParamerter, classMetadata, ast, typeOverrideDetails)
                );
            }
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
            NullableTypeIdentifier.Identify(typeIdentifier)
            && node.Type is not null
            && node.Type.TypeArguments is not null
            && node.Type.TypeArguments.Any()
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

        if (typeIdentifier == GenerationIdentifiedTypes.Void)
        {
            genericTypes.Clear();
        }

        if (isAction)
        {
            actionResultType = GenericTypeIdentifier.Identify(
                node.Last,
                classMetadata,
                ast,
                typeOverrideDetails
            );
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
            AliasType = aliasType,
            IsNullable = NullableTypeIdentifier.Identify(typeIdentifier),
            IsReadonly = ReadonlyTypeIdentifier.Identify(typeIdentifier),
            IsAction = isAction,
            IsVoid = VoidTypeIdentifier.Identify(typeIdentifier),
            ActionResultType = actionResultType,
            IsTask = TaskTypeIdentifier.Identify(typeIdentifier),
            IsLiteral = isLiteral,
            IsModifier = ModifierTypeIdentifier.Identify(typeIdentifier),
            IsInterface = InterfaceResponseTypeIdentifier.Identify(typeIdentifier, ast),
            IsEnum = EnumTypeIdentifier.Identify(typeIdentifier, ast),
            GenericTypes = genericTypes,
            IsTypeQuery = isTypeQuery,
            TypeQuery = TypeQueryIdentifier.Identify(node, classMetadata, ast, typeOverrideDetails),
            Arguments = ArgumentIdentifier.Identify(node, classMetadata, ast, typeOverrideDetails),
        };
    }
}
