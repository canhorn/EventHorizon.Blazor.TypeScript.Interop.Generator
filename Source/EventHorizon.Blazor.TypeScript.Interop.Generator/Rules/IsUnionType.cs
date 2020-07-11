using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsUnionType
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            return node.OfKind(SyntaxKind.UnionType).Any();
        }
    }
}