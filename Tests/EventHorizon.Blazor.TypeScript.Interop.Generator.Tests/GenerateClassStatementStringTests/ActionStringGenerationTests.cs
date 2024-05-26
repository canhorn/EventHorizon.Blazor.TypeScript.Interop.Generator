namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class ActionStringGenerationTests : GenerateStringTestBase
{
    [Theory(DisplayName = "Action")]
    [Trait("Category", "StringGeneration.Actions")]
    [Trait("AST", "Sdcb")]
    [InlineData(
        "ActionCallbackWithResult.ts",
        "Actions",
        "ActionCallbackWithResult.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "ActionTypeCallback.ts",
        "Actions",
        "ActionTypeCallback.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "TypedActionCallback.ts",
        "Actions",
        "TypedActionCallback.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "WithGenericProperty.ts",
        "Actions",
        "WithGenericProperty.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "WithMultipleGenericProperty.ts",
        "Actions",
        "WithMultipleGenericProperty.Expected.txt",
        ASTParserType.Sdcb
    )]
    public void ShouldGenerateConstructorStringsUsingSdcb(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

    [Theory(DisplayName = "Action")]
    [Trait("Category", "StringGeneration.Actions")]
    [Trait("AST", "NodeJS")]
    [InlineData(
        "ActionCallbackWithResult.ts",
        "Actions",
        "ActionCallbackWithResult.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "ActionTypeCallback.ts",
        "Actions",
        "ActionTypeCallback.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "TypedActionCallback.ts",
        "Actions",
        "TypedActionCallback.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "WithGenericProperty.ts",
        "Actions",
        "WithGenericProperty.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "WithMultipleGenericProperty.ts",
        "Actions",
        "WithMultipleGenericProperty.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateConstructorStringsUsingNodeJS(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);
}
