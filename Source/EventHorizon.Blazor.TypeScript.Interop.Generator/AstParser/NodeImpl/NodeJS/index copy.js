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

  var classesFileStructure = classesFile.getStructure();

    callback(null, JSON.stringify(classesFileStructure, null, 2));
};
