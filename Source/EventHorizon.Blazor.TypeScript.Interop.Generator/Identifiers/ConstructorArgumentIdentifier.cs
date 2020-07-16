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
        private static IList<ArgumentStatement> EMTPY = new List<ArgumentStatement>().AsReadOnly();
        internal static IList<ArgumentStatement> Identify(
            Node classDeclaration,
            ClassMetadata classMetadata
        )
        {
            var constructor = classDeclaration
                .OfKind(SyntaxKind.Constructor)
                .FirstOrDefault();
            if (constructor != null)
            {
                var list = ArgumentIdentifier.Identify(
                    constructor,
                    classMetadata
                );
                return ConvertActionToObject(
                    list
                );

            }

            return EMTPY;
        }

        private static IList<ArgumentStatement> ConvertActionToObject(
            IList<ArgumentStatement> list
        )
        {
            return list.Select(
                a =>
                {
                    if (a.Type == GenerationIdentifiedTypes.Action)
                    {
                        a.Type = GenerationIdentifiedTypes.Object;
                    }
                    return a;
                }
            ).ToList();
        }
    }
}
