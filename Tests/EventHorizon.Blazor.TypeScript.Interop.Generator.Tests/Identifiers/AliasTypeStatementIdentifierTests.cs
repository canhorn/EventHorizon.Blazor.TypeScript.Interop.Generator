namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using FluentAssertions;
    using Moq;
    using Xunit;

    public class AliasTypeStatementIdentifierTests
    {
        [Fact]
        [Trait("Category", "EdgeCase")]
        public void ShouldReturnNullWhenNodeIsNotFound()
        {
            // Given
            var rootNode = new Mock<Node>();

            var typeIdentifier = "type-identifier";

            var classMetadataMock = new Mock<ClassMetadata>();
            var astMock = new Mock<AbstractSyntaxTree>();
            var typeOverrideDetails = new TypeOverrideDetails();

            astMock.Setup(mock => mock.RootNode).Returns(rootNode.Object);

            // When
            var actual = AliasTypeStatementIdentifier.Identify(
                typeIdentifier,
                classMetadataMock.Object,
                astMock.Object,
                typeOverrideDetails
            );

            // Then
            actual.Should().BeNull();
        }
    }
}
