namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser
{
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.SdcdImpl;

    public static class ASTParser
    {
        public static AbstractSyntaxTree ParseText(
            string source,
            ASTParserOptions options
        )
        {
            if (options.ParserType == ASTParserType.NodeJS)
            {
                return new NodeJS_ASTWrapper(
                    source
                );
            }
            return new Sdcb_TypeScriptASTWrapper(
                source
            );
        }
    }

    public class ASTParserOptions
    {
        public ASTParserType ParserType { get; set; } = ASTParserType.Sdcb;
    }
}
