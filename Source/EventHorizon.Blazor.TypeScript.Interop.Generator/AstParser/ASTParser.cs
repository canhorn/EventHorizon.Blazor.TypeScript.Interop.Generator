namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;

    public static class ASTParser
    {
        public static AbstractSyntaxTree ParseText(
            string source,
            ASTParserOptions options
        )
        {
            return new Sdcb_TypeScriptASTWrapper(
                source
            );
        }
    }

    public class ASTParserOptions
    {

    }
}
