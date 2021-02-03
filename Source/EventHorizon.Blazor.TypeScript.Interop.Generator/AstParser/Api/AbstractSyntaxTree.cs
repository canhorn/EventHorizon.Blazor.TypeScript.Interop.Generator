namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api
{
    using System.Collections.Generic;

    public interface AbstractSyntaxTree
    {
        Node RootNode { get; }
        IEnumerable<Node> OfKind(string kind);
    }
}
