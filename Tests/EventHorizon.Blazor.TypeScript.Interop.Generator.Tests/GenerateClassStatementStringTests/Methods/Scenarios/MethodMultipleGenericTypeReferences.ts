declare module Static.Class {
    export class ExampleClass {
        static GenericTypeOnArray<T, P>(data: T, start?: number, end?: number): Array<P>;
    }
}
