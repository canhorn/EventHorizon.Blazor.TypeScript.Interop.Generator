using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class JavaScriptProvidedApiIdentifier
    {
        public static bool Identify(
            string typeAsString,
            out string jsProvidedApiType
        )
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
            else if (typeAsString == JavaScriptTypes.Int
                || typeAsString == JavaScriptTypes.Float)
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
                jsProvidedApiType = GenerationIdentifiedTypes.Object;
                return true;
            }
            //else if (Types.NumberArrayTypes.Any(
            //    a => a == typeAsString
            //))
            //{
            //    jsProvidedApiType = GenerationIdentifiedTypes.Number;
            //    return true;
            //}
            return false;
        }
    }
}
