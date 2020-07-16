using System.Collections.Generic;
using System.Linq;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements
{
    public class ConstructorStatement
    {
        public bool NeedsInvokableReference { get; set; }
        public IList<ArgumentStatement> Arguments { get; set; } = new List<ArgumentStatement>();

        public override string ToString()
        {
            var args = string.Join(", ", Arguments.Select(a => a.ToString()));
            var invokableReference = NeedsInvokableReference
                ? "_invokableReference = Create(this);"
                : string.Empty;
            return $"constructor({args}){{ {invokableReference} }}";
        }
    }
}