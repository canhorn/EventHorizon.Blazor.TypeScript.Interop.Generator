using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Sdcb.TypeScript;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests
{
    public class ButtonTest
    {
        [Fact]
        public void ShoudlGenerateExpectedButton()
        {
            // Given
            var sourceFile = "babylon.gui.d.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Button",
                ast,
                typeOverrideMap
            );

            // Then
            actual.Name
                .Should().Be("Button");
            actual.Namespace
                .Should().Be("BABYLON.GUI");
            actual.ExtendedClassNames
                .Should().BeEquivalentTo(
                    new List<string> { "Rectangle" }
                );
            actual.ConstructorStatement
                .Should().BeEquivalentTo(new ConstructorStatement
                {
                    NeedsInvokableReference = false,
                    Arguments = new List<ArgumentStatement>
                    {
                        new ArgumentStatement
                        {
                            Name = "name",
                            Type = "string",
                            IsOptional = true,
                        }
                    }
                });
            actual.AccessorStatements
                .Should().BeEquivalentTo(
                    new AccessorStatement
                    {
                        Name = "image",
                        Type = "Image",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Image",
                        }
                    },
                    new AccessorStatement
                    {
                        Name = "textBlock",
                        Type = "TextBlock",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "TextBlock",
                        }
                    }
                );
            actual.PublicMethodStatements
                .Should().BeEquivalentTo(
                    new List<PublicMethodStatement>
                    {
                        new PublicMethodStatement
                        {
                            Name = "pointerEnterAnimation",
                            Type = "action",
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerOutAnimation",
                            Type = "action",
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerDownAnimation",
                            Type = "action",
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerUpAnimation",
                            Type = "action",
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageButton",
                            Type = "Button",
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
                                    Type = "string",
                                },
                                new ArgumentStatement
                                {
                                    Name = "text",
                                    Type = "string",
                                },
                                new ArgumentStatement
                                {
                                    Name = "imageUrl",
                                    Type = "string",
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageOnlyButton",
                            Type = "Button",
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
                                    Type = "string",
                                },
                                new ArgumentStatement
                                {
                                    Name = "imageUrl",
                                    Type = "string",
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateSimpleButton",
                            Type = "Button",
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
                                    Type = "string",
                                },
                                new ArgumentStatement
                                {
                                    Name = "text",
                                    Type = "string",
                                },
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageWithCenterTextButton",
                            Type = "Button",
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
                                    Type = "string",
                                },
                                new ArgumentStatement
                                {
                                    Name = "text",
                                    Type = "string",
                                },
                                new ArgumentStatement
                                {
                                    Name = "imageUrl",
                                    Type = "string",
                                },
                            },
                        },
                    }
                );
            actual.PublicPropertyStatements
                .Should().BeEquivalentTo(
                    new PublicPropertyStatement
                    {
                        Name = "name",
                        Type = "string",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "delegatePickingToChildren",
                        Type = "bool",
                    }
                );
        }
    }
}
