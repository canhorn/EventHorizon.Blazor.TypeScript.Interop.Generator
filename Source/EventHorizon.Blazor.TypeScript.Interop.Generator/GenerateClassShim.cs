namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;

    public static class GenerateClassShim
    {
        public static ClassStatement GenerateClassStatement(string classIdentifier)
        {
            return new ClassStatement
            {
                Namespace = "global.GlobalShim",
                Name = DotNetClassNormalizer.Normalize(classIdentifier),
            };
        }

        public static string GenerateString(ClassStatement classStatement)
        {
            // Templates
            var classGenerationTemplates = ReadTemplates.Read();

            return classGenerationTemplates.ClassShim.Replace(
                "[[CLASS_NAME]]",
                classStatement.Name
            );
        }
    }
}
