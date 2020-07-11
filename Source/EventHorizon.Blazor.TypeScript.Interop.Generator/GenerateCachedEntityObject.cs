using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    public static class GenerateCachedEntityObject
    {
        public static ClassStatement GenerateClassStatement()
        {
            return new ClassStatement
            {
                Namespace = "global.Provided",
                //Name = GenerationIdentifiedTypes.CachedEntityObject,
            };
        }

        public static string GenerateString()
        {
            // Templates
            var classGenerationTemplates = ReadTemplates.Read();

            return classGenerationTemplates.CachedEntityObject;
        }
    }
}
