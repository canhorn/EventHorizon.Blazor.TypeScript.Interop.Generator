namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class JavaScriptTypesTests : GenerateStringTestBase
{
    [Theory(DisplayName = "JavaScriptTypes")]
    [Trait("Category", "JavaScriptTypes")]
    [Trait("AST", "Sdcb")]
    [InlineData(
        "JavaScriptExclude.ts",
        "JavaScriptTypes",
        "JavaScriptExclude.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "JavaScriptMap.ts",
        "JavaScriptTypes",
        "JavaScriptMap.Expected.txt",
        ASTParserType.Sdcb
    )]
    public void ShouldGenerateJavaScriptMapTypeScenariosSdcb(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

    [Theory(DisplayName = "JavaScriptTypes")]
    [Trait("Category", "JavaScriptTypes")]
    [Trait("AST", "NodeJS")]
    [InlineData(
        "JavaScriptExclude.ts",
        "JavaScriptTypes",
        "JavaScriptExclude.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "JavaScriptMap.ts",
        "JavaScriptTypes",
        "JavaScriptMap.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateJavaScriptTypesScenariosNodeJS(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);
}
