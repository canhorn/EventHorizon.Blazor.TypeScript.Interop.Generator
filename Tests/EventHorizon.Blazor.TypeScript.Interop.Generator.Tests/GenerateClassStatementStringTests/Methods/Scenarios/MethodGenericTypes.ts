declare module Generic.Properties {
    export interface CameraInputsMap<T> { }
    export class Observable<T> { }

    export class ExampleClass<TCamera> {
        attached(): CameraInputsMap<TCamera>;
        initWebVR(): Observable<CameraInputsMap>;
    }
}
