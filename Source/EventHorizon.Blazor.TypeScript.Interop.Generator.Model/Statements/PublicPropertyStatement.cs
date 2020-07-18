using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
    public class PublicPropertyStatement
    {
        public string Name { get; set; }
        public TypeStatement Type { get; set; }
        public bool IsStatic { get; set; }
        public bool IsInterfaceResponse { get; set; }
        public bool IsReadonly { get; set; }
        public IList<string> UsedClassNames { get; set; } = new List<string>();

        public override string ToString()
        {
            var type = Type.ToString();
            if (IsStatic)
            {
                return $"public static {type} {Name};";
            }
            return $"public {type} {Name};";
        }
    }
}
