namespace EventHorizon.Blazor.TypeScript.Interop.Generator;

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Formatter;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Writers;

public static class GenerateClassStatementString
{
    public static string Generate(
        ClassStatement classStatement,
        ConcurrentDictionary<string, ClassStatement> generatedClassStatements,
        TextFormatter textFormatter
    )
    {
        var classTokenMap = new Dictionary<string, string>
        {
            { "[[INTERFACE_SECTION]]", string.Empty },
            { "[[EXTENDED_CLASSES_SECTION]]", string.Empty },
            { "[[WHERE_CONSTRAINT]]", string.Empty },
            { "[[CLASS_GENERICS]]", string.Empty },
            { "[[STATIC_ACCESSORS]]", string.Empty },
            { "[[STATIC_PROPERTIES]]", string.Empty },
            { "[[STATIC_METHODS]]", string.Empty },
            { "[[ACCESSORS]]", string.Empty },
            { "[[PROPERTIES]]", string.Empty },
            { "[[CONSTRUCTOR]]", string.Empty },
            { "[[METHODS]]", string.Empty },
            { "[[ASSEMBLY]]", classStatement.ProjectAssembly },
            { "[[CLASS_NAME]]", string.Empty },
            { "[[NAMESPACE]]", string.Empty },
            { "[[BASE_CONSTRUCTOR]]", string.Empty },
            { "[[INTERFACE_POSTFIX]]", string.Empty },
        };

        // Group Parts of the Class
        var staticAccessors = classStatement.AccessorStatements.Where(a => a.IsStatic);
        var staticProperties = classStatement.PublicPropertyStatements.Where(a => a.IsStatic);
        var staticMethods = classStatement.PublicMethodStatements.Where(a => a.IsStatic).Distinct();
        var accessors = classStatement.AccessorStatements.Where(a => !a.IsStatic);
        var properties = classStatement.PublicPropertyStatements.Where(a => !a.IsStatic);
        var constructorDetails = classStatement.ConstructorStatement;
        var methods = classStatement.PublicMethodStatements.Where(a => !a.IsStatic).Distinct();

        // Templates
        var classGenerationTemplates = ReadTemplates.Read();

        var classTemplate = classGenerationTemplates.Class;

        // Generate Tokens
        var namespaceReplaced = classStatement.Namespace;
        if (string.IsNullOrWhiteSpace(namespaceReplaced))
        {
            namespaceReplaced = string.Empty;
            classTemplate = classGenerationTemplates.ClassWithNoNamespace;
        }
        classTokenMap["[[NAMESPACE]]"] = namespaceReplaced;
        classTokenMap["[[CLASS_NAME]]"] = classStatement.Name;

        classTokenMap["[[INTERFACE_SECTION]]"] = InterfaceSectionWriter.Write(
            classStatement,
            classGenerationTemplates
        );
        classTokenMap["[[INTERFACE_POSTFIX]]"] = classStatement.IsInterface
            ? Constants.INTERFACE_POSTFIX
            : string.Empty;
        classTokenMap["[[CLASS_GENERICS]]"] = BuildClassGenerics(classStatement);
        classTokenMap["[[JSON_CONVERTER_CLASS_GENERICS]]"] = BuildJsonConvertClassGenerics(
            classStatement
        );
        classTokenMap["[[EXTENDED_CLASSES_SECTION]]"] = BuildExtendedClassesSection(classStatement);
        classTokenMap["[[WHERE_CONSTRAINT]]"] = classStatement.GenericTypes.Any()
            ? string.Join(
                "",
                classStatement
                    .GenericTypes.Where(IsGenericTypeReference)
                    .Select(genericType => $" where {genericType.Name} : CachedEntity, new()")
            )
            : string.Empty;
        bool IsGenericTypeReference(TypeStatement typeStatement)
        {
            // Check all Types to see if they are ResultType
            return typeStatement.IsTypeReference
                || typeStatement.IsThisType
                || classStatement.AccessorStatements.Any(a => IsMatchingType(a.Type))
                || classStatement.PublicPropertyStatements.Any(a => IsMatchingType(a.Type))
                || classStatement.PublicMethodStatements.Any(a => IsMatchingType(a.Type));
            bool IsMatchingType(TypeStatement genericType)
            {
                return genericType.Name == typeStatement.Name
                    || genericType.IsThisType
                    || (
                        (genericType.IsArray || genericType.IsNullable || genericType.IsTask)
                        && genericType.GenericTypes.Any(g => g.Name == typeStatement.Name)
                    );
            }
        }
        classTokenMap["[[STATIC_ACCESSORS]]"] = AccessorsSectionWriter.Write(
            classStatement,
            staticAccessors,
            classGenerationTemplates
        );
        classTokenMap["[[STATIC_PROPERTIES]]"] = PropertiesSectionWriter.Write(
            classStatement,
            staticProperties,
            classGenerationTemplates
        );
        classTokenMap["[[STATIC_METHODS]]"] = MethodsSectionWriter.Write(
            classStatement,
            staticMethods,
            classGenerationTemplates
        );
        classTokenMap["[[ACCESSORS]]"] = AccessorsSectionWriter.Write(
            classStatement,
            accessors,
            classGenerationTemplates
        );
        classTokenMap["[[PROPERTIES]]"] = PropertiesSectionWriter.Write(
            classStatement,
            properties,
            classGenerationTemplates
        );
        classTokenMap["[[CONSTRUCTOR]]"] = ConstructorSectionWriter.Write(
            classStatement,
            constructorDetails,
            generatedClassStatements,
            classGenerationTemplates
        );
        classTokenMap["[[BASE_CONSTRUCTOR]]"] = BaseConstructorSectionWriter.Write(
            classStatement,
            constructorDetails,
            classGenerationTemplates
        );
        classTokenMap["[[METHODS]]"] = MethodsSectionWriter.Write(
            classStatement,
            methods,
            classGenerationTemplates
        );

        var classStringBuilder = new StringBuilder(classTemplate);
        classStringBuilder = classTokenMap.Aggregate(
            classStringBuilder,
            (acc, token) => acc.Replace(token.Key, token.Value)
        );

        return textFormatter.Format(classStringBuilder.ToString());
    }

    private static string BuildClassGenerics(ClassStatement classStatement)
    {
        var template = "<[[TYPE]]>";

        if (!classStatement.GenericTypes.Any())
        {
            return string.Empty;
        }

        return template.Replace(
            "[[TYPE]]",
            string.Join(
                ", ",
                classStatement.GenericTypes.Select(genericType =>
                    TypeStatementWriter.Write(genericType)
                )
            )
        );
    }

    private static string BuildJsonConvertClassGenerics(ClassStatement classStatement)
    {
        var template = "<[[TYPE]]>";

        if (!classStatement.GenericTypes.Any())
        {
            return string.Empty;
        }

        return template.Replace(
            "[[TYPE]]",
            string.Join(
                ", ",
                classStatement.GenericTypes.Select(_ => GenerationIdentifiedTypes.CachedEntity)
            )
        );
    }

    /// <summary>
    /// : classStatement.ExtendedClassNames
    /// </summary>
    /// <param name="classStatement"></param>
    /// <returns></returns>
    private static string BuildExtendedClassesSection(ClassStatement classStatement)
    {
        // Check if extendedClassName is interface
        // If all are interfaces, add ClientEntity
        var interfaceTypes = classStatement.ImplementedInterfaces;
        if (classStatement.IsInterface)
        {
            // The classStatement if for an interface, so the class will postfixed with an identifier.
            // And will need to be inherited from its created interface.
            interfaceTypes.Add(
                new TypeStatement
                {
                    Name = classStatement.Name,
                    GenericTypes = classStatement.GenericTypes,
                }
            );
        }

        if (classStatement.ExtendedType == null && !interfaceTypes.Any())
        {
            return " : CachedEntityObject";
        }
        else if (
            classStatement.ExtendedType == null
            || classStatement.ExtendedType?.Name == classStatement.Name
        )
        {
            classStatement.ExtendedType = new TypeStatement { Name = "CachedEntityObject" };
        }

        return " : "
            + string.Join(
                ", ",
                new[] { TypeStatementWriter.Write(classStatement.ExtendedType, true) }
                    .Concat(interfaceTypes.Select(ClassStatementExtendedType))
                    .Distinct()
            );
        string ClassStatementExtendedType(TypeStatement interfaceType)
        {
            var statement = TypeStatementWriter.Write(interfaceType, true, true);
            if (!classStatement.IsInterface && interfaceType.Name == classStatement.Name)
            {
                return $"{statement}Interface";
            }

            return statement;
        }
    }
}
