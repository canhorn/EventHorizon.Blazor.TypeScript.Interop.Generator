namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using FluentAssertions;
    using Xunit;

    public class EnumTypeIdentifierTests
    {
        [Fact]
        [Trait("Category", "EnumTypeIdentifier.NotCached.StandardUsage")]
        [Trait("AST", "Sdcb")]
        public void ShouldReturnExpectedIdentificationOfEnumWhenUsingNotCachedInstance()
        {
            // Given
            var expected = true;
            var enumIdentifierString = "EnumExport";

            var sourceFile = "enum.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var notCachedEnumIdentifier = new EnumTypeIdentifierNotCached();
            var actual = notCachedEnumIdentifier.Identify(
                enumIdentifierString,
                ast
            );

            // Then
            actual.Should()
                .Be(expected);
        }

        [Fact]
        [Trait("Category", "EnumTypeIdentifier.Cached.StandardUsage")]
        [Trait("AST", "Sdcb")]
        public void ShouldReturnExpectedIdentificationOfEnumWhenUsingCachedInstance()
        {
            // Given
            var expected = true;
            var enumIdentifierString = "EnumExport";

            var sourceFile = "enum.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var notCachedEnumIdentifier = new EnumTypeIdentifierCached();
            var actual = notCachedEnumIdentifier.Identify(
                enumIdentifierString,
                ast
            );

            // Then
            actual.Should()
                .Be(expected);
        }

        [Fact]
        [Trait("Category", "EnumTypeIdentifier.Cached.MultipleCalls")]
        [Trait("AST", "Sdcb")]
        public void ShouldReturnExpectedIdentificationOfEnumWhenCalledMultipleTimes()
        {
            // Given
            var enumIdentifierString = "EnumExport";

            var sourceFile = "enum.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var notCachedEnumIdentifier = new EnumTypeIdentifierCached();
            // First Identify
            notCachedEnumIdentifier.Identify(
                enumIdentifierString,
                ast
            ).Should() // Then
                .BeTrue();

            // Second Identify
            notCachedEnumIdentifier.Identify(
                enumIdentifierString,
                ast
            ).Should() // Then
                .BeTrue();

        }
    }
}
