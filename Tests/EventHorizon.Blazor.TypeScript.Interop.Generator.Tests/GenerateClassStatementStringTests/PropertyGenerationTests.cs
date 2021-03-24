namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class PropertyGenerationTests
        : GenerateStringTestBase
    {
        [Theory(DisplayName = "Property.Static")]
        [Trait("Category", "Property.Static")]
        [Trait("AST", "Sdcb")]
        [InlineData("PropertyStaticClass.ts", "Properties", "PropertyStaticClass.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyStaticClassArray.ts", "Properties", "PropertyStaticClassArray.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyStaticPrimitive.ts", "Properties", "PropertyStaticPrimitive.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyStaticPrimitiveArray.ts", "Properties", "PropertyStaticPrimitiveArray.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGenerateStaticPropertyStringsUsingSdcb(
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

        [Theory(DisplayName = "Property")]
        [Trait("Category", "Property")]
        [Trait("AST", "Sdcb")]
        [InlineData("PropertyClass.ts", "Properties", "PropertyClass.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyClassArray.ts", "Properties", "PropertyClassArray.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyPrimitive.ts", "Properties", "PropertyPrimitive.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyPrimitiveArray.ts", "Properties", "PropertyPrimitiveArray.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGeneratePropertyStringsUsingSdcb(
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

        [Theory(DisplayName = "Property.Scenarios")]
        [Trait("Category", "Property.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData("AnyLiteralPropertyType.ts", "Properties", "Scenarios", "AnyLiteralPropertyType.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("ArrayInterfaceResponse.ts", "Properties", "Scenarios", "ArrayInterfaceResponse.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("DotNetNormalized.ts", "Properties", "Scenarios", "DotNetNormalized.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyGenericTypes.ts", "Properties", "Scenarios", "PropertyGenericTypes.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyJavaScriptTypes.ts", "Properties", "Scenarios", "PropertyJavaScriptTypes.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyParenthesized.ts", "Properties", "Scenarios", "PropertyParenthesized.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyStaticRootNamespace.ts", "Properties", "Scenarios", "PropertyStaticRootNamespace.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("TypeofResponse.ts", "Properties", "Scenarios", "TypeofResponse.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("TypeofToPrimitiveResponse.ts", "Properties", "Scenarios", "TypeofToPrimitiveResponse.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("UnionLiteralPropertyType.ts", "Properties", "Scenarios", "UnionLiteralPropertyType.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGeneratePropertyScenarioStringsUsingSdcb(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType
        );


        [Theory(DisplayName = "Property.Static")]
        [Trait("Category", "Property.Static")]
        [Trait("AST", "NodeJS")]
        [InlineData("PropertyStaticClass.ts", "Properties", "PropertyStaticClass.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyStaticClassArray.ts", "Properties", "PropertyStaticClassArray.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyStaticPrimitive.ts", "Properties", "PropertyStaticPrimitive.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyStaticPrimitiveArray.ts", "Properties", "PropertyStaticPrimitiveArray.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGenerateStaticPropertyStringsUsingNodeJS(
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

        [Theory(DisplayName = "Property")]
        [Trait("Category", "Property")]
        [Trait("AST", "NodeJS")]
        [InlineData("PropertyClass.ts", "Properties", "PropertyClass.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyClassArray.ts", "Properties", "PropertyClassArray.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyPrimitive.ts", "Properties", "PropertyPrimitive.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyPrimitiveArray.ts", "Properties", "PropertyPrimitiveArray.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGeneratePropertyStringsUsingNodeJS(
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

        [Theory(DisplayName = "Property.Scenarios")]
        [Trait("Category", "Property.Scenarios")]
        [Trait("AST", "NodeJS")]
        [InlineData("AnyLiteralPropertyType.ts", "Properties", "Scenarios", "AnyLiteralPropertyType.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("ArrayInterfaceResponse.ts", "Properties", "Scenarios", "ArrayInterfaceResponse.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("DotNetNormalized.ts", "Properties", "Scenarios", "DotNetNormalized.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyGenericTypes.ts", "Properties", "Scenarios", "PropertyGenericTypes.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyJavaScriptTypes.ts", "Properties", "Scenarios", "PropertyJavaScriptTypes.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyParenthesized.ts", "Properties", "Scenarios", "PropertyParenthesized.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyStaticRootNamespace.ts", "Properties", "Scenarios", "PropertyStaticRootNamespace.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("TypeofResponse.ts", "Properties", "Scenarios", "TypeofResponse.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("TypeofToPrimitiveResponse.ts", "Properties", "Scenarios", "TypeofToPrimitiveResponse.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("UnionLiteralPropertyType.ts", "Properties", "Scenarios", "UnionLiteralPropertyType.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGeneratePropertyScenarioStringsUsingNodeJS(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType
        );
    }
}
