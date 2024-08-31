namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers;

using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Xunit;

public class TypeStatementTests
{
    [Fact]
    [Trait("Category", "TypeStatement")]
    public void CalculateExpectedScoreWhenAllFieldsAreSet()
    {
        // Given
        var typeStatement = new TypeStatement
        {
            Name = "name",
            IsArray = true,
            IsTypeAlias = true,
            IsTypeReference = true,
            GenericTypes = [new(), new(),],
            Arguments = [new(), new(),],
            IsNullable = true,
            IsReadonly = true,
            IsAction = true,
            IsVoid = true,
            IsTask = true,
            IsLiteral = true,
            IsModifier = true,
            IsInterface = true,
            IsEnum = true,
            IsThisType = true,
            IsTypeQuery = true,
            IsTypeOperator = true,
            IsTypeParameter = true,
        };

        var expected = 18;

        // When
        var actual = typeStatement.Score();

        // Then
        actual.Should().Be(expected, $"{actual.ToString()} should be {expected.ToString()}");
    }

    [Fact]
    [Trait("Category", "TypeStatement")]
    public void CalculateExpectedScoreWhenNoFieldsAreSet()
    {
        // Given
        var typeStatement = new TypeStatement { Name = "name", };

        var expected = 0;

        // When
        var actual = typeStatement.Score();

        // Then
        actual.Should().Be(expected, $"{actual.ToString()} should be {expected.ToString()}");
    }

    [Fact]
    [Trait("Category", "TypeStatement")]
    public void ExpectedTypeStringWhenIsNotNullable()
    {
        // Given
        var typeStatement = new TypeStatement
        {
            IsNullable = false,
            Name = "name",
            IsArray = true,
            IsTypeAlias = true,
            IsTypeReference = true,
            GenericTypes = [new() { Name = "GenericType1" }, new() { Name = "GenericType2" },],
            Arguments =
            [
                new()
                {
                    Name = "Argument1",
                    Type = new() { Name = "ArgumentType1" }
                },
                new()
                {
                    Name = "Argument2",
                    Type = new() { Name = "ArgumentType2" }
                },
            ],
            IsReadonly = true,
            IsAction = true,
            IsVoid = true,
            IsTask = true,
            IsLiteral = true,
            IsModifier = true,
            IsInterface = true,
            IsEnum = true,
            IsThisType = true,
            IsTypeQuery = true,
            IsTypeOperator = true,
            IsTypeParameter = true,
        };

        var expected =
            "(ArgumentType1 Argument1, ArgumentType2 Argument2) => (E)(T)(M)(RO)(V)name<GenericType1, GenericType2>[] = name =     = name";

        // When
        var actual = typeStatement.ToType();

        // Then
        actual.Should().Be(expected);
    }

    [Fact]
    [Trait("Category", "TypeStatement")]
    public void ExpectedTypeStringWhenIsNullable()
    {
        // Given
        var typeStatement = new TypeStatement
        {
            IsNullable = true,
            Name = "name",
            GenericTypes = [new() { Name = "GenericType1" },],
        };

        var expected = "GenericType1";

        // When
        var actual = typeStatement.ToType();

        // Then
        actual.Should().Be(expected);
    }
}
