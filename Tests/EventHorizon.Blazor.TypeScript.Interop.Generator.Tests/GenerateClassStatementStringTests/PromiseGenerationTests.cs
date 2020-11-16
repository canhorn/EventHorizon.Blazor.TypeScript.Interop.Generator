namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using Xunit;

    public class PromiseGenerationTests
        : GenerateStringTestBase
    {
        [Theory(DisplayName = "Promise")]
        [Trait("Category", "StandardPromises")]
        [InlineData("ArrayTaskPromise.ts", "Promise", "ArrayTaskPromise.Expected.txt")]
        [InlineData("ClassArrayTaskPromise.ts", "Promise", "ClassArrayTaskPromise.Expected.txt")]
        [InlineData("ClassTaskPromise.ts", "Promise", "ClassTaskPromise.Expected.txt")]
        [InlineData("TaskPromise.ts", "Promise", "TaskPromise.Expected.txt")]
        [InlineData("LiteralTaskPromise.ts", "Promise", "LiteralTaskPromise.Expected.txt")]
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
