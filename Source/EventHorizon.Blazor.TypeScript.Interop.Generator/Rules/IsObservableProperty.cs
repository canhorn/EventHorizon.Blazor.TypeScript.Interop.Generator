using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsObservableProperty
        : IRule
    {
        public bool Check(Node node)
        {
            // Check the Response
            if (IsCorrectResponseType(node.OfKind(SyntaxKind.TypeReference).FirstOrDefault()))
            {
                return true;
            }
            // Check the 

            return false;
        }

        private static bool IsCorrectResponseType(Node node)
        {
            if (node == null)
            {
                return false;
            }
            var responseType = node.IdentifierStr;
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
            return responseType == JavaScriptTypes.Observable;
        }
    }
}
