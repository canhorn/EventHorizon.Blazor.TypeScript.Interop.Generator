using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsArrayResponseType
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
            if (node.Last.Kind == SyntaxKind.ArrayType
                || JavaScriptTypes.AllArrayTypes.Any(
                    a => a == node.Last.IdentifierStr
                )
            )
            {
                return true;
            }
            if (node.Last.Kind == SyntaxKind.TypeReference)
            {
                return Check(node.Last);
            }

            return false;
        }
    }
}
