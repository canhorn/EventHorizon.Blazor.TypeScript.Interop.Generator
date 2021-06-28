declare module Examples {
    export class PredicateClass { }

    export class ExampleClass<T> {
        classActionResult(predicate: () => PredicateClass): void;
        arrayClassActionResult(predicate: () => PredicateClass[]): void;
        primitiveActionResult(predicate: () => string): void;
        arrayActionResult(predicate: () => string[]): void;
    }
}