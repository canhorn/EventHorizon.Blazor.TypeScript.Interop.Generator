declare module Static.Class {
    export interface ISomeInterface { }

    export class ExampleClass {
        interfaceAction(callback: (interfaceArgument: ISomeInterface) => void): void;
    }
}
