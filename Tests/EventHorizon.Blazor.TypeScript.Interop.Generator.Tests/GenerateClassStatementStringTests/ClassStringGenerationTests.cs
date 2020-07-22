using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class ClassStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Class")]
        [Trait("Category", "StringGeneration.Classes")]
        [InlineData("ExtendsInterface.ts", "Classes", "ExtendsInterface.Expected.txt")]
        [InlineData("InterfaceGenerics.ts", "Classes", "InterfaceGenerics.Expected.txt")]
        [InlineData("NamespaceExtendsClass.ts", "Classes", "NamespaceExtendsClass.Expected.txt")]
        [InlineData("NamespaceImplementsInterface.ts", "Classes", "NamespaceImplementsInterface.Expected.txt")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );
    }
}
