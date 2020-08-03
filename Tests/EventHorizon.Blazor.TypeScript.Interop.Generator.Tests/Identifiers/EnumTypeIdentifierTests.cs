namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;
    using FluentAssertions;
    using Sdcb.TypeScript;
    using Xunit;

    public class EnumTypeIdentifierTests
    {
        [Fact]
        [Trait("Category", "EnumTypeIdentifier.NotCached.StandardUsage")]
        public void ShouldReturnExpectedIdentificationOfEnumWhenUsingNotCachedInstance()
        {
            // Given
            var expected = true;
            var enumIdentifierString = "EnumExport";

            var sourceFile = "enum.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

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
        public void ShouldReturnExpectedIdentificationOfEnumWhenUsingCachedInstance()
        {
            // Given
            var expected = true;
            var enumIdentifierString = "EnumExport";

            var sourceFile = "enum.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

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
        public void ShouldReturnExpectedIdentificationOfEnumWhenCalledMultipleTimes()
        {
            // Given
            var enumIdentifierString = "EnumExport";

            var sourceFile = "enum.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

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
