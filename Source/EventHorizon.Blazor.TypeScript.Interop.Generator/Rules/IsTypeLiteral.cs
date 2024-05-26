namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

    public class IsTypeLiteral : IRule
    {
        public bool Check(Node node)
        {
            return node.Kind == SyntaxKind.TypeLiteral
                || node.Kind == SyntaxKind.LiteralType
                || node.Kind == SyntaxKind.AnyKeyword;
        }
    }
}
