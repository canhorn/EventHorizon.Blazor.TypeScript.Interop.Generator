declare module Accessors.Scenarios {
    export class ExampleClass {
        get namespacedTyping(): BABYLON.Mesh.AbstractMesh;
        get notNamespacedTyping(): AbstractMesh;
    }
}