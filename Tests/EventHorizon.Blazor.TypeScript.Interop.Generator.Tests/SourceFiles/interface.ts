type Nullable = null | undefined;
type Vector3 = null | undefined;

export class Vector3Typed<Vector3> {
}
export class ExampleClass<T> {
}
export interface ExampleInterface<T> {
    action(action: T): void;
}