namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;

using CSharpier;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;

public class CSharpTextFormatter : TextFormatter
{
    public string Format(string text)
    {
        return CodeFormatter.Format(text).Code;
    }
}
