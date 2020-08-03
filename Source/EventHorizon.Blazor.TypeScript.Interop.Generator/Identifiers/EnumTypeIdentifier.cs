using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public interface IEnumTypeIdentifier
    {
        bool Identify(
            string identifierString,
            TypeScriptAST ast
        );
    }

    public static class EnumTypeIdentifier
    {

        private static IEnumTypeIdentifier CACHED = new EnumTypeIdentifierCached();
        private static IEnumTypeIdentifier NOT_CACHED = new EnumTypeIdentifierNotCached();
        private static IEnumTypeIdentifier ACTIVE = CACHED;

        public static void DisableCache()
        {
            ACTIVE = NOT_CACHED;
        }

        public static bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            return ACTIVE.Identify(
                identifierString,
                ast
            );
        }
    }

    public class EnumTypeIdentifierNotCached
        : IEnumTypeIdentifier
    {
        public virtual bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            var hasEnumDeclarations = ast.RootNode.OfKind(
                SyntaxKind.EnumDeclaration
            ).Any(
                child => child.IdentifierStr == identifierString
            );
            return hasEnumDeclarations;
        }
    }

    public class EnumTypeIdentifierCached
        : EnumTypeIdentifierNotCached
    {
        private readonly Dictionary<string, bool> _cache = new Dictionary<string, bool>();

        public override bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            if (_cache.TryGetValue(identifierString, out var value))
            {
                return value;
            }
            var response = base.Identify(
                identifierString,
                ast
            );
            if (identifierString != null)
            {
                _cache[identifierString] = response;
            }
            return response;
        }
    }
}
