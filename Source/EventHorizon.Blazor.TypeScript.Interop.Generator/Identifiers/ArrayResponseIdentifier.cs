using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ArrayResponseIdentifier
    {
        public static bool Identify(
            TypeStatement typeStatement
        )
        {
            var type = typeStatement;
            if (typeStatement.IsModifier
                || typeStatement.IsNullable
                || typeStatement.IsTask)
            {
                if (typeStatement.GenericTypes.Any())
                {
                    return Identify(
                        typeStatement.GenericTypes.First()
                    );
                }
            }
            else if (typeStatement.IsTypeAlias)
            {
                return Identify(
                    typeStatement.AliasType
                );
            }
            return type.IsArray;
        }
    }
}
