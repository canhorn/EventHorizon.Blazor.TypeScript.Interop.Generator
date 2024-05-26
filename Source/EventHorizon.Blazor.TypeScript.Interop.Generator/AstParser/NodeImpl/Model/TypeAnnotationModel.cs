namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model;

using System.Collections.Generic;

public class TypeAnnotationModel
{
    public string Type { get; set; }
    public IdentifierModel TypeName { get; set; }
    public ASTNode TypeAnnotation { get; set; }
    public List<ASTNode> Types { get; set; }
    public List<ASTNode> Parameters { get; set; }
}
