declare module Static.Primitive {
    export class ExampleClass {
        arrayExample(): Array<string>;
        arrayLikeExample(): ArrayLike<string>;
        floatArrayExample(): FloatArray;
        float32ArrayExample(): Float32Array;
        indicesArrayExample(): IndicesArray;
        uint8ArrayExample(): Uint8Array;

        arrayExample(): Array<string>;
        arrayLikeExample(): ArrayLike<string>;
        floatArrayExample(): Nullable<FloatArray>;
        float32ArrayExample(): Nullable<Float32Array>;
        indicesArrayExample(): Nullable<IndicesArray>;
        uint8ArrayExample(): Nullable<Uint8Array>;
        deepImmutableArray(): DeepImmutable<Float32Array>;
    }
}
