namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System;
using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class ExtendedClassTypesIdentifier
{
    private static List<Node> ClassDeclarationCache;

    public static TypeStatement Identify(
        Node node,
        AbstractSyntaxTree ast,
        ClassMetadata classMetadata,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        // Check if Class
        var classesCache =
            ClassDeclarationCache ?? ast.RootNode.OfKind(SyntaxKind.ClassDeclaration);
        if (ClassDeclarationCache == null && GenerateSource.CacheEnabled)
        {
            ClassDeclarationCache = classesCache;
        }

        if (
            node.Kind == SyntaxKind.ClassDeclaration
            && node.HeritageClauses != null
            && node.HeritageClauses.Count != 0
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
            if (
                node.Last is null
                || node.Last.Kind != SyntaxKind.TypeReference
                || classMetadata.GenericTypes.Any(a => a.Name == node.Last.IdentifierStr)
            )
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
