namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public interface IInterfaceResponseTypeIdentifier
{
    bool Identify(string identifierString, AbstractSyntaxTree ast);
    bool Identify(TypeStatement type, AbstractSyntaxTree ast);
}

public static class InterfaceResponseTypeIdentifier
{
    private static readonly InterfaceResponseTypeIdentifierCached CACHED = new();
    private static readonly InterfaceResponseTypeIdentifierNotCached NOT_CACHED = new();
    private static IInterfaceResponseTypeIdentifier ACTIVE = CACHED;

    public static void DisableCache()
    {
        ACTIVE = NOT_CACHED;
    }

    public static bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        return ACTIVE.Identify(identifierString, ast);
    }

    public static bool Identify(TypeStatement type, AbstractSyntaxTree ast)
    {
        return ACTIVE.Identify(type, ast);
    }
}

public class InterfaceResponseTypeIdentifierNotCached : IInterfaceResponseTypeIdentifier
{
    public virtual bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        var hasClassDeclarations = ast
            .RootNode.OfKind(SyntaxKind.ClassDeclaration)
            .Any(child => child.IdentifierStr == identifierString);
        var response =
            !hasClassDeclarations
            && ast.RootNode.OfKind(SyntaxKind.InterfaceDeclaration)
                .Any(child => child.IdentifierStr == identifierString);
        return response;
    }

    public virtual bool Identify(TypeStatement type, AbstractSyntaxTree ast)
    {
        var identifierString = type.Name;
        if (type.IsModifier || type.IsArray || type.IsNullable)
        {
            if (type.GenericTypes.Any())
            {
                identifierString = type.GenericTypes.First().Name;
            }
        }
        return Identify(identifierString, ast);
    }
}

public class InterfaceResponseTypeIdentifierCached : InterfaceResponseTypeIdentifierNotCached
{
    private bool _isCachedSetup;
    private readonly List<string> _cacheClassDeclaration = new List<string>();
    private readonly List<string> _cacheInterfaceDeclaration = new List<string>();

    public override bool Identify(string identifierString, AbstractSyntaxTree ast)
    {
        if (!_isCachedSetup)
        {
            var classDeclarations = ast.RootNode.OfKind(SyntaxKind.ClassDeclaration);
            foreach (var classDeclaration in classDeclarations)
            {
                _cacheClassDeclaration.Add(classDeclaration.IdentifierStr);
            }
            var interfaceDeclarations = ast.RootNode.OfKind(SyntaxKind.InterfaceDeclaration);
            foreach (var interfaceDeclaration in interfaceDeclarations)
            {
                _cacheInterfaceDeclaration.Add(interfaceDeclaration.IdentifierStr);
            }
            _isCachedSetup = true;
        }
        return !_cacheClassDeclaration.Contains(identifierString)
            && _cacheInterfaceDeclaration.Contains(identifierString);
    }

    public override bool Identify(TypeStatement type, AbstractSyntaxTree ast)
    {
        return base.Identify(type, ast);
    }
}
