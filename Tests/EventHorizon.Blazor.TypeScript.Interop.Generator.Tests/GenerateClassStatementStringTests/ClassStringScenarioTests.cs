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
    [InlineData(
        "ClassSameNameInterface.ts",
        "Classes",
        "Scenarios",
        "ClassSameNameInterface.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "ComplexClassScenarios.ts",
        "Classes",
        "Scenarios",
        "ComplexClassScenarios.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "ObservableClass.ts",
        "Classes",
        "Scenarios",
        "ObservableClass.Expected.txt",
        ASTParserType.Sdcb,
        "Observable"
    )]
    public void ShouldGenerateClassScenarioStringsUsingSdcb(
        string sourceFile,
        string rootPath,
        string scenariosPath,
        string expectedFile,
        ASTParserType parserType,
        string classIdentifier = "ExampleClass"
    ) =>
        ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType,
            classIdentifier: classIdentifier
        );

    [Theory(DisplayName = "Class")]
    [Trait("Category", "StringGeneration.Classes")]
    [Trait("AST", "NodeJS")]
    [InlineData(
        "ClassIsInterface.ts",
        "Classes",
        "Scenarios",
        "ClassIsInterface.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "ClassIsType.ts",
        "Classes",
        "Scenarios",
        "ClassIsType.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "ClassSameNameInterface.ts",
        "Classes",
        "Scenarios",
        "ClassSameNameInterface.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "ComplexClassScenarios.ts",
        "Classes",
        "Scenarios",
        "ComplexClassScenarios.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "ObservableClass.ts",
        "Classes",
        "Scenarios",
        "ObservableClass.Expected.txt",
        ASTParserType.NodeJS,
        "Observable"
    )]
    [InlineData(
        "ClassIsVariable.ts",
        "Classes",
        "Scenarios",
        "ClassIsVariable.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateClassScenarioStringsUsingNode(
        string sourceFile,
        string rootPath,
        string scenariosPath,
        string expectedFile,
        ASTParserType parserType,
        string classIdentifier = "ExampleClass"
    ) =>
        ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType,
            classIdentifier: classIdentifier
        );
}
