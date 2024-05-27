namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers;

using System;
using System.Collections.Generic;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;

public class NodeMock : Node
{
    public Node Parent { get; }
    public Node First { get; }
    public Node Last { get; }
    public string IdentifierStr { get; set; }
    public string Kind { get; set; }
    public IEnumerable<Node> Modifiers { get; }
    public Node Type { get; }
    public Node ElementType { get; }
    public IEnumerable<Node> TypeParameters { get; set; }
    public IEnumerable<Node> HeritageClauses { get; }
    public IEnumerable<Node> Types { get; }
    public IEnumerable<Node> TypeArguments { get; }
    public IEnumerable<Node> Parameters { get; }
    public IEnumerable<Node> Children { get; }

    public IEnumerable<Node> OfKind(string kind)
    {
        throw new NotImplementedException();
    }
}
