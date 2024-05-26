using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    public class TypeOverrideDeclarationIdentifier
    {
        public static string Identify(ClassMetadata classMetadata, bool isStatic, string name)
        {
            if (isStatic)
            {
                return $"{classMetadata.Namespace}.{classMetadata.Name} | static | {name}";
            }
            return $"{classMetadata.Namespace}.{classMetadata.Name} | {name}";
        }

        public static string IdentifyArgument(
            ClassMetadata classMetadata,
            bool isStatic,
            string methodNameOrConstructor,
            string argumentName
        )
        {
            if (isStatic)
            {
                return $"{classMetadata.Namespace}.{classMetadata.Name} | static | {methodNameOrConstructor} | {argumentName}";
            }
            return $"{classMetadata.Namespace}.{classMetadata.Name} | {methodNameOrConstructor} | {argumentName}";
        }
    }
}
