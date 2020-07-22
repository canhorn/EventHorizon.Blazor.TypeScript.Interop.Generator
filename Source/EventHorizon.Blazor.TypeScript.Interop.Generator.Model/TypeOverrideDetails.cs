using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model
{
    public class TypeOverrideDetails
    {
        public bool IsStatic { get; set; }
        public IDictionary<string, string> TypeOverrideMap { get; set; } = new Dictionary<string, string>();
    }
}
