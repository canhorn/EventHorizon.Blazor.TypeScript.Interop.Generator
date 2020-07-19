declare module Babylon {
    export class AbstractMesh { }
    export interface IGetSetVerticesData { }
    export interface Observable<Mesh> { }

    export class Engine {
        meshes(): Array<Mesh>;
    }

    export class Mesh extends AbstractMesh implements IGetSetVerticesData {
        /**
         * Mesh side orientation : usually the external or front surface
         */
        static readonly FRONTSIDE: number;
        /**
         * Mesh side orientation : usually the internal or back surface
         */
        static readonly BACKSIDE: number;
        /**
         * Mesh side orientation : both internal and external or front and back surfaces
         */
        static readonly DOUBLESIDE: number;
        /**
         * Mesh side orientation : by default, `FRONTSIDE`
         */
        static readonly DEFAULTSIDE: number;
        /**
         * Mesh cap setting : no cap
         */
        static readonly NO_CAP: number;
        /**
         * Mesh cap setting : one cap at the beginning of the mesh
         */
        static readonly CAP_START: number;
        /**
         * Mesh cap setting : one cap at the end of the mesh
         */
        static readonly CAP_END: number;
        /**
         * Mesh cap setting : two caps, one at the beginning  and one at the end of the mesh
         */
        static readonly CAP_ALL: number;
        /**
         * Mesh pattern setting : no flip or rotate
         */
        static readonly NO_FLIP: number;
        /**
         * Mesh pattern setting : flip (reflect in y axis) alternate tiles on each row or column
         */
        static readonly FLIP_TILE: number;
        /**
         * Mesh pattern setting : rotate (180degs) alternate tiles on each row or column
         */
        static readonly ROTATE_TILE: number;
        /**
         * Mesh pattern setting : flip (reflect in y axis) all tiles on alternate rows
         */
        static readonly FLIP_ROW: number;
        /**
         * Mesh pattern setting : rotate (180degs) all tiles on alternate rows
         */
        static readonly ROTATE_ROW: number;
        /**
         * Mesh pattern setting : flip and rotate alternate tiles on each row or column
         */
        static readonly FLIP_N_ROTATE_TILE: number;
        /**
         * Mesh pattern setting : rotate pattern and rotate
         */
        static readonly FLIP_N_ROTATE_ROW: number;
        /**
         * Mesh tile positioning : part tiles same on left/right or top/bottom
         */
        static readonly CENTER: number;
        /**
         * Mesh tile positioning : part tiles on left
         */
        static readonly LEFT: number;
        /**
         * Mesh tile positioning : part tiles on right
         */
        static readonly RIGHT: number;
        /**
         * Mesh tile positioning : part tiles on top
         */
        static readonly TOP: number;
        /**
         * Mesh tile positioning : part tiles on bottom
         */
        static readonly BOTTOM: number;
        /**
         * Gets the default side orientation.
         * @param orientation the orientation to value to attempt to get
         * @returns the default orientation
         * @hidden
         */
        static _GetDefaultSideOrientation(orientation?: number): number;
        private _internalMeshDataInfo;
        /**
         * An event triggered before rendering the mesh
         */
        get onBeforeRenderObservable(): Observable<Mesh>;
        /**
         * An event triggered before binding the mesh
         */
        get onBeforeBindObservable(): Observable<Mesh>;
        /**
        * An event triggered after rendering the mesh
        */
        get onAfterRenderObservable(): Observable<Mesh>;
        /**
        * An event triggered before drawing the mesh
        */
        get onBeforeDrawObservable(): Observable<Mesh>;
        private _onBeforeDrawObserver;
        /**
         * Sets a callback to call before drawing the mesh. It is recommended to use onBeforeDrawObservable instead
         */
        set onBeforeDraw(callback: () => void);
        get hasInstances(): boolean;
        /**
         * Gets the delay loading state of the mesh (when delay loading is turned on)
         * @see http://doc.babylonjs.com/how_to/using_the_incremental_loading_system
         */
        delayLoadState: number;
        /**
         * Gets the list of instances created from this mesh
         * it is not supposed to be modified manually.
         * Note also that the order of the InstancedMesh wihin the array is not significant and might change.
         * @see http://doc.babylonjs.com/how_to/how_to_use_instances
         */
        instances: InstancedMesh[];
        /**
         * Gets the file containing delay loading data for this mesh
         */
        delayLoadingFile: string;
        /** @hidden */
        _binaryInfo: any;
        /**
         * User defined function used to change how LOD level selection is done
         * @see http://doc.babylonjs.com/how_to/how_to_use_lod
         */
        onLODLevelSelection: (distance: number, mesh: Mesh, selectedLevel: Nullable<Mesh>) => void;
        /**
         * Gets or sets the morph target manager
         * @see http://doc.babylonjs.com/how_to/how_to_use_morphtargets
         */
        get morphTargetManager(): Nullable<MorphTargetManager>;
        set morphTargetManager(value: Nullable<MorphTargetManager>);
        /** @hidden */
        _creationDataStorage: Nullable<_CreationDataStorage>;
        /** @hidden */
        _geometry: Nullable<Geometry>;
        /** @hidden */
        _delayInfo: Array<string>;
        /** @hidden */
        _delayLoadingFunction: (any: any, mesh: Mesh) => void;
        /** @hidden */
        _instanceDataStorage: _InstanceDataStorage;
        private _effectiveMaterial;
        /** @hidden */
        _shouldGenerateFlatShading: boolean;
        /** @hidden */
        _originalBuilderSideOrientation: number;
        /**
         * Use this property to change the original side orientation defined at construction time
         */
        overrideMaterialSideOrientation: Nullable<number>;
        /**
         * Gets the source mesh (the one used to clone this one from)
         */
        get source(): Nullable<Mesh>;
        /**
         * Gets or sets a boolean indicating that this mesh does not use index buffer
         */
        get isUnIndexed(): boolean;
        set isUnIndexed(value: boolean);
        /** Gets the array buffer used to store the instanced buffer used for instances' world matrices */
        get worldMatrixInstancedBuffer(): Float32Array;
        /** Gets or sets a boolean indicating that the update of the instance buffer of the world matrices is manual */
        get manualUpdateOfWorldMatrixInstancedBuffer(): boolean;
        set manualUpdateOfWorldMatrixInstancedBuffer(value: boolean);
        /**
         * @constructor
         * @param name The value used by scene.getMeshByName() to do a lookup.
         * @param scene The scene to add this mesh to.
         * @param parent The parent of this mesh, if it has one
         * @param source An optional Mesh from which geometry is shared, cloned.
         * @param doNotCloneChildren When cloning, skip cloning child meshes of source, default False.
         *                  When false, achieved by calling a clone(), also passing False.
         *                  This will make creation of children, recursive.
         * @param clonePhysicsImpostor When cloning, include cloning mesh physics impostor, default True.
         */
        constructor(name: string, scene?: Nullable<Scene>, parent?: Nullable<Node>, source?: Nullable<Mesh>, doNotCloneChildren?: boolean, clonePhysicsImpostor?: boolean);
        instantiateHierarchy(newParent?: Nullable<TransformNode>, options?: {
            doNotInstantiate: boolean;
        }, onNewNodeCreated?: (source: TransformNode, clone: TransformNode) => void): Nullable<TransformNode>;
        /**
         * Gets the class name
         * @returns the string "Mesh".
         */
        getClassName(): string;
        /** @hidden */
        get _isMesh(): boolean;
        /**
         * Returns a description of this mesh
         * @param fullDetails define if full details about this mesh must be used
         * @returns a descriptive string representing this mesh
         */
        toString(fullDetails?: boolean): string;
        /** @hidden */
        _unBindEffect(): void;
        /**
         * Gets a boolean indicating if this mesh has LOD
         */
        get hasLODLevels(): boolean;
        /**
         * Gets the list of MeshLODLevel associated with the current mesh
         * @returns an array of MeshLODLevel
         */
        getLODLevels(): MeshLODLevel[];
        private _sortLODLevels;
        /**
         * Add a mesh as LOD level triggered at the given distance.
         * @see https://doc.babylonjs.com/how_to/how_to_use_lod
         * @param distance The distance from the center of the object to show this level
         * @param mesh The mesh to be added as LOD level (can be null)
         * @return This mesh (for chaining)
         */
        addLODLevel(distance: number, mesh: Nullable<Mesh>): Mesh;
        /**
         * Returns the LOD level mesh at the passed distance or null if not found.
         * @see https://doc.babylonjs.com/how_to/how_to_use_lod
         * @param distance The distance from the center of the object to show this level
         * @returns a Mesh or `null`
         */
        getLODLevelAtDistance(distance: number): Nullable<Mesh>;
        /**
         * Remove a mesh from the LOD array
         * @see https://doc.babylonjs.com/how_to/how_to_use_lod
         * @param mesh defines the mesh to be removed
         * @return This mesh (for chaining)
         */
        removeLODLevel(mesh: Mesh): Mesh;
        /**
         * Returns the registered LOD mesh distant from the parameter `camera` position if any, else returns the current mesh.
         * @see https://doc.babylonjs.com/how_to/how_to_use_lod
         * @param camera defines the camera to use to compute distance
         * @param boundingSphere defines a custom bounding sphere to use instead of the one from this mesh
         * @return This mesh (for chaining)
         */
        getLOD(camera: Camera, boundingSphere?: BoundingSphere): Nullable<AbstractMesh>;
        /**
         * Gets the mesh internal Geometry object
         */
        get geometry(): Nullable<Geometry>;
        /**
         * Returns the total number of vertices within the mesh geometry or zero if the mesh has no geometry.
         * @returns the total number of vertices
         */
        getTotalVertices(): number;
        /**
         * Returns the content of an associated vertex buffer
         * @param kind defines which buffer to read from (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @param copyWhenShared defines a boolean indicating that if the mesh geometry is shared among some other meshes, the returned array is a copy of the internal one
         * @param forceCopy defines a boolean forcing the copy of the buffer no matter what the value of copyWhenShared is
         * @returns a FloatArray or null if the mesh has no geometry or no vertex buffer for this kind.
         */
        getVerticesData(kind: string, copyWhenShared?: boolean, forceCopy?: boolean): Nullable<FloatArray>;
        /**
         * Returns the mesh VertexBuffer object from the requested `kind`
         * @param kind defines which buffer to read from (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.NormalKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @returns a FloatArray or null if the mesh has no vertex buffer for this kind.
         */
        getVertexBuffer(kind: string): Nullable<VertexBuffer>;
        /**
         * Tests if a specific vertex buffer is associated with this mesh
         * @param kind defines which buffer to check (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.NormalKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @returns a boolean
         */
        isVerticesDataPresent(kind: string): boolean;
        /**
         * Returns a boolean defining if the vertex data for the requested `kind` is updatable.
         * @param kind defines which buffer to check (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @returns a boolean
         */
        isVertexBufferUpdatable(kind: string): boolean;
        /**
         * Returns a string which contains the list of existing `kinds` of Vertex Data associated with this mesh.
         * @param kind defines which buffer to read from (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.NormalKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @returns an array of strings
         */
        getVerticesDataKinds(): string[];
        /**
         * Returns a positive integer : the total number of indices in this mesh geometry.
         * @returns the numner of indices or zero if the mesh has no geometry.
         */
        getTotalIndices(): number;
        /**
         * Returns an array of integers or a typed array (Int32Array, Uint32Array, Uint16Array) populated with the mesh indices.
         * @param copyWhenShared If true (default false) and and if the mesh geometry is shared among some other meshes, the returned array is a copy of the internal one.
         * @param forceCopy defines a boolean indicating that the returned array must be cloned upon returning it
         * @returns the indices array or an empty array if the mesh has no geometry
         */
        getIndices(copyWhenShared?: boolean, forceCopy?: boolean): Nullable<IndicesArray>;
        get isBlocked(): boolean;
        /**
         * Determine if the current mesh is ready to be rendered
         * @param completeCheck defines if a complete check (including materials and lights) has to be done (false by default)
         * @param forceInstanceSupport will check if the mesh will be ready when used with instances (false by default)
         * @returns true if all associated assets are ready (material, textures, shaders)
         */
        isReady(completeCheck?: boolean, forceInstanceSupport?: boolean): boolean;
        /**
         * Gets a boolean indicating if the normals aren't to be recomputed on next mesh `positions` array update. This property is pertinent only for updatable parametric shapes.
         */
        get areNormalsFrozen(): boolean;
        /**
         * This function affects parametric shapes on vertex position update only : ribbons, tubes, etc. It has no effect at all on other shapes. It prevents the mesh normals from being recomputed on next `positions` array update.
         * @returns the current mesh
         */
        freezeNormals(): Mesh;
        /**
         * This function affects parametric shapes on vertex position update only : ribbons, tubes, etc. It has no effect at all on other shapes. It reactivates the mesh normals computation if it was previously frozen
         * @returns the current mesh
         */
        unfreezeNormals(): Mesh;
        /**
         * Sets a value overriding the instance count. Only applicable when custom instanced InterleavedVertexBuffer are used rather than InstancedMeshs
         */
        set overridenInstanceCount(count: number);
        /** @hidden */
        _preActivate(): Mesh;
        /** @hidden */
        _preActivateForIntermediateRendering(renderId: number): Mesh;
        /** @hidden */
        _registerInstanceForRenderId(instance: InstancedMesh, renderId: number): Mesh;
        /**
         * This method recomputes and sets a new BoundingInfo to the mesh unless it is locked.
         * This means the mesh underlying bounding box and sphere are recomputed.
         * @param applySkeleton defines whether to apply the skeleton before computing the bounding info
         * @returns the current mesh
         */
        refreshBoundingInfo(applySkeleton?: boolean): Mesh;
        /** @hidden */
        _createGlobalSubMesh(force: boolean): Nullable<SubMesh>;
        /**
         * This function will subdivide the mesh into multiple submeshes
         * @param count defines the expected number of submeshes
         */
        subdivide(count: number): void;
        /**
         * Copy a FloatArray into a specific associated vertex buffer
         * @param kind defines which buffer to write to (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @param data defines the data source
         * @param updatable defines if the updated vertex buffer must be flagged as updatable
         * @param stride defines the data stride size (can be null)
         * @returns the current mesh
         */
        setVerticesData(kind: string, data: FloatArray, updatable?: boolean, stride?: number): AbstractMesh;
        /**
         * Delete a vertex buffer associated with this mesh
         * @param kind defines which buffer to delete (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         */
        removeVerticesData(kind: string): void;
        /**
         * Flags an associated vertex buffer as updatable
         * @param kind defines which buffer to use (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @param updatable defines if the updated vertex buffer must be flagged as updatable
         */
        markVerticesDataAsUpdatable(kind: string, updatable?: boolean): void;
        /**
         * Sets the mesh global Vertex Buffer
         * @param buffer defines the buffer to use
         * @returns the current mesh
         */
        setVerticesBuffer(buffer: VertexBuffer): Mesh;
        /**
         * Update a specific associated vertex buffer
         * @param kind defines which buffer to write to (positions, indices, normals, etc). Possible `kind` values :
         * - VertexBuffer.PositionKind
         * - VertexBuffer.UVKind
         * - VertexBuffer.UV2Kind
         * - VertexBuffer.UV3Kind
         * - VertexBuffer.UV4Kind
         * - VertexBuffer.UV5Kind
         * - VertexBuffer.UV6Kind
         * - VertexBuffer.ColorKind
         * - VertexBuffer.MatricesIndicesKind
         * - VertexBuffer.MatricesIndicesExtraKind
         * - VertexBuffer.MatricesWeightsKind
         * - VertexBuffer.MatricesWeightsExtraKind
         * @param data defines the data source
         * @param updateExtends defines if extends info of the mesh must be updated (can be null). This is mostly useful for "position" kind
         * @param makeItUnique defines if the geometry associated with the mesh must be cloned to make the change only for this mesh (and not all meshes associated with the same geometry)
         * @returns the current mesh
         */
        updateVerticesData(kind: string, data: FloatArray, updateExtends?: boolean, makeItUnique?: boolean): AbstractMesh;
        /**
         * This method updates the vertex positions of an updatable mesh according to the `positionFunction` returned values.
         * @see http://doc.babylonjs.com/how_to/how_to_dynamically_morph_a_mesh#other-shapes-updatemeshpositions
         * @param positionFunction is a simple JS function what is passed the mesh `positions` array. It doesn't need to return anything
         * @param computeNormals is a boolean (default true) to enable/disable the mesh normal recomputation after the vertex position update
         * @returns the current mesh
         */
        updateMeshPositions(positionFunction: (data: FloatArray) => void, computeNormals?: boolean): Mesh;
        /**
         * Creates a un-shared specific occurence of the geometry for the mesh.
         * @returns the current mesh
         */
        makeGeometryUnique(): Mesh;
        /**
         * Set the index buffer of this mesh
         * @param indices defines the source data
         * @param totalVertices defines the total number of vertices referenced by this index data (can be null)
         * @param updatable defines if the updated index buffer must be flagged as updatable (default is false)
         * @returns the current mesh
         */
        setIndices(indices: IndicesArray, totalVertices?: Nullable<number>, updatable?: boolean): AbstractMesh;
        /**
         * Update the current index buffer
         * @param indices defines the source data
         * @param offset defines the offset in the index buffer where to store the new data (can be null)
         * @param gpuMemoryOnly defines a boolean indicating that only the GPU memory must be updated leaving the CPU version of the indices unchanged (false by default)
         * @returns the current mesh
         */
        updateIndices(indices: IndicesArray, offset?: number, gpuMemoryOnly?: boolean): AbstractMesh;
        /**
         * Invert the geometry to move from a right handed system to a left handed one.
         * @returns the current mesh
         */
        toLeftHanded(): Mesh;
        /** @hidden */
        _bind(subMesh: SubMesh, effect: Effect, fillMode: number): Mesh;
        /** @hidden */
        _draw(subMesh: SubMesh, fillMode: number, instancesCount?: number): Mesh;
        /**
         * Registers for this mesh a javascript function called just before the rendering process
         * @param func defines the function to call before rendering this mesh
         * @returns the current mesh
         */
        registerBeforeRender(func: (mesh: AbstractMesh) => void): Mesh;
        /**
         * Disposes a previously registered javascript function called before the rendering
         * @param func defines the function to remove
         * @returns the current mesh
         */
        unregisterBeforeRender(func: (mesh: AbstractMesh) => void): Mesh;
        /**
         * Registers for this mesh a javascript function called just after the rendering is complete
         * @param func defines the function to call after rendering this mesh
         * @returns the current mesh
         */
        registerAfterRender(func: (mesh: AbstractMesh) => void): Mesh;
        /**
         * Disposes a previously registered javascript function called after the rendering.
         * @param func defines the function to remove
         * @returns the current mesh
         */
        unregisterAfterRender(func: (mesh: AbstractMesh) => void): Mesh;
        /** @hidden */
        _getInstancesRenderList(subMeshId: number, isReplacementMode?: boolean): _InstancesBatch;
        /** @hidden */
        _renderWithInstances(subMesh: SubMesh, fillMode: number, batch: _InstancesBatch, effect: Effect, engine: Engine): Mesh;
        /** @hidden */
        _processInstancedBuffers(visibleInstances: InstancedMesh[], renderSelf: boolean): void;
        /** @hidden */
        _processRendering(subMesh: SubMesh, effect: Effect, fillMode: number, batch: _InstancesBatch, hardwareInstancedRendering: boolean, onBeforeDraw: (isInstance: boolean, world: Matrix, effectiveMaterial?: Material) => void, effectiveMaterial?: Material): Mesh;
        /** @hidden */
        _rebuild(): void;
        /** @hidden */
        _freeze(): void;
        /** @hidden */
        _unFreeze(): void;
        /**
         * Triggers the draw call for the mesh. Usually, you don't need to call this method by your own because the mesh rendering is handled by the scene rendering manager
         * @param subMesh defines the subMesh to render
         * @param enableAlphaMode defines if alpha mode can be changed
         * @param effectiveMeshReplacement defines an optional mesh used to provide info for the rendering
         * @returns the current mesh
         */
        render(subMesh: SubMesh, enableAlphaMode: boolean, effectiveMeshReplacement?: AbstractMesh): Mesh;
        private _onBeforeDraw;
        /**
         *   Renormalize the mesh and patch it up if there are no weights
         *   Similar to normalization by adding the weights compute the reciprocal and multiply all elements, this wil ensure that everything adds to 1.
         *   However in the case of zero weights then we set just a single influence to 1.
         *   We check in the function for extra's present and if so we use the normalizeSkinWeightsWithExtras rather than the FourWeights version.
         */
        cleanMatrixWeights(): void;
        private normalizeSkinFourWeights;
        private normalizeSkinWeightsAndExtra;
        /**
         * ValidateSkinning is used to determine that a mesh has valid skinning data along with skin metrics, if missing weights,
         * or not normalized it is returned as invalid mesh the string can be used for console logs, or on screen messages to let
         * the user know there was an issue with importing the mesh
         * @returns a validation object with skinned, valid and report string
         */
        validateSkinning(): {
            skinned: boolean;
            valid: boolean;
            report: string;
        };
        /** @hidden */
        _checkDelayState(): Mesh;
        private _queueLoad;
        /**
         * Returns `true` if the mesh is within the frustum defined by the passed array of planes.
         * A mesh is in the frustum if its bounding box intersects the frustum
         * @param frustumPlanes defines the frustum to test
         * @returns true if the mesh is in the frustum planes
         */
        isInFrustum(frustumPlanes: Plane[]): boolean;
        /**
         * Sets the mesh material by the material or multiMaterial `id` property
         * @param id is a string identifying the material or the multiMaterial
         * @returns the current mesh
         */
        setMaterialByID(id: string): Mesh;
        /**
         * Returns as a new array populated with the mesh material and/or skeleton, if any.
         * @returns an array of IAnimatable
         */
        getAnimatables(): IAnimatable[];
        /**
         * Modifies the mesh geometry according to the passed transformation matrix.
         * This method returns nothing but it really modifies the mesh even if it's originally not set as updatable.
         * The mesh normals are modified using the same transformation.
         * Note that, under the hood, this method sets a new VertexBuffer each call.
         * @param transform defines the transform matrix to use
         * @see http://doc.babylonjs.com/resources/baking_transformations
         * @returns the current mesh
         */
        bakeTransformIntoVertices(transform: Matrix): Mesh;
        /**
         * Modifies the mesh geometry according to its own current World Matrix.
         * The mesh World Matrix is then reset.
         * This method returns nothing but really modifies the mesh even if it's originally not set as updatable.
         * Note that, under the hood, this method sets a new VertexBuffer each call.
         * @see http://doc.babylonjs.com/resources/baking_transformations
         * @param bakeIndependenlyOfChildren indicates whether to preserve all child nodes' World Matrix during baking
         * @returns the current mesh
         */
        bakeCurrentTransformIntoVertices(bakeIndependenlyOfChildren?: boolean): Mesh;
        /** @hidden */
        get _positions(): Nullable<Vector3[]>;
        /** @hidden */
        _resetPointsArrayCache(): Mesh;
        /** @hidden */
        _generatePointsArray(): boolean;
        /**
         * Returns a new Mesh object generated from the current mesh properties.
         * This method must not get confused with createInstance()
         * @param name is a string, the name given to the new mesh
         * @param newParent can be any Node object (default `null`)
         * @param doNotCloneChildren allows/denies the recursive cloning of the original mesh children if any (default `false`)
         * @param clonePhysicsImpostor allows/denies the cloning in the same time of the original mesh `body` used by the physics engine, if any (default `true`)
         * @returns a new mesh
         */
        clone(name?: string, newParent?: Nullable<Node>, doNotCloneChildren?: boolean, clonePhysicsImpostor?: boolean): Mesh;
        /**
         * Releases resources associated with this mesh.
         * @param doNotRecurse Set to true to not recurse into each children (recurse into each children by default)
         * @param disposeMaterialAndTextures Set to true to also dispose referenced materials and textures (false by default)
         */
        dispose(doNotRecurse?: boolean, disposeMaterialAndTextures?: boolean): void;
        /** @hidden */
        _disposeInstanceSpecificData(): void;
        /**
         * Modifies the mesh geometry according to a displacement map.
         * A displacement map is a colored image. Each pixel color value (actually a gradient computed from red, green, blue values) will give the displacement to apply to each mesh vertex.
         * The mesh must be set as updatable. Its internal geometry is directly modified, no new buffer are allocated.
         * @param url is a string, the URL from the image file is to be downloaded.
         * @param minHeight is the lower limit of the displacement.
         * @param maxHeight is the upper limit of the displacement.
         * @param onSuccess is an optional Javascript function to be called just after the mesh is modified. It is passed the modified mesh and must return nothing.
         * @param uvOffset is an optional vector2 used to offset UV.
         * @param uvScale is an optional vector2 used to scale UV.
         * @param forceUpdate defines whether or not to force an update of the generated buffers. This is useful to apply on a deserialized model for instance.
         * @returns the Mesh.
         */
        applyDisplacementMap(url: string, minHeight: number, maxHeight: number, onSuccess?: (mesh: Mesh) => void, uvOffset?: Vector2, uvScale?: Vector2, forceUpdate?: boolean): Mesh;
        /**
         * Modifies the mesh geometry according to a displacementMap buffer.
         * A displacement map is a colored image. Each pixel color value (actually a gradient computed from red, green, blue values) will give the displacement to apply to each mesh vertex.
         * The mesh must be set as updatable. Its internal geometry is directly modified, no new buffer are allocated.
         * @param buffer is a `Uint8Array` buffer containing series of `Uint8` lower than 255, the red, green, blue and alpha values of each successive pixel.
         * @param heightMapWidth is the width of the buffer image.
         * @param heightMapHeight is the height of the buffer image.
         * @param minHeight is the lower limit of the displacement.
         * @param maxHeight is the upper limit of the displacement.
         * @param onSuccess is an optional Javascript function to be called just after the mesh is modified. It is passed the modified mesh and must return nothing.
         * @param uvOffset is an optional vector2 used to offset UV.
         * @param uvScale is an optional vector2 used to scale UV.
         * @param forceUpdate defines whether or not to force an update of the generated buffers. This is useful to apply on a deserialized model for instance.
         * @returns the Mesh.
         */
        applyDisplacementMapFromBuffer(buffer: Uint8Array, heightMapWidth: number, heightMapHeight: number, minHeight: number, maxHeight: number, uvOffset?: Vector2, uvScale?: Vector2, forceUpdate?: boolean): Mesh;
        /**
         * Modify the mesh to get a flat shading rendering.
         * This means each mesh facet will then have its own normals. Usually new vertices are added in the mesh geometry to get this result.
         * Warning : the mesh is really modified even if not set originally as updatable and, under the hood, a new VertexBuffer is allocated.
         * @returns current mesh
         */
        convertToFlatShadedMesh(): Mesh;
        /**
         * This method removes all the mesh indices and add new vertices (duplication) in order to unfold facets into buffers.
         * In other words, more vertices, no more indices and a single bigger VBO.
         * The mesh is really modified even if not set originally as updatable. Under the hood, a new VertexBuffer is allocated.
         * @returns current mesh
         */
        convertToUnIndexedMesh(): Mesh;
        /**
         * Inverses facet orientations.
         * Warning : the mesh is really modified even if not set originally as updatable. A new VertexBuffer is created under the hood each call.
         * @param flipNormals will also inverts the normals
         * @returns current mesh
         */
        flipFaces(flipNormals?: boolean): Mesh;
        /**
         * Increase the number of facets and hence vertices in a mesh
         * Vertex normals are interpolated from existing vertex normals
         * Warning : the mesh is really modified even if not set originally as updatable. A new VertexBuffer is created under the hood each call.
         * @param numberPerEdge the number of new vertices to add to each edge of a facet, optional default 1
         */
        increaseVertices(numberPerEdge: number): void;
        /**
         * Force adjacent facets to share vertices and remove any facets that have all vertices in a line
         * This will undo any application of covertToFlatShadedMesh
         * Warning : the mesh is really modified even if not set originally as updatable. A new VertexBuffer is created under the hood each call.
         */
        forceSharedVertices(): void;
        /** @hidden */
        static _instancedMeshFactory(name: string, mesh: Mesh): InstancedMesh;
        /** @hidden */
        static _PhysicsImpostorParser(scene: Scene, physicObject: IPhysicsEnabledObject, jsonObject: any): PhysicsImpostor;
        /**
         * Creates a new InstancedMesh object from the mesh model.
         * @see http://doc.babylonjs.com/how_to/how_to_use_instances
         * @param name defines the name of the new instance
         * @returns a new InstancedMesh
         */
        createInstance(name: string): InstancedMesh;
        /**
         * Synchronises all the mesh instance submeshes to the current mesh submeshes, if any.
         * After this call, all the mesh instances have the same submeshes than the current mesh.
         * @returns the current mesh
         */
        synchronizeInstances(): Mesh;
        /**
         * Optimization of the mesh's indices, in case a mesh has duplicated vertices.
         * The function will only reorder the indices and will not remove unused vertices to avoid problems with submeshes.
         * This should be used together with the simplification to avoid disappearing triangles.
         * @param successCallback an optional success callback to be called after the optimization finished.
         * @returns the current mesh
         */
        optimizeIndices(successCallback?: (mesh?: Mesh) => void): Mesh;
        /**
         * Serialize current mesh
         * @param serializationObject defines the object which will receive the serialization data
         */
        serialize(serializationObject: any): void;
        /** @hidden */
        _syncGeometryWithMorphTargetManager(): void;
        /** @hidden */
        static _GroundMeshParser: (parsedMesh: any, scene: Scene) => Mesh;
        /**
         * Returns a new Mesh object parsed from the source provided.
         * @param parsedMesh is the source
         * @param scene defines the hosting scene
         * @param rootUrl is the root URL to prefix the `delayLoadingFile` property with
         * @returns a new Mesh
         */
        static Parse(parsedMesh: any, scene: Scene, rootUrl: string): Mesh;
        /**
         * Creates a ribbon mesh. Please consider using the same method from the MeshBuilder class instead
         * @see http://doc.babylonjs.com/how_to/parametric_shapes
         * @param name defines the name of the mesh to create
         * @param pathArray is a required array of paths, what are each an array of successive Vector3. The pathArray parameter depicts the ribbon geometry.
         * @param closeArray creates a seam between the first and the last paths of the path array (default is false)
         * @param closePath creates a seam between the first and the last points of each path of the path array
         * @param offset is taken in account only if the `pathArray` is containing a single path
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @param instance defines an instance of an existing Ribbon object to be updated with the passed `pathArray` parameter (http://doc.babylonjs.com/how_to/How_to_dynamically_morph_a_mesh#ribbon)
         * @returns a new Mesh
         */
        static CreateRibbon(name: string, pathArray: Vector3[][], closeArray: boolean, closePath: boolean, offset: number, scene?: Scene, updatable?: boolean, sideOrientation?: number, instance?: Mesh): Mesh;
        /**
          * Creates a plane polygonal mesh.  By default, this is a disc. Please consider using the same method from the MeshBuilder class instead
          * @param name defines the name of the mesh to create
          * @param radius sets the radius size (float) of the polygon (default 0.5)
          * @param tessellation sets the number of polygon sides (positive integer, default 64). So a tessellation valued to 3 will build a triangle, to 4 a square, etc
          * @param scene defines the hosting scene
          * @param updatable defines if the mesh must be flagged as updatable
          * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
          * @returns a new Mesh
          */
        static CreateDisc(name: string, radius: number, tessellation: number, scene?: Nullable<Scene>, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
         * Creates a box mesh. Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param size sets the size (float) of each box side (default 1)
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @returns a new Mesh
         */
        static CreateBox(name: string, size: number, scene?: Nullable<Scene>, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
          * Creates a sphere mesh. Please consider using the same method from the MeshBuilder class instead
          * @param name defines the name of the mesh to create
          * @param segments sets the sphere number of horizontal stripes (positive integer, default 32)
          * @param diameter sets the diameter size (float) of the sphere (default 1)
          * @param scene defines the hosting scene
          * @param updatable defines if the mesh must be flagged as updatable
          * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
          * @returns a new Mesh
          */
        static CreateSphere(name: string, segments: number, diameter: number, scene?: Scene, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
          * Creates a hemisphere mesh. Please consider using the same method from the MeshBuilder class instead
          * @param name defines the name of the mesh to create
          * @param segments sets the sphere number of horizontal stripes (positive integer, default 32)
          * @param diameter sets the diameter size (float) of the sphere (default 1)
          * @param scene defines the hosting scene
          * @returns a new Mesh
          */
        static CreateHemisphere(name: string, segments: number, diameter: number, scene?: Scene): Mesh;
        /**
         * Creates a cylinder or a cone mesh. Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param height sets the height size (float) of the cylinder/cone (float, default 2)
         * @param diameterTop set the top cap diameter (floats, default 1)
         * @param diameterBottom set the bottom cap diameter (floats, default 1). This value can't be zero
         * @param tessellation sets the number of cylinder sides (positive integer, default 24). Set it to 3 to get a prism for instance
         * @param subdivisions sets the number of rings along the cylinder height (positive integer, default 1)
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @returns a new Mesh
         */
        static CreateCylinder(name: string, height: number, diameterTop: number, diameterBottom: number, tessellation: number, subdivisions: any, scene?: Scene, updatable?: any, sideOrientation?: number): Mesh;
        /**
         * Creates a torus mesh. Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param diameter sets the diameter size (float) of the torus (default 1)
         * @param thickness sets the diameter size of the tube of the torus (float, default 0.5)
         * @param tessellation sets the number of torus sides (postive integer, default 16)
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @returns a new Mesh
         */
        static CreateTorus(name: string, diameter: number, thickness: number, tessellation: number, scene?: Scene, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
         * Creates a torus knot mesh. Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param radius sets the global radius size (float) of the torus knot (default 2)
         * @param tube sets the diameter size of the tube of the torus (float, default 0.5)
         * @param radialSegments sets the number of sides on each tube segments (positive integer, default 32)
         * @param tubularSegments sets the number of tubes to decompose the knot into (positive integer, default 32)
         * @param p the number of windings on X axis (positive integers, default 2)
         * @param q the number of windings on Y axis (positive integers, default 3)
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @returns a new Mesh
         */
        static CreateTorusKnot(name: string, radius: number, tube: number, radialSegments: number, tubularSegments: number, p: number, q: number, scene?: Scene, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
         * Creates a line mesh. Please consider using the same method from the MeshBuilder class instead.
         * @param name defines the name of the mesh to create
         * @param points is an array successive Vector3
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param instance is an instance of an existing LineMesh object to be updated with the passed `points` parameter (http://doc.babylonjs.com/how_to/How_to_dynamically_morph_a_mesh#lines-and-dashedlines).
         * @returns a new Mesh
         */
        static CreateLines(name: string, points: Vector3[], scene?: Nullable<Scene>, updatable?: boolean, instance?: Nullable<LinesMesh>): LinesMesh;
        /**
         * Creates a dashed line mesh. Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param points is an array successive Vector3
         * @param dashSize is the size of the dashes relatively the dash number (positive float, default 3)
         * @param gapSize is the size of the gap between two successive dashes relatively the dash number (positive float, default 1)
         * @param dashNb is the intended total number of dashes (positive integer, default 200)
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param instance is an instance of an existing LineMesh object to be updated with the passed `points` parameter (http://doc.babylonjs.com/how_to/How_to_dynamically_morph_a_mesh#lines-and-dashedlines)
         * @returns a new Mesh
         */
        static CreateDashedLines(name: string, points: Vector3[], dashSize: number, gapSize: number, dashNb: number, scene?: Nullable<Scene>, updatable?: boolean, instance?: LinesMesh): LinesMesh;
        /**
         * Creates a polygon mesh.Please consider using the same method from the MeshBuilder class instead
         * The polygon's shape will depend on the input parameters and is constructed parallel to a ground mesh.
         * The parameter `shape` is a required array of successive Vector3 representing the corners of the polygon in th XoZ plane, that is y = 0 for all vectors.
         * You can set the mesh side orientation with the values : Mesh.FRONTSIDE (default), Mesh.BACKSIDE or Mesh.DOUBLESIDE
         * The mesh can be set to updatable with the boolean parameter `updatable` (default false) if its internal geometry is supposed to change once created.
         * Remember you can only change the shape positions, not their number when updating a polygon.
         * @see http://doc.babylonjs.com/how_to/parametric_shapes#non-regular-polygon
         * @param name defines the name of the mesh to create
         * @param shape is a required array of successive Vector3 representing the corners of the polygon in th XoZ plane, that is y = 0 for all vectors
         * @param scene defines the hosting scene
         * @param holes is a required array of arrays of successive Vector3 used to defines holes in the polygon
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @param earcutInjection can be used to inject your own earcut reference
         * @returns a new Mesh
         */
        static CreatePolygon(name: string, shape: Vector3[], scene: Scene, holes?: Vector3[][], updatable?: boolean, sideOrientation?: number, earcutInjection?: any): Mesh;
        /**
         * Creates an extruded polygon mesh, with depth in the Y direction. Please consider using the same method from the MeshBuilder class instead.
         * @see http://doc.babylonjs.com/how_to/parametric_shapes#extruded-non-regular-polygon
         * @param name defines the name of the mesh to create
         * @param shape is a required array of successive Vector3 representing the corners of the polygon in th XoZ plane, that is y = 0 for all vectors
         * @param depth defines the height of extrusion
         * @param scene defines the hosting scene
         * @param holes is a required array of arrays of successive Vector3 used to defines holes in the polygon
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @param earcutInjection can be used to inject your own earcut reference
         * @returns a new Mesh
         */
        static ExtrudePolygon(name: string, shape: Vector3[], depth: number, scene: Scene, holes?: Vector3[][], updatable?: boolean, sideOrientation?: number, earcutInjection?: any): Mesh;
        /**
         * Creates an extruded shape mesh.
         * The extrusion is a parametric shape. It has no predefined shape. Its final shape will depend on the input parameters. Please consider using the same method from the MeshBuilder class instead
         * @see http://doc.babylonjs.com/how_to/parametric_shapes
         * @see http://doc.babylonjs.com/how_to/parametric_shapes#extruded-shapes
         * @param name defines the name of the mesh to create
         * @param shape is a required array of successive Vector3. This array depicts the shape to be extruded in its local space : the shape must be designed in the xOy plane and will be extruded along the Z axis
         * @param path is a required array of successive Vector3. This is the axis curve the shape is extruded along
         * @param scale is the value to scale the shape
         * @param rotation is the angle value to rotate the shape each step (each path point), from the former step (so rotation added each step) along the curve
         * @param cap sets the way the extruded shape is capped. Possible values : Mesh.NO_CAP (default), Mesh.CAP_START, Mesh.CAP_END, Mesh.CAP_ALL
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @param instance is an instance of an existing ExtrudedShape object to be updated with the passed `shape`, `path`, `scale` or `rotation` parameters (http://doc.babylonjs.com/how_to/How_to_dynamically_morph_a_mesh#extruded-shape)
         * @returns a new Mesh
         */
        static ExtrudeShape(name: string, shape: Vector3[], path: Vector3[], scale: number, rotation: number, cap: number, scene?: Nullable<Scene>, updatable?: boolean, sideOrientation?: number, instance?: Mesh): Mesh;
        /**
         * Creates an custom extruded shape mesh.
         * The custom extrusion is a parametric shape.
         * It has no predefined shape. Its final shape will depend on the input parameters.
         * Please consider using the same method from the MeshBuilder class instead
         * @see http://doc.babylonjs.com/how_to/parametric_shapes#extruded-shapes
         * @param name defines the name of the mesh to create
         * @param shape is a required array of successive Vector3. This array depicts the shape to be extruded in its local space : the shape must be designed in the xOy plane and will be extruded along the Z axis
         * @param path is a required array of successive Vector3. This is the axis curve the shape is extruded along
         * @param scaleFunction is a custom Javascript function called on each path point
         * @param rotationFunction is a custom Javascript function called on each path point
         * @param ribbonCloseArray forces the extrusion underlying ribbon to close all the paths in its `pathArray`
         * @param ribbonClosePath forces the extrusion underlying ribbon to close its `pathArray`
         * @param cap sets the way the extruded shape is capped. Possible values : Mesh.NO_CAP (default), Mesh.CAP_START, Mesh.CAP_END, Mesh.CAP_ALL
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @param instance is an instance of an existing ExtrudedShape object to be updated with the passed `shape`, `path`, `scale` or `rotation` parameters (http://doc.babylonjs.com/how_to/how_to_dynamically_morph_a_mesh#extruded-shape)
         * @returns a new Mesh
         */
        static ExtrudeShapeCustom(name: string, shape: Vector3[], path: Vector3[], scaleFunction: Function, rotationFunction: Function, ribbonCloseArray: boolean, ribbonClosePath: boolean, cap: number, scene: Scene, updatable?: boolean, sideOrientation?: number, instance?: Mesh): Mesh;
        /**
         * Creates lathe mesh.
         * The lathe is a shape with a symetry axis : a 2D model shape is rotated around this axis to design the lathe.
         * Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param shape is a required array of successive Vector3. This array depicts the shape to be rotated in its local space : the shape must be designed in the xOy plane and will be rotated around the Y axis. It's usually a 2D shape, so the Vector3 z coordinates are often set to zero
         * @param radius is the radius value of the lathe
         * @param tessellation is the side number of the lathe.
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @returns a new Mesh
         */
        static CreateLathe(name: string, shape: Vector3[], radius: number, tessellation: number, scene: Scene, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
         * Creates a plane mesh. Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param size sets the size (float) of both sides of the plane at once (default 1)
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @returns a new Mesh
         */
        static CreatePlane(name: string, size: number, scene: Scene, updatable?: boolean, sideOrientation?: number): Mesh;
        /**
         * Creates a ground mesh.
         * Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param width set the width of the ground
         * @param height set the height of the ground
         * @param subdivisions sets the number of subdivisions per side
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @returns a new Mesh
         */
        static CreateGround(name: string, width: number, height: number, subdivisions: number, scene?: Scene, updatable?: boolean): Mesh;
        /**
         * Creates a tiled ground mesh.
         * Please consider using the same method from the MeshBuilder class instead
         * @param name defines the name of the mesh to create
         * @param xmin set the ground minimum X coordinate
         * @param zmin set the ground minimum Y coordinate
         * @param xmax set the ground maximum X coordinate
         * @param zmax set the ground maximum Z coordinate
         * @param subdivisions is an object `{w: positive integer, h: positive integer}` (default `{w: 6, h: 6}`). `w` and `h` are the numbers of subdivisions on the ground width and height. Each subdivision is called a tile
         * @param precision is an object `{w: positive integer, h: positive integer}` (default `{w: 2, h: 2}`). `w` and `h` are the numbers of subdivisions on the ground width and height of each tile
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @returns a new Mesh
         */
        static CreateTiledGround(name: string, xmin: number, zmin: number, xmax: number, zmax: number, subdivisions: {
            w: number;
            h: number;
        }, precision: {
            w: number;
            h: number;
        }, scene: Scene, updatable?: boolean): Mesh;
        /**
         * Creates a ground mesh from a height map.
         * Please consider using the same method from the MeshBuilder class instead
         * @see http://doc.babylonjs.com/babylon101/height_map
         * @param name defines the name of the mesh to create
         * @param url sets the URL of the height map image resource
         * @param width set the ground width size
         * @param height set the ground height size
         * @param subdivisions sets the number of subdivision per side
         * @param minHeight is the minimum altitude on the ground
         * @param maxHeight is the maximum altitude on the ground
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param onReady  is a callback function that will be called  once the mesh is built (the height map download can last some time)
         * @param alphaFilter will filter any data where the alpha channel is below this value, defaults 0 (all data visible)
         * @returns a new Mesh
         */
        static CreateGroundFromHeightMap(name: string, url: string, width: number, height: number, subdivisions: number, minHeight: number, maxHeight: number, scene: Scene, updatable?: boolean, onReady?: (mesh: GroundMesh) => void, alphaFilter?: number): GroundMesh;
        /**
         * Creates a tube mesh.
         * The tube is a parametric shape.
         * It has no predefined shape. Its final shape will depend on the input parameters.
         * Please consider using the same method from the MeshBuilder class instead
         * @see http://doc.babylonjs.com/how_to/parametric_shapes
         * @param name defines the name of the mesh to create
         * @param path is a required array of successive Vector3. It is the curve used as the axis of the tube
         * @param radius sets the tube radius size
         * @param tessellation is the number of sides on the tubular surface
         * @param radiusFunction is a custom function. If it is not null, it overwrittes the parameter `radius`. This function is called on each point of the tube path and is passed the index `i` of the i-th point and the distance of this point from the first point of the path
         * @param cap sets the way the extruded shape is capped. Possible values : Mesh.NO_CAP (default), Mesh.CAP_START, Mesh.CAP_END, Mesh.CAP_ALL
         * @param scene defines the hosting scene
         * @param updatable defines if the mesh must be flagged as updatable
         * @param sideOrientation defines the mesh side orientation (http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation)
         * @param instance is an instance of an existing Tube object to be updated with the passed `pathArray` parameter (http://doc.babylonjs.com/how_to/How_to_dynamically_morph_a_mesh#tube)
         * @returns a new Mesh
         */
        static CreateTube(name: string, path: Vector3[], radius: number, tessellation: number, radiusFunction: {
            (i: number, distance: number): number;
        }, cap: number, scene: Scene, updatable?: boolean, sideOrientation?: number, instance?: Mesh): Mesh;
        /**
          * Creates a polyhedron mesh.
          * Please consider using the same method from the MeshBuilder class instead.
          * * The parameter `type` (positive integer, max 14, default 0) sets the polyhedron type to build among the 15 embbeded types. Please refer to the type sheet in the tutorial to choose the wanted type
          * * The parameter `size` (positive float, default 1) sets the polygon size
          * * You can overwrite the `size` on each dimension bu using the parameters `sizeX`, `sizeY` or `sizeZ` (positive floats, default to `size` value)
          * * You can build other polyhedron types than the 15 embbeded ones by setting the parameter `custom` (`polyhedronObject`, default null). If you set the parameter `custom`, this overwrittes the parameter `type`
          * * A `polyhedronObject` is a formatted javascript object. You'll find a full file with pre-set polyhedra here : https://github.com/BabylonJS/Extensions/tree/master/Polyhedron
          * * You can set the color and the UV of each side of the polyhedron with the parameters `faceColors` (Color4, default `(1, 1, 1, 1)`) and faceUV (Vector4, default `(0, 0, 1, 1)`)
          * * To understand how to set `faceUV` or `faceColors`, please read this by considering the right number of faces of your polyhedron, instead of only 6 for the box : https://doc.babylonjs.com/how_to/createbox_per_face_textures_and_colors
          * * The parameter `flat` (boolean, default true). If set to false, it gives the polyhedron a single global face, so less vertices and shared normals. In this case, `faceColors` and `faceUV` are ignored
          * * You can also set the mesh side orientation with the values : Mesh.FRONTSIDE (default), Mesh.BACKSIDE or Mesh.DOUBLESIDE
          * * If you create a double-sided mesh, you can choose what parts of the texture image to crop and stick respectively on the front and the back sides with the parameters `frontUVs` and `backUVs` (Vector4). Detail here : http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation
          * * The mesh can be set to updatable with the boolean parameter `updatable` (default false) if its internal geometry is supposed to change once created
          * @param name defines the name of the mesh to create
          * @param options defines the options used to create the mesh
          * @param scene defines the hosting scene
          * @returns a new Mesh
          */
        static CreatePolyhedron(name: string, options: {
            type?: number;
            size?: number;
            sizeX?: number;
            sizeY?: number;
            sizeZ?: number;
            custom?: any;
            faceUV?: Vector4[];
            faceColors?: Color4[];
            updatable?: boolean;
            sideOrientation?: number;
        }, scene: Scene): Mesh;
        /**
         * Creates a sphere based upon an icosahedron with 20 triangular faces which can be subdivided
         * * The parameter `radius` sets the radius size (float) of the icosphere (default 1)
         * * You can set some different icosphere dimensions, for instance to build an ellipsoid, by using the parameters `radiusX`, `radiusY` and `radiusZ` (all by default have the same value than `radius`)
         * * The parameter `subdivisions` sets the number of subdivisions (postive integer, default 4). The more subdivisions, the more faces on the icosphere whatever its size
         * * The parameter `flat` (boolean, default true) gives each side its own normals. Set it to false to get a smooth continuous light reflection on the surface
         * * You can also set the mesh side orientation with the values : Mesh.FRONTSIDE (default), Mesh.BACKSIDE or Mesh.DOUBLESIDE
         * * If you create a double-sided mesh, you can choose what parts of the texture image to crop and stick respectively on the front and the back sides with the parameters `frontUVs` and `backUVs` (Vector4). Detail here : http://doc.babylonjs.com/babylon101/discover_basic_elements#side-orientation
         * * The mesh can be set to updatable with the boolean parameter `updatable` (default false) if its internal geometry is supposed to change once created
         * @param name defines the name of the mesh
         * @param options defines the options used to create the mesh
         * @param scene defines the hosting scene
         * @returns a new Mesh
         * @see http://doc.babylonjs.com/how_to/polyhedra_shapes#icosphere
         */
        static CreateIcoSphere(name: string, options: {
            radius?: number;
            flat?: boolean;
            subdivisions?: number;
            sideOrientation?: number;
            updatable?: boolean;
        }, scene: Scene): Mesh;
        /**
         * Creates a decal mesh.
         * Please consider using the same method from the MeshBuilder class instead.
         * A decal is a mesh usually applied as a model onto the surface of another mesh
         * @param name  defines the name of the mesh
         * @param sourceMesh defines the mesh receiving the decal
         * @param position sets the position of the decal in world coordinates
         * @param normal sets the normal of the mesh where the decal is applied onto in world coordinates
         * @param size sets the decal scaling
         * @param angle sets the angle to rotate the decal
         * @returns a new Mesh
         */
        static CreateDecal(name: string, sourceMesh: AbstractMesh, position: Vector3, normal: Vector3, size: Vector3, angle: number): Mesh;
        /**
         * Prepare internal position array for software CPU skinning
         * @returns original positions used for CPU skinning. Useful for integrating Morphing with skeletons in same mesh
         */
        setPositionsForCPUSkinning(): Float32Array;
        /**
         * Prepare internal normal array for software CPU skinning
         * @returns original normals used for CPU skinning. Useful for integrating Morphing with skeletons in same mesh.
         */
        setNormalsForCPUSkinning(): Float32Array;
        /**
         * Updates the vertex buffer by applying transformation from the bones
         * @param skeleton defines the skeleton to apply to current mesh
         * @returns the current mesh
         */
        applySkeleton(skeleton: Skeleton): Mesh;
        /**
         * Returns an object containing a min and max Vector3 which are the minimum and maximum vectors of each mesh bounding box from the passed array, in the world coordinates
         * @param meshes defines the list of meshes to scan
         * @returns an object `{min:` Vector3`, max:` Vector3`}`
         */
        static MinMax(meshes: AbstractMesh[]): {
            min: Vector3;
            max: Vector3;
        };
        /**
         * Returns the center of the `{min:` Vector3`, max:` Vector3`}` or the center of MinMax vector3 computed from a mesh array
         * @param meshesOrMinMaxVector could be an array of meshes or a `{min:` Vector3`, max:` Vector3`}` object
         * @returns a vector3
         */
        static Center(meshesOrMinMaxVector: {
            min: Vector3;
            max: Vector3;
        } | AbstractMesh[]): Vector3;
        /**
         * Merge the array of meshes into a single mesh for performance reasons.
         * @param meshes defines he vertices source.  They should all be of the same material.  Entries can empty
         * @param disposeSource when true (default), dispose of the vertices from the source meshes
         * @param allow32BitsIndices when the sum of the vertices > 64k, this must be set to true
         * @param meshSubclass when set, vertices inserted into this Mesh.  Meshes can then be merged into a Mesh sub-class.
         * @param subdivideWithSubMeshes when true (false default), subdivide mesh to his subMesh array with meshes source.
         * @param multiMultiMaterials when true (false default), subdivide mesh and accept multiple multi materials, ignores subdivideWithSubMeshes.
         * @returns a new mesh
         */
        static MergeMeshes(meshes: Array<Mesh>, disposeSource?: boolean, allow32BitsIndices?: boolean, meshSubclass?: Mesh, subdivideWithSubMeshes?: boolean, multiMultiMaterials?: boolean): Nullable<Mesh>;
        /** @hidden */
        addInstance(instance: InstancedMesh): void;
        /** @hidden */
        removeInstance(instance: InstancedMesh): void;
    }
    export class Vector3 {
        /**
         * Defines the first coordinates (on X axis)
         */
        x: number;
        /**
         * Defines the second coordinates (on Y axis)
         */
        y: number;
        /**
         * Defines the third coordinates (on Z axis)
         */
        z: number;
        private static _UpReadOnly;
        private static _ZeroReadOnly;
        /**
         * Creates a new Vector3 object from the given x, y, z (floats) coordinates.
         * @param x defines the first coordinates (on X axis)
         * @param y defines the second coordinates (on Y axis)
         * @param z defines the third coordinates (on Z axis)
         */
        constructor(
            /**
             * Defines the first coordinates (on X axis)
             */
            x?: number,
            /**
             * Defines the second coordinates (on Y axis)
             */
            y?: number,
            /**
             * Defines the third coordinates (on Z axis)
             */
            z?: number);
        /**
         * Creates a string representation of the Vector3
         * @returns a string with the Vector3 coordinates.
         */
        toString(): string;
        /**
         * Gets the class name
         * @returns the string "Vector3"
         */
        getClassName(): string;
        /**
         * Creates the Vector3 hash code
         * @returns a number which tends to be unique between Vector3 instances
         */
        getHashCode(): number;
        /**
         * Creates an array containing three elements : the coordinates of the Vector3
         * @returns a new array of numbers
         */
        asArray(): number[];
        /**
         * Populates the given array or Float32Array from the given index with the successive coordinates of the Vector3
         * @param array defines the destination array
         * @param index defines the offset in the destination array
         * @returns the current Vector3
         */
        toArray(array: FloatArray, index?: number): Vector3;
        /**
         * Converts the current Vector3 into a quaternion (considering that the Vector3 contains Euler angles representation of a rotation)
         * @returns a new Quaternion object, computed from the Vector3 coordinates
         */
        toQuaternion(): Quaternion;
        /**
         * Adds the given vector to the current Vector3
         * @param otherVector defines the second operand
         * @returns the current updated Vector3
         */
        addInPlace(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Adds the given coordinates to the current Vector3
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the current updated Vector3
         */
        addInPlaceFromFloats(x: number, y: number, z: number): Vector3;
        /**
         * Gets a new Vector3, result of the addition the current Vector3 and the given vector
         * @param otherVector defines the second operand
         * @returns the resulting Vector3
         */
        add(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Adds the current Vector3 to the given one and stores the result in the vector "result"
         * @param otherVector defines the second operand
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        addToRef(otherVector: DeepImmutable<Vector3>, result: Vector3): Vector3;
        /**
         * Subtract the given vector from the current Vector3
         * @param otherVector defines the second operand
         * @returns the current updated Vector3
         */
        subtractInPlace(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Returns a new Vector3, result of the subtraction of the given vector from the current Vector3
         * @param otherVector defines the second operand
         * @returns the resulting Vector3
         */
        subtract(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Subtracts the given vector from the current Vector3 and stores the result in the vector "result".
         * @param otherVector defines the second operand
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        subtractToRef(otherVector: DeepImmutable<Vector3>, result: Vector3): Vector3;
        /**
         * Returns a new Vector3 set with the subtraction of the given floats from the current Vector3 coordinates
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the resulting Vector3
         */
        subtractFromFloats(x: number, y: number, z: number): Vector3;
        /**
         * Subtracts the given floats from the current Vector3 coordinates and set the given vector "result" with this result
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        subtractFromFloatsToRef(x: number, y: number, z: number, result: Vector3): Vector3;
        /**
         * Gets a new Vector3 set with the current Vector3 negated coordinates
         * @returns a new Vector3
         */
        negate(): Vector3;
        /**
         * Negate this vector in place
         * @returns this
         */
        negateInPlace(): Vector3;
        /**
         * Negate the current Vector3 and stores the result in the given vector "result" coordinates
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        negateToRef(result: Vector3): Vector3;
        /**
         * Multiplies the Vector3 coordinates by the float "scale"
         * @param scale defines the multiplier factor
         * @returns the current updated Vector3
         */
        scaleInPlace(scale: number): Vector3;
        /**
         * Returns a new Vector3 set with the current Vector3 coordinates multiplied by the float "scale"
         * @param scale defines the multiplier factor
         * @returns a new Vector3
         */
        scale(scale: number): Vector3;
        /**
         * Multiplies the current Vector3 coordinates by the float "scale" and stores the result in the given vector "result" coordinates
         * @param scale defines the multiplier factor
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        scaleToRef(scale: number, result: Vector3): Vector3;
        /**
         * Scale the current Vector3 values by a factor and add the result to a given Vector3
         * @param scale defines the scale factor
         * @param result defines the Vector3 object where to store the result
         * @returns the unmodified current Vector3
         */
        scaleAndAddToRef(scale: number, result: Vector3): Vector3;
        /**
         * Returns true if the current Vector3 and the given vector coordinates are strictly equal
         * @param otherVector defines the second operand
         * @returns true if both vectors are equals
         */
        equals(otherVector: DeepImmutable<Vector3>): boolean;
        /**
         * Returns true if the current Vector3 and the given vector coordinates are distant less than epsilon
         * @param otherVector defines the second operand
         * @param epsilon defines the minimal distance to define values as equals
         * @returns true if both vectors are distant less than epsilon
         */
        equalsWithEpsilon(otherVector: DeepImmutable<Vector3>, epsilon?: number): boolean;
        /**
         * Returns true if the current Vector3 coordinates equals the given floats
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns true if both vectors are equals
         */
        equalsToFloats(x: number, y: number, z: number): boolean;
        /**
         * Multiplies the current Vector3 coordinates by the given ones
         * @param otherVector defines the second operand
         * @returns the current updated Vector3
         */
        multiplyInPlace(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Returns a new Vector3, result of the multiplication of the current Vector3 by the given vector
         * @param otherVector defines the second operand
         * @returns the new Vector3
         */
        multiply(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Multiplies the current Vector3 by the given one and stores the result in the given vector "result"
         * @param otherVector defines the second operand
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        multiplyToRef(otherVector: DeepImmutable<Vector3>, result: Vector3): Vector3;
        /**
         * Returns a new Vector3 set with the result of the mulliplication of the current Vector3 coordinates by the given floats
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the new Vector3
         */
        multiplyByFloats(x: number, y: number, z: number): Vector3;
        /**
         * Returns a new Vector3 set with the result of the division of the current Vector3 coordinates by the given ones
         * @param otherVector defines the second operand
         * @returns the new Vector3
         */
        divide(otherVector: DeepImmutable<Vector3>): Vector3;
        /**
         * Divides the current Vector3 coordinates by the given ones and stores the result in the given vector "result"
         * @param otherVector defines the second operand
         * @param result defines the Vector3 object where to store the result
         * @returns the current Vector3
         */
        divideToRef(otherVector: DeepImmutable<Vector3>, result: Vector3): Vector3;
        /**
         * Divides the current Vector3 coordinates by the given ones.
         * @param otherVector defines the second operand
         * @returns the current updated Vector3
         */
        divideInPlace(otherVector: Vector3): Vector3;
        /**
         * Updates the current Vector3 with the minimal coordinate values between its and the given vector ones
         * @param other defines the second operand
         * @returns the current updated Vector3
         */
        minimizeInPlace(other: DeepImmutable<Vector3>): Vector3;
        /**
         * Updates the current Vector3 with the maximal coordinate values between its and the given vector ones.
         * @param other defines the second operand
         * @returns the current updated Vector3
         */
        maximizeInPlace(other: DeepImmutable<Vector3>): Vector3;
        /**
         * Updates the current Vector3 with the minimal coordinate values between its and the given coordinates
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the current updated Vector3
         */
        minimizeInPlaceFromFloats(x: number, y: number, z: number): Vector3;
        /**
         * Updates the current Vector3 with the maximal coordinate values between its and the given coordinates.
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the current updated Vector3
         */
        maximizeInPlaceFromFloats(x: number, y: number, z: number): Vector3;
        /**
         * Due to float precision, scale of a mesh could be uniform but float values are off by a small fraction
         * Check if is non uniform within a certain amount of decimal places to account for this
         * @param epsilon the amount the values can differ
         * @returns if the the vector is non uniform to a certain number of decimal places
         */
        isNonUniformWithinEpsilon(epsilon: number): boolean;
        /**
         * Gets a boolean indicating that the vector is non uniform meaning x, y or z are not all the same
         */
        get isNonUniform(): boolean;
        /**
         * Gets a new Vector3 from current Vector3 floored values
         * @returns a new Vector3
         */
        floor(): Vector3;
        /**
         * Gets a new Vector3 from current Vector3 floored values
         * @returns a new Vector3
         */
        fract(): Vector3;
        /**
         * Gets the length of the Vector3
         * @returns the length of the Vector3
         */
        length(): number;
        /**
         * Gets the squared length of the Vector3
         * @returns squared length of the Vector3
         */
        lengthSquared(): number;
        /**
         * Normalize the current Vector3.
         * Please note that this is an in place operation.
         * @returns the current updated Vector3
         */
        normalize(): Vector3;
        /**
         * Reorders the x y z properties of the vector in place
         * @param order new ordering of the properties (eg. for vector 1,2,3 with "ZYX" will produce 3,2,1)
         * @returns the current updated vector
         */
        reorderInPlace(order: string): this;
        /**
         * Rotates the vector around 0,0,0 by a quaternion
         * @param quaternion the rotation quaternion
         * @param result vector to store the result
         * @returns the resulting vector
         */
        rotateByQuaternionToRef(quaternion: Quaternion, result: Vector3): Vector3;
        /**
         * Rotates a vector around a given point
         * @param quaternion the rotation quaternion
         * @param point the point to rotate around
         * @param result vector to store the result
         * @returns the resulting vector
         */
        rotateByQuaternionAroundPointToRef(quaternion: Quaternion, point: Vector3, result: Vector3): Vector3;
        /**
         * Returns a new Vector3 as the cross product of the current vector and the "other" one
         * The cross product is then orthogonal to both current and "other"
         * @param other defines the right operand
         * @returns the cross product
         */
        cross(other: Vector3): Vector3;
        /**
         * Normalize the current Vector3 with the given input length.
         * Please note that this is an in place operation.
         * @param len the length of the vector
         * @returns the current updated Vector3
         */
        normalizeFromLength(len: number): Vector3;
        /**
         * Normalize the current Vector3 to a new vector
         * @returns the new Vector3
         */
        normalizeToNew(): Vector3;
        /**
         * Normalize the current Vector3 to the reference
         * @param reference define the Vector3 to update
         * @returns the updated Vector3
         */
        normalizeToRef(reference: DeepImmutable<Vector3>): Vector3;
        /**
         * Creates a new Vector3 copied from the current Vector3
         * @returns the new Vector3
         */
        clone(): Vector3;
        /**
         * Copies the given vector coordinates to the current Vector3 ones
         * @param source defines the source Vector3
         * @returns the current updated Vector3
         */
        copyFrom(source: DeepImmutable<Vector3>): Vector3;
        /**
         * Copies the given floats to the current Vector3 coordinates
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the current updated Vector3
         */
        copyFromFloats(x: number, y: number, z: number): Vector3;
        /**
         * Copies the given floats to the current Vector3 coordinates
         * @param x defines the x coordinate of the operand
         * @param y defines the y coordinate of the operand
         * @param z defines the z coordinate of the operand
         * @returns the current updated Vector3
         */
        set(x: number, y: number, z: number): Vector3;
        /**
         * Copies the given float to the current Vector3 coordinates
         * @param v defines the x, y and z coordinates of the operand
         * @returns the current updated Vector3
         */
        setAll(v: number): Vector3;
        /**
         * Get the clip factor between two vectors
         * @param vector0 defines the first operand
         * @param vector1 defines the second operand
         * @param axis defines the axis to use
         * @param size defines the size along the axis
         * @returns the clip factor
         */
        static GetClipFactor(vector0: DeepImmutable<Vector3>, vector1: DeepImmutable<Vector3>, axis: DeepImmutable<Vector3>, size: number): number;
        /**
         * Get angle between two vectors
         * @param vector0 angle between vector0 and vector1
         * @param vector1 angle between vector0 and vector1
         * @param normal direction of the normal
         * @return the angle between vector0 and vector1
         */
        static GetAngleBetweenVectors(vector0: DeepImmutable<Vector3>, vector1: DeepImmutable<Vector3>, normal: DeepImmutable<Vector3>): number;
        /**
         * Returns a new Vector3 set from the index "offset" of the given array
         * @param array defines the source array
         * @param offset defines the offset in the source array
         * @returns the new Vector3
         */
        static FromArray(array: DeepImmutable<ArrayLike<number>>, offset?: number): Vector3;
        /**
         * Returns a new Vector3 set from the index "offset" of the given Float32Array
         * @param array defines the source array
         * @param offset defines the offset in the source array
         * @returns the new Vector3
         * @deprecated Please use FromArray instead.
         */
        static FromFloatArray(array: DeepImmutable<Float32Array>, offset?: number): Vector3;
        /**
         * Sets the given vector "result" with the element values from the index "offset" of the given array
         * @param array defines the source array
         * @param offset defines the offset in the source array
         * @param result defines the Vector3 where to store the result
         */
        static FromArrayToRef(array: DeepImmutable<ArrayLike<number>>, offset: number, result: Vector3): void;
        /**
         * Sets the given vector "result" with the element values from the index "offset" of the given Float32Array
         * @param array defines the source array
         * @param offset defines the offset in the source array
         * @param result defines the Vector3 where to store the result
         * @deprecated Please use FromArrayToRef instead.
         */
        static FromFloatArrayToRef(array: DeepImmutable<Float32Array>, offset: number, result: Vector3): void;
        /**
         * Sets the given vector "result" with the given floats.
         * @param x defines the x coordinate of the source
         * @param y defines the y coordinate of the source
         * @param z defines the z coordinate of the source
         * @param result defines the Vector3 where to store the result
         */
        static FromFloatsToRef(x: number, y: number, z: number, result: Vector3): void;
        /**
         * Returns a new Vector3 set to (0.0, 0.0, 0.0)
         * @returns a new empty Vector3
         */
        static Zero(): Vector3;
        /**
         * Returns a new Vector3 set to (1.0, 1.0, 1.0)
         * @returns a new unit Vector3
         */
        static One(): Vector3;
        /**
         * Returns a new Vector3 set to (0.0, 1.0, 0.0)
         * @returns a new up Vector3
         */
        static Up(): Vector3;
        /**
         * Gets a up Vector3 that must not be updated
         */
        static get UpReadOnly(): DeepImmutable<Vector3>;
        /**
         * Gets a zero Vector3 that must not be updated
         */
        static get ZeroReadOnly(): DeepImmutable<Vector3>;
        /**
         * Returns a new Vector3 set to (0.0, -1.0, 0.0)
         * @returns a new down Vector3
         */
        static Down(): Vector3;
        /**
         * Returns a new Vector3 set to (0.0, 0.0, 1.0)
         * @returns a new forward Vector3
         */
        static Forward(): Vector3;
        /**
         * Returns a new Vector3 set to (0.0, 0.0, -1.0)
         * @returns a new forward Vector3
         */
        static Backward(): Vector3;
        /**
         * Returns a new Vector3 set to (1.0, 0.0, 0.0)
         * @returns a new right Vector3
         */
        static Right(): Vector3;
        /**
         * Returns a new Vector3 set to (-1.0, 0.0, 0.0)
         * @returns a new left Vector3
         */
        static Left(): Vector3;
        /**
         * Returns a new Vector3 set with the result of the transformation by the given matrix of the given vector.
         * This method computes tranformed coordinates only, not transformed direction vectors (ie. it takes translation in account)
         * @param vector defines the Vector3 to transform
         * @param transformation defines the transformation matrix
         * @returns the transformed Vector3
         */
        static TransformCoordinates(vector: DeepImmutable<Vector3>, transformation: DeepImmutable<Matrix>): Vector3;
        /**
         * Sets the given vector "result" coordinates with the result of the transformation by the given matrix of the given vector
         * This method computes tranformed coordinates only, not transformed direction vectors (ie. it takes translation in account)
         * @param vector defines the Vector3 to transform
         * @param transformation defines the transformation matrix
         * @param result defines the Vector3 where to store the result
         */
        static TransformCoordinatesToRef(vector: DeepImmutable<Vector3>, transformation: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Sets the given vector "result" coordinates with the result of the transformation by the given matrix of the given floats (x, y, z)
         * This method computes tranformed coordinates only, not transformed direction vectors
         * @param x define the x coordinate of the source vector
         * @param y define the y coordinate of the source vector
         * @param z define the z coordinate of the source vector
         * @param transformation defines the transformation matrix
         * @param result defines the Vector3 where to store the result
         */
        static TransformCoordinatesFromFloatsToRef(x: number, y: number, z: number, transformation: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Returns a new Vector3 set with the result of the normal transformation by the given matrix of the given vector
         * This methods computes transformed normalized direction vectors only (ie. it does not apply translation)
         * @param vector defines the Vector3 to transform
         * @param transformation defines the transformation matrix
         * @returns the new Vector3
         */
        static TransformNormal(vector: DeepImmutable<Vector3>, transformation: DeepImmutable<Matrix>): Vector3;
        /**
         * Sets the given vector "result" with the result of the normal transformation by the given matrix of the given vector
         * This methods computes transformed normalized direction vectors only (ie. it does not apply translation)
         * @param vector defines the Vector3 to transform
         * @param transformation defines the transformation matrix
         * @param result defines the Vector3 where to store the result
         */
        static TransformNormalToRef(vector: DeepImmutable<Vector3>, transformation: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Sets the given vector "result" with the result of the normal transformation by the given matrix of the given floats (x, y, z)
         * This methods computes transformed normalized direction vectors only (ie. it does not apply translation)
         * @param x define the x coordinate of the source vector
         * @param y define the y coordinate of the source vector
         * @param z define the z coordinate of the source vector
         * @param transformation defines the transformation matrix
         * @param result defines the Vector3 where to store the result
         */
        static TransformNormalFromFloatsToRef(x: number, y: number, z: number, transformation: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Returns a new Vector3 located for "amount" on the CatmullRom interpolation spline defined by the vectors "value1", "value2", "value3", "value4"
         * @param value1 defines the first control point
         * @param value2 defines the second control point
         * @param value3 defines the third control point
         * @param value4 defines the fourth control point
         * @param amount defines the amount on the spline to use
         * @returns the new Vector3
         */
        static CatmullRom(value1: DeepImmutable<Vector3>, value2: DeepImmutable<Vector3>, value3: DeepImmutable<Vector3>, value4: DeepImmutable<Vector3>, amount: number): Vector3;
        /**
         * Returns a new Vector3 set with the coordinates of "value", if the vector "value" is in the cube defined by the vectors "min" and "max"
         * If a coordinate value of "value" is lower than one of the "min" coordinate, then this "value" coordinate is set with the "min" one
         * If a coordinate value of "value" is greater than one of the "max" coordinate, then this "value" coordinate is set with the "max" one
         * @param value defines the current value
         * @param min defines the lower range value
         * @param max defines the upper range value
         * @returns the new Vector3
         */
        static Clamp(value: DeepImmutable<Vector3>, min: DeepImmutable<Vector3>, max: DeepImmutable<Vector3>): Vector3;
        /**
         * Sets the given vector "result" with the coordinates of "value", if the vector "value" is in the cube defined by the vectors "min" and "max"
         * If a coordinate value of "value" is lower than one of the "min" coordinate, then this "value" coordinate is set with the "min" one
         * If a coordinate value of "value" is greater than one of the "max" coordinate, then this "value" coordinate is set with the "max" one
         * @param value defines the current value
         * @param min defines the lower range value
         * @param max defines the upper range value
         * @param result defines the Vector3 where to store the result
         */
        static ClampToRef(value: DeepImmutable<Vector3>, min: DeepImmutable<Vector3>, max: DeepImmutable<Vector3>, result: Vector3): void;
        /**
         * Checks if a given vector is inside a specific range
         * @param v defines the vector to test
         * @param min defines the minimum range
         * @param max defines the maximum range
         */
        static CheckExtends(v: Vector3, min: Vector3, max: Vector3): void;
        /**
         * Returns a new Vector3 located for "amount" (float) on the Hermite interpolation spline defined by the vectors "value1", "tangent1", "value2", "tangent2"
         * @param value1 defines the first control point
         * @param tangent1 defines the first tangent vector
         * @param value2 defines the second control point
         * @param tangent2 defines the second tangent vector
         * @param amount defines the amount on the interpolation spline (between 0 and 1)
         * @returns the new Vector3
         */
        static Hermite(value1: DeepImmutable<Vector3>, tangent1: DeepImmutable<Vector3>, value2: DeepImmutable<Vector3>, tangent2: DeepImmutable<Vector3>, amount: number): Vector3;
        /**
         * Returns a new Vector3 located for "amount" (float) on the linear interpolation between the vectors "start" and "end"
         * @param start defines the start value
         * @param end defines the end value
         * @param amount max defines amount between both (between 0 and 1)
         * @returns the new Vector3
         */
        static Lerp(start: DeepImmutable<Vector3>, end: DeepImmutable<Vector3>, amount: number): Vector3;
        /**
         * Sets the given vector "result" with the result of the linear interpolation from the vector "start" for "amount" to the vector "end"
         * @param start defines the start value
         * @param end defines the end value
         * @param amount max defines amount between both (between 0 and 1)
         * @param result defines the Vector3 where to store the result
         */
        static LerpToRef(start: DeepImmutable<Vector3>, end: DeepImmutable<Vector3>, amount: number, result: Vector3): void;
        /**
         * Returns the dot product (float) between the vectors "left" and "right"
         * @param left defines the left operand
         * @param right defines the right operand
         * @returns the dot product
         */
        static Dot(left: DeepImmutable<Vector3>, right: DeepImmutable<Vector3>): number;
        /**
         * Returns a new Vector3 as the cross product of the vectors "left" and "right"
         * The cross product is then orthogonal to both "left" and "right"
         * @param left defines the left operand
         * @param right defines the right operand
         * @returns the cross product
         */
        static Cross(left: DeepImmutable<Vector3>, right: DeepImmutable<Vector3>): Vector3;
        /**
         * Sets the given vector "result" with the cross product of "left" and "right"
         * The cross product is then orthogonal to both "left" and "right"
         * @param left defines the left operand
         * @param right defines the right operand
         * @param result defines the Vector3 where to store the result
         */
        static CrossToRef(left: Vector3, right: Vector3, result: Vector3): void;
        /**
         * Returns a new Vector3 as the normalization of the given vector
         * @param vector defines the Vector3 to normalize
         * @returns the new Vector3
         */
        static Normalize(vector: DeepImmutable<Vector3>): Vector3;
        /**
         * Sets the given vector "result" with the normalization of the given first vector
         * @param vector defines the Vector3 to normalize
         * @param result defines the Vector3 where to store the result
         */
        static NormalizeToRef(vector: DeepImmutable<Vector3>, result: Vector3): void;
        /**
         * Project a Vector3 onto screen space
         * @param vector defines the Vector3 to project
         * @param world defines the world matrix to use
         * @param transform defines the transform (view x projection) matrix to use
         * @param viewport defines the screen viewport to use
         * @returns the new Vector3
         */
        static Project(vector: DeepImmutable<Vector3>, world: DeepImmutable<Matrix>, transform: DeepImmutable<Matrix>, viewport: DeepImmutable<Viewport>): Vector3;
        /** @hidden */
        static _UnprojectFromInvertedMatrixToRef(source: DeepImmutable<Vector3>, matrix: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Unproject from screen space to object space
         * @param source defines the screen space Vector3 to use
         * @param viewportWidth defines the current width of the viewport
         * @param viewportHeight defines the current height of the viewport
         * @param world defines the world matrix to use (can be set to Identity to go to world space)
         * @param transform defines the transform (view x projection) matrix to use
         * @returns the new Vector3
         */
        static UnprojectFromTransform(source: Vector3, viewportWidth: number, viewportHeight: number, world: DeepImmutable<Matrix>, transform: DeepImmutable<Matrix>): Vector3;
        /**
         * Unproject from screen space to object space
         * @param source defines the screen space Vector3 to use
         * @param viewportWidth defines the current width of the viewport
         * @param viewportHeight defines the current height of the viewport
         * @param world defines the world matrix to use (can be set to Identity to go to world space)
         * @param view defines the view matrix to use
         * @param projection defines the projection matrix to use
         * @returns the new Vector3
         */
        static Unproject(source: DeepImmutable<Vector3>, viewportWidth: number, viewportHeight: number, world: DeepImmutable<Matrix>, view: DeepImmutable<Matrix>, projection: DeepImmutable<Matrix>): Vector3;
        /**
         * Unproject from screen space to object space
         * @param source defines the screen space Vector3 to use
         * @param viewportWidth defines the current width of the viewport
         * @param viewportHeight defines the current height of the viewport
         * @param world defines the world matrix to use (can be set to Identity to go to world space)
         * @param view defines the view matrix to use
         * @param projection defines the projection matrix to use
         * @param result defines the Vector3 where to store the result
         */
        static UnprojectToRef(source: DeepImmutable<Vector3>, viewportWidth: number, viewportHeight: number, world: DeepImmutable<Matrix>, view: DeepImmutable<Matrix>, projection: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Unproject from screen space to object space
         * @param sourceX defines the screen space x coordinate to use
         * @param sourceY defines the screen space y coordinate to use
         * @param sourceZ defines the screen space z coordinate to use
         * @param viewportWidth defines the current width of the viewport
         * @param viewportHeight defines the current height of the viewport
         * @param world defines the world matrix to use (can be set to Identity to go to world space)
         * @param view defines the view matrix to use
         * @param projection defines the projection matrix to use
         * @param result defines the Vector3 where to store the result
         */
        static UnprojectFloatsToRef(sourceX: float, sourceY: float, sourceZ: float, viewportWidth: number, viewportHeight: number, world: DeepImmutable<Matrix>, view: DeepImmutable<Matrix>, projection: DeepImmutable<Matrix>, result: Vector3): void;
        /**
         * Gets the minimal coordinate values between two Vector3
         * @param left defines the first operand
         * @param right defines the second operand
         * @returns the new Vector3
         */
        static Minimize(left: DeepImmutable<Vector3>, right: DeepImmutable<Vector3>): Vector3;
        /**
         * Gets the maximal coordinate values between two Vector3
         * @param left defines the first operand
         * @param right defines the second operand
         * @returns the new Vector3
         */
        static Maximize(left: DeepImmutable<Vector3>, right: DeepImmutable<Vector3>): Vector3;
        /**
         * Returns the distance between the vectors "value1" and "value2"
         * @param value1 defines the first operand
         * @param value2 defines the second operand
         * @returns the distance
         */
        static Distance(value1: DeepImmutable<Vector3>, value2: DeepImmutable<Vector3>): number;
        /**
         * Returns the squared distance between the vectors "value1" and "value2"
         * @param value1 defines the first operand
         * @param value2 defines the second operand
         * @returns the squared distance
         */
        static DistanceSquared(value1: DeepImmutable<Vector3>, value2: DeepImmutable<Vector3>): number;
        /**
         * Returns a new Vector3 located at the center between "value1" and "value2"
         * @param value1 defines the first operand
         * @param value2 defines the second operand
         * @returns the new Vector3
         */
        static Center(value1: DeepImmutable<Vector3>, value2: DeepImmutable<Vector3>): Vector3;
        /**
         * Given three orthogonal normalized left-handed oriented Vector3 axis in space (target system),
         * RotationFromAxis() returns the rotation Euler angles (ex : rotation.x, rotation.y, rotation.z) to apply
         * to something in order to rotate it from its local system to the given target system
         * Note: axis1, axis2 and axis3 are normalized during this operation
         * @param axis1 defines the first axis
         * @param axis2 defines the second axis
         * @param axis3 defines the third axis
         * @returns a new Vector3
         */
        static RotationFromAxis(axis1: DeepImmutable<Vector3>, axis2: DeepImmutable<Vector3>, axis3: DeepImmutable<Vector3>): Vector3;
        /**
         * The same than RotationFromAxis but updates the given ref Vector3 parameter instead of returning a new Vector3
         * @param axis1 defines the first axis
         * @param axis2 defines the second axis
         * @param axis3 defines the third axis
         * @param ref defines the Vector3 where to store the result
         */
        static RotationFromAxisToRef(axis1: DeepImmutable<Vector3>, axis2: DeepImmutable<Vector3>, axis3: DeepImmutable<Vector3>, ref: Vector3): void;
    }
}