declare module Examples {
  type _Tuple<
    T,
    N extends number,
    R extends unknown[] = []
  > = R["length"] extends N ? R : _Tuple<T, N, [T, ...R]>;
  export type Tuple<T, N extends number> = _Tuple<T, N>;

  export type ExampleClass<T, N extends number> = _Tuple<T, N>;
  // export class ExampleClass<TCamera> {
  //   classReturned(): ExampleClass<TCamera>;
  //   thisReturned(): this;
  // }
}
