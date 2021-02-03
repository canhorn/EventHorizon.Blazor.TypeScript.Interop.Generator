namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

    public class NullableTypeIdentifier
    {
        public static bool Identify(
            string type
        )
        {
            return JavaScriptTypes.Nullable.Equals(
                type
            );
        }
    }
}
