module BABYLON {
    export class Observable<T> {
        /**
         * Calling this will execute each callback, expecting it to be a promise or return a value.
         * If at any point in the chain one function fails, the promise will fail and the execution will not continue.
         * This is useful when a chain of events (sometimes async events) is needed to initialize a certain object
         * and it is crucial that all callbacks will be executed.
         * The order of the callbacks is kept, callbacks are not executed parallel.
         *
         * @param eventData The data to be sent to each callback
         * @param mask is used to filter observers defaults to -1
         * @param target defines the callback target (see EventState)
         * @param currentTarget defines he current object in the bubbling phase
         * @returns {Promise<T>} will return a Promise than resolves when all callbacks executed successfully.
         */
        notifyObserversWithPromise(eventData: T, mask?: number, target?: any, currentTarget?: any): Promise<T>;
        private _observers;
        private _eventState;
        private _onObserverAdded;
        /**
         * Gets the list of observers
         */
        get observers(): Array<Observer<T>>;
        /**
         * Creates a new observable
         * @param onObserverAdded defines a callback to call when a new observer is added
         */
        constructor(onObserverAdded?: (observer: Observer<T>) => void);
        /**
         * Create a new Observer with the specified callback
         * @param callback the callback that will be executed for that Observer
         * @param mask the mask used to filter observers
         * @param insertFirst if true the callback will be inserted at the first position, hence executed before the others ones. If false (default behavior) the callback will be inserted at the last position, executed after all the others already present.
         * @param scope optional scope for the callback to be called from
         * @param unregisterOnFirstCall defines if the observer as to be unregistered after the next notification
         * @returns the new observer created for the callback
         */
        add(callback: (eventData: T, eventState: EventState) => void, mask?: number, insertFirst?: boolean, scope?: any, unregisterOnFirstCall?: boolean): Nullable<Observer<T>>;
        /**
         * Create a new Observer with the specified callback and unregisters after the next notification
         * @param callback the callback that will be executed for that Observer
         * @returns the new observer created for the callback
         */
        addOnce(callback: (eventData: T, eventState: EventState) => void): Nullable<Observer<T>>;
        /**
         * Remove an Observer from the Observable object
         * @param observer the instance of the Observer to remove
         * @returns false if it doesn't belong to this Observable
         */
        remove(observer: Nullable<Observer<T>>): boolean;
        /**
         * Remove a callback from the Observable object
         * @param callback the callback to remove
         * @param scope optional scope. If used only the callbacks with this scope will be removed
         * @returns false if it doesn't belong to this Observable
        */
        removeCallback(callback: (eventData: T, eventState: EventState) => void, scope?: any): boolean;
        private _deferUnregister;
        private _remove;
        /**
         * Moves the observable to the top of the observer list making it get called first when notified
         * @param observer the observer to move
         */
        makeObserverTopPriority(observer: Observer<T>): void;
        /**
         * Moves the observable to the bottom of the observer list making it get called last when notified
         * @param observer the observer to move
         */
        makeObserverBottomPriority(observer: Observer<T>): void;
        /**
         * Notify all Observers by calling their respective callback with the given data
         * Will return true if all observers were executed, false if an observer set skipNextObservers to true, then prevent the subsequent ones to execute
         * @param eventData defines the data to send to all observers
         * @param mask defines the mask of the current notification (observers with incompatible mask (ie mask & observer.mask === 0) will not be notified)
         * @param target defines the original target of the state
         * @param currentTarget defines the current target of the state
         * @returns false if the complete observer chain was not processed (because one observer set the skipNextObservers to true)
         */
        notifyObservers(eventData: T, mask?: number, target?: any, currentTarget?: any): boolean;
        /**
         * Notify a specific observer
         * @param observer defines the observer to notify
         * @param eventData defines the data to be sent to each callback
         * @param mask is used to filter observers defaults to -1
         */
        notifyObserver(observer: Observer<T>, eventData: T, mask?: number): void;
        /**
         * Gets a boolean indicating if the observable has at least one observer
         * @returns true is the Observable has at least one Observer registered
         */
        hasObservers(): boolean;
        /**
        * Clear the list of observers
        */
        clear(): void;
        /**
         * Clone the current observable
         * @returns a new observable
         */
        clone(): Observable<T>;
        /**
         * Does this observable handles observer registered with a given mask
         * @param mask defines the mask to be tested
         * @return whether or not one observer registered with the given mask is handeled
        **/
        hasSpecificMask(mask?: number): boolean;
    }
}
