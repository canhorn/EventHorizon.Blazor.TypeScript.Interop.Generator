namespace EventHorizon.Blazor.Interop.Generator.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using EventHorizon.Blazor.Interop.Generator.Templates;
    using EventHorizon.Blazor.TypeScript.Interop.Generator;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using FluentAssertions;
    using Xunit;

    public class MethodTaskGenerationTests
    {
        [Fact]
        [Trait("Generator", "Server")]
        [Trait("Category", "Server.Method.Promise")]
        public void ShouldNotWrapValueTaskTwiceWhenMethodReturnsPromise()
        {
            // Given
            var sourceFile = "Method.Promise.d.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var expected = File.ReadAllText($"./ExpectedResults/Method.Promise.Expected.txt");
            var ast = new Sdcb_TypeScriptASTWrapper(source);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            TypeStatementTemplates.TaskTemplate = "[[GENERIC_TYPES]]";
            ReadInteropTemplates.SetReadTemplates();

            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "MethodWithPromise",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated,
                new NoFormattingTextFormatter()
            );

            // Then
            actual.Should().Be(
                expected
            );
        }
    }
}
