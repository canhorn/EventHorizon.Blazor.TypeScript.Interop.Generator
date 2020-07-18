using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class UsedClassNamesIdentifier
    {
        public static IList<string> Identify(
            TypeStatement type,
            IList<string> list = null
        )
        {
            if (list == null)
            {
                list = new List<string>();
            }
            // Using The Type get
            switch (type.Name)
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
                case GenerationIdentifiedTypes.Int:
                case GenerationIdentifiedTypes.Float:
                case GenerationIdentifiedTypes.CachedEntity:
                    break;
                default:
                    list.Add(type.Name);
                    break;
            }
            foreach (var genericType in type.GenericTypes)
            {
                var genericTypeList = Identify(
                    genericType,
                    list
                );
                foreach (var genericTypeItem in genericTypeList)
                {
                    if (!list.Contains(genericTypeItem))
                    {
                        list.Add(genericTypeItem);
                    }
                }
            }

            return list;
        }
    }
}
