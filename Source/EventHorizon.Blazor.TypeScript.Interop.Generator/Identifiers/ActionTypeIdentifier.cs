using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ActionTypeIdentifier
    {
        public static bool Identify(
            string type
        )
        {
            return type switch
            {
                GenerationIdentifiedTypes.Action => true,
                _ => false,
            };
        }
    }
}
