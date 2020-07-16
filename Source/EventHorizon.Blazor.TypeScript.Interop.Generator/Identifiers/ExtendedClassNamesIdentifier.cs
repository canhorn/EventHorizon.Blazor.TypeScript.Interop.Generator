using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class ExtendedClassNamesIdentifier
    {
        public static IList<string> Identify(
            Node node,
            ITypeScriptAST ast
        )
        {
            var heritedList = node.Children.Where(
                child => child.Kind == SyntaxKind.HeritageClause
            ).Select(
                a => a.First.IdentifierStr
            ).ToList();
            // Check if interface
            var classes = ast.RootNode.OfKind(
                SyntaxKind.ClassDeclaration
            ).Where(
                a => heritedList.Any(b => b == a.IdentifierStr)
            ).Select(
                a => a.IdentifierStr
            ).Distinct().ToList();

            return classes;
        }
    }
}
