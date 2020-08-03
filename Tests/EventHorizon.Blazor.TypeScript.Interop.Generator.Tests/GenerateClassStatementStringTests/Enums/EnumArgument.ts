declare module Static.Class {
    enum ExampleEnum {
        VALUE = 0,
    }

    export class ExampleClass {
        enumFunction(enumArgument: ExampleEnum): void;
        enumOptional(enumArgument?: ExampleEnum): void;
        enumReponse(): ExampleEnum;
    }
}
