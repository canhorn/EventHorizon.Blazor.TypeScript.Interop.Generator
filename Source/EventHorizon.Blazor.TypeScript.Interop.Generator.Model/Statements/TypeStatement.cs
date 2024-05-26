namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

using System.Collections.Generic;
using System.Linq;

// TypeStatement.Name<...TypeStatement.GenericTypes>
public class TypeStatement
{
    public string Name { get; set; }
    public bool IsArray { get; set; } = false;
    public bool IsTypeAlias { get; set; } = false;
    public TypeStatement AliasType { get; set; } = null;
    public IEnumerable<TypeStatement> GenericTypes { get; set; } = new List<TypeStatement>();
    public IEnumerable<ArgumentStatement> Arguments { get; set; } = new List<ArgumentStatement>();
    public bool IsNullable { get; set; }
    public bool IsAction { get; set; }
    public bool IsTask { get; set; }
    public bool IsLiteral { get; set; }
    public bool IsModifier { get; set; }
    public bool IsInterface { get; set; }
    public bool IsEnum { get; set; }

    public bool IsTypeQuery { get; set; }
    public TypeQueryStatement TypeQuery { get; set; }
    public TypeStatement ActionResultType { get; set; }

    public override string ToString()
    {
        var array = IsArray ? "[]" : string.Empty;
        var nullable = IsNullable ? "?" : string.Empty;
        var modifier = IsModifier ? "(M)" : string.Empty;
        var interfaceString = IsInterface ? "(I)" : string.Empty;
        var enumString = IsEnum ? $"(E)" : string.Empty;
        var arguments = string.Join(", ", Arguments.Select(generic => generic.ToString()));
        var action = IsAction ? $"({arguments}) => " : string.Empty;
        var task = IsTask ? $"({arguments}) => " : string.Empty;
        var genericsJoined = string.Join(", ", GenericTypes.Select(generic => generic.ToString()));
        var generics = GenericTypes.Any() ? $"<{genericsJoined}>" : string.Empty;

        return $"{(IsTask ? task : action)} {enumString}{modifier}{interfaceString}{Name}{generics}{array}{nullable}";
    }
}
