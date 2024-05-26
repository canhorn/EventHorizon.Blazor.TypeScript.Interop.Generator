using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Formatter
{
    public class NoFormattingTextFormatter : TextFormatter
    {
        public string Format(string text) => text;
    }
}
