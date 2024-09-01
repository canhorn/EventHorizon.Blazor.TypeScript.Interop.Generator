namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

public static class NodeIdentifier
{
    public static (bool found, string className, Node toGenerateNode) GetNode(
        string classIdentifier,
        AbstractSyntaxTree ast
    )
    {
        var className = DotNetClassNormalizer.Denormalize(classIdentifier);

        var toGenerateNode = GetClassDeclarationList(ast)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        toGenerateNode = GetInterfaceDeclarationList(ast)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        toGenerateNode = GetTypeAliasDeclarationList(ast)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        toGenerateNode = GetVariableDeclarationList(ast)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        return (false, className, toGenerateNode);
    }

    public static (bool found, string className, Node toGenerateNode) GetTypeQueryNode(
        string classIdentifier,
        AbstractSyntaxTree ast
    )
    {
        var (found, className, toGenerateNode) = GetNode(classIdentifier, ast);
        if (found)
        {
            return (found, className, toGenerateNode);
        }

        toGenerateNode = GetFunctionDeclarationList(ast)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        return (false, className, toGenerateNode);
    }

    private static List<Node> ClassDeclarationCache;

    [ExcludeFromCodeCoverage]
    private static List<Node> GetClassDeclarationList(AbstractSyntaxTree ast)
    {
        if (GenerateSource.CacheEnabled && ClassDeclarationCache is not null)
        {
            return ClassDeclarationCache;
        }
        var classDeclarationCache = ast.OfKind(SyntaxKind.ClassDeclaration).ToList();
        if (GenerateSource.CacheEnabled)
        {
            ClassDeclarationCache = classDeclarationCache;
        }

        return classDeclarationCache;
    }

    private static List<Node> InterfaceDeclarationCache;

    [ExcludeFromCodeCoverage]
    private static List<Node> GetInterfaceDeclarationList(AbstractSyntaxTree ast)
    {
        if (GenerateSource.CacheEnabled && InterfaceDeclarationCache is not null)
        {
            return InterfaceDeclarationCache;
        }
        var interfaceDeclarationCache = ast.OfKind(SyntaxKind.InterfaceDeclaration).ToList();
        if (GenerateSource.CacheEnabled)
        {
            InterfaceDeclarationCache = interfaceDeclarationCache;
        }

        return interfaceDeclarationCache;
    }

    private static List<Node> TypeAliasDeclarationCache;

    [ExcludeFromCodeCoverage]
    private static List<Node> GetTypeAliasDeclarationList(AbstractSyntaxTree ast)
    {
        if (GenerateSource.CacheEnabled && TypeAliasDeclarationCache is not null)
        {
            return TypeAliasDeclarationCache;
        }
        var typeAliasDeclarationCache = ast.OfKind(SyntaxKind.TypeAliasDeclaration).ToList();
        if (GenerateSource.CacheEnabled)
        {
            TypeAliasDeclarationCache = typeAliasDeclarationCache;
        }

        return typeAliasDeclarationCache;
    }

    private static List<Node> VariableDeclarationCache;

    [ExcludeFromCodeCoverage]
    private static List<Node> GetVariableDeclarationList(AbstractSyntaxTree ast)
    {
        if (GenerateSource.CacheEnabled && VariableDeclarationCache is not null)
        {
            return VariableDeclarationCache;
        }
        var variableDeclarationCache = ast.OfKind(SyntaxKind.VariableDeclaration).ToList();
        if (GenerateSource.CacheEnabled)
        {
            VariableDeclarationCache = variableDeclarationCache;
        }

        return variableDeclarationCache;
    }

    private static List<Node> FunctionDeclarationCache;

    [ExcludeFromCodeCoverage]
    private static List<Node> GetFunctionDeclarationList(AbstractSyntaxTree ast)
    {
        if (GenerateSource.CacheEnabled && FunctionDeclarationCache is not null)
        {
            return FunctionDeclarationCache;
        }
        var functionDeclarationCache = ast.OfKind(SyntaxKind.FunctionDeclaration).ToList();
        if (GenerateSource.CacheEnabled)
        {
            FunctionDeclarationCache = functionDeclarationCache;
        }

        return functionDeclarationCache;
    }
}
