namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public static class UsedClassNamesIdentifier
{
    public static IList<string> Identify(TypeStatement type, IList<string> list = null)
    {
        list ??= [];

        if (
            !type.IsAction
            && !type.IsArray
            && !type.IsLiteral
            && !type.IsModifier
            && !type.IsNullable
            // && !type.IsTypeAlias
            && !type.IsReadonly
        && !type.IsTypeParameter
        )
        {
            // Using The Type get
            switch (type.Name)
            {
                case GenerationIdentifiedTypes.Array:
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
                case GenerationIdentifiedTypes.Object:
                    break;
                default:
                    list.Add(type.Name);
                    break;
            }
        }
        foreach (var genericType in type.GenericTypes)
        {
            Identify(genericType, list);
        }
        if (type.IsTypeAlias)
        {
            Identify(type.AliasType, list);
        }

        return list;
    }
}
