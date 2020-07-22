using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    public static class GenerateClassShim
    {
        public static ClassStatement GenerateClassStatement(
            string classIdentifier
        )
        {
            return new ClassStatement
            {
                Namespace = "global.GlobalShim",
                Name = DotNetClassNormalizer.Normalize(
                    classIdentifier
                ),
            };
        }

        public static string GenerateString(
            ClassStatement classStatement
        )
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
