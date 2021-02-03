namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
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
            var node = ast.RootNode.OfKind(
                SyntaxKind.TypeAliasDeclaration
            ).FirstOrDefault(
                child => child.IdentifierStr == typeIdentifier
            );
            if (node == null)
            {
                return null;
            }

            return GenericTypeIdentifier.Identify(
                node.Last,
                classMetadata,
                ast,
                typeOverrideDetails
            );
        }
    }
}
