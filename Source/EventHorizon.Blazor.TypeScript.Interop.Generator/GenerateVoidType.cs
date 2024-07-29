namespace EventHorizon.Blazor.TypeScript.Interop.Generator;

using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;

public static class GenerateVoidType
{
    public static ClassStatement GenerateClassStatement()
    {
        return new ClassStatement
        {
            Namespace = "global.Provided",
            Name = GenerationIdentifiedTypes.VoidNode,
        };
    }

    public static string GenerateString()
    {
        // Templates
        var classGenerationTemplates = ReadTemplates.Read();
        return classGenerationTemplates.VoidTypeTemplate;
    }
}
