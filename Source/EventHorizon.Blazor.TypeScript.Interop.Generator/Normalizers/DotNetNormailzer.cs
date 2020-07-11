using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers
{
    public static class DotNetNormailzer
    {
        public static string Normailze(
            string text
        )
        {
            return text switch
            {
                "ref" => "@ref",
                "lock" => "@lock",
                "unlock" => "@unlock",
                "object" => "@object",
                "event" => "@event",
                "bool" => "@bool",
                "virtual" => "@virtual",
                _ => text,
            };
        }
    }
}
