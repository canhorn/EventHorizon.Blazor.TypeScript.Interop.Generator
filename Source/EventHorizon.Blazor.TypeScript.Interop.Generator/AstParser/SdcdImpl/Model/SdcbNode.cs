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

    private IEnumerable<GenNode> _modifiers;
    public IEnumerable<GenNode> Modifiers =>
        _modifiers ??= _node.Modifiers?.Select(a => new SdcbNode(a));

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

    #region ArrayTypeNode
    private GenNode _elementType;
    public GenNode ElementType
    {
        get
        {
            if (_elementType is null && _node is ArrayTypeNode parameterDeclaration)
            {
                _elementType = new SdcbNode(parameterDeclaration.ElementType);
            }
            return _elementType;
        }
    }
    #endregion

    #region TypeReferenceNode ExpressionWithTypeArguments
    private IEnumerable<GenNode> _typeArguments;
    public IEnumerable<GenNode> TypeArguments
    {
        get
        {
            if (_typeArguments is null && _node is TypeReferenceNode typeReferenceNode)
            {
                _typeArguments = typeReferenceNode.TypeArguments?.Select(a => new SdcbNode(a));
            }
            else if (
                _typeArguments is null
                && _node is ExpressionWithTypeArguments expressionWithTypeArguments
            )
            {
                _typeArguments = expressionWithTypeArguments.TypeArguments?.Select(
                    a => new SdcbNode(a)
                );
            }
            return _typeArguments;
        }
    }
    #endregion

    #region ClassDeclaration, InterfaceDeclaration, MethodDeclaration
    private IEnumerable<GenNode> _typeParameters;
    public IEnumerable<GenNode> TypeParameters
    {
        get
        {
            if (_typeParameters is null && _node is ClassDeclaration classDeclaration)
            {
                _typeParameters = classDeclaration.TypeParameters?.Select(a => new SdcbNode(a));
            }
            else if (_typeParameters is null && _node is InterfaceDeclaration interfaceDeclaration)
            {
                _typeParameters = interfaceDeclaration.TypeParameters?.Select(a => new SdcbNode(a));
            }
            else if (_typeParameters is null && _node is MethodDeclaration methodDeclaration)
            {
                _typeParameters = methodDeclaration.TypeParameters?.Select(a => new SdcbNode(a));
            }
            return _typeParameters;
        }
    }
    #endregion

    #region ClassDefinition
    private IEnumerable<GenNode> _heritageClauses;
    public IEnumerable<GenNode> HeritageClauses
    {
        get
        {
            if (_heritageClauses is null && _node is ClassDeclaration classDeclaration)
            {
                _heritageClauses = classDeclaration.HeritageClauses?.Select(a => new SdcbNode(a));
            }
            return _heritageClauses;
        }
    }
    #endregion

    #region HeritageClause
    private IEnumerable<GenNode> _types;
    public IEnumerable<GenNode> Types
    {
        get
        {
            if (_types is null && _node is HeritageClause heritageClause)
            {
                _types = heritageClause.Types?.Select(a => new SdcbNode(a));
            }
            return _types;
        }
    }
    #endregion

    #region FunctionTypeNode
    private IEnumerable<GenNode> _parameters;
    public IEnumerable<GenNode> Parameters
    {
        get
        {
            if (_parameters is null && _node is FunctionTypeNode functionTypeNode)
            {
                _parameters = functionTypeNode.Parameters?.Select(a => new SdcbNode(a));
            }
            return _parameters;
        }
    }
    #endregion

    private IEnumerable<GenNode> _children;
    public IEnumerable<GenNode> Children =>
        _children ??= _node.Children?.Select(a => new SdcbNode(a));

    public IEnumerable<GenNode> OfKind(string kind)
    {
        if (_node is Node node && Enum.TryParse<SyntaxKind>(kind, out var value))
        {
            return node.OfKind(value).Select(a => new SdcbNode(a));
        }

        return new List<GenNode>();
    }
}
