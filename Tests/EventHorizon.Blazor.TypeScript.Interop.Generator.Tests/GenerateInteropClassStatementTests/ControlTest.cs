using System;
using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests
{
    public class ControlTest
    {
        [Fact]
        public void ShouldGenerateExpectedControl()
        {
            // Given
            var sourceFile = "babylon.gui.d.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Control",
                ast,
                typeOverrideMap
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
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "AdvancedDynamicTexture",
                        },
                    },
                    new AccessorStatement
                    {
                        Name = "fontOffset",
                        Type = "CachedEntity",
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
                            //GenerationIdentifiedTypes.CachedEntityObject,
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
                            //GenerationIdentifiedTypes.CachedEntityObject,
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
                            //GenerationIdentifiedTypes.CachedEntityObject,
                                "Control",
                            },
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "className",
                                    Type = "string",
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "isAscendant",
                            Type = "bool",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "container",
                                    Type = "Control",
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
                            Type = "Vector2",
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
                                    Type = "Vector2",
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
                            Name = "getLocalCoordinatesToRef",
                            Type = "Control",
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
                                    Type = "Vector2",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Vector2",
                                    },
                                },
                                new ArgumentStatement
                                {
                                    Name = "result",
                                    Type = "Vector2",
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
                            Type = "Vector2",
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
                                    Type = "Vector2",
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
                            Type = "void",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "position",
                                    Type = "Vector3",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Vector3",
                                    },
                                },
                                new ArgumentStatement
                                {
                                    Name = "scene",
                                    Type = "Scene",
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
                            Name = "getDescendantsToRef",
                            Type = "void",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "results",
                                    Type = "Control",
                                    IsArrayResponse = true,
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Control",
                                    },
                                },
                                new ArgumentStatement
                                {
                                    Name = "directDescendantsOnly",
                                    Type = "bool",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "predicate",
                                    Type = "action",
                                    IsOptional = true,
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "getDescendants",
                            Type = "Control",
                            IsArrayResponse = true,
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Control"
                            },
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "directDescendantsOnly",
                                    Type = "bool",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "predicate",
                                    Type = "action",
                                    IsOptional = true,
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "linkWithMesh",
                            Type = "void",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "mesh",
                                    Type = "AbstractMesh",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "AbstractMesh",
                                    },
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "contains",
                            Type = "bool",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "x",
                                    Type = "decimal",
                                },
                                new ArgumentStatement
                                {
                                    Name = "y",
                                    Type = "decimal",
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "dispose",
                            Type = "void",
                        },
                        new PublicMethodStatement
                        {
                            Name = "AddHeader",
                            Type = "action",
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
                            //GenerationIdentifiedTypes.CachedEntityObject,
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
                        Type = "CachedEntity",
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
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerMoveObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerOutObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerDownObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerUpObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerClickObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onPointerEnterObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onDirtyObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onBeforeDrawObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    },
                    new PublicPropertyStatement
                    {
                        Name = "onAfterDrawObservable",
                        Type = "Observable",
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observable",
                        },
                    }
                );
        }
    }
}
