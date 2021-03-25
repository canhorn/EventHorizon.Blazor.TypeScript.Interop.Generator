declare module Static.Primitive {
    export class Url {
        name: string;
    }

    export class ExampleClass {
        typeofToPrimitive: typeof Static.Primitive.Url.name;
    }
}
