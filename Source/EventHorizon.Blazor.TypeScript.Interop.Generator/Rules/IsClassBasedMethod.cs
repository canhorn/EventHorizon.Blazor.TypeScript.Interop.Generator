using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    class IsClassBasedMethod
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            var classId = node.IdentifierStr;
            if (classId == JavaScriptTypes.Function)
            {
                return true;
            }

            return false;
        }
    }
}
