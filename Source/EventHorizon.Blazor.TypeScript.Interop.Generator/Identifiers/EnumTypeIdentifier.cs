namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

public interface IEnumTypeIdentifier
{
    bool Identify(string identifierString, AbstractSyntaxTree ast);
}

public static class EnumTypeIdentifier
{
    private static readonly EnumTypeIdentifierCached CACHED = new();
    private static readonly EnumTypeIdentifierNotCached NOT_CACHED = new();
    private static IEnumTypeIdentifier ACTIVE = CACHED;

    public static void DisableCache()
    {
        ACTIVE = NOT_CACHED;
    }

    public static bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        return ACTIVE.Identify(identifierString, ast);
    }
}

public class EnumTypeIdentifierNotCached : IEnumTypeIdentifier
{
    public virtual bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        var hasEnumDeclarations = ast
            .RootNode.OfKind(SyntaxKind.EnumDeclaration)
            .Any(child => child.IdentifierStr == identifierString);
        return hasEnumDeclarations;
    }
}

public class EnumTypeIdentifierCached : EnumTypeIdentifierNotCached
{
    private bool _isCachedSetup;
    private readonly List<string> _cache = new List<string>();

    public override bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        if (!_isCachedSetup)
        {
            var declarations = ast.RootNode.OfKind(SyntaxKind.EnumDeclaration);
            foreach (var declaration in declarations)
            {
                _cache.Add(declaration.IdentifierStr);
            }
            _isCachedSetup = true;
        }
        return _cache.Contains(identifierString);
    }
}
