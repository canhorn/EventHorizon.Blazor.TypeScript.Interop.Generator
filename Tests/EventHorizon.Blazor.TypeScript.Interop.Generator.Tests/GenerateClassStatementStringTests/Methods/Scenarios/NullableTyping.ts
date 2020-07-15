declare module Static.Class {
    export class ExampleClass {
        nullableClassStyle(): Nullable<Style>;
        nullableGenericNumber(): Nullable<number>;
        orderNullArguments(scene: Scene | null | undefined, animatables: Animatable[], targetConverter?: Nullable<(target: any) => Nullable<Node>>): void;
    }
}
