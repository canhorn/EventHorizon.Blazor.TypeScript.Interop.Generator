namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

    public class IsStatic
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            return node.Children.Count(
                a => a.Kind == SyntaxKind.StaticKeyword
            ) > 0;
        }
    }
}
