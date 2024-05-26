namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

    public class IsReadonly : IRule
    {
        public bool Check(Node node)
        {
            return node.Children.Count(a => a.Kind == SyntaxKind.ReadonlyKeyword) > 0;
        }
    }
}
