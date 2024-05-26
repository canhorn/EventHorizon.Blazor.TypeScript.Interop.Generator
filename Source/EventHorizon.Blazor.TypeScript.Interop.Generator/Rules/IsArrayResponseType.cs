namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public class IsArrayResponseType : IRule
{
    public bool Check(Node node)
    {
        if (
            node.Kind == SyntaxKind.ArrayType
            || JavaScriptTypes.AllArrayTypes.Any(a => a == node.IdentifierStr)
        )
        {
            return true;
        }

        return false;
    }
}
