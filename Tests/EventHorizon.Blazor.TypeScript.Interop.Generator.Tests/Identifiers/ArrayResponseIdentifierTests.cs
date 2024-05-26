namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers;

using System.Collections.Generic;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Xunit;

public class ArrayResponseIdentifierTests
{
    [Fact]
    [Trait("Category", "EdgeCase")]
    public void ShouldReturnIsArrayOnPassedInTypeWhenIsModiferTrueWithEmptyGenericTypes()
    {
        // Given
        var typeStatement = new TypeStatement
        {
            IsModifier = true,
            IsArray = true,
            GenericTypes = new List<TypeStatement>(),
        };

        // When
        var actual = ArrayResponseIdentifier.Identify(typeStatement);

        // Then
        actual.Should().BeTrue();
    }
}
