using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Identifiers;
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
                var isLast = current == accessors.Count();
                var isClassResponse = accessor.UsedClassNames.Any(a => a == accessor.Type);
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

                if (isClassResponse && accessor.IsArrayResponse)
                {
                    propertyGetterResultType = templates.InteropGetArrayClass;
                }
                else if (isClassResponse)
                {
                    propertyGetterTemplate = templates.ReturnTypeClass;
                    propertyGetterResultType = templates.InteropGetClass;
                    cacheSection = "private [[STATIC]][[TYPE]] __[[NAME]];";
                    cacheSetterSection = "__[[NAME]] = null;";
                }
                else if (accessor.IsArrayResponse)
                {
                    propertyGetterResultType = templates.InteropGetArray;
                }

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
                        "[[PROPERTYTYPE]]",
                        classStatement.Name
                    ).Replace(
                        "[[STATIC]]",
                        accessor.IsStatic ? "static " : string.Empty
                    ).Replace(
                        "[[ARRAY]]",
                        accessor.IsArrayResponse ? "[]" : string.Empty
                    ).Replace(
                        "[[NAME]]",
                        DotNetNormailzer.Normailze(
                            accessor.Name
                        )
                    ).Replace(
                        "[[NAME_CAPTIALIZED]]",
                        accessor.Name.Captialize()
                    ).Replace(
                        "[[TYPE]]",
                        accessor.Type
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
                        accessor.IsInterfaceResponse ? Constants.InterfacePostfix : string.Empty
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
