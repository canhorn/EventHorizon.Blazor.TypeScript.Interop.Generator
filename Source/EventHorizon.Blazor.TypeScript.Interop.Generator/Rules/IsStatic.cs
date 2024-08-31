namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

public class IsStatic : IRule
{
    public static readonly Node StaticModifier = new IsStaticNode();

    public bool Check(Node node)
    {
        return node.Children.Count(a => a.Kind == SyntaxKind.StaticKeyword) > 0
            || node.Modifiers.Any(a => a.Kind == SyntaxKind.StaticKeyword);
    }

    public record IsStaticNode : Node
    {
        public string Kind { get; } = SyntaxKind.StaticKeyword;
        #region Not Implemented
        public Node Parent { get; }

        public Node First { get; }

        public Node Last { get; }

        public string IdentifierStr { get; }

        public List<Node> Modifiers { get; }

        public Node Type { get; }

        public Node ElementType { get; }

        public List<Node> TypeParameters { get; }

        public List<Node> HeritageClauses { get; }

        public List<Node> Types { get; }

        public List<Node> TypeArguments { get; }

        public List<Node> Parameters { get; }

        public List<Node> Children { get; }

        public List<Node> OfKind(string kind)
        {
            return [];
        }
        #endregion
    }
}
