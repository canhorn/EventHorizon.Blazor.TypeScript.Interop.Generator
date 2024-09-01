declare module Examples {
  export type TypeReferenceFunction = (
    shaderType: string,
    code: string,
    defines?: string[]
  ) => string;

  export class ExampleClass {
    methodWithTypeReferenceFunction(
      callback?: Nullable<TypeReferenceFunction>
    ): void;
  }
}
