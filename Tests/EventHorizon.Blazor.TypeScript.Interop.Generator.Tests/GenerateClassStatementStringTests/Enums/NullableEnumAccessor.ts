declare module Static.Class {
    enum AccessorEnum {
        VALUE = 0,
    }

    export class ExampleClass {
        get enumAccessor(): Nullable<AccessorEnum>;
        set enumAccessor(value: Nullable<AccessorEnum>);
    }
}
