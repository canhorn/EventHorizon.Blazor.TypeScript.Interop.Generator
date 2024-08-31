declare module Examples {
  export class Observable<T> {}
  
  export class ExampleClass {
    onBeforeTextureInitObservable: Observable<
      import("babylonjs/Materials/Textures/texture").Texture
    >;
  }
}
