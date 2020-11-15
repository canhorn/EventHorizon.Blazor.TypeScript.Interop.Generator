using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class MethodScenarioTests
        : GenerateStringTestBase
    {

        [Theory(DisplayName = "StaticMethods")]
        [Trait("Category", "Method.Static")]
        [InlineData("MethodStaticClass.ts", "Methods", "MethodStaticClass.Expected.txt")]
        [InlineData("MethodStaticClassArray.ts", "Methods", "MethodStaticClassArray.Expected.txt")]
        [InlineData("MethodStaticPrimitive.ts", "Methods", "MethodStaticPrimitive.Expected.txt")]
        [InlineData("MethodStaticPrimitiveArray.ts", "Methods", "MethodStaticPrimitiveArray.Expected.txt")]
        [InlineData("MethodStaticVoid.ts", "Methods", "MethodStaticVoid.Expected.txt")]
        public void ShouldGenerateStaticMethodStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticMethod.Scenarios")]
        [Trait("Category", "Method.Static.Scenarios")]
        [InlineData("MethodStaticAction.ts", "Methods", "Scenarios", "MethodStaticAction.Expected.txt")]
        [InlineData("MethodStaticClassWithLiteralInArguments.ts", "Methods", "Scenarios", "MethodStaticClassWithLiteralInArguments.Expected.txt")]
        [InlineData("MethodStaticClassWithNullArgument.ts", "Methods", "Scenarios", "MethodStaticClassWithNullArgument.Expected.txt")]
        [InlineData("MethodStaticClassWithUndefinedArgument.ts", "Methods", "Scenarios", "MethodStaticClassWithUndefinedArgument.Expected.txt")]
        [InlineData("MethodStaticWithLiteralAsResult.ts", "Methods", "Scenarios", "MethodStaticWithLiteralAsResult.Expected.txt")]
        public void ShouldGenerateStaticMethodScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Method")]
        [Trait("Category", "Method")]
        [InlineData("MethodClass.ts", "Methods", "MethodClass.Expected.txt")]
        [InlineData("MethodClassArray.ts", "Methods", "MethodClassArray.Expected.txt")]
        [InlineData("MethodPrimitive.ts", "Methods", "MethodPrimitive.Expected.txt")]
        [InlineData("MethodPrimitiveArray.ts", "Methods", "MethodPrimitiveArray.Expected.txt")]
        [InlineData("MethodVoid.ts", "Methods", "MethodVoid.Expected.txt")]
        public void ShouldGenerateMethodStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Method.Scenarios")]
        [Trait("Category", "Method.Scenarios")]
        [InlineData("ActionWithArguments.ts", "Methods", "Scenarios", "ActionWithArguments.Expected.txt")]
        [InlineData("ActionWithInterfaceInArguments.ts", "Methods", "Scenarios", "ActionWithInterfaceInArguments.Expected.txt")]
        [InlineData("GenericsInArguments.ts", "Methods", "Scenarios", "GenericsInArguments.Expected.txt")]
        [InlineData("InterfaceInArguments.ts", "Methods", "Scenarios", "InterfaceInArguments.Expected.txt")]
        [InlineData("MethodGenericTypes.ts", "Methods", "Scenarios", "MethodGenericTypes.Expected.txt")]
        [InlineData("MethodMultipleGenericTypeReferences.ts", "Methods", "Scenarios", "MethodMultipleGenericTypeReferences.Expected.txt")]
        [InlineData("MethodNullableTypeReference.ts", "Methods", "Scenarios", "MethodNullableTypeReference.Expected.txt")]
        [InlineData("MethodThisAsResult.ts", "Methods", "Scenarios", "MethodThisAsResult.Expected.txt")]
        [InlineData("NullableTyping.ts", "Methods", "Scenarios", "NullableTyping.Expected.txt")]
        [InlineData("PromiseResponse.ts", "Methods", "Scenarios", "PromiseResponse.Expected.txt")]
        public void ShouldGenerateMethodScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );
    }
}
