declare module Static.Primitive {
    export class ExampleClass {
        arrayExample(): Array<string>;
        arrayLikeExample(): ArrayLike<string>;
        floatArrayExample(): FloatArray;
        float32ArrayExample(): Float32Array;
        indicesArrayExample(): IndicesArray;
        uint8ArrayExample(): Uint8Array;

        nullableArrayExample(): Nullable<Array<string>>;
        nullableArrayLikeExample(): Nullable<ArrayLike<string>>;
        nullableFloatArrayExample(): Nullable<FloatArray>;
        nullableFloat32ArrayExample(): Nullable<Float32Array>;
        nullableIndicesArrayExample(): Nullable<IndicesArray>;
        nullableUint8ArrayExample(): Nullable<Uint8Array>;
        nullableDeepImmutableArray(): DeepImmutable<Float32Array>;
    }
}
