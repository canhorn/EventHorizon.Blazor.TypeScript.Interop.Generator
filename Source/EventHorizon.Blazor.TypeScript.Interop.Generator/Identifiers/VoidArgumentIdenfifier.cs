namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

class VoidArgumentIdenfifier
{
    internal static bool Identify(IList<ArgumentStatement> arguments)
    {
        return arguments.Any(arg =>
            arg.Type.Name == GenerationIdentifiedTypes.Void
            || arg.Type.GenericTypes.Any(a => a.Name == GenerationIdentifiedTypes.Void)
        );
    }
}
