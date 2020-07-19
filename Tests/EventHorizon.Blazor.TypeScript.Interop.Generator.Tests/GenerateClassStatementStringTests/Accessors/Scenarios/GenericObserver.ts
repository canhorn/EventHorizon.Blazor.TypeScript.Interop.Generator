declare module Static.Primitive {
    export interface Behavior {

    }

    export class ExampleClass<T> {
        get observers(): Array<Observer<T>>;
        get observer(): Observer<T>;
        get getBehaviorByName(name: string): Nullable<Behavior<T>>;
    }
}