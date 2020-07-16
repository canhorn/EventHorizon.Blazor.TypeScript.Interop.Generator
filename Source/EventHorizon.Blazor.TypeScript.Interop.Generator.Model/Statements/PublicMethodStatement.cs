using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
    public class PublicMethodStatement
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public IList<ArgumentStatement> Arguments { get; set; } = new List<ArgumentStatement>();
        public bool IsStatic { get; set; }
        public bool IsInterfaceResponse { get; set; }
        public bool IsArrayResponse { get; set; }
        public IList<string> UsedClassNames { get; set; } = new List<string>();

        public override bool Equals(object obj)
        {
            return obj is PublicMethodStatement statement &&
                   Name == statement.Name &&
                   Type == statement.Type;
        }

        public override int GetHashCode()
        {
            int hashCode = 233090261;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            return hashCode;
        }

        public override string ToString()
        {
            var type = Type;
            var args = string.Join(", ", Arguments.Select(a => a.ToString()));
            if (IsArrayResponse)
            {
                type = $"{type}[]";
            }
            if (IsStatic)
            {
                return $"public static {type} {Name}({args});";
            }
            return $"public {type} {Name}({args});";
        }

        public static bool operator ==(PublicMethodStatement left, PublicMethodStatement right)
        {
            return EqualityComparer<PublicMethodStatement>.Default.Equals(left, right);
        }

        public static bool operator !=(PublicMethodStatement left, PublicMethodStatement right)
        {
            return !(left == right);
        }
    }
}
