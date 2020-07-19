declare module Static.Class {
    export class ExampleClass {
        static ObjectLiteralFirstUnionResult(): {
            value1?: number;
        } | string;
        static ObjectLiteralLastUnionResult(): string | {
            value1?: number;
        };
        getVertexBuffers(): Nullable<{
            [key: string]: VertexBuffer;
        }>;
    }
}
