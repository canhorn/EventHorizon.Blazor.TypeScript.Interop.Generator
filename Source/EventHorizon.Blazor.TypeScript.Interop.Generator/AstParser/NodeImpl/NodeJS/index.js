"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var ts_morph_1 = require("ts-morph");
var fs = require("fs");

module.exports = (callback, sourceFileCode) => {
  var project = new ts_morph_1.Project({
    compilerOptions: {
      target: ts_morph_1.ScriptTarget.ES2017,
      module: ts_morph_1.ModuleKind.CommonJS,
      strict: true,
      lib: ["esnext"],
      esModuleInterop: true,
      sourceRoot: "src",
    },
  });
  //   var classesFile = project.addSourceFileAtPath(sourceFileCode);
  var classesFile = project.createSourceFile("source-code.ts", sourceFileCode);
//   var classesFileStructure = classesFile.getStructure();

  var keysToIgnore = [
    "id",
    "pos",
    "end",
    "flags",
    "transformFlags",
    "modifierFlagsCache",
    "parent",
    "compilerNode",
    "scriptSnapshot",
    "fileName",
    "text",
  ];
  var replacerFunc = function (key, value) {
    if (keysToIgnore.includes(key)) {
      return undefined;
    }
    return value;
  };
  callback(null, JSON.stringify(classesFile.compilerNode, replacerFunc, 2));
};
