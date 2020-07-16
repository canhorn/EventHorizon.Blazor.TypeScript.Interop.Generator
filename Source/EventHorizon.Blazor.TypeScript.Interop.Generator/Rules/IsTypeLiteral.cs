using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsTypeLiteral
        : IRule
    {
        public bool Check(Node node)
        {
            // Check the Response
            if (IsCorrectResponseType(node))
            {
                return true;
            }
            // Check the 

            return false;
        }
        private static bool IsCorrectResponseType(Node node)
        {
            if (node.Children.Any())
            {
                foreach (var nodeChild in node.Children)
                {
                    if (IsCorrectResponseType(nodeChild))
                    {
                        return true;
                    }
                }
            }
            return node.Kind == SyntaxKind.TypeLiteral;
        }
    }
}
