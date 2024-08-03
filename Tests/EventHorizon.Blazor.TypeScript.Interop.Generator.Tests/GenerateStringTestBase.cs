namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests;

using System.Collections.Generic;
using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
using FluentAssertions;

public class GenerateStringTestBase
{
    public void ValidateGenerateStrings(
        string path,
        string sourceFile,
        string expectedFile,
        string classIdentifier = "ExampleClass",
        ASTParserType parserType = ASTParserType.Sdcb
    )
    {
        // Given
        GenerateSource.DisableCache();
        var sourcePath = Path.Combine(".", "GenerateClassStatementStringTests", path);
        string expected = File.ReadAllText(Path.Combine(sourcePath, expectedFile));
        var source = File.ReadAllText(Path.Combine(sourcePath, sourceFile));
        var ast = CreateParser(parserType, source);
        var typeOverrideMap = new Dictionary<string, string>();

        // When
        var generated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            classIdentifier,
            ast,
            typeOverrideMap
        );
        var actual = GenerateClassStatementString.Generate(
            generated,
            new NoFormattingTextFormatter()
        );

        // Then
        actual.Should().Be(expected);
    }

    public void ValidateGenerateWithTypeOverrideStrings(
        string path,
        string sourceFile,
        IDictionary<string, string> typeOverrideMap,
        string expectedFile,
        ASTParserType parserType = ASTParserType.Sdcb
    )
    {
        // Given
        GenerateSource.DisableCache();
        var sourcePath = Path.Combine(".", "GenerateClassStatementStringTests", path);
        string expected = File.ReadAllText(Path.Combine(sourcePath, expectedFile));
        var source = File.ReadAllText(Path.Combine(sourcePath, sourceFile));
        var ast = CreateParser(parserType, source);

        // When
        var generated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "ExampleClass",
            ast,
            typeOverrideMap
        );
        var actual = GenerateClassStatementString.Generate(
            generated,
            new NoFormattingTextFormatter()
        );

        // Then
        actual.Should().Be(expected);
    }

    public void ValidateGenerateWithIgnoreIdentifiers(
        string path,
        string sourceFile,
        IEnumerable<string> ignoredIdentifiers,
        string expectedFile,
        ASTParserType parserType = ASTParserType.Sdcb
    )
    {
        // Given
        GenerateSource.DisableCache();
        var sourcePath = Path.Combine(".", "GenerateClassStatementStringTests", path);
        string expected = File.ReadAllText(Path.Combine(sourcePath, expectedFile));
        var source = File.ReadAllText(Path.Combine(sourcePath, sourceFile));
        var ast = CreateParser(parserType, source);

        // When
        var generated = GenerateInteropClassStatement.Generate(
            "ProjectAssembly",
            "ExampleClass",
            ast,
            new Dictionary<string, string>(),
            ignoredIdentifiers
        );
        var actual = GenerateClassStatementString.Generate(
            generated,
            new NoFormattingTextFormatter()
        );

        // Then
        actual.Should().Be(expected);
    }

    private static AbstractSyntaxTree CreateParser(ASTParserType parserType, string source)
    {
        return parserType switch
        {
            ASTParserType.NodeJS => new NodeJS_ASTWrapper(source),
            _ => new Sdcb_TypeScriptASTWrapper(source),
        };
    }
}
