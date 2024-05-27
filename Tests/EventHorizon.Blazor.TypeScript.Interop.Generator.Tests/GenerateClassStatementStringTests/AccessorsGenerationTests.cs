namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using System.IO;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class AccessorsGenerationTests : GenerateStringTestBase
{
    [Theory(DisplayName = "Accessors.Static")]
    [Trait("Category", "Accessors.Static")]
    [Trait("AST", "Sdcb")]
    [InlineData(
        "AccessorStaticClass.ts",
        "Accessors",
        "AccessorStaticClass.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "AccessorStaticClassArray.ts",
        "Accessors",
        "AccessorStaticClassArray.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "AccessorStaticPrimitive.ts",
        "Accessors",
        "AccessorStaticPrimitive.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "AccessorStaticPrimitiveArray.ts",
        "Accessors",
        "AccessorStaticPrimitiveArray.Expected.txt",
        ASTParserType.Sdcb
    )]
    public void ShouldGenerateStaticAccessorStringsUsingSdcb(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

    [Theory(DisplayName = "Accessors")]
    [Trait("Category", "Accessors")]
    [Trait("AST", "Sdcb")]
    [InlineData("AccessorClass.ts", "Accessors", "AccessorClass.Expected.txt", ASTParserType.Sdcb)]
    [InlineData(
        "AccessorClassArray.ts",
        "Accessors",
        "AccessorClassArray.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "AccessorPrimitive.ts",
        "Accessors",
        "AccessorPrimitive.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "AccessorPrimitiveArray.ts",
        "Accessors",
        "AccessorPrimitiveArray.Expected.txt",
        ASTParserType.Sdcb
    )]
    public void ShouldGenerateAccessorStringsWithSdcb(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

    [Theory(DisplayName = "Accessors.Scenarios")]
    [Trait("Category", "Accessors.Scenarios")]
    [Trait("AST", "Sdcb")]
    [InlineData(
        "AccessorClassResponseType.ts",
        "Accessors",
        "Scenarios",
        "AccessorClassResponseType.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "AccessorSetNoGet.ts",
        "Accessors",
        "Scenarios",
        "AccessorSetNoGet.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "DotNetNormalized.ts",
        "Accessors",
        "Scenarios",
        "DotNetNormalized.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "GenericObserver.ts",
        "Accessors",
        "Scenarios",
        "GenericObserver.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "InterfaceResponse.ts",
        "Accessors",
        "Scenarios",
        "InterfaceResponse.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "NamespacedTyping.ts",
        "Accessors",
        "Scenarios",
        "NamespacedTyping.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "NullableTyping.ts",
        "Accessors",
        "Scenarios",
        "NullableTyping.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "StaticNoNamespace.d.ts",
        "Accessors",
        "Scenarios",
        "StaticNoNamespace.d.Expected.txt",
        ASTParserType.Sdcb
    )]
    [InlineData(
        "StaticRootNamespace.ts",
        "Accessors",
        "Scenarios",
        "StaticRootNamespace.Expected.txt",
        ASTParserType.Sdcb
    )]
    public void ShouldGenerateAccessorScenarioStringsWithSdcb(
        string sourceFile,
        string rootPath,
        string scenariosPath,
        string expectedFile,
        ASTParserType parserType
    ) =>
        ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType
        );

    [Theory(DisplayName = "Accessors.Static")]
    [Trait("Category", "Accessors.Static")]
    [Trait("AST", "NodeJS")]
    [InlineData(
        "AccessorStaticClass.ts",
        "Accessors",
        "AccessorStaticClass.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorStaticClassArray.ts",
        "Accessors",
        "AccessorStaticClassArray.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorStaticPrimitive.ts",
        "Accessors",
        "AccessorStaticPrimitive.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorStaticPrimitiveArray.ts",
        "Accessors",
        "AccessorStaticPrimitiveArray.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateStaticAccessorStringsUsingNodeJS(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

    [Theory(DisplayName = "Accessors")]
    [Trait("Category", "Accessors")]
    [Trait("AST", "NodeJS")]
    [InlineData(
        "AccessorClass.ts",
        "Accessors",
        "AccessorClass.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorClassArray.ts",
        "Accessors",
        "AccessorClassArray.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorPrimitive.ts",
        "Accessors",
        "AccessorPrimitive.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorPrimitiveArray.ts",
        "Accessors",
        "AccessorPrimitiveArray.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateAccessorStringsWithNodeJS(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);

    [Theory(DisplayName = "Accessors.Scenarios")]
    [Trait("Category", "Accessors.Scenarios")]
    [Trait("AST", "NodeJS")]
    [InlineData(
        "AccessorClassResponseType.ts",
        "Accessors",
        "Scenarios",
        "AccessorClassResponseType.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "AccessorSetNoGet.ts",
        "Accessors",
        "Scenarios",
        "AccessorSetNoGet.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "DotNetNormalized.ts",
        "Accessors",
        "Scenarios",
        "DotNetNormalized.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "GenericObserver.ts",
        "Accessors",
        "Scenarios",
        "GenericObserver.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "InterfaceResponse.ts",
        "Accessors",
        "Scenarios",
        "InterfaceResponse.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "NamespacedTyping.ts",
        "Accessors",
        "Scenarios",
        "NamespacedTyping.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "NullableTyping.ts",
        "Accessors",
        "Scenarios",
        "NullableTyping.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "StaticNoNamespace.d.ts",
        "Accessors",
        "Scenarios",
        "StaticNoNamespace.d.Expected.txt",
        ASTParserType.NodeJS
    )]
    [InlineData(
        "StaticRootNamespace.ts",
        "Accessors",
        "Scenarios",
        "StaticRootNamespace.Expected.txt",
        ASTParserType.NodeJS
    )]
    public void ShouldGenerateAccessorScenarioStringsWithNodeJS(
        string sourceFile,
        string rootPath,
        string scenariosPath,
        string expectedFile,
        ASTParserType parserType
    ) =>
        ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile,
            parserType: parserType
        );
}
