namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

    public class BaseConstructorSectionWriter
    {
        internal static string Write(
            ClassStatement classStatement,
            ConstructorStatement constructorDetails,
            ClassGenerationTemplates templates
        )
        {
            GlobalLogger.Info($"Generating Base Constructor: {constructorDetails}");
            var template = templates.Constructor;
            var extendsClass = classStatement.ExtendedType != null;

            if (extendsClass)
            {
                template = templates.ConstructorToBase;
            }

            return template.Replace(
                "[[CLASS_NAME]]",
                classStatement.Name
            ).Replace(
                "[[BASE_CLASS_CALL]]",
                extendsClass ? " : base()" : string.Empty
            );
        }
    }
}
