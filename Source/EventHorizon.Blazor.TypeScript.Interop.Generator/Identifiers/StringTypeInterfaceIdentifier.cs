using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class StringTypeInterfaceIdentifier
    {
        private static ConcurrentDictionary<string, bool> _cache = new ConcurrentDictionary<string, bool>();

        internal static bool Identify(
            TypeScriptAST ast,
            string idefntifierString
        )
        {
            if (_cache.TryGetValue(idefntifierString, out var value))
            {
                return value;
            }
            var hasClassDeclarations = ast.RootNode.OfKind(
                SyntaxKind.ClassDeclaration
            ).Any(
                child => child.IdentifierStr == idefntifierString
            );
            var response = !hasClassDeclarations && ast.RootNode.OfKind(
                SyntaxKind.InterfaceDeclaration
            ).Any(
                child => child.IdentifierStr == idefntifierString
            );
            if (idefntifierString != null)
            {
                _cache.AddOrUpdate(
                    idefntifierString,
                    response,
                    (_,__) => response
                );
            }
            return response;
        }
    }
}
