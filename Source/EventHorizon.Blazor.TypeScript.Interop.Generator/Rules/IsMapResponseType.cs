namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public class IsMapResponseType : IRule
{
    public bool Check(Node node)
    {
        if (JavaScriptTypes.MapTypes.Any(a => a == node.IdentifierStr))
        {
            return true;
        }

        return false;
    }
}
