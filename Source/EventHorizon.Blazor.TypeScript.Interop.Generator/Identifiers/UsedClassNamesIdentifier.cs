using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class UsedClassNamesIdentifier
    {
        public static IList<string> Identify(
            string type
        )
        {
            var list = new List<string>
            {
                //GenerationIdentifiedTypes.CachedEntityObject
            };
            // Using The Type get
            switch (type)
            {
                case GenerationIdentifiedTypes.Unknown:
                case GenerationIdentifiedTypes.Action:
                case GenerationIdentifiedTypes.Void:
                case GenerationIdentifiedTypes.Task:
                case GenerationIdentifiedTypes.Setter:
                case GenerationIdentifiedTypes.Getter:
                case GenerationIdentifiedTypes.String:
                case GenerationIdentifiedTypes.Bool:
                case GenerationIdentifiedTypes.Number:
                case GenerationIdentifiedTypes.Literal:
                case GenerationIdentifiedTypes.Object:
                case GenerationIdentifiedTypes.Int:
                case GenerationIdentifiedTypes.Float:
                    break;
                default:
                    list.Add(type);
                    break;
            }

            return list;
        }
    }
}
