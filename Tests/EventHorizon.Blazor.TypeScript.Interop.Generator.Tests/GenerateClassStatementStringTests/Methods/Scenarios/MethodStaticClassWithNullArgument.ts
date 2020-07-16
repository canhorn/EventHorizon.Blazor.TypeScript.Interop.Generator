declare module Static.Method.Argument {
    export class ExampleClass {
        static undefinedArgument(arg1: null | number): boolean;
        static nullableArgument(arg1: Nullable<number>): boolean;
    }
}