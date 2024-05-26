namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model;

public class IdentifierModel
{
    public string Type { get; set; }
    public string Name { get; set; }
    public IdentifierModel Left { get; set; }
    public IdentifierModel Right { get; set; }
}
