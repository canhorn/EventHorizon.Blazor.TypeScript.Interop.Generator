namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using FluentAssertions;
    using Moq;
    using Xunit;

    public class AliasTypeIdentifierCachedTests
    {
        [Fact]
        [Trait("Category", "Caching")]
        public async Task ShoudlOnlyReadFromASTOnceWhenCallingIdentifyAsSecondTime()
        {
            // Given
            var expected = 1;
            var identifierString = "identifier-string";
            var mockNode = new NodeMock
            {
                IdentifierStr = identifierString,
            };

            var astMock = new Mock<AbstractSyntaxTree>();
            var rootNodeMock = new Mock<Node>();

            astMock.Setup(
                mock => mock.RootNode
            ).Returns(
                rootNodeMock.Object
            );

            rootNodeMock.Setup(
                mock => mock.OfKind(
                    SyntaxKind.TypeAliasDeclaration
                )
            ).Returns(
                new List<Node>
                {
                    mockNode
                }
            );

            // When
            var alias = new AliasTypeIdentifierCached();
            var actual = alias.Identify(
                identifierString,
                astMock.Object
            );
            actual.Should().BeTrue();

            actual = alias.Identify(
                identifierString,
                astMock.Object
            );

            // Then
            actual.Should().BeTrue();

            rootNodeMock.Verify(
                mock => mock.OfKind(
                    SyntaxKind.TypeAliasDeclaration
                ),
                Times.Exactly(expected)
            );
        }
    }
}
