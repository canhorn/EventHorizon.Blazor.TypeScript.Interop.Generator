// import * as ts from 'typescript';
import * as fs from 'fs';
import * as recast from 'recast';
import * as tsParser from 'recast/parsers/typescript';

// function printAllChildren(node: ts.Node, depth = 0) {
//     console.log(
//         new Array(depth + 1).join('----'),
//         ts.formatSyntaxKind(node.kind),
//         node.pos,
//         node.end
//     );
//     depth++;
//     node.getChildren().forEach((c) => printAllChildren(c, depth));
// }

var sourceCode = `
var foo = 123;
`.trim();

// var sourceFile = ts.createSourceFile(
//     'foo.ts',
//     sourceCode,
//     ts.ScriptTarget.ES5,
//     true
// );

// console.log((sourceFile as any).ast);

// const sourceFileCode = fs.readFileSync('./SourceFiles/monaco.d.ts', {
const sourceFileCode = fs.readFileSync(
    './ConsolidatedSourceFiles/consolidated-source.d.ts',
    {
        encoding: 'utf-8',
    }
);

const ast = recast.parse(sourceFileCode, {
    parser: tsParser,
});
const replacerFunc = () => {
    const visited = new WeakSet();
    return (key, value) => {
        if (typeof value === 'object' && value !== null) {
            if (visited.has(value)) {
                return;
            }
            visited.add(value);
        }
        return value;
    };
};
// console.log(JSON.stringify(ast, replacerFunc, 2));

if (!fs.existsSync('./_generated')) {
    fs.mkdirSync('./_generated');
}

fs.writeFileSync(
    './_generated/ast.json',
    JSON.stringify(ast, replacerFunc(), 2)
);
