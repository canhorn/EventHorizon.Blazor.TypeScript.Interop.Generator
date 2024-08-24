namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

public static class ConstructorStatementIdentifier
{
    internal static ConstructorStatement Identify(
        Node classDeclaration,
        ClassStatement classStatement,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        return new ConstructorStatement
        {
            Arguments = ConstructorArgumentIdentifier.Identify(
                classDeclaration,
                classMetadata,
                ast,
                typeOverrideDetails
            ),
            NeedsInvokableReference = InvokableReferenceIdentifier.Identify(classStatement),
        };
    }
}
