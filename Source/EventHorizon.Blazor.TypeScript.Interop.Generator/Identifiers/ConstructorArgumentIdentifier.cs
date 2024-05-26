namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using System.Collections.Generic;
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

    public static class ConstructorArgumentIdentifier
    {
        private static IList<ArgumentStatement> EMPTY => new List<ArgumentStatement>().AsReadOnly();

        internal static IList<ArgumentStatement> Identify(
            Node classDeclaration,
            ClassMetadata classMetadata,
            AbstractSyntaxTree ast,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            var constructor = classDeclaration.OfKind(SyntaxKind.Constructor).FirstOrDefault();
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
    }
}
