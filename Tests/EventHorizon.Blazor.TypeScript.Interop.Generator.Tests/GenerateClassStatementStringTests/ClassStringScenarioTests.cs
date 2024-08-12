namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class ClassStringScenarioTests : GenerateStringTestBase
{
    [Theory(DisplayName = "Class")]
    [Trait("Category", "StringGeneration.Classes")]
    [Trait("AST", "Sdcb")]
    [InlineData(
        "ClassIsInterface.ts",
        "Classes",
        "Scenarios",
        "ClassIsInterface.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "ClassIsType.ts",
        "Classes",
        "Scenarios",
        "ClassIsType.Expected.txt",
        ASTParserType.Sdcb
    )]
    public void ShouldGenerateClassScenarioStringsUsingSdcb(
        string sourceFile,
        string rootPath,
        string scenariosPath,
        string expectedFile,
        ASTParserType parserType
    ) =>
        ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType
        );

    [Theory(DisplayName = "Class")]
    [Trait("Category", "StringGeneration.Classes")]
    [Trait("AST", "NodeJS")]
    // [InlineData(
    //     "ClassIsInterface.ts",
    //     "Classes",
    //     "Scenarios",
    //     "ClassIsInterface.Expected.txt",
    //     ASTParserType.NodeJS
    // )]
    [InlineData(
        "ClassIsType.ts",
        "Classes",
        "Scenarios",
        "ClassIsType.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateClassScenarioStringsUsingNode(
        string sourceFile,
        string rootPath,
        string scenariosPath,
        string expectedFile,
        ASTParserType parserType
    ) =>
        ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType
        );
}
