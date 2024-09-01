namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using Sdcb.TypeScript.TsTypes;
using GenNode = Api.Node;

public class SdcbNode : GenNode
{
    private readonly INode _node;

    public SdcbNode(INode node)
    {
        ArgumentNullException.ThrowIfNull(node);

        _node = node;
    }

    private GenNode _parent;
    public GenNode Parent => _parent ??= _node.Parent is null ? null : new SdcbNode(_node.Parent);

    private GenNode _first;
    public GenNode First => _first ??= _node.First is null ? null : new SdcbNode(_node.First);

    private GenNode _last;
    public GenNode Last => _last ??= _node.Last is null ? null : new SdcbNode(_node.Last);

    public string IdentifierStr
    {
        get
        {
            if (_node is Node node)
            {
                return node.IdentifierStr;
            }
            return null;
        }
    }

    private string _kind;
    public string Kind => _kind ??= Enum.GetName(_node.Kind);

    private List<GenNode> _modifiers;
    public List<GenNode> Modifiers =>
        _modifiers ??= _node.Modifiers?.Select(a => new SdcbNode(a)).OfType<GenNode>().ToList();

    #region Parameter Declarations
    private GenNode _type;
    public GenNode Type
    {
        get
        {
            if (_type is null && _node is ParameterDeclaration parameterDeclaration)
            {
                _type = new SdcbNode(
                    parameterDeclaration.Type
                        ?? parameterDeclaration.Parent.Children.FirstOrDefault(a =>
                            a.Kind == SyntaxKind.TypeParameter
                            && a.IdentifierStr == parameterDeclaration.IdentifierStr
                        ) as INode
                );
            }

            return _type;
        }
    }
    #endregion

    #region TypeReferenceNode ExpressionWithTypeArguments
    private List<GenNode> _typeArguments;
    public List<GenNode> TypeArguments
    {
        get
        {
            if (_typeArguments is null && _node is TypeReferenceNode typeReferenceNode)
            {
                _typeArguments = typeReferenceNode
                    .TypeArguments?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            else if (
                _typeArguments is null
                && _node is ExpressionWithTypeArguments expressionWithTypeArguments
            )
            {
                _typeArguments = expressionWithTypeArguments
                    .TypeArguments?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            return _typeArguments;
        }
    }
    #endregion

    #region ClassDeclaration, InterfaceDeclaration, MethodDeclaration
    private List<GenNode> _typeParameters;
    public List<GenNode> TypeParameters
    {
        get
        {
            if (_typeParameters is null && _node is ClassDeclaration classDeclaration)
            {
                _typeParameters = classDeclaration
                    .TypeParameters?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            else if (_typeParameters is null && _node is InterfaceDeclaration interfaceDeclaration)
            {
                _typeParameters = interfaceDeclaration
                    .TypeParameters?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            else if (_typeParameters is null && _node is MethodDeclaration methodDeclaration)
            {
                _typeParameters = methodDeclaration
                    .TypeParameters?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            else if (_typeParameters is null && _node is MethodSignature methodSignature)
            {
                _typeParameters = methodSignature
                    .TypeParameters?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            else if (_typeParameters is null && _node is TypeAliasDeclaration typeAliasDeclaration)
            {
                _typeParameters = typeAliasDeclaration
                    .TypeParameters?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }

            return _typeParameters;
        }
    }
    #endregion

    #region ClassDefinition
    private List<GenNode> _heritageClauses;
    public List<GenNode> HeritageClauses
    {
        get
        {
            if (_heritageClauses is null && _node is ClassDeclaration classDeclaration)
            {
                _heritageClauses = classDeclaration
                    .HeritageClauses?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            return _heritageClauses;
        }
    }
    #endregion

    #region HeritageClause
    private List<GenNode> _types;
    public List<GenNode> Types
    {
        get
        {
            if (_types is null && _node is HeritageClause heritageClause)
            {
                _types = heritageClause
                    .Types?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            return _types;
        }
    }
    #endregion

    #region FunctionTypeNode
    private List<GenNode> _parameters;
    public List<GenNode> Parameters
    {
        get
        {
            if (_parameters is null && _node is FunctionTypeNode functionTypeNode)
            {
                _parameters = functionTypeNode
                    .Parameters?.Select(a => new SdcbNode(a))
                    .OfType<GenNode>()
                    .ToList();
            }
            return _parameters;
        }
    }
    #endregion

    private List<GenNode> _children;
    public List<GenNode> Children =>
        _children ??= _node.Children?.Select(a => new SdcbNode(a)).OfType<GenNode>().ToList();

    public List<GenNode> OfKind(string kind)
    {
        if (_node is Node node && Enum.TryParse<SyntaxKind>(kind, out var value))
        {
            return node.OfKind(value).Select(a => new SdcbNode(a)).OfType<GenNode>().ToList();
        }

        return [];
    }
}
