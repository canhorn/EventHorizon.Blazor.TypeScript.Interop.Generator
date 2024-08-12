namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class AliasTypeStatementIdentifier
{
    public static TypeStatement Identify(
        string typeIdentifier,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        // Get node from typeIdentifier
        var node = ast
            .RootNode.OfKind(SyntaxKind.TypeAliasDeclaration)
            .FirstOrDefault(child => child.IdentifierStr == typeIdentifier);

        if (node == null)
        {
            return null;
        }

        var typeNode = node.Last;
        var typeStatementIdentifier = TypeIdentifier.Identify(typeNode, classMetadata);

        if (typeStatementIdentifier == GenerationIdentifiedTypes.Unknown)
        {
            return null;
        }
        else if (
            // If the typeStatementIdentifier is the same as the typeIdentifier,
            // then this is not an alias type statement.
            node.Children.Any(a =>
                a.Kind == SyntaxKind.TypeParameter && a.IdentifierStr == typeStatementIdentifier
            )
        )
        {
            return null;
        }

        return GenericTypeIdentifier.Identify(typeNode, classMetadata, ast, typeOverrideDetails);
    }
}
