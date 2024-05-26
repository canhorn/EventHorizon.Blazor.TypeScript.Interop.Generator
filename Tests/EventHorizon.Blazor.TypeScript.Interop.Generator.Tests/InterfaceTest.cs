namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    using System.Collections.Generic;
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
    using FluentAssertions;
    using Xunit;

    public class InterfaceTests
    {
        [Fact]
        [Trait("AST", "Sdcb")]
        [Trait("Category", "Interface")]
        public void ShouldGenerateInterfaceStringWhenUsingSdcb()
        {
            // Given
            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var expected = File.ReadAllText($"./ExpectedResults/interface.Expected.txt");
            var ast = new Sdcb_TypeScriptASTWrapper(source);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "ExampleInterface",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated,
                new NoFormattingTextFormatter()
            );

            // Then
            actual.Should().Be(expected);
        }

        [Fact]
        [Trait("AST", "NodeJS")]
        [Trait("Category", "Interface")]
        public void ShouldGenerateInterfaceStringWhenUsingNodeJS()
        {
            // Given
            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var expected = File.ReadAllText($"./ExpectedResults/interface.Expected.txt");
            var ast = new NodeJS_ASTWrapper(source);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "ExampleInterface",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated,
                new NoFormattingTextFormatter()
            );

            // Then
            actual.Should().Be(expected);
        }
    }
}
