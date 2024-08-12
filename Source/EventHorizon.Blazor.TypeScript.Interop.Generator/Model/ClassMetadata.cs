using System.Collections.Generic;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

public class ClassMetadata
{
    public string Name { get; internal set; }
    public string Namespace { get; internal set; }
    public IList<TypeStatement> GenericTypes { get; internal set; }
}
