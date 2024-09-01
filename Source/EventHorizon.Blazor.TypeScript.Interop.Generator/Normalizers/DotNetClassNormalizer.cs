namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

using System.Collections.Generic;

public class DotNetClassNormalizer
{
    public static IList<string> DOTNET_NOT_SUPPORTED_LIST = new List<string> { "IDisposable" };

    public static string Normalize(string text)
    {
        if (DOTNET_NOT_SUPPORTED_LIST.Contains(text))
        {
            return $"_{text}";
        }
        return text;
    }

    public static string Denormalize(string text)
    {
        if (!text.StartsWith("_"))
        {
            return text;
        }
        var denormalizeText = text.Substring(1);
        if (DOTNET_NOT_SUPPORTED_LIST.Contains(denormalizeText))
        {
            return denormalizeText;
        }
        return text;
    }
}
