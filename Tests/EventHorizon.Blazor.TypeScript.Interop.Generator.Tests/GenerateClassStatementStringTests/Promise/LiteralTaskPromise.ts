declare module Examples {
    export class ExampleClass<T> {
        importMeshAsync(meshesNames: any, scene: string, data: any, rootUrl: string, onProgress?: (event: SceneLoaderProgressEvent) => void, fileName?: string): Promise<{
            meshes: string[];
            particleSystems: string[];
            skeletons: string[];
            animationGroups: string[];
        }>;
    }
}