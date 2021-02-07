var fs = require("fs");
var recast = require("recast");
var tsParser = require("recast/parsers/typescript");

module.exports = (callback, sourceFileCode) => {  // Module must export a function that takes a callback as its first parameter
    // var sourceFileCode = fs.readFileSync('./ConsolidatedSourceFiles/consolidated-source.d.ts', {
    //     encoding: 'utf-8'
    // });
    var ast = recast.parse(sourceFileCode, {
        parser: tsParser
    });
    var replacerFunc = function () {
        var visited = new WeakSet();
        return function (key, value) {
            if (typeof value === 'object' && value !== null) {
                if (visited.has(value)) {
                    return;
                }
                visited.add(value);
            }
            return value;
        };
    };
    callback(null, JSON.stringify(ast, replacerFunc(), 2));
};

//"use strict";
//exports.__esModule = true;
//// import * as ts from 'typescript';
//var fs = require("fs");
//var recast = require("recast");
//var tsParser = require("recast/parsers/typescript");
//// function printAllChildren(node: ts.Node, depth = 0) {
////     console.log(
////         new Array(depth + 1).join('----'),
////         ts.formatSyntaxKind(node.kind),
////         node.pos,
////         node.end
////     );
////     depth++;
////     node.getChildren().forEach((c) => printAllChildren(c, depth));
//// }
//var sourceCode = "\nvar foo = 123;\n".trim();
//// var sourceFile = ts.createSourceFile(
////     'foo.ts',
////     sourceCode,
////     ts.ScriptTarget.ES5,
////     true
//// );
//// console.log((sourceFile as any).ast);
//// const sourceFileCode = fs.readFileSync('./SourceFiles/monaco.d.ts', {
//var sourceFileCode = fs.readFileSync('./ConsolidatedSourceFiles/consolidated-source.d.ts', {
//    encoding: 'utf-8'
//});
//var ast = recast.parse(sourceFileCode, {
//    parser: tsParser
//});
//var replacerFunc = function () {
//    var visited = new WeakSet();
//    return function (key, value) {
//        if (typeof value === 'object' && value !== null) {
//            if (visited.has(value)) {
//                return;
//            }
//            visited.add(value);
//        }
//        return value;
//    };
//};
//// console.log(JSON.stringify(ast, replacerFunc, 2));
//if (!fs.existsSync('./_generated')) {
//    fs.mkdirSync('./_generated');
//}
//fs.writeFileSync('./_generated/ast.json', JSON.stringify(ast, replacerFunc(), 2));
