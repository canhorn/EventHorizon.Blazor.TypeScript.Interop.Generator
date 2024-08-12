declare module BABYLON.GUI {


    /**
     * Class used to transport BABYLON.Vector3 information for pointer events
     */
    export class Vector3WithInfo extends BABYLON.Vector3 {
        /** defines the current mouse button index */
        buttonIndex: number;
        /**
         * Creates a new Vector3WithInfo
         * @param source defines the vector3 data to transport
         * @param buttonIndex defines the current mouse button index
         */
        constructor(source: BABYLON.Vector3, 
        /** defines the current mouse button index */
        buttonIndex?: number);
    }




    /**
     * Class used to manage 3D user interface
     * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui3D
     */
    export class GUI3DManager implements BABYLON.IDisposable {
        private _scene;
        private _sceneDisposeObserver;
        private _utilityLayer;
        private _rootContainer;
        private _pointerObserver;
        private _pointerOutObserver;
        private _customControlScaling;
        /** @internal */
        _lastPickedControl: Control3D;
        /** @internal */
        _lastControlOver: {
            [pointerId: number]: Control3D;
        };
        /** @internal */
        _lastControlDown: {
            [pointerId: number]: Control3D;
        };
        protected static MRTK_REALISTIC_SCALING: number;
        /**
         * BABYLON.Observable raised when the point picked by the pointer events changed
         */
        onPickedPointChangedObservable: BABYLON.Observable<BABYLON.Nullable<BABYLON.Vector3>>;
        /**
         * BABYLON.Observable raised when a picking happens
         */
        onPickingObservable: BABYLON.Observable<BABYLON.Nullable<BABYLON.AbstractMesh>>;
        /** @internal */
        _sharedMaterials: {
            [key: string]: BABYLON.Material;
        };
        /** @internal */
        _touchSharedMaterials: {
            [key: string]: BABYLON.Material;
        };
        /** Gets the hosting scene */
        get scene(): BABYLON.Scene;
        /** Gets associated utility layer */
        get utilityLayer(): BABYLON.Nullable<BABYLON.UtilityLayerRenderer>;
        /** Gets the scaling for all UI elements owned by this manager */
        get controlScaling(): number;
        /** Sets the scaling adjustment for all UI elements owned by this manager */
        set controlScaling(newScale: number);
        /** Gets if controls attached to this manager are realistically sized, based on the fact that 1 unit length is 1 meter */
        get useRealisticScaling(): boolean;
        /** Sets if controls attached to this manager are realistically sized, based on the fact that 1 unit length is 1 meter */
        set useRealisticScaling(newValue: boolean);
        /**
         * Creates a new GUI3DManager
         * @param scene
         */
        constructor(scene?: BABYLON.Scene);
        private _handlePointerOut;
        private _doPicking;
        /**
         * Gets the root container
         */
        get rootContainer(): Container3D;
        /**
         * Gets a boolean indicating if the given control is in the root child list
         * @param control defines the control to check
         * @returns true if the control is in the root child list
         */
        containsControl(control: Control3D): boolean;
        /**
         * Adds a control to the root child list
         * @param control defines the control to add
         * @returns the current manager
         */
        addControl(control: Control3D): GUI3DManager;
        /**
         * Removes a control from the root child list
         * @param control defines the control to remove
         * @returns the current container
         */
        removeControl(control: Control3D): GUI3DManager;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }




    /**
     * This is here for backwards compatibility with 4.2
     */


    /**
     * Class used to render Slider Thumb material with MRDL
     */
    export class MRDLSliderThumbMaterial extends BABYLON.PushMaterial {
        /**
         * URL pointing to the texture used to define the coloring for the Iridescent Map effect.
         */
        static BLUE_GRADIENT_TEXTURE_URL: string;
        private _blueGradientTexture;
        private _decalTexture;
        private _reflectionMapTexture;
        private _indirectEnvTexture;
        /**
         * Gets or sets the corner Radius on the slider thumb.
         */
        radius: number;
        /**
         * Gets or sets the Bevel Front on the slider thumb.
         */
        bevelFront: number;
        /**
         * Gets or sets the Bevel Front Stretch on the slider thumb.
         */
        bevelFrontStretch: number;
        /**
         * Gets or sets the Bevel Back on the slider thumb.
         */
        bevelBack: number;
        /**
         * Gets or sets the Bevel Back Stretch on the slider thumb.
         */
        bevelBackStretch: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusTopLeft: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusTopRight: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusBottomLeft: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusBottomRight: number;
        /**
         * Gets or sets whether Bulge is enabled.
         * Default is false.
         */
        bulgeEnabled: boolean;
        /**
         * Gets or sets the Bulge Height.
         */
        bulgeHeight: number;
        /**
         * Gets or sets the Bulge Radius.
         */
        bulgeRadius: number;
        /**
         * Gets or sets the Sun Intensity.
         */
        sunIntensity: number;
        /**
         * Gets or sets the Sun Theta.
         */
        sunTheta: number;
        /**
         * Gets or sets the Sun Phi.
         */
        sunPhi: number;
        /**
         * Gets or sets the Indirect Diffuse.
         */
        indirectDiffuse: number;
        /**
         * Gets or sets the base albedo.
         */
        albedo: BABYLON.Color4;
        /**
         * Gets or sets the Specular value.
         */
        specular: number;
        /**
         * Gets or sets the Shininess value.
         */
        shininess: number;
        /**
         * Gets or sets the Sharpness value.
         */
        sharpness: number;
        /**
         * Gets or sets the Subsurface value.
         */
        subsurface: number;
        /**
         * Gets or sets the left gradient color.
         */
        leftGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the right gradient color.
         */
        rightGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the reflection value.
         */
        reflection: number;
        /**
         * Gets or sets the front reflect value.
         */
        frontReflect: number;
        /**
         * Gets or sets the edge reflect value.
         */
        edgeReflect: number;
        /**
         * Gets or sets the power value.
         */
        power: number;
        /**
         * Gets or sets the sky color.
         */
        skyColor: BABYLON.Color4;
        /**
         * Gets or sets the horizon color.
         */
        horizonColor: BABYLON.Color4;
        /**
         * Gets or sets the ground color.
         */
        groundColor: BABYLON.Color4;
        /**
         * Gets or sets the horizon power value.
         */
        horizonPower: number;
        /**
         * Gets or sets the finger occlusion width value.
         */
        width: number;
        /**
         * Gets or sets the finger occlusion fuzz value.
         */
        fuzz: number;
        /**
         * Gets or sets the minimum finger occlusion fuzz value.
         */
        minFuzz: number;
        /**
         * Gets or sets the finger occlusion clip fade value.
         */
        clipFade: number;
        /**
         * Gets or sets the hue shift value.
         */
        hueShift: number;
        /**
         * Gets or sets the saturation shift value.
         */
        saturationShift: number;
        /**
         * Gets or sets the value shift.
         */
        valueShift: number;
        /**
         * Gets or sets the position of the hover glow effect.
         */
        blobPosition: BABYLON.Vector3;
        /**
         * Gets or sets the intensity of the hover glow effect.
         */
        blobIntensity: number;
        /**
         * Gets or sets the near size of the hover glow effect.
         */
        blobNearSize: number;
        /**
         * Gets or sets the far size of the hover glow effect.
         */
        blobFarSize: number;
        /**
         * Gets or sets the distance considered "near" to the mesh, which controls the size of the hover glow effect (see blobNearSize).
         */
        blobNearDistance: number;
        /**
         * Gets or sets the distance considered "far" from the mesh, which controls the size of the hover glow effect (see blobFarSize).
         */
        blobFarDistance: number;
        /**
         * Gets or sets the length of the hover glow effect fade.
         */
        blobFadeLength: number;
        /**
         * Gets or sets the progress of the hover glow effect selection animation corresponding to the left pointer (0.0 - 1.0).
         */
        blobPulse: number;
        /**
         * Gets or sets the opacity of the hover glow effect corresponding to the left pointer (0.0 - 1.0). Default is 0.
         */
        blobFade: number;
        /**
         * Gets or sets the position of the hover glow effect.
         */
        blobPosition2: BABYLON.Vector3;
        /**
         * Gets or sets the size of the hover glow effect when the right pointer is considered "near" to the mesh (see blobNearDistance).
         */
        blobNearSize2: number;
        /**
         * Gets or sets the progress of the hover glow effect selection animation corresponding to the right pointer (0.0 - 1.0).
         */
        blobPulse2: number;
        /**
         * Gets or sets the opacity of the hover glow effect corresponding to the right pointer (0.0 - 1.0). Default is 1.
         */
        blobFade2: number;
        /**
         * Gets or sets the texture of the hover glow effect.
         */
        blobTexture: BABYLON.Texture;
        /**
         * Gets or sets the finger position for left index.
         */
        leftIndexPosition: BABYLON.Vector3;
        /**
         * Gets or sets the finger position for right index.
         */
        rightIndexPosition: BABYLON.Vector3;
        /**
         * Gets or sets the finger position for left index middle position.
         */
        leftIndexMiddlePosition: BABYLON.Vector3;
        /**
         * Gets or sets the finger position for right index middle position.
         */
        rightIndexMiddlePosition: BABYLON.Vector3;
        /**
         * Gets or sets the Decal Scale for XY.
         */
        decalScaleXY: BABYLON.Vector2;
        /**
         * Gets or sets decalFrontOnly
         * Default is true
         */
        decalFrontOnly: boolean;
        /**
         * Gets or sets the Rim Light intensity.
         */
        rimIntensity: number;
        /**
         * Gets or sets the Rim Light hue shift value.
         */
        rimHueShift: number;
        /**
         * Gets or sets the Rim Light saturation shift value.
         */
        rimSaturationShift: number;
        /**
         * Gets or sets the Rim Light value shift.
         */
        rimValueShift: number;
        /**
         * Gets or sets the intensity of the iridescence effect.
         */
        iridescenceIntensity: number;
        /**
         * @internal
         */
        useGlobalLeftIndex: number;
        /**
         * @internal
         */
        useGlobalRightIndex: number;
        /**
         * @internal
         */
        globalLeftIndexTipProximity: number;
        /**
         * @internal
         */
        globalRightIndexTipProximity: number;
        /**
         * @internal
         */
        globalLeftIndexTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globaRightIndexTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalLeftThumbTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalRightThumbTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalLeftIndexMiddlePosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalRightIndexMiddlePosition: BABYLON.Vector4;
        constructor(name: string, scene?: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): MRDLSliderThumbMaterial;
        serialize(): any;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): MRDLSliderThumbMaterial;
    }


    /**
     * Class used to render Slider Bar material with MRDL
     */
    export class MRDLSliderBarMaterial extends BABYLON.PushMaterial {
        /**
         * URL pointing to the texture used to define the coloring for the Iridescent Map effect.
         */
        static BLUE_GRADIENT_TEXTURE_URL: string;
        private _blueGradientTexture;
        private _decalTexture;
        private _reflectionMapTexture;
        private _indirectEnvTexture;
        /**
         * Gets or sets the corner Radius on the slider bar.
         */
        radius: number;
        /**
         * Gets or sets the Bevel Front on the slider bar.
         */
        bevelFront: number;
        /**
         * Gets or sets the Bevel Front Stretch on the slider bar.
         */
        bevelFrontStretch: number;
        /**
         * Gets or sets the Bevel Back on the slider bar.
         */
        bevelBack: number;
        /**
         * Gets or sets the Bevel Back Stretch on the slider bar.
         */
        bevelBackStretch: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusTopLeft: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusTopRight: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusBottomLeft: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusBottomRight: number;
        /**
         * Gets or sets whether Bulge is enabled.
         * Default is false.
         */
        bulgeEnabled: boolean;
        /**
         * Gets or sets the Bulge Height.
         */
        bulgeHeight: number;
        /**
         * Gets or sets the Bulge Radius.
         */
        bulgeRadius: number;
        /**
         * Gets or sets the Sun Intensity.
         */
        sunIntensity: number;
        /**
         * Gets or sets the Sun Theta.
         */
        sunTheta: number;
        /**
         * Gets or sets the Sun Phi.
         */
        sunPhi: number;
        /**
         * Gets or sets the Indirect Diffuse.
         */
        indirectDiffuse: number;
        /**
         * Gets or sets the base albedo.
         */
        albedo: BABYLON.Color4;
        /**
         * Gets or sets the Specular value.
         */
        specular: number;
        /**
         * Gets or sets the Shininess value.
         */
        shininess: number;
        /**
         * Gets or sets the Sharpness value.
         */
        sharpness: number;
        /**
         * Gets or sets the Subsurface value.
         */
        subsurface: number;
        /**
         * Gets or sets the left gradient color.
         */
        leftGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the right gradient color.
         */
        rightGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the reflection value.
         */
        reflection: number;
        /**
         * Gets or sets the front reflect value.
         */
        frontReflect: number;
        /**
         * Gets or sets the edge reflect value.
         */
        edgeReflect: number;
        /**
         * Gets or sets the power value.
         */
        power: number;
        /**
         * Gets or sets the sky color.
         */
        skyColor: BABYLON.Color4;
        /**
         * Gets or sets the horizon color.
         */
        horizonColor: BABYLON.Color4;
        /**
         * Gets or sets the ground color.
         */
        groundColor: BABYLON.Color4;
        /**
         * Gets or sets the horizon power value.
         */
        horizonPower: number;
        /**
         * Gets or sets the finger occlusion width value.
         */
        width: number;
        /**
         * Gets or sets the finger occlusion fuzz value.
         */
        fuzz: number;
        /**
         * Gets or sets the minimum finger occlusion fuzz value.
         */
        minFuzz: number;
        /**
         * Gets or sets the finger occlusion clip fade value.
         */
        clipFade: number;
        /**
         * Gets or sets the hue shift value.
         */
        hueShift: number;
        /**
         * Gets or sets the saturation shift value.
         */
        saturationShift: number;
        /**
         * Gets or sets the value shift.
         */
        valueShift: number;
        /**
         * Gets or sets the position of the hover glow effect.
         */
        blobPosition: BABYLON.Vector3;
        /**
         * Gets or sets the intensity of the hover glow effect.
         */
        blobIntensity: number;
        /**
         * Gets or sets the near size of the hover glow effect.
         */
        blobNearSize: number;
        /**
         * Gets or sets the far size of the hover glow effect.
         */
        blobFarSize: number;
        /**
         * Gets or sets the distance considered "near" to the mesh, which controls the size of the hover glow effect (see blobNearSize).
         */
        blobNearDistance: number;
        /**
         * Gets or sets the distance considered "far" from the mesh, which controls the size of the hover glow effect (see blobFarSize).
         */
        blobFarDistance: number;
        /**
         * Gets or sets the length of the hover glow effect fade.
         */
        blobFadeLength: number;
        /**
         * Gets or sets the progress of the hover glow effect selection animation corresponding to the left pointer (0.0 - 1.0).
         */
        blobPulse: number;
        /**
         * Gets or sets the opacity of the hover glow effect corresponding to the left pointer (0.0 - 1.0). Default is 0.
         */
        blobFade: number;
        /**
         * Gets or sets the position of the hover glow effect.
         */
        blobPosition2: BABYLON.Vector3;
        /**
         * Gets or sets the size of the hover glow effect when the right pointer is considered "near" to the mesh (see blobNearDistance).
         */
        blobNearSize2: number;
        /**
         * Gets or sets the progress of the hover glow effect selection animation corresponding to the right pointer (0.0 - 1.0).
         */
        blobPulse2: number;
        /**
         * Gets or sets the opacity of the hover glow effect corresponding to the right pointer (0.0 - 1.0). Default is 1.
         */
        blobFade2: number;
        /**
         * Gets or sets the texture of the hover glow effect.
         */
        blobTexture: BABYLON.Texture;
        /**
         * Gets or sets the finger position for left index.
         */
        leftIndexPosition: BABYLON.Vector3;
        /**
         * Gets or sets the finger position for right index.
         */
        rightIndexPosition: BABYLON.Vector3;
        /**
         * Gets or sets the finger position for left index middle position.
         */
        leftIndexMiddlePosition: BABYLON.Vector3;
        /**
         * Gets or sets the finger position for right index middle position.
         */
        rightIndexMiddlePosition: BABYLON.Vector3;
        /**
         * Gets or sets the Decal Scle for XY.
         */
        decalScaleXY: BABYLON.Vector2;
        /**
         * Gets or sets decalFrontOnly
         * Default is true
         */
        decalFrontOnly: boolean;
        /**
         * Gets or sets the Rim Light intensity.
         */
        rimIntensity: number;
        /**
         * Gets or sets the Rim Light hue shift value.
         */
        rimHueShift: number;
        /**
         * Gets or sets the Rim Light saturation shift value.
         */
        rimSaturationShift: number;
        /**
         * Gets or sets the Rim Light value shift.
         */
        rimValueShift: number;
        /**
         * Gets or sets the intensity of the iridescence effect.
         */
        iridescenceIntensity: number;
        /**
         * @internal
         */
        useGlobalLeftIndex: number;
        /**
         * @internal
         */
        useGlobalRightIndex: number;
        /**
         * @internal
         */
        globalLeftIndexTipProximity: number;
        /**
         * @internal
         */
        globalRightIndexTipProximity: number;
        /**
         * @internal
         */
        globalLeftIndexTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globaRightIndexTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalLeftThumbTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalRightThumbTipPosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalLeftIndexMiddlePosition: BABYLON.Vector4;
        /**
         * @internal
         */
        globalRightIndexMiddlePosition: BABYLON.Vector4;
        constructor(name: string, scene?: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): MRDLSliderBarMaterial;
        serialize(): any;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): MRDLSliderBarMaterial;
    }


    export class MRDLInnerquadMaterial extends BABYLON.PushMaterial {
        /**
         * Gets or sets the color of the innerquad.
         */
        color: BABYLON.Color4;
        /**
         * Gets or sets the corner radius on the innerquad. If this value is changed, update the lineWidth to match.
         */
        radius: number;
        /**
         * Gets or sets whether the radius of the innerquad should be fixed.
         */
        fixedRadius: boolean;
        /** @hidden */
        _filterWidth: number;
        /**
         * Gets or sets the glow fraction of the innerquad.
         */
        glowFraction: number;
        /**
         * Gets or sets the maximum glow intensity of the innerquad.
         */
        glowMax: number;
        /**
         * Gets or sets the glow falloff effect of the innerquad.
         */
        glowFalloff: number;
        constructor(name: string, scene: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): MRDLInnerquadMaterial;
        serialize(): unknown;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): MRDLInnerquadMaterial;
    }


    export class MRDLFrontplateMaterial extends BABYLON.PushMaterial {
        /**
         * Gets or sets the corner radius on the frontplate. If this value is changed, update the lineWidth to match.
         */
        radius: number;
        /**
         * Gets or sets the line width of the frontplate.
         */
        lineWidth: number;
        /**
         * Gets or sets whether the scale is relative to the frontplate height.
         */
        relativeToHeight: boolean;
        /** @hidden */
        _filterWidth: number;
        /**
         * Gets or sets the edge color of the frontplate.
         */
        edgeColor: BABYLON.Color4;
        /**
         * Gets or sets whether to enable blob effects on the frontplate.
         */
        blobEnable: boolean;
        /**
         * Gets or sets the blob position on the frontplate.
         */
        blobPosition: BABYLON.Vector3;
        /**
         * Gets or sets the blob intensity of the frontplate.
         */
        blobIntensity: number;
        /**
         * Gets or sets the blob near size of the frontplate.
         */
        blobNearSize: number;
        /**
         * Gets or sets the blob far size of the frontplate.
         */
        blobFarSize: number;
        /**
         * Gets or sets the blob near distance of the frontplate.
         */
        blobNearDistance: number;
        /**
         * Gets or sets the blob far distance of the frontplate.
         */
        blobFarDistance: number;
        /**
         * Gets or sets the blob fade length of the frontplate.
         */
        blobFadeLength: number;
        /**
         * Gets or sets the blob inner fade of the frontplate.
         */
        blobInnerFade: number;
        /**
         * Gets or sets the blob pulse of the frontplate.
         */
        blobPulse: number;
        /**
         * Gets or sets the blob fade effect on the frontplate.
         */
        blobFade: number;
        /**
         * Gets or sets the maximum size of the blob pulse on the frontplate.
         */
        blobPulseMaxSize: number;
        /**
         * Gets or sets whether to enable extra blob effects of the frontplate.
         */
        blobEnable2: boolean;
        /**
         * Gets or sets blob2 position of the frontplate.
         */
        blobPosition2: BABYLON.Vector3;
        /**
         * Gets or sets the blob2 near size of the frontplate.
         */
        blobNearSize2: number;
        /**
         * Gets or sets the blob2 inner fade of the frontplate.
         */
        blobInnerFade2: number;
        /**
         * Gets or sets the blob2 pulse of the frontplate.
         */
        blobPulse2: number;
        /**
         * Gets or sets the blob2 fade effect on the frontplate.
         */
        blobFade2: number;
        /**
         * Gets or sets the gaze intensity of the frontplate.
         */
        gazeIntensity: number;
        /**
         * Gets or sets the gaze focus of the frontplate.
         */
        gazeFocus: number;
        /**
         * Gets or sets the selection fuzz of the frontplate.
         */
        selectionFuzz: number;
        /**
         * Gets or sets the fade intensity of the frontplate.
         */
        selected: number;
        /**
         * Gets or sets the selection fade intensity of the frontplate.
         */
        selectionFade: number;
        /**
         * Gets or sets the selection fade size of the frontplate.
         */
        selectionFadeSize: number;
        /**
         * Gets or sets the selected distance of the frontplate.
         */
        selectedDistance: number;
        /**
         * Gets or sets the selected fade length of the frontplate.
         */
        selectedFadeLength: number;
        /**
         * Gets or sets the proximity maximum intensity of the frontplate.
         */
        proximityMaxIntensity: number;
        /**
         * Gets or sets the proximity far distance of the frontplate.
         */
        proximityFarDistance: number;
        /**
         * Gets or sets the proximity near radius of the frontplate.
         */
        proximityNearRadius: number;
        /**
         * Gets or sets the proximity anisotropy of the frontplate.
         */
        proximityAnisotropy: number;
        /**
         * Gets or sets whether to use global left index on the frontplate.
         */
        useGlobalLeftIndex: boolean;
        /**
         * Gets or sets  whether to use global right index of the frontplate.
         */
        useGlobalRightIndex: boolean;
        /**
         * URL pointing to the texture used to define the coloring for the BLOB.
         */
        static BLOB_TEXTURE_URL: string;
        /**
         * Gets or sets the opacity of the frontplate (0.0 - 1.0).
         */
        fadeOut: number;
        private _blobTexture;
        constructor(name: string, scene: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): MRDLFrontplateMaterial;
        serialize(): unknown;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): MRDLFrontplateMaterial;
    }


    /**
     * Class used to render backplate material with MRDL
     */
    export class MRDLBackplateMaterial extends BABYLON.PushMaterial {
        /**
         * URL pointing to the texture used to define the coloring for the Iridescent Map effect.
         */
        static IRIDESCENT_MAP_TEXTURE_URL: string;
        private _iridescentMapTexture;
        /**
         * Gets or sets the corner radius on the backplate. If this value is changed, update the lineWidth to match.
         */
        radius: number;
        /**
         * Gets or sets the line width of the backplate.
         */
        lineWidth: number;
        /**
         * Gets or sets whether to use absolute sizes when calculating effects on the backplate.
         * Since desktop and VR/AR have different relative sizes, it's usually best to keep this false.
         */
        absoluteSizes: boolean;
        /** @internal */
        _filterWidth: number;
        /**
         * Gets or sets the base color of the backplate.
         */
        baseColor: BABYLON.Color4;
        /**
         * Gets or sets the line color of the backplate.
         */
        lineColor: BABYLON.Color4;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusTopLeft: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusTopRight: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusBottomLeft: number;
        /**
         * Gets or sets the top left Radii Multiplier.
         */
        radiusBottomRight: number;
        /** @internal */
        _rate: number;
        /**
         * Gets or sets the color of the highlights on the backplate line.
         */
        highlightColor: BABYLON.Color4;
        /**
         * Gets or sets the width of the highlights on the backplate line.
         */
        highlightWidth: number;
        /** @internal */
        _highlightTransform: BABYLON.Vector4;
        /** @internal */
        _highlight: number;
        /**
         * Gets or sets the intensity of the iridescence effect.
         */
        iridescenceIntensity: number;
        /**
         * Gets or sets the intensity of the iridescence effect on the backplate edges.
         */
        iridescenceEdgeIntensity: number;
        /**
         * Gets or sets the Tint of the iridescence effect on the backplate.
         */
        iridescenceTint: BABYLON.Color4;
        /** @internal */
        _angle: number;
        /**
         * Gets or sets the opacity of the backplate (0.0 - 1.0).
         */
        fadeOut: number;
        /** @internal */
        _reflected: boolean;
        /** @internal */
        _frequency: number;
        /** @internal */
        _verticalOffset: number;
        /**
         * Gets or sets the gradient color effect on the backplate.
         */
        gradientColor: BABYLON.Color4;
        /**
         * Gets or sets the top left gradient color effect on the backplate.
         */
        topLeftGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the top right gradient color effect on the backplate.
         */
        topRightGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the bottom left gradient color effect on the backplate.
         */
        bottomLeftGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the bottom right gradient color effect on the backplate.
         */
        bottomRightGradientColor: BABYLON.Color4;
        /**
         * Gets or sets the edge width of the backplate.
         */
        edgeWidth: number;
        /**
         * Gets or sets the edge width of the backplate.
         */
        edgePower: number;
        /**
         * Gets or sets the edge width of the backplate.
         */
        edgeLineGradientBlend: number;
        constructor(name: string, scene?: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): MRDLBackplateMaterial;
        serialize(): any;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): MRDLBackplateMaterial;
    }


    export class MRDLBackglowMaterial extends BABYLON.PushMaterial {
        /**
         * Gets or sets the bevel radius on the backglow. If this value is changed, update the lineWidth to match.
         */
        bevelRadius: number;
        /**
         * Gets or sets the line width of the backglow.
         */
        lineWidth: number;
        /**
         * Gets or sets whether to use absolute sizes when calculating effects on the backglow.
         * Since desktop and VR/AR have different relative sizes, it's usually best to keep this false.
         */
        absoluteSizes: boolean;
        /**
         * Gets or sets the tuning motion of the backglow.
         */
        tuningMotion: number;
        /**
         * Gets or sets the motion of the backglow.
         */
        motion: number;
        /**
         * Gets or sets the maximum intensity of the backglow.
         */
        maxIntensity: number;
        /**
         * Gets or sets the fade-in exponent of the intensity of the backglow.
         */
        intensityFadeInExponent: number;
        /**
         * Gets or sets the start of the outer fuzz effect on the backglow.
         */
        outerFuzzStart: number;
        /**
         * Gets or sets the end of the outer fuzz effect on the backglow.
         */
        outerFuzzEnd: number;
        /**
         * Gets or sets the color of the backglow.
         */
        color: BABYLON.Color4;
        /**
         * Gets or sets the inner color of the backglow.
         */
        innerColor: BABYLON.Color4;
        /**
         * Gets or sets the blend exponent of the backglow.
         */
        blendExponent: number;
        /**
         * Gets or sets the falloff of the backglow.
         */
        falloff: number;
        /**
         * Gets or sets the bias of the backglow.
         */
        bias: number;
        constructor(name: string, scene: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): MRDLBackglowMaterial;
        serialize(): unknown;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): MRDLBackglowMaterial;
    }




    /** @internal */
    export var mrdlSliderThumbVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlSliderThumbPixelShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlSliderBarVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlSliderBarPixelShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlInnerquadVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlInnerquadPixelShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlFrontplateVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlFrontplatePixelShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlBackplateVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlBackplatePixelShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlBackglowVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var mrdlBackglowPixelShader: {
        name: string;
        shader: string;
    };




    /**
     * Class used to render gizmo handles with fluent design
     */
    export class HandleMaterial extends BABYLON.ShaderMaterial {
        private _hover;
        private _drag;
        private _onBeforeRender;
        private _color;
        private _scale;
        private _targetColor;
        private _targetScale;
        private _lastTick;
        /**
         * Is the material indicating hovering state
         */
        get hover(): boolean;
        set hover(b: boolean);
        /**
         * Is the material indicating drag state
         */
        get drag(): boolean;
        set drag(b: boolean);
        /**
         * Length of animation
         */
        animationLength: number;
        /**
         * Color of the handle when hovered
         */
        hoverColor: BABYLON.Color3;
        /**
         * Color of the handle when idle
         */
        baseColor: BABYLON.Color3;
        /**
         * Scale of the handle when hovered
         */
        hoverScale: number;
        /**
         * Scale of the handle when idle
         */
        baseScale: number;
        /**
         * Scale of the handle when dragged
         */
        dragScale: number;
        /**
         * @internal
         */
        _positionOffset: BABYLON.Vector3;
        /**
         * Creates a handle material
         * @param name Name of the material
         * @param scene BABYLON.Scene
         */
        constructor(name: string, scene: BABYLON.Scene);
        private _updateInterpolationTarget;
        /**
         * Disposes the handle material
         */
        dispose(): void;
    }


    /** @internal */
    export var handleVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var handlePixelShader: {
        name: string;
        shader: string;
    };




    /**
     * Class used to render square buttons with fluent design
     * @since 5.0.0
     */
    export class FluentButtonMaterial extends BABYLON.PushMaterial {
        /**
         * URL pointing to the texture used to define the coloring for the fluent blob effect.
         */
        static BLOB_TEXTURE_URL: string;
        /**
         * Gets or sets the width of the glowing edge, relative to the scale of the button.
         * (Default is 4% of the height).
         */
        edgeWidth: number;
        /**
         * Gets or sets the color of the glowing edge.
         */
        edgeColor: BABYLON.Color4;
        /**
         * Gets or sets the maximum intensity of the proximity light.
         */
        proximityMaxIntensity: number;
        /**
         * Gets or sets the maximum distance for the proximity light (Default is 16mm).
         */
        proximityFarDistance: number;
        /**
         * Gets or sets the radius of the proximity light when near to the surface.
         */
        proximityNearRadius: number;
        /**
         * Gets or sets the anisotropy of the proximity light.
         */
        proximityAnisotropy: number;
        /**
         * Gets or sets the amount of fuzzing in the selection focus.
         */
        selectionFuzz: number;
        /**
         * Gets or sets an override value to display the button as selected.
         */
        selected: number;
        /**
         * Gets or sets a value to manually fade the blob size.
         */
        selectionFade: number;
        /**
         * Gets or sets a value to manually shrink the blob size as it fades (see selectionFade).
         */
        selectionFadeSize: number;
        /**
         * Gets or sets the distance from the button the cursor should be for the button
         * to appear selected (Default is 8cm).
         */
        selectedDistance: number;
        /**
         * Gets or sets the fall-off distance for the selection fade (Default is 8cm).
         */
        selectedFadeLength: number;
        /**
         * Gets or sets the intensity of the luminous blob (Ranges 0-1, default is 0.5).
         */
        blobIntensity: number;
        /**
         * The size of the blob when the pointer is at the blobFarDistance (Default is 5cm).
         */
        blobFarSize: number;
        /**
         * The distance at which the pointer is considered near. See [left|right]BlobNearSize. (Default is 0cm).
         */
        blobNearDistance: number;
        /**
         * The distance at which the pointer is considered far. See [left|right]BlobFarSize. (Default is 8cm).
         */
        blobFarDistance: number;
        /**
         * The distance over which the blob intensity fades from full to none (Default is 8cm).
         */
        blobFadeLength: number;
        /**
         * Gets or sets whether the blob corresponding to the left index finger is enabled.
         */
        leftBlobEnable: boolean;
        /**
         * Gets or sets the size of the left blob when the left pointer is considered near. See blobNearDistance. (Default is 2.5cm).
         */
        leftBlobNearSize: number;
        /**
         * Gets or sets the progress of the pulse animation on the left blob (Ranges 0-1).
         */
        leftBlobPulse: number;
        /**
         * Gets or sets the fade factor on the left blob.
         */
        leftBlobFade: number;
        /**
         * Gets or sets the inner fade on the left blob;
         */
        leftBlobInnerFade: number;
        /**
         * Gets or sets whether the blob corresponding to the right index finger is enabled.
         */
        rightBlobEnable: boolean;
        /**
         * Gets or sets the size of the right blob when the right pointer is considered near. See blobNearDistance. (Default is 2.5cm).
         */
        rightBlobNearSize: number;
        /**
         * Gets or sets the progress of the pulse animation on the right blob (Ranges 0-1).
         */
        rightBlobPulse: number;
        /**
         * Gets or sets the fade factor on the right blob.
         */
        rightBlobFade: number;
        /**
         * Gets or sets the inner fade on the right blob;
         */
        rightBlobInnerFade: number;
        /**
         * Gets or sets the direction of the active face before the world transform is applied.
         * This should almost always be set to -z.
         */
        activeFaceDir: BABYLON.Vector3;
        /**
         * Gets or sets the button's up direction before the world transform is applied.
         * This should almost always be set to +y.
         */
        activeFaceUp: BABYLON.Vector3;
        /**
         * Gets or sets whether the edge fade effect is enabled.
         */
        enableFade: boolean;
        /**
         * Gets or sets a value corresponding to the width of the edge fade effect (Default 1.5).
         */
        fadeWidth: number;
        /**
         * Gets or sets whether the active face is smoothly interpolated.
         */
        smoothActiveFace: boolean;
        /**
         * Gets or sets whether the frame of the fluent button model is visible.
         * This is usually only enabled for debugging purposes.
         */
        showFrame: boolean;
        /**
         * Gets or sets whether the blob color texture is used for the proximity
         * light effect. This is usually only disabled for debugging purposes.
         */
        useBlobTexture: boolean;
        /**
         * Gets or sets the world-space position of the tip of the left index finger.
         */
        globalLeftIndexTipPosition: BABYLON.Vector3;
        /**
         * Gets or sets the world-space position of the tip of the right index finger.
         */
        globalRightIndexTipPosition: BABYLON.Vector3;
        private _blobTexture;
        constructor(name: string, scene?: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): FluentButtonMaterial;
        serialize(): any;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): FluentButtonMaterial;
    }


    /** @internal */
    export var fluentButtonVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var fluentButtonPixelShader: {
        name: string;
        shader: string;
    };




    /**
     * Class used to render square buttons with fluent design
     */
    export class FluentBackplateMaterial extends BABYLON.PushMaterial {
        /**
         * URL pointing to the texture used to define the coloring for the fluent blob effect.
         */
        static BLOB_TEXTURE_URL: string;
        /**
         * URL pointing to the texture used to define iridescent map.
         */
        static IM_TEXTURE_URL: string;
        private _blobTexture;
        private _iridescentMap;
        /**
         * Gets or sets the corner radius on the backplate. Best to keep this value between 0.01 and 0.5. Default is 0.03.
         */
        radius: number;
        /**
         * Gets or sets the line width of the backplate.
         */
        lineWidth: number;
        /**
         * Gets or sets whether to use absolute sizes when calculating effects on the backplate.
         * Since desktop and VR/AR have different relative sizes, it's usually best to keep this false.
         */
        absoluteSizes: boolean;
        /** @internal */
        _filterWidth: number;
        /**
         * Gets or sets the base color of the backplate.
         */
        baseColor: BABYLON.Color4;
        /**
         * Gets or sets the line color of the backplate.
         */
        lineColor: BABYLON.Color4;
        /**
         * Gets or sets the intensity of the fluent hover glow effect.
         */
        blobIntensity: number;
        /**
         * Gets or sets the far size of the fluent hover glow effect.
         */
        blobFarSize: number;
        /**
         * Gets or sets the distance considered "near" to the backplate, which controls the size of the fluent hover glow effect (see blobNearSize).
         */
        blobNearDistance: number;
        /**
         * Gets or sets the distance considered "far" from the backplate, which controls the size of the fluent hover glow effect (see blobFarSize).
         */
        blobFarDistance: number;
        /**
         * Gets or sets the length of the fluent hover glow effect fade.
         */
        blobFadeLength: number;
        /**
         * Gets or sets the size of the fluent hover glow effect when the left pointer is considered "near" to the backplate (see blobNearDistance).
         */
        blobNearSize: number;
        /**
         * Gets or sets the progress of the fluent hover glow effect selection animation corresponding to the left pointer (0.0 - 1.0).
         */
        blobPulse: number;
        /**
         * Gets or sets the opacity of the fluent hover glow effect corresponding to the left pointer (0.0 - 1.0). Default is 0.
         */
        blobFade: number;
        /**
         * Gets or sets the size of the fluent hover glow effect when the right pointer is considered "near" to the backplate (see blobNearDistance).
         */
        blobNearSize2: number;
        /**
         * Gets or sets the progress of the fluent hover glow effect selection animation corresponding to the right pointer (0.0 - 1.0).
         */
        blobPulse2: number;
        /**
         * Gets or sets the opacity of the fluent hover glow effect corresponding to the right pointer (0.0 - 1.0). Default is 0.
         */
        blobFade2: number;
        /** @internal */
        _rate: number;
        /**
         * Gets or sets the color of the highlights on the backplate line.
         */
        highlightColor: BABYLON.Color4;
        /**
         * Gets or sets the width of the highlights on the backplate line.
         */
        highlightWidth: number;
        /** @internal */
        _highlightTransform: BABYLON.Vector4;
        /** @internal */
        _highlight: number;
        /**
         * Gets or sets the intensity of the iridescence effect.
         */
        iridescenceIntensity: number;
        /**
         * Gets or sets the intensity of the iridescence effect on the backplate edges.
         */
        iridescenceEdgeIntensity: number;
        /** @internal */
        _angle: number;
        /**
         * Gets or sets the opacity of the backplate (0.0 - 1.0).
         */
        fadeOut: number;
        /** @internal */
        _reflected: boolean;
        /** @internal */
        _frequency: number;
        /** @internal */
        _verticalOffset: number;
        /**
         * Gets or sets the world-space position of the tip of the left index finger.
         */
        globalLeftIndexTipPosition: BABYLON.Vector3;
        private _globalLeftIndexTipPosition4;
        /**
         * Gets or sets the world-space position of the tip of the right index finger.
         */
        globalRightIndexTipPosition: BABYLON.Vector3;
        private _globalRightIndexTipPosition4;
        constructor(name: string, scene?: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        /**
         * Get the list of animatables in the material.
         * @returns the list of animatables object used in the material
         */
        getAnimatables(): BABYLON.IAnimatable[];
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): FluentBackplateMaterial;
        serialize(): any;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): FluentBackplateMaterial;
    }


    /** @internal */
    export var fluentBackplateVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var fluentBackplatePixelShader: {
        name: string;
        shader: string;
    };




    /** @internal */
    export class FluentMaterialDefines extends BABYLON.MaterialDefines {
        INNERGLOW: boolean;
        BORDER: boolean;
        HOVERLIGHT: boolean;
        TEXTURE: boolean;
        constructor();
    }
    /**
     * Class used to render controls with fluent design
     */
    export class FluentMaterial extends BABYLON.PushMaterial {
        /**
         * Gets or sets inner glow intensity. A value of 0 means no glow (default is 0.5)
         */
        innerGlowColorIntensity: number;
        /**
         * Gets or sets the inner glow color (white by default)
         */
        innerGlowColor: BABYLON.Color3;
        /**
         * Gets or sets the albedo color (Default is BABYLON.Color3(0.3, 0.35, 0.4))
         */
        albedoColor: BABYLON.Color3;
        /**
         * Gets or sets a boolean indicating if borders must be rendered (default is false)
         */
        renderBorders: boolean;
        /**
         * Gets or sets border width (default is 0.5)
         */
        borderWidth: number;
        /**
         * Gets or sets a value indicating the smoothing value applied to border edges (0.02 by default)
         */
        edgeSmoothingValue: number;
        /**
         * Gets or sets the minimum value that can be applied to border width (default is 0.1)
         */
        borderMinValue: number;
        /**
         * Gets or sets a boolean indicating if hover light must be rendered (default is false)
         */
        renderHoverLight: boolean;
        /**
         * Gets or sets the radius used to render the hover light (default is 0.01)
         */
        hoverRadius: number;
        /**
         * Gets or sets the color used to render the hover light (default is BABYLON.Color4(0.3, 0.3, 0.3, 1.0))
         */
        hoverColor: BABYLON.Color4;
        /**
         * Gets or sets the hover light position in world space (default is BABYLON.Vector3.Zero())
         */
        hoverPosition: BABYLON.Vector3;
        private _albedoTexture;
        /** Gets or sets the texture to use for albedo color */
        albedoTexture: BABYLON.Nullable<BABYLON.BaseTexture>;
        /**
         * Creates a new Fluent material
         * @param name defines the name of the material
         * @param scene defines the hosting scene
         */
        constructor(name: string, scene?: BABYLON.Scene);
        needAlphaBlending(): boolean;
        needAlphaTesting(): boolean;
        getAlphaTestTexture(): BABYLON.Nullable<BABYLON.BaseTexture>;
        isReadyForSubMesh(mesh: BABYLON.AbstractMesh, subMesh: BABYLON.SubMesh): boolean;
        bindForSubMesh(world: BABYLON.Matrix, mesh: BABYLON.Mesh, subMesh: BABYLON.SubMesh): void;
        getActiveTextures(): BABYLON.BaseTexture[];
        hasTexture(texture: BABYLON.BaseTexture): boolean;
        dispose(forceDisposeEffect?: boolean): void;
        clone(name: string): FluentMaterial;
        serialize(): any;
        getClassName(): string;
        static Parse(source: any, scene: BABYLON.Scene, rootUrl: string): FluentMaterial;
    }


    /** @internal */
    export var fluentVertexShader: {
        name: string;
        shader: string;
    };


    /** @internal */
    export var fluentPixelShader: {
        name: string;
        shader: string;
    };


    /**
     * BABYLON.Gizmo to resize 2D slates
     */
    export class SlateGizmo extends BABYLON.Gizmo {
        private _boundingDimensions;
        private _pickedPointObserver;
        private _renderObserver;
        private _tmpQuaternion;
        private _tmpVector;
        private _corners;
        private _sides;
        private _handlesParent;
        private _handleHovered;
        private _handleDragged;
        private _boundingBoxGizmo;
        /**
         * Value we use to offset handles from mesh
         */
        private _margin;
        private _handleSize;
        private _attachedSlate;
        private _existingSlateScale;
        /**
         * If set, the handles will increase in size based on the distance away from the camera to have a consistent screen size (Default: true)
         */
        fixedScreenSize: boolean;
        /**
         * The distance away from the object which the draggable meshes should appear world sized when fixedScreenSize is set to true (default: 10)
         */
        fixedScreenSizeDistanceFactor: number;
        /**
         * The slate attached to this gizmo
         */
        set attachedSlate(control: BABYLON.Nullable<HolographicSlate>);
        get attachedSlate(): BABYLON.Nullable<HolographicSlate>;
        constructor(utilityLayer?: BABYLON.UtilityLayerRenderer);
        private _createNode;
        private _keepAspectRatio;
        private _clampDimensions;
        private _moveHandle;
        private _assignDragBehaviorCorners;
        private _assignDragBehaviorSides;
        protected _attachedNodeChanged(value: BABYLON.Nullable<BABYLON.AbstractMesh>): void;
        /**
         * Updates the bounding box information for the gizmo
         */
        updateBoundingBox(): void;
        private _updateHandlesPosition;
        private _updateHandlesScaling;
        protected _update(): void;
        dispose(): void;
    }




    /**
     * State of the handle regarding user interaction
     */
    export enum HandleState {
        /**
         * Handle is idle
         */
        IDLE = 0,
        /**
         * Handle is hovered
         */
        HOVER = 1,
        /**
         * Handle is dragged
         */
        DRAG = 2
    }
    /**
     * Base class for SlateGizmo handles
     */
    export abstract class GizmoHandle {
        protected _scene: BABYLON.Scene;
        protected _state: HandleState;
        protected _materials: HandleMaterial[];
        private _dragStartObserver;
        private _draggingObserver;
        private _dragEndObserver;
        /**
         * @internal
         */
        _dragBehavior: BABYLON.BaseSixDofDragBehavior;
        /**
         * The current state of the handle
         */
        get state(): HandleState;
        private _gizmo;
        /**
         * Returns the gizmo carrying this handle
         */
        get gizmo(): SlateGizmo;
        /**
         * Sets hover state
         */
        set hover(value: boolean);
        /**
         * Sets drag state
         */
        set drag(value: boolean);
        /**
         * Node of this handle
         */
        node: BABYLON.TransformNode;
        /**
         * Creates a handle for a SlateGizmo
         * @param gizmo associated SlateGizmo
         * @param scene scene
         */
        constructor(gizmo: SlateGizmo, scene: BABYLON.Scene);
        protected _createMaterial(positionOffset?: BABYLON.Vector3): HandleMaterial;
        private _updateMaterial;
        /**
         * Binds callbacks from dragging interaction
         * @param dragStartFn Function to call on drag start
         * @param dragFn Function to call on drag
         * @param dragEndFn Function to call on drag end
         */
        setDragBehavior(dragStartFn: (event: {
            position: BABYLON.Vector3;
        }) => void, dragFn: (event: {
            position: BABYLON.Vector3;
        }) => void, dragEndFn: () => void): void;
        /**
         * Creates the meshes and parent node of the handle
         * Should be overridden by child classes
         * @returns created node
         */
        abstract createNode(): BABYLON.TransformNode;
        /**
         * Disposes the handle
         */
        dispose(): void;
    }
    /**
     * Side handle class that rotates the slate
     */
    export class SideHandle extends GizmoHandle {
        /**
         * Creates the meshes and parent node of the handle
         * @returns created node
         */
        createNode(): BABYLON.TransformNode;
    }
    /**
     * Corner handle that resizes the slate
     */
    export class CornerHandle extends GizmoHandle {
        /**
         * Creates the meshes and parent node of the handle
         * @returns created node
         */
        createNode(): BABYLON.TransformNode;
    }


    /**
     * Abstract class used to create a container panel deployed on the surface of a volume
     */
    export abstract class VolumeBasedPanel extends Container3D {
        private _columns;
        private _rows;
        private _rowThenColum;
        private _orientation;
        protected _cellWidth: number;
        protected _cellHeight: number;
        /**
         * Gets or sets the distance between elements
         */
        margin: number;
        /**
         * Gets or sets the orientation to apply to all controls (BABYLON.Container3D.FaceOriginReversedOrientation by default)
         * | Value | Type                                | Description |
         * | ----- | ----------------------------------- | ----------- |
         * | 0     | UNSET_ORIENTATION                   |  Control rotation will remain unchanged |
         * | 1     | FACEORIGIN_ORIENTATION              |  Control will rotate to make it look at sphere central axis |
         * | 2     | FACEORIGINREVERSED_ORIENTATION      |  Control will rotate to make it look back at sphere central axis |
         * | 3     | FACEFORWARD_ORIENTATION             |  Control will rotate to look at z axis (0, 0, 1) |
         * | 4     | FACEFORWARDREVERSED_ORIENTATION     |  Control will rotate to look at negative z axis (0, 0, -1) |
         */
        get orientation(): number;
        set orientation(value: number);
        /**
         * Gets or sets the number of columns requested (10 by default).
         * The panel will automatically compute the number of rows based on number of child controls.
         */
        get columns(): BABYLON.int;
        set columns(value: BABYLON.int);
        /**
         * Gets or sets a the number of rows requested.
         * The panel will automatically compute the number of columns based on number of child controls.
         */
        get rows(): BABYLON.int;
        set rows(value: BABYLON.int);
        /**
         * Creates new VolumeBasedPanel
         * @param name
         */
        constructor(name?: string);
        protected _arrangeChildren(): void;
        /** Child classes must implement this function to provide correct control positioning */
        protected abstract _mapGridNode(control: Control3D, nodePosition: BABYLON.Vector3): void;
        /** Child classes can implement this function to provide additional processing */
        protected _finalProcessing(): void;
    }


    /**
     * Class used to create an interactable object. It's a touchable 3D button using a mesh coming from the current scene
     * @since 5.0.0
     */
    export class TouchMeshButton3D extends TouchButton3D {
        /** @internal */
        protected _currentMesh: BABYLON.Mesh;
        /**
         * Creates a new 3D button based on a mesh
         * @param mesh mesh to become a 3D button. By default this is also the mesh for near interaction collision checking
         * @param name defines the control name
         */
        constructor(mesh: BABYLON.Mesh, name?: string);
        protected _getTypeName(): string;
        protected _createNode(): BABYLON.TransformNode;
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
    }


    /**
     * Simple menu that can contain holographic buttons
     */
    export class TouchHolographicMenu extends VolumeBasedPanel {
        protected _backPlate: BABYLON.Mesh;
        private _backPlateMaterial;
        private _pickedPointObserver;
        private _currentMin;
        private _currentMax;
        private _backPlateMargin;
        /**
         * Scale for the buttons added to the menu
         */
        protected static MENU_BUTTON_SCALE: number;
        /**
         * Gets or sets the margin size of the backplate in button size units.
         * Setting this to 1, will make the backPlate margin the size of 1 button
         */
        get backPlateMargin(): number;
        set backPlateMargin(value: number);
        protected _createNode(scene: BABYLON.Scene): BABYLON.Nullable<BABYLON.TransformNode>;
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
        protected _mapGridNode(control: Control3D, nodePosition: BABYLON.Vector3): void;
        protected _finalProcessing(): void;
        private _updateCurrentMinMax;
        private _updateMargins;
        /**
         * Creates a holographic menu GUI 3D control
         * @param name name of the menu
         */
        constructor(name?: string);
        /**
         * Adds a button to the menu.
         * Please note that the back material of the button will be set to transparent as it is attached to the menu.
         *
         * @param button Button to add
         * @returns This menu
         */
        addButton(button: TouchHolographicButton): TouchHolographicMenu;
        /**
         * This method should not be used directly. It is inherited from `Container3D`.
         * Please use `addButton` instead.
         * @param _control the control to add
         * @returns the current container
         */
        addControl(_control: Control3D): Container3D;
        /**
         * Disposes the menu
         */
        dispose(): void;
    }


    /**
     * Class used to create a holographic button in 3D
     * @since 5.0.0
     */
    export class TouchHolographicButton extends TouchButton3D {
        /**
         * Base Url for the button model.
         */
        static MODEL_BASE_URL: string;
        /**
         * File name for the button model.
         */
        static MODEL_FILENAME: string;
        private _backPlate;
        private _textPlate;
        private _frontPlate;
        private _text;
        private _imageUrl;
        private _shareMaterials;
        private _isBackplateVisible;
        private _frontMaterial;
        private _backMaterial;
        private _plateMaterial;
        private _pickedPointObserver;
        private _pointerHoverObserver;
        private _frontPlateDepth;
        private _backPlateDepth;
        private _backplateColor;
        private _backplateToggledColor;
        private _tooltipFade;
        private _tooltipTextBlock;
        private _tooltipTexture;
        private _tooltipMesh;
        private _tooltipHoverObserver;
        private _tooltipOutObserver;
        private _disposeTooltip;
        /**
         * Rendering ground id of all the mesh in the button
         */
        set renderingGroupId(id: number);
        get renderingGroupId(): number;
        /**
         * Gets the mesh used to render this control
         */
        get mesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        /**
         * Text to be displayed on the tooltip shown when hovering on the button. When set to null tooltip is disabled. (Default: null)
         */
        set tooltipText(text: BABYLON.Nullable<string>);
        get tooltipText(): BABYLON.Nullable<string>;
        /**
         * Gets or sets text for the button
         */
        get text(): string;
        set text(value: string);
        /**
         * Gets or sets the image url for the button
         */
        get imageUrl(): string;
        set imageUrl(value: string);
        /**
         * Gets the back material used by this button
         */
        get backMaterial(): FluentMaterial;
        /**
         * Gets the front material used by this button
         */
        get frontMaterial(): FluentButtonMaterial;
        /**
         * Gets the plate material used by this button
         */
        get plateMaterial(): BABYLON.StandardMaterial;
        /**
         * Gets a boolean indicating if this button shares its material with other HolographicButtons
         */
        get shareMaterials(): boolean;
        /**
         * Sets whether the backplate is visible or hidden. Hiding the backplate is not recommended without some sort of replacement
         */
        set isBackplateVisible(isVisible: boolean);
        /**
         * Creates a new button
         * @param name defines the control name
         * @param shareMaterials
         */
        constructor(name?: string, shareMaterials?: boolean);
        protected _getTypeName(): string;
        private _rebuildContent;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        protected _applyFacade(facadeTexture: AdvancedDynamicTexture): void;
        private _createBackMaterial;
        private _createFrontMaterial;
        private _createPlateMaterial;
        protected _onToggle(newState: boolean): void;
        protected _affectMaterial(mesh: BABYLON.Mesh): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Class used to create a touchable button in 3D
     */
    export class TouchButton3D extends Button3D {
        private _collisionMesh;
        private _collidableFrontDirection;
        private _isNearPressed;
        private _interactionSurfaceHeight;
        private _isToggleButton;
        private _toggleState;
        private _toggleButtonCallback;
        /**
         * An event triggered when the button is toggled. Only fired if 'isToggleButton' is true
         */
        onToggleObservable: BABYLON.Observable<boolean>;
        /**
         * Creates a new touchable button
         * @param name defines the control name
         * @param collisionMesh mesh to track collisions with
         */
        constructor(name?: string, collisionMesh?: BABYLON.Mesh);
        /**
         * Whether the current interaction is caused by near interaction or not
         */
        get isActiveNearInteraction(): boolean;
        /**
         * Sets the front-facing direction of the button. Pass in BABYLON.Vector3.Zero to allow interactions from any direction
         * @param frontWorldDir the forward direction of the button
         */
        set collidableFrontDirection(frontWorldDir: BABYLON.Vector3);
        /**
         * Returns the front-facing direction of the button, or BABYLON.Vector3.Zero if there is no 'front'
         */
        get collidableFrontDirection(): BABYLON.Vector3;
        /**
         * Sets the mesh used for testing input collision
         * @param collisionMesh the new collision mesh for the button
         */
        set collisionMesh(collisionMesh: BABYLON.Mesh);
        /**
         * Setter for if this TouchButton3D should be treated as a toggle button
         * @param value If this TouchHolographicButton should act like a toggle button
         */
        set isToggleButton(value: boolean);
        get isToggleButton(): boolean;
        /**
         * A public entrypoint to set the toggle state of the TouchHolographicButton. Only works if 'isToggleButton' is true
         * @param newState The new state to set the TouchHolographicButton's toggle state to
         */
        set isToggled(newState: boolean);
        get isToggled(): boolean;
        protected _onToggle(newState: boolean): void;
        private _isInteractionInFrontOfButton;
        /**
         * Get the height of the touchPoint from the collidable part of the button
         * @param touchPoint the point to compare to the button, in absolute position
         * @returns the depth of the touch point into the front of the button
         */
        getPressDepth(touchPoint: BABYLON.Vector3): number;
        protected _getInteractionHeight(interactionPos: BABYLON.Vector3, basePos: BABYLON.Vector3): number;
        /**
         * @internal
         */
        _generatePointerEventType(providedType: number, nearMeshPosition: BABYLON.Vector3, activeInteractionCount: number): number;
        protected _getTypeName(): string;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Class used to create a stack panel in 3D on XY plane
     */
    export class StackPanel3D extends Container3D {
        private _isVertical;
        /**
         * Gets or sets a boolean indicating if the stack panel is vertical or horizontal (horizontal by default)
         */
        get isVertical(): boolean;
        set isVertical(value: boolean);
        /**
         * Gets or sets the distance between elements
         */
        margin: number;
        /**
         * Creates new StackPanel
         * @param isVertical
         */
        constructor(isVertical?: boolean);
        protected _arrangeChildren(): void;
    }


    /**
     * Class used to create a container panel deployed on the surface of a sphere
     */
    export class SpherePanel extends VolumeBasedPanel {
        private _radius;
        /**
         * Gets or sets the radius of the sphere where to project controls (5 by default)
         */
        get radius(): BABYLON.float;
        set radius(value: BABYLON.float);
        protected _mapGridNode(control: Control3D, nodePosition: BABYLON.Vector3): void;
        private _sphericalMapping;
    }


    /**
     * Class used to create a slider in 3D
     */
    export class Slider3D extends Control3D {
        /**
         * Base Url for the models.
         */
        static MODEL_BASE_URL: string;
        /**
         * File name for the 8x4 model.
         */
        static MODEL_FILENAME: string;
        private _sliderBackplate;
        private _sliderBackplateMaterial;
        private _sliderBarMaterial;
        private _sliderThumbMaterial;
        private _sliderThumb;
        private _sliderBar;
        private _sliderBackplateVisible;
        private _minimum;
        private _maximum;
        private _value;
        private _step;
        private _draggedPosition;
        /** BABYLON.Observable raised when the sldier value changes */
        onValueChangedObservable: BABYLON.Observable<number>;
        /**
         * Creates a new slider
         * @param name defines the control name
         * @param sliderBackplateVisible defines if the control has a backplate, default is false
         */
        constructor(name?: string, sliderBackplateVisible?: boolean);
        /**
         * Gets the mesh used to render this control
         */
        get mesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        /** Gets or sets minimum value */
        get minimum(): number;
        set minimum(value: number);
        /** Gets or sets maximum value */
        get maximum(): number;
        set maximum(value: number);
        /** Gets or sets step value */
        get step(): number;
        set step(value: number);
        /** Gets or sets current value */
        get value(): number;
        set value(value: number);
        protected get start(): number;
        protected get end(): number;
        /**
         * Gets the slider bar material used by this control
         */
        get sliderBarMaterial(): MRDLSliderBarMaterial;
        /**
         * Gets the slider thumb material used by this control
         */
        get sliderThumbMaterial(): MRDLSliderThumbMaterial;
        /**
         * Gets the slider backplate material used by this control
         */
        get sliderBackplateMaterial(): MRDLBackplateMaterial;
        /**
         * Gets the slider bar mesh used by this control
         */
        get sliderBar(): BABYLON.AbstractMesh;
        /**
         * Gets the slider thumb mesh used by this control
         */
        get sliderThumb(): BABYLON.AbstractMesh;
        /**
         * Gets the slider backplate mesh used by this control
         */
        get sliderBackplate(): BABYLON.AbstractMesh;
        /** Sets a boolean indicating if the control is visible */
        set isVisible(value: boolean);
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
        private _createBehavior;
        private _convertToPosition;
        private _convertToValue;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Class used to create a container panel where items get randomized planar mapping
     */
    export class ScatterPanel extends VolumeBasedPanel {
        private _iteration;
        /**
         * Gets or sets the number of iteration to use to scatter the controls (100 by default)
         */
        get iteration(): BABYLON.float;
        set iteration(value: BABYLON.float);
        protected _mapGridNode(control: Control3D, nodePosition: BABYLON.Vector3): void;
        private _scatterMapping;
        protected _finalProcessing(): void;
    }


    /**
     * Class used to create a container panel deployed on the surface of a plane
     */
    export class PlanePanel extends VolumeBasedPanel {
        protected _mapGridNode(control: Control3D, nodePosition: BABYLON.Vector3): void;
    }


    /**
     * NearMenu that displays buttons and follows the camera
     * @since 5.0.0
     */
    export class NearMenu extends TouchHolographicMenu {
        /**
         * Base Url for the assets.
         */
        private static _ASSETS_BASE_URL;
        /**
         * File name for the close icon.
         */
        private static _PIN_ICON_FILENAME;
        private _pinButton;
        private _dragObserver;
        private _defaultBehavior;
        /**
         * Regroups all mesh behaviors for the near menu
         */
        get defaultBehavior(): DefaultBehavior;
        private _isPinned;
        /**
         * Indicates if the near menu is world-pinned
         */
        get isPinned(): boolean;
        set isPinned(value: boolean);
        private _createPinButton;
        protected _createNode(scene: BABYLON.Scene): BABYLON.Nullable<BABYLON.TransformNode>;
        protected _finalProcessing(): void;
        /**
         * Creates a near menu GUI 3D control
         * @param name name of the near menu
         */
        constructor(name?: string);
        /**
         * Disposes the near menu
         */
        dispose(): void;
    }


    /**
     * Class used to create an interactable object. It's a 3D button using a mesh coming from the current scene
     */
    export class MeshButton3D extends Button3D {
        /** @internal */
        protected _currentMesh: BABYLON.Mesh;
        /**
         * Creates a new 3D button based on a mesh
         * @param mesh mesh to become a 3D button
         * @param name defines the control name
         */
        constructor(mesh: BABYLON.Mesh, name?: string);
        protected _getTypeName(): string;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
    }




    /**
     * Class used to create a holographic slate
     * @since 5.0.0
     */
    export class HolographicSlate extends ContentDisplay3D {
        /**
         * Base Url for the assets.
         */
        static ASSETS_BASE_URL: string;
        /**
         * File name for the close icon.
         */
        static CLOSE_ICON_FILENAME: string;
        /**
         * File name for the close icon.
         */
        static FOLLOW_ICON_FILENAME: string;
        private static _DEFAULT_TEXT_RESOLUTION_Y;
        /**
         * Margin between title bar and contentplate
         */
        titleBarMargin: number;
        /**
         * Origin in local coordinates (top left corner)
         */
        origin: BABYLON.Vector3;
        private _dimensions;
        private _titleBarHeight;
        private _titleBarMaterial;
        private _backMaterial;
        private _contentMaterial;
        private _pickedPointObserver;
        private _positionChangedObserver;
        private _titleText;
        private _titleTextComponent;
        private _contentViewport;
        private _contentDragBehavior;
        private _defaultBehavior;
        /**
         * Regroups all mesh behaviors for the slate
         */
        get defaultBehavior(): DefaultBehavior;
        /** @internal */
        _gizmo: SlateGizmo;
        protected _titleBar: BABYLON.Mesh;
        protected _titleBarTitle: BABYLON.Mesh;
        protected _contentPlate: BABYLON.Mesh;
        protected _backPlate: BABYLON.Mesh;
        /** @internal */
        _followButton: TouchHolographicButton;
        protected _closeButton: TouchHolographicButton;
        protected _contentScaleRatio: number;
        /**
         * 2D dimensions of the slate
         */
        get dimensions(): BABYLON.Vector2;
        set dimensions(value: BABYLON.Vector2);
        /**
         * Minimum dimensions of the slate
         */
        minDimensions: BABYLON.Vector2;
        /**
         * Default dimensions of the slate
         */
        readonly defaultDimensions: BABYLON.Vector2;
        /**
         * Height of the title bar component
         */
        get titleBarHeight(): number;
        set titleBarHeight(value: number);
        /**
         * Rendering ground id of all the meshes
         */
        set renderingGroupId(id: number);
        get renderingGroupId(): number;
        /**
         * The title text displayed at the top of the slate
         */
        set title(title: string);
        get title(): string;
        /**
         * Creates a new slate
         * @param name defines the control name
         */
        constructor(name?: string);
        /**
         * Apply the facade texture (created from the content property).
         * This function can be overloaded by child classes
         * @param facadeTexture defines the AdvancedDynamicTexture to use
         */
        protected _applyFacade(facadeTexture: AdvancedDynamicTexture): void;
        private _addControl;
        protected _getTypeName(): string;
        /**
         * @internal
         */
        _positionElements(): void;
        private _applyContentViewport;
        private _resetContentPositionAndZoom;
        /**
         * @internal
         */
        _updatePivot(): void;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        private _attachContentPlateBehavior;
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
        /**
         * @internal
         */
        _prepareNode(scene: BABYLON.Scene): void;
        /**
         * Resets the aspect and pose of the slate so it is right in front of the active camera, facing towards it.
         * @param resetAspect Should the slate's dimensions/aspect ratio be reset as well
         */
        resetDefaultAspectAndPose(resetAspect?: boolean): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Class used to create a holographic button in 3D
     */
    export class HolographicButton extends Button3D {
        private _backPlate;
        private _textPlate;
        private _frontPlate;
        private _text;
        private _imageUrl;
        private _shareMaterials;
        private _frontMaterial;
        private _backMaterial;
        private _plateMaterial;
        private _pickedPointObserver;
        private _tooltipFade;
        private _tooltipTextBlock;
        private _tooltipTexture;
        private _tooltipMesh;
        private _tooltipHoverObserver;
        private _tooltipOutObserver;
        private _disposeTooltip;
        /**
         * Rendering ground id of all the mesh in the button
         */
        set renderingGroupId(id: number);
        get renderingGroupId(): number;
        /**
         * Text to be displayed on the tooltip shown when hovering on the button. When set to null tooltip is disabled. (Default: null)
         */
        set tooltipText(text: BABYLON.Nullable<string>);
        get tooltipText(): BABYLON.Nullable<string>;
        /**
         * Gets or sets text for the button
         */
        get text(): string;
        set text(value: string);
        /**
         * Gets or sets the image url for the button
         */
        get imageUrl(): string;
        set imageUrl(value: string);
        /**
         * Gets the back material used by this button
         */
        get backMaterial(): FluentMaterial;
        /**
         * Gets the front material used by this button
         */
        get frontMaterial(): FluentMaterial;
        /**
         * Gets the plate material used by this button
         */
        get plateMaterial(): BABYLON.StandardMaterial;
        /**
         * Gets a boolean indicating if this button shares its material with other HolographicButtons
         */
        get shareMaterials(): boolean;
        /**
         * Creates a new button
         * @param name defines the control name
         * @param shareMaterials
         */
        constructor(name?: string, shareMaterials?: boolean);
        protected _getTypeName(): string;
        private _rebuildContent;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        protected _applyFacade(facadeTexture: AdvancedDynamicTexture): void;
        private _createBackMaterial;
        private _createFrontMaterial;
        private _createPlateMaterial;
        protected _affectMaterial(mesh: BABYLON.Mesh): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Class used to create a holographic backplate in 3D
     * @since 5.0.0
     */
    export class HolographicBackplate extends Control3D {
        private _shareMaterials;
        /**
         * Base Url for the button model.
         */
        static MODEL_BASE_URL: string;
        /**
         * File name for the button model.
         */
        static MODEL_FILENAME: string;
        private _model;
        private _material;
        /**
         * Rendering ground id of the backplate mesh.
         */
        set renderingGroupId(id: number);
        get renderingGroupId(): number;
        /**
         * Gets the material used by the backplate
         */
        get material(): FluentBackplateMaterial;
        /**
         * Gets a boolean indicating if this backplate shares its material with other HolographicBackplates
         */
        get shareMaterials(): boolean;
        /**
         * Creates a new holographic backplate
         * @param name defines the control name
         * @param _shareMaterials
         */
        constructor(name?: string, _shareMaterials?: boolean);
        protected _getTypeName(): string;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        private _createMaterial;
        protected _affectMaterial(mesh: BABYLON.Mesh): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Hand menu that displays buttons and floats around the hand.
     * @since 5.0.0
     */
    export class HandMenu extends TouchHolographicMenu {
        private _handConstraintBehavior;
        /**
         * The hand constraint behavior setting the transformation of this node
         */
        get handConstraintBehavior(): BABYLON.HandConstraintBehavior;
        protected _createNode(scene: BABYLON.Scene): BABYLON.Nullable<BABYLON.TransformNode>;
        /**
         * Creates a hand menu GUI 3D control
         * @param xr the BABYLON.WebXRExperienceHelper used to link this control to the enabled WebXRHandTracking feature
         * @param name name of the hand menu
         */
        constructor(xr: BABYLON.WebXRExperienceHelper, name?: string);
        /**
         * Disposes the hand menu
         */
        dispose(): void;
    }


    /**
     * Class used to create a container panel deployed on the surface of a cylinder
     */
    export class CylinderPanel extends VolumeBasedPanel {
        private _radius;
        /**
         * Gets or sets the radius of the cylinder where to project controls (5 by default)
         */
        get radius(): BABYLON.float;
        set radius(value: BABYLON.float);
        protected _mapGridNode(control: Control3D, nodePosition: BABYLON.Vector3): void;
        private _cylindricalMapping;
    }


    /**
     * Class used as base class for controls
     */
    export class Control3D implements BABYLON.IDisposable, BABYLON.IBehaviorAware<Control3D> {
        /** Defines the control name */
        name?: string | undefined;
        private _node;
        private _downCount;
        private _enterCount;
        private _downPointerIds;
        protected _isVisible: boolean;
        /** @internal */
        _host: GUI3DManager;
        /** @internal */
        _isScaledByManager: boolean;
        /** Gets or sets the control position in world space */
        get position(): BABYLON.Vector3;
        set position(value: BABYLON.Vector3);
        /** Gets or sets the control scaling in world space */
        get scaling(): BABYLON.Vector3;
        set scaling(value: BABYLON.Vector3);
        /** Callback used to start pointer enter animation */
        pointerEnterAnimation: () => void;
        /** Callback used to start pointer out animation */
        pointerOutAnimation: () => void;
        /** Callback used to start pointer down animation */
        pointerDownAnimation: () => void;
        /** Callback used to start pointer up animation */
        pointerUpAnimation: () => void;
        /**
         * An event triggered when the pointer moves over the control
         */
        onPointerMoveObservable: BABYLON.Observable<BABYLON.Vector3>;
        /**
         * An event triggered when the pointer moves out of the control
         */
        onPointerOutObservable: BABYLON.Observable<Control3D>;
        /**
         * An event triggered when the pointer taps the control
         */
        onPointerDownObservable: BABYLON.Observable<Vector3WithInfo>;
        /**
         * An event triggered when pointer is up
         */
        onPointerUpObservable: BABYLON.Observable<Vector3WithInfo>;
        /**
         * An event triggered when a control is clicked on (with a mouse)
         */
        onPointerClickObservable: BABYLON.Observable<Vector3WithInfo>;
        /**
         * An event triggered when pointer enters the control
         */
        onPointerEnterObservable: BABYLON.Observable<Control3D>;
        /**
         * Gets or sets the parent container
         */
        parent: BABYLON.Nullable<Container3D>;
        private _behaviors;
        /**
         * Gets the list of attached behaviors
         * @see https://doc.babylonjs.com/features/featuresDeepDive/behaviors
         */
        get behaviors(): BABYLON.Behavior<Control3D>[];
        /**
         * Attach a behavior to the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/behaviors
         * @param behavior defines the behavior to attach
         * @returns the current control
         */
        addBehavior(behavior: BABYLON.Behavior<Control3D>): Control3D;
        /**
         * Remove an attached behavior
         * @see https://doc.babylonjs.com/features/featuresDeepDive/behaviors
         * @param behavior defines the behavior to attach
         * @returns the current control
         */
        removeBehavior(behavior: BABYLON.Behavior<Control3D>): Control3D;
        /**
         * Gets an attached behavior by name
         * @param name defines the name of the behavior to look for
         * @see https://doc.babylonjs.com/features/featuresDeepDive/behaviors
         * @returns null if behavior was not found else the requested behavior
         */
        getBehaviorByName(name: string): BABYLON.Nullable<BABYLON.Behavior<Control3D>>;
        /** Gets or sets a boolean indicating if the control is visible */
        get isVisible(): boolean;
        set isVisible(value: boolean);
        /**
         * Creates a new control
         * @param name defines the control name
         */
        constructor(
        /** Defines the control name */
        name?: string | undefined);
        /**
         * Gets a string representing the class name
         */
        get typeName(): string;
        /**
         * Get the current class name of the control.
         * @returns current class name
         */
        getClassName(): string;
        protected _getTypeName(): string;
        /**
         * Gets the transform node used by this control
         */
        get node(): BABYLON.Nullable<BABYLON.TransformNode>;
        /**
         * Gets the mesh used to render this control
         */
        get mesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        /**
         * Link the control as child of the given node
         * @param node defines the node to link to. Use null to unlink the control
         * @returns the current control
         */
        linkToTransformNode(node: BABYLON.Nullable<BABYLON.TransformNode>): Control3D;
        /**
         * @internal
         */
        _prepareNode(scene: BABYLON.Scene): void;
        protected _injectGUI3DReservedDataStore(node: BABYLON.TransformNode): any;
        /**
         * Node creation.
         * Can be overriden by children
         * @param scene defines the scene where the node must be attached
         * @returns the attached node or null if none. Must return a Mesh or BABYLON.AbstractMesh if there is an attached visible object
         */
        protected _createNode(scene: BABYLON.Scene): BABYLON.Nullable<BABYLON.TransformNode>;
        /**
         * Affect a material to the given mesh
         * @param mesh defines the mesh which will represent the control
         */
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
        private _isTouchButton3D;
        /**
         * @internal
         */
        _onPointerMove(target: Control3D, coordinates: BABYLON.Vector3): void;
        /**
         * @internal
         */
        _onPointerEnter(target: Control3D): boolean;
        /**
         * @internal
         */
        _onPointerOut(target: Control3D): void;
        /**
         * @internal
         */
        _onPointerDown(target: Control3D, coordinates: BABYLON.Vector3, pointerId: number, buttonIndex: number): boolean;
        /**
         * @internal
         */
        _onPointerUp(target: Control3D, coordinates: BABYLON.Vector3, pointerId: number, buttonIndex: number, notifyClick: boolean): void;
        /**
         * @internal
         */
        forcePointerUp(pointerId?: BABYLON.Nullable<number>): void;
        /**
         * @internal
         */
        _processObservables(type: number, pickedPoint: BABYLON.Vector3, originMeshPosition: BABYLON.Nullable<BABYLON.Vector3>, pointerId: number, buttonIndex: number): boolean;
        /** @internal */
        _disposeNode(): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * The base class for controls that display content
     */
    export class ContentDisplay3D extends Control3D {
        private _content;
        private _facadeTexture;
        protected _contentResolution: number;
        protected _contentScaleRatio: number;
        protected _contentScaleRatioY?: number;
        /**
         * Gets or sets the GUI 2D content used to display the button's facade
         */
        get content(): Control;
        set content(value: Control);
        protected _setFacadeTextureScaling(): void;
        /**
         * Gets or sets the texture resolution used to render content (512 by default)
         */
        get contentResolution(): number;
        set contentResolution(value: number);
        protected _disposeFacadeTexture(): void;
        protected _resetContent(): void;
        /**
         * Apply the facade texture (created from the content property).
         * This function can be overloaded by child classes
         * @param facadeTexture defines the AdvancedDynamicTexture to use
         */
        protected _applyFacade(facadeTexture: AdvancedDynamicTexture): void;
    }


    /**
     * Class used to create containers for controls
     */
    export class Container3D extends Control3D {
        private _blockLayout;
        /**
         * Gets the list of child controls
         */
        protected _children: Control3D[];
        /**
         * Gets the list of child controls
         */
        get children(): Array<Control3D>;
        /**
         * Gets or sets a boolean indicating if the layout must be blocked (default is false).
         * This is helpful to optimize layout operation when adding multiple children in a row
         */
        get blockLayout(): boolean;
        set blockLayout(value: boolean);
        /**
         * Creates a new container
         * @param name defines the container name
         */
        constructor(name?: string);
        /**
         * Force the container to update the layout. Please note that it will not take blockLayout property in account
         * @returns the current container
         */
        updateLayout(): Container3D;
        /**
         * Gets a boolean indicating if the given control is in the children of this control
         * @param control defines the control to check
         * @returns true if the control is in the child list
         */
        containsControl(control: Control3D): boolean;
        /**
         * Adds a control to the children of this control
         * @param control defines the control to add
         * @returns the current container
         */
        addControl(control: Control3D): Container3D;
        /**
         * This function will be called everytime a new control is added
         */
        protected _arrangeChildren(): void;
        protected _createNode(scene: BABYLON.Scene): BABYLON.Nullable<BABYLON.TransformNode>;
        /**
         * Removes a control from the children of this control
         * @param control defines the control to remove
         * @returns the current container
         */
        removeControl(control: Control3D): Container3D;
        protected _getTypeName(): string;
        /**
         * Releases all associated resources
         */
        dispose(): void;
        /** Control rotation will remain unchanged  */
        static readonly UNSET_ORIENTATION = 0;
        /** Control will rotate to make it look at sphere central axis */
        static readonly FACEORIGIN_ORIENTATION = 1;
        /** Control will rotate to make it look back at sphere central axis */
        static readonly FACEORIGINREVERSED_ORIENTATION = 2;
        /** Control will rotate to look at z axis (0, 0, 1) */
        static readonly FACEFORWARD_ORIENTATION = 3;
        /** Control will rotate to look at negative z axis (0, 0, -1) */
        static readonly FACEFORWARDREVERSED_ORIENTATION = 4;
    }


    /**
     * Options used to create a button in 3D
     */
    export interface IButton3DCreationOptions {
        /**
         * Width of the button. Default: 1
         */
        width?: number;
        /**
         * Height of the button. Default: 1
         */
        height?: number;
        /**
         * Depth of the button. Default: 0.08
         */
        depth?: number;
    }
    /**
     * Class used to create a button in 3D
     */
    export class Button3D extends AbstractButton3D {
        /** @internal */
        protected _currentMaterial: BABYLON.Material;
        protected _options: IButton3DCreationOptions;
        protected _height: number;
        protected _depth: number;
        /**
         * Creates a new button
         * @param name defines the control name
         * @param options defines the options used to create the button
         */
        constructor(name?: string, options?: IButton3DCreationOptions);
        /**
         * Apply the facade texture (created from the content property).
         * @param facadeTexture defines the AdvancedDynamicTexture to use
         */
        protected _applyFacade(facadeTexture: AdvancedDynamicTexture): void;
        protected _getTypeName(): string;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        protected _affectMaterial(mesh: BABYLON.AbstractMesh): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Class used as a root to all buttons
     */
    export class AbstractButton3D extends ContentDisplay3D {
        /**
         * Creates a new button
         * @param name defines the control name
         */
        constructor(name?: string);
        protected _getTypeName(): string;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
    }


    /**
     * Class used to create the mrtkv3 button
     */
    export class TouchHolographicButtonV3 extends TouchButton3D {
        /**
         * Base Url for the frontplate model.
         */
        static MRTK_ASSET_BASE_URL: string;
        /**
         * File name for the frontplate model.
         */
        static FRONTPLATE_MODEL_FILENAME: string;
        /**
         * File name for the backplate model.
         */
        static BACKPLATE_MODEL_FILENAME: string;
        /**
         * File name for the backglow model.
         */
        static BACKGLOW_MODEL_FILENAME: string;
        /**
         * File name for the innerquad model.
         */
        static INNERQUAD_MODEL_FILENAME: string;
        /**
         * Gets or sets the horizontal scaling for the button.
         */
        width: number;
        /**
         * Gets or sets the vertical scaling for the button.
         */
        height: number;
        /**
         * Gets or sets the bevel radius for the button.
         */
        radius: number;
        /**
         * Gets or sets the font size of the button text in pixels.
         * This is only adjustable for a button with width to height ratio greater than 1.
         */
        textSizeInPixels: number;
        /**
         * Gets or sets the size of the button image in pixels.
         * This is only adjustable for a button with width to height ratio greater than 1.
         */
        imageSizeInPixels: number;
        /**
         * Gets or sets the color of the button plate.
         */
        plateMaterialColor: BABYLON.Color3;
        /**
         * Gets or sets the depth of the button's front plate.
         * This variable determines the z scaling and z position for some of the button's meshes.
         */
        frontPlateDepth: number;
        /**
         * Gets or sets the depth of the button's back plate.
         * This variable determines the z scaling and z position for some of the button's meshes.
         */
        backPlateDepth: number;
        /**
         * Gets or sets the offset value for button's back glow.
         * This variable determines the x, y scaling of the button's meshes.
         */
        backGlowOffset: number;
        /**
         * Gets or sets the value that determines the z scaling and z position for the innerQuad and BackGlow meshes.
         */
        flatPlaneDepth: number;
        /**
         * Gets or sets the radius for FrontMaterial and innerQuadMaterial.
         */
        innerQuadRadius: number;
        /**
         * Gets or sets the color for innerQuadMaterial.
         */
        innerQuadColor: BABYLON.Color4;
        /**
         * Gets or sets the color for innerQuadMaterial for when it is toggled.
         */
        innerQuadToggledColor: BABYLON.Color4;
        /**
         * Gets or sets the color for innerQuadMaterial for when it is hovered.
         */
        innerQuadHoverColor: BABYLON.Color4;
        /**
         * Gets or sets the color for innerQuadMaterial for when it is toggled and hovered.
         */
        innerQuadToggledHoverColor: BABYLON.Color4;
        private _backPlate;
        private _textPlate;
        private _frontPlate;
        private _backGlow;
        private _innerQuad;
        private _collisionPlate;
        private _frontPlateCollisionMesh;
        private _isBackplateVisible;
        private _text;
        private _subtext;
        private _imageUrl;
        private _shareMaterials;
        private _frontMaterial;
        private _backMaterial;
        private _backGlowMaterial;
        private _innerQuadMaterial;
        private _plateMaterial;
        private _pickedPointObserver;
        private _pointerClickObserver;
        private _pointerEnterObserver;
        private _pointerOutObserver;
        private _toggleObserver;
        private _tooltipFade;
        private _tooltipTextBlock;
        private _tooltipTexture;
        private _tooltipMesh;
        private _tooltipHoverObserver;
        private _tooltipOutObserver;
        private _disposeTooltip;
        /**
         * Rendering ground id of all the mesh in the button
         */
        set renderingGroupId(id: number);
        get renderingGroupId(): number;
        /**
         * Gets the mesh used to render this control
         */
        get mesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        /**
         * Text to be displayed on the tooltip shown when hovering on the button. When set to null tooltip is disabled. (Default: null)
         * Set this property after adding the button to the GUI3DManager
         */
        set tooltipText(text: BABYLON.Nullable<string>);
        get tooltipText(): BABYLON.Nullable<string>;
        /**
         * Gets or sets text for the button
         */
        get text(): string;
        set text(value: string);
        /**
         * Gets or sets subtext for a button with larger width
         */
        get subtext(): string;
        set subtext(value: string);
        /**
         * Gets or sets the image url for the button
         */
        get imageUrl(): string;
        set imageUrl(value: string);
        /**
         * Gets the back material used by this button
         */
        get backMaterial(): MRDLBackplateMaterial;
        /**
         * Gets the front material used by this button
         */
        get frontMaterial(): MRDLFrontplateMaterial;
        /**
         * Gets the back glow material used by this button
         */
        get backGlowMaterial(): MRDLBackglowMaterial;
        /**
         * Gets the inner quad material used by this button
         */
        get innerQuadMaterial(): MRDLInnerquadMaterial;
        /**
         * Gets the plate material used by this button
         */
        get plateMaterial(): BABYLON.StandardMaterial;
        /**
         * Gets a boolean indicating if this button shares its material with other V3 Buttons
         */
        get shareMaterials(): boolean;
        /**
         * Sets whether the backplate is visible or hidden. Hiding the backplate is not recommended without some sort of replacement
         */
        set isBackplateVisible(isVisible: boolean);
        /**
         * Creates a new button
         * @param name defines the control name
         * @param shareMaterials
         */
        constructor(name?: string, shareMaterials?: boolean);
        protected _getTypeName(): string;
        private _rebuildContent;
        private _getAspectRatio;
        private _alignContentVertically;
        private _alignContentHorizontally;
        protected _createNode(scene: BABYLON.Scene): BABYLON.TransformNode;
        private _createBackPlate;
        private _createFrontPlate;
        private _createInnerQuad;
        private _createBackGlow;
        protected _applyFacade(facadeTexture: AdvancedDynamicTexture): void;
        private _performClickAnimation;
        private _performEnterExitAnimation;
        private _createBackMaterial;
        private _createFrontMaterial;
        private _createBackGlowMaterial;
        private _createInnerQuadMaterial;
        private _createPlateMaterial;
        protected _onToggle(newState: boolean): void;
        protected _affectMaterial(mesh: BABYLON.Mesh): void;
        /**
         * Releases all associated resources
         */
        dispose(): void;
    }


    /**
     * Default behavior for 3D UI elements.
     * Handles a BABYLON.FollowBehavior, SixDofBehavior and BABYLON.SurfaceMagnetismBehavior
     * @since 5.0.0
     */
    export class DefaultBehavior implements BABYLON.Behavior<BABYLON.Mesh> {
        private _scene;
        private _followBehavior;
        private _sixDofDragBehavior;
        private _surfaceMagnetismBehavior;
        private _onBeforeRenderObserver;
        private _onDragObserver;
        /**
         * Instantiates the default behavior
         */
        constructor();
        /**
         * Attached node of this behavior
         */
        attachedNode: BABYLON.Nullable<BABYLON.Mesh>;
        /**
         *  The name of the behavior
         */
        get name(): string;
        /**
         *  The follow behavior
         */
        get followBehavior(): BABYLON.FollowBehavior;
        /**
         *  The six DoF drag behavior
         */
        get sixDofDragBehavior(): BABYLON.SixDofDragBehavior;
        /**
         * The surface magnetism behavior
         */
        get surfaceMagnetismBehavior(): BABYLON.SurfaceMagnetismBehavior;
        /**
         * Enables the follow behavior
         */
        followBehaviorEnabled: boolean;
        /**
         * Enables the six DoF drag behavior
         */
        sixDofDragBehaviorEnabled: boolean;
        /**
         * Enables the surface magnetism behavior
         */
        surfaceMagnetismBehaviorEnabled: boolean;
        /**
         *  Initializes the behavior
         */
        init(): void;
        /**
         * Attaches the default behavior
         * @param ownerMesh The top level mesh
         * @param draggablesMeshes Descendant meshes that can be used for dragging the owner mesh
         * @param sceneUnderstandingMeshes Meshes from the scene understanding that will be used for surface magnetism
         */
        attach(ownerMesh: BABYLON.Mesh, draggablesMeshes?: BABYLON.Mesh[], sceneUnderstandingMeshes?: BABYLON.AbstractMesh[]): void;
        /**
         *  Detaches the behavior from the mesh
         */
        detach(): void;
        private _addObservables;
        private _removeObservables;
    }


    /**
     * Class used to load GUI via XML.
     */
    export class XmlLoader {
        private _nodes;
        private _nodeTypes;
        private _isLoaded;
        private _objectAttributes;
        private _rootNode;
        private _parentClass;
        /**
         * Create a new xml loader
         * @param parentClass Sets the class context. Used when the loader is instanced inside a class and not in a global context
         */
        constructor(parentClass?: any);
        private _getChainElement;
        private _getClassAttribute;
        private _createGuiElement;
        private _parseGrid;
        private _parseElement;
        private _prepareSourceElement;
        private _parseElementsFromSource;
        private _parseXml;
        /**
         * Gets if the loading has finished.
         * @returns whether the loading has finished or not
         */
        isLoaded(): boolean;
        /**
         * Gets a loaded node / control by id.
         * @param id the Controls id set in the xml
         * @returns element of type Control
         */
        getNodeById(id: string): any;
        /**
         * Gets all loaded nodes / controls
         * @returns Array of controls
         */
        getNodes(): any;
        /**
         * Disposes the loaded layout
         */
        dispose(): void;
        /**
         * Initiates the xml layout loading
         * @param xmlFile defines the xml layout to load
         * @param rootNode defines the node / control to use as a parent for the loaded layout controls.
         * @param onSuccess defines the callback called on layout load successfully.
         * @param onError defines the callback called on layout load failure.
         */
        loadLayout(xmlFile: any, rootNode: any, onSuccess?: BABYLON.Nullable<() => void>, onError?: BABYLON.Nullable<(error: string) => void>): void;
        /**
         * Initiates the xml layout loading asynchronously
         * @param xmlFile defines the xml layout to load
         * @param rootNode defines the node / control to use as a parent for the loaded layout controls.
         * @returns Promise
         */
        loadLayoutAsync(xmlFile: any, rootNode: any): Promise<any>;
    }


    /**
     * Class used to specific a value and its associated unit
     */
    export class ValueAndUnit {
        /** defines a boolean indicating if the value can be negative */
        negativeValueAllowed: boolean;
        private _value;
        private _unit;
        private _originalUnit;
        /**
         * Gets or sets a value indicating that this value will not scale accordingly with adaptive scaling property
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#adaptive-scaling
         */
        ignoreAdaptiveScaling: boolean;
        /**
         * BABYLON.Observable event triggered each time the value or unit changes
         */
        onChangedObservable: BABYLON.Observable<void>;
        /**
         * Creates a new ValueAndUnit
         * @param value defines the value to store
         * @param unit defines the unit to store - defaults to ValueAndUnit.UNITMODE_PIXEL
         * @param negativeValueAllowed defines a boolean indicating if the value can be negative
         */
        constructor(value: number, 
        /** defines the unit to store */
        unit?: number, 
        /** defines a boolean indicating if the value can be negative */
        negativeValueAllowed?: boolean);
        /** Gets a boolean indicating if the value is a percentage */
        get isPercentage(): boolean;
        /** Gets a boolean indicating if the value is store as pixel */
        get isPixel(): boolean;
        /**
         * Gets value (without units)
         * @deprecated use value property instead
         */
        get internalValue(): number;
        /** Gets value (without units) */
        get value(): number;
        /** Sets value (without units) */
        set value(value: number);
        /** Gets units (without value) */
        get unit(): number;
        /** Sets units (without value) */
        set unit(value: number);
        /**
         * Gets value as pixel
         * @param host defines the root host
         * @param refValue defines the reference value for percentages
         * @returns the value as pixel
         */
        getValueInPixel(host: AdvancedDynamicTexture, refValue: number): number;
        /**
         * Update the current value and unit.
         * @param value defines the value to store
         * @param unit defines the unit to store
         * @returns the current ValueAndUnit
         */
        updateInPlace(value: number, unit?: number): ValueAndUnit;
        /**
         * Gets the value accordingly to its unit
         * @param host  defines the root host
         * @returns the value
         */
        getValue(host: AdvancedDynamicTexture): number;
        /**
         * Gets a string representation of the value
         * @param host defines the root host
         * @param decimals defines an optional number of decimals to display
         * @returns a string
         */
        toString(host: AdvancedDynamicTexture, decimals?: number): string;
        /**
         * Store a value parsed from a string
         * @param source defines the source string
         * @returns true if the value was successfully parsed and updated
         */
        fromString(source: string | number): boolean;
        private static _Regex;
        private static _UNITMODE_PERCENTAGE;
        private static _UNITMODE_PIXEL;
        /** UNITMODE_PERCENTAGE */
        static get UNITMODE_PERCENTAGE(): number;
        /** UNITMODE_PIXEL */
        static get UNITMODE_PIXEL(): number;
    }


    /**
     * Define a style used by control to automatically setup properties based on a template.
     * Only support font related properties so far
     */
    export class Style implements BABYLON.IDisposable {
        private _fontFamily;
        private _fontStyle;
        private _fontWeight;
        /** @internal */
        _host: AdvancedDynamicTexture;
        /** @internal */
        _fontSize: ValueAndUnit;
        /**
         * BABYLON.Observable raised when the style values are changed
         */
        onChangedObservable: BABYLON.Observable<Style>;
        /**
         * Creates a new style object
         * @param host defines the AdvancedDynamicTexture which hosts this style
         */
        constructor(host: AdvancedDynamicTexture);
        /**
         * Gets or sets the font size
         */
        get fontSize(): string | number;
        set fontSize(value: string | number);
        /**
         * Gets or sets the font family
         */
        get fontFamily(): string;
        set fontFamily(value: string);
        /**
         * Gets or sets the font style
         */
        get fontStyle(): string;
        set fontStyle(value: string);
        /** Gets or sets font weight */
        get fontWeight(): string;
        set fontWeight(value: string);
        /** Dispose all associated resources */
        dispose(): void;
    }


    /**
     * Class used to store a point for a MultiLine object.
     * The point can be pure 2D coordinates, a mesh or a control
     */
    export class MultiLinePoint {
        private _multiLine;
        private _x;
        private _y;
        private _control;
        private _mesh;
        private _controlObserver;
        private _meshObserver;
        /** @internal */
        _point: BABYLON.Vector3;
        /**
         * Creates a new MultiLinePoint
         * @param multiLine defines the source MultiLine object
         */
        constructor(multiLine: MultiLine);
        /** Gets or sets x coordinate */
        get x(): string | number;
        set x(value: string | number);
        /** Gets or sets y coordinate */
        get y(): string | number;
        set y(value: string | number);
        /** Gets or sets the control associated with this point */
        get control(): BABYLON.Nullable<Control>;
        set control(value: BABYLON.Nullable<Control>);
        /** Gets or sets the mesh associated with this point */
        get mesh(): BABYLON.Nullable<BABYLON.AbstractMesh>;
        set mesh(value: BABYLON.Nullable<BABYLON.AbstractMesh>);
        /** Resets links */
        resetLinks(): void;
        /**
         * Gets a translation vector with Z component
         * @returns the translation vector
         */
        translate(): BABYLON.Vector3;
        private _translatePoint;
        /** Release associated resources */
        dispose(): void;
    }


    /**
     * Class used to store 2D control sizes
     */
    export class Measure {
        /** defines left coordinate */
        left: number;
        /** defines top coordinate  */
        top: number;
        /** defines width dimension  */
        width: number;
        /** defines height dimension */
        height: number;
        /**
         * Creates a new measure
         * @param left defines left coordinate
         * @param top defines top coordinate
         * @param width defines width dimension
         * @param height defines height dimension
         */
        constructor(
        /** defines left coordinate */
        left: number, 
        /** defines top coordinate  */
        top: number, 
        /** defines width dimension  */
        width: number, 
        /** defines height dimension */
        height: number);
        /**
         * Copy from another measure
         * @param other defines the other measure to copy from
         */
        copyFrom(other: Measure): void;
        /**
         * Copy from a group of 4 floats
         * @param left defines left coordinate
         * @param top defines top coordinate
         * @param width defines width dimension
         * @param height defines height dimension
         */
        copyFromFloats(left: number, top: number, width: number, height: number): void;
        /**
         * Computes the axis aligned bounding box measure for two given measures
         * @param a Input measure
         * @param b Input measure
         * @param result the resulting bounding measure
         */
        static CombineToRef(a: Measure, b: Measure, result: Measure): void;
        /**
         * Computes the axis aligned bounding box of the measure after it is modified by a given transform
         * @param transform the matrix to transform the measure before computing the AABB
         * @param addX number to add to left
         * @param addY number to add to top
         * @param addWidth number to add to width
         * @param addHeight number to add to height
         * @param result the resulting AABB
         */
        addAndTransformToRef(transform: Matrix2D, addX: number, addY: number, addWidth: number, addHeight: number, result: Measure): void;
        /**
         * Computes the axis aligned bounding box of the measure after it is modified by a given transform
         * @param transform the matrix to transform the measure before computing the AABB
         * @param result the resulting AABB
         */
        transformToRef(transform: Matrix2D, result: Measure): void;
        /**
         * Check equality between this measure and another one
         * @param other defines the other measures
         * @returns true if both measures are equals
         */
        isEqualsTo(other: Measure): boolean;
        /**
         * Creates an empty measure
         * @returns a new measure
         */
        static Empty(): Measure;
    }


    /**
     * Class used to transport BABYLON.Vector2 information for pointer events
     */
    export class Vector2WithInfo extends BABYLON.Vector2 {
        /** defines the current mouse button index */
        buttonIndex: number;
        /**
         * Creates a new Vector2WithInfo
         * @param source defines the vector2 data to transport
         * @param buttonIndex defines the current mouse button index
         */
        constructor(source: BABYLON.Vector2, 
        /** defines the current mouse button index */
        buttonIndex?: number);
    }
    /** Class used to provide 2D matrix features */
    export class Matrix2D {
        /** Gets the internal array of 6 floats used to store matrix data */
        m: Float32Array;
        /**
         * Creates a new matrix
         * @param m00 defines value for (0, 0)
         * @param m01 defines value for (0, 1)
         * @param m10 defines value for (1, 0)
         * @param m11 defines value for (1, 1)
         * @param m20 defines value for (2, 0)
         * @param m21 defines value for (2, 1)
         */
        constructor(m00: number, m01: number, m10: number, m11: number, m20: number, m21: number);
        /**
         * Fills the matrix from direct values
         * @param m00 defines value for (0, 0)
         * @param m01 defines value for (0, 1)
         * @param m10 defines value for (1, 0)
         * @param m11 defines value for (1, 1)
         * @param m20 defines value for (2, 0)
         * @param m21 defines value for (2, 1)
         * @returns the current modified matrix
         */
        fromValues(m00: number, m01: number, m10: number, m11: number, m20: number, m21: number): Matrix2D;
        /**
         * Gets matrix determinant
         * @returns the determinant
         */
        determinant(): number;
        /**
         * Inverses the matrix and stores it in a target matrix
         * @param result defines the target matrix
         * @returns the current matrix
         */
        invertToRef(result: Matrix2D): Matrix2D;
        /**
         * Multiplies the current matrix with another one
         * @param other defines the second operand
         * @param result defines the target matrix
         * @returns the current matrix
         */
        multiplyToRef(other: Matrix2D, result: Matrix2D): Matrix2D;
        /**
         * Applies the current matrix to a set of 2 floats and stores the result in a vector2
         * @param x defines the x coordinate to transform
         * @param y defines the x coordinate to transform
         * @param result defines the target vector2
         * @returns the current matrix
         */
        transformCoordinates(x: number, y: number, result: BABYLON.Vector2): Matrix2D;
        /**
         * Creates an identity matrix
         * @returns a new matrix
         */
        static Identity(): Matrix2D;
        /**
         * Creates an identity matrix and stores it in a target matrix
         * @param result defines the target matrix
         */
        static IdentityToRef(result: Matrix2D): void;
        /**
         * Creates a translation matrix and stores it in a target matrix
         * @param x defines the x coordinate of the translation
         * @param y defines the y coordinate of the translation
         * @param result defines the target matrix
         */
        static TranslationToRef(x: number, y: number, result: Matrix2D): void;
        /**
         * Creates a scaling matrix and stores it in a target matrix
         * @param x defines the x coordinate of the scaling
         * @param y defines the y coordinate of the scaling
         * @param result defines the target matrix
         */
        static ScalingToRef(x: number, y: number, result: Matrix2D): void;
        /**
         * Creates a rotation matrix and stores it in a target matrix
         * @param angle defines the rotation angle
         * @param result defines the target matrix
         */
        static RotationToRef(angle: number, result: Matrix2D): void;
        private static _TempPreTranslationMatrix;
        private static _TempPostTranslationMatrix;
        private static _TempRotationMatrix;
        private static _TempScalingMatrix;
        private static _TempCompose0;
        private static _TempCompose1;
        private static _TempCompose2;
        /**
         * Composes a matrix from translation, rotation, scaling and parent matrix and stores it in a target matrix
         * @param tx defines the x coordinate of the translation
         * @param ty defines the y coordinate of the translation
         * @param angle defines the rotation angle
         * @param scaleX defines the x coordinate of the scaling
         * @param scaleY defines the y coordinate of the scaling
         * @param parentMatrix defines the parent matrix to multiply by (can be null)
         * @param result defines the target matrix
         */
        static ComposeToRef(tx: number, ty: number, angle: number, scaleX: number, scaleY: number, parentMatrix: BABYLON.Nullable<Matrix2D>, result: Matrix2D): void;
    }
    /**
     * Useful math functions
     */
    export class MathTools {
        /**
         * Default rounding precision for GUI elements. It should be
         * set to a power of ten, where the exponent means the number
         * of decimal digits to round to, i.e, 100 means 2 decimal digits,
         * 1000 means 3 decimal digits, etc. Default is 100 (2 decimal digits).
         */
        static DefaultRoundingPrecision: number;
        /**
         * Rounds a number to the nearest multiple of a given precision
         * @param value the value to be rounded
         * @param precision the multiple to which the value will be rounded. Default is 100 (2 decimal digits)
         * @returns
         */
        static Round(value: number, precision?: number): number;
    }




    /**
     * Class used to create texture to support 2D GUI elements
     * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui
     */
    export class AdvancedDynamicTexture extends BABYLON.DynamicTexture {
        /** Define the url to load snippets */
        static SnippetUrl: string;
        /** Indicates if some optimizations can be performed in GUI GPU management (the downside is additional memory/GPU texture memory used) */
        static AllowGPUOptimizations: boolean;
        /** Snippet ID if the content was created from the snippet server */
        snippetId: string;
        /** BABYLON.Observable that fires when the GUI is ready */
        onGuiReadyObservable: BABYLON.Observable<AdvancedDynamicTexture>;
        private _isDirty;
        private _renderObserver;
        private _resizeObserver;
        private _preKeyboardObserver;
        private _prePointerObserver;
        private _sceneRenderObserver;
        private _pointerObserver;
        private _canvasPointerOutObserver;
        private _canvasBlurObserver;
        private _controlAddedObserver;
        private _controlRemovedObserver;
        private _background;
        /** @internal */
        _rootContainer: Container;
        /** @internal */
        _lastPickedControl: Control;
        /** @internal */
        _lastControlOver: {
            [pointerId: number]: Control;
        };
        /** @internal */
        _lastControlDown: {
            [pointerId: number]: Control;
        };
        /** @internal */
        _capturingControl: {
            [pointerId: number]: Control;
        };
        /** @internal */
        _shouldBlockPointer: boolean;
        /** @internal */
        _layerToDispose: BABYLON.Nullable<BABYLON.Layer>;
        /** @internal */
        _linkedControls: Control[];
        /** @internal */
        _isFullscreen: boolean;
        private _fullscreenViewport;
        private _idealWidth;
        private _idealHeight;
        private _useSmallestIdeal;
        private _renderAtIdealSize;
        private _focusedControl;
        private _blockNextFocusCheck;
        private _renderScale;
        private _rootElement;
        private _cursorChanged;
        private _defaultMousePointerId;
        private _rootChildrenHaveChanged;
        /** @internal */
        _capturedPointerIds: Set<number>;
        /** @internal */
        _numLayoutCalls: number;
        /** Gets the number of layout calls made the last time the ADT has been rendered */
        get numLayoutCalls(): number;
        /** @internal */
        _numRenderCalls: number;
        /** Gets the number of render calls made the last time the ADT has been rendered */
        get numRenderCalls(): number;
        /**
         * Define type to string to ensure compatibility across browsers
         * Safari doesn't support DataTransfer constructor
         */
        private _clipboardData;
        /**
         * BABYLON.Observable event triggered each time an clipboard event is received from the rendering canvas
         */
        onClipboardObservable: BABYLON.Observable<BABYLON.ClipboardInfo>;
        /**
         * BABYLON.Observable event triggered each time a pointer down is intercepted by a control
         */
        onControlPickedObservable: BABYLON.Observable<Control>;
        /**
         * BABYLON.Observable event triggered before layout is evaluated
         */
        onBeginLayoutObservable: BABYLON.Observable<AdvancedDynamicTexture>;
        /**
         * BABYLON.Observable event triggered after the layout was evaluated
         */
        onEndLayoutObservable: BABYLON.Observable<AdvancedDynamicTexture>;
        /**
         * BABYLON.Observable event triggered before the texture is rendered
         */
        onBeginRenderObservable: BABYLON.Observable<AdvancedDynamicTexture>;
        /**
         * BABYLON.Observable event triggered after the texture was rendered
         */
        onEndRenderObservable: BABYLON.Observable<AdvancedDynamicTexture>;
        /**
         * Gets or sets a boolean defining if alpha is stored as premultiplied
         */
        premulAlpha: boolean;
        /**
         * Gets or sets a boolean indicating that the canvas must be reverted on Y when updating the texture
         */
        applyYInversionOnUpdate: boolean;
        /**
         * A boolean indicating whether or not the elements can be navigated to using the tab key.
         * Defaults to false.
         */
        disableTabNavigation: boolean;
        /**
         * Gets or sets a number used to scale rendering size (2 means that the texture will be twice bigger).
         * Useful when you want more antialiasing
         */
        get renderScale(): number;
        set renderScale(value: number);
        /** Gets or sets the background color */
        get background(): string;
        set background(value: string);
        /**
         * Gets or sets the ideal width used to design controls.
         * The GUI will then rescale everything accordingly
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#adaptive-scaling
         */
        get idealWidth(): number;
        set idealWidth(value: number);
        /**
         * Gets or sets the ideal height used to design controls.
         * The GUI will then rescale everything accordingly
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#adaptive-scaling
         */
        get idealHeight(): number;
        set idealHeight(value: number);
        /**
         * Gets or sets a boolean indicating if the smallest ideal value must be used if idealWidth and idealHeight are both set
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#adaptive-scaling
         */
        get useSmallestIdeal(): boolean;
        set useSmallestIdeal(value: boolean);
        /**
         * Gets or sets a boolean indicating if adaptive scaling must be used
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#adaptive-scaling
         */
        get renderAtIdealSize(): boolean;
        set renderAtIdealSize(value: boolean);
        /**
         * Gets the ratio used when in "ideal mode"
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#adaptive-scaling
         * */
        get idealRatio(): number;
        /**
         * Gets the underlying layer used to render the texture when in fullscreen mode
         */
        get layer(): BABYLON.Nullable<BABYLON.Layer>;
        /**
         * Gets the root container control
         */
        get rootContainer(): Container;
        /**
         * Returns an array containing the root container.
         * This is mostly used to let the Inspector introspects the ADT
         * @returns an array containing the rootContainer
         */
        getChildren(): Array<Container>;
        /**
         * Will return all controls that are inside this texture
         * @param directDescendantsOnly defines if true only direct descendants of 'this' will be considered, if false direct and also indirect (children of children, an so on in a recursive manner) descendants of 'this' will be considered
         * @param predicate defines an optional predicate that will be called on every evaluated child, the predicate must return true for a given child to be part of the result, otherwise it will be ignored
         * @returns all child controls
         */
        getDescendants(directDescendantsOnly?: boolean, predicate?: (control: Control) => boolean): Control[];
        /**
         * Will return all controls with the given type name
         * @param typeName defines the type name to search for
         * @returns an array of all controls found
         */
        getControlsByType(typeName: string): Control[];
        /**
         * Will return the first control with the given name
         * @param name defines the name to search for
         * @returns the first control found or null
         */
        getControlByName(name: string): BABYLON.Nullable<Control>;
        private _getControlByKey;
        /**
         * Gets or sets the current focused control
         */
        get focusedControl(): BABYLON.Nullable<Control>;
        set focusedControl(control: BABYLON.Nullable<Control>);
        /**
         * Gets or sets a boolean indicating if the texture must be rendered in background or foreground when in fullscreen mode
         */
        get isForeground(): boolean;
        set isForeground(value: boolean);
        /**
         * Gets or set information about clipboardData
         */
        get clipboardData(): string;
        set clipboardData(value: string);
        /**
         * If this is set, even when a control is pointer blocker, some events can still be passed through to the scene.
         * Options from values are PointerEventTypes
         * POINTERDOWN, POINTERUP, POINTERMOVE, POINTERWHEEL, POINTERPICK, POINTERTAP, POINTERDOUBLETAP
         */
        skipBlockEvents: number;
        /**
         * If set to true, every scene render will trigger a pointer event for the GUI
         * if it is linked to a mesh or has controls linked to a mesh. This will allow
         * you to catch the pointer moving around the GUI due to camera or mesh movements,
         * but it has a performance cost.
         */
        checkPointerEveryFrame: boolean;
        /**
         * Creates a new AdvancedDynamicTexture
         * @param name defines the name of the texture
         * @param width defines the width of the texture
         * @param height defines the height of the texture
         * @param scene defines the hosting scene
         * @param generateMipMaps defines a boolean indicating if mipmaps must be generated (false by default)
         * @param samplingMode defines the texture sampling mode (Texture.NEAREST_SAMPLINGMODE by default)
         * @param invertY defines if the texture needs to be inverted on the y axis during loading (true by default)
         */
        constructor(name: string, width?: number, height?: number, scene?: BABYLON.Nullable<BABYLON.Scene>, generateMipMaps?: boolean, samplingMode?: number, invertY?: boolean);
        /**
         * Get the current class name of the texture useful for serialization or dynamic coding.
         * @returns "AdvancedDynamicTexture"
         */
        getClassName(): string;
        /**
         * Function used to execute a function on all controls
         * @param func defines the function to execute
         * @param container defines the container where controls belong. If null the root container will be used
         */
        executeOnAllControls(func: (control: Control) => void, container?: Container): void;
        private _useInvalidateRectOptimization;
        /**
         * Gets or sets a boolean indicating if the InvalidateRect optimization should be turned on
         */
        get useInvalidateRectOptimization(): boolean;
        set useInvalidateRectOptimization(value: boolean);
        private _invalidatedRectangle;
        /**
         * Invalidates a rectangle area on the gui texture
         * @param invalidMinX left most position of the rectangle to invalidate in the texture
         * @param invalidMinY top most position of the rectangle to invalidate in the texture
         * @param invalidMaxX right most position of the rectangle to invalidate in the texture
         * @param invalidMaxY bottom most position of the rectangle to invalidate in the texture
         */
        invalidateRect(invalidMinX: number, invalidMinY: number, invalidMaxX: number, invalidMaxY: number): void;
        /**
         * Marks the texture as dirty forcing a complete update
         */
        markAsDirty(): void;
        /**
         * Helper function used to create a new style
         * @returns a new style
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#styles
         */
        createStyle(): Style;
        /**
         * Adds a new control to the root container
         * @param control defines the control to add
         * @returns the current texture
         */
        addControl(control: Control): AdvancedDynamicTexture;
        /**
         * Removes a control from the root container
         * @param control defines the control to remove
         * @returns the current texture
         */
        removeControl(control: Control): AdvancedDynamicTexture;
        /**
         * Moves overlapped controls towards a position where it is not overlapping anymore.
         * Please note that this method alters linkOffsetXInPixels and linkOffsetYInPixels.
         * @param overlapGroup the overlap group which will be processed or undefined to process all overlap groups
         * @param deltaStep the step size (speed) to reach the target non overlapping position (default 0.1)
         * @param repelFactor how much is the control repelled by other controls
         */
        moveToNonOverlappedPosition(overlapGroup?: number | Control[], deltaStep?: number, repelFactor?: number): void;
        /**
         * Release all resources
         */
        dispose(): void;
        private _onResize;
        /** @internal */
        _getGlobalViewport(): BABYLON.Viewport;
        /**
         * Get screen coordinates for a vector3
         * @param position defines the position to project
         * @param worldMatrix defines the world matrix to use
         * @returns the projected position
         */
        getProjectedPosition(position: BABYLON.Vector3, worldMatrix: BABYLON.Matrix): BABYLON.Vector2;
        /**
         * Get screen coordinates for a vector3
         * @param position defines the position to project
         * @param worldMatrix defines the world matrix to use
         * @returns the projected position with Z
         */
        getProjectedPositionWithZ(position: BABYLON.Vector3, worldMatrix: BABYLON.Matrix): BABYLON.Vector3;
        private _checkUpdate;
        private _clearMeasure;
        private _render;
        /**
         * @internal
         */
        _changeCursor(cursor: string): void;
        /**
         * @internal
         */
        _registerLastControlDown(control: Control, pointerId: number): void;
        private _doPicking;
        /**
         * @internal
         */
        _cleanControlAfterRemovalFromList(list: {
            [pointerId: number]: Control;
        }, control: Control): void;
        /**
         * @internal
         */
        _cleanControlAfterRemoval(control: Control): void;
        /**
         * This function will run a pointer event on this ADT and will trigger any pointer events on any controls
         * This will work on a fullscreen ADT only. For mesh based ADT, simulate pointer events using the scene directly.
         * @param x pointer X on the canvas for the picking
         * @param y pointer Y on the canvas for the picking
         * @param pi optional pointer information
         */
        pick(x: number, y: number, pi?: BABYLON.Nullable<BABYLON.PointerInfoPre>): void;
        private _translateToPicking;
        /** Attach to all scene events required to support pointer events */
        attach(): void;
        private _focusProperties;
        private _focusNextElement;
        /**
         * @internal
         */
        private _onClipboardCopy;
        /**
         * @internal
         */
        private _onClipboardCut;
        /**
         * @internal
         */
        private _onClipboardPaste;
        /**
         * Register the clipboard Events onto the canvas
         */
        registerClipboardEvents(): void;
        /**
         * Unregister the clipboard Events from the canvas
         */
        unRegisterClipboardEvents(): void;
        /**
         * Transform uvs from mesh space to texture space, taking the texture into account
         * @param uv the uvs in mesh space
         * @returns the uvs in texture space
         */
        private _transformUvs;
        /**
         * Connect the texture to a hosting mesh to enable interactions
         * @param mesh defines the mesh to attach to
         * @param supportPointerMove defines a boolean indicating if pointer move events must be catched as well
         */
        attachToMesh(mesh: BABYLON.AbstractMesh, supportPointerMove?: boolean): void;
        /**
         * Move the focus to a specific control
         * @param control defines the control which will receive the focus
         */
        moveFocusToControl(control: Control): void;
        private _manageFocus;
        private _attachPickingToSceneRender;
        private _attachToOnPointerOut;
        private _attachToOnBlur;
        /**
         * Serializes the entire GUI system
         * @returns an object with the JSON serialized data
         */
        serializeContent(): any;
        /**
         * Recreate the content of the ADT from a JSON object
         * @param serializedObject define the JSON serialized object to restore from
         * @param scaleToSize defines whether to scale to texture to the saved size
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         */
        parseSerializedObject(serializedObject: any, scaleToSize?: boolean, urlRewriter?: (url: string) => string): void;
        /**
         * Clones the ADT. If no mesh is defined, the GUI will be considered as a fullscreen GUI
         * @param newName defines the name of the new ADT
         * @param attachToMesh defines if the new ADT should be attached to a mesh
         * @returns the clone of the ADT
         */
        clone(newName?: string, attachToMesh?: BABYLON.AbstractMesh): AdvancedDynamicTexture;
        /**
         * Recreate the content of the ADT from a JSON object
         * @param serializedObject define the JSON serialized object to restore from
         * @param scaleToSize defines whether to scale to texture to the saved size
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @deprecated Please use parseSerializedObject instead
         */
        parseContent: (serializedObject: any, scaleToSize?: boolean, urlRewriter?: ((url: string) => string) | undefined) => void;
        /**
         * Recreate the content of the ADT from a snippet saved by the GUI editor
         * @param snippetId defines the snippet to load
         * @param scaleToSize defines whether to scale to texture to the saved size
         * @param appendToAdt if provided the snippet will be appended to the adt. Otherwise a fullscreen ADT will be created.
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @returns a promise that will resolve on success
         */
        static ParseFromSnippetAsync(snippetId: string, scaleToSize?: boolean, appendToAdt?: AdvancedDynamicTexture, urlRewriter?: (url: string) => string): Promise<AdvancedDynamicTexture>;
        /**
         * Recreate the content of the ADT from a snippet saved by the GUI editor
         * @param snippetId defines the snippet to load
         * @param scaleToSize defines whether to scale to texture to the saved size
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @returns a promise that will resolve on success
         */
        parseFromSnippetAsync(snippetId: string, scaleToSize?: boolean, urlRewriter?: (url: string) => string): Promise<AdvancedDynamicTexture>;
        /**
         * Recreate the content of the ADT from a url json
         * @param url defines the url to load
         * @param scaleToSize defines whether to scale to texture to the saved size
         * @param appendToAdt if provided the snippet will be appended to the adt. Otherwise a fullscreen ADT will be created.
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @returns a promise that will resolve on success
         */
        static ParseFromFileAsync(url: string, scaleToSize?: boolean, appendToAdt?: AdvancedDynamicTexture, urlRewriter?: (url: string) => string): Promise<AdvancedDynamicTexture>;
        /**
         * Recreate the content of the ADT from a url json
         * @param url defines the url to load
         * @param scaleToSize defines whether to scale to texture to the saved size
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @returns a promise that will resolve on success
         */
        parseFromURLAsync(url: string, scaleToSize?: boolean, urlRewriter?: (url: string) => string): Promise<AdvancedDynamicTexture>;
        private static _LoadURLContentAsync;
        /**
         * Compares two rectangle based controls for pixel overlap
         * @param control1 The first control to compare
         * @param control2 The second control to compare
         * @returns true if overlaps, otherwise false
         */
        private static _Overlaps;
        /**
         * Creates a new AdvancedDynamicTexture in projected mode (ie. attached to a mesh)
         * @param mesh defines the mesh which will receive the texture
         * @param width defines the texture width (1024 by default)
         * @param height defines the texture height (1024 by default)
         * @param supportPointerMove defines a boolean indicating if the texture must capture move events (true by default)
         * @param onlyAlphaTesting defines a boolean indicating that alpha blending will not be used (only alpha testing) (false by default)
         * @param invertY defines if the texture needs to be inverted on the y axis during loading (true by default)
         * @param materialSetupCallback defines a custom way of creating and setting up the material on the mesh
         * @param sampling defines the texture sampling mode (Texture.TRILINEAR_SAMPLINGMODE by default)
         * @returns a new AdvancedDynamicTexture
         */
        static CreateForMesh(mesh: BABYLON.AbstractMesh, width?: number, height?: number, supportPointerMove?: boolean, onlyAlphaTesting?: boolean, invertY?: boolean, materialSetupCallback?: (mesh: BABYLON.AbstractMesh, uniqueId: string, texture: AdvancedDynamicTexture, onlyAlphaTesting: boolean) => void, sampling?: number): AdvancedDynamicTexture;
        private static _CreateMaterial;
        /**
         * Creates a new AdvancedDynamicTexture in projected mode (ie. attached to a mesh) BUT do not create a new material for the mesh. You will be responsible for connecting the texture
         * @param mesh defines the mesh which will receive the texture
         * @param width defines the texture width (1024 by default)
         * @param height defines the texture height (1024 by default)
         * @param supportPointerMove defines a boolean indicating if the texture must capture move events (true by default)
         * @param invertY defines if the texture needs to be inverted on the y axis during loading (true by default)
         * @param sampling defines the texture sampling mode (Texture.TRILINEAR_SAMPLINGMODE by default)
         * @returns a new AdvancedDynamicTexture
         */
        static CreateForMeshTexture(mesh: BABYLON.AbstractMesh, width?: number, height?: number, supportPointerMove?: boolean, invertY?: boolean, sampling?: number): AdvancedDynamicTexture;
        /**
         * Creates a new AdvancedDynamicTexture in fullscreen mode.
         * In this mode the texture will rely on a layer for its rendering.
         * This allows it to be treated like any other layer.
         * As such, if you have a multi camera setup, you can set the layerMask on the GUI as well.
         * LayerMask is set through advancedTexture.layer.layerMask
         * @param name defines name for the texture
         * @param foreground defines a boolean indicating if the texture must be rendered in foreground (default is true)
         * @param scene defines the hosting scene
         * @param sampling defines the texture sampling mode (Texture.BILINEAR_SAMPLINGMODE by default)
         * @param adaptiveScaling defines whether to automatically scale root to match hardwarescaling (false by default)
         * @returns a new AdvancedDynamicTexture
         */
        static CreateFullscreenUI(name: string, foreground?: boolean, scene?: BABYLON.Nullable<BABYLON.Scene>, sampling?: number, adaptiveScaling?: boolean): AdvancedDynamicTexture;
        /**
         * Scales the texture
         * @param ratio the scale factor to apply to both width and height
         */
        scale(ratio: number): void;
        /**
         * Resizes the texture
         * @param width the new width
         * @param height the new height
         */
        scaleTo(width: number, height: number): void;
        private _checkGuiIsReady;
        /**
         * @returns true if all the GUI components are ready to render
         */
        guiIsReady(): boolean;
    }


    /**
     * This class can be used to get instrumentation data from a AdvancedDynamicTexture object
     */
    export class AdvancedDynamicTextureInstrumentation implements BABYLON.IDisposable {
        /**
         * Define the instrumented AdvancedDynamicTexture.
         */
        texture: AdvancedDynamicTexture;
        private _captureRenderTime;
        private _renderTime;
        private _captureLayoutTime;
        private _layoutTime;
        private _onBeginRenderObserver;
        private _onEndRenderObserver;
        private _onBeginLayoutObserver;
        private _onEndLayoutObserver;
        /**
         * Gets the perf counter used to capture render time
         */
        get renderTimeCounter(): BABYLON.PerfCounter;
        /**
         * Gets the perf counter used to capture layout time
         */
        get layoutTimeCounter(): BABYLON.PerfCounter;
        /**
         * Enable or disable the render time capture
         */
        get captureRenderTime(): boolean;
        set captureRenderTime(value: boolean);
        /**
         * Enable or disable the layout time capture
         */
        get captureLayoutTime(): boolean;
        set captureLayoutTime(value: boolean);
        /**
         * Instantiates a new advanced dynamic texture instrumentation.
         * This class can be used to get instrumentation data from an AdvancedDynamicTexture object
         * @param texture Defines the AdvancedDynamicTexture to instrument
         */
        constructor(
        /**
         * Define the instrumented AdvancedDynamicTexture.
         */
        texture: AdvancedDynamicTexture);
        /**
         * Dispose and release associated resources.
         */
        dispose(): void;
    }


    /**
     * Class used to store key control properties
     */
    export class KeyPropertySet {
        /** Width */
        width?: string;
        /** Height */
        height?: string;
        /** Left padding */
        paddingLeft?: string;
        /** Right padding */
        paddingRight?: string;
        /** Top padding */
        paddingTop?: string;
        /** Bottom padding */
        paddingBottom?: string;
        /** Foreground color */
        color?: string;
        /** Background color */
        background?: string;
    }
    /**
     * Class used to create virtual keyboard
     */
    export class VirtualKeyboard extends StackPanel {
        /** BABYLON.Observable raised when a key is pressed */
        onKeyPressObservable: BABYLON.Observable<string>;
        /** Gets or sets default key button width */
        defaultButtonWidth: string;
        /** Gets or sets default key button height */
        defaultButtonHeight: string;
        /** Gets or sets default key button left padding */
        defaultButtonPaddingLeft: string;
        /** Gets or sets default key button right padding */
        defaultButtonPaddingRight: string;
        /** Gets or sets default key button top padding */
        defaultButtonPaddingTop: string;
        /** Gets or sets default key button bottom padding */
        defaultButtonPaddingBottom: string;
        /** Gets or sets default key button foreground color */
        defaultButtonColor: string;
        /** Gets or sets default key button background color */
        defaultButtonBackground: string;
        /** Gets or sets shift button foreground color */
        shiftButtonColor: string;
        /** Gets or sets shift button thickness*/
        selectedShiftThickness: number;
        /** Gets shift key state */
        shiftState: number;
        protected _getTypeName(): string;
        private _createKey;
        /**
         * Adds a new row of keys
         * @param keys defines the list of keys to add
         * @param propertySets defines the associated property sets
         */
        addKeysRow(keys: Array<string>, propertySets?: Array<KeyPropertySet>): void;
        /**
         * Set the shift key to a specific state
         * @param shiftState defines the new shift state
         */
        applyShiftState(shiftState: number): void;
        private _currentlyConnectedInputText;
        private _connectedInputTexts;
        private _onKeyPressObserver;
        /** Gets the input text control currently attached to the keyboard */
        get connectedInputText(): BABYLON.Nullable<InputText | InputTextArea>;
        /**
         * Connects the keyboard with an input text control
         *
         * @param input defines the target control
         */
        connect(input: InputText): void;
        /**
         * Disconnects the keyboard from connected InputText controls
         *
         * @param input optionally defines a target control, otherwise all are disconnected
         */
        disconnect(input?: InputText): void;
        private _removeConnectedInputObservables;
        /**
         * Release all resources
         */
        dispose(): void;
        /**
         * Creates a new keyboard using a default layout
         *
         * @param name defines control name
         * @returns a new VirtualKeyboard
         */
        static CreateDefaultLayout(name?: string): VirtualKeyboard;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture): void;
    }


    /**
     * Class used to create toggle buttons
     * @since 5.0.0
     */
    export class ToggleButton extends Rectangle {
        name?: string | undefined;
        /**
         * Function called to generate the toActive animation
         */
        toActiveAnimation: () => void;
        /**
         * Function called to generate the toInactive animation
         */
        toInactiveAnimation: () => void;
        /**
         * Function called to generate a pointer enter animation when the toggle button is active.
         */
        pointerEnterActiveAnimation: () => void;
        /**
         * Function called to generate a pointer out animation when the toggle button is active.
         */
        pointerOutActiveAnimation: () => void;
        /**
         * Function called to generate a pointer down animation when the toggle button is active.
         */
        pointerDownActiveAnimation: () => void;
        /**
         * Function called to generate a pointer up animation when the toggle button is active.
         */
        pointerUpActiveAnimation: () => void;
        /**
         * Function called to generate a pointer enter animation when the toggle button is inactive.
         */
        pointerEnterInactiveAnimation: () => void;
        /**
         * Function called to generate a pointer out animation when the toggle button is inactive.
         */
        pointerOutInactiveAnimation: () => void;
        /**
         * Function called to generate a pointer down animation when the toggle button is inactive.
         */
        pointerDownInactiveAnimation: () => void;
        /**
         * Function called to generate a pointer up animation when the toggle button is inactive.
         */
        pointerUpInactiveAnimation: () => void;
        /** BABYLON.Observable raised when isActive is changed */
        onIsActiveChangedObservable: BABYLON.Observable<boolean>;
        /**
         * Gets or sets a boolean indicating that the toggle button will let internal controls handle picking instead of doing it directly using its bounding info
         */
        delegatePickingToChildren: boolean;
        private _group;
        /** Gets or sets group name this toggle button belongs to */
        get group(): string;
        set group(value: string);
        private _isActive;
        /** Gets or sets a boolean indicating if the toggle button is active or not */
        get isActive(): boolean;
        set isActive(value: boolean);
        /**
         * Creates a new ToggleButton
         * @param name defines the control name
         * @param group defines the toggle group this toggle belongs to
         */
        constructor(name?: string | undefined, group?: string);
        protected _getTypeName(): string;
        /**
         * @internal
         */
        _processPicking(x: number, y: number, pi: BABYLON.PointerInfoBase, type: number, pointerId: number, buttonIndex: number, deltaX?: number, deltaY?: number): boolean;
        /**
         * @internal
         */
        _onPointerEnter(target: Control, pi: BABYLON.PointerInfoBase): boolean;
        /**
         * @internal
         */
        _onPointerOut(target: Control, pi: BABYLON.PointerInfoBase, force?: boolean): void;
        /**
         * @internal
         */
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        /**
         * @internal
         */
        _onPointerUp(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, notifyClick: boolean, pi: BABYLON.PointerInfoBase): void;
    }


    /** @internal */
    export class TextWrapper {
        private _text;
        private _characters;
        get text(): string;
        set text(txt: string);
        get length(): number;
        removePart(idxStart: number, idxEnd: number, insertTxt?: string): void;
        charAt(idx: number): string;
        substr(from: number, length?: number): string;
        substring(from: number, to?: number): string;
        isWord(index: number): boolean;
    }


    /**
     * Enum that determines the text-wrapping mode to use.
     */
    export enum TextWrapping {
        /**
         * Clip the text when it's larger than Control.width; this is the default mode.
         */
        Clip = 0,
        /**
         * Wrap the text word-wise, i.e. try to add line-breaks at word boundary to fit within Control.width.
         */
        WordWrap = 1,
        /**
         * Ellipsize the text, i.e. shrink with trailing … when text is larger than Control.width.
         */
        Ellipsis = 2,
        /**
         * Wrap the text word-wise and clip the text when the text's height is larger than the Control.height, and shrink the last line with trailing … .
         */
        WordWrapEllipsis = 3,
        /**
         * Use HTML to wrap the text. This is the only mode that supports east-asian languages.
         */
        HTML = 4
    }
    /**
     * Class used to create text block control
     */
    export class TextBlock extends Control {
        /**
         * Defines the name of the control
         */
        name?: string | undefined;
        private _text;
        private _textWrapping;
        private _textHorizontalAlignment;
        private _textVerticalAlignment;
        private _lines;
        private _resizeToFit;
        private _lineSpacing;
        private _outlineWidth;
        private _outlineColor;
        private _underline;
        private _lineThrough;
        private _wordDivider;
        private _forceResizeWidth;
        private _applyOutlineToUnderline;
        /**
         * An event triggered after the text is changed
         */
        onTextChangedObservable: BABYLON.Observable<TextBlock>;
        /**
         * An event triggered after the text was broken up into lines
         */
        onLinesReadyObservable: BABYLON.Observable<TextBlock>;
        /**
         * Function used to split a string into words. By default, a string is split at each space character found
         */
        wordSplittingFunction: BABYLON.Nullable<(line: string) => string[]>;
        /**
         * This function will be called when a new HTML element is generated to be used for word wrapping.
         * This is only used when wrapping mode HTML is selected.
         * Using this function you can adjust word-break, overflow-wrap, hyphens, or any other CSS properties of the HTML element, language-dependent.
         */
        adjustWordWrappingHTMLElement: BABYLON.Nullable<(element: HTMLElement) => void>;
        /**
         * Gets or sets a boolean indicating if the HTML element generated for word wrapping should be reused or removed after each wrapping.
         */
        reuseHTMLForWordWrapping: boolean;
        /**
         * Return the line list (you may need to use the onLinesReadyObservable to make sure the list is ready)
         */
        get lines(): any[];
        /**
         * Gets or sets a boolean indicating that the TextBlock will be resized to fit its content
         */
        get resizeToFit(): boolean;
        /**
         * Gets or sets a boolean indicating that the TextBlock will be resized to fit its content
         */
        set resizeToFit(value: boolean);
        /**
         * Gets or sets a boolean indicating if text must be wrapped
         */
        get textWrapping(): TextWrapping | boolean;
        /**
         * Gets or sets a boolean indicating if text must be wrapped
         */
        set textWrapping(value: TextWrapping | boolean);
        /**
         * Gets or sets text to display
         */
        get text(): string;
        /**
         * Gets or sets text to display
         */
        set text(value: string);
        /**
         * Gets or sets text horizontal alignment (BABYLON.GUI.Control.HORIZONTAL_ALIGNMENT_CENTER by default)
         */
        get textHorizontalAlignment(): number;
        /**
         * Gets or sets text horizontal alignment (BABYLON.GUI.Control.HORIZONTAL_ALIGNMENT_CENTER by default)
         */
        set textHorizontalAlignment(value: number);
        /**
         * Gets or sets text vertical alignment (BABYLON.GUI.Control.VERTICAL_ALIGNMENT_CENTER by default)
         */
        get textVerticalAlignment(): number;
        /**
         * Gets or sets text vertical alignment (BABYLON.GUI.Control.VERTICAL_ALIGNMENT_CENTER by default)
         */
        set textVerticalAlignment(value: number);
        /**
         * Gets or sets line spacing value
         */
        set lineSpacing(value: string | number);
        /**
         * Gets or sets line spacing value
         */
        get lineSpacing(): string | number;
        /**
         * Gets or sets outlineWidth of the text to display
         */
        get outlineWidth(): number;
        /**
         * Gets or sets outlineWidth of the text to display
         */
        set outlineWidth(value: number);
        /**
         * Gets or sets a boolean indicating that text must have underline
         */
        get underline(): boolean;
        /**
         * Gets or sets a boolean indicating that text must have underline
         */
        set underline(value: boolean);
        /**
         * Gets or sets an boolean indicating that text must be crossed out
         */
        get lineThrough(): boolean;
        /**
         * Gets or sets an boolean indicating that text must be crossed out
         */
        set lineThrough(value: boolean);
        /**
         * If the outline should be applied to the underline/strike-through too. Has different behavior in Edge/Chrome vs Firefox.
         */
        get applyOutlineToUnderline(): boolean;
        set applyOutlineToUnderline(value: boolean);
        /**
         * Gets or sets outlineColor of the text to display
         */
        get outlineColor(): string;
        /**
         * Gets or sets outlineColor of the text to display
         */
        set outlineColor(value: string);
        /**
         * Gets or sets word divider
         */
        get wordDivider(): string;
        /**
         * Gets or sets word divider
         */
        set wordDivider(value: string);
        /**
         * By default, if a text block has text wrapping other than Clip, its width
         * is not resized even if resizeToFit = true. This parameter forces the width
         * to be resized.
         */
        get forceResizeWidth(): boolean;
        set forceResizeWidth(value: boolean);
        /**
         * Creates a new TextBlock object
         * @param name defines the name of the control
         * @param text defines the text to display (empty string by default)
         */
        constructor(
        /**
         * Defines the name of the control
         */
        name?: string | undefined, text?: string);
        protected _getTypeName(): string;
        protected _processMeasures(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        private _drawText;
        private _drawLine;
        /**
         * @internal
         */
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        protected _applyStates(context: BABYLON.ICanvasRenderingContext): void;
        private _linesTemp;
        protected _breakLines(refWidth: number, refHeight: number, context: BABYLON.ICanvasRenderingContext): object[];
        private _htmlElement;
        protected _parseHTMLText(refWidth: number, refHeight: number, context: BABYLON.ICanvasRenderingContext): string[];
        protected _parseLine(line: string | undefined, context: BABYLON.ICanvasRenderingContext): object;
        private _getCharsToRemove;
        protected _parseLineEllipsis(line: string | undefined, width: number, context: BABYLON.ICanvasRenderingContext): object;
        private _getTextMetricsWidth;
        protected _parseLineWordWrap(line: string | undefined, width: number, context: BABYLON.ICanvasRenderingContext): object[];
        protected _parseLineWordWrapEllipsis(line: string | undefined, width: number, height: number, context: BABYLON.ICanvasRenderingContext): object[];
        protected _renderLines(context: BABYLON.ICanvasRenderingContext): void;
        private _computeHeightForLinesOf;
        isDimensionFullyDefined(dim: "width" | "height"): boolean;
        /**
         * Given a width constraint applied on the text block, find the expected height
         * @returns expected height
         */
        computeExpectedHeight(): number;
        dispose(): void;
    }


    /**
     * Forcing an export so that this code will execute
     * @internal
     */
    const name = "Statics";


    /**
     * Class used to create a 2D stack panel container
     */
    export class StackPanel extends Container {
        name?: string | undefined;
        private _isVertical;
        private _manualWidth;
        private _manualHeight;
        private _doNotTrackManualChanges;
        private _spacing;
        /**
         * Gets or sets a boolean indicating that layout warnings should be ignored
         */
        ignoreLayoutWarnings: boolean;
        /** Gets or sets a boolean indicating if the stack panel is vertical or horizontal*/
        get isVertical(): boolean;
        set isVertical(value: boolean);
        /**
         * Gets or sets the spacing (in pixels) between each child.
         */
        get spacing(): number;
        set spacing(value: number);
        /**
         * Gets or sets panel width.
         * This value should not be set when in horizontal mode as it will be computed automatically
         */
        set width(value: string | number);
        get width(): string | number;
        /**
         * Gets or sets panel height.
         * This value should not be set when in vertical mode as it will be computed automatically
         */
        set height(value: string | number);
        get height(): string | number;
        /**
         * Creates a new StackPanel
         * @param name defines control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        /**
         * @internal
         */
        protected _preMeasure(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _postMeasure(): void;
        private _getManualDim;
        isDimensionFullyDefined(dim: "width" | "height"): boolean;
        /**
         * Serializes the current control
         * @param serializationObject defined the JSON serialized object
         * @param force force serialization even if isSerializable === false
         */
        serialize(serializationObject: any, force: boolean): void;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture): void;
    }


    /** Class used to create a RadioGroup
     * which contains groups of radio buttons
     */
    export class SelectorGroup {
        /** name of SelectorGroup */
        name: string;
        private _groupPanel;
        private _selectors;
        private _groupHeader;
        /**
         * Creates a new SelectorGroup
         * @param name of group, used as a group heading
         */
        constructor(
        /** name of SelectorGroup */
        name: string);
        /** Gets the groupPanel of the SelectorGroup  */
        get groupPanel(): StackPanel;
        /** Gets the selectors array */
        get selectors(): StackPanel[];
        /** Gets and sets the group header */
        get header(): string;
        set header(label: string);
        /**
         * @internal
         */
        private _addGroupHeader;
        /**
         * @internal
         */
        _getSelector(selectorNb: number): StackPanel | undefined;
        /** Removes the selector at the given position
         * @param selectorNb the position of the selector within the group
         */
        removeSelector(selectorNb: number): void;
    }
    /** Class used to create a CheckboxGroup
     * which contains groups of checkbox buttons
     */
    export class CheckboxGroup extends SelectorGroup {
        /** Adds a checkbox as a control
         * @param text is the label for the selector
         * @param func is the function called when the Selector is checked
         * @param checked is true when Selector is checked
         */
        addCheckbox(text: string, func?: (s: boolean) => void, checked?: boolean): void;
        /**
         * @internal
         */
        _setSelectorLabel(selectorNb: number, label: string): void;
        /**
         * @internal
         */
        _setSelectorLabelColor(selectorNb: number, color: string): void;
        /**
         * @internal
         */
        _setSelectorButtonColor(selectorNb: number, color: string): void;
        /**
         * @internal
         */
        _setSelectorButtonBackground(selectorNb: number, color: string): void;
    }
    /** Class used to create a RadioGroup
     * which contains groups of radio buttons
     */
    export class RadioGroup extends SelectorGroup {
        private _selectNb;
        /** Adds a radio button as a control
         * @param label is the label for the selector
         * @param func is the function called when the Selector is checked
         * @param checked is true when Selector is checked
         */
        addRadio(label: string, func?: (n: number) => void, checked?: boolean): void;
        /**
         * @internal
         */
        _setSelectorLabel(selectorNb: number, label: string): void;
        /**
         * @internal
         */
        _setSelectorLabelColor(selectorNb: number, color: string): void;
        /**
         * @internal
         */
        _setSelectorButtonColor(selectorNb: number, color: string): void;
        /**
         * @internal
         */
        _setSelectorButtonBackground(selectorNb: number, color: string): void;
    }
    /** Class used to create a SliderGroup
     * which contains groups of slider buttons
     */
    export class SliderGroup extends SelectorGroup {
        /**
         * Adds a slider to the SelectorGroup
         * @param label is the label for the SliderBar
         * @param func is the function called when the Slider moves
         * @param unit is a string describing the units used, eg degrees or metres
         * @param min is the minimum value for the Slider
         * @param max is the maximum value for the Slider
         * @param value is the start value for the Slider between min and max
         * @param onValueChange is the function used to format the value displayed, eg radians to degrees
         */
        addSlider(label: string, func?: (v: number) => void, unit?: string, min?: number, max?: number, value?: number, onValueChange?: (v: number) => number): void;
        /**
         * @internal
         */
        _setSelectorLabel(selectorNb: number, label: string): void;
        /**
         * @internal
         */
        _setSelectorLabelColor(selectorNb: number, color: string): void;
        /**
         * @internal
         */
        _setSelectorButtonColor(selectorNb: number, color: string): void;
        /**
         * @internal
         */
        _setSelectorButtonBackground(selectorNb: number, color: string): void;
    }
    /** Class used to hold the controls for the checkboxes, radio buttons and sliders
     * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/selector
     */
    export class SelectionPanel extends Rectangle {
        /** name of SelectionPanel */
        name: string;
        /** an array of SelectionGroups */
        groups: SelectorGroup[];
        private _panel;
        private _buttonColor;
        private _buttonBackground;
        private _headerColor;
        private _barColor;
        private _barHeight;
        private _spacerHeight;
        private _labelColor;
        private _groups;
        private _bars;
        /**
         * Creates a new SelectionPanel
         * @param name of SelectionPanel
         * @param groups is an array of SelectionGroups
         */
        constructor(
        /** name of SelectionPanel */
        name: string, 
        /** an array of SelectionGroups */
        groups?: SelectorGroup[]);
        protected _getTypeName(): string;
        /** Gets the (stack) panel of the SelectionPanel  */
        get panel(): StackPanel;
        /** Gets or sets the headerColor */
        get headerColor(): string;
        set headerColor(color: string);
        private _setHeaderColor;
        /** Gets or sets the button color */
        get buttonColor(): string;
        set buttonColor(color: string);
        private _setbuttonColor;
        /** Gets or sets the label color */
        get labelColor(): string;
        set labelColor(color: string);
        private _setLabelColor;
        /** Gets or sets the button background */
        get buttonBackground(): string;
        set buttonBackground(color: string);
        private _setButtonBackground;
        /** Gets or sets the color of separator bar */
        get barColor(): string;
        set barColor(color: string);
        private _setBarColor;
        /** Gets or sets the height of separator bar */
        get barHeight(): string;
        set barHeight(value: string);
        private _setBarHeight;
        /** Gets or sets the height of spacers*/
        get spacerHeight(): string;
        set spacerHeight(value: string);
        private _setSpacerHeight;
        /** Adds a bar between groups */
        private _addSpacer;
        /** Add a group to the selection panel
         * @param group is the selector group to add
         */
        addGroup(group: SelectorGroup): void;
        /** Remove the group from the given position
         * @param groupNb is the position of the group in the list
         */
        removeGroup(groupNb: number): void;
        /** Change a group header label
         * @param label is the new group header label
         * @param groupNb is the number of the group to relabel
         * */
        setHeaderName(label: string, groupNb: number): void;
        /** Change selector label to the one given
         * @param label is the new selector label
         * @param groupNb is the number of the groupcontaining the selector
         * @param selectorNb is the number of the selector within a group to relabel
         * */
        relabel(label: string, groupNb: number, selectorNb: number): void;
        /** For a given group position remove the selector at the given position
         * @param groupNb is the number of the group to remove the selector from
         * @param selectorNb is the number of the selector within the group
         */
        removeFromGroupSelector(groupNb: number, selectorNb: number): void;
        /** For a given group position of correct type add a checkbox button
         * @param groupNb is the number of the group to remove the selector from
         * @param label is the label for the selector
         * @param func is the function called when the Selector is checked
         * @param checked is true when Selector is checked
         */
        addToGroupCheckbox(groupNb: number, label: string, func?: () => void, checked?: boolean): void;
        /** For a given group position of correct type add a radio button
         * @param groupNb is the number of the group to remove the selector from
         * @param label is the label for the selector
         * @param func is the function called when the Selector is checked
         * @param checked is true when Selector is checked
         */
        addToGroupRadio(groupNb: number, label: string, func?: () => void, checked?: boolean): void;
        /**
         * For a given slider group add a slider
         * @param groupNb is the number of the group to add the slider to
         * @param label is the label for the Slider
         * @param func is the function called when the Slider moves
         * @param unit is a string describing the units used, eg degrees or metres
         * @param min is the minimum value for the Slider
         * @param max is the maximum value for the Slider
         * @param value is the start value for the Slider between min and max
         * @param onVal is the function used to format the value displayed, eg radians to degrees
         */
        addToGroupSlider(groupNb: number, label: string, func?: () => void, unit?: string, min?: number, max?: number, value?: number, onVal?: (v: number) => number): void;
    }


    /** Class used to create rectangle container */
    export class Rectangle extends Container {
        name?: string | undefined;
        private _thickness;
        private _cornerRadius;
        private _cachedRadius;
        /** Gets or sets border thickness */
        get thickness(): number;
        set thickness(value: number);
        /** Gets or sets the corner radius of all angles */
        get cornerRadius(): number;
        set cornerRadius(value: number);
        /** Gets or sets the corner radius top left angle */
        get cornerRadiusX(): number;
        set cornerRadiusX(value: number);
        /** Gets or sets the corner radius top right angle */
        get cornerRadiusY(): number;
        set cornerRadiusY(value: number);
        /** Gets or sets the corner radius bottom left angle */
        get cornerRadiusZ(): number;
        set cornerRadiusZ(value: number);
        /** Gets or sets the corner radius bottom right angle */
        get cornerRadiusW(): number;
        set cornerRadiusW(value: number);
        /**
         * Creates a new Rectangle
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        /** @internal */
        protected _computeAdditionalOffsetX(): number;
        /** @internal */
        protected _computeAdditionalOffsetY(): number;
        protected _getRectangleFill(context: BABYLON.ICanvasRenderingContext): string | CanvasGradient;
        protected _localDraw(context: BABYLON.ICanvasRenderingContext): void;
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        private _drawRoundedRect;
        protected _clipForChildren(context: BABYLON.ICanvasRenderingContext): void;
    }


    /**
     * Class used to create radio button controls
     */
    export class RadioButton extends Control {
        name?: string | undefined;
        private _isChecked;
        private _background;
        private _checkSizeRatio;
        private _thickness;
        /** Gets or sets border thickness */
        get thickness(): number;
        set thickness(value: number);
        /** Gets or sets group name */
        group: string;
        /** BABYLON.Observable raised when isChecked is changed */
        onIsCheckedChangedObservable: BABYLON.Observable<boolean>;
        /** Gets or sets a value indicating the ratio between overall size and check size */
        get checkSizeRatio(): number;
        set checkSizeRatio(value: number);
        /** Gets or sets background color */
        get background(): string;
        set background(value: string);
        /** Gets or sets a boolean indicating if the checkbox is checked or not */
        get isChecked(): boolean;
        set isChecked(value: boolean);
        /**
         * Creates a new RadioButton
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        /**
         * Utility function to easily create a radio button with a header
         * @param title defines the label to use for the header
         * @param group defines the group to use for the radio button
         * @param isChecked defines the initial state of the radio button
         * @param onValueChanged defines the callback to call when value changes
         * @returns a StackPanel containing the radio button and a textBlock
         */
        static AddRadioButtonWithHeader(title: string, group: string, isChecked: boolean, onValueChanged: (button: RadioButton, value: boolean) => void): StackPanel;
    }


    /**
     * Class used to create multi line control
     */
    export class MultiLine extends Control {
        name?: string | undefined;
        private _lineWidth;
        private _dash;
        private _points;
        private _minX;
        private _minY;
        private _maxX;
        private _maxY;
        /**
         * Creates a new MultiLine
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        /** Gets or sets dash pattern */
        get dash(): Array<number>;
        set dash(value: Array<number>);
        /**
         * Gets point stored at specified index
         * @param index defines the index to look for
         * @returns the requested point if found
         */
        getAt(index: number): MultiLinePoint;
        /** Function called when a point is updated */
        onPointUpdate: () => void;
        /**
         * Adds new points to the point collection
         * @param items defines the list of items (mesh, control or 2d coordinates) to add
         * @returns the list of created MultiLinePoint
         */
        add(...items: (AbstractMesh | Control | {
            x: string | number;
            y: string | number;
        })[]): MultiLinePoint[];
        /**
         * Adds a new point to the point collection
         * @param item defines the item (mesh, control or 2d coordinates) to add
         * @returns the created MultiLinePoint
         */
        push(item?: BABYLON.AbstractMesh | Control | {
            x: string | number;
            y: string | number;
        }): MultiLinePoint;
        /**
         * Remove a specific value or point from the active point collection
         * @param value defines the value or point to remove
         */
        remove(value: number | MultiLinePoint): void;
        /**
         * Resets this object to initial state (no point)
         */
        reset(): void;
        /**
         * Resets all links
         */
        resetLinks(): void;
        /** Gets or sets line width */
        get lineWidth(): number;
        set lineWidth(value: number);
        set horizontalAlignment(value: number);
        set verticalAlignment(value: number);
        protected _getTypeName(): string;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        protected _additionalProcessing(): void;
        _measure(): void;
        protected _computeAlignment(): void;
        dispose(): void;
    }


    /** Class used to render 2D lines */
    export class Line extends Control {
        name?: string | undefined;
        private _lineWidth;
        /** @internal */
        _x1: ValueAndUnit;
        /** @internal */
        _y1: ValueAndUnit;
        /** @internal */
        _x2: ValueAndUnit;
        /** @internal */
        _y2: ValueAndUnit;
        private _dash;
        private _connectedControl;
        private _connectedControlDirtyObserver;
        /** Gets or sets the dash pattern */
        get dash(): Array<number>;
        set dash(value: Array<number>);
        /** Gets or sets the control connected with the line end */
        get connectedControl(): Control;
        set connectedControl(value: Control);
        /** Gets or sets start coordinates on X axis */
        get x1(): string | number;
        set x1(value: string | number);
        /** Gets or sets start coordinates on Y axis */
        get y1(): string | number;
        set y1(value: string | number);
        /** Gets or sets end coordinates on X axis */
        get x2(): string | number;
        set x2(value: string | number);
        /** Gets or sets end coordinates on Y axis */
        get y2(): string | number;
        set y2(value: string | number);
        /** Gets or sets line width */
        get lineWidth(): number;
        set lineWidth(value: number);
        /** Gets or sets horizontal alignment */
        set horizontalAlignment(value: number);
        /** Gets or sets vertical alignment */
        set verticalAlignment(value: number);
        /** @internal */
        get _effectiveX2(): number;
        /** @internal */
        get _effectiveY2(): number;
        /**
         * Creates a new Line
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        _measure(): void;
        protected _computeAlignment(parentMeasure: Measure): void;
        /**
         * Move one end of the line given 3D cartesian coordinates.
         * @param position Targeted world position
         * @param scene BABYLON.Scene
         * @param end (opt) Set to true to assign x2 and y2 coordinates of the line. Default assign to x1 and y1.
         */
        moveToVector3(position: BABYLON.Vector3, scene: BABYLON.Scene, end?: boolean): void;
        /**
         * Move one end of the line to a position in screen absolute space.
         * @param projectedPosition Position in screen absolute space (X, Y)
         * @param end (opt) Set to true to assign x2 and y2 coordinates of the line. Default assign to x1 and y1.
         */
        _moveToProjectedPosition(projectedPosition: BABYLON.Vector3, end?: boolean): void;
    }


    /**
     * Class used to create input text control
     */
    export class InputTextArea extends InputText {
        name?: string | undefined;
        private _textHorizontalAlignment;
        private _textVerticalAlignment;
        private _prevText;
        private _lines;
        private _lineSpacing;
        private _maxHeight;
        private _clipTextTop;
        private _clipTextLeft;
        private _cursorInfo;
        private _highlightCursorInfo;
        /**
         * An event triggered after the text was broken up into lines
         */
        onLinesReadyObservable: BABYLON.Observable<InputTextArea>;
        /** @internal */
        _connectedVirtualKeyboard: BABYLON.Nullable<VirtualKeyboard>;
        private _contextForBreakLines;
        private _clickedCoordinateX;
        private _clickedCoordinateY;
        private _availableWidth;
        private _availableHeight;
        private _scrollTop;
        private _autoStretchHeight;
        /** Gets or sets a boolean indicating if the control can auto stretch its height to adapt to the text */
        get autoStretchHeight(): boolean;
        set autoStretchHeight(value: boolean);
        set height(value: string | number);
        get maxHeight(): string | number;
        /** Gets the maximum width allowed by the control in pixels */
        get maxHeightInPixels(): number;
        set maxHeight(value: string | number);
        /**
         * Creates a new InputTextArea
         * @param name defines the control name
         * @param text defines the text of the control
         */
        constructor(name?: string | undefined, text?: string);
        protected _getTypeName(): string;
        /**
         * Handles the keyboard event
         * @param evt Defines the KeyboardEvent
         */
        processKeyboard(evt: BABYLON.IKeyboardEvent): void;
        /**
         * Process the last keyboard input
         *
         * @param code The ascii input number
         * @param key The key string representation
         * @param evt The keyboard event emits with input
         * @internal
         */
        alternativeProcessKey(code: string, key?: string, evt?: BABYLON.IKeyboardEvent): void;
        protected _parseLineWordWrap(line: string | undefined, width: number, context: BABYLON.ICanvasRenderingContext): {
            text: string;
            width: number;
            lineEnding: string;
        }[];
        protected _breakLines(refWidth: number, context: BABYLON.ICanvasRenderingContext): object[];
        protected _parseLine(line: string | undefined, context: BABYLON.ICanvasRenderingContext): {
            text: string;
            width: number;
            lineEnding: string;
        };
        /**
         * Processing of child right before the parent measurement update
         *
         * @param parentMeasure The parent measure
         * @param context The rendering canvas
         * @internal
         */
        protected _preMeasure(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _textHasChanged(): void;
        private _computeScroll;
        /**
         * Processing of child after the parent measurement update
         *
         * @internal
         */
        protected _additionalProcessing(): void;
        private _drawText;
        /**
         * Copy the text in the clipboard
         *
         * @param ev The clipboard event
         * @internal
         */
        protected _onCopyText(ev: ClipboardEvent): void;
        /**
         * Cut the text and copy it in the clipboard
         *
         * @param ev The clipboard event
         * @internal
         */
        protected _onCutText(ev: ClipboardEvent): void;
        /**
         * Paste the copied text from the clipboard
         *
         * @param ev The clipboard event
         * @internal
         */
        protected _onPasteText(ev: ClipboardEvent): void;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        private _resetBlinking;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        _onPointerMove(target: Control, coordinates: BABYLON.Vector2, pointerId: number, pi: BABYLON.PointerInfoBase): void;
        /**
         * Apply the correct position of cursor according to current modification
         */
        private _updateCursorPosition;
        /**
         * Update all values of cursor information based on cursorIndex value
         *
         * @param offset The index to take care of
         * @internal
         */
        protected _updateValueFromCursorIndex(offset: number): void;
        /**
         * Select the word immediatly under the cursor on double click
         *
         * @param _evt Pointer informations of double click
         * @internal
         */
        protected _processDblClick(_evt: BABYLON.PointerInfo): void;
        /** @internal */
        protected _selectAllText(): void;
        dispose(): void;
    }


    /**
     * Class used to create input text control
     */
    export class InputText extends Control {
        name?: string | undefined;
        protected _textWrapper: TextWrapper;
        protected _placeholderText: string;
        protected _background: string;
        protected _focusedBackground: string;
        protected _placeholderColor: string;
        protected _thickness: number;
        protected _margin: ValueAndUnit;
        protected _autoStretchWidth: boolean;
        protected _maxWidth: ValueAndUnit;
        /** the type of device that most recently focused the input: "mouse", "touch" or "pen" */
        protected _focusedBy: string;
        protected _blinkTimeout: number;
        protected _blinkIsEven: boolean;
        private _cursorOffset;
        protected _scrollLeft: BABYLON.Nullable<number>;
        protected _textWidth: number;
        protected _clickedCoordinate: BABYLON.Nullable<number>;
        protected _deadKey: boolean;
        protected _addKey: boolean;
        protected _currentKey: string;
        protected _isTextHighlightOn: boolean;
        protected _textHighlightColor: string;
        protected _highligherOpacity: number;
        protected _highlightedText: string;
        private _startHighlightIndex;
        private _endHighlightIndex;
        private _cursorIndex;
        private _outlineWidth;
        private _outlineColor;
        protected _onFocusSelectAll: boolean;
        protected _isPointerDown: boolean;
        protected _onClipboardObserver: BABYLON.Nullable<BABYLON.Observer<BABYLON.ClipboardInfo>>;
        protected _onPointerDblTapObserver: BABYLON.Nullable<BABYLON.Observer<BABYLON.PointerInfo>>;
        /** @internal */
        _connectedVirtualKeyboard: BABYLON.Nullable<VirtualKeyboard>;
        /** Gets or sets a string representing the message displayed on mobile when the control gets the focus */
        promptMessage: string;
        /** Force disable prompt on mobile device */
        disableMobilePrompt: boolean;
        /**
         * Gets or sets outlineWidth of the text to display
         */
        get outlineWidth(): number;
        set outlineWidth(value: number);
        /**
         * Gets or sets outlineColor of the text to display
         */
        get outlineColor(): string;
        set outlineColor(value: string);
        /** BABYLON.Observable raised when the text changes */
        onTextChangedObservable: BABYLON.Observable<InputText>;
        /** BABYLON.Observable raised just before an entered character is to be added */
        onBeforeKeyAddObservable: BABYLON.Observable<InputText>;
        /** BABYLON.Observable raised when the text is highlighted */
        onTextHighlightObservable: BABYLON.Observable<InputText>;
        /** BABYLON.Observable raised when copy event is triggered */
        onTextCopyObservable: BABYLON.Observable<InputText>;
        /** BABYLON.Observable raised when cut event is triggered */
        onTextCutObservable: BABYLON.Observable<InputText>;
        /** BABYLON.Observable raised when paste event is triggered */
        onTextPasteObservable: BABYLON.Observable<InputText>;
        /** Gets or sets the maximum width allowed by the control */
        get maxWidth(): string | number;
        /** Gets the maximum width allowed by the control in pixels */
        get maxWidthInPixels(): number;
        set maxWidth(value: string | number);
        /** Gets or sets the text highlighter transparency; default: 0.4 */
        get highligherOpacity(): number;
        set highligherOpacity(value: number);
        /** Gets or sets a boolean indicating whether to select complete text by default on input focus */
        get onFocusSelectAll(): boolean;
        set onFocusSelectAll(value: boolean);
        /** Gets or sets the text hightlight color */
        get textHighlightColor(): string;
        set textHighlightColor(value: string);
        /** Gets or sets control margin */
        get margin(): string;
        /** Gets control margin in pixels */
        get marginInPixels(): number;
        set margin(value: string);
        /** Gets or sets a boolean indicating if the control can auto stretch its width to adapt to the text */
        get autoStretchWidth(): boolean;
        set autoStretchWidth(value: boolean);
        /** Gets or sets border thickness */
        get thickness(): number;
        set thickness(value: number);
        /** Gets or sets the background color when focused */
        get focusedBackground(): string;
        set focusedBackground(value: string);
        /** Gets or sets the background color when focused */
        set focusedColor(value: string);
        /** Gets or sets the background color */
        get background(): string;
        set background(value: string);
        /** Gets or sets the placeholder color */
        get placeholderColor(): string;
        set placeholderColor(value: string);
        /** Gets or sets the text displayed when the control is empty */
        get placeholderText(): string;
        set placeholderText(value: string);
        /** Gets or sets the dead key. 0 to disable. */
        get deadKey(): boolean;
        set deadKey(flag: boolean);
        /** Gets or sets the highlight text */
        get highlightedText(): string;
        set highlightedText(text: string);
        /** Gets or sets if the current key should be added */
        get addKey(): boolean;
        set addKey(flag: boolean);
        /** Gets or sets the value of the current key being entered */
        get currentKey(): string;
        set currentKey(key: string);
        /** Gets or sets the text displayed in the control */
        get text(): string;
        set text(value: string);
        protected _textHasChanged(): void;
        protected _applyStates(context: BABYLON.ICanvasRenderingContext): void;
        /** Gets or sets control width */
        get width(): string | number;
        set width(value: string | number);
        /**
         * Creates a new InputText
         * @param name defines the control name
         * @param text defines the text of the control
         */
        constructor(name?: string | undefined, text?: string);
        /** @internal */
        onBlur(): void;
        /** @internal */
        onFocus(): void;
        protected _getTypeName(): string;
        /**
         * Function called to get the list of controls that should not steal the focus from this control
         * @returns an array of controls
         */
        keepsFocusWith(): BABYLON.Nullable<Control[]>;
        /**
         * @internal
         */
        processKey(keyCode: number, key?: string, evt?: BABYLON.IKeyboardEvent): void;
        /**
         * @internal
         */
        protected _updateValueFromCursorIndex(offset: number): void;
        /**
         * @internal
         */
        protected _processDblClick(evt: BABYLON.PointerInfo): void;
        /** @internal */
        protected _selectAllText(): void;
        /**
         * Handles the keyboard event
         * @param evt Defines the KeyboardEvent
         */
        processKeyboard(evt: BABYLON.IKeyboardEvent): void;
        /**
         * @internal
         */
        protected _onCopyText(ev: ClipboardEvent): void;
        /**
         * @internal
         */
        protected _onCutText(ev: ClipboardEvent): void;
        /**
         * @internal
         */
        protected _onPasteText(ev: ClipboardEvent): void;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        _onPointerMove(target: Control, coordinates: BABYLON.Vector2, pointerId: number, pi: BABYLON.PointerInfoBase): void;
        _onPointerUp(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, notifyClick: boolean): void;
        protected _beforeRenderText(textWrapper: TextWrapper): TextWrapper;
        /** @internal */
        private set isTextHighlightOn(value);
        /** @internal */
        private get isTextHighlightOn();
        dispose(): void;
    }


    /**
     * Class used to create a password control
     */
    export class InputPassword extends InputText {
        protected _getTypeName(): string;
        protected _beforeRenderText(textWrapper: TextWrapper): TextWrapper;
    }




    /**
     * Class used to create 2D images
     */
    export class Image extends Control {
        name?: string | undefined;
        /**
         *  Specifies an alternate text for the image, if the image for some reason cannot be displayed.
         */
        alt?: string;
        private _workingCanvas;
        private _domImage;
        private _imageWidth;
        private _imageHeight;
        private _loaded;
        private _stretch;
        private _source;
        private _autoScale;
        private _sourceLeft;
        private _sourceTop;
        private _sourceWidth;
        private _sourceHeight;
        private _svgAttributesComputationCompleted;
        private _isSVG;
        private _cellWidth;
        private _cellHeight;
        private _cellId;
        private _sliceLeft;
        private _sliceRight;
        private _sliceTop;
        private _sliceBottom;
        private _populateNinePatchSlicesFromImage;
        private _detectPointerOnOpaqueOnly;
        private _imageDataCache;
        /**
         * Cache of images to avoid loading the same image multiple times
         */
        static SourceImgCache: Map<string, {
            img: BABYLON.IImage;
            timesUsed: number;
            loaded: boolean;
            waitingForLoadCallback: Array<() => void>;
        }>;
        /**
         * BABYLON.Observable notified when the content is loaded
         */
        onImageLoadedObservable: BABYLON.Observable<Image>;
        /**
         * BABYLON.Observable notified when _sourceLeft, _sourceTop, _sourceWidth and _sourceHeight are computed
         */
        onSVGAttributesComputedObservable: BABYLON.Observable<Image>;
        /**
         * Gets or sets the referrer policy to apply on the img element load request.
         * You should set referrerPolicy before set the source of the image if you want to ensure the header will be present on the xhr loading request
         */
        referrerPolicy: BABYLON.Nullable<ReferrerPolicy>;
        /**
         * Gets a boolean indicating that the content is loaded
         */
        get isLoaded(): boolean;
        isReady(): boolean;
        /**
         * Gets or sets a boolean indicating if pointers should only be validated on pixels with alpha > 0.
         * Beware using this as this will consume more memory as the image has to be stored twice
         */
        get detectPointerOnOpaqueOnly(): boolean;
        set detectPointerOnOpaqueOnly(value: boolean);
        /**
         * Gets or sets the left value for slicing (9-patch)
         */
        get sliceLeft(): number;
        set sliceLeft(value: number);
        /**
         * Gets or sets the right value for slicing (9-patch)
         */
        get sliceRight(): number;
        set sliceRight(value: number);
        /**
         * Gets or sets the top value for slicing (9-patch)
         */
        get sliceTop(): number;
        set sliceTop(value: number);
        /**
         * Gets or sets the bottom value for slicing (9-patch)
         */
        get sliceBottom(): number;
        set sliceBottom(value: number);
        /**
         * Gets or sets the left coordinate in the source image
         */
        get sourceLeft(): number;
        set sourceLeft(value: number);
        /**
         * Gets or sets the top coordinate in the source image
         */
        get sourceTop(): number;
        set sourceTop(value: number);
        /**
         * Gets or sets the width to capture in the source image
         */
        get sourceWidth(): number;
        set sourceWidth(value: number);
        /**
         * Gets or sets the height to capture in the source image
         */
        get sourceHeight(): number;
        set sourceHeight(value: number);
        /**
         * Gets the image width
         */
        get imageWidth(): number;
        /**
         * Gets the image height
         */
        get imageHeight(): number;
        /**
         * Gets or sets a boolean indicating if nine patch slices (left, top, right, bottom) should be read from image data
         */
        get populateNinePatchSlicesFromImage(): boolean;
        set populateNinePatchSlicesFromImage(value: boolean);
        /** Indicates if the format of the image is SVG */
        get isSVG(): boolean;
        /** Gets the status of the SVG attributes computation (sourceLeft, sourceTop, sourceWidth, sourceHeight) */
        get svgAttributesComputationCompleted(): boolean;
        /**
         * Gets or sets a boolean indicating if the image can force its container to adapt its size
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#image
         */
        get autoScale(): boolean;
        set autoScale(value: boolean);
        /** Gets or sets the stretching mode used by the image */
        get stretch(): number;
        set stretch(value: number);
        /**
         * @internal
         */
        _rotate90(n: number, preserveProperties?: boolean): Image;
        private _handleRotationForSVGImage;
        private _rotate90SourceProperties;
        private _extractNinePatchSliceDataFromImage;
        /**
         * Gets or sets the internal DOM image used to render the control
         */
        set domImage(value: BABYLON.IImage);
        get domImage(): BABYLON.IImage;
        private _onImageLoaded;
        /**
         * Gets the image source url
         */
        get source(): BABYLON.Nullable<string>;
        /**
         * Resets the internal Image Element cache. Can reduce memory usage.
         */
        static ResetImageCache(): void;
        private _removeCacheUsage;
        /**
         * Gets or sets image source url
         */
        set source(value: BABYLON.Nullable<string>);
        /**
         * Checks for svg document with icon id present
         * @param value the source svg
         * @returns the svg
         */
        private _svgCheck;
        /**
         * Sets sourceLeft, sourceTop, sourceWidth, sourceHeight automatically
         * given external svg file and icon id
         * @param svgsrc
         * @param elemid
         */
        private _getSVGAttribs;
        /**
         * Gets or sets the cell width to use when animation sheet is enabled
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#image
         */
        get cellWidth(): number;
        set cellWidth(value: number);
        /**
         * Gets or sets the cell height to use when animation sheet is enabled
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#image
         */
        get cellHeight(): number;
        set cellHeight(value: number);
        /**
         * Gets or sets the cell id to use (this will turn on the animation sheet mode)
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#image
         */
        get cellId(): number;
        set cellId(value: number);
        /**
         * Creates a new Image
         * @param name defines the control name
         * @param url defines the image url
         */
        constructor(name?: string | undefined, url?: BABYLON.Nullable<string>);
        /**
         * Tests if a given coordinates belong to the current control
         * @param x defines x coordinate to test
         * @param y defines y coordinate to test
         * @returns true if the coordinates are inside the control
         */
        contains(x: number, y: number): boolean;
        protected _getTypeName(): string;
        /** Force the control to synchronize with its content */
        synchronizeSizeWithContent(): void;
        protected _processMeasures(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        private _prepareWorkingCanvasForOpaqueDetection;
        private _drawImage;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        private _renderNinePatch;
        dispose(): void;
        /** STRETCH_NONE */
        static readonly STRETCH_NONE = 0;
        /** STRETCH_FILL */
        static readonly STRETCH_FILL = 1;
        /** STRETCH_UNIFORM */
        static readonly STRETCH_UNIFORM = 2;
        /** STRETCH_EXTEND */
        static readonly STRETCH_EXTEND = 3;
        /** NINE_PATCH */
        static readonly STRETCH_NINE_PATCH = 4;
    }


    /**
     * Class used to create a 2D grid container
     */
    export class Grid extends Container {
        name?: string | undefined;
        private _rowDefinitions;
        private _rowDefinitionObservers;
        private _columnDefinitions;
        private _columnDefinitionObservers;
        private _cells;
        private _childControls;
        /**
         * Sets/Gets a boolean indicating that control content must be clipped
         * Please note that not clipping content may generate issues with adt.useInvalidateRectOptimization so it is recommended to turn this optimization off if you want to use unclipped children
         */
        set clipContent(value: boolean);
        get clipContent(): boolean;
        /**
         * Sets/Gets a boolean indicating if the children are clipped to the current control bounds.
         * Please note that not clipping children may generate issues with adt.useInvalidateRectOptimization so it is recommended to turn this optimization off if you want to use unclipped children
         */
        set clipChildren(value: boolean);
        get clipChildren(): boolean;
        /**
         * Gets the number of columns
         */
        get columnCount(): number;
        /**
         * Gets the number of rows
         */
        get rowCount(): number;
        /** Gets the list of children */
        get children(): Control[];
        /** Gets the list of cells (e.g. the containers) */
        get cells(): {
            [key: string]: Container;
        };
        /**
         * Gets the definition of a specific row
         * @param index defines the index of the row
         * @returns the row definition
         */
        getRowDefinition(index: number): BABYLON.Nullable<ValueAndUnit>;
        /**
         * Gets the definition of a specific column
         * @param index defines the index of the column
         * @returns the column definition
         */
        getColumnDefinition(index: number): BABYLON.Nullable<ValueAndUnit>;
        /**
         * Adds a new row to the grid
         * @param height defines the height of the row (either in pixel or a value between 0 and 1)
         * @param isPixel defines if the height is expressed in pixel (or in percentage)
         * @returns the current grid
         */
        addRowDefinition(height: number, isPixel?: boolean): Grid;
        /**
         * Adds a new column to the grid
         * @param width defines the width of the column (either in pixel or a value between 0 and 1)
         * @param isPixel defines if the width is expressed in pixel (or in percentage)
         * @returns the current grid
         */
        addColumnDefinition(width: number, isPixel?: boolean): Grid;
        /**
         * Update a row definition
         * @param index defines the index of the row to update
         * @param height defines the height of the row (either in pixel or a value between 0 and 1)
         * @param isPixel defines if the weight is expressed in pixel (or in percentage)
         * @returns the current grid
         */
        setRowDefinition(index: number, height: number, isPixel?: boolean): Grid;
        /**
         * Update a column definition
         * @param index defines the index of the column to update
         * @param width defines the width of the column (either in pixel or a value between 0 and 1)
         * @param isPixel defines if the width is expressed in pixel (or in percentage)
         * @returns the current grid
         */
        setColumnDefinition(index: number, width: number, isPixel?: boolean): Grid;
        /**
         * Gets the list of children stored in a specific cell
         * @param row defines the row to check
         * @param column defines the column to check
         * @returns the list of controls
         */
        getChildrenAt(row: number, column: number): BABYLON.Nullable<Array<Control>>;
        /**
         * Gets a string representing the child cell info (row x column)
         * @param child defines the control to get info from
         * @returns a string containing the child cell info (row x column)
         */
        getChildCellInfo(child: Control): string;
        private _removeCell;
        private _offsetCell;
        /**
         * Remove a column definition at specified index
         * @param index defines the index of the column to remove
         * @returns the current grid
         */
        removeColumnDefinition(index: number): Grid;
        /**
         * Remove a row definition at specified index
         * @param index defines the index of the row to remove
         * @returns the current grid
         */
        removeRowDefinition(index: number): Grid;
        /**
         * Adds a new control to the current grid
         * @param control defines the control to add
         * @param row defines the row where to add the control (0 by default)
         * @param column defines the column where to add the control (0 by default)
         * @returns the current grid
         */
        addControl(control: Control, row?: number, column?: number): Grid;
        /**
         * Removes a control from the current container
         * @param control defines the control to remove
         * @returns the current container
         */
        removeControl(control: Control): Container;
        /**
         * Creates a new Grid
         * @param name defines control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        protected _getGridDefinitions(definitionCallback: (lefts: number[], tops: number[], widths: number[], heights: number[]) => void): void;
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        _flagDescendantsAsMatrixDirty(): void;
        _renderHighlightSpecific(context: BABYLON.ICanvasRenderingContext): void;
        /** Releases associated resources */
        dispose(): void;
        /**
         * Serializes the current control
         * @param serializationObject defined the JSON serialized object
         * @param force force serialization even if isSerializable === false
         */
        serialize(serializationObject: any, force: boolean): void;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture): void;
    }


    /**
     * Interface used to define a control that can receive focus
     */
    export interface IFocusableControl {
        /**
         * Function called when the control receives the focus
         */
        onFocus(): void;
        /**
         * Function called when the control loses the focus
         */
        onBlur(): void;
        /**
         * Function called to let the control handle keyboard events
         * @param evt defines the current keyboard event
         */
        processKeyboard(evt: BABYLON.IKeyboardEvent): void;
        /**
         * Function called to get the list of controls that should not steal the focus from this control
         * @returns an array of controls
         */
        keepsFocusWith(): BABYLON.Nullable<Control[]>;
        /**
         * Function to focus the control programmatically
         */
        focus(): void;
        /**
         * Function to unfocus the control programmatically
         */
        blur(): void;
        /**
         * Gets or sets the tabIndex of the control
         */
        tabIndex?: number;
        /**
         * Gets or sets the color used to draw the focus border
         * Defaults to "white"
         */
        focusBorderColor?: string;
    }


    /**
     * Class used to create a focusable button that can easily handle keyboard events
     * @since 5.0.0
     */
    export class FocusableButton extends Button implements IFocusableControl {
        name?: string | undefined;
        constructor(name?: string | undefined);
        /**
         * @internal
         */
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
    }


    /** Class used to create 2D ellipse containers */
    export class Ellipse extends Container {
        name?: string | undefined;
        private _thickness;
        /** Gets or sets border thickness */
        get thickness(): number;
        set thickness(value: number);
        private _arc;
        /** Gets or sets arcing of the ellipse (ratio of the circumference between 0 and 1) */
        get arc(): number;
        set arc(value: number);
        /**
         * Creates a new Ellipse
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        protected _localDraw(context: BABYLON.ICanvasRenderingContext): void;
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _clipForChildren(context: BABYLON.ICanvasRenderingContext): void;
        _renderHighlightSpecific(context: BABYLON.ICanvasRenderingContext): void;
    }


    /** Class used to render a grid  */
    export class DisplayGrid extends Control {
        name?: string | undefined;
        private _cellWidth;
        private _cellHeight;
        private _minorLineTickness;
        private _minorLineColor;
        private _majorLineTickness;
        private _majorLineColor;
        private _majorLineFrequency;
        private _background;
        private _displayMajorLines;
        private _displayMinorLines;
        /** Gets or sets a boolean indicating if minor lines must be rendered (true by default)) */
        get displayMinorLines(): boolean;
        set displayMinorLines(value: boolean);
        /** Gets or sets a boolean indicating if major lines must be rendered (true by default)) */
        get displayMajorLines(): boolean;
        set displayMajorLines(value: boolean);
        /** Gets or sets background color (Black by default) */
        get background(): string;
        set background(value: string);
        /** Gets or sets the width of each cell (20 by default) */
        get cellWidth(): number;
        set cellWidth(value: number);
        /** Gets or sets the height of each cell (20 by default) */
        get cellHeight(): number;
        set cellHeight(value: number);
        /** Gets or sets the tickness of minor lines (1 by default) */
        get minorLineTickness(): number;
        set minorLineTickness(value: number);
        /** Gets or sets the color of minor lines (DarkGray by default) */
        get minorLineColor(): string;
        set minorLineColor(value: string);
        /** Gets or sets the tickness of major lines (2 by default) */
        get majorLineTickness(): number;
        set majorLineTickness(value: number);
        /** Gets or sets the color of major lines (White by default) */
        get majorLineColor(): string;
        set majorLineColor(value: string);
        /** Gets or sets the frequency of major lines (default is 1 every 5 minor lines)*/
        get majorLineFrequency(): number;
        set majorLineFrequency(value: number);
        /**
         * Creates a new GridDisplayRectangle
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        protected _getTypeName(): string;
    }


    /**
     * Root class used for all 2D controls
     * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#controls
     */
    export class Control implements BABYLON.IAnimatable, IFocusableControl {
        /** defines the name of the control */
        name?: string | undefined;
        /**
         * Gets or sets a boolean indicating if alpha must be an inherited value (false by default)
         */
        static AllowAlphaInheritance: boolean;
        private _alpha;
        private _alphaSet;
        private _zIndex;
        /** @internal */
        _host: AdvancedDynamicTexture;
        /** Gets or sets the control parent */
        parent: BABYLON.Nullable<Container>;
        /** @internal */
        _currentMeasure: Measure;
        /** @internal */
        _tempPaddingMeasure: Measure;
        private _fontFamily;
        private _fontStyle;
        private _fontWeight;
        private _fontSize;
        private _font;
        /** @internal */
        _width: ValueAndUnit;
        /** @internal */
        _height: ValueAndUnit;
        /** @internal */
        protected _fontOffset: {
            ascent: number;
            height: number;
            descent: number;
        };
        private _color;
        private _style;
        private _styleObserver;
        /** @internal */
        protected _horizontalAlignment: number;
        /** @internal */
        protected _verticalAlignment: number;
        /** @internal */
        protected _isDirty: boolean;
        /** @internal */
        protected _wasDirty: boolean;
        /** @internal */
        _tempParentMeasure: Measure;
        /** @internal */
        _prevCurrentMeasureTransformedIntoGlobalSpace: Measure;
        /** @internal */
        _cachedParentMeasure: Measure;
        private _descendantsOnlyPadding;
        private _paddingLeft;
        private _paddingRight;
        private _paddingTop;
        private _paddingBottom;
        /** @internal */
        _left: ValueAndUnit;
        /** @internal */
        _top: ValueAndUnit;
        private _scaleX;
        private _scaleY;
        private _rotation;
        private _transformCenterX;
        private _transformCenterY;
        /** @internal */
        _transformMatrix: Matrix2D;
        /** @internal */
        protected _invertTransformMatrix: Matrix2D;
        /** @internal */
        protected _transformedPosition: BABYLON.Vector2;
        private _isMatrixDirty;
        private _cachedOffsetX;
        private _cachedOffsetY;
        private _isVisible;
        private _isHighlighted;
        private _highlightColor;
        protected _highlightLineWidth: number;
        /** @internal */
        _linkedMesh: BABYLON.Nullable<BABYLON.TransformNode>;
        private _fontSet;
        private _dummyVector2;
        private _downCount;
        private _enterCount;
        private _doNotRender;
        private _downPointerIds;
        private _evaluatedMeasure;
        private _evaluatedParentMeasure;
        protected _isEnabled: boolean;
        protected _disabledColor: string;
        protected _disabledColorItem: string;
        protected _isReadOnly: boolean;
        private _gradient;
        /** @internal */
        protected _rebuildLayout: boolean;
        /** @internal */
        protected _urlRewriter?: (url: string) => string;
        /**
         * BABYLON.Observable that fires when the control's enabled state changes
         */
        onEnabledStateChangedObservable: BABYLON.Observable<boolean>;
        /** @internal */
        _customData: any;
        /** @internal */
        _isClipped: boolean;
        /** @internal */
        _automaticSize: boolean;
        /** @internal */
        _tag: any;
        /**
         * Gets or sets the unique id of the node. Please note that this number will be updated when the control is added to a container
         */
        uniqueId: number;
        /**
         * Gets or sets a boolean indicating if the control is readonly (default: false).
         * A readonly control will still raise pointer events but will not react to them
         */
        get isReadOnly(): boolean;
        set isReadOnly(value: boolean);
        /**
         * Gets the transformed measure, that is the bounding box of the control after applying all transformations
         */
        get transformedMeasure(): Measure;
        /**
         * Gets or sets an object used to store user defined information for the node
         */
        metadata: any;
        /** Gets or sets a boolean indicating if the control can be hit with pointer events */
        isHitTestVisible: boolean;
        /** Gets or sets a boolean indicating if the control can block pointer events. False by default except on the following controls:
         * * Button controls (Button, RadioButton, ToggleButton)
         * * Checkbox
         * * ColorPicker
         * * InputText
         * * Slider
         */
        isPointerBlocker: boolean;
        /** Gets or sets a boolean indicating if the control can be focusable */
        isFocusInvisible: boolean;
        protected _clipChildren: boolean;
        /**
         * Sets/Gets a boolean indicating if the children are clipped to the current control bounds.
         * Please note that not clipping children may generate issues with adt.useInvalidateRectOptimization so it is recommended to turn this optimization off if you want to use unclipped children
         */
        set clipChildren(value: boolean);
        get clipChildren(): boolean;
        protected _clipContent: boolean;
        /**
         * Sets/Gets a boolean indicating that control content must be clipped
         * Please note that not clipping content may generate issues with adt.useInvalidateRectOptimization so it is recommended to turn this optimization off if you want to use unclipped children
         */
        set clipContent(value: boolean);
        get clipContent(): boolean;
        /**
         * Gets or sets a boolean indicating that the current control should cache its rendering (useful when the control does not change often)
         */
        useBitmapCache: boolean;
        private _cacheData;
        private _shadowOffsetX;
        /** Gets or sets a value indicating the offset to apply on X axis to render the shadow */
        get shadowOffsetX(): number;
        set shadowOffsetX(value: number);
        private _shadowOffsetY;
        /** Gets or sets a value indicating the offset to apply on Y axis to render the shadow */
        get shadowOffsetY(): number;
        set shadowOffsetY(value: number);
        private _shadowBlur;
        private _previousShadowBlur;
        /** Gets or sets a value indicating the amount of blur to use to render the shadow */
        get shadowBlur(): number;
        set shadowBlur(value: number);
        private _shadowColor;
        /** Gets or sets a value indicating the color of the shadow (black by default ie. "#000") */
        get shadowColor(): string;
        set shadowColor(value: string);
        /** Gets or sets the cursor to use when the control is hovered */
        hoverCursor: string;
        /** @internal */
        protected _linkOffsetX: ValueAndUnit;
        /** @internal */
        protected _linkOffsetY: ValueAndUnit;
        /** Gets the control type name */
        get typeName(): string;
        /**
         * Get the current class name of the control.
         * @returns current class name
         */
        getClassName(): string;
        /**
         * Gets or sets the accessibility tag to describe the control for accessibility purpose.
         * By default, GUI controls already indicate accessibility info, but one can override the info using this tag.
         */
        set accessibilityTag(value: BABYLON.Nullable<BABYLON.IAccessibilityTag>);
        get accessibilityTag(): BABYLON.Nullable<BABYLON.IAccessibilityTag>;
        protected _accessibilityTag: BABYLON.Nullable<BABYLON.IAccessibilityTag>;
        /**
         * BABYLON.Observable that fires whenever the accessibility event of the control has changed
         */
        onAccessibilityTagChangedObservable: BABYLON.Observable<BABYLON.Nullable<BABYLON.IAccessibilityTag>>;
        /**
         * An event triggered when pointer wheel is scrolled
         */
        onWheelObservable: BABYLON.Observable<BABYLON.Vector2>;
        /**
         * An event triggered when the pointer moves over the control.
         */
        onPointerMoveObservable: BABYLON.Observable<BABYLON.Vector2>;
        /**
         * An event triggered when the pointer moves out of the control.
         */
        onPointerOutObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered when the pointer taps the control
         */
        onPointerDownObservable: BABYLON.Observable<Vector2WithInfo>;
        /**
         * An event triggered when pointer up
         */
        onPointerUpObservable: BABYLON.Observable<Vector2WithInfo>;
        /**
         * An event triggered when a control is clicked on
         */
        onPointerClickObservable: BABYLON.Observable<Vector2WithInfo>;
        /**
         * An event triggered when a control receives an ENTER key down event
         */
        onEnterPressedObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered when pointer enters the control
         */
        onPointerEnterObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered when the control is marked as dirty
         */
        onDirtyObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered before drawing the control
         */
        onBeforeDrawObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered after the control was drawn
         */
        onAfterDrawObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered when the control has been disposed
         */
        onDisposeObservable: BABYLON.Observable<Control>;
        /**
         * An event triggered when the control isVisible is changed
         */
        onIsVisibleChangedObservable: BABYLON.Observable<boolean>;
        /**
         * Get the hosting AdvancedDynamicTexture
         */
        get host(): AdvancedDynamicTexture;
        /** Gets or set information about font offsets (used to render and align text) */
        get fontOffset(): {
            ascent: number;
            height: number;
            descent: number;
        };
        set fontOffset(offset: {
            ascent: number;
            height: number;
            descent: number;
        });
        /** Gets or sets alpha value for the control (1 means opaque and 0 means entirely transparent) */
        get alpha(): number;
        set alpha(value: number);
        /**
         * Gets or sets a number indicating size of stroke we want to highlight the control with (mostly for debugging purpose)
         */
        get highlightLineWidth(): number;
        set highlightLineWidth(value: number);
        /**
         * Gets or sets a boolean indicating that we want to highlight the control (mostly for debugging purpose)
         */
        get isHighlighted(): boolean;
        set isHighlighted(value: boolean);
        /**
         * Indicates if the control should be serialized. Defaults to true.
         */
        isSerializable: boolean;
        /**
         * Gets or sets a string defining the color to use for highlighting this control
         */
        get highlightColor(): string;
        set highlightColor(value: string);
        /** Gets or sets a value indicating the scale factor on X axis (1 by default)
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#rotation-and-scaling
         */
        get scaleX(): number;
        set scaleX(value: number);
        /** Gets or sets a value indicating the scale factor on Y axis (1 by default)
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#rotation-and-scaling
         */
        get scaleY(): number;
        set scaleY(value: number);
        /** Gets or sets the rotation angle (0 by default)
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#rotation-and-scaling
         */
        get rotation(): number;
        set rotation(value: number);
        /** Gets or sets the transformation center on Y axis (0 by default)
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#rotation-and-scaling
         */
        get transformCenterY(): number;
        set transformCenterY(value: number);
        /** Gets or sets the transformation center on X axis (0 by default)
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#rotation-and-scaling
         */
        get transformCenterX(): number;
        set transformCenterX(value: number);
        /**
         * Gets or sets the horizontal alignment
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#alignments
         */
        get horizontalAlignment(): number;
        set horizontalAlignment(value: number);
        /**
         * Gets or sets the vertical alignment
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#alignments
         */
        get verticalAlignment(): number;
        set verticalAlignment(value: number);
        private _fixedRatio;
        set fixedRatio(value: number);
        /**
         * Gets or sets a fixed ratio for this control.
         * When different from 0, the ratio is used to compute the "second" dimension.
         * The first dimension used in the computation is the last one set (by setting width / widthInPixels or height / heightInPixels), and the
         * second dimension is computed as first dimension * fixedRatio
         */
        get fixedRatio(): number;
        private _fixedRatioMasterIsWidth;
        set fixedRatioMasterIsWidth(value: boolean);
        /**
         * Gets or sets a boolean indicating that the fixed ratio is set on the width instead of the height. True by default.
         * When the height of a control is set, this property is changed to false.
         */
        get fixedRatioMasterIsWidth(): boolean;
        /**
         * Gets or sets control width
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get width(): string | number;
        set width(value: string | number);
        /**
         * Gets or sets the control width in pixel
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get widthInPixels(): number;
        set widthInPixels(value: number);
        /**
         * Gets or sets control height
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get height(): string | number;
        set height(value: string | number);
        /**
         * Gets or sets control height in pixel
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get heightInPixels(): number;
        set heightInPixels(value: number);
        /** Gets or set font family */
        get fontFamily(): string;
        set fontFamily(value: string);
        /** Gets or sets font style */
        get fontStyle(): string;
        set fontStyle(value: string);
        /** Gets or sets font weight */
        get fontWeight(): string;
        set fontWeight(value: string);
        /**
         * Gets or sets style
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#styles
         */
        get style(): BABYLON.Nullable<Style>;
        set style(value: BABYLON.Nullable<Style>);
        /** @internal */
        get _isFontSizeInPercentage(): boolean;
        /** Gets or sets font size in pixels */
        get fontSizeInPixels(): number;
        set fontSizeInPixels(value: number);
        /** Gets or sets font size */
        get fontSize(): string | number;
        set fontSize(value: string | number);
        /** Gets or sets foreground color */
        get color(): string;
        set color(value: string);
        /** Gets or sets gradient. Setting a gradient will override the color */
        get gradient(): BABYLON.Nullable<BaseGradient>;
        set gradient(value: BABYLON.Nullable<BaseGradient>);
        /** Gets or sets z index which is used to reorder controls on the z axis */
        get zIndex(): number;
        set zIndex(value: number);
        /** Gets or sets a boolean indicating if the control can be rendered */
        get notRenderable(): boolean;
        set notRenderable(value: boolean);
        /** Gets or sets a boolean indicating if the control is visible */
        get isVisible(): boolean;
        set isVisible(value: boolean);
        /** Gets a boolean indicating that the control needs to update its rendering */
        get isDirty(): boolean;
        /**
         * Gets the current linked mesh (or null if none)
         */
        get linkedMesh(): BABYLON.Nullable<BABYLON.TransformNode>;
        /**
         * Gets or sets a value indicating the padding should work like in CSS.
         * Basically, it will add the padding amount on each side of the parent control for its children.
         */
        get descendantsOnlyPadding(): boolean;
        set descendantsOnlyPadding(value: boolean);
        /**
         * Gets or sets a value indicating the padding to use on the left of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingLeft(): string | number;
        set paddingLeft(value: string | number);
        /**
         * Gets or sets a value indicating the padding in pixels to use on the left of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingLeftInPixels(): number;
        set paddingLeftInPixels(value: number);
        /** @internal */
        get _paddingLeftInPixels(): number;
        /**
         * Gets or sets a value indicating the padding to use on the right of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingRight(): string | number;
        set paddingRight(value: string | number);
        /**
         * Gets or sets a value indicating the padding in pixels to use on the right of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingRightInPixels(): number;
        set paddingRightInPixels(value: number);
        /** @internal */
        get _paddingRightInPixels(): number;
        /**
         * Gets or sets a value indicating the padding to use on the top of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingTop(): string | number;
        set paddingTop(value: string | number);
        /**
         * Gets or sets a value indicating the padding in pixels to use on the top of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingTopInPixels(): number;
        set paddingTopInPixels(value: number);
        /** @internal */
        get _paddingTopInPixels(): number;
        /**
         * Gets or sets a value indicating the padding to use on the bottom of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingBottom(): string | number;
        set paddingBottom(value: string | number);
        /**
         * Gets or sets a value indicating the padding in pixels to use on the bottom of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get paddingBottomInPixels(): number;
        set paddingBottomInPixels(value: number);
        /** @internal */
        get _paddingBottomInPixels(): number;
        /**
         * Gets or sets a value indicating the left coordinate of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get left(): string | number;
        set left(value: string | number);
        /**
         * Gets or sets a value indicating the left coordinate in pixels of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get leftInPixels(): number;
        set leftInPixels(value: number);
        /**
         * Gets or sets a value indicating the top coordinate of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get top(): string | number;
        set top(value: string | number);
        /**
         * Gets or sets a value indicating the top coordinate in pixels of the control
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get topInPixels(): number;
        set topInPixels(value: number);
        /**
         * Gets or sets a value indicating the offset on X axis to the linked mesh
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#tracking-positions
         */
        get linkOffsetX(): string | number;
        set linkOffsetX(value: string | number);
        /**
         * Gets or sets a value indicating the offset in pixels on X axis to the linked mesh
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#tracking-positions
         */
        get linkOffsetXInPixels(): number;
        set linkOffsetXInPixels(value: number);
        /**
         * Gets or sets a value indicating the offset on Y axis to the linked mesh
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#tracking-positions
         */
        get linkOffsetY(): string | number;
        set linkOffsetY(value: string | number);
        /**
         * Gets or sets a value indicating the offset in pixels on Y axis to the linked mesh
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#tracking-positions
         */
        get linkOffsetYInPixels(): number;
        set linkOffsetYInPixels(value: number);
        /** Gets the center coordinate on X axis */
        get centerX(): number;
        /** Gets the center coordinate on Y axis */
        get centerY(): number;
        /** Gets or sets if control is Enabled */
        get isEnabled(): boolean;
        set isEnabled(value: boolean);
        /** Gets or sets background color of control if it's disabled. Only applies to Button class. */
        get disabledColor(): string;
        set disabledColor(value: string);
        /** Gets or sets front color of control if it's disabled. Only applies to Checkbox class. */
        get disabledColorItem(): string;
        set disabledColorItem(value: string);
        /**
         * Gets/sets the overlap group of the control.
         * Controls with overlapGroup set to a number can be deoverlapped.
         * Controls with overlapGroup set to undefined are not deoverlapped.
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#deoverlapping
         */
        overlapGroup?: number;
        /**
         * Gets/sets the deoverlap movement multiplier
         */
        overlapDeltaMultiplier?: number;
        /**
         * Array of animations
         */
        animations: BABYLON.Nullable<BABYLON.Animation[]>;
        protected _focusedColor: BABYLON.Nullable<string>;
        /**
         * Border color when control is focused
         * When not defined the ADT color will be used. If no ADT color is defined, focused state won't have any border
         */
        get focusedColor(): BABYLON.Nullable<string>;
        set focusedColor(value: BABYLON.Nullable<string>);
        /**
         * The tab index of this control. -1 indicates this control is not part of the tab navigation.
         * A positive value indicates the order of the control in the tab navigation.
         * A value of 0 indicated the control will be focused after all controls with a positive index.
         * More than one control can have the same tab index and the navigation would then go through all controls with the same value in an order defined by the layout or the hierarchy.
         * The value can be changed at any time.
         * @see https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/tabindex
         */
        tabIndex: number;
        protected _isFocused: boolean;
        protected _unfocusedColor: BABYLON.Nullable<string>;
        /** BABYLON.Observable raised when the control gets the focus */
        onFocusObservable: BABYLON.Observable<Control>;
        /** BABYLON.Observable raised when the control loses the focus */
        onBlurObservable: BABYLON.Observable<Control>;
        /** BABYLON.Observable raised when a key event was processed */
        onKeyboardEventProcessedObservable: BABYLON.Observable<BABYLON.IKeyboardEvent>;
        /** @internal */
        onBlur(): void;
        /** @internal */
        onFocus(): void;
        /**
         * Function called to get the list of controls that should not steal the focus from this control
         * @returns an array of controls
         */
        keepsFocusWith(): BABYLON.Nullable<Control[]>;
        /**
         * Function to focus a button programmatically
         */
        focus(): void;
        /**
         * Function to unfocus a button programmatically
         */
        blur(): void;
        /**
         * Handles the keyboard event
         * @param evt Defines the KeyboardEvent
         */
        processKeyboard(evt: BABYLON.IKeyboardEvent): void;
        /**
         * Creates a new control
         * @param name defines the name of the control
         */
        constructor(
        /** defines the name of the control */
        name?: string | undefined);
        /** @internal */
        protected _getTypeName(): string;
        /**
         * Gets the first ascendant in the hierarchy of the given type
         * @param className defines the required type
         * @returns the ascendant or null if not found
         */
        getAscendantOfClass(className: string): BABYLON.Nullable<Control>;
        /**
         * Mark control element as dirty
         * @param force force non visible elements to be marked too
         */
        markAsDirty(force?: boolean): void;
        /**
         * Mark the element and its children as dirty
         */
        markAllAsDirty(): void;
        /** @internal */
        _resetFontCache(): void;
        /**
         * Determines if a container is an ascendant of the current control
         * @param container defines the container to look for
         * @returns true if the container is one of the ascendant of the control
         */
        isAscendant(container: Control): boolean;
        /**
         * Gets coordinates in local control space
         * @param globalCoordinates defines the coordinates to transform
         * @returns the new coordinates in local space
         */
        getLocalCoordinates(globalCoordinates: BABYLON.Vector2): BABYLON.Vector2;
        /**
         * Gets coordinates in local control space
         * @param globalCoordinates defines the coordinates to transform
         * @param result defines the target vector2 where to store the result
         * @returns the current control
         */
        getLocalCoordinatesToRef(globalCoordinates: BABYLON.Vector2, result: BABYLON.Vector2): Control;
        /**
         * Gets coordinates in parent local control space
         * @param globalCoordinates defines the coordinates to transform
         * @returns the new coordinates in parent local space
         */
        getParentLocalCoordinates(globalCoordinates: BABYLON.Vector2): BABYLON.Vector2;
        /**
         * Move the current control to a vector3 position projected onto the screen.
         * @param position defines the target position
         * @param scene defines the hosting scene
         */
        moveToVector3(position: BABYLON.Vector3, scene: BABYLON.Scene): void;
        /**
         * Will store all controls that have this control as ascendant in a given array
         * @param results defines the array where to store the descendants
         * @param directDescendantsOnly defines if true only direct descendants of 'this' will be considered, if false direct and also indirect (children of children, an so on in a recursive manner) descendants of 'this' will be considered
         * @param predicate defines an optional predicate that will be called on every evaluated child, the predicate must return true for a given child to be part of the result, otherwise it will be ignored
         */
        getDescendantsToRef(results: Control[], directDescendantsOnly?: boolean, predicate?: (control: Control) => boolean): void;
        /**
         * Will return all controls that have this control as ascendant
         * @param directDescendantsOnly defines if true only direct descendants of 'this' will be considered, if false direct and also indirect (children of children, an so on in a recursive manner) descendants of 'this' will be considered
         * @param predicate defines an optional predicate that will be called on every evaluated child, the predicate must return true for a given child to be part of the result, otherwise it will be ignored
         * @returns all child controls
         */
        getDescendants(directDescendantsOnly?: boolean, predicate?: (control: Control) => boolean): Control[];
        /**
         * Link current control with a target mesh
         * @param mesh defines the mesh to link with
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#tracking-positions
         */
        linkWithMesh(mesh: BABYLON.Nullable<BABYLON.TransformNode>): void;
        /**
         * Shorthand function to set the top, right, bottom, and left padding values on the control.
         * @param { string | number} paddingTop - The value of the top padding.
         * @param { string | number} paddingRight - The value of the right padding. If omitted, top is used.
         * @param { string | number} paddingBottom - The value of the bottom padding. If omitted, top is used.
         * @param { string | number} paddingLeft - The value of the left padding. If omitted, right is used.
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        setPadding(paddingTop: string | number, paddingRight?: string | number, paddingBottom?: string | number, paddingLeft?: string | number): void;
        /**
         * Shorthand funtion to set the top, right, bottom, and left padding values in pixels on the control.
         * @param { number} paddingTop - The value in pixels of the top padding.
         * @param { number} paddingRight - The value in pixels of the right padding. If omitted, top is used.
         * @param { number} paddingBottom - The value in pixels of the bottom padding. If omitted, top is used.
         * @param { number} paddingLeft - The value in pixels of the left padding. If omitted, right is used.
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        setPaddingInPixels(paddingTop: number, paddingRight?: number, paddingBottom?: number, paddingLeft?: number): void;
        /**
         * @internal
         */
        _moveToProjectedPosition(projectedPosition: BABYLON.Vector3): void;
        /**
         * @internal
         */
        _offsetLeft(offset: number): void;
        /**
         * @internal
         */
        _offsetTop(offset: number): void;
        /** @internal */
        _markMatrixAsDirty(): void;
        /** @internal */
        _flagDescendantsAsMatrixDirty(): void;
        /**
         * @internal
         */
        _intersectsRect(rect: Measure, context?: BABYLON.ICanvasRenderingContext): boolean;
        /** @internal */
        protected _computeAdditionalOffsetX(): number;
        /** @internal */
        protected _computeAdditionalOffsetY(): number;
        /** @internal */
        invalidateRect(): void;
        /**
         * @internal
         */
        _markAsDirty(force?: boolean): void;
        /** @internal */
        _markAllAsDirty(): void;
        /**
         * @internal
         */
        _link(host: AdvancedDynamicTexture): void;
        /**
         * @internal
         */
        protected _transform(context?: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _renderHighlight(context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _renderHighlightSpecific(context: BABYLON.ICanvasRenderingContext): void;
        protected _getColor(context: BABYLON.ICanvasRenderingContext): string | BABYLON.ICanvasGradient;
        /**
         * @internal
         */
        protected _applyStates(context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _layout(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): boolean;
        /**
         * @internal
         */
        protected _processMeasures(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _evaluateClippingState(parentMeasure: Measure): void;
        /** @internal */
        _measure(): void;
        /**
         * @internal
         */
        protected _computeAlignment(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        protected _preMeasure(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        protected _postMeasure(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        protected _clipForChildren(context: BABYLON.ICanvasRenderingContext): void;
        private static _ClipMeasure;
        private _tmpMeasureA;
        private _clip;
        /**
         * @internal
         */
        _render(context: BABYLON.ICanvasRenderingContext, invalidatedRectangle?: BABYLON.Nullable<Measure>): boolean;
        /**
         * @internal
         */
        _draw(context: BABYLON.ICanvasRenderingContext, invalidatedRectangle?: BABYLON.Nullable<Measure>): void;
        /**
         * Tests if a given coordinates belong to the current control
         * @param x defines x coordinate to test
         * @param y defines y coordinate to test
         * @returns true if the coordinates are inside the control
         */
        contains(x: number, y: number): boolean;
        /**
         * @internal
         */
        _processPicking(x: number, y: number, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>, type: number, pointerId: number, buttonIndex: number, deltaX?: number, deltaY?: number): boolean;
        /**
         * @internal
         */
        _onPointerMove(target: Control, coordinates: BABYLON.Vector2, pointerId: number, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>): void;
        /**
         * @internal
         */
        _onPointerEnter(target: Control, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>): boolean;
        /**
         * @internal
         */
        _onPointerOut(target: Control, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>, force?: boolean): void;
        /**
         * @internal
         */
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>): boolean;
        /**
         * @internal
         */
        _onPointerUp(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, notifyClick: boolean, pi?: BABYLON.Nullable<BABYLON.PointerInfoBase>): void;
        /**
         * @internal
         */
        _forcePointerUp(pointerId?: BABYLON.Nullable<number>): void;
        /**
         * @internal
         */
        _onWheelScroll(deltaX?: number, deltaY?: number): void;
        /** @internal */
        _onCanvasBlur(): void;
        /**
         * @internal
         */
        _processObservables(type: number, x: number, y: number, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>, pointerId: number, buttonIndex: number, deltaX?: number, deltaY?: number): boolean;
        private _getStyleProperty;
        private _prepareFont;
        /**
         * A control has a dimension fully defined if that dimension doesn't depend on the parent's dimension.
         * As an example, a control that has dimensions in pixels is fully defined, while in percentage is not fully defined.
         * @param dim the dimension to check (width or height)
         * @returns if the dimension is fully defined
         */
        isDimensionFullyDefined(dim: "width" | "height"): boolean;
        /**
         * Gets the dimension of the control along a specified axis
         * @param dim the dimension to retrieve (width or height)
         * @returns the dimension value along the specified axis
         */
        getDimension(dim: "width" | "height"): ValueAndUnit;
        /**
         * Clones a control and its descendants
         * @param host the texture where the control will be instantiated. Can be empty, in which case the control will be created on the same texture
         * @returns the cloned control
         */
        clone(host?: AdvancedDynamicTexture): Control;
        /**
         * Parses a serialized object into this control
         * @param serializedObject the object with the serialized properties
         * @param host the texture where the control will be instantiated. Can be empty, in which case the control will be created on the same texture
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @returns this control
         */
        parse(serializedObject: any, host?: AdvancedDynamicTexture, urlRewriter?: (url: string) => string): Control;
        /**
         * Serializes the current control
         * @param serializationObject defined the JSON serialized object
         * @param force if the control should be serialized even if the isSerializable flag is set to false (default false)
         * @param allowCanvas defines if the control is allowed to use a Canvas2D object to serialize (true by default)
         */
        serialize(serializationObject: any, force?: boolean, allowCanvas?: boolean): void;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture, urlRewriter?: (url: string) => string): void;
        /** Releases associated resources */
        dispose(): void;
        private static _HORIZONTAL_ALIGNMENT_LEFT;
        private static _HORIZONTAL_ALIGNMENT_RIGHT;
        private static _HORIZONTAL_ALIGNMENT_CENTER;
        private static _VERTICAL_ALIGNMENT_TOP;
        private static _VERTICAL_ALIGNMENT_BOTTOM;
        private static _VERTICAL_ALIGNMENT_CENTER;
        /** HORIZONTAL_ALIGNMENT_LEFT */
        static get HORIZONTAL_ALIGNMENT_LEFT(): number;
        /** HORIZONTAL_ALIGNMENT_RIGHT */
        static get HORIZONTAL_ALIGNMENT_RIGHT(): number;
        /** HORIZONTAL_ALIGNMENT_CENTER */
        static get HORIZONTAL_ALIGNMENT_CENTER(): number;
        /** VERTICAL_ALIGNMENT_TOP */
        static get VERTICAL_ALIGNMENT_TOP(): number;
        /** VERTICAL_ALIGNMENT_BOTTOM */
        static get VERTICAL_ALIGNMENT_BOTTOM(): number;
        /** VERTICAL_ALIGNMENT_CENTER */
        static get VERTICAL_ALIGNMENT_CENTER(): number;
        private static _FontHeightSizes;
        /**
         * @internal
         */
        static _GetFontOffset(font: string, engineToUse?: BABYLON.AbstractEngine): {
            ascent: number;
            height: number;
            descent: number;
        };
        /**
         * Creates a Control from parsed data
         * @param serializedObject defines parsed data
         * @param host defines the hosting AdvancedDynamicTexture
         * @param urlRewriter defines an url rewriter to update urls before sending them to the controls
         * @returns a new Control
         */
        static Parse(serializedObject: any, host: AdvancedDynamicTexture, urlRewriter?: (url: string) => string): Control;
        static AddHeader: (control: Control, text: string, size: string | number, options: {
            isHorizontal: boolean;
            controlFirst: boolean;
        }) => any;
        /**
         * @internal
         */
        protected static drawEllipse(x: number, y: number, width: number, height: number, arc: number, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * Returns true if the control is ready to be used
         * @returns
         */
        isReady(): boolean;
    }


    /**
     * Root class for 2D containers
     * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#containers
     */
    export class Container extends Control {
        name?: string | undefined;
        /** @internal */
        _children: Control[];
        /** @internal */
        protected _measureForChildren: Measure;
        /** @internal */
        protected _background: string;
        /** @internal */
        protected _backgroundGradient: BABYLON.Nullable<BaseGradient>;
        /** @internal */
        protected _adaptWidthToChildren: boolean;
        /** @internal */
        protected _adaptHeightToChildren: boolean;
        /** @internal */
        protected _renderToIntermediateTexture: boolean;
        /** @internal */
        protected _intermediateTexture: BABYLON.Nullable<BABYLON.DynamicTexture>;
        /**
         * Gets or sets a boolean indicating that the container will let internal controls handle picking instead of doing it directly using its bounding info
         */
        delegatePickingToChildren: boolean;
        /** Gets or sets boolean indicating if children should be rendered to an intermediate texture rather than directly to host, useful for alpha blending */
        get renderToIntermediateTexture(): boolean;
        set renderToIntermediateTexture(value: boolean);
        /**
         * Gets or sets a boolean indicating that layout cycle errors should be displayed on the console
         */
        logLayoutCycleErrors: boolean;
        /**
         * Gets or sets the number of layout cycles (a change involved by a control while evaluating the layout) allowed
         */
        maxLayoutCycle: number;
        /** Gets or sets a boolean indicating if the container should try to adapt to its children height */
        get adaptHeightToChildren(): boolean;
        set adaptHeightToChildren(value: boolean);
        /** Gets or sets a boolean indicating if the container should try to adapt to its children width */
        get adaptWidthToChildren(): boolean;
        set adaptWidthToChildren(value: boolean);
        /** Gets or sets background color */
        get background(): string;
        set background(value: string);
        /** Gets or sets background gradient color. Takes precedence over background */
        get backgroundGradient(): BABYLON.Nullable<BaseGradient>;
        set backgroundGradient(value: BABYLON.Nullable<BaseGradient>);
        /** Gets the list of children */
        get children(): Control[];
        get isReadOnly(): boolean;
        set isReadOnly(value: boolean);
        /**
         * Creates a new Container
         * @param name defines the name of the container
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        _flagDescendantsAsMatrixDirty(): void;
        /**
         * Gets a child using its name
         * @param name defines the child name to look for
         * @returns the child control if found
         */
        getChildByName(name: string): BABYLON.Nullable<Control>;
        /**
         * Gets a child using its type and its name
         * @param name defines the child name to look for
         * @param type defines the child type to look for
         * @returns the child control if found
         */
        getChildByType(name: string, type: string): BABYLON.Nullable<Control>;
        /**
         * Search for a specific control in children
         * @param control defines the control to look for
         * @returns true if the control is in child list
         */
        containsControl(control: Control): boolean;
        /**
         * Adds a new control to the current container
         * @param control defines the control to add
         * @returns the current container
         */
        addControl(control: BABYLON.Nullable<Control>): Container;
        /**
         * Removes all controls from the current container
         * @returns the current container
         */
        clearControls(): Container;
        /**
         * Removes a control from the current container
         * @param control defines the control to remove
         * @returns the current container
         */
        removeControl(control: Control): Container;
        /**
         * An event triggered when any control is added to this container.
         */
        onControlAddedObservable: BABYLON.Observable<BABYLON.Nullable<Control>>;
        /**
         * An event triggered when any control is removed from this container.
         */
        onControlRemovedObservable: BABYLON.Observable<BABYLON.Nullable<Control>>;
        /**
         * @internal
         */
        _reOrderControl(control: Control): void;
        /**
         * @internal
         */
        _offsetLeft(offset: number): void;
        /**
         * @internal
         */
        _offsetTop(offset: number): void;
        /** @internal */
        _markAllAsDirty(): void;
        protected _getBackgroundColor(context: BABYLON.ICanvasRenderingContext): string | CanvasGradient;
        /**
         * @internal
         */
        protected _localDraw(context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _link(host: AdvancedDynamicTexture): void;
        /** @internal */
        protected _beforeLayout(): void;
        /**
         * @internal
         */
        protected _processMeasures(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _layout(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): boolean;
        protected _postMeasure(): void;
        private _inverseTransformMatrix;
        private _inverseMeasure;
        /**
         * @internal
         */
        _draw(context: BABYLON.ICanvasRenderingContext, invalidatedRectangle?: Measure): void;
        getDescendantsToRef(results: Control[], directDescendantsOnly?: boolean, predicate?: (control: Control) => boolean): void;
        /**
         * @internal
         */
        _processPicking(x: number, y: number, pi: BABYLON.Nullable<BABYLON.PointerInfoBase>, type: number, pointerId: number, buttonIndex: number, deltaX?: number, deltaY?: number): boolean;
        /**
         * @internal
         */
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _getAdaptDimTo(dim: "width" | "height"): boolean;
        isDimensionFullyDefined(dim: "width" | "height"): boolean;
        /**
         * Serializes the current control
         * @param serializationObject defined the JSON serialized object
         * @param force force serialization even if isSerializable === false
         * @param allowCanvas defines if the control is allowed to use a Canvas2D object to serialize (true by default)
         */
        serialize(serializationObject: any, force?: boolean, allowCanvas?: boolean): void;
        /** Releases associated resources */
        dispose(): void;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture, urlRewriter?: (url: string) => string): void;
        isReady(): boolean;
    }


    /** Class used to create color pickers */
    export class ColorPicker extends Control {
        name?: string | undefined;
        private static _Epsilon;
        private _colorWheelCanvas;
        private _value;
        private _tmpColor;
        private _pointerStartedOnSquare;
        private _pointerStartedOnWheel;
        private _squareLeft;
        private _squareTop;
        private _squareSize;
        private _h;
        private _s;
        private _v;
        private _lastPointerDownId;
        /**
         * BABYLON.Observable raised when the value changes
         */
        onValueChangedObservable: BABYLON.Observable<BABYLON.Color3>;
        /** Gets or sets the color of the color picker */
        get value(): BABYLON.Color3;
        set value(value: BABYLON.Color3);
        /**
         * Gets or sets control width
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get width(): string | number;
        set width(value: string | number);
        /**
         * Gets or sets control height
         * @see https://doc.babylonjs.com/features/featuresDeepDive/gui/gui#position-and-size
         */
        get height(): string | number;
        /** Gets or sets control height */
        set height(value: string | number);
        /** Gets or sets control size */
        get size(): string | number;
        set size(value: string | number);
        /**
         * Creates a new ColorPicker
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        /**
         * @internal
         */
        protected _preMeasure(parentMeasure: Measure): void;
        private _updateSquareProps;
        private _drawGradientSquare;
        private _drawCircle;
        private _createColorWheelCanvas;
        /**
         * @internal
         */
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        private _pointerIsDown;
        private _updateValueFromPointer;
        private _isPointOnSquare;
        private _isPointOnWheel;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        _onPointerMove(target: Control, coordinates: BABYLON.Vector2, pointerId: number, pi: BABYLON.PointerInfoBase): void;
        _onPointerUp(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, notifyClick: boolean, pi: BABYLON.PointerInfoBase): void;
        _onCanvasBlur(): void;
        /**
         * This function expands the color picker by creating a color picker dialog with manual
         * color value input and the ability to save colors into an array to be used later in
         * subsequent launches of the dialogue.
         * @param advancedTexture defines the AdvancedDynamicTexture the dialog is assigned to
         * @param options defines size for dialog and options for saved colors. Also accepts last color picked as hex string and saved colors array as hex strings.
         * @param options.pickerWidth
         * @param options.pickerHeight
         * @param options.headerHeight
         * @param options.lastColor
         * @param options.swatchLimit
         * @param options.numSwatchesPerLine
         * @param options.savedColors
         * @returns picked color as a hex string and the saved colors array as hex strings.
         */
        static ShowPickerDialogAsync(advancedTexture: AdvancedDynamicTexture, options: {
            pickerWidth?: string;
            pickerHeight?: string;
            headerHeight?: string;
            lastColor?: string;
            swatchLimit?: number;
            numSwatchesPerLine?: number;
            savedColors?: Array<string>;
        }): Promise<{
            savedColors?: string[];
            pickedColor: string;
        }>;
    }


    /**
     * Class used to represent a 2D checkbox
     */
    export class Checkbox extends Control {
        name?: string | undefined;
        private _isChecked;
        private _background;
        private _checkSizeRatio;
        private _thickness;
        /** Gets or sets border thickness  */
        get thickness(): number;
        set thickness(value: number);
        /**
         * BABYLON.Observable raised when isChecked property changes
         */
        onIsCheckedChangedObservable: BABYLON.Observable<boolean>;
        /** Gets or sets a value indicating the ratio between overall size and check size */
        get checkSizeRatio(): number;
        set checkSizeRatio(value: number);
        /** Gets or sets background color */
        get background(): string;
        set background(value: string);
        /** Gets or sets a boolean indicating if the checkbox is checked or not */
        get isChecked(): boolean;
        set isChecked(value: boolean);
        /**
         * Creates a new CheckBox
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        /**
         * @internal
         */
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        /**
         * Utility function to easily create a checkbox with a header
         * @param title defines the label to use for the header
         * @param onValueChanged defines the callback to call when value changes
         * @returns a StackPanel containing the checkbox and a textBlock
         */
        static AddCheckBoxWithHeader(title: string, onValueChanged: (value: boolean) => void): StackPanel;
    }


    /**
     * Class used to create 2D buttons
     */
    export class Button extends Rectangle {
        name?: string | undefined;
        /**
         * Function called to generate a pointer enter animation
         */
        pointerEnterAnimation: () => void;
        /**
         * Function called to generate a pointer out animation
         */
        pointerOutAnimation: () => void;
        /**
         * Function called to generate a pointer down animation
         */
        pointerDownAnimation: () => void;
        /**
         * Function called to generate a pointer up animation
         */
        pointerUpAnimation: () => void;
        private _image;
        /**
         * Returns the image part of the button (if any)
         */
        get image(): BABYLON.Nullable<Image>;
        private _textBlock;
        /**
         * Returns the TextBlock part of the button (if any)
         */
        get textBlock(): BABYLON.Nullable<TextBlock>;
        /**
         * Creates a new Button
         * @param name defines the name of the button
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        /**
         * @internal
         */
        _processPicking(x: number, y: number, pi: BABYLON.PointerInfoBase, type: number, pointerId: number, buttonIndex: number, deltaX?: number, deltaY?: number): boolean;
        /**
         * @internal
         */
        _onPointerEnter(target: Control, pi: BABYLON.PointerInfoBase): boolean;
        /**
         * @internal
         */
        _onPointerOut(target: Control, pi: BABYLON.PointerInfoBase, force?: boolean): void;
        /**
         * @internal
         */
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        protected _getRectangleFill(context: BABYLON.ICanvasRenderingContext): string | CanvasGradient;
        /**
         * @internal
         */
        _onPointerUp(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, notifyClick: boolean, pi: BABYLON.PointerInfoBase): void;
        /**
         * Serializes the current button
         * @param serializationObject defines the JSON serialized object
         * @param force force serialization even if isSerializable === false
         */
        serialize(serializationObject: any, force: boolean): void;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture): void;
        /**
         * Creates a new button made with an image and a text
         * @param name defines the name of the button
         * @param text defines the text of the button
         * @param imageUrl defines the url of the image
         * @returns a new Button
         */
        static CreateImageButton(name: string, text: string, imageUrl: string): Button;
        /**
         * Creates a new button made with an image
         * @param name defines the name of the button
         * @param imageUrl defines the url of the image
         * @returns a new Button
         */
        static CreateImageOnlyButton(name: string, imageUrl: string): Button;
        /**
         * Creates a new button made with a text
         * @param name defines the name of the button
         * @param text defines the text of the button
         * @returns a new Button
         */
        static CreateSimpleButton(name: string, text: string): Button;
        /**
         * Creates a new button made with an image and a centered text
         * @param name defines the name of the button
         * @param text defines the text of the button
         * @param imageUrl defines the url of the image
         * @returns a new Button
         */
        static CreateImageWithCenterTextButton(name: string, text: string, imageUrl: string): Button;
    }


    /**
     * Class used to create slider controls
     */
    export class Slider extends BaseSlider {
        name?: string | undefined;
        private _background;
        private _borderColor;
        private _thumbColor;
        private _isThumbCircle;
        protected _displayValueBar: boolean;
        private _backgroundGradient;
        /** Gets or sets a boolean indicating if the value bar must be rendered */
        get displayValueBar(): boolean;
        set displayValueBar(value: boolean);
        /** Gets or sets border color */
        get borderColor(): string;
        set borderColor(value: string);
        /** Gets or sets background color */
        get background(): string;
        set background(value: string);
        /** Gets or sets background gradient */
        get backgroundGradient(): BABYLON.Nullable<BaseGradient>;
        set backgroundGradient(value: BABYLON.Nullable<BaseGradient>);
        /** Gets or sets thumb's color */
        get thumbColor(): string;
        set thumbColor(value: string);
        /** Gets or sets a boolean indicating if the thumb should be round or square */
        get isThumbCircle(): boolean;
        set isThumbCircle(value: boolean);
        /**
         * Creates a new Slider
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        protected _getBackgroundColor(context: BABYLON.ICanvasRenderingContext): string | CanvasGradient;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        serialize(serializationObject: any): void;
        /** @internal */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture): void;
    }


    /**
     * Class used to create slider controls
     */
    export class ScrollBar extends BaseSlider {
        name?: string | undefined;
        private _background;
        private _borderColor;
        private _tempMeasure;
        private _invertScrollDirection;
        private _backgroundGradient;
        /** Gets or sets border color */
        get borderColor(): string;
        set borderColor(value: string);
        /** Gets or sets background color */
        get background(): string;
        set background(value: string);
        /** Gets or sets background gradient. Takes precedence over gradient. */
        get backgroundGradient(): BABYLON.Nullable<BaseGradient>;
        set backgroundGradient(value: BABYLON.Nullable<BaseGradient>);
        /** Inverts the scrolling direction (default: false) */
        get invertScrollDirection(): boolean;
        set invertScrollDirection(invert: boolean);
        /**
         * Creates a new Slider
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        protected _getThumbThickness(): number;
        private _getBackgroundColor;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        private _first;
        private _originX;
        private _originY;
        /**
         * @internal
         */
        protected _updateValueFromPointer(x: number, y: number): void;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        serialize(serializationObject: any): void;
        _parseFromContent(serializationObject: any, host: AdvancedDynamicTexture): void;
    }


    /**
     * Class used to create slider controls
     */
    export class ImageScrollBar extends BaseSlider {
        name?: string | undefined;
        private _backgroundBaseImage;
        private _backgroundImage;
        private _thumbImage;
        private _thumbBaseImage;
        private _thumbLength;
        private _thumbHeight;
        private _barImageHeight;
        private _tempMeasure;
        private _invertScrollDirection;
        /** Number of 90° rotation to apply on the images when in vertical mode */
        num90RotationInVerticalMode: number;
        /** Inverts the scrolling direction (default: false) */
        get invertScrollDirection(): boolean;
        set invertScrollDirection(invert: boolean);
        /**
         * Gets or sets the image used to render the background for horizontal bar
         */
        get backgroundImage(): Image;
        set backgroundImage(value: Image);
        /**
         * Gets or sets the image used to render the thumb
         */
        get thumbImage(): Image;
        set thumbImage(value: Image);
        /**
         * Gets or sets the length of the thumb
         */
        get thumbLength(): number;
        set thumbLength(value: number);
        /**
         * Gets or sets the height of the thumb
         */
        get thumbHeight(): number;
        set thumbHeight(value: number);
        /**
         * Gets or sets the height of the bar image
         */
        get barImageHeight(): number;
        set barImageHeight(value: number);
        /**
         * Creates a new ImageScrollBar
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        protected _getThumbThickness(): number;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        private _first;
        private _originX;
        private _originY;
        /**
         * @internal
         */
        protected _updateValueFromPointer(x: number, y: number): void;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
    }


    /**
     * Class used to create slider controls based on images
     */
    export class ImageBasedSlider extends BaseSlider {
        name?: string | undefined;
        private _backgroundImage;
        private _thumbImage;
        private _valueBarImage;
        private _tempMeasure;
        get displayThumb(): boolean;
        set displayThumb(value: boolean);
        /**
         * Gets or sets the image used to render the background
         */
        get backgroundImage(): Image;
        set backgroundImage(value: Image);
        /**
         * Gets or sets the image used to render the value bar
         */
        get valueBarImage(): Image;
        set valueBarImage(value: Image);
        /**
         * Gets or sets the image used to render the thumb
         */
        get thumbImage(): Image;
        set thumbImage(value: Image);
        /**
         * Creates a new ImageBasedSlider
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        _draw(context: BABYLON.ICanvasRenderingContext): void;
        /**
         * Serializes the current control
         * @param serializationObject defined the JSON serialized object
         */
        serialize(serializationObject: any): void;
        /**
         * @internal
         */
        _parseFromContent(serializedObject: any, host: AdvancedDynamicTexture): void;
    }


    /**
     * Class used to create slider controls
     */
    export class BaseSlider extends Control {
        name?: string | undefined;
        protected _thumbWidth: ValueAndUnit;
        private _minimum;
        private _maximum;
        private _value;
        private _isVertical;
        protected _barOffset: ValueAndUnit;
        private _isThumbClamped;
        protected _displayThumb: boolean;
        private _step;
        private _lastPointerDownId;
        protected _effectiveBarOffset: number;
        protected _renderLeft: number;
        protected _renderTop: number;
        protected _renderWidth: number;
        protected _renderHeight: number;
        protected _backgroundBoxLength: number;
        protected _backgroundBoxThickness: number;
        protected _effectiveThumbThickness: number;
        /** BABYLON.Observable raised when the slider value changes */
        onValueChangedObservable: BABYLON.Observable<number>;
        /** Gets or sets a boolean indicating if the thumb must be rendered */
        get displayThumb(): boolean;
        set displayThumb(value: boolean);
        /** Gets or sets a step to apply to values (0 by default) */
        get step(): number;
        set step(value: number);
        /** Gets or sets main bar offset (ie. the margin applied to the value bar) */
        get barOffset(): string | number;
        /** Gets main bar offset in pixels*/
        get barOffsetInPixels(): number;
        set barOffset(value: string | number);
        /** Gets or sets thumb width */
        get thumbWidth(): string | number;
        /** Gets thumb width in pixels */
        get thumbWidthInPixels(): number;
        set thumbWidth(value: string | number);
        /** Gets or sets minimum value */
        get minimum(): number;
        set minimum(value: number);
        /** Gets or sets maximum value */
        get maximum(): number;
        set maximum(value: number);
        /** Gets or sets current value */
        get value(): number;
        set value(value: number);
        /**Gets or sets a boolean indicating if the slider should be vertical or horizontal */
        get isVertical(): boolean;
        set isVertical(value: boolean);
        /** Gets or sets a value indicating if the thumb can go over main bar extends */
        get isThumbClamped(): boolean;
        set isThumbClamped(value: boolean);
        /**
         * Creates a new BaseSlider
         * @param name defines the control name
         */
        constructor(name?: string | undefined);
        protected _getTypeName(): string;
        protected _getThumbPosition(): number;
        protected _getThumbThickness(type: string): number;
        protected _prepareRenderingData(type: string): void;
        private _pointerIsDown;
        /**
         * @internal
         */
        protected _updateValueFromPointer(x: number, y: number): void;
        _onPointerDown(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, pi: BABYLON.PointerInfoBase): boolean;
        _onPointerMove(target: Control, coordinates: BABYLON.Vector2, pointerId: number, pi: BABYLON.PointerInfoBase): void;
        _onPointerUp(target: Control, coordinates: BABYLON.Vector2, pointerId: number, buttonIndex: number, notifyClick: boolean): void;
        _onCanvasBlur(): void;
    }


    /**
     * Class used to hold a the container for ScrollViewer
     * @internal
     */
    export class _ScrollViewerWindow extends Container {
        parentClientWidth: number;
        parentClientHeight: number;
        private _freezeControls;
        private _parentMeasure;
        private _oldLeft;
        private _oldTop;
        get freezeControls(): boolean;
        set freezeControls(value: boolean);
        private _bucketWidth;
        private _bucketHeight;
        private _buckets;
        private _bucketLen;
        get bucketWidth(): number;
        get bucketHeight(): number;
        setBucketSizes(width: number, height: number): void;
        private _useBuckets;
        private _makeBuckets;
        private _dispatchInBuckets;
        private _updateMeasures;
        private _updateChildrenMeasures;
        private _restoreMeasures;
        /**
         * Creates a new ScrollViewerWindow
         * @param name of ScrollViewerWindow
         */
        constructor(name?: string);
        protected _getTypeName(): string;
        /**
         * @internal
         */
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        /**
         * @internal
         */
        _layout(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): boolean;
        private _scrollChildren;
        private _scrollChildrenWithBuckets;
        /**
         * @internal
         */
        _draw(context: BABYLON.ICanvasRenderingContext, invalidatedRectangle?: Measure): void;
        protected _postMeasure(): void;
    }


    /**
     * Class used to hold a viewer window and sliders in a grid
     */
    export class ScrollViewer extends Rectangle {
        private _grid;
        private _horizontalBarSpace;
        private _verticalBarSpace;
        private _dragSpace;
        private _horizontalBar;
        private _verticalBar;
        private _barColor;
        private _barBackground;
        private _barImage;
        private _horizontalBarImage;
        private _verticalBarImage;
        private _barBackgroundImage;
        private _horizontalBarBackgroundImage;
        private _verticalBarBackgroundImage;
        private _barSize;
        private _window;
        private _pointerIsOver;
        private _wheelPrecision;
        private _onWheelObserver;
        private _clientWidth;
        private _clientHeight;
        private _useImageBar;
        private _thumbLength;
        private _thumbHeight;
        private _barImageHeight;
        private _horizontalBarImageHeight;
        private _verticalBarImageHeight;
        private _oldWindowContentsWidth;
        private _oldWindowContentsHeight;
        /**
         * Gets the horizontal scrollbar
         */
        get horizontalBar(): ScrollBar | ImageScrollBar;
        /**
         * Gets the vertical scrollbar
         */
        get verticalBar(): ScrollBar | ImageScrollBar;
        /**
         * Adds a new control to the current container
         * @param control defines the control to add
         * @returns the current container
         */
        addControl(control: BABYLON.Nullable<Control>): Container;
        /**
         * Removes a control from the current container
         * @param control defines the control to remove
         * @returns the current container
         */
        removeControl(control: Control): Container;
        /** Gets the list of children */
        get children(): Control[];
        _flagDescendantsAsMatrixDirty(): void;
        /**
         * Freezes or unfreezes the controls in the window.
         * When controls are frozen, the scroll viewer can render a lot more quickly but updates to positions/sizes of controls
         * are not taken into account. If you want to change positions/sizes, unfreeze, perform the changes then freeze again
         */
        get freezeControls(): boolean;
        set freezeControls(value: boolean);
        /** Gets the bucket width */
        get bucketWidth(): number;
        /** Gets the bucket height */
        get bucketHeight(): number;
        /**
         * Sets the bucket sizes.
         * When freezeControls is true, setting a non-zero bucket size will improve performances by updating only
         * controls that are visible. The bucket sizes is used to subdivide (internally) the window area to smaller areas into which
         * controls are dispatched. So, the size should be roughly equals to the mean size of all the controls of
         * the window. To disable the usage of buckets, sets either width or height (or both) to 0.
         * Please note that using this option will raise the memory usage (the higher the bucket sizes, the less memory
         * used), that's why it is not enabled by default.
         * @param width width of the bucket
         * @param height height of the bucket
         */
        setBucketSizes(width: number, height: number): void;
        private _forceHorizontalBar;
        private _forceVerticalBar;
        /**
         * Forces the horizontal scroll bar to be displayed
         */
        get forceHorizontalBar(): boolean;
        set forceHorizontalBar(value: boolean);
        /**
         * Forces the vertical scroll bar to be displayed
         */
        get forceVerticalBar(): boolean;
        set forceVerticalBar(value: boolean);
        /**
         * Creates a new ScrollViewer
         * @param name of ScrollViewer
         * @param isImageBased
         */
        constructor(name?: string, isImageBased?: boolean);
        /** Reset the scroll viewer window to initial size */
        resetWindow(): void;
        protected _getTypeName(): string;
        private _buildClientSizes;
        protected _additionalProcessing(parentMeasure: Measure, context: BABYLON.ICanvasRenderingContext): void;
        protected _postMeasure(): void;
        /**
         * Gets or sets the mouse wheel precision
         * from 0 to 1 with a default value of 0.05
         * */
        get wheelPrecision(): number;
        set wheelPrecision(value: number);
        /** Gets or sets the scroll bar container background color */
        get scrollBackground(): string;
        set scrollBackground(color: string);
        /** Gets or sets the bar color */
        get barColor(): string;
        set barColor(color: string);
        /** Gets or sets the bar image */
        get thumbImage(): Image;
        set thumbImage(value: Image);
        /** Gets or sets the horizontal bar image */
        get horizontalThumbImage(): Image;
        set horizontalThumbImage(value: Image);
        /** Gets or sets the vertical bar image */
        get verticalThumbImage(): Image;
        set verticalThumbImage(value: Image);
        /** Gets or sets the size of the bar */
        get barSize(): number;
        set barSize(value: number);
        /** Gets or sets the length of the thumb */
        get thumbLength(): number;
        set thumbLength(value: number);
        /** Gets or sets the height of the thumb */
        get thumbHeight(): number;
        set thumbHeight(value: number);
        /** Gets or sets the height of the bar image */
        get barImageHeight(): number;
        set barImageHeight(value: number);
        /** Gets or sets the height of the horizontal bar image */
        get horizontalBarImageHeight(): number;
        set horizontalBarImageHeight(value: number);
        /** Gets or sets the height of the vertical bar image */
        get verticalBarImageHeight(): number;
        set verticalBarImageHeight(value: number);
        /** Gets or sets the bar background */
        get barBackground(): string;
        set barBackground(color: string);
        /** Gets or sets the bar background image */
        get barImage(): Image;
        set barImage(value: Image);
        /** Gets or sets the horizontal bar background image */
        get horizontalBarImage(): Image;
        set horizontalBarImage(value: Image);
        /** Gets or sets the vertical bar background image */
        get verticalBarImage(): Image;
        set verticalBarImage(value: Image);
        private _setWindowPosition;
        /** @internal */
        private _updateScroller;
        _link(host: AdvancedDynamicTexture): void;
        /**
         * @internal
         */
        private _addBar;
        /** @internal */
        private _attachWheel;
        _renderHighlightSpecific(context: BABYLON.ICanvasRenderingContext): void;
        /** Releases associated resources */
        dispose(): void;
    }


    /**
     * Gradient formed from two circles with their own centers and radius.
     * The coordinates of the circles centers are relative to the canvas' space, not to any control's space.
     * @see https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/createRadialGradient
     */
    export class RadialGradient extends BaseGradient {
        private _x0;
        private _y0;
        private _r0;
        private _x1;
        private _y1;
        private _r1;
        /**
         * Creates a new radial gradient
         * @param x0 x coordinate of the first circle's center
         * @param y0 y coordinate of the first circle's center
         * @param r0 radius of the first circle
         * @param x1 x coordinate of the second circle's center
         * @param y1 y coordinate of the second circle's center
         * @param r1 radius of the second circle
         */
        constructor(x0?: number, y0?: number, r0?: number, x1?: number, y1?: number, r1?: number);
        protected _createCanvasGradient(context: BABYLON.ICanvasRenderingContext): BABYLON.ICanvasGradient;
        /** x coordinate of the first circle's center */
        get x0(): number;
        /** x coordinate of the second circle's center */
        get x1(): number;
        /** y coordinate of the first circle's center */
        get y0(): number;
        /** y coordinate of the second circle's center */
        get y1(): number;
        /** radius of the first circle */
        get r0(): number;
        /** radius of the second circle */
        get r1(): number;
        /**
         * Class name of the gradient
         * @returns the class name of the gradient
         */
        getClassName(): string;
        /**
         * Serializes this gradient
         * @param serializationObject the object to serialize to
         */
        serialize(serializationObject: any): void;
        /**
         * Parses a gradient from a serialization object
         * @param serializationObject the object to parse from
         */
        parse(serializationObject: any): void;
    }


    /**
     * Gradient along a line that connects two coordinates.
     * These coordinates are relative to the canvas' space, not to any control's space.
     * @see https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/createLinearGradient
     */
    export class LinearGradient extends BaseGradient {
        private _x0;
        private _y0;
        private _x1;
        private _y1;
        /**
         * Creates a new linear gradient
         * @param x0
         * @param y0
         * @param x1
         * @param y1
         */
        constructor(x0?: number, y0?: number, x1?: number, y1?: number);
        protected _createCanvasGradient(context: BABYLON.ICanvasRenderingContext): BABYLON.ICanvasGradient;
        /** X axis coordinate of the starting point in the line */
        get x0(): number;
        /** X axis coordinate of the ending point in the line */
        get x1(): number;
        /** Y axis coordinate of the starting point in the line */
        get y0(): number;
        /** Y axis coordinate of the ending point in the line */
        get y1(): number;
        /**
         * Class name of the gradient
         * @returns the class name of the gradient
         */
        getClassName(): string;
        /**
         * Serializes this gradient
         * @param serializationObject the object to serialize to
         */
        serialize(serializationObject: any): void;
        /**
         * Parses a gradient from a serialization object
         * @param serializationObject the object to parse from
         */
        parse(serializationObject: any): void;
    }


    /**
     * Type that represents a single stop on the gradient.
     */
    export type GradientColorStop = {
        /**
         * Offset from the start where the color will be applied.
         */
        offset: number;
        /**
         * Color to be applied.
         */
        color: string;
    };
    /**
     * Class that serves as a base for all the gradients created from context.
     */
    export abstract class BaseGradient {
        private _colorStops;
        private _canvasGradient;
        private _context;
        private _gradientDirty;
        /**
         * Overwritten by child classes to create the canvas gradient.
         * @param context
         */
        protected abstract _createCanvasGradient(context: BABYLON.ICanvasRenderingContext): BABYLON.ICanvasGradient;
        private _addColorStopsToCanvasGradient;
        /**
         * If there are any changes or the context changed, regenerate the canvas gradient object. Else,
         * reuse the existing gradient.
         * @param context the context to create the gradient from
         * @returns the canvas gradient
         */
        getCanvasGradient(context: BABYLON.ICanvasRenderingContext): CanvasGradient;
        /**
         * Adds a new color stop to the gradient.
         * @param offset the offset of the stop on the gradient. Should be between 0 and 1
         * @param color the color of the stop
         */
        addColorStop(offset: number, color: string): void;
        /**
         * Removes an existing color stop with the specified offset from the gradient
         * @param offset the offset of the stop to be removed
         */
        removeColorStop(offset: number): void;
        /**
         * Removes all color stops from the gradient
         */
        clearColorStops(): void;
        /**
         * Color stops of the gradient
         */
        get colorStops(): GradientColorStop[];
        /**
         * @returns Type of the gradient
         */
        getClassName(): string;
        /**
         * Serialize into a json object
         * @param serializationObject object to serialize into
         */
        serialize(serializationObject: any): void;
        /**
         * Parse from json object
         * @param serializationObject object to parse from
         */
        parse(serializationObject: any): void;
    }



}


                