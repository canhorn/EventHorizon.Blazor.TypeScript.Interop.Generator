declare module Static.Primitive {
    export class ExampleClass<T> {
        get observers(): Array<Observer<T>>;
        get observer(): Observer<T>;
    }
}