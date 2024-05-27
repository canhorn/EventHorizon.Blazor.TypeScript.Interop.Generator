using System;

namespace EventHorizon.Blazor.TypeScript.Interop.Tool.ToolException;

[Serializable]
public class InvalidSourceFileException : Exception
{
    public InvalidSourceFileException(string message)
        : base(message) { }
}
