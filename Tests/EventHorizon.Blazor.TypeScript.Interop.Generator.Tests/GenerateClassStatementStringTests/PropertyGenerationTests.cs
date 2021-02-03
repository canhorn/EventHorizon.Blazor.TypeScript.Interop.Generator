namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.IO;
    using Xunit;

    public class PropertyGenerationTests
        : GenerateStringTestBase
    {
        [Theory(DisplayName = "Property.Static")]
        [Trait("Category", "Property.Static")]
        [Trait("AST", "Sdcb")]
        [InlineData("PropertyStaticClass.ts", "Properties", "PropertyStaticClass.Expected.txt")]
        [InlineData("PropertyStaticClassArray.ts", "Properties", "PropertyStaticClassArray.Expected.txt")]
        [InlineData("PropertyStaticPrimitive.ts", "Properties", "PropertyStaticPrimitive.Expected.txt")]
        [InlineData("PropertyStaticPrimitiveArray.ts", "Properties", "PropertyStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticPropertyStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Property")]
        [Trait("Category", "Property")]
        [Trait("AST", "Sdcb")]
        [InlineData("PropertyClass.ts", "Properties", "PropertyClass.Expected.txt")]
        [InlineData("PropertyClassArray.ts", "Properties", "PropertyClassArray.Expected.txt")]
        [InlineData("PropertyPrimitive.ts", "Properties", "PropertyPrimitive.Expected.txt")]
        [InlineData("PropertyPrimitiveArray.ts", "Properties", "PropertyPrimitiveArray.Expected.txt")]
        public void ShouldGeneratePropertyStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Property.Scenarios")]
        [Trait("Category", "Property.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData("AnyLiteralPropertyType.ts", "Properties", "Scenarios", "AnyLiteralPropertyType.Expected.txt")]
        [InlineData("ArrayInterfaceResponse.ts", "Properties", "Scenarios", "ArrayInterfaceResponse.Expected.txt")]
        [InlineData("DotNetNormalized.ts", "Properties", "Scenarios", "DotNetNormalized.Expected.txt")]
        [InlineData("PropertyGenericTypes.ts", "Properties", "Scenarios", "PropertyGenericTypes.Expected.txt")]
        [InlineData("PropertyJavaScriptTypes.ts", "Properties", "Scenarios", "PropertyJavaScriptTypes.Expected.txt")]
        [InlineData("PropertyParenthesized.ts", "Properties", "Scenarios", "PropertyParenthesized.Expected.txt")]
        [InlineData("PropertyStaticRootNamespace.ts", "Properties", "Scenarios", "PropertyStaticRootNamespace.Expected.txt")]
        [InlineData("TypeofResponse.ts", "Properties", "Scenarios", "TypeofResponse.Expected.txt")]
        [InlineData("UnionLiteralPropertyType.ts", "Properties", "Scenarios", "UnionLiteralPropertyType.Expected.txt")]
        public void ShouldGeneratePropertyScenarioStrings(
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
