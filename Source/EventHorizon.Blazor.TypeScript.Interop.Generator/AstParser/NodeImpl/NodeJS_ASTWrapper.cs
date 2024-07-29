namespace EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl;

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Text.Json;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Api;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.NodeImpl.Model;
using Jering.Javascript.NodeJS;

[ExcludeFromCodeCoverage]
public class NodeJS_ASTWrapper : AbstractSyntaxTree
{
    public NodeJS_ASTWrapper(string source)
    {
        var nodeJSPath = Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            "AstParser",
            "NodeImpl",
            "NodeJS"
        );
        var nodeModulesPath = Path.Combine(nodeJSPath, "node_modules");
        var indexJSPath = Path.Combine(nodeJSPath, "index.js");
        // Check for existing node_modules, install if needed
        if (!Directory.Exists(nodeModulesPath))
        {
            var cmdProcessInfo = new ProcessStartInfo
            {
                FileName = "npm",
                WorkingDirectory = nodeJSPath,
                UseShellExecute = true,
                Arguments = "install",
            };
            var cmdProcess = Process.Start(cmdProcessInfo);
            cmdProcess.WaitForExit();
        }

        var fileContent = StaticNodeJSService
            .InvokeFromFileAsync<string>(indexJSPath, args: new object[] { source })
            .GetAwaiter()
            .GetResult();

        // TEST: Uncomment to view the generated AST
        // WriteAstJsonToFile(fileContent);

        var ast = JsonSerializer.Deserialize<ASTModel>(
            fileContent,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true, }
        );

        RootNode = new NodeJS_Node(ast.Program);
    }

    private static void WriteAstJsonToFile(string fileContent)
    {
        Directory.CreateDirectory(
            Path.Combine(".", "AstParser", "NodeImpl", "NodeJS", "_generated")
        );
        File.WriteAllText(
            Path.Combine(".", "AstParser", "NodeImpl", "NodeJS", "_generated", "ast.json"),
            fileContent
        );
    }

    public Node RootNode { get; }

    public IEnumerable<Node> OfKind(string kind)
    {
        return RootNode.OfKind(kind);
    }
}
