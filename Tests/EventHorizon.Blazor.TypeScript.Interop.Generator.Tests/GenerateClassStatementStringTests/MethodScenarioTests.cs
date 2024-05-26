namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using Xunit;

    public class MethodScenarioTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "StaticMethods")]
        [Trait("Category", "Method.Static")]
        [Trait("AST", "Sdcb")]
        [InlineData(
            "MethodStaticClass.ts",
            "Methods",
            "MethodStaticClass.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticClassArray.ts",
            "Methods",
            "MethodStaticClassArray.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticPrimitive.ts",
            "Methods",
            "MethodStaticPrimitive.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticPrimitiveArray.ts",
            "Methods",
            "MethodStaticPrimitiveArray.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticVoid.ts",
            "Methods",
            "MethodStaticVoid.Expected.txt",
            ASTParserType.Sdcb
        )]
        public void ShouldGenerateStaticMethodStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

        [Theory(DisplayName = "StaticMethod.Scenarios")]
        [Trait("Category", "Method.Static.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData(
            "MethodStaticAction.ts",
            "Methods",
            "Scenarios",
            "MethodStaticAction.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticClassWithLiteralInArguments.ts",
            "Methods",
            "Scenarios",
            "MethodStaticClassWithLiteralInArguments.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticClassWithNullArgument.ts",
            "Methods",
            "Scenarios",
            "MethodStaticClassWithNullArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticClassWithUndefinedArgument.ts",
            "Methods",
            "Scenarios",
            "MethodStaticClassWithUndefinedArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodStaticWithLiteralAsResult.ts",
            "Methods",
            "Scenarios",
            "MethodStaticWithLiteralAsResult.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "StaticNoNamespace.d.ts",
            "Methods",
            "Scenarios",
            "StaticNoNamespace.d.Expected.txt",
            ASTParserType.Sdcb
        )]
        public void ShouldGenerateStaticMethodScenarioStringsUsingSdcb(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile,
            ASTParserType parserType
        ) =>
            ValidateGenerateStrings(
                Path.Combine(rootPath, scenariosPath),
                sourceFile,
                expectedFile,
                parserType: parserType
            );

        [Theory(DisplayName = "Method")]
        [Trait("Category", "Method")]
        [Trait("AST", "Sdcb")]
        [InlineData("MethodClass.ts", "Methods", "MethodClass.Expected.txt", ASTParserType.Sdcb)]
        [InlineData(
            "MethodClassArray.ts",
            "Methods",
            "MethodClassArray.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodPrimitive.ts",
            "Methods",
            "MethodPrimitive.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodPrimitiveArray.ts",
            "Methods",
            "MethodPrimitiveArray.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData("MethodVoid.ts", "Methods", "MethodVoid.Expected.txt", ASTParserType.Sdcb)]
        public void ShouldGenerateMethodStringsUsingSdcb(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

        [Theory(DisplayName = "Method.Scenarios")]
        [Trait("Category", "Method.Scenarios")]
        [Trait("AST", "Sdcb")]
        [InlineData(
            "ActionWithArguments.ts",
            "Methods",
            "Scenarios",
            "ActionWithArguments.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "ActionWithInterfaceInArguments.ts",
            "Methods",
            "Scenarios",
            "ActionWithInterfaceInArguments.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "ArrayDestructuring.ts",
            "Methods",
            "Scenarios",
            "ArrayDestructuring.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "GenericsInArguments.ts",
            "Methods",
            "Scenarios",
            "GenericsInArguments.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "InterfaceInArguments.ts",
            "Methods",
            "Scenarios",
            "InterfaceInArguments.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodGenericArrayDestructuring.ts",
            "Methods",
            "Scenarios",
            "MethodGenericArrayDestructuring.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodGenericTypes.ts",
            "Methods",
            "Scenarios",
            "MethodGenericTypes.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodMultipleGenericTypeReferences.ts",
            "Methods",
            "Scenarios",
            "MethodMultipleGenericTypeReferences.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodNullableTypeReference.ts",
            "Methods",
            "Scenarios",
            "MethodNullableTypeReference.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodNullModiferArgument.ts",
            "Methods",
            "Scenarios",
            "MethodNullModiferArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodThisAsResult.ts",
            "Methods",
            "Scenarios",
            "MethodThisAsResult.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "NullableTyping.ts",
            "Methods",
            "Scenarios",
            "NullableTyping.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "PromiseResponse.ts",
            "Methods",
            "Scenarios",
            "PromiseResponse.Expected.txt",
            ASTParserType.Sdcb
        )]
        public void ShouldGenerateMethodScenarioStringsUsingSdcb(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile,
            ASTParserType parserType
        ) =>
            ValidateGenerateStrings(
                Path.Combine(rootPath, scenariosPath),
                sourceFile,
                expectedFile,
                parserType: parserType
            );

        [Theory(DisplayName = "StaticMethods")]
        [Trait("Category", "Method.Static")]
        [Trait("AST", "NodeJS")]
        [InlineData(
            "MethodStaticClass.ts",
            "Methods",
            "MethodStaticClass.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticClassArray.ts",
            "Methods",
            "MethodStaticClassArray.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticPrimitive.ts",
            "Methods",
            "MethodStaticPrimitive.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticPrimitiveArray.ts",
            "Methods",
            "MethodStaticPrimitiveArray.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticVoid.ts",
            "Methods",
            "MethodStaticVoid.Expected.txt",
            ASTParserType.NodeJS
        )]
        public void ShouldGenerateStaticMethodStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

        [Theory(DisplayName = "StaticMethod.Scenarios")]
        [Trait("Category", "Method.Static.Scenarios")]
        [Trait("AST", "NodeJS")]
        [InlineData(
            "MethodStaticAction.ts",
            "Methods",
            "Scenarios",
            "MethodStaticAction.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticClassWithLiteralInArguments.ts",
            "Methods",
            "Scenarios",
            "MethodStaticClassWithLiteralInArguments.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticClassWithNullArgument.ts",
            "Methods",
            "Scenarios",
            "MethodStaticClassWithNullArgument.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticClassWithUndefinedArgument.ts",
            "Methods",
            "Scenarios",
            "MethodStaticClassWithUndefinedArgument.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodStaticWithLiteralAsResult.ts",
            "Methods",
            "Scenarios",
            "MethodStaticWithLiteralAsResult.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "StaticNoNamespace.d.ts",
            "Methods",
            "Scenarios",
            "StaticNoNamespace.d.Expected.txt",
            ASTParserType.NodeJS
        )]
        public void ShouldGenerateStaticMethodScenarioStringsUsingNodeJS(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile,
            ASTParserType parserType
        ) =>
            ValidateGenerateStrings(
                Path.Combine(rootPath, scenariosPath),
                sourceFile,
                expectedFile,
                parserType: parserType
            );

        [Theory(DisplayName = "Method")]
        [Trait("Category", "Method")]
        [Trait("AST", "NodeJS")]
        [InlineData("MethodClass.ts", "Methods", "MethodClass.Expected.txt", ASTParserType.NodeJS)]
        [InlineData(
            "MethodClassArray.ts",
            "Methods",
            "MethodClassArray.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodPrimitive.ts",
            "Methods",
            "MethodPrimitive.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodPrimitiveArray.ts",
            "Methods",
            "MethodPrimitiveArray.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData("MethodVoid.ts", "Methods", "MethodVoid.Expected.txt", ASTParserType.NodeJS)]
        public void ShouldGenerateMethodStringsUsingNodeJS(
            string sourceFile,
            string path,
            string expectedFile,
            ASTParserType parserType
        ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

        [Theory(DisplayName = "Method.Scenarios")]
        [Trait("Category", "Method.Scenarios")]
        [Trait("AST", "NodeJS")]
        [InlineData(
            "ActionWithArguments.ts",
            "Methods",
            "Scenarios",
            "ActionWithArguments.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "ActionWithInterfaceInArguments.ts",
            "Methods",
            "Scenarios",
            "ActionWithInterfaceInArguments.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "ArrayDestructuring.ts",
            "Methods",
            "Scenarios",
            "ArrayDestructuring.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "GenericsInArguments.ts",
            "Methods",
            "Scenarios",
            "GenericsInArguments.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "InterfaceInArguments.ts",
            "Methods",
            "Scenarios",
            "InterfaceInArguments.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodGenericArrayDestructuring.ts",
            "Methods",
            "Scenarios",
            "MethodGenericArrayDestructuring.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodGenericTypes.ts",
            "Methods",
            "Scenarios",
            "MethodGenericTypes.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodMultipleGenericTypeReferences.ts",
            "Methods",
            "Scenarios",
            "MethodMultipleGenericTypeReferences.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodNullableTypeReference.ts",
            "Methods",
            "Scenarios",
            "MethodNullableTypeReference.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "MethodNullModiferArgument.ts",
            "Methods",
            "Scenarios",
            "MethodNullModiferArgument.Expected.txt",
            ASTParserType.Sdcb
        )]
        [InlineData(
            "MethodThisAsResult.ts",
            "Methods",
            "Scenarios",
            "MethodThisAsResult.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "NullableTyping.ts",
            "Methods",
            "Scenarios",
            "NullableTyping.Expected.txt",
            ASTParserType.NodeJS
        )]
        [InlineData(
            "PromiseResponse.ts",
            "Methods",
            "Scenarios",
            "PromiseResponse.Expected.txt",
            ASTParserType.NodeJS
        )]
        public void ShouldGenerateMethodScenarioStringsUsingNodeJS(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile,
            ASTParserType parserType
        ) =>
            ValidateGenerateStrings(
                Path.Combine(rootPath, scenariosPath),
                sourceFile,
                expectedFile,
                parserType: parserType
            );
    }
}
