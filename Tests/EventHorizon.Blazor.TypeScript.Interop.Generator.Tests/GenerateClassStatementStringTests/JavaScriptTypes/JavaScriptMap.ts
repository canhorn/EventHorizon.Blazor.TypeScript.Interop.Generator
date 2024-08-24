declare module Examples {
  export class ExampleClass {
    static staticMapProp: Map<string, string>;
    mapProp: Map<string, string>;

    static staticMapType(theMap: Map<string, string>): Map<string, string>;
    mapType(theMap: Map<string, string>): Map<string, string>;
  }
}
