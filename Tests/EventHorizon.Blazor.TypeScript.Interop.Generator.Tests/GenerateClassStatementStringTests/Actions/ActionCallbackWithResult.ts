declare module Examples {
    export class ExampleClass<T> {
        add(predicate: (data: T) => void): Nullable<Observer<T>>;
    }
}