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
                ast
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
