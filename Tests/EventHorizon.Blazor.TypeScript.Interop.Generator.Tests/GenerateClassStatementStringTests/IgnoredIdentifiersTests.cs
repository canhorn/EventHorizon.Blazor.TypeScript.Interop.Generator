namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class IgnoredIdentifiersTests : GenerateStringTestBase
{
    [Theory(DisplayName = "IgnoredIdentifiers.Scenarios")]
    [Trait("Category", "IgnoredIdentifiers.Scenarios")]
    [Trait("AST", "Sdcb,NodeJS")]
    [InlineData(
        "IgnoredIdentifiers.ts",
        "IgnoredIdentifiers",
        "IgnoredIdentifiers.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "IgnoredIdentifiers.ts",
        "IgnoredIdentifiers",
        "IgnoredIdentifiers.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateIgnoredIdentifiersScenarioStrings(
        string sourceFile,
        string rootPath,
        string expectedFile,
        ASTParserType parserType
    ) =>
        ValidateGenerateWithIgnoreIdentifiers(
            rootPath,
            sourceFile,
            ignoredIdentifiers:
            [
                // This is advance typescript that is not supported by the Sdbc parser.
                "Examples.ExampleClass.R[PropertySignature]",
                "Examples.ExampleClass.property[PropertySignature]",
                "Examples.ExampleClass.getProperty[GetAccessor]",
                "Examples.ExampleClass.setProperty[SetAccessor]",
                "Examples.ExampleClass.getProperty[MethodSignature]",
                "Examples.ExampleClass.setProperty[MethodSignature]",
                "Examples.ExampleClass.propertySignature[PropertySignature]",
                "Examples.ExampleClass.addToRef[MethodSignature]",
                "Examples.ExampleClass.subtractFromFloatsToRef[MethodSignature]",
                "Examples.ExampleClass.method[MethodSignature]",
                "Examples.ExampleClass.method[MethodDeclaration]",
            ],
            expectedFile,
            parserType: parserType
        );
}
