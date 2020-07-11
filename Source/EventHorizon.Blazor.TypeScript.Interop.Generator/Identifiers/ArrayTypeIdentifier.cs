using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public static class ArrayTypeIdentifier
    {
        private static IRule IsArrayResponseTypeRule = new IsArrayResponseType();

        public static string Identify(
            Node node,
            ClassMetadata classMetadata
        )
        {
            if (IsArrayResponseTypeRule.Check(node))
            {
                if (!IsArrayResponseTypeRule.Check(node.Last))
                {
                    if (JavaScriptTypes.NumberArrayTypes.Any(
                        a => a == node.Last.IdentifierStr
                    ))
                    {
                        return GenerationIdentifiedTypes.Number;
                    }

                    return TypeIdentifier.Identify(
                        node.Last,
                        classMetadata,
                        TypeParameterIdentifier.Identify(node)
                    );
                }
                return Identify(
                    node.Last,
                    classMetadata
                );
            }
            return GenerationIdentifiedTypes.Object;
        }
    }
}
