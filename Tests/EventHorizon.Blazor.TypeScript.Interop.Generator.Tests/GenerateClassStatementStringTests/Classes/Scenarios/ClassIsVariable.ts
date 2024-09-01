declare module Examples {
  export function CreateBox(
    name: string,
    options?: {
      size?: number;
      width?: number;
      height?: number;
      depth?: number;
      faceUV?: Vector4[];
      faceColors?: Color4[];
      sideOrientation?: number;
      frontUVs?: Vector4;
      backUVs?: Vector4;
      wrap?: boolean;
      topBaseAt?: number;
      bottomBaseAt?: number;
      updatable?: boolean;
    },
    scene?: Nullable<Scene>
  ): Mesh;
  export const VariableClass: {
    CreateBox: typeof CreateBox;
  };

  export var ExampleClass: {
    CreateBoxTypeOfFunction: typeof CreateBox;
    VariableTypeOfConst: typeof VariableClass;
    Constant: 123;
    property: string;
    method: (name: string) => void;
  };
}
