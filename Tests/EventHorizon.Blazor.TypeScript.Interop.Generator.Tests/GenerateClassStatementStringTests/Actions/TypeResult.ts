declare module Examples {
    export type CallbackType = (collisionIndex: number, newPosition: Vector3, collidedMesh: Nullable<AbstractMesh>) => void;

    export class ExampleClass<T> {
        typeCallback(onCallback: CallbackType, numberArg: number): void;
    }
}