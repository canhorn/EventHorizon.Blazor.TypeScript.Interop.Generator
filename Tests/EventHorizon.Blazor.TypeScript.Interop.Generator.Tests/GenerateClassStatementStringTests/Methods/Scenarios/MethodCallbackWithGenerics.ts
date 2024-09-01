declare module Examples {
  export class ExampleClass {
    complexGeneric(
      functionCallback: Nullable<
        (
          arg1: SmartArray<SubMesh>,
          arg2: SubMesh,
          arg3: string,
          arg4: Array<SubMesh>
        ) => void
      >,
      boolArg: boolean,
      nullableArrayArg: Nullable<AbstractMesh[]>
    ): void;
  }
}
