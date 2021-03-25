declare module Examples {
    export class Camera { }
    export class ExampleClassWithGeneric<TCamera> { }

    export class ExampleClass extends ExampleClassWithGeneric<Camera> {
        /**
         * Instantiates a new ArcRotateCameraInputsManager.
         * @param camera Defines the camera the inputs belong to
         */
        constructor(camera: Camera);
        /**
         * Add mouse wheel input support to the input manager.
         * @returns the current input manager
         */
        addMouseWheel(): Camera;
        /**
         * Add pointers input support to the input manager.
         * @returns the current input manager
         */
        addPointers(): Camera;
        /**
         * Add keyboard input support to the input manager.
         * @returns the current input manager
         */
        addKeyboard(): Camera;
    }
}