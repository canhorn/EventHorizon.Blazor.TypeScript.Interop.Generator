using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ClassResponseIdentifier
    {
        public static bool Identify(TypeStatement typeStatement, IList<string> classNameList)
        {
            var name = typeStatement.Name;
            if (
                typeStatement.IsArray
                || typeStatement.IsModifier
                || typeStatement.IsNullable
                || typeStatement.IsTask
            )
            {
                return Identify(typeStatement.GenericTypes.First(), classNameList);
            }
            return ClassIdentifier.Identify(classNameList, name);
        }
    }
}
