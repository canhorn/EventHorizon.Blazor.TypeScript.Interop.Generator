declare module Scenario.Class {
  export class ExampleClass<T> {
    add(
      callback?: null | undefined,
      mask?: number,
      insertFirst?: boolean,
      scope?: any,
      unregisterOnFirstCall?: boolean
    ): null;
    add(
      callback: (eventData: T, eventState: EventState) => void,
      mask?: number,
      insertFirst?: boolean,
      scope?: any,
      unregisterOnFirstCall?: boolean
    ): Observer<T>;
    add(
      callback?:
        | ((eventData: T, eventState: EventState) => void)
        | null
        | undefined,
      mask?: number,
      insertFirst?: boolean,
      scope?: any,
      unregisterOnFirstCall?: boolean
    ): Nullable<Observer<T>>;
  }
}
