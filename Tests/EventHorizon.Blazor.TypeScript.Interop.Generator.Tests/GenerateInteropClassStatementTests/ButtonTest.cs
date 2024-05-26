namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests
{
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

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Button",
                ast,
                typeOverrideMap
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
                        new AccessorStatement
                        {
                            Name = "image",
                            Type = new TypeStatement
                            {
                                Name = "Nullable",
                                IsNullable = true,
                                GenericTypes = new List<TypeStatement>
                                {
                                    new TypeStatement { Name = "Image" }
                                }
                            },
                            UsedClassNames = new List<string> { "Image", }
                        },
                        new AccessorStatement
                        {
                            Name = "textBlock",
                            Type = new TypeStatement
                            {
                                Name = "Nullable",
                                IsNullable = true,
                                GenericTypes = new List<TypeStatement>
                                {
                                    new TypeStatement { Name = "TextBlock" }
                                }
                            },
                            UsedClassNames = new List<string> { "TextBlock", }
                        }
                    }
                );
            actual
                .PublicMethodStatements.Should()
                .BeEquivalentTo(
                    new List<PublicMethodStatement>
                    {
                        new PublicMethodStatement
                        {
                            Name = "pointerEnterAnimation",
                            Type = new TypeStatement { Name = "action", IsAction = true, },
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerOutAnimation",
                            Type = new TypeStatement { Name = "action", IsAction = true, },
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerDownAnimation",
                            Type = new TypeStatement { Name = "action", IsAction = true, },
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerUpAnimation",
                            Type = new TypeStatement { Name = "action", IsAction = true, },
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageButton",
                            Type = new TypeStatement { Name = "Button" },
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Button"
                            },
                            Arguments = new List<ArgumentStatement>
                            {
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
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageOnlyButton",
                            Type = new TypeStatement { Name = "Button" },
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Button"
                            },
                            Arguments = new List<ArgumentStatement>
                            {
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
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateSimpleButton",
                            Type = new TypeStatement { Name = "Button" },
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Button"
                            },
                            Arguments = new List<ArgumentStatement>
                            {
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
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageWithCenterTextButton",
                            Type = new TypeStatement { Name = "Button" },
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Button"
                            },
                            Arguments = new List<ArgumentStatement>
                            {
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
                            },
                        },
                    }
                );
            actual
                .PublicPropertyStatements.Should()
                .BeEquivalentTo(
                    new List<PublicPropertyStatement>
                    {
                        new PublicPropertyStatement
                        {
                            Name = "name",
                            Type = new TypeStatement { Name = "string" },
                        },
                        new PublicPropertyStatement
                        {
                            Name = "delegatePickingToChildren",
                            Type = "bool".MakeTypeStatement(),
                        }
                    }
                );
        }
    }
}
