namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model
{
    public static class TypeStatementTemplates
    {
        public static string StandardTemplate { get; set; } = "[[NAME]]";
        public static string ActionVoidTemplate { get; set; } = "ActionCallback";
        public static string ActionTemplate { get; set; } = "ActionCallback<[[GENERIC_TYPES]]>";
        public static string ActionResultTemplate { get; set; } = "ActionResultCallback<[[ACTION_RESULT]]>";
        public static string ActionResultArgsTemplate { get; set; } = "ActionResultCallback<[[GENERIC_TYPES]], [[ACTION_RESULT]]>";
        public static string TaskVoidTemplate { get; set; } = "ValueTask";
        public static string TaskTemplate { get; set; } = "ValueTask<[[GENERIC_TYPES]]>";
        public static string RootTaskTemplate { get; set; } = "[[GENERIC_TYPES]]";
        public static string StandardArrayTemplate { get; set; } = "[[NAME]][]";
        public static string StandardPostfixTemplate { get; set; } = "[[NAME]][[INTERFACE_POSTFIX]]";
        public static string GenericTemplate { get; set; } = "[[NAME]]<[[GENERIC_TYPES]]>";
        public static string GenericPostfixTemplate { get; set; } = "[[NAME]][[INTERFACE_POSTFIX]]<[[GENERIC_TYPES]]>";
        public static string ArrayTemplate { get; set; } = "[[GENERIC_TYPES]][]";
        public static string RootArrayTemplate { get; set; } = "[[GENERIC_TYPES]]";
    }
}
