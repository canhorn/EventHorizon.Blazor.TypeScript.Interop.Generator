using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class TypeParameterIdentifier
    {
        internal static IList<string> Identify(
            Node node
        )
        {
            var list = default(IList<string>);
            if (node is ClassDeclaration classDeclaration)
            {
                list = classDeclaration
                    .TypeParameters
                    ?.Select(
                        typeParam => typeParam.IdentifierStr
                    ).ToList();
            }
            if (node is InterfaceDeclaration interfaceDeclaration)
            {
                list = interfaceDeclaration
                    .TypeParameters
                    ?.Select(
                        typeParam => typeParam.IdentifierStr
                    ).ToList();
            }
            if (node is MethodDeclaration methodDeclaration)
            {
                list = methodDeclaration
                    .TypeParameters
                    ?.Select(
                        typeParam => typeParam.IdentifierStr
                    ).ToList();
            }
            if (node is TypeReferenceNode typeReference)
            {
                list = typeReference
                    .TypeArguments
                    ?.Where(a => a is TypeReferenceNode)
                    .Cast<TypeReferenceNode>()
                    .Select(
                        typeParam => typeParam.IdentifierStr
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
