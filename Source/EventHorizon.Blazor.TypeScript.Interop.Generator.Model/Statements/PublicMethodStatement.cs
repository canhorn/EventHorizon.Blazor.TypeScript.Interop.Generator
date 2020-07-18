using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
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

        public override string ToString()
        {
            var type = Type.ToString();
            var args = string.Join(", ", Arguments.Select(a => a.ToString()));
            if (IsStatic)
            {
                return $"public static {type} {Name}({args});";
            }
            return $"public {type} {Name}({args});";
        }
    }
}
