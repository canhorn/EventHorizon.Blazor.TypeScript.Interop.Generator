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
            bool root = false,
            bool ignorePrefix = false
        )
        {
            var name = type.Name;
            var genericTypesAsString = string.Empty;
            // Observer -> PickerInfo -> PickerData
            // Observer<PickerInfo<PickerData>>   [[INTERFACE_POSTFIX]]
            var standardTemplate = "[[NAME]]";
            var actionVoidTemplate = "ActionCallback";
            var actionTemplate = "ActionCallback<[[GENERIC_TYPES]]>";
            var standardArrayTemplate = "[[NAME]][]";
            var standardPostfixTemplate = "[[NAME]][[INTERFACE_POSTFIX]]";
            var genericTemplate = "[[NAME]]<[[GENERIC_TYPES]]>";
            var genericPostfixTemplate = "[[NAME]][[INTERFACE_POSTFIX]]<[[GENERIC_TYPES]]>";
            var arrayTemplate = "[[GENERIC_TYPES]][]";
            var rootArrayTemplate = "[[GENERIC_TYPES]]";
            var template = standardTemplate;
            if (type.IsInterface)
            {
                template = standardPostfixTemplate;
            }
            if (type.IsArray)
            {
                template = standardArrayTemplate;
            }

            if (type.GenericTypes.Any())
            {
                template = genericTemplate;
                if (type.IsInterface)
                {
                    template = genericPostfixTemplate;
                }
                if (type.IsArray)
                {
                    template = arrayTemplate;
                }
                var genericTypes = type.GenericTypes.Select(
                    a => Write(
                        a,
                        root && (type.IsNullable || type.IsModifier)
                    )
                );

                genericTypesAsString = string.Join(
                    ", ",
                    genericTypes
                );
            }
            if (type.IsNullable
                || type.IsModifier
                || (type.IsArray && root)
            )
            {
                template = rootArrayTemplate;
            }
            if (type.IsAction)
            {
                template = actionTemplate;

                if (!type.GenericTypes.Any())
                {
                    template = actionVoidTemplate;
                }
            }
            if(type.IsEnum)
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
