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
    public class ExtendedClassTypesIdentifier
    {
        public static TypeStatement Identify(
            Node node,
            TypeScriptAST ast,
            ClassMetadata classMetadata,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            // Check if Class
            var classesCache = ast.RootNode.OfKind(
                SyntaxKind.ClassDeclaration
            );
            if (node is ClassDeclaration classDeclaration
                && classDeclaration.HeritageClauses != null
                && classDeclaration.HeritageClauses.Any())
            {
                var herited = classDeclaration.HeritageClauses.First();
                if (herited != null)
                {
                    var identifiedClass = GenericTypeIdentifier.Identify(
                        herited.First,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    );
                    if (classesCache.Any(a => a.IdentifierStr == identifiedClass.Name))
                    {
                        return identifiedClass;
                    }
                }
            }

            return null;
        }
    }
}
