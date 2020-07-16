declare module Static.Class {
    export class ExampleClass {
        static CreateGroundFromHeightMap(name: string, url: string, options: {
            width?: number;
            height?: number;
            subdivisions?: number;
            minHeight?: number;
            maxHeight?: number;
            colorFilter?: Color3;
            alphaFilter?: number;
            updatable?: boolean;
            onReady?: (mesh: GroundMesh) => void;
        }, scene?: Nullable<Scene>): GroundMesh;
        static ObjectLiteralAsSecondArgument(options: string | {
            value1?: number;
        }): void;
    }
}
