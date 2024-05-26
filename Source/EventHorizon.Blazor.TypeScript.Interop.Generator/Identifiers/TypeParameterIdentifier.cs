namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using System.Collections.Generic;
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

    public class TypeParameterIdentifier
    {
        internal static IList<string> Identify(Node node)
        {
            var list = default(IList<string>);
            if (node.Kind == SyntaxKind.ClassDeclaration)
            {
                list = node.TypeParameters?.Select(typeParam => typeParam.IdentifierStr).ToList();
            }
            if (node.Kind == SyntaxKind.InterfaceDeclaration)
            {
                list = node.TypeParameters?.Select(typeParam => typeParam.IdentifierStr).ToList();
            }
            if (node.Kind == SyntaxKind.MethodDeclaration)
            {
                list = node.TypeParameters?.Select(typeParam => typeParam.IdentifierStr).ToList();
            }
            if (list == null)
            {
                return new List<string>();
            }
            return list;
        }
    }
}
