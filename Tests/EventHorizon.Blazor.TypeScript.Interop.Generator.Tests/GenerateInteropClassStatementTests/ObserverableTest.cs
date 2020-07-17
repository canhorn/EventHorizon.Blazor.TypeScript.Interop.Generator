using System;
using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using FluentAssertions;
using Sdcb.TypeScript;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.GenerateInteropClassStatementTests
{
    public class ObserverableTest
    {
        [Fact]
        public void Slim_ShouldGenerateExpectedObserverable()
        {
            // Given
            var sourceFile = "observable.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Observable",
                ast,
                typeOverrideMap
            );
            Console.WriteLine("stop");
        }

        [Fact]
        public void ShouldGenerateExpectedObserverable()
        {
            // Given
            //var sourceFile = "babylon.d.ts";
            var sourceFile = "observable.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var ast = new TypeScriptAST(source, sourceFile);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var actual = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Observable",
                ast,
                typeOverrideMap
            );

            // Then
            Console.WriteLine("stop");
            actual.Namespace
                .Should().Be("BABYLON");
            actual.Name
                .Should().Be("Observable");
            actual.ExtendedClassNames
                .Should().BeEmpty();
            actual.AccessorStatements
                .Should().BeEquivalentTo(
                    new AccessorStatement
                    {
                        Name = "observers",
                        Type = "Observer",
                        IsArrayResponse = true,
                        UsedClassNames = new List<string>
                        {
                            //GenerationIdentifiedTypes.CachedEntityObject,
                            "Observer",
                        },
                    }
                );
            actual.PublicMethodStatements
                .Should().BeEquivalentTo(
                    new List<PublicMethodStatement>
                    {
                        new PublicMethodStatement
                        {
                            Name = "add",
                            Type = "Observer",
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Observer",
                            },
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "callback",
                                    Type = "action",
                                },
                                new ArgumentStatement
                                {
                                    Name = "mask",
                                    Type = "decimal",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "insertFirst",
                                    Type = "bool",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "scope",
                                    Type = "object",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "unregisterOnFirstCall",
                                    Type = "bool",
                                    IsOptional = true,
                                },
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "addOnce",
                            Type = "Observer",
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Observer",
                            },
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "callback",
                                    Type = "action",
                                },
                            }
                        },
                        new PublicMethodStatement
                        {
                            Name = "remove",
                            Type = "bool",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "observer",
                                    Type = "Observer",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Observer",
                                    },
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "removeCallback",
                            Type = "bool",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "callback",
                                    Type = "action",
                                },
                                new ArgumentStatement
                                {
                                    Name = "scope",
                                    Type = "object", 
                                    IsOptional = true,
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "makeObserverTopPriority",
                            Type = "void",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "observer",
                                    Type = "Observer",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Observer",
                                    },
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "makeObserverBottomPriority",
                            Type = "void",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "observer",
                                    Type = "Observer",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Observer",
                                    },
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "notifyObservers",
                            Type = "bool",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "eventData",
                                    Type = "object",
                                },
                                new ArgumentStatement
                                {
                                    Name = "mask",
                                    Type = "decimal",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "target",
                                    Type = "object",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "currentTarget",
                                    Type = "object",
                                    IsOptional = true,
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "notifyObserversWithPromise",
                            Type = "Task",
                            //UsedClassNames = new List<string>
                            //{
                            //    "Task",
                            //},
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "eventData",
                                    Type = "object",
                                },
                                new ArgumentStatement
                                {
                                    Name = "mask",
                                    Type = "decimal",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "target",
                                    Type = "object",
                                    IsOptional = true,
                                },
                                new ArgumentStatement
                                {
                                    Name = "currentTarget",
                                    Type = "object",
                                    IsOptional = true,
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "notifyObserver",
                            Type = "void",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "observer",
                                    Type = "Observer",
                                    UsedClassNames = new List<string>
                                    {
                                        //GenerationIdentifiedTypes.CachedEntityObject,
                                        "Observer",
                                    },
                                },
                                new ArgumentStatement
                                {
                                    Name = "eventData",
                                    Type = "object",
                                },
                                new ArgumentStatement
                                {
                                    Name = "mask",
                                    Type = "decimal",
                                    IsOptional = true,
                                },
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "hasObservers",
                            Type = "bool",
                        },
                        new PublicMethodStatement
                        {
                            Name = "clear",
                            Type = "void",
                        },
                        new PublicMethodStatement
                        {
                            Name = "clone",
                            Type = "Observable",
                            UsedClassNames = new List<string>
                            {
                                //GenerationIdentifiedTypes.CachedEntityObject,
                                "Observable",
                            },
                        },
                        new PublicMethodStatement
                        {
                            Name = "hasSpecificMask",
                            Type = "bool",
                            Arguments = new List<ArgumentStatement>
                            {
                                new ArgumentStatement
                                {
                                    Name = "mask",
                                    Type = "decimal",
                                    IsOptional = true,
                                },
                            },
                        },
                    }
                );
            actual.PublicPropertyStatements
                .Should().BeEmpty();
        }
    }
}
