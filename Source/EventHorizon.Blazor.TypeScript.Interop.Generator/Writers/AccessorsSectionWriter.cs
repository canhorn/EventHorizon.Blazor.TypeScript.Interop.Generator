using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Logging;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Normalizers;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    public static class AccessorsSectionWriter
    {
        public static string Write(
            ClassStatement classStatement,
            IEnumerable<AccessorStatement> accessors,
            ClassGenerationTemplates templates
        )
        {
            if (accessors.Count() == 0)
            {
                return string.Empty;
            }
            var section = new StringBuilder();
            var current = 1;
            foreach (var accessor in accessors)
            {
                GlobalLogger.Info($"Generating Accessor: {accessor}");
                var isLast = current == accessors.Count();
                var isClassResponse = ClassResponseIdentifier.Identify(
                    accessor.Type,
                    accessor.UsedClassNames
                );
                var isArray = ArrayResponseIdentifier.Identify(
                    accessor.Type
                );
                var template = templates.Accessor;
                var propertyGetterResultType = templates.InteropGet;
                var root = "this.___guid";
                var namespaceParts = classStatement.Namespace.Split(".");
                var entityNamespace = string.Join(
                    ", ",
                    namespaceParts.Select(part => @$"""{part}""")
                );
                var property = accessor.Name;
                var propertyGetterTemplate = templates.ReturnTypePrimitiveTemplate;
                var cacheSection = string.Empty;
                var cacheSetterSection = string.Empty;

                if (accessor.HasSetter)
                {
                    template = templates.AccessorWithSetter;
                }

                if (accessor.IsStatic)
                {
                    root = $"\"{namespaceParts.FirstOrDefault()}\"";
                    property = string.Join(
                        ".",
                        namespaceParts
                            .Skip(1)
                            .Select(part => @$"{part}")
                    );
                    if (property.Length > 0)
                    {
                        property += $".{classStatement.Name}.{accessor.Name}";
                    }
                    else
                    {
                        property = $"{classStatement.Name}.{accessor.Name}";
                    }
                }

                if (isClassResponse && isArray)
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
                else if (isArray)
                {
                    propertyGetterResultType = templates.InteropGetArray;
                }
                var propType = TypeStatementWriter.Write(
                    accessor.Type
                );
                var arrayType = TypeStatementWriter.Write(
                    accessor.Type,
                    true
                );
                var newType = TypeStatementWriter.Write(
                    accessor.Type,
                    true
                );

                template = template
                    .Replace(
                        "[[PROPERTY_GETTER]]",
                        propertyGetterTemplate
                    ).Replace(
                        "[[PROPERTY_SETTER]]",
                        templates.InteropSet
                    ).Replace(
                        "[[RETURN_TYPE_CONTENT]]",
                        propertyGetterResultType
                    ).Replace(
                        "[[PROPERTY_NAMESPACE]]",
                        entityNamespace
                    ).Replace(
                        "[[CACHE_SECTION]]",
                        cacheSection
                    ).Replace(
                        "[[CACHE_SETTTER_SECTION]]",
                        cacheSetterSection
                    ).Replace(
                        "[[CACHE_NAME]]",
                        accessor.Name
                    ).Replace(
                        "[[PROPERTYTYPE]]",
                        classStatement.Name
                    ).Replace(
                        "[[STATIC]]",
                        accessor.IsStatic ? "static " : string.Empty
                    ).Replace(
                        "[[ARRAY]]",
                        string.Empty
                    ).Replace(
                        "[[NAME]]",
                        DotNetNormalizer.Normalize(
                            accessor.Name
                        )
                    ).Replace(
                        "[[NAME_CAPTIALIZED]]",
                        accessor.Name.Captialize()
                    ).Replace(
                        "[[TYPE]]",
                        TypeStatementWriter.Write(
                            accessor.Type
                        )
                    ).Replace(
                        "[[ARRAY_TYPE]]",
                        TypeStatementWriter.Write(
                            accessor.Type,
                            true
                        )
                    ).Replace(
                        "[[NEW_TYPE]]",
                        TypeStatementWriter.Write(
                            accessor.Type,
                            true
                        )
                    ).Replace(
                        "[[PROPERTY]]",
                        property
                    ).Replace(
                        "[[PROPERTY_ARGUMENTS]]",
                        string.Empty
                    ).Replace(
                        "[[ROOT]]",
                        root
                    ).Replace(
                        "[[INTERFACE_POSTFIX]]",
                        accessor.IsInterfaceResponse ? Constants.INTERFACE_POSTFIX : string.Empty
                    )
                ;
                section.Append(
                    template
                );
                if (!isLast)
                {
                    section.Append(
                        Environment.NewLine
                    ).Append(
                        Environment.NewLine
                    );
                }
                current++;
            }
            return section.ToString();
        }
    }
}
