namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

using System.Collections.Generic;

public static class DotNetNormalizer
{
    private static readonly IList<string> NORMAILZE_LIST = new List<string>
    {
        "ref",
        "lock",
        "unlock",
        "object",
        "event",
        "bool",
        "virtual",
        "string",
        "this",
        "params",
    };

    public static string Normalize(string text)
    {
        if (NORMAILZE_LIST.Contains(text))
        {
            return $"@{text}";
        }
        return text;
    }
}
