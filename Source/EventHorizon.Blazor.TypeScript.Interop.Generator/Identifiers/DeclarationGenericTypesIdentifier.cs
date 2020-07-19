using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class DeclarationGenericTypesIdentifier
    {
        public static IList<string> Identify(
            Node node
        )
        {
            var list = default(IList<string>);
            if (node is MethodDeclaration methodDeclaration)
            {
                list = methodDeclaration.TypeParameters
                    ?.Select(
                        a => a.IdentifierStr
                    ).ToList();
            }
            if (list == null)
            {
                return new List<string>();
            }
            return list;
        }
    }
}
