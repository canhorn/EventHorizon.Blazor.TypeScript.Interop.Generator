declare module Static.Class {
    export class ExampleClass {
        nullableClassStyle(): Nullable<Style>;
        nullableGenericNumber(): Nullable<number>;
        orderNullArguments(scene: Scene | null | undefined, animatables: Animatable[], targetConverter?: Nullable<(target: any) => Nullable<Node>>): void;
        undefinedStringArgument(name?: string): ExampleClass;
        mixedUndefinedAndOptional(name: string, points: Vector3[], scene?: Nullable<Scene>, updatable?: boolean, instance?: Nullable<LinesMesh>): LinesMesh;
    }
}
