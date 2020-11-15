declare module Examples {
    export type DataArray = number[] | ArrayBuffer | ArrayBufferView;

    export class ExampleClass<T> {
        getData(): Nullable<DataArray>;
    }
}