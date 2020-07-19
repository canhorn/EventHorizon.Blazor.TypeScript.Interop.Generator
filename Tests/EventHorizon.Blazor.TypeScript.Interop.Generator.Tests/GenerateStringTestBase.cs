using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using Sdcb.TypeScript;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests
{
    public class GenerateStringTestBase
    {
        public void ValidateGenerateStrings(
            string path,
            string sourceFile,
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
            var ast = new TypeScriptAST(
                source,
                sourceFile
            );
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "ExampleClass",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated
            );

            // Then
            actual.Should().Be(
                expected
            );

        }
        public void ValidateGenerateWithTypeOverrideStrings(
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
            var ast = new TypeScriptAST(
                source,
                sourceFile
            );

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "ExampleClass",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated
            );

            // Then
            actual.Should().Be(
                expected
            );

        }
    }
}
