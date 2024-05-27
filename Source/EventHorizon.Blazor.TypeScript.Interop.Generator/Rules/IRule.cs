namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;

public interface IRule
{
    bool Check(Node node);
}
