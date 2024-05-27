namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter;

using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;

public class NoFormattingTextFormatter : TextFormatter
{
    public string Format(string text) => text;
}
