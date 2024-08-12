namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;

public class ThisTypeIdentifier
{
    public static bool Identify(Node node)
    {
        return node.Kind == SyntaxKind.ThisType;
    }
}
