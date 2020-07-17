using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    class TypeOverrideIdentifier
    {
        public static bool Identify(
            string typeDeclaration,
            IDictionary<string, string> typeOverrideMap,
            string currentType,
            out string type
        )
        {
            type = currentType;
            if (typeOverrideMap.TryGetValue(
                typeDeclaration,
                out var overrideType
            ))
            {
                type = overrideType;
                return true;
            }
            return false;
        }
    }
}
