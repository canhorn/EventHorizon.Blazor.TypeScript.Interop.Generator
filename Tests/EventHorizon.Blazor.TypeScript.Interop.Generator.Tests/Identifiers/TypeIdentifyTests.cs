namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers;

using System.Collections.Generic;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using FluentAssertions;
using Moq;
using Xunit;

public class TypeIdentifyTests
{
    [Fact]
    [Trait("Category", "EdgeCase")]
    public void ShouldReturnClassMetadataNameWhenNodeIsKindParameter()
    {
        // Given
        var nodeKind = SyntaxKind.Parameter;
        var classMetadataName = "class-metadata-name";

        var expected = classMetadataName;

        var nodeMock = new Mock<Node>();
        var classMetadata = new ClassMetadata { Name = classMetadataName, };

        nodeMock.SetupGet(mock => mock.Kind).Returns(nodeKind);

        // When
        var actual = TypeIdentifier.Identify(nodeMock.Object, classMetadata);

        // Then
        actual.Should().Be(expected);
    }
}
