namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using System.Collections.Generic;
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

    public class ImplementedInterfacesIdentifier
    {
        public static IList<TypeStatement> Identify(
            Node node,
            AbstractSyntaxTree ast,
            ClassMetadata classMetadata,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            var interfaces = new List<TypeStatement>();
            // Check if Class
            var interfaceCache = ast.RootNode.OfKind(
                SyntaxKind.InterfaceDeclaration
            );
            if (node.Kind == SyntaxKind.ClassDeclaration
                && node.HeritageClauses != null
                && node.HeritageClauses.Any())
            {
                foreach (var heritageClauses in node.HeritageClauses)
                {
                    foreach (var heritageClauseType in heritageClauses.Types)
                    {
                        var identifiers = heritageClauseType.OfKind(SyntaxKind.Identifier);
                        foreach (var identifier in identifiers)
                        {
                            var interfaceNode = interfaceCache.FirstOrDefault(
                                a => a.IdentifierStr == identifier.IdentifierStr
                            );
                            if (interfaceNode != null)
                            {
                                interfaces.Add(
                                    GenericTypeIdentifier.Identify(
                                        heritageClauseType,
                                        classMetadata,
                                        ast,
                                        typeOverrideDetails
                                    )
                                );
                                break;
                            }
                        }
                    }
                }
            }

            return interfaces;
        }
    }
}
