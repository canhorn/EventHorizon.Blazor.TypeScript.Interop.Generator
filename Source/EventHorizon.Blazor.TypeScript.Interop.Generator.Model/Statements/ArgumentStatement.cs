using System.Collections.Generic;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class ArgumentStatement
{
    public string Name { get; set; }
    public TypeStatement Type { get; set; }

    //public bool IsArrayResponse { get; set; }
    public bool IsOptional { get; set; }
    public IList<string> UsedClassNames { get; set; } = new List<string>();

    public override string ToString()
    {
        var type = Type.ToString();
        if (IsOptional)
        {
            type = $"{type}?";
        }
        return $"{type} {Name}";
    }
}
