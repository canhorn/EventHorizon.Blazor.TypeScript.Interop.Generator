using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class StringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "StaticAccessor")]
        [Trait("Category", "StringGeneration.StaticAccessors")]
        // Static Accessors
        [InlineData("AccessorStaticClass.ts", "Accessors", "AccessorStaticClass.Expected.txt")]
        [InlineData("AccessorStaticClassArray.ts", "Accessors", "AccessorStaticClassArray.Expected.txt")]
        [InlineData("AccessorStaticPrimitive.ts", "Accessors", "AccessorStaticPrimitive.Expected.txt")]
        [InlineData("AccessorStaticPrimitiveArray.ts", "Accessors", "AccessorStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticAccessorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticProperties")]
        [Trait("Category", "StringGeneration.StaticProperties")]
        // Static Properties
        [InlineData("PropertyStaticClass.ts", "Properties", "PropertyStaticClass.Expected.txt")]
        [InlineData("PropertyStaticClassArray.ts", "Properties", "PropertyStaticClassArray.Expected.txt")]
        [InlineData("PropertyStaticPrimitive.ts", "Properties", "PropertyStaticPrimitive.Expected.txt")]
        [InlineData("PropertyStaticPrimitiveArray.ts", "Properties", "PropertyStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticPropertyStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticMethods")]
        [Trait("Category", "StringGeneration.StaticMethods")]
        [InlineData("MethodStaticClass.ts", "Methods", "MethodStaticClass.Expected.txt")]
        [InlineData("MethodStaticClassWithLiteralInArguments.ts", "Methods", "MethodStaticClassWithLiteralInArguments.Expected.txt")]
        public void ShouldGenerateStaticMethodStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Accessor")]
        [Trait("Category", "StringGeneration.Accessors")]
        // Accessors
        [InlineData("AccessorClass.ts", "Accessors", "AccessorClass.Expected.txt")]
        [InlineData("AccessorClassArray.ts", "Accessors", "AccessorClassArray.Expected.txt")]
        [InlineData("AccessorPrimitive.ts", "Accessors", "AccessorPrimitive.Expected.txt")]
        [InlineData("AccessorPrimitiveArray.ts", "Accessors", "AccessorPrimitiveArray.Expected.txt")]
        public void ShouldGenerateAccessorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Properties")]
        [Trait("Category", "StringGeneration.Properties")]
        // Properties
        [InlineData("PropertyClass.ts", "Properties", "PropertyClass.Expected.txt")]
        [InlineData("PropertyClassArray.ts", "Properties", "PropertyClassArray.Expected.txt")]
        [InlineData("PropertyPrimitive.ts", "Properties", "PropertyPrimitive.Expected.txt")]
        [InlineData("PropertyPrimitiveArray.ts", "Properties", "PropertyPrimitiveArray.Expected.txt")]
        public void ShouldGeneratePropertyStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "ArrayTypes")]
        [Trait("Category", "StringGeneration.ArrayTypes")]
        // Arrays
        [InlineData("PropertyArrayTypes.ts", "Properties", "PropertyArrayTypes.Expected.txt")]
        public void ShouldGenerateArrayTypeStrings(
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
