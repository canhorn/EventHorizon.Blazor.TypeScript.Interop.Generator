using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class TypeAliasGenerationTests 
        : GenerateStringTestBase
    {
        [Theory(DisplayName = "TypeAlias")]
        [Trait("Category", "TypeAlias")]
        [InlineData("NullableActionCallbackArgument.ts", "TypeAlias", "NullableActionCallbackArgument.Expected.txt")]
        [InlineData("NullableAliasActionCallbackArgument.ts", "TypeAlias", "NullableAliasActionCallbackArgument.Expected.txt")]
        [InlineData("NullableNumberArgument.ts", "TypeAlias", "NullableNumberArgument.Expected.txt")]
        [InlineData("NullableTypeResponse.ts", "TypeAlias", "NullableTypeResponse.Expected.txt")]
        [InlineData("ObjectTypeResponse.ts", "TypeAlias", "ObjectTypeResponse.Expected.txt")]
        public void ShouldGenerateTypeAliasStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );
    }
}
