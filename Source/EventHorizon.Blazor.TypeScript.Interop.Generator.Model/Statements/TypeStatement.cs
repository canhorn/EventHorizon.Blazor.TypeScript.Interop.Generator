using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
    // TypeStatement.Name<...TypeStatement.GenericTypes>
    public class TypeStatement
    {
        public string Name { get; set; }
        public bool IsArray { get; set; } = false;
        public IEnumerable<TypeStatement> GenericTypes { get; set; } = new List<TypeStatement>();
        public bool IsNullable { get; set; }
        public bool IsAction { get; set; }
        public bool IsLiteral { get; set; }
        public bool IsModifier { get; set; }
        public bool IsInterface { get; set; }

        public override string ToString()
        {
            // TODO: Prettify this
            Func<TypeStatement, IEnumerable<TypeStatement>> selector = a => a.GenericTypes;
            var something = string.Join(
                ", ",
                GenericTypes.SelectMany(
                    selector
                ).Select(a => a.ToString()))
            ;
            return $"{Name}";
        }
    }
}
