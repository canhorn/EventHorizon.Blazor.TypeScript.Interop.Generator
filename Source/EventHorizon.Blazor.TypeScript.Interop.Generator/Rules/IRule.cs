using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public interface IRule
    {
        bool Check(Node node);
    }
}