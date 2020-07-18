using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ClassResponseIdentifier
    {
        public static bool Identify(
            TypeStatement typeStatement,
            IList<string> classNameList
        )
        {
            var name = typeStatement.Name;
            if (typeStatement.IsArray
                || typeStatement.IsNullable)
            {
                if (typeStatement.GenericTypes.Any())
                {
                    name = typeStatement.GenericTypes.First().Name;
                }
            }
            return ClassIdentifier.Identify(
                classNameList,
                name
            );
        }
    }
}
