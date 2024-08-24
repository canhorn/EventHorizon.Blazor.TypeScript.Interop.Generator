using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;

/// <summary>
/// Check for Arguments with an Action, this will need a callback of some kind.
/// If has an action/callback it will need a ReferenceIdentifier.
/// </summary>
class InvokableReferenceIdentifier
{
    internal static bool Identify(ClassStatement classStatement)
    {
        var methodArgumentUsedClasses = classStatement.PublicMethodStatements.Aggregate(
            new List<string>(),
            static (acc, method) =>

                [
                    .. acc,
                    .. method.Arguments.Aggregate(
                        new List<string>(),
                        (argAcc, arg) => [.. argAcc, arg.Type.Name]
                    ),
                ]
        );
        var constructorUsedClasses = classStatement.ConstructorStatement.Arguments.Aggregate(
            new List<string>(),
            (argAcc, arg) => [.. argAcc, arg.Type.Name]
        );
        var argumentUsedClasses = methodArgumentUsedClasses.Concat(constructorUsedClasses);

        return argumentUsedClasses.Any(a => a == GenerationIdentifiedTypes.Action);
    }
}
