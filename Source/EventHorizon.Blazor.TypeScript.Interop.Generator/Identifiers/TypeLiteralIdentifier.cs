using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class TypeLiteralIdentifier
    {
        public static bool Identify(
            string type
        )
        {
            return GenerationIdentifiedTypes.Literal.Equals(
                type
            );
        }

        public static bool Identify(
            TypeStatement property
        )
        {
            var type = property;
            if (type.IsModifier
                || type.IsNullable
                || type.IsTask
                || type.IsArray)
            {
                if (type.GenericTypes.Any())
                {
                    return Identify(
                        type.GenericTypes.First()
                    );
                }
            }
            return type.IsLiteral;
        }
    }
}
