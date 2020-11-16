declare module Examples {
    export type Predicate = (p0: Vector3, p1: Vector3, p2: Vector3, ray: Ray) => boolean;

    export class ExampleClass {
        nullablePredicate(x: number, y: number, predicate?: Predicate): Nullable<PickingInfo>;
    }
}