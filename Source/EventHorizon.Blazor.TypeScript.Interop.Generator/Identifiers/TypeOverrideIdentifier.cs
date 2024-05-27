using System.Collections.Generic;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

public class TypeOverrideIdentifier
{
    public static bool Identify(
        string typeDeclaration,
        IDictionary<string, string> typeOverrideMap,
        TypeStatement currentType,
        out TypeStatement type
    )
    {
        type = currentType;
        if (typeOverrideMap.TryGetValue(typeDeclaration, out var overrideType))
        {
            type.Name = overrideType;
            return true;
        }
        return false;
    }
}
