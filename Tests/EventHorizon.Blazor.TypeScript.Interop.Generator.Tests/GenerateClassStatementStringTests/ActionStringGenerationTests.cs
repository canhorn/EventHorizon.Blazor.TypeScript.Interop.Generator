using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class ActionStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Action")]
        [Trait("Category", "StringGeneration.Actions")]
        [InlineData("TypedActionCallback.ts", "Actions", "TypedActionCallback.Expected.txt")]
        [InlineData("WithGenericProperty.ts", "Actions", "WithGenericProperty.Expected.txt")]
        [InlineData("WithMultipleGenericProperty.ts", "Actions", "WithMultipleGenericProperty.Expected.txt")]
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
