namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
    using FluentAssertions;

    public class GenerateStringTestBase
    {
        public void ValidateGenerateStringsUsingSdcb(
            string path,
            string sourceFile,
            string expectedFile,
            string classIdentifier = "ExampleClass"
        )
        {
            // Given
            GenerateSource.DisableCache();
            var sourcePath = Path.Combine(
                ".",
                "GenerateClassStatementStringTests",
                path
            );
            string expected = File.ReadAllText(Path.Combine(
                sourcePath,
                expectedFile
            ));
            var source = File.ReadAllText(Path.Combine(
                sourcePath,
                sourceFile
            ));
            var ast = new Sdcb_TypeScriptASTWrapper(
                source
            );
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                classIdentifier,
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated,
                new NoFormattingTextFormatter()
            );

            // Then
            actual.Should().Be(
                expected
            );
        }

        public void ValidateGenerateWithTypeOverrideStringsUsingSdcb(
            string path,
            string sourceFile,
            IDictionary<string, string> typeOverrideMap,
            string expectedFile
        )
        {
            // Given
            GenerateSource.DisableCache();
            var sourcePath = Path.Combine(
                ".",
                "GenerateClassStatementStringTests",
                path
            );
            string expected = File.ReadAllText(Path.Combine(
                sourcePath,
                expectedFile
            ));
            var source = File.ReadAllText(Path.Combine(
                sourcePath,
                sourceFile
            ));
            var ast = new Sdcb_TypeScriptASTWrapper(
                source
            );

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "ExampleClass",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated,
                new NoFormattingTextFormatter()
            );

            // Then
            actual.Should().Be(
                expected
            );

        }
    }
}
