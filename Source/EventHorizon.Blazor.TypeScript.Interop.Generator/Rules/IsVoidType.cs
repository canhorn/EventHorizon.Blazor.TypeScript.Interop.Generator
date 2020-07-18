using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsVoidType
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            return node.Kind == SyntaxKind.VoidKeyword
                || !node.Children.Any();
        }
    }
}
