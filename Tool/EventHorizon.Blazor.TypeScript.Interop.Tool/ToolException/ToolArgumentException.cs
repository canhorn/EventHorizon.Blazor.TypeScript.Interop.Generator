using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHorizon.Blazor.TypeScript.Interop.Tool.ToolException
{
    [Serializable]
    public class ToolArgumentException : ArgumentException
    {
        public ToolArgumentException(string paramName, string message)
            : base(message, paramName)
        {
        }
    }
}
