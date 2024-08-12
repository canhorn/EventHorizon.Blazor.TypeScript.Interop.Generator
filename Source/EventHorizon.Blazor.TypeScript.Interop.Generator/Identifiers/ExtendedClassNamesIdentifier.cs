namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class ExtendedClassTypesIdentifier
{
    public static TypeStatement Identify(
        Node node,
        AbstractSyntaxTree ast,
        ClassMetadata classMetadata,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        // Check if Class
        var classesCache = ast.RootNode.OfKind(SyntaxKind.ClassDeclaration);
        if (
            node.Kind == SyntaxKind.ClassDeclaration
            && node.HeritageClauses != null
            && node.HeritageClauses.Any()
        )
        {
            var heritageClause = node.HeritageClauses.First();
            if (heritageClause is null)
            {
                return null;
            }

            var identifiedClass = GenericTypeIdentifier.Identify(
                heritageClause.First,
                classMetadata,
                ast,
                typeOverrideDetails
            );
            if (classesCache.Any(a => a.IdentifierStr == identifiedClass.Name))
            {
                return GenericTypeIdentifier.Identify(
                    heritageClause.First,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
            }
        }
        else if (node.Kind == SyntaxKind.TypeAliasDeclaration)
        {
            if (node.Last is null || node.Last.Kind != SyntaxKind.TypeReference)
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

        return null;
    }
}
