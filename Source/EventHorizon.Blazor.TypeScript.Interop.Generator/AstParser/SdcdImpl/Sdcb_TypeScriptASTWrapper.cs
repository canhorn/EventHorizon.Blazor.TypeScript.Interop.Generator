namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;

using System;
using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl.Model;
using Sdcb_SyntaxKind = Sdcb.TypeScript.TsTypes.SyntaxKind;
using Sdcb_TypeScriptAST = Sdcb.TypeScript.TypeScriptAST;

public class Sdcb_TypeScriptASTWrapper : AbstractSyntaxTree
{
    private readonly Sdcb_TypeScriptAST _ast;

    public Sdcb_TypeScriptASTWrapper(string source)
    {
        _ast = new Sdcb_TypeScriptAST(source);
    }

    private Node _rootNode;
    public Node RootNode => _rootNode ??= new SdcbNode(_ast.RootNode) as Node;

    public IEnumerable<Node> OfKind(string kind)
    {
        if (Enum.TryParse<Sdcb_SyntaxKind>(kind, out var value))
        {
            return _ast.OfKind(value).Select(a => new SdcbNode(a));
        }

        return new List<Node>();
    }
}
