using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers;

public static class PropertiesSectionWriter
{
    public static string Write(
        ClassStatement classStatement,
        IEnumerable<PublicPropertyStatement> properties,
        ClassGenerationTemplates templates
    )
    {
        if (properties.Count() == 0)
        {
            return string.Empty;
        }
        var section = new StringBuilder();
        var current = 1;
        foreach (var property in properties)
        {
            GlobalLogger.Info($"Generating Property: {property}");
            var isLast = current == properties.Count();
            var isClassResponse = ClassResponseIdentifier.Identify(
                property.Type,
                property.UsedClassNames
            );
            var isLiteral = TypeLiteralIdentifier.Identify(property.Type);
            var isArray = ArrayResponseIdentifier.Identify(property.Type);
            var isNotSupported = NotSupportedIdentifier.Identify(property);
            var isEnum = TypeEnumIdentifier.Identify(property.Type);

            var template = templates.AccessorWithSetter;
            var propertyGetterResultType = templates.InteropGet;
            var root = "this.___guid";
            var namespaceParts = classStatement.Namespace.Split(".");
            var entityNamespace =
                string.Join(", ", namespaceParts.Select(part => @$"""{part}""")) + ", ";
            var propertyIdentifier = property.Name;
            var propertyGetterTemplate = templates.ReturnTypePrimitiveTemplate;
            var cacheSection = string.Empty;
            var cacheSetterSection = string.Empty;

            if (property.IsReadonly)
            {
                template = templates.Accessor;
            }

            if (entityNamespace == @""""", ")
            {
                entityNamespace = string.Empty;
            }

            if (property.IsStatic)
            {
                root = $"\"{namespaceParts.FirstOrDefault()}\"";
                propertyIdentifier = string.Join(
                    ".",
                    namespaceParts.Skip(1).Select(part => @$"{part}")
                );
                if (propertyIdentifier.Length > 0)
                {
                    propertyIdentifier += $".{classStatement.Name}.{property.Name}";
                }
                else
                {
                    propertyIdentifier = $"{classStatement.Name}.{property.Name}";
                    if (entityNamespace == string.Empty)
                    {
                        root = $"\"{classStatement.Name}\"";
                        propertyIdentifier = property.Name;
                    }
                }
            }

            if (isEnum)
            {
                propertyGetterResultType = templates.InteropGet;
            }
            else if (isClassResponse && isArray)
            {
                propertyGetterResultType = templates.InteropGetArrayClass;
            }
            else if (isClassResponse)
            {
                propertyGetterTemplate = templates.ReturnTypeClass;
                propertyGetterResultType = templates.InteropGetClass;
                cacheSection = "private [[STATIC]][[TYPE]] __[[CACHE_NAME]];";
                cacheSetterSection = "__[[CACHE_NAME]] = null;";
            }
            else if (isArray && isLiteral)
            {
                propertyGetterResultType = templates.InteropGetArrayClass;
            }
            else if (isArray)
            {
                propertyGetterResultType = templates.InteropGetArray;
            }
            else if (isLiteral && property.Type.Name == GenerationIdentifiedTypes.CachedEntity)
            {
                propertyGetterResultType = templates.InteropGetClass;
            }

            if (isNotSupported)
            {
                template = "// [[NAME]] is not supported by the platform yet";
            }

            template = template
                .Replace("[[PROPERTY_GETTER]]", propertyGetterTemplate)
                .Replace("[[PROPERTY_SETTER]]", templates.InteropSet)
                .Replace("[[RETURN_TYPE_CONTENT]]", propertyGetterResultType)
                .Replace("[[PROPERTY_NAMESPACE]]", entityNamespace)
                .Replace("[[CACHE_SECTION]]", cacheSection)
                .Replace("[[CACHE_SETTTER_SECTION]]", cacheSetterSection)
                .Replace("[[STATIC]]", property.IsStatic ? "static " : string.Empty)
                .Replace("[[ARRAY]]", string.Empty)
                .Replace("[[NAME]]", DotNetNormalizer.Normalize(property.Name))
                .Replace("[[CACHE_NAME]]", property.Name)
                .Replace("[[NAME_CAPTIALIZED]]", property.Name.Captialize())
                .Replace("[[TYPE]]", TypeStatementWriter.Write(property.Type))
                .Replace("[[ARRAY_TYPE]]", TypeStatementWriter.Write(property.Type, false))
                .Replace("[[NEW_TYPE]]", TypeStatementWriter.Write(property.Type, false))
                .Replace("[[PROPERTY]]", propertyIdentifier)
                .Replace("[[PROPERTY_ARGUMENTS]]", string.Empty)
                .Replace("[[ROOT]]", root)
                .Replace(
                    "[[INTERFACE_POSTFIX]]",
                    property.IsInterfaceResponse ? Constants.INTERFACE_POSTFIX : string.Empty
                );
            section.Append(template);
            if (!isLast)
            {
                section.Append(Environment.NewLine).Append(Environment.NewLine);
            }
            current++;
        }
        return section.ToString();
    }
}
