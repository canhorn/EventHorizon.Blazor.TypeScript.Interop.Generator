using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsOptional
        : IRule
    {
        public bool Check(
            Node node
        )
        {
            var nodes = node.Children
                .Where(a => a.Kind != SyntaxKind.TypeLiteral);
            return nodes.Any(a => a.Kind == SyntaxKind.QuestionToken || a.OfKind(SyntaxKind.QuestionToken).Any())
                || nodes.Any(a => a.Kind == SyntaxKind.UndefinedKeyword || a.OfKind(SyntaxKind.UndefinedKeyword).Any())
                || nodes.Any(a => a.Kind == SyntaxKind.NullKeyword || a.OfKind(SyntaxKind.NullKeyword).Any());
        }
    }
}
