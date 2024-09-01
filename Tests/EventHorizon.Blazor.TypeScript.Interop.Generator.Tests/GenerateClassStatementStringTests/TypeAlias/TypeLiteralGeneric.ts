declare module Examples {
  export type Length<T> = T extends {
    length: number;
  }
    ? T["length"]
    : never;
  type _FromLength<N extends number, R = Empty> = {
    0: R;
    1: _FromLength<N, Unshift<R, 0>>;
  }[Length<R> extends N ? 0 : 1];
  
  export type ExampleClass<T> = T extends Array<infer U>
    ? [Length<T>, ...Dimension<U>]
    : T extends readonly [infer U, ...infer R]
    ? [Length<T>, ...Dimension<U>]
    : [];
}
