declare module Static.Class {
    export class ExampleClass<T> {
        javaScriptApiFunctionClass: Function;
        literalTypeArgument(literal: { prop1: string }): void;
        makeObserverTopPriority(observer: Observer<T>): void;
        voidInArguments(observer: void): void;
    }
}