namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests;

using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Xunit;

public class ObserverableTest
{
    [Fact]
    [Trait("AST", "Sdcb")]
    public void Slim_ShouldGenerateExpectedObservable()
    {
        // Given
        var sourceFile = "observable.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        // When
        var actual = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "Observable",
            ast,
            typeOverrideMap,
            ignoredIdentifiers
        );
    }

    [Fact]
    [Trait("AST", "Sdcb")]
    public void ShouldGenerateExpectedObservable()
    {
        // Given
        //var sourceFile = "babylon.d.ts";
        var sourceFile = "observable.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        // When
        var actual = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "Observable",
            ast,
            typeOverrideMap,
            ignoredIdentifiers
        );

        // Then
        actual.Namespace.Should().Be("BABYLON");
        actual.Name.Should().Be("Observable");
        actual.ExtendedType.Should().BeNull();
        actual
            .AccessorStatements.Should()
            .BeEquivalentTo(
                new List<AccessorStatement>
                {
                    new()
                    {
                        Name = "observers",
                        Type = new TypeStatement
                        {
                            Name = "Array",
                            IsArray = true,
                            IsTypeReference = true,
                            GenericTypes =
                            [
                                new()
                                {
                                    Name = "Observer",
                                    IsTypeReference = true,
                                    GenericTypes = [new() { Name = "T", IsTypeReference = true, },],
                                },
                            ],
                        },
                        UsedClassNames = ["Observer", "T",],
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
                        Name = "notifyObserversWithPromise",
                        Type = new TypeStatement { Name = "void", },
                        //UsedClassNames = new List<string>
                        //{
                        //    "Task",
                        //},
                        Arguments =
                        [
                            new()
                            {
                                Name = "eventData",
                                Type = "T".MakeTypeStatement(),
                                UsedClassNames = ["T",],
                            },
                            new()
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "target",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "currentTarget",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        ],
                    },
                    new()
                    {
                        Name = "add",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes =
                            [
                                new()
                                {
                                    Name = "Observer",
                                    GenericTypes = [new() { Name = "T", },],
                                },
                            ],
                        },
                        UsedClassNames = ["Observer", "T",],
                        Arguments =
                        [
                            new()
                            {
                                Name = "callback",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                            },
                            new()
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "insertFirst",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "scope",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "unregisterOnFirstCall",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        ]
                    },
                    new()
                    {
                        Name = "addOnce",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes =
                            [
                                new()
                                {
                                    Name = "Observer",
                                    GenericTypes = [new() { Name = "T", },],
                                },
                            ],
                        },
                        UsedClassNames = ["Observer", "T",],
                        Arguments =
                        [
                            new()
                            {
                                Name = "callback",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                            },
                        ]
                    },
                    new()
                    {
                        Name = "remove",
                        Type = "bool".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Nullable",
                                    IsNullable = true,
                                    GenericTypes =
                                    [
                                        new()
                                        {
                                            Name = "Observer",
                                            GenericTypes = [new() { Name = "T", },],
                                        },
                                    ],
                                },
                                UsedClassNames = ["Observer", "T",],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "removeCallback",
                        Type = "bool".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "callback",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                            },
                            new()
                            {
                                Name = "scope",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        ],
                    },
                    new()
                    {
                        Name = "makeObserverTopPriority",
                        Type = "void".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = [new() { Name = "T", },],
                                },
                                UsedClassNames = ["Observer", "T",],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "makeObserverBottomPriority",
                        Type = "void".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = [new() { Name = "T", },],
                                },
                                UsedClassNames = ["Observer", "T",],
                            },
                        ],
                    },
                    new()
                    {
                        Name = "notifyObservers",
                        Type = "bool".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "eventData",
                                Type = new TypeStatement { Name = "T" },
                                UsedClassNames = ["T",],
                            },
                            new()
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "target",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new()
                            {
                                Name = "currentTarget",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        ],
                    },
                    new()
                    {
                        Name = "notifyObserver",
                        Type = "void".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = [new() { Name = "T", },],
                                },
                                UsedClassNames = ["Observer", "T",],
                            },
                            new()
                            {
                                Name = "eventData",
                                Type = "T".MakeTypeStatement(),
                                UsedClassNames = ["T",],
                            },
                            new()
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        ],
                    },
                    new() { Name = "hasObservers", Type = "bool".MakeTypeStatement(), },
                    new() { Name = "clear", Type = "void".MakeTypeStatement(), },
                    new()
                    {
                        Name = "clone",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = [new() { Name = "T", },],
                        },
                        UsedClassNames = ["Observable", "T",],
                    },
                    new()
                    {
                        Name = "hasSpecificMask",
                        Type = "bool".MakeTypeStatement(),
                        Arguments =
                        [
                            new()
                            {
                                Name = "mask",
                                Type = new TypeStatement { Name = "decimal" },
                                IsOptional = true,
                            },
                        ],
                    },
                }
            );
        actual.PublicPropertyStatements.Should().BeEmpty();
    }
}

public static class MakeTypeStatementExtension
{
    public static TypeStatement MakeTypeStatement(this string typeString) =>
        new() { Name = typeString };
}
