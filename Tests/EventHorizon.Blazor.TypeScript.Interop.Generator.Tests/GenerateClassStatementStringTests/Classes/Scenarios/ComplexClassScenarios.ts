declare module Examples {
  // TODO: [TEST] Break this up into multiple tests
  export class ExampleClass<T> {
    prop: T[];
    nullableProp: Nullable<TCamera>;
    addBehavior(behavior: Behavior<T>): T[];
    thisMethod(): this;
    isClass(): T;
    removeBehavior(behavior: Behavior<T>): T;
    getBehaviorByName(name: string): Nullable<Behavior<T>>;
  }
}