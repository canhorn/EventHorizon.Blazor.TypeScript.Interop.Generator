declare module Static.Primitive {
    export class AbstractMesh {
        name: string;
    }

    export class ExampleClass {
        get surroundingMeshes(): Nullable<AbstractMesh[]>;
        set surroundingMeshes(meshes: Nullable<AbstractMesh[]>);
    }
}