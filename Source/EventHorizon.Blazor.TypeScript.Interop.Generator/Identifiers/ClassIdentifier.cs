namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public class ClassIdentifier
{
    public static bool Identify(IList<string> classNameList, string typeAsString)
    {
        return classNameList.Any(arg => arg == typeAsString)
            || typeAsString == GenerationIdentifiedTypes.Literal
            || typeAsString == GenerationIdentifiedTypes.Object;
    }
}
