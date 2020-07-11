using System;
using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Sdcb.TypeScript;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests
{
    public class StractTesting
    {
        [Fact(Skip = "only for testing")]
        public void ShouldTesting()
        {
            // Given
            //var sourceFile = "babylon.d.ts";
            var sourceFile = "testing.d.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var generatedButton = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Engine",
                ast
            );
            var actual = GenerateClassStatementString.Generate(
                generatedButton
            );

            // Then
            Assert.False(true);

        }

        [Fact(Skip = "only for testing")]
        public void ShoudlGenerateExpectedButton()
        {
            // Given
            var sourceFile = "babylon.gui.d.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Button",
                ast
            );

            // Then
            actual.AccessorStatements
                .Should().BeEquivalentTo(
                    new AccessorStatement
                    {
                        Name = "image",
                        Type = "Image",
                        UsedClassNames = new List<string>
                        {
                            "Image",
                        }
                    },
                    new AccessorStatement
                    {
                        Name = "textBlock",
                        Type = "TextBlock",
                        UsedClassNames = new List<string>
                        {
                            "TextBlock",
                        }
                    }
                );
            actual.ExtendedClassNames
                .Should().BeEquivalentTo(
                    new List<string> { "Rectangle" }
                );
            actual.ExtendedClassNames
                .Should().BeEquivalentTo(
                    new List<string> {
                        "Rectangle"
                    }
                );
            actual.PublicMethodStatements
                .Should().BeEquivalentTo(
                    new List<PublicMethodStatement>
                    {
                        new PublicMethodStatement
                        {
                            Name = "pointerEnterAnimation",
                            Type = "method",
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerOutAnimation",
                            Type = "method",
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerDownAnimation",
                            Type = "method",
                        },
                        new PublicMethodStatement
                        {
                            Name = "pointerUpAnimation",
                            Type = "method",
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageButton",
                            Type = "Button",
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                "Button"
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageOnlyButton",
                            Type = "Button",
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                "Button"
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateSimpleButton",
                            Type = "Button",
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                "Button"
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "CreateImageWithCenterTextButton",
                            Type = "Button",
                            IsStatic = true,
                            UsedClassNames = new List<string>
                            {
                                "Button"
                            }
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

        [Fact(Skip = "only for testing")]
        public void ShouldGenerateExpectedControl()
        {
            // Given
            var sourceFile = "babylon.gui.d.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Control",
                ast
            );

            // Then
            Console.WriteLine("stop");
            actual.AccessorStatements
                .Should().BeEquivalentTo(
                    new AccessorStatement
                    {
                        Name = "shadowOffsetX",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "shadowOffsetY",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "shadowBlur",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "shadowColor",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "typeName",
                        Type = "string",
                    },
                    new AccessorStatement
                    {
                        Name = "host",
                        Type = "AdvancedDynamicTexture",
                        UsedClassNames = new List<string>
                        {
                            "AdvancedDynamicTexture",
                        },
                    },
                    new AccessorStatement
                    {
                        Name = "fontOffset",
                        Type = "object",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "alpha",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "isHighlighted",
                        Type = "bool",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "scaleX",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "scaleY",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "rotation",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "transformCenterY",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "transformCenterX",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "horizontalAlignment",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "verticalAlignment",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "width",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "widthInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "height",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "heightInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontFamily",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontStyle",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontWeight",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "style",
                        Type = "Style",
                        HasSetter = true,
                        UsedClassNames = new List<string>
                        {
                            "Style",
                        },
                    },
                    new AccessorStatement
                    {
                        Name = "fontSizeInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontSize",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "color",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "zIndex",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "notRenderable",
                        Type = "bool",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "isVisible",
                        Type = "bool",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "isDirty",
                        Type = "bool",
                    },
                    new AccessorStatement
                    {
                        Name = "linkedMesh",
                        Type = "AbstractMesh",
                        UsedClassNames = new List<string>
                        {
                            "AbstractMesh"
                        },
                    },
                    new AccessorStatement
                    {
                        Name = "paddingLeftInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingLeft",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingRight",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingRightInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingTop",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingTopInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingBottom",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingBottomInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "left",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "leftInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "top",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "topInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetX",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetXInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetY",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetYInPixels",
                        Type = "decimal",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "centerX",
                        Type = "decimal",
                    },
                    new AccessorStatement
                    {
                        Name = "centerY",
                        Type = "decimal",
                    },
                    new AccessorStatement
                    {
                        Name = "isEnabled",
                        Type = "bool",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "disabledColor",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "disabledColorItem",
                        Type = "string",
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "HORIZONTAL_ALIGNMENT_LEFT",
                        Type = "decimal",
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "HORIZONTAL_ALIGNMENT_RIGHT",
                        Type = "decimal",
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "HORIZONTAL_ALIGNMENT_CENTER",
                        Type = "decimal",
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "VERTICAL_ALIGNMENT_TOP",
                        Type = "decimal",
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "VERTICAL_ALIGNMENT_BOTTOM",
                        Type = "decimal",
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "VERTICAL_ALIGNMENT_CENTER",
                        Type = "decimal",
                        IsStatic = true,
                    }
                );
            actual.ExtendedClassNames
                .Should().BeEmpty();
            actual.PublicMethodStatements
                .Should().BeEquivalentTo(
                    new List<PublicMethodStatement>
                    {
                        new PublicMethodStatement
                        {
                            Name = "getClassName",
                            Type = "string",
                        },
                        new PublicMethodStatement
                        {
                            Name = "getAscendantOfClass",
                            Type = "Control",
                            UsedClassNames = new List<string>
                            {
                                "Control",
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "isAscendant",
                            Type = "bool",
                        },
                        new PublicMethodStatement
                        {
                            Name = "getLocalCoordinates",
                            Type = "Vector2",
                            UsedClassNames = new List<string>
                            {
                                "Vector2",
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "getLocalCoordinatesToRef",
                            Type = "Control",
                            UsedClassNames = new List<string>
                            {
                                "Control"
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "getParentLocalCoordinates",
                            Type = "Vector2",
                            UsedClassNames = new List<string>
                            {
                                "Vector2"
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "moveToVector3",
                            Type = "void",
                        },
                        new PublicMethodStatement
                        {
                            Name = "getDescendantsToRef",
                            Type = "void",
                        },
                        new PublicMethodStatement
                        {
                            Name = "getDescendants",
                            Type = "Control",
                            IsArrayResponse = true,
                            UsedClassNames = new List<string>
                            {
                                "Control"
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "linkWithMesh",
                            Type = "void",
                        },
                        new PublicMethodStatement
                        {
                            Name = "contains",
                            Type = "bool",
                        },
                        new PublicMethodStatement
                        {
                            Name = "dispose",
                            Type = "void",
                        },
                        new PublicMethodStatement
                        {
                            Name = "AddHeader",
                            Type = "method",
                            IsStatic = true,
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
                        Name = "AllowAlphaInheritance",
                        Type = "bool",
                        IsStatic = true,
                    },
                    new PublicPropertyStatement
                    {
                        Name = "parent",
                        Type = "Container",
                        UsedClassNames = new List<string>
                        {
                            "Container",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "uniqueId",
                        Type = "decimal",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "metadata",
                        Type = "object",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "isHitTestVisible",
                        Type = "bool",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "isPointerBlocker",
                        Type = "bool",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "isFocusInvisible",
                        Type = "bool",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "clipChildren",
                        Type = "bool",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "clipContent",
                        Type = "bool",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "useBitmapCache",
                        Type = "bool",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "hoverCursor",
                        Type = "string",
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onWheelObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerMoveObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerOutObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerDownObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerUpObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerClickObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerEnterObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onDirtyObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onBeforeDrawObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onAfterDrawObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            "Observable",
                        },
                    }
                );
        }

        string expected = @"/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using EventHorizon.Blazor.Interop;

    public class Button : ICachedEntity
    {
        public decimal Width
        {
            get
            {
                return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    ""width""
                );
            }
            set
            {
                EventHorizonBlazorInteropt.Set(
                    this,
                    ""width"",
                    value
                );
            }
        }
        public string Height
        {
            get
            {
                return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    ""height""
                );
            }
            set
            {
                EventHorizonBlazorInteropt.Set(
                    this,
                    ""height"",
                    value
                );
            }
        }

        private Observable _onPointerClickObservable;
        public Observable OnPointerClickObservable
        {
            get
            {
                if (_onPointerClickObservable == null)
                {
                    _onPointerClickObservable = Observable.Create(
                        ___guid,
                        ""onPointerClickObservable""
                    );
                }
                return _onPointerClickObservable;
            }
        }

        public static Button CreateSimpleButton(
            string name,
            string text
        ) => new Button(
            EventHorizonBlazorInteropt.Func(
                new string[] { ""BABYLON"", ""GUI"", ""Button"", ""CreateSimpleButton"" },
                name,
                text
            )
        );

        private Button(
            ICachedEntity entity
        )
        {
            ___guid = entity.___guid;
        }
    }
}
";
    }
}
