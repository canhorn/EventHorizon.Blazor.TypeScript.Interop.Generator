declare module Examples {
    export class ExampleClass {
        constructor(arg1: string,
            arg2: Class1 | Class2,
            arg3: number | undefined | null,
            arg4?: number,
            arg5?: Class3,
            arg6?: { item: string; });
    }
}