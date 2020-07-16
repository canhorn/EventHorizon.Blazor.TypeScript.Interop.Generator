using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class NullableTypeIdentifier
    {
        public static bool Identify(
            string type,
            Node node,
            ClassMetadata classMetadata,
            IList<string> usedTypeParamterList,
            out string nullableType
        )
        {
            nullableType = type;
            if (JavaScriptTypes.Nullable.Equals(
                type
            ))
            {
                nullableType = TypeIdentifier.Identify(
                    node,
                    classMetadata,
                    usedTypeParamterList
                );
                if (GenerationIdentifiedTypes.Unknown.Equals(nullableType))
                {
                    nullableType = GenerationIdentifiedTypes.Object;
                }
                return true;
            }

            return false;
        }
    }
}
