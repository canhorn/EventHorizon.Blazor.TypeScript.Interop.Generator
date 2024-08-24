namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests;

using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Xunit;

public class ControlTest
{
    [Fact]
    [Trait("AST", "Sdcb")]
    public void ShouldGenerateExpectedControl()
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
            "Control",
            ast,
            typeOverrideMap,
            ignoredIdentifiers
        );

        // Then
        actual
            .AccessorStatements.Should()
            .BeEquivalentTo(
                new List<AccessorStatement>
                {
                    new()
                    {
                        Name = "shadowOffsetX",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "shadowOffsetY",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "shadowBlur",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "shadowColor",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new() { Name = "typeName", Type = "string".MakeTypeStatement(), },
                    new()
                    {
                        Name = "host",
                        Type = new TypeStatement
                        {
                            Name = "AdvancedDynamicTexture",
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["AdvancedDynamicTexture",],
                    },
                    new()
                    {
                        Name = "fontOffset",
                        Type = new TypeStatement { Name = "CachedEntity", IsLiteral = true, },
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "alpha",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "isHighlighted",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "scaleX",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "scaleY",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "rotation",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "transformCenterY",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "transformCenterX",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "horizontalAlignment",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "verticalAlignment",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "width",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "widthInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "height",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "heightInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "fontFamily",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "fontStyle",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "fontWeight",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "fontSizeInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "fontSize",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "color",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "zIndex",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "notRenderable",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "isVisible",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new() { Name = "isDirty", Type = "bool".MakeTypeStatement(), },
                    new()
                    {
                        Name = "paddingLeft",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingLeftInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingRight",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingRightInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingTop",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingTopInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingBottom",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "paddingBottomInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "left",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "leftInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "top",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "topInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "linkOffsetX",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "linkOffsetXInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "linkOffsetY",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "linkOffsetYInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new() { Name = "centerX", Type = "decimal".MakeTypeStatement(), },
                    new() { Name = "centerY", Type = "decimal".MakeTypeStatement(), },
                    new()
                    {
                        Name = "isEnabled",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "disabledColor",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "disabledColorItem",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new()
                    {
                        Name = "style",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = [new() { Name = "Style", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        HasSetter = true,
                        UsedClassNames = ["Style",],
                    },
                    new()
                    {
                        Name = "linkedMesh",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes =
                            [
                                new() { Name = "AbstractMesh", IsTypeReference = true, }
                            ],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["AbstractMesh",],
                    },
                    new()
                    {
                        Name = "HORIZONTAL_ALIGNMENT_LEFT",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new()
                    {
                        Name = "HORIZONTAL_ALIGNMENT_RIGHT",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new()
                    {
                        Name = "HORIZONTAL_ALIGNMENT_CENTER",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new()
                    {
                        Name = "VERTICAL_ALIGNMENT_TOP",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new()
                    {
                        Name = "VERTICAL_ALIGNMENT_BOTTOM",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new()
                    {
                        Name = "VERTICAL_ALIGNMENT_CENTER",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    }
                }
            );
        actual.ExtendedType.Should().BeNull();
        actual
            .PublicMethodStatements.Should()
            .BeEquivalentTo(
                new List<PublicMethodStatement>
                {
                    new()
                    {
                        Name = "getLocalCoordinatesToRef",
                        Type = "Control".MakeTypeStatement(),
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Control"
                        ],
                        Arguments =
                        [
                            new()
                            {
                                Name = "globalCoordinates",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                ],
                            },
                            new()
                            {
                                Name = "result",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                ],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "getAscendantOfClass",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = [new() { Name = "Control", },],
                        },
                        UsedClassNames = ["Control",],
                        Arguments =
                        [
                            new() { Name = "className", Type = "string".MakeTypeStatement(), },
                        ],
                    },
                    new()
                    {
                        Name = "isAscendant",
                        Type = "bool".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "container",
                                Type = "Control".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Control",
                                ],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "getLocalCoordinates",
                        Type = "Vector2".MakeTypeStatement(),
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Vector2",
                        ],
                        Arguments =
                        [
                            new()
                            {
                                Name = "globalCoordinates",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                ],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "getParentLocalCoordinates",
                        Type = "Vector2".MakeTypeStatement(),
                        UsedClassNames =
                        [
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Vector2"
                        ],
                        Arguments =
                        [
                            new()
                            {
                                Name = "globalCoordinates",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                ],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "moveToVector3",
                        Type = "void".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "position",
                                Type = "Vector3".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector3",
                                ],
                            },
                            new()
                            {
                                Name = "scene",
                                Type = "Scene".MakeTypeStatement(),
                                UsedClassNames =
                                [
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Scene",
                                ],
                            },
                        ],
                    },
                    new() { Name = "getClassName", Type = "string".MakeTypeStatement(), },
                    new()
                    {
                        Name = "linkWithMesh",
                        Type = "void".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "mesh",
                                Type = new TypeStatement
                                {
                                    Name = "Nullable",
                                    IsNullable = true,
                                    GenericTypes = [new() { Name = "AbstractMesh", }]
                                },
                                UsedClassNames = ["AbstractMesh",],
                            },
                        ],
                    },
                    new() { Name = "dispose", Type = "void".MakeTypeStatement(), },
                    new()
                    {
                        Name = "contains",
                        Type = "bool".MakeTypeStatement(),
                        Arguments =
                        [
                            new() { Name = "x", Type = "decimal".MakeTypeStatement(), },
                            new() { Name = "y", Type = "decimal".MakeTypeStatement(), },
                        ],
                    },
                    new()
                    {
                        Name = "getDescendantsToRef",
                        Type = "void".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "results",
                                Type = new TypeStatement
                                {
                                    Name = "Array",
                                    IsArray = true,
                                    GenericTypes = [new() { Name = "Control", },],
                                },
                                UsedClassNames = ["Control",],
                            },
                            new()
                            {
                                Name = "directDescendantsOnly",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "predicate",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                                IsOptional = true,
                            },
                        ],
                    },
                    new()
                    {
                        Name = "getDescendants",
                        Type = new TypeStatement
                        {
                            Name = "Array",
                            IsArray = true,
                            GenericTypes = [new() { Name = "Control", },],
                        },
                        UsedClassNames = ["Control",],
                        Arguments =
                        [
                            new()
                            {
                                Name = "directDescendantsOnly",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "predicate",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                                IsOptional = true,
                            },
                        ],
                    },
                    new()
                    {
                        Name = "AddHeader",
                        Type = new TypeStatement { Name = "action", IsAction = true, },
                        IsStatic = true,
                    },
                }
            );
        actual
            .PublicPropertyStatements.Should()
            .BeEquivalentTo(
                new List<PublicPropertyStatement>
                {
                    new() { Name = "name", Type = "string".MakeTypeStatement(), },
                    new()
                    {
                        Name = "AllowAlphaInheritance",
                        Type = "bool".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new() { Name = "uniqueId", Type = "decimal".MakeTypeStatement(), },
                    new()
                    {
                        Name = "metadata",
                        Type = new TypeStatement { Name = "CachedEntity", IsLiteral = true, },
                    },
                    new() { Name = "isHitTestVisible", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "isPointerBlocker", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "isFocusInvisible", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "clipChildren", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "clipContent", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "useBitmapCache", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "hoverCursor", Type = "string".MakeTypeStatement(), },
                    new()
                    {
                        Name = "onWheelObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Vector2", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Vector2",],
                    },
                    new()
                    {
                        Name = "onPointerMoveObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Vector2", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Vector2",],
                    },
                    new()
                    {
                        Name = "onPointerOutObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Control", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Control",],
                    },
                    new()
                    {
                        Name = "onPointerDownObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes =
                            [
                                new() { Name = "Vector2WithInfo", IsTypeReference = true, },
                            ],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Vector2WithInfo",],
                    },
                    new()
                    {
                        Name = "onPointerUpObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes =
                            [
                                new() { Name = "Vector2WithInfo", IsTypeReference = true, },
                            ],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Vector2WithInfo",],
                    },
                    new()
                    {
                        Name = "onPointerClickObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes =
                            [
                                new() { Name = "Vector2WithInfo", IsTypeReference = true, },
                            ],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Vector2WithInfo",],
                    },
                    new()
                    {
                        Name = "onPointerEnterObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Control", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Control",],
                    },
                    new()
                    {
                        Name = "onDirtyObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Control", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Control",],
                    },
                    new()
                    {
                        Name = "onBeforeDrawObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Control", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Control",],
                    },
                    new()
                    {
                        Name = "onAfterDrawObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "Control", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Observable", "Control",],
                    },
                    new()
                    {
                        Name = "parent",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = [new() { Name = "Container", IsTypeReference = true, },],
                            IsTypeReference = true,
                        },
                        UsedClassNames = ["Container",],
                    }
                }
            );
    }
}
