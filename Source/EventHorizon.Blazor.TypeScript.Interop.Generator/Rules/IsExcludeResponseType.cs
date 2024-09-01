namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public class IsExcludeResponseType : IRule
{
    public bool Check(Node node)
    {
        return JavaScriptTypes.Exclude == node.IdentifierStr;
    }
}
