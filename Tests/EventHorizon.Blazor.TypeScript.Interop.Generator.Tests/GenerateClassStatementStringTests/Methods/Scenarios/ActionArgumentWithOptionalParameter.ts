declare module Examples {
  export class ExampleClass {
    methodWithCallback(
      callback: (body: string, optional?: number) => void
    ): void;
  }
}
