using System.Collections.Generic;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public class ClassStatement
{
    public string ProjectAssembly { get; set; }
    public string Namespace { get; set; }
    public string Name { get; set; }
    public bool IsInterface { get; set; }
    public IList<TypeStatement> GenericTypes { get; set; } = [];
    public TypeStatement ExtendedType { get; set; }
    public IList<TypeStatement> ImplementedInterfaces { get; set; } = [];
    public ConstructorStatement ConstructorStatement { get; set; } = new ConstructorStatement();
    public IList<PublicPropertyStatement> PublicPropertyStatements { get; set; } = [];
    public IList<PublicMethodStatement> PublicMethodStatements { get; set; } = [];
    public IList<AccessorStatement> AccessorStatements { get; set; } = [];

    public override string ToString()
    {
        return $"{Namespace}.{Name}";
    }
}
