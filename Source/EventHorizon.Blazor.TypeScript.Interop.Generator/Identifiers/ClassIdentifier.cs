using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ClassIdentifier
    {
        public static bool Identify(
            IList<string> classNameList,
            string typeAsString
        )
        {
            return classNameList.Any(
                arg => arg == typeAsString
            ) || typeAsString == GenerationIdentifiedTypes.Literal
            || typeAsString == GenerationIdentifiedTypes.Object;
        }
    }
}
