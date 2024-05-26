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
    public void Slim_ShouldGenerateExpectedObserverable()
    {
        // Given
        var sourceFile = "observable.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();

        // When
        var actual = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "Observable",
            ast,
            typeOverrideMap
        );
    }

    [Fact]
    [Trait("AST", "Sdcb")]
    public void ShouldGenerateExpectedObserverable()
    {
        // Given
        //var sourceFile = "babylon.d.ts";
        var sourceFile = "observable.ts";
        var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
        var ast = new Sdcb_TypeScriptASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();

        // When
        var actual = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "Observable",
            ast,
            typeOverrideMap
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
                    new AccessorStatement
                    {
                        Name = "observers",
                        Type = new TypeStatement
                        {
                            Name = "Array",
                            IsArray = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "T", },
                                    },
                                },
                            },
                        },
                        UsedClassNames = new List<string> { "Observer", "T", },
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
                        Name = "notifyObserversWithPromise",
                        Type = new TypeStatement { Name = "void", },
                        //UsedClassNames = new List<string>
                        //{
                        //    "Task",
                        //},
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "eventData",
                                Type = "T".MakeTypeStatement(),
                                UsedClassNames = new List<string> { "T", },
                            },
                            new ArgumentStatement
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "target",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "currentTarget",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "add",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "T", },
                                    },
                                },
                            },
                        },
                        UsedClassNames = new List<string> { "Observer", "T", },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "callback",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                            },
                            new ArgumentStatement
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "insertFirst",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "scope",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "unregisterOnFirstCall",
                                Type = "bool".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        }
                    },
                    new PublicMethodStatement
                    {
                        Name = "addOnce",
                        Type = new TypeStatement
                        {
                            Name = "Nullable",
                            IsNullable = true,
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "T", },
                                    },
                                },
                            },
                        },
                        UsedClassNames = new List<string> { "Observer", "T", },
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "callback",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                            },
                        }
                    },
                    new PublicMethodStatement
                    {
                        Name = "remove",
                        Type = "bool".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Nullable",
                                    IsNullable = true,
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement
                                        {
                                            Name = "Observer",
                                            GenericTypes = new List<TypeStatement>
                                            {
                                                new TypeStatement { Name = "T", },
                                            },
                                        },
                                    },
                                },
                                UsedClassNames = new List<string> { "Observer", "T", },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "removeCallback",
                        Type = "bool".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "callback",
                                Type = new TypeStatement { Name = "action", IsAction = true, },
                            },
                            new ArgumentStatement
                            {
                                Name = "scope",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "makeObserverTopPriority",
                        Type = "void".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "T", },
                                    },
                                },
                                UsedClassNames = new List<string> { "Observer", "T", },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "makeObserverBottomPriority",
                        Type = "void".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "T", },
                                    },
                                },
                                UsedClassNames = new List<string> { "Observer", "T", },
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "notifyObservers",
                        Type = "bool".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "eventData",
                                Type = new TypeStatement { Name = "T" },
                                UsedClassNames = new List<string> { "T", },
                            },
                            new ArgumentStatement
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "target",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                            new ArgumentStatement
                            {
                                Name = "currentTarget",
                                Type = "object".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "notifyObserver",
                        Type = "void".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "observer",
                                Type = new TypeStatement
                                {
                                    Name = "Observer",
                                    GenericTypes = new List<TypeStatement>
                                    {
                                        new TypeStatement { Name = "T", },
                                    },
                                },
                                UsedClassNames = new List<string> { "Observer", "T", },
                            },
                            new ArgumentStatement
                            {
                                Name = "eventData",
                                Type = "T".MakeTypeStatement(),
                                UsedClassNames = new List<string> { "T", },
                            },
                            new ArgumentStatement
                            {
                                Name = "mask",
                                Type = "decimal".MakeTypeStatement(),
                                IsOptional = true,
                            },
                        },
                    },
                    new PublicMethodStatement
                    {
                        Name = "hasObservers",
                        Type = "bool".MakeTypeStatement(),
                    },
                    new PublicMethodStatement
                    {
                        Name = "clear",
                        Type = "void".MakeTypeStatement(),
                    },
                    new PublicMethodStatement
                    {
                        Name = "clone",
                        Type = new TypeStatement
                        {
                            Name = "Observable",
                            GenericTypes = new List<TypeStatement>
                            {
                                new TypeStatement { Name = "T", },
                            },
                        },
                        UsedClassNames = new List<string> { "Observable", "T", },
                    },
                    new PublicMethodStatement
                    {
                        Name = "hasSpecificMask",
                        Type = "bool".MakeTypeStatement(),
                        Arguments = new List<ArgumentStatement>
                        {
                            new ArgumentStatement
                            {
                                Name = "mask",
                                Type = new TypeStatement { Name = "decimal" },
                                IsOptional = true,
                            },
                        },
                    },
                }
            );
        actual.PublicPropertyStatements.Should().BeEmpty();
    }
}

public static class MakeTypeStatementExtension
{
    public static TypeStatement MakeTypeStatement(this string typeString) =>
        new TypeStatement { Name = typeString };
}
