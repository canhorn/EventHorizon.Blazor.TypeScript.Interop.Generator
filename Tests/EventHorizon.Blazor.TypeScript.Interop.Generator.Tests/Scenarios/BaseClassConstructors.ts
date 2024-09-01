declare module Examples {
  export class UsedClass {}
  export class FifthLayerBaseClass {
    constructor(name: string, usedClass?: Nullable<UsedClass>, isPure?: boolean);
  }
  export class FourthLayerBaseClass extends FifthLayerBaseClass {
    constructor(name: string, usedClass?: Nullable<UsedClass>, isPure: boolean);
  }
  export abstract class ThirdLayerBaseClass extends FourthLayerBaseClass {
    constructor(name: string, usedClass?: Nullable<UsedClass>);
  }
  export class SecondLayerBaseClass extends ThirdLayerBaseClass {
    constructor(
      name: string,
      usedClass?: Nullable<UsedClass>,
      parent?: Nullable<ThirdLayerBaseClass>,
      source?: Nullable<ExampleClass>,
      boolParam?: boolean,
      boolParam2?: boolean
    );
  }
  export class ExampleClass extends SecondLayerBaseClass {
    constructor(name: string, usedClass?: UsedClass);
  }
}
