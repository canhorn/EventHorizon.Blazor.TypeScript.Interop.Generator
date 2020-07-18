declare module Examples {
    export class PickingInfo {
    }

    export class PointerInfo {
        pickInfo: Nullable<PickingInfo>;
        constructor(type: number, event: PointerEvent | MouseWheelEvent, pickInfo: Nullable<PickingInfo>);

    }

    export class Observable<T> {
        add(callback: (eventData: T, eventState: EventState) => void, mask?: number, insertFirst?: boolean, scope?: any, unregisterOnFirstCall?: boolean): Nullable<Observer<T>>;
    }

    export class ExampleClass {
        onPointerObservable: Observable<PointerInfo, string>;
    }
}