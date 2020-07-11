declare module BABYLON.GUI {
    export class Otherthing { }
    export interface IDisposable { }
    export interface IInterfaceResponseType { }

    export class Everything<T> extends Otherthing implements IDisposable {
        // Static Accessors
        static get Now(): number;
        static get NowValues(): number[];
        static get UNITMODE_PERCENTAGE(): number;
        static get Up(): Vector3;
        static get Downs(): Vector3[];

        // Static Properties
        static readonly NoneLogLevel: number;
        static readonly LogLevels: number[];
        static readonly Vector3LogLevel: Vector3;
        static readonly Vector3List: Vector3[];

        // Static Methods
        static makeObserverTopPriority(observer: Observer<T>): void; // No Return Type
        // TODO: [ACTION_METHODS] : This is not supported, it is the ability to add a callback.
        static OnNewCacheEntry: (entry: string) => void; // Action Type
        static Identity(): Matrix2D; // Class 
        static Identitys(): Matrix2D[]; // Array Class
        static numberArray(): number[]; // Array
        static numberMethod(): number; // Primitive
        static numberArrayObj(): Array<number>; // Array
        static FromArray(array: DeepImmutable<ArrayLike<number>>, offset?: number): Vector3;
        static get InterfaceResponseType(): IInterfaceResponseType;

        // Accessors
        get linkedMesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        get observers(): Array<Observer<T>>;
        get texts(): string[];
        get text(): string;
        set text(value: string);
        get style(): BABYLON.Nullable<Style>;
        set style(value: BABYLON.Nullable<Style>);

        // Properties
        num: number;
        width: string;
        widths: string[];
        height: Vector2;
        matrix: Vector2[];
        floatArrayExample: FloatArray;
        float32ArrayExample: Float32Array;
        indicesArrayExample: IndicesArray;
        uint8ArrayExample: Uint8Array;
        webkitURL: typeof URL;

        // Constructor
        constructor(arg1: string,
            arg2: Class1 | Class2,
            arg3: number | undefined | null,
            arg4?: number,
            arg5?: Class3,
            arg6?: { item: string; });

        // Methods
        // Property that is a Method
        javaScriptApiFunctionClass: Function;
        literalTypeArgument(literal: { prop1: string }): void;
        isEqualsTo(other: Measure): boolean;
        isBooleans(): boolean[];
        Matrixices(): Vector2[];
        TheMatrix(): Vector2;
        makeObserverTopPriority(observer: Observer<T>): void;
        add(callback: (eventData: T, eventState: EventState) => void,
            mask?: number,
            insertFirst?: boolean,
            scope?: any,
            unregisterOnFirstCall?: boolean): Nullable<Observer<T>>;
        theOtherMatrix<D>(methodData: D, classData: T): Vector2;
        promiseVoid(): Promise<void>;
        nullableClassStyle(): Nullable<Style>;
        nullableGenericNumber(): Nullable<number>;
        orderNullArguments(scene: Scene | null | undefined, animatables: Animatable[], targetConverter?: Nullable<(target: any) => Nullable<Node>>): void;
    }
}