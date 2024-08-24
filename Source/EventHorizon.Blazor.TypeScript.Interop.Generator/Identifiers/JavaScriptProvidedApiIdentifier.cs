using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

public class JavaScriptProvidedApiIdentifier
{
    public static bool Identify(string typeAsString, out string jsProvidedApiType)
    {
        jsProvidedApiType = typeAsString;
        if (typeAsString == JavaScriptTypes.Promise)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.Task;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.Function)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.Void;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.Int)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.Int;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.Float)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.Number;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.String)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.String;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.Boolean)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.Bool;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.HTMLElement)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.CachedEntity;
            return true;
        }
        else if (typeAsString == JavaScriptTypes.Map)
        {
            jsProvidedApiType = GenerationIdentifiedTypes.CachedEntity;
            return true;
        }
        else if (JavaScriptTypes.NumberArrayTypes.Any(a => a == typeAsString))
        {
            jsProvidedApiType = GenerationIdentifiedTypes.Array;
            return true;
        }
        return false;
    }
}
