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

        // When
        var actual = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "Control",
            ast,
            typeOverrideMap
        );

        // Then
        actual
            .AccessorStatements.Should()
            .BeEquivalentTo(
                new List<AccessorStatement>
                {
                    new AccessorStatement
                    {
                        Name = "shadowOffsetX",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "shadowOffsetY",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "shadowBlur",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "shadowColor",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "typeName",
                        Type = "string".MakeTypeStatement(),
                    },
                    new AccessorStatement
                    {
                        Name = "host",
                        Type = new TypeStatement { Name = "AdvancedDynamicTexture", },
                        UsedClassNames = new List<string> { "AdvancedDynamicTexture", },
                    },
                    new AccessorStatement
                    {
                        Name = "fontOffset",
                        Type = new TypeStatement { Name = "CachedEntity", IsLiteral = true, },
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "alpha",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "isHighlighted",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "scaleX",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "scaleY",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "rotation",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "transformCenterY",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "transformCenterX",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "horizontalAlignment",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "verticalAlignment",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "width",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "widthInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "height",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "heightInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontFamily",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontStyle",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontWeight",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontSizeInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "fontSize",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "color",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "zIndex",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "notRenderable",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "isVisible",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement { Name = "isDirty", Type = "bool".MakeTypeStatement(), },
                    new AccessorStatement
                    {
                        Name = "paddingLeft",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingLeftInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingRight",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingRightInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingTop",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingTopInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingBottom",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "paddingBottomInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "left",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "leftInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "top",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "topInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetX",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetXInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetY",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "linkOffsetYInPixels",
                        Type = "decimal".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "centerX",
                        Type = "decimal".MakeTypeStatement(),
                    },
                    new AccessorStatement
                    {
                        Name = "centerY",
                        Type = "decimal".MakeTypeStatement(),
                    },
                    new AccessorStatement
                    {
                        Name = "isEnabled",
                        Type = "bool".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "disabledColor",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "disabledColorItem",
                        Type = "string".MakeTypeStatement(),
                        HasSetter = true,
                    },
                    new AccessorStatement
                    {
                        Name = "style",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Style", }
                            }
                        },
                        HasSetter = true,
                        UsedClassNames = new List<string> { "Style", },
                    },
                    new AccessorStatement
                    {
                        Name = "linkedMesh",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "AbstractMesh", }
                            }
                        },
                        UsedClassNames = new List<string> { "AbstractMesh", },
                    },
                    new AccessorStatement
                    {
                        Name = "HORIZONTAL_ALIGNMENT_LEFT",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "HORIZONTAL_ALIGNMENT_RIGHT",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "HORIZONTAL_ALIGNMENT_CENTER",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "VERTICAL_ALIGNMENT_TOP",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new AccessorStatement
                    {
                        Name = "VERTICAL_ALIGNMENT_BOTTOM",
                        Type = "decimal".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new AccessorStatement
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
                    new PublicMethodStatement
                    {
                        Name = "getLocalCoordinatesToRef",
                        Type = "Control".MakeTypeStatement(),
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Control"
                        },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "globalCoordinates",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                },
                            },
                            new ArgumentStatement
                            {
                                Name = "result",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "getAscendantOfClass",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Control", },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "className",
                                Type = "string".MakeTypeStatement(),
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "isAscendant",
                        Type = "bool".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "container",
                                Type = "Control".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Control",
                                },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "getLocalCoordinates",
                        Type = "Vector2".MakeTypeStatement(),
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Vector2",
                        },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "globalCoordinates",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "getParentLocalCoordinates",
                        Type = "Vector2".MakeTypeStatement(),
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Vector2"
                        },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "globalCoordinates",
                                Type = "Vector2".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector2",
                                },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "moveToVector3",
                        Type = "void".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "position",
                                Type = "Vector3".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Vector3",
                                },
                            },
                            new ArgumentStatement
                            {
                                Name = "scene",
                                Type = "Scene".MakeTypeStatement(),
                                UsedClassNames = new List<string>
                                {
                                    //GenerationIdentifiedTypes.CachedEntityObject,
                                    "Scene",
                                },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "getClassName",
                        Type = "string".MakeTypeStatement(),
                    },
                    new PublicMethodStatement
                    {
                        Name = "linkWithMesh",
                        Type = "void".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "mesh",
                                Type = new TypeStatement
                                {
                                    Name = "Nullable",
                                    IsNullable = true,
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "AbstractMesh", }
                                    }
                                },
                                UsedClassNames = new List<string> { "AbstractMesh", },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "dispose",
                        Type = "void".MakeTypeStatement(),
                    },
                    new PublicMethodStatement
                    {
                        Name = "contains",
                        Type = "bool".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "x",
                                Type = "decimal".MakeTypeStatement(),
                            },
                            new ArgumentStatement
                            {
                                Name = "y",
                                Type = "decimal".MakeTypeStatement(),
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "getDescendantsToRef",
                        Type = "void".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "results",
                                Type = new TypeStatement
                                {
                                    Name = "Array",
                                    IsArray = true,
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "Control", },
                                    },
                                },
                                UsedClassNames = new List<string> { "Control", },
                            },
                            new ArgumentStatement
                            {
                                Name = "directDescendantsOnly",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "predicate",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                                IsOptional = true,
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "getDescendants",
                        Type = new TypeStatement
                        {
                            Name = "Array",
                            IsArray = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Control", },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "directDescendantsOnly",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "predicate",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                                IsOptional = true,
                            },
                        },
                    },
                    new PublicMethodStatement
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
                    new PublicPropertyStatement
                    {
                        Name = "name",
                        Type = "string".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "AllowAlphaInheritance",
                        Type = "bool".MakeTypeStatement(),
                        IsStatic = true,
                    },
                    new PublicPropertyStatement
                    {
                        Name = "uniqueId",
                        Type = "decimal".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "metadata",
                        Type = new TypeStatement { Name = "CachedEntity", IsLiteral = true, },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "isHitTestVisible",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "isPointerBlocker",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "isFocusInvisible",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "clipChildren",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "clipContent",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "useBitmapCache",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "hoverCursor",
                        Type = "string".MakeTypeStatement(),
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onWheelObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Vector2", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Vector2", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerMoveObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Vector2", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Vector2", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerOutObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Control", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerDownObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Vector2WithInfo", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Vector2WithInfo", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerUpObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Vector2WithInfo", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Vector2WithInfo", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerClickObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Vector2WithInfo", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Vector2WithInfo", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerEnterObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Control", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onDirtyObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Control", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onBeforeDrawObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Control", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onAfterDrawObservable",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Control", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "Control", },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "parent",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "Container", },
                            },
                        },
                        UsedClassNames = new List<string> { "Container", },
                    }
                }
            );
    }
}
