namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model;

using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using Microsoft.CodeAnalysis;

public class NodeJS_Node : Node
{
    private readonly ASTNode _node;

    public NodeJS_Node(
        ASTNode node,
        Node parent = null,
        bool typeReference = false,
        string overrideKind = null,
        ASTNode typeParameters = null
    )
    {
        var children = new List<Node>();
        var modifiers = new List<Node>();
        var heritageClauses = new List<Node>();
        // Look at moving all this logic into ad/hoc caching from the getters
        _node = node;
        IdentifierStr = node.Key?.Name;
        if (IdentifierStr == "constructor")
        {
            IdentifierStr = null;
        }
        if (node.Id is not null)
        {
            IdentifierStr = node.Id.Name;
        }
        if (node.Name is not null)
        {
            IdentifierStr = node.Name;
        }
        if (node.TypeName is not null)
        {
            IdentifierStr = node.TypeName.Name ?? node.TypeName.Right.Name;
        }
        if (node.Expression is not null)
        {
            if (node.Expression.Type == "Identifier")
            {
                IdentifierStr = node.Expression.Name;
            }
            else
            {
                children.Add(new NodeJS_Node(node.Expression));
            }
        }
        if (node.Left is not null)
        {
            children.Add(new NodeJS_Node(node.Left, parent: this));
        }
        if (node.Right is not null)
        {
            children.Add(new NodeJS_Node(node.Right, parent: this));
        }
        if (node.ExprName is not null)
        {
            var exprNode = new NodeJS_Node(node.ExprName, parent: this);
            children.Add(exprNode);
            IdentifierStr = exprNode.IdentifierStr;
        }
        Parent = parent;

        if (node.TypeName is not null)
        {
            if (node.TypeName.Left is not null)
            {
                children.Add(new NodeJS_Node(SyntaxKind.Identifier, node.TypeName.Left.Name, this));
            }
            if (node.TypeName.Right is not null)
            {
                children.Add(
                    new NodeJS_Node(SyntaxKind.Identifier, node.TypeName.Right.Name, this)
                );
            }
        }

        // Declaration
        if (node.Declaration is not null)
        {
            children.Add(new NodeJS_Node(node.Declaration, this));
        }
        // Body as Node
        if (node.BodyNode is not null)
        {
            var bodyNode = new NodeJS_Node(node.BodyNode, this);
            if (bodyNode.Kind == SyntaxKind.ModuleDeclaration)
            {
                children.Add(bodyNode);
            }
            else
            {
                var bodyNodeChildren = new NodeJS_Node(
                    node.BodyNode,
                    this
                ).Children.Cast<NodeJS_Node>();
                foreach (var child in bodyNodeChildren)
                {
                    child.Parent = this;
                    children.Add(child);
                }
            }
        }
        // Body as Array
        if (node.BodyArray is not null)
        {
            var bodyArrayChildren = node.BodyArray.Select(a => new NodeJS_Node(a, this));
            foreach (var bodyNode in bodyArrayChildren)
            {
                children.Add(bodyNode);
            }
        }

        Kind = overrideKind ?? NodeJSTypeMapper.NodeJSTypeToSyntaxKind(node.Type, node.Kind);

        //if (!string.IsNullOrWhiteSpace(
        //    node.Accessibility
        //))
        //{
        //    var modiferKind = default(string);
        //    switch (node.Accessibility)
        //    {
        //        case "protected":
        //            modiferKind = SyntaxKind.ProtectedKeyword;
        //            break;
        //        case "private":
        //            modiferKind = SyntaxKind.PrivateKeyword;
        //            break;
        //        default:
        //            modiferKind = node.Accessibility;
        //            break;
        //    }
        //    modifiers.Add(
        //        new NodeJS_Node(
        //            NodeJSTypeMapper.NodeJSTypeToSyntaxKind(
        //                modiferKind,
        //                null
        //            ),
        //            this
        //        )
        //    );
        //}

        if (node.Static ?? false)
        {
            children.Add(new NodeJS_Node(SyntaxKind.StaticKeyword, this));
        }
        if (node.Readonly ?? false)
        {
            children.Add(new NodeJS_Node(SyntaxKind.ReadonlyKeyword, this));
        }
        if (node.Optional ?? false)
        {
            children.Add(new NodeJS_Node(SyntaxKind.QuestionToken, this));
        }

        if (!typeReference && IdentifierStr is not null)
        {
            children.Add(new NodeJS_Node(SyntaxKind.Identifier, IdentifierStr, this));
        }

        if (node.SuperClass is not null)
        {
            var superClassNode = new NodeJS_Node(
                node.SuperClass,
                typeParameters: node.SuperTypeParameters,
                parent: this
            );

            heritageClauses.Add(new NodeJS_Node(types: new List<Node> { superClassNode }, this));
        }
        if (node.Object is not null)
        {
            children.Add(new NodeJS_Node(SyntaxKind.Identifier, node.Object.Name, this));
        }
        if (node.Property is not null)
        {
            children.Add(new NodeJS_Node(SyntaxKind.Identifier, node.Property.Name, this));
        }

        if (node.ObjectType is not null)
        {
            children.Add(new NodeJS_Node(node.ObjectType, this));
        }

        if (node.IndexType is not null)
        {
            children.Add(new NodeJS_Node(node.IndexType, this));
        }

        if (node.Implements is not null)
        {
            foreach (var implementation in node.Implements)
            {
                var interfaceNode = new NodeJS_Node(implementation, parent: this);
                heritageClauses.Add(new NodeJS_Node(types: new List<Node> { interfaceNode }, this));
            }
        }
        if (heritageClauses.Any())
        {
            HeritageClauses = heritageClauses;
        }

        if (node.TypeAnnotation is not null && node.TypeAnnotation.Type != "TSTypeAnnotation")
        {
            var type = new NodeJS_Node(node.TypeAnnotation, parent: this);
            children.Add(type);
        }

        if (node.Params is not null)
        {
            Types = node.Params.Select(paramNode => new NodeJS_Node(
                paramNode,
                parent: this,
                overrideKind: SyntaxKind.Parameter
            ));
            children.AddRange(Types);
        }

        if (node.Parameters is not null)
        {
            Parameters = node.Parameters.Select(paramNode => new NodeJS_Node(
                paramNode,
                parent: this,
                overrideKind: SyntaxKind.Parameter
            ));
            children.AddRange(Parameters);
        }

        if (node.TypeParameters is not null)
        {
            var types = node.TypeParameters.Params.Select(a => new NodeJS_Node(a, parent: this));
            if (types.Any(a => a.Kind == SyntaxKind.TypeParameter))
            {
                TypeParameters = types;
            }
            else
            {
                TypeArguments = types;
            }
            children.AddRange(types);
        }

        if (typeParameters is not null)
        {
            var types = typeParameters.Params.Select(a => new NodeJS_Node(a, parent: this));
            TypeArguments = types;
            children.AddRange(types);
        }

        if (node.ElementTypes is not null)
        {
            var types = node.ElementTypes.Select(a => new NodeJS_Node(a, parent: this));
            //TypeArguments = types;
            children.AddRange(types);
        }

        if (node.Types is not null)
        {
            children.AddRange(node.Types.Select(a => new NodeJS_Node(a, this)));
        }

        if (node.ElementType is not null)
        {
            ElementType = new NodeJS_Node(node.ElementType, this);
            children.Add(ElementType);
        }

        if (node.Members is not null)
        {
            // TODO: Members are on Object Literals, not currently used by framework
            //Members = typeAnnotation.Members.Select(
            //    a => new NodeJS_Node(a)
            //);
        }

        if (node.TypeAnnotation is not null && node.TypeAnnotation.Type == "TSTypeAnnotation")
        {
            var type = new NodeJS_Node(node.TypeAnnotation.TypeAnnotation, parent: this);
            if (Kind == SyntaxKind.Parameter)
            {
                Type = type;
            }
            children.Add(type);
        }

        if (node.ReturnType is not null)
        {
            children.Add(new NodeJS_Node(node.ReturnType.TypeAnnotation, parent: this));
        }

        Children = children.ToList();
        Modifiers = modifiers.ToList();
    }

    public NodeJS_Node(Program program)
    {
        Kind = "Program";
        Children = program.Body.Select(a => new NodeJS_Node(a, this)).ToList();
    }

    public NodeJS_Node(string kind, string name, Node parent)
    {
        Kind = kind;
        IdentifierStr = name;
        Parent = parent;
        Children = new List<Node>();
    }

    public NodeJS_Node(IdentifierModel identifier, Node parent)
    {
        var children = new List<Node>();
        Kind = identifier.Type;
        Parent = parent;

        // Get Last Node
        var leftNode = identifier.Left?.Right;
        if (leftNode is not null)
        {
            children.Add(new NodeJS_Node(leftNode, parent: this));
        }
        var rightNode = identifier.Right;
        if (rightNode is not null)
        {
            children.Add(new NodeJS_Node(rightNode, parent: this));
        }

        IdentifierStr = rightNode?.Name ?? identifier.Name;

        Children = children;
    }

    public NodeJS_Node(string kind, Node parent)
    {
        Kind = kind;
        Parent = parent;
        Children = new List<Node>();
    }

    public NodeJS_Node(List<Node> types, Node parent)
    {
        Types = types;
        Children = types;
        Parent = parent;
    }

    public string IdentifierStr { get; }
    public Node Parent { get; set; }
    public Node First => Children?.FirstOrDefault();
    public Node Last => Children?.LastOrDefault();
    public string Kind { get; }
    public IEnumerable<Node> Modifiers { get; }
    public Node Type { get; }
    public Node ElementType { get; }
    public IEnumerable<Node> TypeParameters { get; }
    public IEnumerable<Node> HeritageClauses { get; }
    public IEnumerable<Node> Types { get; }
    public IEnumerable<Node> TypeArguments { get; }
    public IEnumerable<Node> Parameters { get; }

    public IEnumerable<Node> Children { get; init; }

    public IEnumerable<Node> OfKind(string kind)
    {
        var list = new List<Node>();
        foreach (var child in Children)
        {
            if (child.Kind == kind)
            {
                list.Add(child);
            }
            list.AddRange(child.OfKind(kind));
        }
        return list;
    }
}

public static class NodeJSTypeMapper
{
    public static string NodeJSTypeToSyntaxKind(string type, string kind)
    {
        if (type == "TSDeclareMethod" && !string.IsNullOrWhiteSpace(kind))
        {
            switch (kind)
            {
                case "method":
                    return SyntaxKind.MethodDeclaration;
                case "constructor":
                    return SyntaxKind.Constructor;
                case "get":
                    return SyntaxKind.GetAccessor;
                case "set":
                    return SyntaxKind.SetAccessor;
                default:
                    break;
            }
        }

        switch (type)
        {
            case "TSModuleDeclaration":
                return SyntaxKind.ModuleDeclaration;
            case "TSInterfaceDeclaration":
                return SyntaxKind.InterfaceDeclaration;
            case "TSEnumDeclaration":
                return SyntaxKind.EnumDeclaration;
            //case "Constructor": return SyntaxKind.Constructor;
            case "ClassProperty":
                return SyntaxKind.PropertyDeclaration;
            case "TSPropertySignature":
                return SyntaxKind.PropertySignature;
            case "TSDeclareMethod":
                return SyntaxKind.MethodDeclaration;
            case "TSMethodSignature":
                return SyntaxKind.MethodSignature;

            case "TSTypeAliasDeclaration":
                return SyntaxKind.TypeAliasDeclaration;

            case "TSTypeReference":
                return SyntaxKind.TypeReference;
            case "TSArrayType":
                return SyntaxKind.ArrayType;
            case "TSUnionType":
                return SyntaxKind.UnionType;
            case "TSParenthesizedType":
                return SyntaxKind.ParenthesizedType;
            case "TSFunctionType":
                return SyntaxKind.FunctionType;
            case "TSStringKeyword":
                return SyntaxKind.StringKeyword;
            case "TSVoidKeyword":
                return SyntaxKind.VoidKeyword;
            case "TSBooleanKeyword":
                return SyntaxKind.BooleanKeyword;
            case "TSNumberKeyword":
                return SyntaxKind.NumberKeyword;
            case "TSObjectKeyword":
                return SyntaxKind.ObjectKeyword;
            //case "StaticKeyword": return SyntaxKind.StaticKeyword;
            //case "ReadonlyKeyword": return SyntaxKind.ReadonlyKeyword;
            //case "LiteralType": return SyntaxKind.LiteralType;
            //case "TSTypeLiteral": return SyntaxKind.TypeLiteral;
            case "TSTypeLiteral":
                return SyntaxKind.TypeLiteral;
            case "TSNullKeyword":
                return SyntaxKind.NullKeyword;
            case "TSUndefinedKeyword":
                return SyntaxKind.UndefinedKeyword;
            case "TSAnyKeyword":
                return SyntaxKind.AnyKeyword;
            case "TSThisType":
                return SyntaxKind.ThisType;
            case "TSTypeParameter":
                return SyntaxKind.TypeParameter;
            case "TSTypeQuery":
                return SyntaxKind.TypeQuery;
            default:
                return type;
        }
        ;
    }
}
