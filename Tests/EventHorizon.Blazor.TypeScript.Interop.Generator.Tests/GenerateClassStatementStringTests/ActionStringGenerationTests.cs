namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using Xunit;

    public class ActionStringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Action")]
        [Trait("Category", "StringGeneration.Actions")]
        [Trait("AST", "Sdcb")]
        [InlineData("ActionCallbackWithResult.ts", "Actions", "ActionCallbackWithResult.Expected.txt")]
        [InlineData("ActionTypeCallback.ts", "Actions", "ActionTypeCallback.Expected.txt")]
        [InlineData("TypedActionCallback.ts", "Actions", "TypedActionCallback.Expected.txt")]
        [InlineData("WithGenericProperty.ts", "Actions", "WithGenericProperty.Expected.txt")]
        [InlineData("WithMultipleGenericProperty.ts", "Actions", "WithMultipleGenericProperty.Expected.txt")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStringsUsingSdcb(
            path,
            sourceFile,
            expectedFile
        );
    }
}
