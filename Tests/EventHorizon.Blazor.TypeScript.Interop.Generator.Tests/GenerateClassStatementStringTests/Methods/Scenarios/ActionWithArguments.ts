declare module Static.Class {
    export class ExampleClass<T> {
        add(callback: (eventData: T, eventState: EventState) => void,
            mask?: number,
            insertFirst?: boolean,
            scope?: any,
            unregisterOnFirstCall?: boolean): Nullable<Observer<T>>;
    }
}
