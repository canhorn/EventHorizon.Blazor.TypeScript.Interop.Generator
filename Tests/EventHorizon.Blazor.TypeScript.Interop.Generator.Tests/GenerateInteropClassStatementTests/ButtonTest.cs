namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests;

using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Xunit;

public class ButtonTest
{
    [Fact]
    [Trait("AST", "Sdcb")]
    public void ShoudlGenerateExpectedButton()
    {
        // Given
        var sourceFile = "babylon.gui.d.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        // When
        var actual = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "Button",
            ast,
            typeOverrideMap,
            ignoredIdentifiers
        );

        // Then
        actual.Name.Should().Be("Button");
        actual.Namespace.Should().Be("BABYLON.GUI");
        actual.ExtendedType.Should().BeEquivalentTo(new TypeStatement { Name = "Rectangle" });
        actual
            .ConstructorStatement.Should()
            .BeEquivalentTo(
                new ConstructorStatement
                {
                    NeedsInvokableReference = false,
                    Arguments = new List<ArgumentStatement>
                    {
                        new ArgumentStatement
                        {
                            Name = "name",
                            Type = new TypeStatement { Name = "string" },
                            IsOptional = true,
                        }
                    }
                }
            );
        actual
            .AccessorStatements.Should()
            .BeEquivalentTo(
                new List<AccessorStatement>
                {
                    new()
                    {
                        Name = "image",
                        Type = new()
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            IsTypeReference = true,
                            GenericTypes = [new() { Name = "Image", IsTypeReference = true, }]
                        },
                        UsedClassNames = ["Image",]
                    },
                    new()
                    {
                        Name = "textBlock",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            IsTypeReference = true,
                            GenericTypes = [new() { Name = "TextBlock", IsTypeReference = true, }]
                        },
                        UsedClassNames = ["TextBlock",]
                    }
                }
            );
        actual
            .PublicMethodStatements.Should()
            .BeEquivalentTo(
                new List<PublicMethodStatement>
                {
                    new()
                    {
                        Name = "pointerEnterAnimation",
                        Type = new TypeStatement { Name = "action", IsAction = true, },
                    },
                    new()
                    {
                        Name = "pointerOutAnimation",
                        Type = new TypeStatement { Name = "action", IsAction = true, },
                    },
                    new()
                    {
                        Name = "pointerDownAnimation",
                        Type = new TypeStatement { Name = "action", IsAction = true, },
                    },
                    new()
                    {
                        Name = "pointerUpAnimation",
                        Type = new TypeStatement { Name = "action", IsAction = true, },
                    },
                    new()
                    {
                        Name = "CreateImageButton",
                        Type = new TypeStatement { Name = "Button" },
                        IsStatic = true,
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Button"
                        ],
                        Arguments =
                        [
                            new ArgumentStatement
                            {
                                Name = "name",
                                Type = new TypeStatement { Name = "string" },
                            },
                            new ArgumentStatement
                            {
                                Name = "text",
                                Type = new TypeStatement { Name = "string" },
                            },
                            new ArgumentStatement
                            {
                                Name = "imageUrl",
                                Type = new TypeStatement { Name = "string" },
                            },
                        ],
                    },
                    new()
                    {
                        Name = "CreateImageOnlyButton",
                        Type = new TypeStatement { Name = "Button" },
                        IsStatic = true,
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Button"
                        ],
                        Arguments =
                        [
                            new ArgumentStatement
                            {
                                Name = "name",
                                Type = new TypeStatement { Name = "string" },
                            },
                            new ArgumentStatement
                            {
                                Name = "imageUrl",
                                Type = new TypeStatement { Name = "string" },
                            },
                        ],
                    },
                    new()
                    {
                        Name = "CreateSimpleButton",
                        Type = new TypeStatement { Name = "Button" },
                        IsStatic = true,
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Button"
                        ],
                        Arguments =
                        [
                            new ArgumentStatement
                            {
                                Name = "name",
                                Type = new TypeStatement { Name = "string" },
                            },
                            new ArgumentStatement
                            {
                                Name = "text",
                                Type = new TypeStatement { Name = "string" },
                            },
                        ]
                    },
                    new()
                    {
                        Name = "CreateImageWithCenterTextButton",
                        Type = new TypeStatement { Name = "Button" },
                        IsStatic = true,
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Button"
                        ],
                        Arguments =
                        [
                            new ArgumentStatement
                            {
                                Name = "name",
                                Type = new TypeStatement { Name = "string" },
                            },
                            new ArgumentStatement
                            {
                                Name = "text",
                                Type = new TypeStatement { Name = "string" },
                            },
                            new ArgumentStatement
                            {
                                Name = "imageUrl",
                                Type = new TypeStatement { Name = "string" },
                            },
                        ],
                    },
                }
            );
        actual
            .PublicPropertyStatements.Should()
            .BeEquivalentTo(
                new List<PublicPropertyStatement>
                {
                    new()
                    {
                        Name = "name",
                        Type = new TypeStatement { Name = "string" },
                    },
                    new() { Name = "delegatePickingToChildren", Type = "bool".MakeTypeStatement(), }
                }
            );
    }
}
