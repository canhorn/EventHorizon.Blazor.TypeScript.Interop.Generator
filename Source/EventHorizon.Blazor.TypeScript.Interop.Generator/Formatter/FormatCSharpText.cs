using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter
{
    public static class FormatCSharpText
    {
        public static string Format(
            string text
        )
        {
            return SyntaxFactory.ParseSyntaxTree(
                SourceText.From(
                    text,
                    Encoding.UTF8
                )
            ).GetRoot().NormalizeWhitespace().ToFullString();
        }
    }
}
