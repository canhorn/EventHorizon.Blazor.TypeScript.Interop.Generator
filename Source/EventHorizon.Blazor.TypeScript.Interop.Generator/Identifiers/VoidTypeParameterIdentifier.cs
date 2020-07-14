using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class VoidTypeParameterIdentifier
    {
        public static bool Identify(
            Node node,
            string typeAsString,
            out string voidType
        )
        {
            voidType = typeAsString;
            if (typeAsString == GenerationIdentifiedTypes.Unknown
                && node is MethodDeclaration methodNode
                && (methodNode.TypeParameters == null
                    || !methodNode.TypeParameters.Any()
                )
            )
            {
                voidType = GenerationIdentifiedTypes.Void;
                return true;
            }
            return false;
        }
    }
}
