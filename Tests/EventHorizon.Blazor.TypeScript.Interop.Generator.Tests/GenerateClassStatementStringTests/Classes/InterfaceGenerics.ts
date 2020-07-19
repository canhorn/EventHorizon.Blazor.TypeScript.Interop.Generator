declare module Examples {
    export class Camera { }
    export interface IEffectFallbacks<TCamera> { }

    export class ExampleClass extends IEffectFallbacks<Camera> {
    }
}