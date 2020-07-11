using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    class ClassIdentifier
    {
        internal static bool Identify(
            IList<string> classNameList,
            string typeAsString
        )
        {
            return classNameList.Any(
                arg => arg == typeAsString
            ) || typeAsString == GenerationIdentifiedTypes.Object
            || typeAsString == GenerationIdentifiedTypes.Literal
            || typeAsString == GenerationIdentifiedTypes.String;
        }
    }
}
