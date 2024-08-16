namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model;

using System;
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
        // bool typeReference = false,
        string overrideKind = null,
        ASTNode typeParameters = null
    )
    {
        var children = new List<Node>();
        var modifiers = new List<Node>();
        var heritageClauses = new List<Node>();
        // Look at moving all this logic into ad/hoc caching from the getters
        _node = node;
        IdentifierStr = node?.Text ?? node?.EscapedText;
        if (node.Kind == TypeScriptSyntaxKind.Constructor)
        {
            IdentifierStr = null;
        }
        // if (node.Id is not null)
        // {
        //     IdentifierStr = node.Id.Name;
        // }
        if (node.Name is not null)
        {
            IdentifierStr = node.Name.Text ?? node.Name.EscapedText;
        }
        if (node.TypeName is not null)
        {
            IdentifierStr = node.TypeName.Text ?? node.TypeName.EscapedText;
        }
        if (node.Expression is not null)
        {
            // if (node.Expression.Kind == TypeScriptSyntaxKind.Identifier)
            // {
            //     IdentifierStr = node.Expression.Text ?? node.Expression.EscapedText;
            // }
            // else
            // {
            children.Add(new NodeJS_Node(node.Expression, parent: this));
            // }
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
            children.Add(new NodeJS_Node(node.TypeName, this));
            // if (node.TypeName.Left is not null)
            // {
            //     children.Add(new NodeJS_Node(node.TypeName.Left, this));
            // }
            // if (node.TypeName.Right is not null)
            // {
            //     children.Add(new NodeJS_Node(node.TypeName.Right, this));
            // }
        }

        // Declaration
        // if (node.Declaration is not null)
        // {
        //     children.Add(new NodeJS_Node(node.Declaration, this));
        // }
        // Body as Node
        // if (node.BodyNode is not null)
        // {
        //     var bodyNode = new NodeJS_Node(node.BodyNode, this);
        //     if (bodyNode.Kind == SyntaxKind.ModuleDeclaration)
        //     {
        //         children.Add(bodyNode);
        //     }
        //     else
        //     {
        //         var bodyNodeChildren = new NodeJS_Node(
        //             node.BodyNode,
        //             this
        //         ).Children.Cast<NodeJS_Node>();
        //         foreach (var child in bodyNodeChildren)
        //         {
        //             child.Parent = this;
        //             children.Add(child);
        //         }
        //     }
        // }
        // // Body as Array
        // if (node.BodyArray is not null)
        // {
        //     var bodyArrayChildren = node.BodyArray.Select(a => new NodeJS_Node(a, this));
        //     foreach (var bodyNode in bodyArrayChildren)
        //     {
        //         children.Add(bodyNode);
        //     }
        // }

        // Children as Body
        if (node.Body is not null)
        {
            children.Add(new NodeJS_Node(node.Body, this));
        }
        // Children as Statements
        if (node.Statements is not null)
        {
            foreach (var statement in node.Statements)
            {
                children.Add(new NodeJS_Node(statement, this));
            }
        }
        // Children as Members
        if (node.Members is not null)
        {
            foreach (var member in node.Members)
            {
                children.Add(new NodeJS_Node(member, this));
            }
        }

        // Kind = overrideKind ?? NodeJSTypeMapper.NodeJSTypeToSyntaxKind(node.Type, node.Kind);
        Kind = overrideKind ?? NodeJSTypeMapper.NodeJSTypeToSyntaxKind(node.Type, node.Kind);

        if (node.Modifiers is not null)
        {
            // var modifierKind = default(string);
            // modifierKind = node.Accessibility switch
            // {
            //     "protected" => SyntaxKind.ProtectedKeyword,
            //     "private" => SyntaxKind.PrivateKeyword,
            //     _ => node.Accessibility,
            // };
            // modifiers.Add(
            //     new NodeJS_Node(NodeJSTypeMapper.NodeJSTypeToSyntaxKind(modifierKind, null), this)
            // );
            foreach (var modifier in node.Modifiers)
            {
                if (modifier.Kind == TypeScriptSyntaxKind.StaticKeyword)
                {
                    children.Add(new NodeJS_Node(SyntaxKind.StaticKeyword, this));
                    continue;
                }
                if (modifier.Kind == TypeScriptSyntaxKind.ReadonlyKeyword)
                {
                    children.Add(new NodeJS_Node(SyntaxKind.ReadonlyKeyword, this));
                    continue;
                }

                if (modifier.Kind == TypeScriptSyntaxKind.PublicKeyword)
                {
                    modifiers.Add(new NodeJS_Node(modifier, this));
                    continue;
                }
                if (modifier.Kind == TypeScriptSyntaxKind.PrivateKeyword)
                {
                    modifiers.Add(new NodeJS_Node(modifier, this));
                    continue;
                }
                if (modifier.Kind == TypeScriptSyntaxKind.ProtectedKeyword)
                {
                    modifiers.Add(new NodeJS_Node(modifier, this));
                    continue;
                }
            }
        }
        // if (node.Static ?? false)
        // {
        //     children.Add(new NodeJS_Node(SyntaxKind.StaticKeyword, this));
        // }
        // if (node.Readonly ?? false)
        // {
        //     children.Add(new NodeJS_Node(SyntaxKind.ReadonlyKeyword, this));
        // }

        if (node.QuestionToken is not null)
        {
            children.Add(new NodeJS_Node(SyntaxKind.QuestionToken, this));
        }

        if (IdentifierStr is not null)
        {
            children.Add(new NodeJS_Node(SyntaxKind.Identifier, IdentifierStr, this));
        }

        // if (node.Object is not null)
        // {
        //     children.Add(new NodeJS_Node(SyntaxKind.Identifier, node.Object.Name, this));
        // }
        // if (node.Property is not null)
        // {
        //     children.Add(new NodeJS_Node(SyntaxKind.Identifier, node.Property.Name, this));
        // }

        if (node.ObjectType is not null)
        {
            children.Add(new NodeJS_Node(node.ObjectType, this));
        }

        if (node.IndexType is not null)
        {
            children.Add(new NodeJS_Node(node.IndexType, this));
        }

        // if (node.SuperClass is not null)
        // {
        //     var superClassNode = new NodeJS_Node(
        //         node.SuperClass,
        //         typeParameters: node.SuperTypeParameters,
        //         parent: this
        //     );

        //     heritageClauses.Add(new NodeJS_Node(types: new List<Node> { superClassNode }, this));
        // }
        // if (node.Implements is not null)
        // {
        //     foreach (var implementation in node.Implements)
        //     {
        //         var interfaceNode = new NodeJS_Node(implementation, parent: this);
        //         heritageClauses.Add(new NodeJS_Node(types: new List<Node> { interfaceNode }, this));
        //     }
        // }
        if (node.HeritageClauses is not null)
        {
            foreach (var heritageClause in node.HeritageClauses)
            {
                heritageClauses.Add(new NodeJS_Node(heritageClause, parent: this));
            }
        }
        if (heritageClauses.Count != 0)
        {
            HeritageClauses = heritageClauses;
        }

        // if (node.TypeAnnotation is not null && node.TypeAnnotation.Type != "TSTypeAnnotation")
        // {
        //     var type = new NodeJS_Node(node.TypeAnnotation, parent: this);
        //     children.Add(type);
        // }

        // if (node.Params is not null)
        // {
        //     Types = node.Params.Select(paramNode => new NodeJS_Node(
        //         paramNode,
        //         parent: this,
        //         overrideKind: SyntaxKind.Parameter
        //     ));
        //     children.AddRange(Types);
        // }

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
            var types = node.TypeParameters.Select(a => new NodeJS_Node(a, parent: this));
            // if (types.Any(a => a.Kind == SyntaxKind.TypeParameter))
            // {
            TypeParameters = types;
            // }
            // else
            // {
            //     TypeArguments = types;
            // }
            children.AddRange(types);
        }

        if (node.TypeArguments is not null)
        {
            var types = node.TypeArguments.Select(a => new NodeJS_Node(a, parent: this));
            TypeArguments = types;
            children.AddRange(types);
        }

        if (typeParameters is not null)
        {
            // TODO: Validate this
            var types = typeParameters.Parameters.Select(a => new NodeJS_Node(a, parent: this));
            TypeArguments = types;
            children.AddRange(types);
        }

        // if (node.ElementTypes is not null)
        // {
        //     var types = node.ElementTypes.Select(a => new NodeJS_Node(a, parent: this));
        //     //TypeArguments = types;
        //     children.AddRange(types);
        // }

        if (node.Elements is not null)
        {
            children.AddRange(node.Elements.Select(a => new NodeJS_Node(a, parent: this)));
        }

        if (node.Types is not null)
        {
            Types = node.Types.Select(a => new NodeJS_Node(a, this));
            children.AddRange(node.Types.Select(a => new NodeJS_Node(a, this)));
        }

        if (node.Kind == TypeScriptSyntaxKind.TypeOperator)
        {
            Type = new NodeJS_Node(node.Type, this);
            children.Add(Type);
        }
        else if (node.Type is not null)
        {
            Type = new NodeJS_Node(node.Type, this);
            children.Add(Type);
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

        // TODO: Look into this a TypeAnnotation might be something I have to handle, since it changes the Type on the node
        // if (node.TypeAnnotation is not null && node.TypeAnnotation.Type == "TSTypeAnnotation")
        // {
        //     var type = new NodeJS_Node(node.TypeAnnotation.TypeAnnotation, parent: this);
        //     if (Kind == SyntaxKind.Parameter)
        //     {
        //         Type = type;
        //     }
        //     children.Add(type);
        // }

        // if (node.ReturnType is not null)
        // {
        //     children.Add(new NodeJS_Node(node.ReturnType.TypeAnnotation, parent: this));
        // }

        // if (node.Value is not null)
        // {
        //     children.Add(new NodeJS_Node(node.Value, parent: this));
        // }

        if (node.Literal is not null)
        {
            children.Add(new NodeJS_Node(node.Literal, parent: this));
        }

        if (node.Initializer is not null)
        {
            children.Add(new NodeJS_Node(node.Initializer, parent: this));
        }

        Children = children;
        Modifiers = modifiers;
    }

    public NodeJS_Node(Program program)
    {
        Kind = "Program";
        Children = program.Body.Select(a => new NodeJS_Node(a, this)).OfType<Node>().ToList();
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

    public List<Node> Children { get; init; }

    public List<Node> OfKind(string kind)
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

    public override string ToString()
    {
        return $"{Kind} {IdentifierStr}";
    }
}

public static class NodeJSTypeMapper
{
    public static string NodeJSTypeToSyntaxKind(ASTNode typeNode, TypeScriptSyntaxKind? kind)
    {
        if (typeNode?.Kind == TypeScriptSyntaxKind.MethodDeclaration && kind is not null)
        {
            switch (kind)
            {
                // case TypeScriptSyntaxKind.MethodSignature:
                case TypeScriptSyntaxKind.MethodDeclaration:
                    return SyntaxKind.MethodDeclaration;
                case TypeScriptSyntaxKind.Constructor:
                    return SyntaxKind.Constructor;
                case TypeScriptSyntaxKind.GetAccessor:
                    return SyntaxKind.GetAccessor;
                case TypeScriptSyntaxKind.SetAccessor:
                    return SyntaxKind.SetAccessor;
                default:
                    break;
            }
        }

        switch (kind)
        {
            // case "TSModuleDeclaration":
            case TypeScriptSyntaxKind.ModuleDeclaration:
                return SyntaxKind.ModuleDeclaration;
            // case "TSInterfaceDeclaration":
            case TypeScriptSyntaxKind.InterfaceDeclaration:
                return SyntaxKind.InterfaceDeclaration;
            // case "TSEnumDeclaration":
            case TypeScriptSyntaxKind.EnumDeclaration:
                return SyntaxKind.EnumDeclaration;
            //case "Constructor": return SyntaxKind.Constructor;
            // case "ClassProperty":
            case TypeScriptSyntaxKind.PropertyDeclaration:
                return SyntaxKind.PropertyDeclaration;
            // case "TSPropertySignature":
            case TypeScriptSyntaxKind.PropertySignature:
                return SyntaxKind.PropertySignature;
            // case "TSDeclareMethod":
            case TypeScriptSyntaxKind.MethodDeclaration:
                return SyntaxKind.MethodDeclaration;
            // case "TSMethodSignature":
            case TypeScriptSyntaxKind.MethodSignature:
                return SyntaxKind.MethodSignature;

            // case "TSTypeAliasDeclaration":
            case TypeScriptSyntaxKind.TypeAliasDeclaration:
                return SyntaxKind.TypeAliasDeclaration;

            // case "TSTypeReference":
            case TypeScriptSyntaxKind.TypeReference:
                return SyntaxKind.TypeReference;
            // case "TSArrayType":
            case TypeScriptSyntaxKind.ArrayType:
                return SyntaxKind.ArrayType;
            // case "TSUnionType":
            case TypeScriptSyntaxKind.UnionType:
                return SyntaxKind.UnionType;
            // case "TSParenthesizedType":
            case TypeScriptSyntaxKind.ParenthesizedType:
                return SyntaxKind.ParenthesizedType;
            // case "TSFunctionType":
            case TypeScriptSyntaxKind.FunctionType:
                return SyntaxKind.FunctionType;
            // case "TSStringKeyword":
            case TypeScriptSyntaxKind.StringKeyword:
                return SyntaxKind.StringKeyword;
            // case "TSVoidKeyword":
            case TypeScriptSyntaxKind.VoidKeyword:
                return SyntaxKind.VoidKeyword;
            // case "TSBooleanKeyword":
            case TypeScriptSyntaxKind.BooleanKeyword:
                return SyntaxKind.BooleanKeyword;
            // case "TSNumberKeyword":
            case TypeScriptSyntaxKind.NumberKeyword:
                return SyntaxKind.NumberKeyword;
            // case "TSObjectKeyword":
            case TypeScriptSyntaxKind.ObjectKeyword:
                return SyntaxKind.ObjectKeyword;
            //case "StaticKeyword": return SyntaxKind.StaticKeyword;
            //case "ReadonlyKeyword": return SyntaxKind.ReadonlyKeyword;
            //case "LiteralType": return SyntaxKind.LiteralType;
            //case "TSTypeLiteral": return SyntaxKind.TypeLiteral;
            // case "TSTypeLiteral":
            case TypeScriptSyntaxKind.TypeLiteral:
                return SyntaxKind.TypeLiteral;
            // case "TSNullKeyword":
            case TypeScriptSyntaxKind.NullKeyword:
                return SyntaxKind.NullKeyword;
            // case "TSUndefinedKeyword":
            case TypeScriptSyntaxKind.UndefinedKeyword:
                return SyntaxKind.UndefinedKeyword;
            // case "TSAnyKeyword":
            case TypeScriptSyntaxKind.AnyKeyword:
                return SyntaxKind.AnyKeyword;
            // case "TSThisType":
            case TypeScriptSyntaxKind.ThisType:
                return SyntaxKind.ThisType;
            // case "TSTypeParameter":
            case TypeScriptSyntaxKind.TypeParameter:
                return SyntaxKind.TypeParameter;
            // case "TSTypeQuery":
            case TypeScriptSyntaxKind.TypeQuery:
                return SyntaxKind.TypeQuery;
            default:
                return kind.ToString();
        }
    }
}
