using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class ActionStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Action")]
        [Trait("Category", "StringGeneration.Actions")]
        [InlineData("WithGenericProperty.ts", "Actions", "WithGenericProperty.Expected.txt")]
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
