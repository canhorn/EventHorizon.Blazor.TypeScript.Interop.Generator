declare module Examples {
    export type Nullable<T> = T | null;

    export class ExampleClass {
        setIndices(indices: IndicesArray, totalVertices?: Nullable<number>): Mesh;
    }
}