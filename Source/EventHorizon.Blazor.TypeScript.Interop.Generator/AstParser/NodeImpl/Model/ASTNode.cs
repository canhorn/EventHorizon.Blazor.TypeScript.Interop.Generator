namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model
{
    using System.Collections.Generic;
    using System.Text.Json;

    public class ASTNode
    {
        public JsonElement Body { get; set; }
        public ASTNode BodyNode
        {
            get
            {
                if (Body.ValueKind == JsonValueKind.Object)
                {
                    return JsonSerializer.Deserialize<ASTNode>(
                        Body.GetRawText(),
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                        }
                    );
                }
                return null;
            }
        }
        public List<ASTNode> BodyArray
        {
            get
            {
                if (Body.ValueKind == JsonValueKind.Array)
                {
                    return JsonSerializer.Deserialize<List<ASTNode>>(
                        Body.GetRawText(),
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                        }
                    );
                }
                return null;
            }
        }
        public ASTNode Declaration { get; set; }

        public IdentifierModel Id { get; set; }
        public IdentifierModel Key { get; set; }
        public IdentifierModel TypeName { get; set; }
        public IdentifierModel ExprName { get; set; }
        public IdentifierModel Left { get; set; }
        public IdentifierModel Right { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Kind { get; set; }
        public bool? Static { get; set; }
        public bool? Readonly { get; set; }
        public bool? Optional { get; set; }
        public string Accessibility { get; set; }
        public ASTNode TypeAnnotation { get; set; }
        public TypeAnnotationModel ReturnType { get; set; }
        public ASTNode TypeParameters { get; set; }
        public ASTNode Expression { get; set; }

        #region SuperClass
        public IdentifierModel Object { get; set; }
        public IdentifierModel Property { get; set; }
        #endregion

        #region HeritageClauses
        public ASTNode SuperClass { get; set; }
        public ASTNode SuperTypeParameters { get; set; }
        public List<ASTNode> Implements { get; set; }
        #endregion

        #region TypeReference
        public List<ASTNode> Types { get; set; }
        public ASTNode ElementType { get; set; }
        public List<ASTNode> ElementTypes { get; set; }
        public List<ASTNode> Members { get; set; }
        #endregion

        #region Method
        public List<ASTNode> Params { get; set; }
        public List<ASTNode> Parameters { get; set; }
        #endregion

        #region indexType
        public ASTNode ObjectType { get; set; }
        public ASTNode IndexType { get; set; }
        #endregion
    }
}
