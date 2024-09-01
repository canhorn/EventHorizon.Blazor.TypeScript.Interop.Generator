declare module Examples {
  export interface ExampleClass<T, N extends number> {
    method(): ExampleClass<T, N>;
  }
}
