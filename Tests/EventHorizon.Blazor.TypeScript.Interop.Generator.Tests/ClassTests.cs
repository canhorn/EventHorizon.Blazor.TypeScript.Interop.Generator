namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
using FluentAssertions;
using Xunit;

public class ClassTests
{
    [Fact]
    [Trait("AST", "NodeJS")]
    [Trait("Category", "Class.Scenario.BaseClassConstructors")]
    public void ShouldGenerateInterfaceStringWhenUsingNodeJS()
    {
        // Given
        var source = File.ReadAllText($"./Scenarios/BaseClassConstructors.ts");
        var expected = File.ReadAllText($"./Scenarios/BaseClassConstructors.Expected.txt");
        var ast = new NodeJS_ASTWrapper(source);
        var typeOverrideMap = new Dictionary<string, string>();

        // When
        var className = "ExampleClass";
        var secondLayerBaseClass = "SecondLayerBaseClass";
        var thirdLayerBaseClass = "ThirdLayerBaseClass";
        var fourthLayerBaseClass = "FourthLayerBaseClass";
        var fifthLayerBaseClass = "FifthLayerBaseClass";
        var classGenerated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            className,
            ast,
            typeOverrideMap
        );
        var secondLayerSuperClassGenerated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            secondLayerBaseClass,
            ast,
            typeOverrideMap
        );
        var thirdLayerSuperClassGenerated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            thirdLayerBaseClass,
            ast,
            typeOverrideMap
        );
        var fourthLayerSuperClassGenerated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            fourthLayerBaseClass,
            ast,
            typeOverrideMap
        );
        var fifthLayerSuperClassGenerated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            fifthLayerBaseClass,
            ast,
            typeOverrideMap
        );
        var actual = GenerateClassStatementString.Generate(
            classGenerated,
            new ConcurrentDictionary<string, Model.Statements.ClassStatement>
            {
                [className] = classGenerated,
                [secondLayerBaseClass] = secondLayerSuperClassGenerated,
                [thirdLayerBaseClass] = thirdLayerSuperClassGenerated,
                [fourthLayerBaseClass] = fourthLayerSuperClassGenerated,
                [fifthLayerBaseClass] = fifthLayerSuperClassGenerated,
            },
            new NoFormattingTextFormatter()
        );

        // Then
        actual.Should().Be(expected);
    }
}
