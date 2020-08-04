declare module Examples {
    export class Camera { }
    export interface IEffectFallbacks<TCamera> { }

    export class ExampleClass implements IEffectFallbacks<Camera> {
    }
}