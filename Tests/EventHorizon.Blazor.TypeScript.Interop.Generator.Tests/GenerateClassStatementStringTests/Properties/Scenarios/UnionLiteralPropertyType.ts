declare module Examples {
    export class ExampleClass {
        static ExceptionList: ({
            key: string;
            capture: string;
            captureConstraint: number;
            targets: string[];
        } | {
            key: string;
            capture: null;
            captureConstraint: null;
            targets: string[];
        })[];
    }
}
