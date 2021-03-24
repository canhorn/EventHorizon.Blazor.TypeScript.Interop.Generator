namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using System;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

    public class TypeQueryIdentifier
    {
        public static TypeQueryStatement Identify(
            Node node,
            ClassMetadata classMetadata,
            AbstractSyntaxTree ast,
            TypeOverrideDetails typeOverrideDetails
        )
        {
            if (node.Kind != GenerationIdentifiedTypes.TypeQuery
                || node.First?.First == null)
            {
                return null;
            }
            var firstNode = node.First;

            return new TypeQueryStatement
            {
                Class = TypeIdentifier.Identify(
                    firstNode.First,
                    classMetadata
                ),
                Type = TypeIdentifier.Identify(
                    firstNode.Last,
                    classMetadata
                )
            };
        }
    }
}
