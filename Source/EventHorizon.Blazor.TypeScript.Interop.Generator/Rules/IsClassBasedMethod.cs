namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

    class IsClassBasedMethod
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            if (node.IdentifierStr == JavaScriptTypes.Function)
            {
                return true;
            }

            return false;
        }
    }
}
