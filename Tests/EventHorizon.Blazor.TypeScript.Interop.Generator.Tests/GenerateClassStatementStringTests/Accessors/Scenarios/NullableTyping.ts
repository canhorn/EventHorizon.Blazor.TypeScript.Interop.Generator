declare module Static.Primitive {
    export class ExampleClass {
        get linkedMesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        get style(): BABYLON.Nullable<Style>;
        set style(value: BABYLON.Nullable<Style>);
        get renderList(): Nullable<Array<AbstractMesh>>;
        set renderList(value: Nullable<Array<AbstractMesh>>);
    }
}