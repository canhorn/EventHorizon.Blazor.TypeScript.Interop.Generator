using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class NotSupportedStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "NotSupported")]
        [Trait("Category", "StringGeneration.NotSupported")]
        [InlineData("NotSupportedResponseType.ts", "NotSupported", "NotSupportedResponseType.Expected.txt")]
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
