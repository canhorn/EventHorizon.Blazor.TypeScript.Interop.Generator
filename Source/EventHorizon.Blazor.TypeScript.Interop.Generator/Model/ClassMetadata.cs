using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model
{
    public class ClassMetadata
    {
        public string Name { get; internal set; }
        public IList<string> TypeIdentifier { get; internal set; }
    }
}
