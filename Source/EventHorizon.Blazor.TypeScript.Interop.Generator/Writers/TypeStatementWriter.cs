using System.Linq;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers;

public class TypeStatementWriter
{
    public static string Write(
        TypeStatement type,
        bool includeArraySymbol = true,
        bool ignorePrefix = false
    )
    {
        if (
            type.IsTypeAlias
            && !type.IsNullable
            && !type.IsModifier
            && !type.IsArray
            && !type.IsReadonly
        )
        {
            type = type.AliasType;
        }
        var name = type.Name;
        var genericTypesAsString = string.Empty;
        var actionResultTypeAsString = string.Empty;
        var template = TypeStatementTemplates.StandardTemplate;
        var interfacePostfix = ignorePrefix ? string.Empty : Constants.INTERFACE_POSTFIX;
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
            var genericTypes = type.GenericTypes.Select(a =>
                a.IsVoid
                    ? GenerationIdentifiedTypes.VoidNode
                    : Write(a, includeArraySymbol, ignorePrefix)
            );

            genericTypesAsString = string.Join(", ", genericTypes);
            if (genericTypesAsString == "void")
            {
                genericTypesAsString = GenerationIdentifiedTypes.CachedEntityObject;
            }
        }
        if (
            type.IsNullable
            || type.IsModifier
            || type.IsReadonly
            || (type.IsArray && type.GenericTypes.Any() && !includeArraySymbol)
        )
        {
            template = TypeStatementTemplates.RootArrayTemplate;
        }
        if (type.IsAction)
        {
            if (type.ActionResultType.IsTask || type.ActionResultType.IsVoid)
            {
                template = TypeStatementTemplates.ActionTemplate;

                if (!type.GenericTypes.Any())
                {
                    template = TypeStatementTemplates.ActionVoidTemplate;
                }
            }
            else
            {
                template = TypeStatementTemplates.ActionResultTemplate;

                if (type.GenericTypes.Any())
                {
                    template = TypeStatementTemplates.ActionResultArgsTemplate;
                }

                actionResultTypeAsString = Write(
                    type.ActionResultType,
                    includeArraySymbol,
                    ignorePrefix
                );
            }
        }
        if (type.IsTask)
        {
            template = TypeStatementTemplates.TaskTemplate;
            if (!includeArraySymbol)
            {
                template = TypeStatementTemplates.RootTaskTemplate;
            }

            if (!type.GenericTypes.Any() || type.GenericTypes.Any(type => type.IsVoid))
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
            template = template.Replace("[[NAME]]", "int");
        }

        return template
            .Replace("[[NAME]]", name)
            .Replace("[[GENERIC_TYPES]]", genericTypesAsString)
            .Replace("[[ACTION_RESULT]]", actionResultTypeAsString)
            .Replace("[[INTERFACE_POSTFIX]]", interfacePostfix);
    }
}
