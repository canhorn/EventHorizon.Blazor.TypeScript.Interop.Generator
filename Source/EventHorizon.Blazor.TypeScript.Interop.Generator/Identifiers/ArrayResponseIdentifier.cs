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
                || typeStatement.IsNullable)
            {
                if (typeStatement.GenericTypes.Any())
                {
                    return Identify(
                        typeStatement.GenericTypes.First()
                    );
                }
            }
            return type.IsArray;
        }
    }
}
