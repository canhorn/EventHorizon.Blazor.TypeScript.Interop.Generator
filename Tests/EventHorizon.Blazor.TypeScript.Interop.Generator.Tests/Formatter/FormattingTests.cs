namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
using FluentAssertions;
using Xunit;

public class FormattingTests
{
    [Fact]
    [Trait("Category", "FormattingTests.CShapeTextFormatter")]
    [Trait("AST", "Sdcb")]
    public void ShouldGenerateFormattedString()
    {
        // Given
        var sourceFile = "CSharpTextFormatter.d.ts";
        var source = File.ReadAllText($"./Formatter/SourceFiles/{sourceFile}");
        var expected = File.ReadAllText(
            $"./Formatter/ExpectedResults/CSharpTextFormatter.Expected.txt"
        );
        var ast = new Sdcb_TypeScriptASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();

        // When
        var generated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "CSharpTextClass",
            ast,
            typeOverrideMap
        );
        var actual = GenerateClassStatementString.Generate(generated, new CSharpTextFormatter());

        // Then
        actual.Should().Be(expected);
    }
}
