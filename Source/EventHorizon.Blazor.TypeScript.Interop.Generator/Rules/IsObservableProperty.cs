namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

    public class IsObservableProperty
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            // Check the Response
            if (IsCorrectResponseType(
                node.OfKind(
                    SyntaxKind.TypeReference
                ).FirstOrDefault()
            ))
            {
                return true;
            }
            // Check the 

            return false;
        }

        private static bool IsCorrectResponseType(
            Node node
        )
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
                    if (IsCorrectResponseType(
                        nodeChild
                    ))
                    {
                        return true;
                    }
                }
            }
            return responseType == JavaScriptTypes.Observable;
        }
    }
}
