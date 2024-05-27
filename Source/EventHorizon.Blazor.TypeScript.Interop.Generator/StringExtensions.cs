namespace EventHorizon.Blazor.TypeScript.Interop.Generator;

public static class StringExtensions
{
    public static string Captialize(this string str)
    {
        return str.Remove(0, 1).Insert(0, char.ToUpper(str[0]).ToString());
    }
}
