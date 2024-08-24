declare module Examples {
  export class Observable<T> {
        notifyIfTriggered: boolean;
        private _observers;
        private _numObserversMarkedAsDeleted;
        private _hasNotified;
        private _lastNotifiedValue?;
        _eventState: EventState;
        private _onObserverAdded;
        static FromPromise<T, E = Error>(promise: Promise<T>, onErrorObservable?: Observable<E>): Observable<T>;
        get observers(): Array<Observer<T>>;
        constructor(onObserverAdded?: (observer: Observer<T>) => void, 
        notifyIfTriggered?: boolean);
        add(callback?: null | undefined, mask?: number, insertFirst?: boolean, scope?: any, unregisterOnFirstCall?: boolean): null;
        add(callback: (eventData: T, eventState: EventState) => void, mask?: number, insertFirst?: boolean, scope?: any, unregisterOnFirstCall?: boolean): Observer<T>;
        add(callback?: ((eventData: T, eventState: EventState) => void) | null | undefined, mask?: number, insertFirst?: boolean, scope?: any, unregisterOnFirstCall?: boolean): Nullable<Observer<T>>;
        addOnce(callback?: null | undefined): null;
        addOnce(callback: (eventData: T, eventState: EventState) => void): Observer<T>;
        addOnce(callback?: ((eventData: T, eventState: EventState) => void) | null | undefined): Nullable<Observer<T>>;
        remove(observer: Nullable<Observer<T>>): boolean;
        removeCallback(callback: (eventData: T, eventState: EventState) => void, scope?: any): boolean;
        _deferUnregister(observer: Observer<T>): void;
        private _remove;
        makeObserverTopPriority(observer: Observer<T>): void;
        makeObserverBottomPriority(observer: Observer<T>): void;
        notifyObservers(eventData: T, mask?: number, target?: any, currentTarget?: any, userInfo?: any): boolean;
        notifyObserver(observer: Observer<T>, eventData: T, mask?: number): void;
        hasObservers(): boolean;
        clear(): void;
        cleanLastNotifiedState(): void;
        clone(): Observable<T>;
        hasSpecificMask(mask?: number): boolean;
    }
}
