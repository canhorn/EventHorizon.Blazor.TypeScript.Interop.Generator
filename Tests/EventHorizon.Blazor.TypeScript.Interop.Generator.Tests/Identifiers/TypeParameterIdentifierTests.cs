namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System.Collections.Generic;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using FluentAssertions;
    using Xunit;

    public class TypeParameterIdentifierTests
    {
        [Theory]
        [Trait("Category", "EdgeCase")]
        [InlineData(SyntaxKind.ClassDeclaration)]
        [InlineData(SyntaxKind.InterfaceDeclaration)]
        public void ShouldReturnListOfTypeParametersOnNodeWhenKindIsSyntaxKind(string kind)
        {
            // Given
            var typeParameterIdentifierStr = "identifier-str";
            var typeParemters = new List<Node>
            {
                new NodeMock { IdentifierStr = typeParameterIdentifierStr, },
            };

            var expected = new List<string> { typeParameterIdentifierStr, };

            var node = new NodeMock { Kind = kind, TypeParameters = typeParemters, };

            // When
            var actual = TypeParameterIdentifier.Identify(node);

            // Then
            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [Trait("Category", "EdgeCase")]
        [InlineData(SyntaxKind.ClassDeclaration)]
        [InlineData(SyntaxKind.InterfaceDeclaration)]
        public void ShouldReturnEmptyListWhenTypeParametersAreNull(string kind)
        {
            // Given
            var typeParemters = default(List<Node>);

            var node = new NodeMock { Kind = kind, TypeParameters = typeParemters, };

            // When
            var actual = TypeParameterIdentifier.Identify(node);

            // Then
            actual.Should().BeEmpty();
        }
    }
}
