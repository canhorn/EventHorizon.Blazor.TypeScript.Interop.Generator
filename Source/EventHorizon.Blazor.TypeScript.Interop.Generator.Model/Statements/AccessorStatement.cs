using System.Collections.Generic;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class AccessorStatement
{
    public string Name { get; set; }
    public TypeStatement Type { get; set; }
    public bool IsStatic { get; set; }
    public bool IsInterfaceResponse { get; set; }

    //public bool IsArrayResponse { get; set; }
    public bool HasSetter { get; set; }
    public IList<string> UsedClassNames { get; set; } = new List<string>();

    public override string ToString()
    {
        var type = Type.ToString();
        var staticSyntax = "";
        if (IsStatic)
        {
            staticSyntax = "static ";
        }
        if (HasSetter)
        {
            return $"public {staticSyntax}{type} {Name} {{ get; set; }}";
        }
        return $"public {staticSyntax}{type} {Name} {{ get; }}";
    }
}
