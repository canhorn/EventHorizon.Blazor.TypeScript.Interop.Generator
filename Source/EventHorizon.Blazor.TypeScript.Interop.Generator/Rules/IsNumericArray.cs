using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsNumericArray
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            return JavaScriptTypes.NumberArrayTypes.Any(
                a => a == node.IdentifierStr
            );
        }
    }
}
