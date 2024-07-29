namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public interface IAliasTypeIdentifier
{
    bool Identify(string identifierString, AbstractSyntaxTree ast);
}

public static class AliasTypeIdentifier
{
    private static readonly AliasTypeIdentifierCached CACHED = new();
    private static readonly AliasTypeIdentifierNotCached NOT_CACHED = new();
    private static IAliasTypeIdentifier ACTIVE = CACHED;

    public static void DisableCache()
    {
        ACTIVE = NOT_CACHED;
    }

    public static bool Identify(Node node, AbstractSyntaxTree ast)
    {
        return ACTIVE.Identify(node.IdentifierStr, ast);
    }
}

public class AliasTypeIdentifierNotCached : IAliasTypeIdentifier
{
    public virtual bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        return ast
            .RootNode.OfKind(SyntaxKind.TypeAliasDeclaration)
            .Any(child =>
                child.IdentifierStr == identifierString
                && child.IdentifierStr != JavaScriptTypes.Nullable
            );
    }
}

public class AliasTypeIdentifierCached : AliasTypeIdentifierNotCached
{
    private bool _isCachedSetup;
    private readonly List<string> _cache = new List<string>();

    public override bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        if (!_isCachedSetup)
        {
            var types = ast.RootNode.OfKind(SyntaxKind.TypeAliasDeclaration);

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
