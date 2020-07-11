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
            Node node,
            ClassMetadata classMetadata
        )
        {
            var list = new List<string>
            {
                //GenerationIdentifiedTypes.CachedEntityObject
            };
            // Get Type
            var type = TypeIdentifier.Identify(
                node,
                classMetadata,
                TypeParameterIdentifier.Identify(node)
            );
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
                //case GenerationIdentifiedTypes.Literal:
                case GenerationIdentifiedTypes.Object:
                    break;
                default:
                    list.Add(type);
                    break;
            }

            return list;
        }
    }
}
