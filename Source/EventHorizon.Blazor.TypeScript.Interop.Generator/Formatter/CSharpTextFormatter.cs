namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;

using System;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

public class CSharpTextFormatter : TextFormatter
{
    public string Format(string text)
    {
        return SyntaxFactory
            .ParseSyntaxTree(SourceText.From(text, Encoding.UTF8))
            .GetRoot()
            .NormalizeWhitespace("    ", Environment.NewLine)
            .ToFullString();
    }
}
