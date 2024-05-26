using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ActionTypeIdentifier
    {
        public static bool Identify(string type)
        {
            return GenerationIdentifiedTypes.Action == type;
        }
    }
}
