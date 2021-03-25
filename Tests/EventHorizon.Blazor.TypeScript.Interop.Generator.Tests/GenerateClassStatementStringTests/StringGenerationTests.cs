namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.Collections.Generic;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class StringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Constructor")]
        [Trait("Category", "StringGeneration.Constructors")]
        [Trait("AST", "Sdcb")]
        [InlineData("DotNetNormalizedArguments.ts", "Constructors", "DotNetNormalizedArguments.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("MixedArguments.ts", "Constructors", "MixedArguments.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("NoConstructor.ts", "Constructors", "NoConstructor.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("WithActionArgument.ts", "Constructors", "WithActionArgument.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("WithActionGenericArgument.ts", "Constructors", "WithActionGenericArgument.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("WithNullArguments.ts", "Constructors", "WithNullArguments.Expected.txt", ASTParserType.Sdcb)]
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

        [Theory(DisplayName = "ArrayTypes")]
        [Trait("Category", "StringGeneration.ArrayTypes")]
        [Trait("AST", "Sdcb")]
        [InlineData("MethodArrayTypes.ts", "Methods", "MethodArrayTypes.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyArrayTypes.ts", "Properties", "PropertyArrayTypes.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGenerateArrayTypeStringsUsingSdcb(
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

        [Theory(DisplayName = "TypeOverride.Scenarios")]
        [Trait("Category", "StringGeneration.TypeOverride.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData("AccessorOverride.ts", "TypeOverrides", "AccessorOverride.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("ConstructorOverride.ts", "TypeOverrides", "ConstructorOverride.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("MethodOverride.ts", "TypeOverrides", "MethodOverride.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("PropertyOverride.ts", "TypeOverrides", "PropertyOverride.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGenerateTypeOverrideScenarioStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
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
            expectedFile,
            parserType: parserType
        );

        [Theory(DisplayName = "Enums")]
        [Trait("Category", "StringGeneration.Enum")]
        [Trait("AST", "Sdcb")]
        [InlineData("EnumAccessor.ts", "Enums", "EnumAccessor.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("EnumArgument.ts", "Enums", "EnumArgument.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("EnumProperty.ts", "Enums", "EnumProperty.Expected.txt", ASTParserType.Sdcb)]
        [InlineData("NullableEnumAccessor.ts", "Enums", "NullableEnumAccessor.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGenerateEnumScenarioStringsUsingSdcb(
            string sourceFile,
            string rootPath,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            rootPath,
            sourceFile,
            expectedFile,
            parserType: parserType
        );


        [Theory(DisplayName = "Constructor")]
        [Trait("Category", "StringGeneration.Constructors")]
        [Trait("AST", "NodeJS")]
        [InlineData("DotNetNormalizedArguments.ts", "Constructors", "DotNetNormalizedArguments.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("MixedArguments.ts", "Constructors", "MixedArguments.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("NoConstructor.ts", "Constructors", "NoConstructor.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("WithActionArgument.ts", "Constructors", "WithActionArgument.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("WithActionGenericArgument.ts", "Constructors", "WithActionGenericArgument.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("WithNullArguments.ts", "Constructors", "WithNullArguments.Expected.txt", ASTParserType.NodeJS)]
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

        [Theory(DisplayName = "ArrayTypes")]
        [Trait("Category", "StringGeneration.ArrayTypes")]
        [Trait("AST", "NodeJS")]
        [InlineData("MethodArrayTypes.ts", "Methods", "MethodArrayTypes.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyArrayTypes.ts", "Properties", "PropertyArrayTypes.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGenerateArrayTypeStringsUsingNodeJS(
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

        [Theory(DisplayName = "TypeOverride.Scenarios")]
        [Trait("Category", "StringGeneration.TypeOverride.Scenarios")]
        [Trait("AST", "NodeJS")]
        [InlineData("AccessorOverride.ts", "TypeOverrides", "AccessorOverride.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("ConstructorOverride.ts", "TypeOverrides", "ConstructorOverride.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("MethodOverride.ts", "TypeOverrides", "MethodOverride.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("PropertyOverride.ts", "TypeOverrides", "PropertyOverride.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGenerateTypeOverrideScenarioStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
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
            expectedFile,
            parserType: parserType
        );

        [Theory(DisplayName = "Enums")]
        [Trait("Category", "StringGeneration.Enum")]
        [Trait("AST", "NodeJS")]
        [InlineData("EnumAccessor.ts", "Enums", "EnumAccessor.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("EnumArgument.ts", "Enums", "EnumArgument.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("EnumProperty.ts", "Enums", "EnumProperty.Expected.txt", ASTParserType.NodeJS)]
        [InlineData("NullableEnumAccessor.ts", "Enums", "NullableEnumAccessor.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGenerateEnumScenarioStringsUsingNodeJS(
            string sourceFile,
            string rootPath,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(
            rootPath,
            sourceFile,
            expectedFile,
            parserType: parserType
        );
    }
}
