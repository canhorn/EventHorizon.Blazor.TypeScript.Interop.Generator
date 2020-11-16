declare module Examples {
    export class PromiseClass { }
    export class ExampleClass<T> {
        importMeshAsync(meshesNames: any, scene: string, data: any, rootUrl: string, onProgress?: (event: SceneLoaderProgressEvent) => void, fileName?: string): Promise<PromiseClass>;
    }
}