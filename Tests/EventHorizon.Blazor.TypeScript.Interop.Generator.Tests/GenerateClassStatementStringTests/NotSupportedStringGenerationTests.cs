namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class NotSupportedStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "NotSupported")]
        [Trait("Category", "StringGeneration.NotSupported")]
        [Trait("AST", "Sdcb")]
        [InlineData("IDisposablDotNetInterfaceName.ts", "NotSupported", "IDisposablDotNetInterfaceName.Expected.txt", "IDisposable", ASTParserType.Sdcb)]
        [InlineData("NotSupportedDotNetClassName.ts", "NotSupported", "NotSupportedDotNetClassName.Expected.txt", "IDisposable", ASTParserType.Sdcb)]
        [InlineData("NotSupportedResponseType.ts", "NotSupported", "NotSupportedResponseType.Expected.txt", "ExampleClass", ASTParserType.Sdcb)]
        public void ShouldGenerateConstructorStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            string classIdentifier,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile,
            classIdentifier,
            parserType: parserType
        );

        [Theory(DisplayName = "NotSupported")]
        [Trait("Category", "StringGeneration.NotSupported")]
        [Trait("AST", "NodeJS")]
        [InlineData("IDisposablDotNetInterfaceName.ts", "NotSupported", "IDisposablDotNetInterfaceName.Expected.txt", "IDisposable", ASTParserType.NodeJS)]
        [InlineData("NotSupportedDotNetClassName.ts", "NotSupported", "NotSupportedDotNetClassName.Expected.txt", "IDisposable", ASTParserType.NodeJS)]
        [InlineData("NotSupportedResponseType.ts", "NotSupported", "NotSupportedResponseType.Expected.txt", "ExampleClass", ASTParserType.NodeJS)]
        public void ShouldGenerateConstructorStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            string classIdentifier,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile,
            classIdentifier,
            parserType: parserType
        );
    }
}
