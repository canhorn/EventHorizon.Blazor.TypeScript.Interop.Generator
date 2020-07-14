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
    public static class MethodsSectionWriter
    {
        public static string Write(
            ClassStatement classStatement,
            IEnumerable<PublicMethodStatement> methods,
            ClassGenerationTemplates templates
        )
        {
            if (methods.Count() == 0)
            {
                return string.Empty;
            }
            var section = new StringBuilder();
            var current = 1;
            foreach (var method in methods)
            {
                GlobalLogger.Info($"Generating Method: {method}");
                var isLast = current == methods.Count();
                var isClassResponse = method.UsedClassNames.Any(a => a == method.Type);
                var template = templates.Method;
                var methodType = method.Type;
                var propertyArguments = string.Empty;

                var bodyTemplate = templates.ReturnTypePrimitiveTemplate;
                var returnTypeContent = templates.InteropFunc;
                var arguments = string.Empty;
                var argumentStrings = new List<string>();
                var namespacedMethod = string.Join(
                    ".",
                    classStatement.Namespace,
                    classStatement.Name,
                    method.Name
                );
                var propertyIdentifier = "this.___guid";

                // Argument Generation
                foreach (var argument in method.Arguments.OrderBy(a => a.IsOptional))
                {
                    var argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]]";
                    if (argument.IsOptional)
                    {
                        argumentsTemplate = "System.Nullable<[[TYPE]][[IS_ARRAY]]> [[NAME]] = null";
                        if (ClassIdentifier.Identify(
                            argument.UsedClassNames,
                            argument.Type
                        ) || argument.IsArrayResponse)
                        {
                            argumentsTemplate = "[[TYPE]][[IS_ARRAY]] [[NAME]] = null";
                        }
                    }
                    var argumentString = argumentsTemplate.Replace(
                        "[[NAME]]",
                        DotNetNormailzer.Normailze(argument.Name)
                    ).Replace(
                        "[[TYPE]]",
                        argument.Type
                    ).Replace(
                        "[[IS_ARRAY]]",
                        argument.IsArrayResponse ? "[]" : string.Empty
                    );
                    argumentStrings.Add(
                        argumentString
                    );
                }

                if (VoidArgumentIdenfifier.Identify(method.Arguments))
                {
                    GlobalLogger.Error(
                        $"Found void argument in method: {method.Name}"
                    );
                    continue;
                }

                arguments = string.Join(
                    ", ",
                    argumentStrings
                );
                propertyArguments = method.Arguments.Any()
                    ? ", " +
                        string.Join(
                            ", ",
                            method.Arguments.Select(
                                argument => DotNetNormailzer.Normailze(argument.Name)
                            )
                        )
                    : string.Empty;


                // Template/ReturnTypeContent Dictation
                if (method.Type == GenerationIdentifiedTypes.Action
                    || method.Arguments.Any(a => a.Type == GenerationIdentifiedTypes.Action))
                {
                    template = templates.MethodActionTemplate;
                    bodyTemplate = templates.ReturnTypeVoidTemplate;

                    if (method.IsStatic)
                    {
                        template = templates.MethodStaticActionTemplate;
                    }
                }

                if (isClassResponse && method.IsArrayResponse)
                {
                    returnTypeContent = templates.InteropFuncArrayClass;
                }
                else if (isClassResponse)
                {
                    returnTypeContent = templates.InteropFuncClass;
                }
                else if (method.IsArrayResponse)
                {
                    returnTypeContent = templates.InteropFuncArray;
                }


                if (method.IsStatic)
                {
                    propertyIdentifier = string.Join(
                        ", ",
                        string.Join(
                            ".",
                            classStatement.Namespace,
                            classStatement.Name
                        ).Split(".").Select(part => @$"""{part}""")
                    );
                }

                // Replace the Type in the Return TypeContent to Object
                // This is to avoid parsing errors and just get a generic object back from method calls.
                if (method.Type == GenerationIdentifiedTypes.Void)
                {
                    bodyTemplate = templates.ReturnTypeVoidTemplate;
                    returnTypeContent = returnTypeContent.Replace(
                        "[[TYPE]]",
                        GenerationIdentifiedTypes.Object
                    );
                }


                template = template.Replace(
                    "[[BODY]]",
                    bodyTemplate
                ).Replace(
                    "[[RETURN_TYPE_CONTENT]]",
                    returnTypeContent
                ).Replace(
                    "[[NAMESPACED_METHOD]]",
                    namespacedMethod
                )
                //.Replace(
                //    "[[CACHE_SECTION]]",
                //    string.Empty
                //).Replace(
                //    "[[CACHE_SETTTER_SECTION]]",
                //    string.Empty
                //)
                .Replace(
                    "[[ARRAY]]",
                    method.IsArrayResponse ? "[]" : string.Empty
                ).Replace(
                    "[[STATIC]]",
                    method.IsStatic ? "static " : string.Empty
                ).Replace(
                    "[[NAME]]",
                    DotNetNormailzer.Normailze(
                        method.Name
                    )
                ).Replace(
                    "[[NAME_CAPTIALIZED]]",
                    method.Name.Captialize()
                ).Replace(
                    "[[CLASS_NAME]]",
                    classStatement.Name
                ).Replace(
                    "[[TYPE]]",
                    methodType
                ).Replace(
                    "[[ARGUMENTS]]",
                    arguments
                ).Replace(
                    "[[PROPERTY_IDENTIFIER]]",
                    propertyIdentifier
                ).Replace(
                    "[[PROPERTY]]",
                    DotNetNormailzer.Normailze(
                        method.Name
                    )
                ).Replace(
                    "[[PROPERTY_ARGUMENTS]]",
                    propertyArguments
                ).Replace(
                    "[[INTERFACE_POSTFIX]]",
                    method.IsInterfaceResponse ? Constants.InterfacePostfix : string.Empty
                );

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
