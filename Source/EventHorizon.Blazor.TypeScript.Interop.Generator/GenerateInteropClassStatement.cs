using System.Collections.Generic;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Rules;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using Sdcb.TypeScript;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    public static class GenerateInteropClassStatement
    {
        static readonly IRule IsObservablePropertyRule = new IsObservableProperty();
        static readonly IRule IsGetterRule = new IsGetter();
        static readonly IRule IsSetterRule = new IsSetter();
        static readonly IRule IsArrayResposneTypeRule = new IsArrayResponseType();
        static readonly IRule IsStaticRule = new IsStatic();
        static readonly IRule IsReadonlyRule = new IsReadonly();
        static readonly IRule IsClassBasedMethodRule = new IsClassBasedMethod();
        static readonly IRule IsInterfaceRule = new IsInterface();

        public static ClassStatement Generate(
            string projectAssembly,
            string classIdentifier,
            TypeScriptAST ast,
            IDictionary<string, string> typeOverrideMap
        )
        {
            //var namespaceIdentifier = string.Join(".", identifier.Take(identifier.Count - 1)); // "Bablyon";
            var className = classIdentifier;

            var toGenerateNode = ast.OfKind(SyntaxKind.ClassDeclaration)
                .FirstOrDefault(a => a.IdentifierStr == classIdentifier);
            if (toGenerateNode == null)
            {
                toGenerateNode = ast.OfKind(SyntaxKind.InterfaceDeclaration)
                    .FirstOrDefault(a => a.IdentifierStr == classIdentifier);
                if (toGenerateNode == null)
                {
                    return null;
                }
            }
            var namespaceIdentifier = string.Join(".", GetNamespace(toGenerateNode));
            var classMetadata = new ClassMetadata
            {
                Namespace = namespaceIdentifier,
                Name = classIdentifier,
                TypeIdentifier = TypeParameterIdentifier.Identify(toGenerateNode),
            };


            // Get ExtendedClassNames
            var extendedClassNames = ExtendedClassNamesIdentifier.Identify(
                toGenerateNode,
                ast
            );
            // Get ImplementedInterfaceNames
            var implementedInterfaceNames = ImplementedInterfaceNamesIdentifier.Identify(
                toGenerateNode,
                ast
            );

            // Public Properties
            var publicProperties = toGenerateNode
                .Children.Where(
                    child => IsNotPrivate(child) && IsPropertyType(child, classMetadata)
                );

            // Public Methods/Functions
            var publicMethods = toGenerateNode
                .Children.Where(
                    child => IsNotPrivate(child) && IsMethodType(child, classMetadata)
                );

            // Get/Set Accessors
            var accessorMethods = toGenerateNode
                .Children.Where(
                    child => IsNotPrivate(child) && IsAccessorType(child)
                );

            // Is Observer Method/Function
            var observalbleMethods = publicProperties.Where(
                a => IsObservablePropertyRule.Check(a)
            ).ToList();

            var classStatement = new ClassStatement
            {
                ProjectAssembly = projectAssembly,
                Namespace = namespaceIdentifier,
                Name = className,
                IsInterface = IsInterfaceRule.Check(toGenerateNode),
                ExtendedClassNames = extendedClassNames,
                ImplementedInterfaceNames = implementedInterfaceNames,
                ConstructorStatement = new ConstructorStatement
                {
                    Arguments = ConstructorArgumentIdentifier.Identify(
                        toGenerateNode,
                        classMetadata,
                        typeOverrideMap
                    ),
                },
                PublicPropertyStatements = publicProperties.ToList().Select(
                    a =>
                    {
                        var name = a.IdentifierStr;
                        var isStatic = IsStaticRule.Check(a);
                        var type = TypeIdentifier.Identify(
                            a,
                            classMetadata,
                            TypeParameterIdentifier.Identify(a)
                        );
                        if (TypeOverrideIdentifier.Identify(
                            TypeOverrideDeclarationIdentifier.Identify(
                                classMetadata,
                                isStatic,
                                name
                            ),
                            typeOverrideMap,
                            type,
                            out var overrideType
                        ))
                        {
                            type = overrideType;
                        }
                        return new PublicPropertyStatement
                        {
                            Name = name,
                            Type = type,
                            IsStatic = isStatic,
                            IsInterfaceResponse = StringTypeInterfaceIdentifier.Identify(
                                ast,
                                type
                            ),
                            IsArrayResponse = IsArrayResposneTypeRule.Check(a),
                            IsReadonly = IsReadonlyRule.Check(a),
                            UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                        };
                    }
                ).ToList(),
                PublicMethodStatements = publicMethods.ToList().Select(
                    a =>
                    {
                        var name = a.IdentifierStr;
                        var isStatic = IsStaticRule.Check(a);
                        var type = TypeIdentifier.Identify(
                            a,
                            classMetadata,
                            TypeParameterIdentifier.Identify(a)
                        );
                        if (TypeOverrideIdentifier.Identify(
                            TypeOverrideDeclarationIdentifier.Identify(
                                classMetadata,
                                isStatic,
                                name
                            ),
                            typeOverrideMap,
                            type,
                            out var overrideType
                        ))
                        {
                            type = overrideType;
                        }
                        return new PublicMethodStatement
                        {
                            Name = name,
                            Type = type,
                            Arguments = ArgumentIdentifier.Identify(
                                a,
                                classMetadata,
                                typeOverrideMap,
                                isStatic
                            ),
                            IsStatic = isStatic,
                            IsInterfaceResponse = StringTypeInterfaceIdentifier.Identify(
                                ast,
                                type
                            ),
                            IsArrayResponse = IsArrayResposneTypeRule.Check(a),
                            UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                        };
                    }
                ).ToList(),
                AccessorStatements = accessorMethods.FlattenAccessorStatements(
                    ast,
                    classMetadata,
                    typeOverrideMap
                ),
            };
            classStatement.ConstructorStatement.NeedsInvokableReference = InvokableReferenceIdentifier.Identify(
                classStatement
            );

            return classStatement;
        }

        public static IList<AccessorStatement> FlattenAccessorStatements(
            this IEnumerable<Node> nodes,
            TypeScriptAST ast,
            ClassMetadata classMetadata,
            IDictionary<string, string> typeOverrideMap
        )
        {
            var flattenedAccessorList = nodes.Where(a => IsGetterRule.Check(a)).Select(
                accessor =>
                {
                    var name = accessor.IdentifierStr;
                    var isStatic = IsStaticRule.Check(accessor);
                    var type = TypeIdentifier.Identify(
                        accessor,
                        classMetadata,
                        TypeParameterIdentifier.Identify(accessor)
                    );
                    if (TypeOverrideIdentifier.Identify(
                        TypeOverrideDeclarationIdentifier.Identify(
                            classMetadata,
                            isStatic,
                            name
                        ),
                        typeOverrideMap,
                        type,
                        out var overrideType
                    ))
                    {
                        type = overrideType;
                    }
                    return new AccessorStatement
                    {
                        Name = name,
                        Type = type,
                        IsStatic = isStatic,
                        IsInterfaceResponse = StringTypeInterfaceIdentifier.Identify(
                            ast,
                            type
                        ),
                        HasSetter = IsSetterRule.Check(accessor),
                        IsArrayResponse = IsArrayResposneTypeRule.Check(accessor),
                        UsedClassNames = UsedClassNamesIdentifier.Identify(type),
                    };
                }
            ).ToList();
            // Loop through Setters and on the setter flat as HasSetter
            foreach (var node in nodes.Where(a => IsSetterRule.Check(a)))
            {
                var getNode = flattenedAccessorList.FirstOrDefault(
                    a => a.Name == node.IdentifierStr
                );
                if (getNode != null)
                {
                    getNode.HasSetter = true;
                }
            }
            return flattenedAccessorList;
        }


        private static List<string> GetNamespace(
            INode classDeclaration,
            List<string> namespaceText = null
        )
        {
            if (namespaceText == null)
            {
                namespaceText = new List<string>();
            }
            if (classDeclaration.Kind == SyntaxKind.ModuleDeclaration)
            {
                var delc = (ModuleDeclaration)classDeclaration;
                namespaceText.Insert(0, delc.IdentifierStr);
            }
            if (classDeclaration.Parent == null)
            {
                return namespaceText;
            }
            return GetNamespace(classDeclaration.Parent, namespaceText);
        }

        private static bool IsPropertyType(
            Node child,
            ClassMetadata classMetadata
        )
        {
            return (child.Kind == SyntaxKind.PropertyDeclaration || child.Kind == SyntaxKind.PropertySignature)
                && TypeIdentifier
                    .Identify(
                        child,
                        classMetadata,
                        TypeParameterIdentifier.Identify(child)
                    ) != GenerationIdentifiedTypes.Action
                && !IsClassBasedMethodRule.Check(child);
        }

        private static bool IsMethodType(
            Node child,
            ClassMetadata classMetadata
        )
        {
            return !IsAccessorType(child)
                && ((child.Kind == SyntaxKind.MethodDeclaration || child.Kind == SyntaxKind.MethodSignature)
                || TypeIdentifier
                    .Identify(
                        child,
                        classMetadata,
                        TypeParameterIdentifier.Identify(child)
                    ) == GenerationIdentifiedTypes.Action
                || TypeIdentifier
                    .Identify(
                        child,
                        classMetadata,
                        TypeParameterIdentifier.Identify(child)
                    ) == GenerationIdentifiedTypes.Void
                || IsClassBasedMethodRule.Check(child));
        }

        private static bool IsAccessorType(Node child)
        {
            return child.Kind == SyntaxKind.GetAccessor
                || child.Kind == SyntaxKind.SetAccessor;
        }

        private static bool IsNotPrivate(Node child)
        {
            return child.Modifiers?.Count(
                modifier => modifier.Kind == SyntaxKind.PrivateKeyword) == 0
            && child.Modifiers?.Count(
                modifier => modifier.Kind == SyntaxKind.ProtectedKeyword) == 0
            && child.IdentifierStr != null && !child.IdentifierStr.StartsWith("_");
        }
    }
}
