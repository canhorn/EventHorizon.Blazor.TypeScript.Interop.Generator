namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using Xunit;

    public class ClassStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Class")]
        [Trait("Category", "StringGeneration.Classes")]
        [Trait("AST", "Sdcb")]
        [InlineData("ExtendsAndImplementsClass.ts", "Classes", "ExtendsAndImplementsClass.Expected.txt")]
        [InlineData("ExtendsInterface.ts", "Classes", "ExtendsInterface.Expected.txt")]
        [InlineData("InterfaceGenerics.ts", "Classes", "InterfaceGenerics.Expected.txt")]
        [InlineData("NamespaceExtendsClass.ts", "Classes", "NamespaceExtendsClass.Expected.txt")]
        [InlineData("NamespaceImplementsInterface.ts", "Classes", "NamespaceImplementsInterface.Expected.txt")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );
    }
}
