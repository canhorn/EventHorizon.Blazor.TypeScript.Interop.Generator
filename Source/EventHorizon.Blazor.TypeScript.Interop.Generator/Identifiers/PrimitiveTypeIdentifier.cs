using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class PrimitiveTypeIdentifier
    {
        public static bool Identify(
            string type
        )
        {
            switch (type)
            {
                case GenerationIdentifiedTypes.String:
                case GenerationIdentifiedTypes.Bool:
                case GenerationIdentifiedTypes.Number:
                case GenerationIdentifiedTypes.Int:
                case GenerationIdentifiedTypes.Float:
                //case GenerationIdentifiedTypes.Array:
                    return true;
                default:
                    break;
            }
            return false;
        }
    }
}
