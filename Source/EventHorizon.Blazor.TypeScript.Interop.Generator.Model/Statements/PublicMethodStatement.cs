using System.Collections.Generic;
using System.Linq;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class PublicMethodStatement
{
    public string Name { get; set; }
    public IList<string> GenericTypes { get; set; } = new List<string>();
    public TypeStatement Type { get; set; }
    public IList<ArgumentStatement> Arguments { get; set; } = new List<ArgumentStatement>();
    public bool IsStatic { get; set; }
    public bool IsInterfaceResponse { get; set; }

    //public bool IsArrayResponse { get; set; }
    public IList<string> UsedClassNames { get; set; } = new List<string>();

    public override bool Equals(object obj)
    {
        return obj is PublicMethodStatement statement
            && Name == statement.Name
            && IsStatic == statement.IsStatic;
    }

    public override int GetHashCode()
    {
        var hashCode = 2030980769;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        hashCode = hashCode * -1521134295 + IsStatic.GetHashCode();
        return hashCode;
    }

    public override string ToString()
    {
        var type = Type.ToString();
        var args = string.Join(", ", Arguments.Select(a => a.ToString()));
        var toString = "public ";
        if (IsStatic)
        {
            toString += "static ";
        }
        toString += $"{type} {Name}";
        if (GenericTypes.Any())
        {
            var generics = string.Join(", ", GenericTypes);
            toString += $"<{generics}>";
        }

        return $"{toString}({args})";
    }
}
