using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
    public class ClassStatement
    {
        public string ProjectAssembly { get; set; }
        public string Namespace { get; set; }
        public string Name { get; set; }
        public bool IsInterface { get; set; }
        public IList<string> ExtendedClassNames { get; set; } = new List<string>();
        public IList<string> ImplementedInterfaceNames { get; set; } = new List<string>();
        public ConstructorStatement ConstructorStatement { get; set; } = new ConstructorStatement();
        public IList<PublicPropertyStatement> PublicPropertyStatements { get; set; } = new List<PublicPropertyStatement>();
        public IList<PublicMethodStatement> PublicMethodStatements { get; set; } = new List<PublicMethodStatement>();
        public IList<AccessorStatement> AccessorStatements { get; set; } = new List<AccessorStatement>();

        public override string ToString()
        {
            return $"{Namespace}.{Name}";
        }
    }
}
