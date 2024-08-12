declare module Static.Class {
    export class ExampleClass {
        static GenericTypeOnArray<T, P>(data: T, start?: number, end?: number): Array<P>;
        static FromPromise<T, E = Error>(promise: Promise<T>, onErrorObservable?: Observable<E>): Observable<T>;
    }
}
