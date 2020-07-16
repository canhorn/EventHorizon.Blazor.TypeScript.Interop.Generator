using System;
using System.Collections.Generic;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model
{
    public class GeneratedStatement
    {
        public ClassStatement ClassStatement { get; }
        public string GeneratedString { get; }

        public GeneratedStatement(
            ClassStatement classStatement,
            string generatedString
        )
        {
            ClassStatement = classStatement;
            GeneratedString = generatedString;
        }
    }
}
