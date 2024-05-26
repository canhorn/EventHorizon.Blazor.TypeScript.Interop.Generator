namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class PromiseGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Promise")]
        [Trait("Category", "StandardPromises")]
        [Trait("AST", "Sdcb")]
        [InlineData(
            "ArrayTaskPromise.ts",
            "Promise",
            "ArrayTaskPromise.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "ClassArrayTaskPromise.ts",
            "Promise",
            "ClassArrayTaskPromise.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "ClassTaskPromise.ts",
            "Promise",
            "ClassTaskPromise.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData("TaskPromise.ts", "Promise", "TaskPromise.Expected.txt", ASTParserType.Sdcb)]
        [InlineData(
            "LiteralTaskPromise.ts",
            "Promise",
            "LiteralTaskPromise.Expected.txt",
            ASTParserType.Sdcb
        )]
        public void ShouldGenerateConstructorStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

        [Theory(DisplayName = "Promise")]
        [Trait("Category", "StandardPromises")]
        [Trait("AST", "NodeJS")]
        [InlineData(
            "ArrayTaskPromise.ts",
            "Promise",
            "ArrayTaskPromise.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "ClassArrayTaskPromise.ts",
            "Promise",
            "ClassArrayTaskPromise.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "ClassTaskPromise.ts",
            "Promise",
            "ClassTaskPromise.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData("TaskPromise.ts", "Promise", "TaskPromise.Expected.txt", ASTParserType.NodeJS)]
        [InlineData(
            "LiteralTaskPromise.ts",
            "Promise",
            "LiteralTaskPromise.Expected.txt",
            ASTParserType.NodeJS
        )]
        public void ShouldGenerateConstructorStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);
    }
}
