declare module Examples {
  export class Level2BaseClass {
    constructor(arg1: number, arg2: number);
  }
  export class BaseClass extends Level2BaseClass {
    constructor(arg1: number, arg2: number);
  }
  export class ExampleClass extends Mesh {
    constructor(name: string, scene?: UsedClass);
  }

  export class Node {
    constructor(name: string, scene?: Nullable<UsedClass>, isPure?: boolean);
  }
  export class TransformNode extends Node {
    constructor(name: string, scene?: Nullable<UsedClass>, isPure?: boolean);
  }
  export abstract class AbstractMesh extends TransformNode {
    constructor(name: string, scene?: Nullable<UsedClass>);
  }
  export class Mesh extends AbstractMesh {
    constructor(
      name: string,
      scene?: Nullable<UsedClass>,
      parent?: Nullable<Node>,
      source?: Nullable<Mesh>,
      doNotCloneChildren?: boolean,
      clonePhysicsImpostor?: boolean
    );
  }
  export class GroundMesh extends Mesh {
    constructor(name: string, scene?: UsedClass);
  }
}
