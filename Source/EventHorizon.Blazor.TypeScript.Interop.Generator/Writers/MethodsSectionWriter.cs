using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Sources;
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
                var isClassResponse = ClassResponseIdentifier.Identify(
                    method.Type,
                    method.UsedClassNames
                );
                var isArray = ArrayResponseIdentifier.Identify(method.Type);
                var template = templates.Method;
                var methodType = method.Type;
                var type = TypeStatementWriter.Write(methodType);
                var typeNoModifier = TypeStatementWriter.Write(methodType, false);
                var propertyArguments = string.Empty;
                var isNotSupported = NotSupportedIdentifier.Identify(method);
                var isTask = method.Type.IsTask;
                var isEnum = TypeEnumIdentifier.Identify(method.Type);
                var isAction =
                    method.Type.Name == GenerationIdentifiedTypes.Action
                    || (method.Arguments.Take(1).Any(a => a.Type.IsAction && a.Name == "callback"));

                var bodyTemplate = templates.ReturnTypePrimitiveTemplate;
                var returnTypeContent = templates.InteropFunc;
                var arguments = string.Empty;
                var argumentStrings = new List<string>();
                var classNamespace = classStatement.Namespace;
                var namespacedMethod = string.Join(
                    ".",
                    classNamespace,
                    classStatement.Name,
                    method.Name
                );
                var propertyIdentifier = "this.___guid";
                // [[FUNCTION_GENERICS]] = functionGenerics = T, EventState, Task
                var functionGenerics = string.Empty;
                var genericSection = string.Empty;
                var whereConstraint = string.Empty;
                var taskType = TypeStatementWriter.Write(methodType, false);
                var taskAsync = string.Empty;
                var taskAwait = string.Empty;

                if (classNamespace == string.Empty)
                {
                    namespacedMethod = string.Join(".", classStatement.Name, method.Name);
                }

                // Argument Generation
                if (isAction)
                {
                    var functionGenericsStrings = new List<string>();
                    var actionArgument = method.Arguments.FirstOrDefault(argument =>
                        argument.Type.Name == GenerationIdentifiedTypes.Action
                    );
                    if (actionArgument != null)
                    {
                        foreach (var genericType in actionArgument.Type.GenericTypes)
                        {
                            functionGenericsStrings.Add(
                                TypeStatementWriter.Write(genericType, ignorePrefix: true)
                            );
                        }

                        // [[ARGUMENTS]] = arguments = T eventData, EventState eventState
                        foreach (
                            var argument in actionArgument.Type.Arguments.OrderBy(a => a.IsOptional)
                        )
                        {
                            argumentStrings.Add(
                                ArgumentWriter.Write(
                                    argument,
                                    true,
                                    string.Empty,
                                    ignorePrefix: false
                                )
                            );
                        }
                        // [[PROPERTY_ARGUMENTS]] = propertyArguments = eventData, eventState
                        propertyArguments = string.Join(
                            ", ",
                            actionArgument.Type.Arguments.Select(argument =>
                                DotNetNormalizer.Normalize(argument.Name)
                            )
                        );
                    }

                    functionGenericsStrings.Add("Task");
                    functionGenerics = string.Join(", ", functionGenericsStrings);
                }
                else
                {
                    // TODO: [Re-factor] : Move to Writer
                    foreach (var argument in method.Arguments.OrderBy(a => a.IsOptional))
                    {
                        argumentStrings.Add(ArgumentWriter.Write(argument, true, " = null"));
                    }
                    propertyArguments = method.Arguments.Any()
                        ? ", "
                            + string.Join(
                                ", ",
                                method.Arguments.Select(argument =>
                                    DotNetNormalizer.Normalize(argument.Name)
                                )
                            )
                        : string.Empty;

                    if (VoidArgumentIdenfifier.Identify(method.Arguments))
                    {
                        GlobalLogger.Error($"Found void argument in method: {method.Name}");
                        continue;
                    }
                }

                arguments = string.Join(", ", argumentStrings);

                // Template/ReturnTypeContent Dictation
                if (isAction)
                {
                    template = templates.MethodActionTemplate;
                    bodyTemplate = templates.ReturnTypeVoidTemplate;

                    if (method.IsStatic)
                    {
                        template = templates.MethodStaticActionTemplate;
                    }
                }

                if (isEnum)
                {
                    returnTypeContent = templates.InteropFunc;
                }
                else if (isClassResponse && isArray)
                {
                    returnTypeContent = templates.InteropFuncArrayClass;
                }
                else if (isClassResponse)
                {
                    returnTypeContent = templates.InteropFuncClass;
                }
                else if (isArray)
                {
                    returnTypeContent = templates.InteropFuncArray;
                }

                if (isTask)
                {
                    returnTypeContent = templates.InteropTask;

                    if (isClassResponse && isArray)
                    {
                        returnTypeContent = templates.InteropTaskArrayClass;
                    }
                    else if (isClassResponse || taskType == GenerationIdentifiedTypes.CachedEntity)
                    {
                        returnTypeContent = templates.InteropTaskClass;
                    }
                    else if (isArray)
                    {
                        returnTypeContent = templates.InteropTaskArray;
                    }

                    // Change up the taskType if 'void';
                    if (taskType == GenerationIdentifiedTypes.Void)
                    {
                        bodyTemplate = templates.ReturnTypeVoidTemplate;
                        taskType = GenerationIdentifiedTypes.CachedEntity;
                        taskAsync = "async ";
                        taskAwait = "await ";
                    }
                }

                if (method.IsStatic)
                {
                    var classStatementIdentitiferList = new string[] { classStatement.Name, };
                    if (classNamespace != string.Empty)
                    {
                        classStatementIdentitiferList = new string[]
                        {
                            classStatement.Namespace,
                            classStatement.Name,
                        };
                    }
                    propertyIdentifier = string.Join(
                        ", ",
                        string.Join(".", classStatementIdentitiferList)
                            .Split(".")
                            .Select(part => @$"""{part}""")
                    );
                }

                // Replace the Type in the Return TypeContent to Object
                // This is to avoid parsing errors and just get a generic object back from method calls.
                if (method.Type.Name == GenerationIdentifiedTypes.Void)
                {
                    bodyTemplate = templates.ReturnTypeVoidTemplate;
                    returnTypeContent = returnTypeContent
                        .Replace("[[ARRAY_TYPE]]", GenerationIdentifiedTypes.CachedEntity)
                        .Replace("[[NEW_TYPE]]", GenerationIdentifiedTypes.CachedEntity);
                }

                if (method.GenericTypes.Any())
                {
                    var genericTypeString = string.Join(", ", method.GenericTypes);
                    // TODO: [Template] : Move to templates
                    genericSection = $"<{genericTypeString}>";

                    if (
                        isClassResponse
                        && method.GenericTypes.Any(genericType => genericType == typeNoModifier)
                    )
                    {
                        // TODO: [Template] : Move to templates
                        whereConstraint = string.Join(
                            "",
                            method.GenericTypes.Select(genericType =>
                                $" where {genericType} : CachedEntity, new()"
                            )
                        );
                    }
                }

                if (isNotSupported)
                {
                    template = "// [[NAME]] is not supported by the platform yet";
                }

                template = template
                    .Replace("[[BODY]]", bodyTemplate)
                    .Replace("[[RETURN_TYPE_CONTENT]]", returnTypeContent)
                    .Replace("[[NAMESPACED_METHOD]]", namespacedMethod)
                    //.Replace(
                    //    "[[CACHE_SECTION]]",
                    //    string.Empty
                    //).Replace(
                    //    "[[CACHE_SETTTER_SECTION]]",
                    //    string.Empty
                    //)
                    .Replace("[[ARRAY]]", string.Empty)
                    .Replace("[[STATIC]]", method.IsStatic ? "static " : string.Empty)
                    .Replace("[[NAME]]", DotNetNormalizer.Normalize(method.Name))
                    .Replace("[[NAME_CAPTIALIZED]]", method.Name.Captialize())
                    .Replace("[[CLASS_NAME]]", classStatement.Name)
                    .Replace("[[TYPE]]", TypeStatementWriter.Write(methodType))
                    .Replace("[[ARRAY_TYPE]]", TypeStatementWriter.Write(methodType, false))
                    .Replace("[[NEW_TYPE]]", TypeStatementWriter.Write(methodType, false))
                    .Replace("[[TASK_TYPE]]", taskType)
                    .Replace("[[GENERIC_SECTION]]", genericSection)
                    .Replace("[[ARGUMENTS]]", arguments)
                    .Replace("[[WHERE_CONSTRAINT]]", whereConstraint)
                    .Replace("[[PROPERTY_IDENTIFIER]]", propertyIdentifier)
                    .Replace("[[PROPERTY]]", DotNetNormalizer.Normalize(method.Name))
                    .Replace("[[PROPERTY_ARGUMENTS]]", propertyArguments)
                    .Replace(
                        "[[INTERFACE_POSTFIX]]",
                        method.IsInterfaceResponse ? Constants.INTERFACE_POSTFIX : string.Empty
                    )
                    .Replace("[[FUNCTION_GENERICS]]", functionGenerics)
                    .Replace("[[TASK_ASYNC]]", taskAsync)
                    .Replace("[[TASK_AWAIT]]", taskAwait);

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
}
