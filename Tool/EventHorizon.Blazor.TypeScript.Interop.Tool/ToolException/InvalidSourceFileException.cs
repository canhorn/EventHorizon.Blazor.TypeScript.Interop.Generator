using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHorizon.Blazor.TypeScript.Interop.Tool.ToolException
{
    [Serializable]
    public class InvalidSourceFileException : Exception
    {
        public InvalidSourceFileException(string message) 
            : base(message)
        {
        }
    }
}
