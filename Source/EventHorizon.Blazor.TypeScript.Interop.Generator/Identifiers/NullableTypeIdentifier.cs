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
            string type
        )
        {
            return JavaScriptTypes.Nullable.Equals(
                type
            );
        }
    }
}
