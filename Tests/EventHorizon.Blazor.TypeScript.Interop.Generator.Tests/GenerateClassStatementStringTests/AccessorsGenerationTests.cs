namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.IO;
    using Xunit;

    public class AccessorsGenerationTests
        : GenerateStringTestBase
    {
        [Theory(DisplayName = "Accessors.Static")]
        [Trait("Category", "Accessors.Static")]
        [Trait("AST", "Sdcb")]
        [InlineData("AccessorStaticClass.ts", "Accessors", "AccessorStaticClass.Expected.txt")]
        [InlineData("AccessorStaticClassArray.ts", "Accessors", "AccessorStaticClassArray.Expected.txt")]
        [InlineData("AccessorStaticPrimitive.ts", "Accessors", "AccessorStaticPrimitive.Expected.txt")]
        [InlineData("AccessorStaticPrimitiveArray.ts", "Accessors", "AccessorStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticAccessorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Accessors")]
        [Trait("Category", "Accessors")]
        [Trait("AST", "Sdcb")]
        [InlineData("AccessorClass.ts", "Accessors", "AccessorClass.Expected.txt")]
        [InlineData("AccessorClassArray.ts", "Accessors", "AccessorClassArray.Expected.txt")]
        [InlineData("AccessorPrimitive.ts", "Accessors", "AccessorPrimitive.Expected.txt")]
        [InlineData("AccessorPrimitiveArray.ts", "Accessors", "AccessorPrimitiveArray.Expected.txt")]
        public void ShouldGenerateAccessorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Accessors.Scenarios")]
        [Trait("Category", "Accessors.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData("AccessorClassResponseType.ts", "Accessors", "Scenarios", "AccessorClassResponseType.Expected.txt")]
        [InlineData("AccessorSetNoGet.ts", "Accessors", "Scenarios", "AccessorSetNoGet.Expected.txt")]
        [InlineData("DotNetNormalized.ts", "Accessors", "Scenarios", "DotNetNormalized.Expected.txt")]
        [InlineData("GenericObserver.ts", "Accessors", "Scenarios", "GenericObserver.Expected.txt")]
        [InlineData("InterfaceResponse.ts", "Accessors", "Scenarios", "InterfaceResponse.Expected.txt")]
        [InlineData("NamespacedTyping.ts", "Accessors", "Scenarios", "NamespacedTyping.Expected.txt")]
        [InlineData("NullableTyping.ts", "Accessors", "Scenarios", "NullableTyping.Expected.txt")]
        [InlineData("StaticRootNamespace.ts", "Accessors", "Scenarios", "StaticRootNamespace.Expected.txt")]
        public void ShouldGenerateAccessorScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );
    }
}
