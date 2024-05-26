namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers;

using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using FluentAssertions;
using Xunit;

public class EnumTypeIdentifierTests
{
    [Fact]
    [Trait("Category", "EnumTypeIdentifier.NotCached.StandardUsage")]
    [Trait("AST", "Sdcb")]
    public void ShouldReturnExpectedIdentificationOfEnumWhenUsingNotCachedInstanceWithSdcb()
    {
        // Given
        var expected = true;
        var enumIdentifierString = "EnumExport";

        var sourceFile = "enum.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);

        // When
        var notCachedEnumIdentifier = new EnumTypeIdentifierNotCached();
        var actual = notCachedEnumIdentifier.Identify(enumIdentifierString, ast);

        // Then
        actual.Should().Be(expected);
    }

    [Fact]
    [Trait("Category", "EnumTypeIdentifier.Cached.StandardUsage")]
    [Trait("AST", "Sdcb")]
    public void ShouldReturnExpectedIdentificationOfEnumWhenUsingCachedInstanceWithSdcb()
    {
        // Given
        var expected = true;
        var enumIdentifierString = "EnumExport";

        var sourceFile = "enum.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);

        // When
        var notCachedEnumIdentifier = new EnumTypeIdentifierCached();
        var actual = notCachedEnumIdentifier.Identify(enumIdentifierString, ast);

        // Then
        actual.Should().Be(expected);
    }

    [Fact]
    [Trait("Category", "EnumTypeIdentifier.Cached.MultipleCalls")]
    [Trait("AST", "Sdcb")]
    public void ShouldReturnExpectedIdentificationOfEnumWhenCalledMultipleTimesWithSdcb()
    {
        // Given
        var enumIdentifierString = "EnumExport";

        var sourceFile = "enum.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);

        // When
        var notCachedEnumIdentifier = new EnumTypeIdentifierCached();
        // First Identify
        notCachedEnumIdentifier
            .Identify(enumIdentifierString, ast)
            .Should() // Then
            .BeTrue();

        // Second Identify
        notCachedEnumIdentifier
            .Identify(enumIdentifierString, ast)
            .Should() // Then
            .BeTrue();
    }

    [Fact]
    [Trait("Category", "EnumTypeIdentifier.NotCached.StandardUsage")]
    [Trait("AST", "NodeJS")]
    public void ShouldReturnExpectedIdentificationOfEnumWhenUsingNotCachedInstanceWithNodeJS()
    {
        // Given
        var expected = true;
        var enumIdentifierString = "EnumExport";

        var sourceFile = "enum.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new NodeJS_ASTWrapper(source);

        // When
        var notCachedEnumIdentifier = new EnumTypeIdentifierNotCached();
        var actual = notCachedEnumIdentifier.Identify(enumIdentifierString, ast);

        // Then
        actual.Should().Be(expected);
    }

    [Fact]
    [Trait("Category", "EnumTypeIdentifier.Cached.StandardUsage")]
    [Trait("AST", "NodeJS")]
    public void ShouldReturnExpectedIdentificationOfEnumWhenUsingCachedInstanceWithNodeJS()
    {
        // Given
        var expected = true;
        var enumIdentifierString = "EnumExport";

        var sourceFile = "enum.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new NodeJS_ASTWrapper(source);

        // When
        var notCachedEnumIdentifier = new EnumTypeIdentifierCached();
        var actual = notCachedEnumIdentifier.Identify(enumIdentifierString, ast);

        // Then
        actual.Should().Be(expected);
    }

    [Fact]
    [Trait("Category", "EnumTypeIdentifier.Cached.MultipleCalls")]
    [Trait("AST", "NodeJS")]
    public void ShouldReturnExpectedIdentificationOfEnumWhenCalledMultipleTimesWithNodeJS()
    {
        // Given
        var enumIdentifierString = "EnumExport";

        var sourceFile = "enum.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new NodeJS_ASTWrapper(source);

        // When
        var notCachedEnumIdentifier = new EnumTypeIdentifierCached();
        // First Identify
        notCachedEnumIdentifier
            .Identify(enumIdentifierString, ast)
            .Should() // Then
            .BeTrue();

        // Second Identify
        notCachedEnumIdentifier
            .Identify(enumIdentifierString, ast)
            .Should() // Then
            .BeTrue();
    }
}
