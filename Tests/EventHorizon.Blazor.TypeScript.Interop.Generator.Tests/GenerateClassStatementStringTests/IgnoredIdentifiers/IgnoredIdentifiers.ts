declare module Examples {
  export interface CameraInputsMap<T> {}
  export class DeepImmutable<T> {}

  export interface ExampleClass<V extends CameraInputsMap<I>, I> {
    property: string;
    get getProperty(): string;
    set setProperty(value: string);
    propertySignature: string;

    addToRef<R extends I>(other: DeepImmutable<I>, result: R): R;
    subtractFromFloatsToRef<R extends I>(...args: [...Array<V>, R]): R;
    method(): void;
  }
}
