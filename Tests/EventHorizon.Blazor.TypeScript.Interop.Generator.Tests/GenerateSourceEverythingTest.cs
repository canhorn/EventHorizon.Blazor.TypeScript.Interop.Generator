namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests;

using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;
using FluentAssertions;
using Moq;
using Xunit;

public class GenerateSourceEverythingTest
{
    [Fact]
    [Trait("AST", "Sdcb")]
    public void ShouldGenerateSourceForEverythingDefinition()
    {
        // Given
        GenerateSource.DisableCache();
        var projectAssembly = "ProjectAssembly";
        var sourceDirectory = "";
        var sourceFileName = "Everything.ts";
        var sourceFile = Path.Combine(".", "SourceFiles", sourceFileName);
        var sourceFiles = new List<string> { sourceFile };
        var generationList = new List<string> { "Everything" };
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
    [Trait("AST", "NodeJS")]
    public void ShouldGenerateSourceForEverythingDefinitionWhenUsingTheNodeJS_AST()
    {
        // Given
        GenerateSource.DisableCache();
        var projectAssembly = "ProjectAssembly";
        var sourceDirectory = "";
        var sourceFileName = "Everything.ts";
        var sourceFile = Path.Combine(".", "SourceFiles", sourceFileName);
        var sourceFiles = new List<string> { sourceFile };
        var generationList = new List<string> { "Everything" };
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
            ignoredIdentifiers,
            ASTParserType.NodeJS
        );

        // Then
        actual.Should().BeTrue();
    }
}
