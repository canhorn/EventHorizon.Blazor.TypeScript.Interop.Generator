namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using Xunit;

    public class NotSupportedStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "NotSupported")]
        [Trait("Category", "StringGeneration.NotSupported")]
        [Trait("AST", "Sdcb")]
        [InlineData("IDisposablDotNetInterfaceName.ts", "NotSupported", "IDisposablDotNetInterfaceName.Expected.txt", "IDisposable")]
        [InlineData("NotSupportedDotNetClassName.ts", "NotSupported", "NotSupportedDotNetClassName.Expected.txt", "IDisposable")]
        [InlineData("NotSupportedResponseType.ts", "NotSupported", "NotSupportedResponseType.Expected.txt", "ExampleClass")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile,
            string classIdentifier
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile,
            classIdentifier
        );
    }
}
