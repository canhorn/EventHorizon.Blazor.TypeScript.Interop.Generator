namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.Collections.Generic;
    using Xunit;

    public class StringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Constructor")]
        [Trait("Category", "StringGeneration.Constructors")]
        [Trait("AST", "Sdcb")]
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
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "ArrayTypes")]
        [Trait("Category", "StringGeneration.ArrayTypes")]
        [Trait("AST", "Sdcb")]
        [InlineData("MethodArrayTypes.ts", "Methods", "MethodArrayTypes.Expected.txt")]
        [InlineData("PropertyArrayTypes.ts", "Properties", "PropertyArrayTypes.Expected.txt")]
        public void ShouldGenerateArrayTypeStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "TypeOverride.Scenarios")]
        [Trait("Category", "StringGeneration.TypeOverride.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData("AccessorOverride.ts", "TypeOverrides", "AccessorOverride.Expected.txt")]
        [InlineData("ConstructorOverride.ts", "TypeOverrides", "ConstructorOverride.Expected.txt")]
        [InlineData("MethodOverride.ts", "TypeOverrides", "MethodOverride.Expected.txt")]
        [InlineData("PropertyOverride.ts", "TypeOverrides", "PropertyOverride.Expected.txt")]
        public void ShouldGenerateTypeOverrideScenarioStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateWithTypeOverrideStringsUsingSdcb(
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
        [Trait("AST", "Sdcb")]
        [InlineData("EnumAccessor.ts", "Enums", "EnumAccessor.Expected.txt")]
        [InlineData("EnumArgument.ts", "Enums", "EnumArgument.Expected.txt")]
        [InlineData("EnumProperty.ts", "Enums", "EnumProperty.Expected.txt")]
        [InlineData("NullableEnumAccessor.ts", "Enums", "NullableEnumAccessor.Expected.txt")]
        public void ShouldGenerateEnumScenarioStrings(
            string sourceFile,
            string rootPath,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            rootPath,
            sourceFile,
            expectedFile
        );
    }
}
