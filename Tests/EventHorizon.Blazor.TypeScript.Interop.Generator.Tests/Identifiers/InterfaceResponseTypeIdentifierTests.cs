namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using FluentAssertions;
    using Moq;
    using Xunit;

    public class InterfaceResponseTypeIdentifierTests
    {
        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.NotCached.StandardUsage")]
        [Trait("AST", "Sdcb")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenUsingNotCachedInstanceWithSdcb()
        {
            // Given
            var expected = true;
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var notCachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierNotCached();
            var actual = notCachedInterfaceIdentifier.Identify(interfaceIdentifierString, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.StandardUsage")]
        [Trait("AST", "Sdcb")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenUsingCachedInstanceWithSdcb()
        {
            // Given
            var expected = true;
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            var actual = cachedInterfaceIdentifier.Identify(interfaceIdentifierString, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.MultipleCalls")]
        [Trait("AST", "Sdcb")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenCalledMultipleTimesWithSdcb()
        {
            // Given
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            // First Identify
            cachedInterfaceIdentifier
                .Identify(interfaceIdentifierString, ast)
                .Should() // Then
                .BeTrue();

            // Second Identify
            cachedInterfaceIdentifier
                .Identify(interfaceIdentifierString, ast)
                .Should() // Then
                .BeTrue();
        }

        [Theory]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.TypeStatementIdentification")]
        [Trait("AST", "Sdcb")]
        [InlineData("Random", "ExampleInterface", true, false, false, true)]
        [InlineData("Random", "ExampleInterface", false, true, false, true)]
        [InlineData("Random", "ExampleInterface", false, false, true, true)]
        [InlineData("Random", "ExampleInterface", false, false, false, false)]
        [InlineData("ExampleInterface", "Other", false, false, false, true)]
        public void ShouldReturnExpectedIdentificationWhenTypeStatementIsUsedWithSdcb(
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
                GenericTypes = new List<TypeStatement> { new TypeStatement { Name = genericName } }
            };

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            var actual = cachedInterfaceIdentifier.Identify(type, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Theory]
        [Trait("Category", "InterfaceResponseTypeIdentifier.NotCached.TypeStatementIdentification")]
        [Trait("AST", "Sdcb")]
        [InlineData("Random", "ExampleInterface", true, false, false, true)]
        [InlineData("Random", "ExampleInterface", false, true, false, true)]
        [InlineData("Random", "ExampleInterface", false, false, true, true)]
        [InlineData("Random", "ExampleInterface", false, false, false, false)]
        [InlineData("ExampleInterface", "Other", false, false, false, true)]
        public void ShouldReturnExpectedIdentificationWhenTypeStatementIsUsedAndNotCachedWithSdcb(
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
                GenericTypes = new List<TypeStatement> { new TypeStatement { Name = genericName } }
            };

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new Sdcb_TypeScriptASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierNotCached();
            var actual = cachedInterfaceIdentifier.Identify(type, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.NotCached.StandardUsage")]
        [Trait("AST", "NodeJS")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenUsingNotCachedInstanceWithNodeJS()
        {
            // Given
            var expected = true;
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new NodeJS_ASTWrapper(source);

            // When
            var notCachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierNotCached();
            var actual = notCachedInterfaceIdentifier.Identify(interfaceIdentifierString, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.StandardUsage")]
        [Trait("AST", "NodeJS")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenUsingCachedInstanceWithNodeJS()
        {
            // Given
            var expected = true;
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new NodeJS_ASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            var actual = cachedInterfaceIdentifier.Identify(interfaceIdentifierString, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Fact]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.MultipleCalls")]
        [Trait("AST", "NodeJS")]
        public void ShouldReturnExpectedIdentificationOfInterfaceWhenCalledMultipleTimesWithNodeJS()
        {
            // Given
            var interfaceIdentifierString = "ExampleInterface";

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new NodeJS_ASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            // First Identify
            cachedInterfaceIdentifier
                .Identify(interfaceIdentifierString, ast)
                .Should() // Then
                .BeTrue();

            // Second Identify
            cachedInterfaceIdentifier
                .Identify(interfaceIdentifierString, ast)
                .Should() // Then
                .BeTrue();
        }

        [Theory]
        [Trait("Category", "InterfaceResponseTypeIdentifier.Cached.TypeStatementIdentification")]
        [Trait("AST", "NodeJS")]
        [InlineData("Random", "ExampleInterface", true, false, false, true)]
        [InlineData("Random", "ExampleInterface", false, true, false, true)]
        [InlineData("Random", "ExampleInterface", false, false, true, true)]
        [InlineData("Random", "ExampleInterface", false, false, false, false)]
        [InlineData("ExampleInterface", "Other", false, false, false, true)]
        public void ShouldReturnExpectedIdentificationWhenTypeStatementIsUsedWithNodeJS(
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
                GenericTypes = new List<TypeStatement> { new TypeStatement { Name = genericName } }
            };

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new NodeJS_ASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierCached();
            var actual = cachedInterfaceIdentifier.Identify(type, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Theory]
        [Trait("Category", "InterfaceResponseTypeIdentifier.NotCached.TypeStatementIdentification")]
        [Trait("AST", "NodeJS")]
        [InlineData("Random", "ExampleInterface", true, false, false, true)]
        [InlineData("Random", "ExampleInterface", false, true, false, true)]
        [InlineData("Random", "ExampleInterface", false, false, true, true)]
        [InlineData("Random", "ExampleInterface", false, false, false, false)]
        [InlineData("ExampleInterface", "Other", false, false, false, true)]
        public void ShouldReturnExpectedIdentificationWhenTypeStatementIsUsedAndNotCachedWithNodeJS(
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
                GenericTypes = new List<TypeStatement> { new TypeStatement { Name = genericName } }
            };

            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new NodeJS_ASTWrapper(source);

            // When
            var cachedInterfaceIdentifier = new InterfaceResponseTypeIdentifierNotCached();
            var actual = cachedInterfaceIdentifier.Identify(type, ast);

            // Then
            actual.Should().Be(expected);
        }

        [Theory]
        [Trait("Category", "EdgeCase")]
        [InlineData(SyntaxKind.ClassDeclaration, false)]
        [InlineData(SyntaxKind.InterfaceDeclaration, true)]
        public void ShouldValidateAgainstCacheWhenDeclarationTypeIsUsed(
            string declarationType,
            bool found
        )
        {
            // Given
            var expected = 1;
            var identifierString = "identifier-string";
            var mockNode = new NodeMock { IdentifierStr = identifierString, };

            var astMock = new Mock<AbstractSyntaxTree>();
            var rootNodeMock = new Mock<Node>();

            astMock.Setup(mock => mock.RootNode).Returns(rootNodeMock.Object);

            rootNodeMock
                .Setup(mock => mock.OfKind(declarationType))
                .Returns(new List<Node> { mockNode });

            // When
            var alias = new InterfaceResponseTypeIdentifierCached();
            var actual = alias.Identify(identifierString, astMock.Object);
            actual.Should().Be(found);

            actual = alias.Identify(identifierString, astMock.Object);

            // Then
            actual.Should().Be(found);

            rootNodeMock.Verify(mock => mock.OfKind(declarationType), Times.Exactly(expected));
        }
    }
}
