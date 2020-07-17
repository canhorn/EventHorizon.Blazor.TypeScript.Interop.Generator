using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Writers;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator
{
    public static class GenerateClassStatementString
    {
        public static string Generate(
            ClassStatement classStatement
        )
        {
            var classTokenMap = new Dictionary<string, string>
            {
                { "[[INTERFACE_SECTION]]", string.Empty },
                { "[[EXTENDED_CLASSES_SECTION]]", string.Empty },
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

            // Generate Tokens
            var namespaceReplaced = classStatement.Namespace.Replace("BABYLON", "BabylonJS");
            if (string.IsNullOrWhiteSpace(namespaceReplaced))
            {
                namespaceReplaced = "BabylonJS";
            }
            classTokenMap["[[NAMESPACE]]"] = namespaceReplaced;
            classTokenMap["[[CLASS_NAME]]"] = classStatement.Name;

            classTokenMap["[[INTERFACE_SECTION]]"] = InterfaceSectionWriter.Write(
                classStatement,
                classGenerationTemplates
            );
            classTokenMap["[[INTERFACE_POSTFIX]]"] = classStatement.IsInterface ? Constants.INTERFACE_POSTFIX : string.Empty;
            classTokenMap["[[EXTENDED_CLASSES_SECTION]]"] = BuildExtendedClassesSection(
                classStatement
            );
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

            var classStringBuilder = new StringBuilder(
                classGenerationTemplates.Class
            );
            classStringBuilder = classTokenMap.Aggregate(
                classStringBuilder,
                (acc, token) => acc.Replace(
                    token.Key,
                    token.Value
                )
            );

            return classStringBuilder.ToString();
        }

        /// <summary>
        /// : classStatement.ExtendedClassNames
        /// </summary>
        /// <param name="classStatement"></param>
        /// <returns></returns>
        private static string BuildExtendedClassesSection(
            ClassStatement classStatement
        )
        {
            // Check if extendedClassName is interface
            // If all are interfaces, add ClientEntity
            var interfaceNames = classStatement.ImplementedInterfaceNames;
            if (classStatement.IsInterface)
            {
                // The classStatament if for an interface, so the class will postfixed with an identifier.
                // And will need to be inherited from its created interface.
                interfaceNames.Add(classStatement.Name);
            }

            if (!classStatement.ExtendedClassNames.Any()
                && !interfaceNames.Any())
            {
                return " : CachedEntityObject";
            }
            if (!classStatement.ExtendedClassNames.Any())
            {
                classStatement.ExtendedClassNames.Add(
                    "CachedEntityObject"
                );
            }

            return " : " + string.Join(
                ", ",
                classStatement.ExtendedClassNames.Concat(
                    interfaceNames
                ).Distinct()
            );
        }

    }
}
