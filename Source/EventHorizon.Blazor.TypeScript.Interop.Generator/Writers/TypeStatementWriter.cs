using System;
using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers
{
    public class TypeStatementWriter
    {
        public static string Write(
            TypeStatement type,
            bool includeArraySymbol = true,
            bool ignorePrefix = false
        )
        {
            if (type.IsTypeAlias 
                && !type.IsNullable
                && !type.IsModifier
                && !type.IsArray
            )
            {
                type = type.AliasType;
            }
            var name = type.Name;
            var genericTypesAsString = string.Empty;
            // Observer -> PickerInfo -> PickerData
            // Observer<PickerInfo<PickerData>>   [[INTERFACE_POSTFIX]]
            //var standardTemplate = "[[NAME]]";
            //var actionVoidTemplate = "ActionCallback";
            //var actionTemplate = "ActionCallback<[[GENERIC_TYPES]]>";
            //var taskVoidTemplate = "ValueTask";
            //var taskTemplate = "ValueTask<[[GENERIC_TYPES]]>";
            //var rootTaskTemplate = "[[GENERIC_TYPES]]";
            //var standardArrayTemplate = "[[NAME]][]";
            //var standardPostfixTemplate = "[[NAME]][[INTERFACE_POSTFIX]]";
            //var genericTemplate = "[[NAME]]<[[GENERIC_TYPES]]>";
            //var genericPostfixTemplate = "[[NAME]][[INTERFACE_POSTFIX]]<[[GENERIC_TYPES]]>";
            //var arrayTemplate = "[[GENERIC_TYPES]][]";
            //var rootArrayTemplate = "[[GENERIC_TYPES]]";
            var template = TypeStatementTemplates.StandardTemplate;
            if (type.IsInterface)
            {
                template = TypeStatementTemplates.StandardPostfixTemplate;
            }
            if (type.IsArray)
            {
                template = TypeStatementTemplates.StandardArrayTemplate;
            }

            if (type.GenericTypes.Any())
            {
                template = TypeStatementTemplates.GenericTemplate;
                if (type.IsInterface)
                {
                    template = TypeStatementTemplates.GenericPostfixTemplate;
                }
                if (type.IsArray)
                {
                    template = TypeStatementTemplates.ArrayTemplate;
                }
                var genericTypes = type.GenericTypes.Select(
                    a => Write(
                        a,
                        includeArraySymbol,
                        ignorePrefix
                    )
                );

                genericTypesAsString = string.Join(
                    ", ",
                    genericTypes
                );
            }
            if (type.IsNullable
                || type.IsModifier
                || (type.IsArray && type.GenericTypes.Any() && !includeArraySymbol)
            )
            {
                template = TypeStatementTemplates.RootArrayTemplate;
            }
            if (type.IsAction)
            {
                template = TypeStatementTemplates.ActionTemplate;

                if (!type.GenericTypes.Any())
                {
                    template = TypeStatementTemplates.ActionVoidTemplate;
                }
            }
            if (type.IsTask)
            {
                template = TypeStatementTemplates.TaskTemplate;
                if (!includeArraySymbol)
                {
                    template = TypeStatementTemplates.RootTaskTemplate;
                }

                if (!type.GenericTypes.Any()
                    || type.GenericTypes.Any(type => type.Name == "void"))
                {
                    template = TypeStatementTemplates.TaskVoidTemplate;
                    if (!includeArraySymbol)
                    {
                        template = TypeStatementTemplates.RootTaskTemplate;
                    }
                }
            }
            if (type.IsEnum)
            {
                template = template.Replace(
                    "[[NAME]]",
                    "int"
                );
            }

            return template.Replace(
                "[[NAME]]",
                name
            ).Replace(
                "[[GENERIC_TYPES]]",
                genericTypesAsString
            ).Replace(
                "[[INTERFACE_POSTFIX]]",
                ignorePrefix ? string.Empty : Constants.INTERFACE_POSTFIX
            );
        }
    }
}
