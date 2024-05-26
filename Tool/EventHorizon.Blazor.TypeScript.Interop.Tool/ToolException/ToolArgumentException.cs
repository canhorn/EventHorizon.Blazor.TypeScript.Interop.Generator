using System;

namespace EventHorizon.Blazor.TypeScript.Interop.Tool.ToolException;

[Serializable]
public class ToolArgumentException : ArgumentException
{
    public ToolArgumentException(string paramName, string message)
        : base(message, paramName) { }
}
