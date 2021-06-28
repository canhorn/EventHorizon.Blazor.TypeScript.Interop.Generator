declare module Examples {
    export class PredicateClass { }

    export class ExampleClass<T> {
        classActionResult(predicate: (arg1: number, arg2: string, arg3: PredicateClass) => PredicateClass): void;
        arrayClassActionResult(predicate: (arg1: number, arg2: string, arg3: PredicateClass) => PredicateClass[]): void;
        primitiveActionResult(predicate: (arg1: number, arg2: string, arg3: PredicateClass) => string): void;
        arrayActionResult(predicate: (arg1: number, arg2: string, arg3: PredicateClass) => string[]): void;
    }
}