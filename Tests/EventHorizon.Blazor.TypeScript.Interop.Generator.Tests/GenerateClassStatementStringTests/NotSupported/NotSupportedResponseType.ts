declare module Examples {
    export interface IEffectFallbacks<T> { }
    export class Observable<T> { }

    export class ExampleClass {
        unsupportedMethod(): IEffectFallbacks<boolean>;
        onInfluenceChanged: Observable<boolean>;
        arrayOfArray: string[][];
    }
}