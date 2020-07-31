using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class ConstructorArgumentIdentifier
    {
        private static IList<ArgumentStatement> EMPTY = new List<ArgumentStatement>().AsReadOnly();
        internal static IList<ArgumentStatement> Identify(
            Node classDeclaration,
            ClassMetadata classMetadata,
            TypeScriptAST ast,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            var constructor = classDeclaration
                .OfKind(SyntaxKind.Constructor)
                .FirstOrDefault();
            if (constructor != null)
            {
                return ArgumentIdentifier.Identify(
                    constructor,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
            }

            return EMPTY;
        }

        private static IList<ArgumentStatement> ConvertActionToObject(
            IList<ArgumentStatement> list
        )
        {
            return list.Select(
                a =>
                {
                    if (a.Type.Name == GenerationIdentifiedTypes.Action)
                    {
                        a.Type.Name = GenerationIdentifiedTypes.CachedEntity;
                    }
                    return a;
                }
            ).ToList();
        }
    }
}
