namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api
{
    using System.Collections.Generic;

    public interface Node
    {
        Node Parent { get; }
        Node First { get; }
        Node Last { get; }
        string IdentifierStr { get; }
        string Kind { get; }
        IEnumerable<Node> Modifiers { get; }

        #region ParameterDeclaration
        Node Type { get; }
        #endregion

        #region ArrayTypeNode
        Node ElementType { get; }
        #endregion

        #region ClassDeclaration, InterfaceDeclaration, MethodDeclaration
        IEnumerable<Node> TypeParameters { get; }
        #endregion

        #region ClassDefinition
        IEnumerable<Node> HeritageClauses { get; }
        #endregion

        #region HeritageClause
        //public SyntaxKind Token { get; set; }
        IEnumerable<Node> Types { get; }
        #endregion

        #region TypeReferenceNode ExpressionWithTypeArguments
        public IEnumerable<Node> TypeArguments { get; }
        #endregion

        #region FunctionTypeNode
        public IEnumerable<Node> Parameters { get; }
        #endregion

        IEnumerable<Node> Children { get; }

        IEnumerable<Node> OfKind(string kind);
    }
}
