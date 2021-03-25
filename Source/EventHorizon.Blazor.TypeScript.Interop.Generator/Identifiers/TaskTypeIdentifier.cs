namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

    public class TaskTypeIdentifier
    {
        public static bool Identify(
            string type
        )
        {
            return GenerationIdentifiedTypes.Task == type;
        }
    }
}
