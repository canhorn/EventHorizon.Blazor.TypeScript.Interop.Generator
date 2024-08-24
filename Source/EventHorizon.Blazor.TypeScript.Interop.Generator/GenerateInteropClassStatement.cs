namespace EventHorizon.Blazor.TypeScript.Interop.Generator;

using System;
using System.Collections.Generic;
using System.IO;
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

        var (found, className, toGenerateNode) = GetNode(classIdentifier, ast);
        if (!found)
        {
            return null;
        }

        var namespaceIdentifier = string.Join(".", GetNamespace(toGenerateNode));
        var classMetadata = new ClassMetadata
        {
            Namespace = namespaceIdentifier,
            Name = className,
        };

        var typeOverrideDetails = new TypeOverrideDetails
        {
            IsStatic = false,
            TypeOverrideMap = typeOverrideMap,
        };
        var genericTypes = GetGenericTypes(
            toGenerateNode,
            classMetadata,
            ast,
            new TypeOverrideDetails { IsStatic = false, TypeOverrideMap = typeOverrideMap, }
        );
        classMetadata.GenericTypes = genericTypes;

        // Get ExtendedClassNames
        var extendedClassType = ExtendedClassTypesIdentifier.Identify(
            toGenerateNode,
            ast,
            classMetadata,
            typeOverrideDetails
        );
        // Get ImplementedInterfaces
        var implementedInterfaces = ImplementedInterfacesIdentifier.Identify(
            toGenerateNode,
            ast,
            classMetadata,
            typeOverrideDetails
        );

        // Public Properties
        var publicProperties = toGenerateNode
            .Children.Where(child =>
                IsNotPrivate(child)
                && IsPropertyType(child, classMetadata)
                && IsNotIgnored(namespaceIdentifier, className, child, ignoredIdentifiers)
            )
            .ToList();

        // Public Methods/Functions
        var publicMethods = toGenerateNode
            .Children.Where(child =>
                IsNotPrivate(child)
                && IsMethodType(child, classMetadata)
                && IsNotIgnored(namespaceIdentifier, className, child, ignoredIdentifiers)
            )
            .ToList();

        // Get/Set Accessors
        var accessorMethods = toGenerateNode
            .Children.Where(child =>
                IsNotPrivate(child)
                && IsAccessorType(child)
                && IsNotIgnored(namespaceIdentifier, className, child, ignoredIdentifiers)
            )
            .ToList();

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
            GenericTypes = MergeGenericTypes(genericTypes, extendedClassType).ToList(),
            ExtendedType = extendedClassType,
            ImplementedInterfaces = implementedInterfaces,
            // ConstructorStatement = new ConstructorStatement
            // {
            //     Arguments = ConstructorArgumentIdentifier.Identify(
            //         toGenerateNode,
            //         classMetadata,
            //         ast,
            //         new TypeOverrideDetails { IsStatic = false, TypeOverrideMap = typeOverrideMap, }
            //     ),
            // },
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
                    var type = GenericTypeIdentifier.Identify(
                        a.Last,
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
                            typeOverrideDetails
                        ),
                        IsStatic = isStatic,
                        IsInterfaceResponse = InterfaceResponseTypeIdentifier.Identify(type, ast),
                        // IsArrayResponse = IsArrayResposneTypeRule.Check(a),
                        IsReadonly = IsReadonlyRule.Check(a),
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
                    var type = GenericTypeIdentifier.Identify(
                        a.Last,
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
                    return new PublicMethodStatement
                    {
                        Name = name,
                        Type = NormalizeLiteralTypeStatement(
                            type,
                            toGenerateNode,
                            classMetadata,
                            ast,
                            typeOverrideDetails
                        ),
                        GenericTypes = DeclarationGenericTypesIdentifier.Identify(a),
                        Arguments = ArgumentIdentifier.Identify(
                            a,
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
            new TypeOverrideDetails { IsStatic = false, TypeOverrideMap = typeOverrideMap, }
        );

        return classStatement;
    }

    private static bool IsNotIgnored(
        string namespaceIdentifier,
        string className,
        Node child,
        IEnumerable<string> ignoredIdentifiers
    )
    {
        if (child.IdentifierStr == "T")
        {
            // Write to file in /temp/ignored.txt
            File.AppendAllText(
                "/temp/ignored.txt",
                $"{namespaceIdentifier}.{className}.{child.IdentifierStr}[{child.Kind}]\n"
            );
        }
        return !ignoredIdentifiers.Contains(
            $"{namespaceIdentifier}.{className}.{child.IdentifierStr}[{child.Kind}]"
        );
    }

    private static (bool found, string className, Node toGenerateNode) GetNode(
        string classIdentifier,
        AbstractSyntaxTree ast
    )
    {
        var className = DotNetClassNormalizer.Denormalize(classIdentifier);

        var toGenerateNode = ast.OfKind(SyntaxKind.ClassDeclaration)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        toGenerateNode = ast.OfKind(SyntaxKind.InterfaceDeclaration)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        toGenerateNode = ast.OfKind(SyntaxKind.TypeAliasDeclaration)
            .FirstOrDefault(a => a.IdentifierStr == className);
        if (toGenerateNode is not null)
        {
            return (true, className, toGenerateNode);
        }

        return (false, className, toGenerateNode);
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
        TypeOverrideDetails typeOverrideDetails
    )
    {
        if (type.IsTypeQuery)
        {
            var (found, className, toGenerateNode) = GetNode(type.TypeQuery.Class, ast);

            if (!found)
            {
                return type;
            }

            var typeNode = toGenerateNode.Children.FirstOrDefault(a =>
                a.IdentifierStr == type.TypeQuery.Type
            );
            if (typeNode is not null)
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
                        typeOverrideDetails
                    ),
                    IsStatic = isStatic,
                    IsInterfaceResponse = InterfaceResponseTypeIdentifier.Identify(type, ast),
                    HasSetter = IsSetterRule.Check(accessor),
                    //IsArrayResponse = IsArrayResposneTypeRule.Check(accessor),
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
            //var classDeclarationTyped = (ModuleDeclaration)classDeclaration;
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
            )
            && TypeIdentifier.Identify(child.Last, classMetadata)
                != GenerationIdentifiedTypes.Action
            && !IsClassBasedMethodRule.Check(child.Last);
    }

    private static bool IsMethodType(Node child, ClassMetadata classMetadata)
    {
        return !IsAccessorType(child)
            && (
                (
                    child.Kind == SyntaxKind.MethodDeclaration
                    || child.Kind == SyntaxKind.MethodSignature
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
        return child.Modifiers?.Count(modifier => modifier.Kind == SyntaxKind.PrivateKeyword) == 0
            && child.Modifiers?.Count(modifier => modifier.Kind == SyntaxKind.ProtectedKeyword) == 0
            && child.IdentifierStr != null
            && !child.IdentifierStr.StartsWith("_");
    }
}
