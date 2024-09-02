namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class WipGenerationTests : GenerateStringTestBase
{
    [Theory(DisplayName = "WIP")]
    [Trait("Category", "WIP")]
    [Trait("AST", "Sdcb")]
    [InlineData("WIP.ts", "WIP", "WIP.Expected.txt", ASTParserType.Sdcb)]
    [InlineData("WIP.ts", "WIP", "WIP.Expected.txt", ASTParserType.NodeJS)]
    public void WIP(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);
}
