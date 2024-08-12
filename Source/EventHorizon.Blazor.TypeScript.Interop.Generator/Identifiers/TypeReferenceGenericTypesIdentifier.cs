namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class TypeReferenceGenericTypesIdentifier
{
    public static List<TypeStatement> Identify(
        Node node,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        // TypeAliasDeclaration
        // Get the Reference Type to the Node
        var referenceType = ast.OfKind(SyntaxKind.TypeAliasDeclaration)
            .Where(a => a.IdentifierStr == node.IdentifierStr)
            .FirstOrDefault();

        if (referenceType == null)
        {
            return [];
        }

        var genericTypes = new List<TypeStatement>();
        foreach (
            var typeArgument in referenceType.TypeParameters ?? referenceType.TypeArguments ?? []
        )
        {
            var typeStatement = GenericTypeIdentifier.Identify(
                typeArgument,
                classMetadata,
                ast,
                typeOverrideDetails
            );
            if (typeStatement != null)
            {
                genericTypes.Add(typeStatement);
            }
        }
        return genericTypes;
    }
}
