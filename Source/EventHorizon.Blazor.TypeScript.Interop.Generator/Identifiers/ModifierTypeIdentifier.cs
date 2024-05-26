using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

public class ModifierTypeIdentifier
{
    public static bool Identify(string type)
    {
        return JavaScriptTypes.DeepImmutable.Equals(type) || JavaScriptTypes.Partial.Equals(type);
    }
}
