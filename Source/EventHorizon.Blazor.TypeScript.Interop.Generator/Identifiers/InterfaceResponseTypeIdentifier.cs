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
    public interface IInterfaceResponseTypeIdentifier
    {
        bool Identify(
            string identifierString,
            TypeScriptAST ast
        );
        bool Identify(
            TypeStatement type,
            TypeScriptAST ast
        );
    }
    public static class InterfaceResponseTypeIdentifier
    {

        private static IInterfaceResponseTypeIdentifier CACHED = new InterfaceResponseTypeIdentifierCached();
        private static IInterfaceResponseTypeIdentifier NOT_CACHED = new InterfaceResponseTypeIdentifierNotCached();
        private static IInterfaceResponseTypeIdentifier ACTIVE = CACHED;

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

        public static bool Identify(
            TypeStatement type,
            TypeScriptAST ast
        )
        {
            return ACTIVE.Identify(
                type,
                ast
            );
        }
    }

    public class InterfaceResponseTypeIdentifierNotCached
        : IInterfaceResponseTypeIdentifier
    {
        public virtual bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
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
            return response;
        }

        public virtual bool Identify(
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

    public class InterfaceResponseTypeIdentifierCached
        : InterfaceResponseTypeIdentifierNotCached
    {
        private bool _isCachedSetup;
        private readonly List<string> _cacheClassDeclaration = new List<string>();
        private readonly List<string> _cacheInterfaceDeclaration = new List<string>();

        public override bool Identify(
            string identifierString,
            TypeScriptAST ast
        )
        {
            if (!_isCachedSetup)
            {
                var classDeclarations = ast.RootNode.OfKind(
                    SyntaxKind.ClassDeclaration
                );
                foreach (var classDeclaration in classDeclarations)
                {
                    _cacheClassDeclaration.Add(classDeclaration.IdentifierStr);
                }
                var interfaceDeclarations = ast.RootNode.OfKind(
                    SyntaxKind.InterfaceDeclaration
                );
                foreach (var interfaceDeclaration in interfaceDeclarations)
                {
                    _cacheInterfaceDeclaration.Add(interfaceDeclaration.IdentifierStr);
                }
                _isCachedSetup = true;
            }
            return !_cacheClassDeclaration.Contains(identifierString)
                && _cacheInterfaceDeclaration.Contains(identifierString);
        }

        public override bool Identify(
            TypeStatement type,
            TypeScriptAST ast
        )
        {
            return base.Identify(
                type,
                ast
            );
        }
    }
}
