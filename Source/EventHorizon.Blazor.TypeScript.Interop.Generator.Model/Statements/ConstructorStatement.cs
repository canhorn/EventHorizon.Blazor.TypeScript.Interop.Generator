using System.Collections.Generic;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
    public class ConstructorStatement
    {
        public bool NeedsInvokableReference { get; set; }
        public IList<ArgumentStatement> Arguments { get; set; } = new List<ArgumentStatement>();
    }
}