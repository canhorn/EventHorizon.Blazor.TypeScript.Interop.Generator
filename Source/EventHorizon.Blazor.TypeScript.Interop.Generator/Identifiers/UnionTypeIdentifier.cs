namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers
{
    using System.Linq;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

    public class UnionTypeIdentifier
    {
        private static IRule IsUnionTypeRule = new IsUnionType();

        internal static bool Identify(
            Node parameter,
            ClassMetadata classMetadata,
            AbstractSyntaxTree ast,
            TypeOverrideDetails typeOverrideDetails,
            out TypeStatement type
        )
        {
            type = new TypeStatement
            {
                Name = GenerationIdentifiedTypes.Unknown,
            };
            if (IsUnionTypeRule.Check(parameter))
            {
                var unionNode = parameter.OfKind(
                    SyntaxKind.UnionType
                ).FirstOrDefault()
                .Children.Where(
                    // Make sure does not contain undefined
                    a => a.Kind != SyntaxKind.UndefinedKeyword
                        && a.Kind != SyntaxKind.NullKeyword
                        && a.Kind != SyntaxKind.TypeLiteral
                        && a.Kind != SyntaxKind.LiteralType
                ).ToList().FirstOrDefault();

                if (unionNode != null)
                {
                    type = GenericTypeIdentifier.Identify(
                        unionNode,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    );
                }

                return true;
            }
            else if (parameter.Kind == SyntaxKind.UnionType)
            {
                type = GenericTypeIdentifier.Identify(
                    parameter.First,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
                return true;
            }
            return false;
        }
    }
}
