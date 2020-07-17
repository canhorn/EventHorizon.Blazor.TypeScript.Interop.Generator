using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;
using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Moq;
using Sdcb.TypeScript;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests
{
    public class GenerateSourceEverythingTest
    {
        [Fact]
        public void ShouldGenerateSourceForEverythingDefinition()
        {
            // Given
            var projectAssembly = "ProjectAssembly";
            var sourceDirectory = "";
            var sourceFileName = "Everything.ts";
            var sourceFile = Path.Combine(
                ".",
                "SourceFiles",
                sourceFileName
            );
            var sourceFiles = new List<string>
            {
                sourceFile
            };
            var generationList = new List<string>
            {
                "Everything",
            };
            var typeOverrideMap = new Dictionary<string, string>();

            var writerMock = new Mock<IWriter>();

            // When
            var generateSource = new GenerateSource();
            var actual = generateSource.Run(
                projectAssembly,
                sourceDirectory,
                sourceFiles,
                generationList,
                writerMock.Object, 
                typeOverrideMap
            );


            // Then
            actual.Should().BeTrue();

        }
    }
}
