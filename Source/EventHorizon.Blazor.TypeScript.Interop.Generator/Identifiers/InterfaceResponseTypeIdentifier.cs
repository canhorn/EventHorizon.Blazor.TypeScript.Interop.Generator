using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class InterfaceResponseTypeIdentifier
    {
        private static ConcurrentDictionary<string, bool> _cache = new ConcurrentDictionary<string, bool>();
        private static bool _cacheDisabled = false;

        public static void DisableCache()
        {
            _cacheDisabled = true;
        }

        public static bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            if (!_cacheDisabled && _cache.TryGetValue(identifierString, out var value))
            {
                return value;
            }
            var hasClassDeclarations = ast.RootNode.OfKind(
                SyntaxKind.ClassDeclaration
            ).Any(
                child => child.IdentifierStr == identifierString
            );
            var response = !hasClassDeclarations && ast.RootNode.OfKind(
                SyntaxKind.InterfaceDeclaration
            ).Any(
                child => child.IdentifierStr == identifierString
            );
            if (!_cacheDisabled && identifierString != null)
            {
                _cache.AddOrUpdate(
                    identifierString,
                    response,
                    (_, __) => response
                );
            }
            return response;
        }

        public static bool Identify(
            TypeStatement type,
            TypeScriptAST ast
        )
        {
            var identifierString = type.Name;
            if (type.IsModifier
                || type.IsArray
                || type.IsNullable
            )
            {
                if (type.GenericTypes.Any())
                {
                    identifierString = type.GenericTypes.First().Name;
                }
            }
            return Identify(
                identifierString,
                ast
            );
        }
    }
}
