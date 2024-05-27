namespace EventHorizon.Blazor.Interop.Generator;

using System.Collections.Generic;
using EventHorizon.Blazor.Interop.Generator.Templates;
using EventHorizon.Blazor.TypeScript.Interop.Generator;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;

public class GenerateInteropSource
{
    public bool Run(
        string projectAssembly,
        string sourceDirectory,
        IList<string> sourceFiles,
        IList<string> generationList,
        IWriter writer,
        TextFormatter textFormatter,
        IDictionary<string, string> typeOverrideMap,
        ASTParserType parserType = ASTParserType.Sdcb
    )
    {
        TypeStatementTemplates.TaskTemplate = "[[GENERIC_TYPES]]";
        ReadInteropTemplates.SetReadTemplates();

        return new GenerateSource().Run(
            projectAssembly,
            sourceDirectory,
            sourceFiles,
            generationList,
            writer,
            textFormatter,
            typeOverrideMap,
            parserType
        );
    }
}
