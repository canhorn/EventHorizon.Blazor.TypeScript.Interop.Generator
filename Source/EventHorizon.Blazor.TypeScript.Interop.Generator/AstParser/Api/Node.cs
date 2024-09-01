namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;

using System.Collections.Generic;

public interface Node
{
    Node Parent { get; }
    Node First { get; }
    Node Last { get; }
    string IdentifierStr { get; }
    string Kind { get; }
    List<Node> Modifiers { get; }

    #region ParameterDeclaration
    Node Type { get; }
    #endregion

    #region ClassDeclaration, InterfaceDeclaration, MethodDeclaration
    List<Node> TypeParameters { get; }
    #endregion

    #region ClassDefinition
    List<Node> HeritageClauses { get; }
    #endregion

    #region HeritageClause
    List<Node> Types { get; }
    #endregion

    #region TypeReferenceNode ExpressionWithTypeArguments
    public List<Node> TypeArguments { get; }
    #endregion

    #region FunctionTypeNode
    public List<Node> Parameters { get; }
    #endregion

    List<Node> Children { get; }

    List<Node> OfKind(string kind);
}
