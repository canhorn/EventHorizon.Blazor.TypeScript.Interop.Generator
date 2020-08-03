namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System.Collections.Generic;
    using System.IO;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using FluentAssertions;
    using Sdcb.TypeScript;
    using Xunit;

    public class InterfaceResponseTypeIdentifierTests
    {
        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.NotCached.StandardUsage")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenUsingNotCachedInstance()
        {
            // Given
            var expected = true;
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var notCachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierNotCached();
            var actual = notCachedInterfaceIdentifier.Identify(
                interfaceIdentifierString,
                ast
            );

            // Then
            actual.Should()
                .Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.StandardUsage")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenUsingCachedInstance()
        {
            // Given
            var expected = true;
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            var actual = cachedInterfaceIdentifier.Identify(
                interfaceIdentifierString,
                ast
            );

            // Then
            actual.Should()
                .Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.MultipleCalls")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenCalledMultipleTimes()
        {
            // Given
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            // First Identify
            cachedInterfaceIdentifier.Identify(
                interfaceIdentifierString,
                ast
            ).Should() // Then
                .BeTrue();

            // Second Identify
            cachedInterfaceIdentifier.Identify(
                interfaceIdentifierString,
                ast
            ).Should() // Then
                .BeTrue();
        }

        [Theory]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.TypeStatementIdentification")]
        [InlineData("Random", "ExampleInterface", true, false, false, true)]
        [InlineData("Random", "ExampleInterface", false, true, false, true)]
        [InlineData("Random", "ExampleInterface", false, false, true, true)]
        [InlineData("Random", "ExampleInterface", false, false, false, false)]
        [InlineData("ExampleInterface", "Other", false, false, false, true)]
        public void ShouldReturnExpectedIdentificationWhenTypeStatementIsUsed(
            string typeName,
            string genericName,
            bool isModifier,
            bool isArray,
            bool isNullable,
            bool expected
        )
        {
            // Given
            var type = new TypeStatement
            {
                Name = typeName,
                IsModifier = isModifier,
                IsArray = isArray,
                IsNullable = isNullable,
                GenericTypes = new List<TypeStatement>
                {
                    new TypeStatement
                    {
                        Name = genericName
                    }
                }
            };

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            var actual = cachedInterfaceIdentifier.Identify(
                type,
                ast
            );

            // Then
            actual.Should()
                .Be(expected);
        }

        [Theory]
        [Trait("Category", "InterfaceResponseTypeIdentifier.NotCached.TypeStatementIdentification")]
        [InlineData("Random", "ExampleInterface", true, false, false, true)]
        [InlineData("Random", "ExampleInterface", false, true, false, true)]
        [InlineData("Random", "ExampleInterface", false, false, true, true)]
        [InlineData("Random", "ExampleInterface", false, false, false, false)]
        [InlineData("ExampleInterface", "Other", false, false, false, true)]
        public void ShouldReturnExpectedIdentificationWhenTypeStatementIsUsedAndNotCached(
            string typeName,
            string genericName,
            bool isModifier,
            bool isArray,
            bool isNullable,
            bool expected
        )
        {
            // Given
            var type = new TypeStatement
            {
                Name = typeName,
                IsModifier = isModifier,
                IsArray = isArray,
                IsNullable = isNullable,
                GenericTypes = new List<TypeStatement>
                {
                    new TypeStatement
                    {
                        Name = genericName
                    }
                }
            };

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierNotCached();
            var actual = cachedInterfaceIdentifier.Identify(
                type,
                ast
            );

            // Then
            actual.Should()
                .Be(expected);
        }
    }
}
