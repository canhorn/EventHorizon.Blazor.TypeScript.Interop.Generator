declare module Examples {
    export class ExampleClass {
        static methodStaticCheck(arg1: Vector3, arg2: number): Vector3;
        static vectorStaticMethodCheck(arg1: Vector3, arg2: number): boolean;
        static primativeStaticMethodCheck(arg1: Vector3, arg2: number): boolean;

        methodCheck(arg1: Vector3, arg2: number): Vector3;
        vectorMethodCheck(arg1: Vector3, arg2: number): boolean;
        primativeMethodCheck(arg1: Vector3, arg2: number): boolean;
    }
}