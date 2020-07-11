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
            if (node.Last == null)
            {
                return false;
            }
            var classId = node.Last.IdentifierStr;
            if (classId == JavaScriptTypes.Function)
            {
                return true;
            }

            return false;
        }
    }
}
