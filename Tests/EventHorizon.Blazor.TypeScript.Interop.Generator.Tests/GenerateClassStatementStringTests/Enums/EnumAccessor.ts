declare module Static.Class {
    enum AccessorEnum {
        VALUE = 0,
    }

    export class ExampleClass {
        get enumAccessor(): AccessorEnum;
        set enumAccessor(value: AccessorEnum);
    }
}
