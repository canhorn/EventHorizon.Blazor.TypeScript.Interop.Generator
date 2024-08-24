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
    public List<Node> Modifiers { get; }
    public Node Type { get; }
    public Node ElementType { get; }
    public List<Node> TypeParameters { get; set; }
    public List<Node> HeritageClauses { get; }
    public List<Node> Types { get; }
    public List<Node> TypeArguments { get; }
    public List<Node> Parameters { get; }
    public List<Node> Children { get; }

    public List<Node> OfKind(string kind)
    {
        throw new NotImplementedException();
    }
}
