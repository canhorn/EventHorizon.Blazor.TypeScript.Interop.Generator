declare module Examples {
    export class TransformNode { }
    export interface IDisposable { }
    export interface ICullable { }
    export interface IGetSetVerticesData { }

    export class ExampleClass extends TransformNode implements IDisposable, ICullable, IGetSetVerticesData {
    }
}