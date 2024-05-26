namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer
{
    using System.Collections.Generic;

    public interface IWriter
    {
        void Write(IList<GeneratedStatement> generatedStatementList);
    }
}
