namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

public class DeclarationGenericTypesIdentifier
{
    public static IList<string> Identify(Node node)
    {
        var list = default(IList<string>);
        if (node.Kind == SyntaxKind.MethodDeclaration)
        {
            list = node.TypeParameters?.Select(a => a.IdentifierStr).ToList();
        }
        if (list == null)
        {
            return new List<string>();
        }
        return list;
    }
}
