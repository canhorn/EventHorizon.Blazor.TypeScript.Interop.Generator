using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    public class InterfaceSectionWriter
    {
        public static string Write(
            ClassStatement classStatement, 
            ClassGenerationTemplates classGenerationTemplates
        )
        {
            // TODO: Check if class is an interface
            if(classStatement.IsInterface)
            {
                GlobalLogger.Info($"Generating Interface: {classStatement}");
                // Get Interface Section Template
                var template = "public interface [[CLASS_NAME]] { }";
                return template;
            }
            return string.Empty;
        }
    }
}
