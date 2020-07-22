using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class NotSupportedStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "NotSupported")]
        [Trait("Category", "StringGeneration.NotSupported")]
        [InlineData("NotSupportedDotNetClassName.ts", "NotSupported", "NotSupportedDotNetClassName.Expected.txt", "IDisposable")]
        [InlineData("NotSupportedResponseType.ts", "NotSupported", "NotSupportedResponseType.Expected.txt", "ExampleClass")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile,
            string classIdentifier
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile,
            classIdentifier
        );
    }
}
