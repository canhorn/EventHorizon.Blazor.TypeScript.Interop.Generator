namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public class ReadonlyTypeIdentifier
{
    public static bool Identify(string type)
    {
        return JavaScriptTypes.Readonly.Equals(type);
    }
}
