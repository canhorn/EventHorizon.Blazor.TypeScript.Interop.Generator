declare module Examples {
    export class ExampleClass {
        static get vectorStaticCheck(): Vector3;
        static get primativeStaticCheck(): number;

        get vectorCheck(): Vector3;
        get primativeCheck(): number;
    }
}