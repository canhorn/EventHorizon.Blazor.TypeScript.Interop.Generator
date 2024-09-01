declare module Examples {
  export class ExampleClass {
    static staticExcludeProp: Exclude<string, string>;
    excludeProp: Exclude<Vector2, string>;

    static staticExcludeType(
      theMap: Exclude<Map<string, string>, object>
    ): Exclude<string, number>;
    excludeType(
      theMap: Exclude<Vector3, object>
    ): Exclude<string, number>;
  }
}
