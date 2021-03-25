namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class ClassStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Class")]
        [Trait("Category", "StringGeneration.Classes")]
        [Trait("AST", "Sdcb")]
        [InlineData("ClassGenerics.ts", "Classes", "ClassGenerics.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("ExtendsAndImplementsClass.ts", "Classes", "ExtendsAndImplementsClass.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("ExtendsInterface.ts", "Classes", "ExtendsInterface.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("InterfaceGenerics.ts", "Classes", "InterfaceGenerics.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("NamespaceExtendsClass.ts", "Classes", "NamespaceExtendsClass.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("NamespaceImplementsInterface.ts", "Classes", "NamespaceImplementsInterface.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGenerateConstructorStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile,
            parserType: parserType
        );

        [Theory(DisplayName = "Class")]
        [Trait("Category", "StringGeneration.Classes")]
        [Trait("AST", "NodeJS")]
        [InlineData("ClassGenerics.ts", "Classes", "ClassGenerics.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("ExtendsAndImplementsClass.ts", "Classes", "ExtendsAndImplementsClass.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("ExtendsInterface.ts", "Classes", "ExtendsInterface.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("InterfaceGenerics.ts", "Classes", "InterfaceGenerics.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("NamespaceExtendsClass.ts", "Classes", "NamespaceExtendsClass.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("NamespaceImplementsInterface.ts", "Classes", "NamespaceImplementsInterface.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGenerateConstructorStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile,
            parserType: parserType
        );
    }
}
