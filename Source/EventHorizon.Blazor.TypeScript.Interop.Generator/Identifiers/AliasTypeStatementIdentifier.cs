using System;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class AliasTypeStatementIdentifier
    {
        public static TypeStatement Identify(
            string typeIdentifier,
            ClassMetadata classMetadata,
            TypeScriptAST ast,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            // Get node from typeIdentifier
            var node = ast.RootNode.OfKind(
                SyntaxKind.TypeAliasDeclaration
            ).FirstOrDefault(
                child => child.IdentifierStr == typeIdentifier
            );
            if (node == null)
            {
                return null;
            }

            return GenericTypeIdentifier.Identify(
                node.Last,
                classMetadata,
                ast,
                typeOverrideDetails
            );
        }
    }
}
