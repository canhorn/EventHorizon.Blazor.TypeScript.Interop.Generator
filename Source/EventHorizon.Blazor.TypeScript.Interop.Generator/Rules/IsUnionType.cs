namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

    public class IsUnionType
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            return node.OfKind(
                SyntaxKind.UnionType
            ).Any();
        }
    }
}
