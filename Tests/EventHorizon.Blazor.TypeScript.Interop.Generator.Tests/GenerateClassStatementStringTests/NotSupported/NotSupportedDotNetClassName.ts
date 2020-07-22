declare module Examples {
    export class IDisposable {
        disposeProperty: IDisposable;
        disposeMethod(arg1: IDisposable): IDisposable;
    }
}