using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public interface IAliasTypeIdentifier
    {
        bool Identify(
            string identifierString,
            TypeScriptAST ast
        );
    }
    public static class AliasTypeIdentifier
    {

        private static IAliasTypeIdentifier CACHED => new AliasTypeIdentifierCached();
        private static IAliasTypeIdentifier NOT_CACHED => new AliasTypeIdentifierNotCached();
        private static IAliasTypeIdentifier ACTIVE = CACHED;

        public static void DisableCache()
        {
            ACTIVE = NOT_CACHED;
        }

        public static bool Identify(
            Node node,
            TypeScriptAST ast
        )
        {
            return ACTIVE.Identify(
                node.IdentifierStr,
                ast
            );
        }
    }

    public class AliasTypeIdentifierNotCached
        : IAliasTypeIdentifier
    {
        public virtual bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            return ast.RootNode.OfKind(
                SyntaxKind.TypeAliasDeclaration
            ).Any(
                child => child.IdentifierStr == identifierString
                    && child.IdentifierStr != JavaScriptTypes.Nullable
            );
        }
    }

    public class AliasTypeIdentifierCached
        : AliasTypeIdentifierNotCached
    {
        private bool _isCachedSetup;
        private readonly List<string> _cache = new List<string>();

        public override bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            if (!_isCachedSetup)
            {
                var types = ast.RootNode.OfKind(
                    SyntaxKind.TypeAliasDeclaration
                );

                foreach (var type in types)
                {
                    if (type.IdentifierStr != JavaScriptTypes.Nullable)
                    {
                        _cache.Add(type.IdentifierStr);
                    }
                }

                _isCachedSetup = true;
            }
            return _cache.Contains(identifierString);
        }
    }
}
