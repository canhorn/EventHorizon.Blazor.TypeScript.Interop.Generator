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
            if (classStatement.IsInterface)
            {
                GlobalLogger.Info($"Generating Interface: {classStatement}");
                var className = TypeStatementWriter.Write(new TypeStatement
                {
                    Name = classStatement.Name,
                    GenericTypes = classStatement.GenericTypes,
                });
                // Get Interface Section Template
                var template = "public interface [[CLASS_NAME]] : ICachedEntity { }";
                return template.Replace(
                    "[[CLASS_NAME]]",
                    className
                );
            }
            return string.Empty;
        }
    }
}
