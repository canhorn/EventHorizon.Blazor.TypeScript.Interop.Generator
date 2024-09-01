namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventHorizon.Blazor.TypeScript.Interop.Generator.AstParser.Model;
using Xunit;

public class WipGenerationTests : GenerateStringTestBase
{
    [Theory(DisplayName = "WIP")]
    [Trait("Category", "WIP")]
    [Trait("AST", "Sdcb")]
    [InlineData("WIP.ts", "WIP", "WIP.Expected.txt", ASTParserType.Sdcb)]
    [InlineData("WIP.ts", "WIP", "WIP.Expected.txt", ASTParserType.NodeJS)]
    public void WIP(
        string sourceFile,
        string path,
        string expectedFile,
        ASTParserType parserType
    ) => ValidateGenerateStrings(path, sourceFile, expectedFile, parserType: parserType);
}

// public class ArrayResponseIdentifier{
// private bool _isIterateOverAllInstancesEnabled = false;
//         private readonly IDictionary<string, Func<string, System.Nullable<decimal>, Task>> _iterateOverAllInstancesActionMap = new Dictionary<string, Func<string, System.Nullable<decimal>, Task>>();

//         public string iterateOverAllInstances(
//             Func<string, System.Nullable<decimal>, Task> callback
//         )
//         {
//             SetupIterateOverAllInstancesLoop();

//             var handle = Guid.NewGuid().ToString();
//             _iterateOverAllInstancesActionMap.Add(
//                 handle,
//                 callback
//             );

//             return handle;
//         }

//         public bool iterateOverAllInstances_Remove(
//             string handle
//         )
//         {
//             return _iterateOverAllInstancesActionMap.Remove(
//                 handle
//             );
//         }

//         private void SetupIterateOverAllInstancesLoop()
//         {
//             if (_isIterateOverAllInstancesEnabled)
//             {
//                 return;
//             }
//             _isIterateOverAllInstancesEnabled = true;
//         }

//         public async Task CallIterateOverAllInstancesActions(string body, System.Nullable<System.Nullable<decimal>> instanceIndex)
//         {
//             foreach (var action in _iterateOverAllInstancesActionMap.Values)
//             {
//                 await action(body, instanceIndex);
//             }
//         }}
