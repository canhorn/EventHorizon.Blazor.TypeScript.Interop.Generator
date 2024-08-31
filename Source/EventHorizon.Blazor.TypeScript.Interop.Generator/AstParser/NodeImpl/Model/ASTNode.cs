namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model;

using System.Collections.Generic;
using System.Text.Json;

public class ASTNode
{
    public TypeScriptSyntaxKind? Kind { get; set; }

    public ASTNode Body { get; set; }
    public List<ASTNode> Statements { get; set; }
    public List<ASTNode> Members { get; set; }

    public ASTNode Name { get; set; }
    public List<ASTNode> Types { get; set; }
    public List<ASTNode> Modifiers { get; set; }
    public List<ASTNode> HeritageClauses { get; set; }
    public List<ASTNode> Parameters { get; set; }
    public List<ASTNode> TypeParameters { get; set; }
    public List<ASTNode> TypeArguments { get; set; }
    public List<ASTNode> Elements { get; set; }
    public List<ASTNode> Declarations { get; set; }
    public ASTNode DeclarationList { get; set; }
    public ASTNode Expression { get; set; }
    public ASTNode Type { get; set; }
    public ASTNode Initializer { get; set; }
    public ASTNode QuestionToken { get; set; }
    public ASTNode ExprName { get; set; }
    public ASTNode TypeName { get; set; }
    public ASTNode Left { get; set; }
    public ASTNode Right { get; set; }
    public ASTNode ObjectType { get; set; }
    public ASTNode IndexType { get; set; }
    public ASTNode ElementType { get; set; }
    public ASTNode Literal { get; set; }

    public string Text { get; set; }
    public string EscapedText { get; set; }

    public int Token { get; set; }

    #region JSDocs
    public List<ASTNode> JsDoc { get; set; }
    public JsonElement Comment { get; set; }
    public List<ASTNode> Tags { get; set; }
    public ASTNode TagName { get; set; }
    public bool isNameFirst { get; set; }
    public bool isBracketed { get; set; }
    #endregion


    public override string ToString()
    {
        return $"{Kind} {Text ?? EscapedText}";
    }
}
