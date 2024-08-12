using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;
using FluentAssertions;
using Moq;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

public class ActualStringGenerationTest
{
    [Fact]
    [Trait("Category", "Multiple Generation")]
    [Trait("AST", "Sdcb")]
    public void ShouldGenerateSourceForEverythingDefinition()
    {
        // Given
        var projectAssembly = "ProjectAssembly";
        var sourceDirectory = "";
        var sourceFileName = "MultipleGeneration.d.ts";
        var sourceFile = Path.Combine(".", "SourceFiles", sourceFileName);
        var sourceFiles = new List<string> { sourceFile };
        var generationList = new List<string> { "Mesh", "Mesh", "Engine", "Vector3", };
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        var writerMock = new Mock<IWriter>();

        // When
        var generateSource = new GenerateSource();
        var actual = generateSource.Run(
            projectAssembly,
            sourceDirectory,
            sourceFiles,
            generationList,
            writerMock.Object,
            new NoFormattingTextFormatter(),
            typeOverrideMap,
            ignoredIdentifiers
        );

        // Then
        actual.Should().BeTrue();
    }

    [Fact]
    [Trait("Category", "Writer")]
    [Trait("AST", "Sdcb")]
    public void ShouldCallWriterWithGeneratedClassStatement()
    {
        // Given
        var projectAssembly = "ProjectAssembly";
        var sourceDirectory = "";
        var sourceFileName = "MultipleGeneration.d.ts";
        var sourceFile = Path.Combine(".", "SourceFiles", sourceFileName);
        var sourceFiles = new List<string> { sourceFile };
        var generationList = new List<string> { "Vector3", };
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        var writerMock = new Mock<IWriter>();

        // When
        var generateSource = new GenerateSource();
        var actual = default(IList<GeneratedStatement>);
        writerMock
            .Setup(mock => mock.Write(It.IsAny<IList<GeneratedStatement>>()))
            .Callback<IList<GeneratedStatement>>(
                (generatedStatement) =>
                {
                    actual = generatedStatement;
                }
            );

        generateSource.Run(
            projectAssembly,
            sourceDirectory,
            sourceFiles,
            generationList,
            writerMock.Object,
            new NoFormattingTextFormatter(),
            typeOverrideMap,
            ignoredIdentifiers
        );

        // Then
        actual.Should().NotBeNull();
        actual.Should().HaveCount(6);
    }

    [Fact]
    [Trait("Category", "Writer")]
    [Trait("AST", "Sdcb")]
    public void ShouldCallWriterWithGeneratedComplexDefinitionSdcb()
    {
        // Given
        var projectAssembly = "ProjectAssembly";
        var sourceDirectory = "";
        var sourceFileName = "ComplexGeneration.d.ts";
        var sourceFile = Path.Combine(".", "SourceFiles", sourceFileName);
        var sourceFiles = new List<string> { sourceFile };
        var generationList = new List<string> { "ExampleClass", };
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        var writerMock = new Mock<IWriter>();

        // When
        var generateSource = new GenerateSource();
        var actual = default(IList<GeneratedStatement>);
        writerMock
            .Setup(mock => mock.Write(It.IsAny<IList<GeneratedStatement>>()))
            .Callback<IList<GeneratedStatement>>(
                (generatedStatement) =>
                {
                    actual = generatedStatement;
                }
            );

        generateSource.Run(
            projectAssembly,
            sourceDirectory,
            sourceFiles,
            generationList,
            writerMock.Object,
            new NoFormattingTextFormatter(),
            typeOverrideMap,
            ignoredIdentifiers,
            AstParser.Model.ASTParserType.Sdcb
        );

        // Then
        actual.Should().NotBeNull();
        actual.Should().HaveCount(6);
    }

    [Fact]
    [Trait("Category", "Writer")]
    [Trait("AST", "NodeJS")]
    public void ShouldCallWriterWithGeneratedComplexDefinitionNodeJS()
    {
        // Given
        var projectAssembly = "ProjectAssembly";
        var sourceDirectory = "";
        var sourceFileName = "ComplexGeneration.d.ts";
        var sourceFile = Path.Combine(".", "SourceFiles", sourceFileName);
        var sourceFiles = new List<string> { sourceFile };
        var generationList = new List<string> { "ExampleClass", };
        var typeOverrideMap = new Dictionary<string, string>();
        var ignoredIdentifiers = new List<string>();

        var writerMock = new Mock<IWriter>();

        // When
        var generateSource = new GenerateSource();
        var actual = default(IList<GeneratedStatement>);
        writerMock
            .Setup(mock => mock.Write(It.IsAny<IList<GeneratedStatement>>()))
            .Callback<IList<GeneratedStatement>>(
                (generatedStatement) =>
                {
                    actual = generatedStatement;
                }
            );

        generateSource.Run(
            projectAssembly,
            sourceDirectory,
            sourceFiles,
            generationList,
            writerMock.Object,
            new NoFormattingTextFormatter(),
            typeOverrideMap,
            ignoredIdentifiers,
            AstParser.Model.ASTParserType.NodeJS
        );

        // Then
        actual.Should().NotBeNull();
        actual.Should().HaveCount(6);
    }
}
