using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class StringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Constructor")]
        [Trait("Category", "StringGeneration.Constructors")]
        [InlineData("DotNetNormalizedArguments.ts", "Constructors", "DotNetNormalizedArguments.Expected.txt")]
        [InlineData("MixedArguments.ts", "Constructors", "MixedArguments.Expected.txt")]
        [InlineData("NoConstructor.ts", "Constructors", "NoConstructor.Expected.txt")]
        [InlineData("WithActionArgument.ts", "Constructors", "WithActionArgument.Expected.txt")]
        [InlineData("WithActionGenericArgument.ts", "Constructors", "WithActionGenericArgument.Expected.txt")]
        [InlineData("WithNullArguments.ts", "Constructors", "WithNullArguments.Expected.txt")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticAccessor")]
        [Trait("Category", "StringGeneration.StaticAccessors")]
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

        [Theory(DisplayName = "Accessor")]
        [Trait("Category", "StringGeneration.Accessors")]
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

        [Theory(DisplayName = "Accessor.Scenarios")]
        [Trait("Category", "StringGeneration.Accessor.Scenarios")]
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
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "ArrayTypes")]
        [Trait("Category", "StringGeneration.ArrayTypes")]
        [InlineData("MethodArrayTypes.ts", "Methods", "MethodArrayTypes.Expected.txt")]
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

        [Theory(DisplayName = "TypeOverride.Scenarios")]
        [Trait("Category", "StringGeneration.TypeOverride.Scenarios")]
        [InlineData("AccessorOverride.ts", "TypeOverrides", "AccessorOverride.Expected.txt")]
        [InlineData("ConstructorOverride.ts", "TypeOverrides", "ConstructorOverride.Expected.txt")]
        [InlineData("MethodOverride.ts", "TypeOverrides", "MethodOverride.Expected.txt")]
        [InlineData("PropertyOverride.ts", "TypeOverrides", "PropertyOverride.Expected.txt")]
        public void ShouldGenerateTypeOverrideScenarioStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateWithTypeOverrideStrings(
            path,
            sourceFile,
            new Dictionary<string, string>
            {
                { "Examples.ExampleClass | static | vectorStaticCheck", "OverrideVector4" },
                { "Examples.ExampleClass | static | primativeStaticCheck", "int" },
                { "Examples.ExampleClass | vectorCheck", "OverrideVector4" },
                { "Examples.ExampleClass | primativeCheck", "int" },

                { "Examples.ExampleClass | static | methodStaticCheck", "int" },
                { "Examples.ExampleClass | static | vectorStaticMethodCheck | arg1", "OverrideVector4" },
                { "Examples.ExampleClass | static | primativeStaticMethodCheck | arg2", "int" },
                { "Examples.ExampleClass | methodCheck", "OverrideVector4" },
                { "Examples.ExampleClass | vectorMethodCheck | arg1", "OverrideVector4" },
                { "Examples.ExampleClass | primativeMethodCheck | arg2", "int" },

                { "Examples.ExampleClass | constructor | arg1", "OverrideVector4" },
                { "Examples.ExampleClass | constructor | arg2", "int" },
            },
            expectedFile
        );

        [Theory(DisplayName = "Enums")]
        [Trait("Category", "StringGeneration.Enum")]
        [InlineData("EnumAccessor.ts", "Enums", "EnumAccessor.Expected.txt")]
        [InlineData("EnumArgument.ts", "Enums", "EnumArgument.Expected.txt")]
        [InlineData("EnumProperty.ts", "Enums", "EnumProperty.Expected.txt")]
        [InlineData("NullableEnumAccessor.ts", "Enums", "NullableEnumAccessor.Expected.txt")]
        public void ShouldGenerateEnumScenarioStrings(
            string sourceFile,
            string rootPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            rootPath,
            sourceFile,
            expectedFile
        );
    }
}
