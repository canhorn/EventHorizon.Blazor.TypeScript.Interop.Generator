namespace EventHorizon.Blazor.TypeScript.Interop.Generator;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model.Types;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;

public static class GenerateInteropClassStatement
{
    static readonly IsObservableProperty IsObservablePropertyRule = new();
    static readonly IsGetter IsGetterRule = new();
    static readonly IsSetter IsSetterRule = new();
    static readonly IsStatic IsStaticRule = new();
    static readonly IsReadonly IsReadonlyRule = new();
    static readonly IsClassBasedMethod IsClassBasedMethodRule = new();
    static readonly IsInterface IsInterfaceRule = new();

    public static ClassStatement Generate(
        string projectAssembly,
        string classIdentifier,
        AbstractSyntaxTree ast,
        IDictionary<string, string> typeOverrideMap,
        IEnumerable<string> ignoredIdentifiers = null
    )
    {
        ignoredIdentifiers ??= [];

        var (found, className, toGenerateNode) = NodeIdentifier.GetNode(classIdentifier, ast);
        if (!found)
        {
            return null;
        }

        var namespaceIdentifier = string.Join(".", GetNamespace(toGenerateNode));
        var classMetadata = new ClassMetadata { Namespace = namespaceIdentifier, Name = className };

        var typeOverrideDetails = new TypeOverrideDetails
        {
            IsStatic = false,
            TypeOverrideMap = typeOverrideMap,
        };
        var genericTypes = GetGenericTypes(
            toGenerateNode,
            classMetadata,
            ast,
            new TypeOverrideDetails { IsStatic = false, TypeOverrideMap = typeOverrideMap }
        );
        classMetadata.GenericTypes = genericTypes;

        // Get ExtendedClassNames
        var extendedClassType = ExtendedClassTypesIdentifier.Identify(
            toGenerateNode,
            ast,
            classMetadata,
            typeOverrideDetails
        );
        genericTypes = MergeGenericTypes(genericTypes, extendedClassType);
        classMetadata.GenericTypes = genericTypes;

        // Get ImplementedInterfaces
        var implementedInterfaces = ImplementedInterfacesIdentifier.Identify(
            toGenerateNode,
            ast,
            classMetadata,
            typeOverrideDetails
        );

        // Class Children
        var classChildren = RemoveInvalidPatterns(toGenerateNode.Children);

        // Public Properties
        var publicProperties = classChildren
            .Where(child =>
                child.Kind != SyntaxKind.TypeLiteral
                && IsNotPrivate(child)
                && IsPropertyType(child, classMetadata)
                && IsNotIgnored(namespaceIdentifier, className, child, ignoredIdentifiers)
            )
            .ToList();

        // Public Methods/Functions
        var publicMethods = classChildren
            .Where(child =>
                child.Kind != SyntaxKind.TypeLiteral
                && IsNotPrivate(child)
                && IsMethodType(child, classMetadata)
                && IsNotIgnored(namespaceIdentifier, className, child, ignoredIdentifiers)
            )
            .ToList();

        // Get/Set Accessors
        var accessorMethods = classChildren
            .Where(child =>
                IsNotPrivate(child)
                && IsAccessorType(child)
                && IsNotIgnored(namespaceIdentifier, className, child, ignoredIdentifiers)
            )
            .ToList();

        // Get TypeLiteral Properties/Accessors/Methods/Functions
        var (properties, methods) = GetTypeLiteralChildren(
            classChildren,
            ast,
            classMetadata,
            typeOverrideDetails
        );
        publicProperties.AddRange(properties);
        publicMethods.AddRange(methods);

        // Is Observer Method/Function
        var observableMethods = publicProperties
            .Where(a => IsObservablePropertyRule.Check(a))
            .ToList();

        var classStatement = new ClassStatement
        {
            ProjectAssembly = projectAssembly,
            Namespace = namespaceIdentifier,
            Name = DotNetClassNormalizer.Normalize(className),
            IsInterface = IsInterfaceRule.Check(toGenerateNode),
            GenericTypes = genericTypes,
            ExtendedType = extendedClassType,
            ImplementedInterfaces = implementedInterfaces,
            PublicPropertyStatements = publicProperties
                .Select(a =>
                {
                    var name = a.IdentifierStr;
                    var isStatic = IsStaticRule.Check(a);
                    var typeOverrideDetails = new TypeOverrideDetails
                    {
                        IsStatic = isStatic,
                        TypeOverrideMap = typeOverrideMap,
                    };
                    var node = a;
                    var typeNode = a.Last;
                    if (node.Type?.Kind == SyntaxKind.TypeQuery && node.Type.IdentifierStr != null)
                    {
                        var (found, className, childTypeNode) = NodeIdentifier.GetTypeQueryNode(
                            node.Type.IdentifierStr,
                            ast
                        );
                        if (found)
                        {
                            node = childTypeNode;
                            typeNode = childTypeNode.Type;
                        }
                    }

                    var type = GenericTypeIdentifier.Identify(
                        typeNode,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    );
                    if (
                        TypeOverrideIdentifier.Identify(
                            TypeOverrideDeclarationIdentifier.Identify(
                                classMetadata,
                                typeOverrideDetails.IsStatic,
                                name
                            ),
                            typeOverrideDetails.TypeOverrideMap,
                            type,
                            out var overrideType
                        )
                    )
                    {
                        type = overrideType;
                    }

                    return new PublicPropertyStatement
                    {
                        Name = name,
                        Type = NormalizeLiteralTypeStatement(
                            type,
                            toGenerateNode,
                            classMetadata,
                            ast,
                            typeOverrideDetails,
                            []
                        ),
                        IsStatic = isStatic,
                        IsInterfaceResponse = InterfaceResponseTypeIdentifier.Identify(type, ast),
                        IsReadonly = IsReadonlyRule.Check(node),
                        UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                    };
                })
                .ToList(),
            PublicMethodStatements = publicMethods
                .Select(a =>
                {
                    var name = a.IdentifierStr;
                    var isStatic = IsStaticRule.Check(a);
                    var typeOverrideDetails = new TypeOverrideDetails
                    {
                        IsStatic = isStatic,
                        TypeOverrideMap = typeOverrideMap,
                    };
                    var node = a;
                    var typeNode = a.Last;
                    if (node.Type?.Kind == SyntaxKind.TypeQuery)
                    {
                        var (found, className, childTypeNode) = NodeIdentifier.GetTypeQueryNode(
                            node.Type.IdentifierStr,
                            ast
                        );
                        if (found)
                        {
                            node = childTypeNode;
                            typeNode = childTypeNode.Type;
                        }
                    }
                    else if (node.Type?.Kind == SyntaxKind.FunctionType)
                    {
                        node = node.Type;
                        typeNode = node.Last;
                    }

                    var type = GenericTypeIdentifier.Identify(
                        typeNode,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    );
                    if (
                        TypeOverrideIdentifier.Identify(
                            TypeOverrideDeclarationIdentifier.Identify(
                                classMetadata,
                                typeOverrideDetails.IsStatic,
                                name
                            ),
                            typeOverrideDetails.TypeOverrideMap,
                            type,
                            out var overrideType
                        )
                    )
                    {
                        type = overrideType;
                    }

                    var genericTypes = DeclarationGenericTypesIdentifier.Identify(node);
                    return new PublicMethodStatement
                    {
                        Name = name,
                        Type = NormalizeLiteralTypeStatement(
                            type,
                            toGenerateNode,
                            classMetadata,
                            ast,
                            typeOverrideDetails,
                            genericTypes
                        ),
                        GenericTypes = genericTypes,
                        Arguments = ArgumentIdentifier.Identify(
                            node,
                            classMetadata,
                            ast,
                            typeOverrideDetails
                        ),
                        IsStatic = isStatic,
                        IsInterfaceResponse = InterfaceResponseTypeIdentifier.Identify(type, ast),
                        UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                    };
                })
                .GroupBy(a => a.Name)
                .Select(FlattenPublicMethodStatement)
                .ToList(),
            AccessorStatements = accessorMethods.FlattenAccessorStatements(
                toGenerateNode,
                ast,
                classMetadata,
                typeOverrideMap
            ),
        };

        static PublicMethodStatement FlattenPublicMethodStatement(
            IGrouping<string, PublicMethodStatement> group
        )
        {
            var first = group.First();
            if (group.Count() == 1)
            {
                return first;
            }

            return new PublicMethodStatement
            {
                Name = first.Name,
                Type = first.Type,
                IsStatic = first.IsStatic,
                IsInterfaceResponse = first.IsInterfaceResponse,
                UsedClassNames = group.SelectMany(a => a.UsedClassNames).Distinct().ToList(),
                GenericTypes = group.SelectMany(a => a.GenericTypes).Distinct().ToList(),
                Arguments = group
                    .SelectMany(a => a.Arguments)
                    .GroupBy(b => b.Name)
                    .Select(FlattenArgumentStatement)
                    .Distinct()
                    .ToList(),
            };

            static ArgumentStatement FlattenArgumentStatement(
                IGrouping<string, ArgumentStatement> group
            )
            {
                var first = group.First();
                if (group.Count() == 1)
                {
                    return first;
                }

                return new ArgumentStatement
                {
                    Name = first.Name,
                    IsOptional = first.IsOptional,
                    UsedClassNames = group.SelectMany(a => a.UsedClassNames).Distinct().ToList(),
                    Type = group.OrderByDescending(a => a.Type.Score()).FirstOrDefault().Type,
                };
            }
        }

        classStatement.ConstructorStatement = ConstructorStatementIdentifier.Identify(
            toGenerateNode,
            classStatement,
            classMetadata,
            ast,
            new TypeOverrideDetails { IsStatic = false, TypeOverrideMap = typeOverrideMap }
        );

        return classStatement;
    }

    private static List<Node> RemoveInvalidPatterns(List<Node> children)
    {
        // MethodDeclaration<Identifier(import), Block> PropertyDeclaration<StringLiteral> PropertyDeclaration<Identifier>
        // Create a sliding window of 3 nodes checking for the above pattern
        for (var i = 0; i < children.Count - 2; i++)
        {
            var firstChild = children[i];
            var secondChild = children[i + 1];
            var thirdChild = children[i + 2];
            if (
                // First Child
                firstChild != null
                && firstChild.Kind == SyntaxKind.MethodDeclaration
                && firstChild.IdentifierStr == "import"
                && firstChild.Last?.Kind == SyntaxKind.Block
                // Second Child
                && secondChild != null
                && secondChild.Kind == SyntaxKind.PropertyDeclaration
                && secondChild.Last?.Kind == SyntaxKind.StringLiteral
                // Third Child
                && thirdChild != null
                && thirdChild.Kind == SyntaxKind.PropertyDeclaration
                && thirdChild.Children.All(a => a.Kind != SyntaxKind.StringLiteral)
            )
            {
                // remove all 3 nodes
                children.RemoveAt(i + 2);
                children.RemoveAt(i + 1);
                children.RemoveAt(i);
            }
        }
        return children;
    }

    private static (List<Node> properties, List<Node> methods) GetTypeLiteralChildren(
        List<Node> children,
        AbstractSyntaxTree ast,
        ClassMetadata classMetadata,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        var typeLiteralChildren = children
            .Where(child => IsNotPrivate(child) && child.Kind == SyntaxKind.TypeLiteral)
            .SelectMany(child => child.Children)
            .Where(child => child.Type != null)
            .ToList();

        var groupChildren = typeLiteralChildren.GroupBy(a => a.Type.Kind);
        var properties = new List<Node>();
        var methods = new List<Node>();
        foreach (var group in groupChildren)
        {
            if (group.Key == SyntaxKind.LiteralType)
            {
                properties.AddRange(group);
                continue;
            }

            foreach (var child in group)
            {
                if (IsPropertyType(child, classMetadata) && child.Type.Kind != SyntaxKind.TypeQuery)
                {
                    properties.Add(child);
                }
                else if (
                    IsPropertyType(child, classMetadata)
                    && child.Type.Kind == SyntaxKind.TypeQuery
                )
                {
                    // Lookup the TypeQuery and add that to the properties
                    var (found, className, childTypeNode) = NodeIdentifier.GetTypeQueryNode(
                        child.Type.IdentifierStr,
                        ast
                    );
                    if (!found)
                    {
                        continue;
                    }
                    else if (IsPropertyType(childTypeNode, classMetadata))
                    {
                        properties.Add(child);
                    }
                    else if (IsMethodType(childTypeNode, classMetadata))
                    {
                        methods.Add(child);
                    }
                }
                else if (IsMethodType(child, classMetadata))
                {
                    methods.Add(child);
                }
            }
        }

        // Add Static modifier to every property/method
        foreach (var property in properties)
        {
            property.Modifiers.Add(IsStatic.StaticModifier);
        }
        foreach (var method in methods)
        {
            method.Modifiers.Add(IsStatic.StaticModifier);
        }

        return (properties, methods);
    }

    private static bool IsNotIgnored(
        string namespaceIdentifier,
        string className,
        Node child,
        IEnumerable<string> ignoredIdentifiers
    )
    {
        return !ignoredIdentifiers.Contains(
            $"{namespaceIdentifier}.{className}.{child.IdentifierStr}[{child.Kind}]"
        );
    }

    private static IList<TypeStatement> GetGenericTypes(
        Node node,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails
    )
    {
        if (node.Kind == SyntaxKind.ClassDeclaration && node.TypeParameters != null)
        {
            return node
                .TypeParameters.Select(typeParam =>
                    GenericTypeIdentifier.Identify(
                        typeParam,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    )
                )
                .ToList();
        }
        else if (node.Kind == SyntaxKind.InterfaceDeclaration && node.TypeParameters != null)
        {
            return node
                .TypeParameters.Select(typeParam =>
                    GenericTypeIdentifier.Identify(
                        typeParam,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    )
                )
                .ToList();
        }
        else if (node.Kind == SyntaxKind.TypeAliasDeclaration && node.TypeParameters != null)
        {
            return node
                .TypeParameters.Select(typeParam =>
                    GenericTypeIdentifier.Identify(
                        typeParam,
                        classMetadata,
                        ast,
                        typeOverrideDetails
                    )
                )
                .ToList();
        }

        // Fallback, find any TypeParameter
        return node
            .Children.Where(a => a.Kind == SyntaxKind.TypeParameter)
            .Select(typeParam =>
                GenericTypeIdentifier.Identify(typeParam, classMetadata, ast, typeOverrideDetails)
            )
            .ToList();
    }

    private static IList<TypeStatement> MergeGenericTypes(
        IList<TypeStatement> genericTypes,
        TypeStatement extendedClassType
    )
    {
        if (extendedClassType is null)
        {
            return genericTypes;
        }

        var extendedClassGenericTypes = extendedClassType.GenericTypes?.Where(a =>
            !a.IsTypeReference
        );
        if (extendedClassGenericTypes is null || !extendedClassGenericTypes.Any())
        {
            return genericTypes;
        }

        var mergedGenericTypes = new List<TypeStatement>();
        foreach (var genericType in genericTypes)
        {
            var extendedGenericType = extendedClassGenericTypes.FirstOrDefault(a =>
                a.Name == genericType.Name
            );
            if (extendedGenericType is not null)
            {
                mergedGenericTypes.Add(extendedGenericType);
            }
            else
            {
                mergedGenericTypes.Add(genericType);
            }
        }

        foreach (var extendedGenericType in extendedClassGenericTypes)
        {
            if (!mergedGenericTypes.Any(a => a.Name == extendedGenericType.Name))
            {
                mergedGenericTypes.Add(extendedGenericType);
            }
        }

        return mergedGenericTypes;
    }

    private static TypeStatement NormalizeLiteralTypeStatement(
        TypeStatement type,
        Node classNode,
        ClassMetadata classMetadata,
        AbstractSyntaxTree ast,
        TypeOverrideDetails typeOverrideDetails,
        IList<string> genericTypes
    )
    {
        if (type.IsTypeQuery)
        {
            var (found, className, toGenerateNode) = NodeIdentifier.GetTypeQueryNode(
                type.TypeQuery.Class,
                ast
            );

            if (!found)
            {
                return type;
            }

            var typeNode = toGenerateNode.Children.FirstOrDefault(a =>
                a.IdentifierStr == type.TypeQuery.Type
            );
            if (typeNode is not null && typeNode.Last is not null)
            {
                return GenericTypeIdentifier.Identify(
                    typeNode.Last,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
            }
        }

        if (type.IsThisType)
        {
            return GenericTypeIdentifier.Identify(
                classNode,
                classMetadata,
                ast,
                typeOverrideDetails
            );
        }

        if (type.IsLiteral)
        {
            type.Name = GenerationIdentifiedTypes.CachedEntity;
        }
        var literalGenericTypes = type.GenericTypes.Where(a => a.IsLiteral);
        foreach (var genericType in literalGenericTypes)
        {
            genericType.Name = GenerationIdentifiedTypes.CachedEntity;
        }

        if (
            type.IsTypeReference
            && !type.GenericTypes.Any()
            && !classMetadata.GenericTypes.Any(a => a.Name == type.Name)
            && !genericTypes.Any(a => a == type.Name)
        )
        {
            var (found, className, toGenerateNode) = NodeIdentifier.GetTypeQueryNode(
                type.Name,
                ast
            );
            if (found)
            {
                return GenericTypeIdentifier.Identify(
                    toGenerateNode,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
            }
        }

        return type;
    }

    public static IList<AccessorStatement> FlattenAccessorStatements(
        this IEnumerable<Node> nodes,
        Node classNode,
        AbstractSyntaxTree ast,
        ClassMetadata classMetadata,
        IDictionary<string, string> typeOverrideMap
    )
    {
        var flattenedAccessorList = nodes
            .Where(a => IsGetterRule.Check(a))
            .Select(accessor =>
            {
                var name = accessor.IdentifierStr;
                if (name == "host")
                {
                    Debugger.Break();
                }
                var isStatic = IsStaticRule.Check(accessor);
                var typeOverrideDetails = new TypeOverrideDetails
                {
                    IsStatic = isStatic,
                    TypeOverrideMap = typeOverrideMap,
                };
                var type = GenericTypeIdentifier.Identify(
                    accessor.Last,
                    classMetadata,
                    ast,
                    typeOverrideDetails
                );
                if (
                    TypeOverrideIdentifier.Identify(
                        TypeOverrideDeclarationIdentifier.Identify(classMetadata, isStatic, name),
                        typeOverrideMap,
                        type,
                        out var overrideType
                    )
                )
                {
                    type = overrideType;
                }
                return new AccessorStatement
                {
                    Name = name,
                    Type = NormalizeLiteralTypeStatement(
                        type,
                        classNode,
                        classMetadata,
                        ast,
                        typeOverrideDetails,
                        []
                    ),
                    IsStatic = isStatic,
                    IsInterfaceResponse = InterfaceResponseTypeIdentifier.Identify(type, ast),
                    HasSetter = IsSetterRule.Check(accessor),
                    UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                };
            })
            .ToList();
        // Loop through Setters and on the setter flat as HasSetter
        foreach (var node in nodes.Where(a => IsSetterRule.Check(a)))
        {
            var getNode = flattenedAccessorList.FirstOrDefault(a => a.Name == node.IdentifierStr);
            if (getNode != null)
            {
                getNode.HasSetter = true;
            }
        }
        return flattenedAccessorList;
    }

    private static List<string> GetNamespace(
        Node classDeclaration,
        List<string> namespaceText = null
    )
    {
        if (namespaceText == null)
        {
            namespaceText = new List<string>();
        }
        if (classDeclaration.Kind == SyntaxKind.ModuleDeclaration)
        {
            namespaceText.Insert(0, classDeclaration.IdentifierStr);
        }
        if (classDeclaration.Parent == null)
        {
            return namespaceText;
        }
        return GetNamespace(classDeclaration.Parent, namespaceText);
    }

    private static bool IsPropertyType(Node child, ClassMetadata classMetadata)
    {
        return (
                child.Kind == SyntaxKind.PropertyDeclaration
                || child.Kind == SyntaxKind.PropertySignature
                || child.Kind == SyntaxKind.VariableDeclaration
            )
            && TypeIdentifier.Identify(child.Last, classMetadata)
                != GenerationIdentifiedTypes.Action
            && TypeIdentifier.Identify(child.Last, classMetadata) != GenerationIdentifiedTypes.Void
            && !IsClassBasedMethodRule.Check(child.Last);
    }

    private static bool IsMethodType(Node child, ClassMetadata classMetadata)
    {
        return !IsAccessorType(child)
            && (
                (
                    child.Kind == SyntaxKind.MethodDeclaration
                    || child.Kind == SyntaxKind.MethodSignature
                    || child.Kind == SyntaxKind.FunctionDeclaration
                )
                || TypeIdentifier.Identify(child.Last, classMetadata)
                    == GenerationIdentifiedTypes.Action
                || TypeIdentifier.Identify(child.Last, classMetadata)
                    == GenerationIdentifiedTypes.Void
                || IsClassBasedMethodRule.Check(child)
            );
    }

    private static bool IsAccessorType(Node child)
    {
        return child.Kind == SyntaxKind.GetAccessor || child.Kind == SyntaxKind.SetAccessor;
    }

    private static bool IsNotPrivate(Node child)
    {
        if (child.Kind == SyntaxKind.TypeLiteral)
        {
            return true;
        }

        return child.Modifiers?.Count(modifier => modifier.Kind == SyntaxKind.PrivateKeyword) == 0
            && child.Modifiers?.Count(modifier => modifier.Kind == SyntaxKind.ProtectedKeyword) == 0
            && child.IdentifierStr != null
            && !child.IdentifierStr.StartsWith("_");
    }
}
