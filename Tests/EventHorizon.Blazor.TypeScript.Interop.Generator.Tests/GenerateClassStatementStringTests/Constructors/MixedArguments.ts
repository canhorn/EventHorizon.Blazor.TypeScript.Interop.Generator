declare module Examples {
    export class ThinEngine { }
    export class Effect { }
    export interface IEffectCreationOptions { }
    export interface IEffectFallbacks { }

    export class ExampleClass {
        constructor(baseName: any,
            attributesNamesOrOptions: string[] | IEffectCreationOptions,
            uniformsNamesOrEngine: string[] | ThinEngine,
            samplers?: Nullable<string[]>,
            engine?: ThinEngine,
            defines?: Nullable<string>,
            fallbacks?: Nullable<IEffectFallbacks>,
            onCompiled?: Nullable<(effect: Effect) => void>,
            onError?: Nullable<(effect: Effect, errors: string) => void>,
            indexParameters?: any);

    }
}