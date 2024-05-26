namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class TypeAliasGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "TypeAlias")]
        [Trait("Category", "TypeAlias")]
        [Trait("AST", "Sdcb")]
        [InlineData(
            "NullableActionCallbackArgument.ts",
            "TypeAlias",
            "NullableActionCallbackArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "NullableAliasActionCallbackArgument.ts",
            "TypeAlias",
            "NullableAliasActionCallbackArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "NullableNumberArgument.ts",
            "TypeAlias",
            "NullableNumberArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "NullableTypeResponse.ts",
            "TypeAlias",
            "NullableTypeResponse.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "ObjectTypeResponse.ts",
            "TypeAlias",
            "ObjectTypeResponse.Expected.txt",
            ASTParserType.Sdcb
        )]
        public void ShouldGenerateTypeAliasStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

        [Theory(DisplayName = "TypeAlias")]
        [Trait("Category", "TypeAlias")]
        [Trait("AST", "NodeJS")]
        [InlineData(
            "NullableActionCallbackArgument.ts",
            "TypeAlias",
            "NullableActionCallbackArgument.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "NullableAliasActionCallbackArgument.ts",
            "TypeAlias",
            "NullableAliasActionCallbackArgument.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "NullableNumberArgument.ts",
            "TypeAlias",
            "NullableNumberArgument.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "NullableTypeResponse.ts",
            "TypeAlias",
            "NullableTypeResponse.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "ObjectTypeResponse.ts",
            "TypeAlias",
            "ObjectTypeResponse.Expected.txt",
            ASTParserType.NodeJS
        )]
        public void ShouldGenerateTypeAliasStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);
    }
}
