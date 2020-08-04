using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ImplementedInterfacesIdentifier
    {
        public static IList<TypeStatement> Identify(
            Node node,
            TypeScriptAST ast,
            ClassMetadata classMetadata,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            var interfaces = new List<TypeStatement>();
            // Check if Class
            var interfaceCache = ast.RootNode.OfKind(
                SyntaxKind.InterfaceDeclaration
            );
            if (node is ClassDeclaration classDeclaration
                && classDeclaration.HeritageClauses != null
                && classDeclaration.HeritageClauses.Any())
            {
                foreach (var heritageClauses in classDeclaration.HeritageClauses)
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
