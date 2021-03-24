namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.Identifiers
{
    using System;
    using System.Collections.Generic;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
    using FluentAssertions;
    using Xunit;

    public class TypeParameterIdentifierTests
    {
        [Theory]
        [InlineData(SyntaxKind.ClassDeclaration)]
        [InlineData(SyntaxKind.InterfaceDeclaration)]
        public void ShouldReturnListOfTypeParametersOnNodeWhenKindIsClassDeclaration(
            string kind
        )
        {
            // Given
            var typeParameterIdentifierStr = "identifier-str";
            var typeParemters = new List<Node>
            {
                new NodeMock
                {
                    IdentifierStr = typeParameterIdentifierStr,
                },
            };

            var expected = new List<string>
            {
                typeParameterIdentifierStr,
            };

            var node = new NodeMock
            {
                Kind = kind,
                TypeParameters = typeParemters,
            };

            // When
            var actual = TypeParameterIdentifier.Identify(
                node
            );

            // Then
            actual.Should()
                .BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(SyntaxKind.ClassDeclaration)]
        [InlineData(SyntaxKind.InterfaceDeclaration)]
        public void ShouldReturnEmptyListWhenClassDeclarationTypeParametersAreNull(
            string kind
        )
        {
            // Given
            var typeParemters = default(List<Node>);

            var node = new NodeMock
            {
                Kind = kind,
                TypeParameters = typeParemters,
            };

            // When
            var actual = TypeParameterIdentifier.Identify(
                node
            );

            // Then
            actual.Should().BeEmpty();
        }

        public class NodeMock
            : Node
        {
            public Node Parent { get; }
            public Node First { get; }
            public Node Last { get; }
            public string IdentifierStr { get; set; }
            public string Kind { get; set; }
            public IEnumerable<Node> Modifiers { get; }
            public Node Type { get; }
            public Node ElementType { get; }
            public IEnumerable<Node> TypeParameters { get; set; }
            public IEnumerable<Node> HeritageClauses { get; }
            public IEnumerable<Node> Types { get; }
            public IEnumerable<Node> TypeArguments { get; }
            public IEnumerable<Node> Parameters { get; }
            public IEnumerable<Node> Children { get; }

            public IEnumerable<Node> OfKind(string kind)
            {
                throw new NotImplementedException();
            }
        }
    }
}
