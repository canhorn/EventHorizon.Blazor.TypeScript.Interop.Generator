namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public static class TypeIdentifier
{
    public static string Identify(Node node, ClassMetadata classMetadata)
    {
        var type = GetFromNode(node, node.Kind, classMetadata);
        if (JavaScriptProvidedApiIdentifier.Identify(type, out var jsType))
        {
            type = jsType;
        }

        return type;
    }

    public static string GetFromNode(Node node, string kind, ClassMetadata classMetadata)
    {
        switch (kind)
        {
            case SyntaxKind.UnionType:
                return UnionTypeCheck(node, classMetadata);
            case SyntaxKind.ParenthesizedType:
                return ParenthesizedTypeCheck(node, classMetadata);
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
                return AllOtherTypeChecks(node, classMetadata);
        }
    }

    private static string UnionTypeCheck(Node node, ClassMetadata classMetadata)
    {
        var firstNode = node.Children.FirstOrDefault(childNode =>
            childNode.Kind != SyntaxKind.NullKeyword
            && childNode.Kind != SyntaxKind.UndefinedKeyword
        );
        return GetFromNode(firstNode, firstNode.Kind, classMetadata);
    }

    private static string ParenthesizedTypeCheck(Node node, ClassMetadata classMetadata)
    {
        return GetFromNode(node.First, node.First.Kind, classMetadata);
    }

    private static string AllOtherTypeChecks(Node node, ClassMetadata classMetadata)
    {
        if (node.Kind == SyntaxKind.AnyKeyword)
        {
            return GenerationIdentifiedTypes.CachedEntity;
        }
        else if (node.Kind == SyntaxKind.ThisType)
        {
            return classMetadata.Name;
        }
        else if (node.Type is not null)
        {
            return GetFromNode(node.Type, node.Type.Kind, classMetadata);
        }
        else if (node.Kind == SyntaxKind.Parameter)
        {
            return classMetadata.Name;
        }
        else if (node.IdentifierStr is not null)
        {
            return node.IdentifierStr;
        }
        // Is Probably a Namespace
        return GetNamespacesType(node);
    }

    private static string GetNamespacesType(Node node)
    {
        if (node.TypeArguments is not null && node.TypeArguments.Any())
        {
            return node.First.Last.IdentifierStr;
        }
        return node.OfKind(SyntaxKind.Identifier).LastOrDefault()?.IdentifierStr
            ?? GenerationIdentifiedTypes.Unknown;
    }
}
