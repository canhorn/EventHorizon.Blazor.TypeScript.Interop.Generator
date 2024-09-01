namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Rules;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using FluentAssertions;
using Xunit;

public class IsStaticTests
{
    [Fact]
    [Trait("Category", "IsStatic")]
    public void IsStaticNode()
    {
        // Given

        // When
        var actual = new IsStatic.IsStaticNode();

        // Then
        actual.Kind.Should().Be(SyntaxKind.StaticKeyword);
        actual.Parent.Should().BeNull();
        actual.First.Should().BeNull();
        actual.Last.Should().BeNull();
        actual.IdentifierStr.Should().BeNull();
        actual.Modifiers.Should().BeNullOrEmpty();
        actual.Type.Should().BeNull();
        actual.ElementType.Should().BeNull();
        actual.TypeParameters.Should().BeNullOrEmpty();
        actual.HeritageClauses.Should().BeNullOrEmpty();
        actual.Types.Should().BeNullOrEmpty();
        actual.TypeArguments.Should().BeNullOrEmpty();
        actual.Parameters.Should().BeNullOrEmpty();
        actual.Children.Should().BeNullOrEmpty();
        actual.OfKind("kind").Should().BeEmpty();
    }
}
