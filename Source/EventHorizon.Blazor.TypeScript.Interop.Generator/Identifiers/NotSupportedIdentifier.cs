using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

/// <summary>
/// This class will take in different statement types and return a true if it has something that is not supported by the generator.
/// </summary>
public class NotSupportedIdentifier
{
    public static bool Identify(PublicMethodStatement statement)
    {
        return Identify(statement.Type);
    }

    public static bool Identify(PublicPropertyStatement statement)
    {
        return Identify(statement.Type);
    }

    public static bool Identify(TypeStatement typeStatement)
    {
        // Check for supported Response Type
        if (
            !typeStatement.IsArray
            && !typeStatement.IsNullable
            && !typeStatement.IsAction
            && !typeStatement.IsTask
            && !typeStatement.Arguments.Any()
            && typeStatement.GenericTypes.Any()
            && PrimitiveTypeIdentifier.Identify(typeStatement.GenericTypes.First().Name)
        )
        {
            return true;
        }
        // Check for Array in Array
        if (HasAnArrayInArray(typeStatement))
        {
            return true;
        }

        return false;
    }

    private static bool HasAnArrayInArray(TypeStatement typeStatement)
    {
        if (typeStatement.IsArray)
        {
            if (typeStatement.GenericTypes.Any(a => a.IsArray))
            {
                return true;
            }
        }
        foreach (var genericType in typeStatement.GenericTypes)
        {
            return HasAnArrayInArray(genericType);
        }
        return false;
    }
}
