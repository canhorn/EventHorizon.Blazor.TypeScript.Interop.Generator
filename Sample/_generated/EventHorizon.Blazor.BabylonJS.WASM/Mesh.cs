/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Mesh : AbstractMesh, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal FRONTSIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.FRONTSIDE"
                );
            }
        }

        
        public static decimal BACKSIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.BACKSIDE"
                );
            }
        }

        
        public static decimal DOUBLESIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.DOUBLESIDE"
                );
            }
        }

        
        public static decimal DEFAULTSIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.DEFAULTSIDE"
                );
            }
        }

        
        public static decimal NO_CAP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.NO_CAP"
                );
            }
        }

        
        public static decimal CAP_START
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.CAP_START"
                );
            }
        }

        
        public static decimal CAP_END
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.CAP_END"
                );
            }
        }

        
        public static decimal CAP_ALL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.CAP_ALL"
                );
            }
        }

        
        public static decimal NO_FLIP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.NO_FLIP"
                );
            }
        }

        
        public static decimal FLIP_TILE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.FLIP_TILE"
                );
            }
        }

        
        public static decimal ROTATE_TILE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.ROTATE_TILE"
                );
            }
        }

        
        public static decimal FLIP_ROW
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.FLIP_ROW"
                );
            }
        }

        
        public static decimal ROTATE_ROW
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.ROTATE_ROW"
                );
            }
        }

        
        public static decimal FLIP_N_ROTATE_TILE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.FLIP_N_ROTATE_TILE"
                );
            }
        }

        
        public static decimal FLIP_N_ROTATE_ROW
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.FLIP_N_ROTATE_ROW"
                );
            }
        }

        
        public static decimal CENTER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.CENTER"
                );
            }
        }

        
        public static decimal LEFT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.LEFT"
                );
            }
        }

        
        public static decimal RIGHT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.RIGHT"
                );
            }
        }

        
        public static decimal TOP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.TOP"
                );
            }
        }

        
        public static decimal BOTTOM
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Mesh.BOTTOM"
                );
            }
        }
        #endregion

        #region Static Methods
        public static Mesh Parse(CachedEntity parsedMesh, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "Parse" }, parsedMesh, scene, rootUrl
                }
            );
        }

        public static Mesh CreateRibbon(string name, Vector3[] pathArray, bool closeArray, bool closePath, decimal offset, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateRibbon" }, name, pathArray, closeArray, closePath, offset, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static Mesh CreateDisc(string name, decimal radius, decimal tessellation, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateDisc" }, name, radius, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateBox(string name, decimal size, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateBox" }, name, size, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateSphere(string name, decimal segments, decimal diameter, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateSphere" }, name, segments, diameter, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateHemisphere(string name, decimal segments, decimal diameter, Scene scene = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateHemisphere" }, name, segments, diameter, scene
                }
            );
        }

        public static Mesh CreateCylinder(string name, decimal height, decimal diameterTop, decimal diameterBottom, decimal tessellation, CachedEntity subdivisions, Scene scene = null, CachedEntity updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateCylinder" }, name, height, diameterTop, diameterBottom, tessellation, subdivisions, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateTorus(string name, decimal diameter, decimal thickness, decimal tessellation, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTorus" }, name, diameter, thickness, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateTorusKnot(string name, decimal radius, decimal tube, decimal radialSegments, decimal tubularSegments, decimal p, decimal q, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTorusKnot" }, name, radius, tube, radialSegments, tubularSegments, p, q, scene, updatable, sideOrientation
                }
            );
        }

        public static LinesMesh CreateLines(string name, Vector3[] points, Scene scene = null, System.Nullable<bool> updatable = null, LinesMesh instance = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<LinesMesh>(
                entity => new LinesMesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateLines" }, name, points, scene, updatable, instance
                }
            );
        }

        public static LinesMesh CreateDashedLines(string name, Vector3[] points, decimal dashSize, decimal gapSize, decimal dashNb, Scene scene = null, System.Nullable<bool> updatable = null, LinesMesh instance = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<LinesMesh>(
                entity => new LinesMesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateDashedLines" }, name, points, dashSize, gapSize, dashNb, scene, updatable, instance
                }
            );
        }

        public static Mesh CreatePolygon(string name, Vector3[] shape, Scene scene, Vector3[] holes = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, CachedEntity earcutInjection = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreatePolygon" }, name, shape, scene, holes, updatable, sideOrientation, earcutInjection
                }
            );
        }

        public static Mesh ExtrudePolygon(string name, Vector3[] shape, decimal depth, Scene scene, Vector3[] holes = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, CachedEntity earcutInjection = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "ExtrudePolygon" }, name, shape, depth, scene, holes, updatable, sideOrientation, earcutInjection
                }
            );
        }

        public static Mesh ExtrudeShape(string name, Vector3[] shape, Vector3[] path, decimal scale, decimal rotation, decimal cap, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "ExtrudeShape" }, name, shape, path, scale, rotation, cap, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static Mesh CreateLathe(string name, Vector3[] shape, decimal radius, decimal tessellation, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateLathe" }, name, shape, radius, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreatePlane(string name, decimal size, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreatePlane" }, name, size, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateGround(string name, decimal width, decimal height, decimal subdivisions, Scene scene = null, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateGround" }, name, width, height, subdivisions, scene, updatable
                }
            );
        }

        public static CachedEntity CreateTiledGround(string name, decimal xmin, decimal zmin, decimal xmax, decimal zmax, CachedEntity subdivisions, CachedEntity precision, Scene scene, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTiledGround" }, name, xmin, zmin, xmax, zmax, subdivisions, precision, scene, updatable
                }
            );
        }

        #region CreateGroundFromHeightMap TODO: Get Comments as metadata identification
        private static bool IsCreateGroundFromHeightMapEnabled = false;
        private static readonly IDictionary<string, Func<Task>> CreateGroundFromHeightMapActionMap = new Dictionary<string, Func<Task>>();

        public static string CreateGroundFromHeightMap(
            Func<Task> callback
        )
        {
            SetupCreateGroundFromHeightMapStaticLoop();

            var handle = Guid.NewGuid().ToString();
            CreateGroundFromHeightMapActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupCreateGroundFromHeightMapStaticLoop()
        {
            if (IsCreateGroundFromHeightMapEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Mesh.CreateGroundFromHeightMap",
                "CallCreateGroundFromHeightMapStaticActions"
            );
            IsCreateGroundFromHeightMapEnabled = true;
        }

        [JSInvokable]
        public static async Task CallCreateGroundFromHeightMapStaticActions()
        {
            foreach (var action in CreateGroundFromHeightMapActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static CachedEntity CreateTube(string name, Vector3[] path, decimal radius, decimal tessellation, CachedEntity radiusFunction, decimal cap, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTube" }, name, path, radius, tessellation, radiusFunction, cap, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static CachedEntity CreatePolyhedron(string name, Scene scene, CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreatePolyhedron" }, name, options, scene
                }
            );
        }

        public static CachedEntity CreateIcoSphere(string name, Scene scene, CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateIcoSphere" }, name, options, scene
                }
            );
        }

        public static Mesh CreateDecal(string name, AbstractMesh sourceMesh, Vector3 position, Vector3 normal, Vector3 size, decimal angle)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateDecal" }, name, sourceMesh, position, normal, size, angle
                }
            );
        }

        public static CachedEntity MinMax(AbstractMesh[] meshes)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "MinMax" }, meshes
                }
            );
        }

        public static CachedEntity Center(CachedEntity meshesOrMinMaxVector)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "Center" }, meshesOrMinMaxVector
                }
            );
        }

        public static Mesh MergeMeshes(Mesh[] meshes, System.Nullable<bool> disposeSource = null, System.Nullable<bool> allow32BitsIndices = null, Mesh meshSubclass = null, System.Nullable<bool> subdivideWithSubMeshes = null, System.Nullable<bool> multiMultiMaterials = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "MergeMeshes" }, meshes, disposeSource, allow32BitsIndices, meshSubclass, subdivideWithSubMeshes, multiMultiMaterials
                }
            );
        }


        #endregion

        #region Accessors
        private Observable __onBeforeRenderObservable;
        public Observable onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeRenderObservable;
            }
        }

        private Observable __onBeforeBindObservable;
        public Observable onBeforeBindObservable
        {
            get
            {
            if(__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeBindObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeBindObservable;
            }
        }

        private Observable __onAfterRenderObservable;
        public Observable onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterRenderObservable;
            }
        }

        private Observable __onBeforeDrawObservable;
        public Observable onBeforeDrawObservable
        {
            get
            {
            if(__onBeforeDrawObservable == null)
            {
                __onBeforeDrawObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeDrawObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeDrawObservable;
            }
        }

        
        public bool hasInstances
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasInstances"
                );
            }
        }

        private MorphTargetManager __morphTargetManager;
        public MorphTargetManager morphTargetManager
        {
            get
            {
            if(__morphTargetManager == null)
            {
                __morphTargetManager = EventHorizonBlazorInteropt.GetClass<MorphTargetManager>(
                    this.___guid,
                    "morphTargetManager",
                    (entity) =>
                    {
                        return new MorphTargetManager(entity);
                    }
                );
            }
            return __morphTargetManager;
            }
            set
            {
__morphTargetManager = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "morphTargetManager",
                    value
                );
            }
        }

        private Mesh __source;
        public Mesh source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInteropt.GetClass<Mesh>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new Mesh(entity);
                    }
                );
            }
            return __source;
            }
        }

        
        public bool isUnIndexed
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isUnIndexed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isUnIndexed",
                    value
                );
            }
        }

        
        public decimal[] worldMatrixInstancedBuffer
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "worldMatrixInstancedBuffer"
                );
            }
        }

        
        public bool manualUpdateOfWorldMatrixInstancedBuffer
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "manualUpdateOfWorldMatrixInstancedBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "manualUpdateOfWorldMatrixInstancedBuffer",
                    value
                );
            }
        }

        
        public bool hasLODLevels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasLODLevels"
                );
            }
        }

        private Geometry __geometry;
        public Geometry geometry
        {
            get
            {
            if(__geometry == null)
            {
                __geometry = EventHorizonBlazorInteropt.GetClass<Geometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new Geometry(entity);
                    }
                );
            }
            return __geometry;
            }
        }

        
        public bool isBlocked
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBlocked"
                );
            }
        }

        
        public bool areNormalsFrozen
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "areNormalsFrozen"
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal delayLoadState
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "delayLoadState",
                    value
                );
            }
        }

        
        public InstancedMesh[] instances
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<InstancedMesh>(
                    this.___guid,
                    "instances",
                    (entity) =>
                    {
                        return new InstancedMesh(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "instances",
                    value
                );
            }
        }

        
        public string delayLoadingFile
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "delayLoadingFile"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "delayLoadingFile",
                    value
                );
            }
        }

        
        public decimal overrideMaterialSideOrientation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "overrideMaterialSideOrientation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "overrideMaterialSideOrientation",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Mesh() : base() { }

        public Mesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Mesh(
            string name, Scene scene = null, Node parent = null, Mesh source = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> clonePhysicsImpostor = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Mesh" },
                name, scene, parent, source, doNotCloneChildren, clonePhysicsImpostor
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region onLODLevelSelection TODO: Get Comments as metadata identification
        private bool _isOnLODLevelSelectionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onLODLevelSelectionActionMap = new Dictionary<string, Func<Task>>();

        public string onLODLevelSelection(
            Func<Task> callback
        )
        {
            SetupOnLODLevelSelectionLoop();

            var handle = Guid.NewGuid().ToString();
            _onLODLevelSelectionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupOnLODLevelSelectionLoop()
        {
            if (_isOnLODLevelSelectionEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "onLODLevelSelection",
                "CallOnLODLevelSelectionActions",
                _invokableReference
            );
            _isOnLODLevelSelectionEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnLODLevelSelectionActions()
        {
            foreach (var action in _onLODLevelSelectionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region instantiateHierarchy TODO: Get Comments as metadata identification
        private bool _isInstantiateHierarchyEnabled = false;
        private readonly IDictionary<string, Func<Task>> _instantiateHierarchyActionMap = new Dictionary<string, Func<Task>>();

        public string instantiateHierarchy(
            Func<Task> callback
        )
        {
            SetupInstantiateHierarchyLoop();

            var handle = Guid.NewGuid().ToString();
            _instantiateHierarchyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupInstantiateHierarchyLoop()
        {
            if (_isInstantiateHierarchyEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "instantiateHierarchy",
                "CallInstantiateHierarchyActions",
                _invokableReference
            );
            _isInstantiateHierarchyEnabled = true;
        }

        [JSInvokable]
        public async Task CallInstantiateHierarchyActions()
        {
            foreach (var action in _instantiateHierarchyActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public MeshLODLevel[] getLODLevels()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<MeshLODLevel>(
                entity => new MeshLODLevel(entity),
                new object[]
                {
                    new string[] { this.___guid, "getLODLevels" }
                }
            );
        }

        public Mesh addLODLevel(decimal distance, Mesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addLODLevel" }, distance, mesh
                }
            );
        }

        public Mesh getLODLevelAtDistance(decimal distance)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLODLevelAtDistance" }, distance
                }
            );
        }

        public Mesh removeLODLevel(Mesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeLODLevel" }, mesh
                }
            );
        }

        public AbstractMesh getLOD(Camera camera, BoundingSphere boundingSphere = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLOD" }, camera, boundingSphere
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal[] getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public VertexBuffer getVertexBuffer(string kind)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexBuffer>(
                entity => new VertexBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getVertexBuffer" }, kind
                }
            );
        }

        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public bool isVertexBufferUpdatable(string kind)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVertexBufferUpdatable" }, kind
                }
            );
        }

        public string[] getVerticesDataKinds()
        {
            return EventHorizonBlazorInteropt.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesDataKinds" }
                }
            );
        }

        public decimal getTotalIndices()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public decimal[] getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public bool isReady(System.Nullable<bool> completeCheck = null, System.Nullable<bool> forceInstanceSupport = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck, forceInstanceSupport
                }
            );
        }

        public Mesh freezeNormals()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "freezeNormals" }
                }
            );
        }

        public Mesh unfreezeNormals()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeNormals" }
                }
            );
        }

        public Mesh refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
                }
            );
        }

        public void subdivide(decimal count)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "subdivide" }, count
                }
            );
        }

        public AbstractMesh setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public void removeVerticesData(string kind)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeVerticesData" }, kind
                }
            );
        }

        public void markVerticesDataAsUpdatable(string kind, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markVerticesDataAsUpdatable" }, kind, updatable
                }
            );
        }

        public Mesh setVerticesBuffer(VertexBuffer buffer)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesBuffer" }, buffer
                }
            );
        }

        public AbstractMesh updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        #region updateMeshPositions TODO: Get Comments as metadata identification
        private bool _isUpdateMeshPositionsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateMeshPositionsActionMap = new Dictionary<string, Func<Task>>();

        public string updateMeshPositions(
            Func<Task> callback
        )
        {
            SetupUpdateMeshPositionsLoop();

            var handle = Guid.NewGuid().ToString();
            _updateMeshPositionsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateMeshPositionsLoop()
        {
            if (_isUpdateMeshPositionsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateMeshPositions",
                "CallUpdateMeshPositionsActions",
                _invokableReference
            );
            _isUpdateMeshPositionsEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateMeshPositionsActions()
        {
            foreach (var action in _updateMeshPositionsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Mesh makeGeometryUnique()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "makeGeometryUnique" }
                }
            );
        }

        public AbstractMesh setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
                }
            );
        }

        public AbstractMesh updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public Mesh toLeftHanded()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "toLeftHanded" }
                }
            );
        }

        #region registerBeforeRender TODO: Get Comments as metadata identification
        private bool _isRegisterBeforeRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _registerBeforeRenderActionMap = new Dictionary<string, Func<Task>>();

        public string registerBeforeRender(
            Func<Task> callback
        )
        {
            SetupRegisterBeforeRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _registerBeforeRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRegisterBeforeRenderLoop()
        {
            if (_isRegisterBeforeRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "registerBeforeRender",
                "CallRegisterBeforeRenderActions",
                _invokableReference
            );
            _isRegisterBeforeRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallRegisterBeforeRenderActions()
        {
            foreach (var action in _registerBeforeRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region unregisterBeforeRender TODO: Get Comments as metadata identification
        private bool _isUnregisterBeforeRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _unregisterBeforeRenderActionMap = new Dictionary<string, Func<Task>>();

        public string unregisterBeforeRender(
            Func<Task> callback
        )
        {
            SetupUnregisterBeforeRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _unregisterBeforeRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUnregisterBeforeRenderLoop()
        {
            if (_isUnregisterBeforeRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "unregisterBeforeRender",
                "CallUnregisterBeforeRenderActions",
                _invokableReference
            );
            _isUnregisterBeforeRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallUnregisterBeforeRenderActions()
        {
            foreach (var action in _unregisterBeforeRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region registerAfterRender TODO: Get Comments as metadata identification
        private bool _isRegisterAfterRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _registerAfterRenderActionMap = new Dictionary<string, Func<Task>>();

        public string registerAfterRender(
            Func<Task> callback
        )
        {
            SetupRegisterAfterRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _registerAfterRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRegisterAfterRenderLoop()
        {
            if (_isRegisterAfterRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "registerAfterRender",
                "CallRegisterAfterRenderActions",
                _invokableReference
            );
            _isRegisterAfterRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallRegisterAfterRenderActions()
        {
            foreach (var action in _registerAfterRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region unregisterAfterRender TODO: Get Comments as metadata identification
        private bool _isUnregisterAfterRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _unregisterAfterRenderActionMap = new Dictionary<string, Func<Task>>();

        public string unregisterAfterRender(
            Func<Task> callback
        )
        {
            SetupUnregisterAfterRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _unregisterAfterRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUnregisterAfterRenderLoop()
        {
            if (_isUnregisterAfterRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "unregisterAfterRender",
                "CallUnregisterAfterRenderActions",
                _invokableReference
            );
            _isUnregisterAfterRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallUnregisterAfterRenderActions()
        {
            foreach (var action in _unregisterAfterRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Mesh render(SubMesh subMesh, bool enableAlphaMode, AbstractMesh effectiveMeshReplacement = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "render" }, subMesh, enableAlphaMode, effectiveMeshReplacement
                }
            );
        }

        public void cleanMatrixWeights()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cleanMatrixWeights" }
                }
            );
        }

        public CachedEntity validateSkinning()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "validateSkinning" }
                }
            );
        }

        public bool isInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public Mesh setMaterialByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setMaterialByID" }, id
                }
            );
        }

        public IAnimatable[] getAnimatables()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<IAnimatable>(
                entity => new IAnimatableCachedEntity(entity),
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public Mesh bakeTransformIntoVertices(Matrix transform)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "bakeTransformIntoVertices" }, transform
                }
            );
        }

        public Mesh bakeCurrentTransformIntoVertices(System.Nullable<bool> bakeIndependenlyOfChildren = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "bakeCurrentTransformIntoVertices" }, bakeIndependenlyOfChildren
                }
            );
        }

        public Mesh clone(string name = null, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> clonePhysicsImpostor = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren, clonePhysicsImpostor
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        #region applyDisplacementMap TODO: Get Comments as metadata identification
        private bool _isApplyDisplacementMapEnabled = false;
        private readonly IDictionary<string, Func<Task>> _applyDisplacementMapActionMap = new Dictionary<string, Func<Task>>();

        public string applyDisplacementMap(
            Func<Task> callback
        )
        {
            SetupApplyDisplacementMapLoop();

            var handle = Guid.NewGuid().ToString();
            _applyDisplacementMapActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupApplyDisplacementMapLoop()
        {
            if (_isApplyDisplacementMapEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "applyDisplacementMap",
                "CallApplyDisplacementMapActions",
                _invokableReference
            );
            _isApplyDisplacementMapEnabled = true;
        }

        [JSInvokable]
        public async Task CallApplyDisplacementMapActions()
        {
            foreach (var action in _applyDisplacementMapActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Mesh applyDisplacementMapFromBuffer(decimal[] buffer, decimal heightMapWidth, decimal heightMapHeight, decimal minHeight, decimal maxHeight, Vector2 uvOffset = null, Vector2 uvScale = null, System.Nullable<bool> forceUpdate = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "applyDisplacementMapFromBuffer" }, buffer, heightMapWidth, heightMapHeight, minHeight, maxHeight, uvOffset, uvScale, forceUpdate
                }
            );
        }

        public Mesh convertToFlatShadedMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "convertToFlatShadedMesh" }
                }
            );
        }

        public Mesh convertToUnIndexedMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "convertToUnIndexedMesh" }
                }
            );
        }

        public Mesh flipFaces(System.Nullable<bool> flipNormals = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "flipFaces" }, flipNormals
                }
            );
        }

        public void increaseVertices(decimal numberPerEdge)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "increaseVertices" }, numberPerEdge
                }
            );
        }

        public void forceSharedVertices()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceSharedVertices" }
                }
            );
        }

        public InstancedMesh createInstance(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<InstancedMesh>(
                entity => new InstancedMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createInstance" }, name
                }
            );
        }

        public Mesh synchronizeInstances()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "synchronizeInstances" }
                }
            );
        }

        #region optimizeIndices TODO: Get Comments as metadata identification
        private bool _isOptimizeIndicesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _optimizeIndicesActionMap = new Dictionary<string, Func<Task>>();

        public string optimizeIndices(
            Func<Task> callback
        )
        {
            SetupOptimizeIndicesLoop();

            var handle = Guid.NewGuid().ToString();
            _optimizeIndicesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupOptimizeIndicesLoop()
        {
            if (_isOptimizeIndicesEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "optimizeIndices",
                "CallOptimizeIndicesActions",
                _invokableReference
            );
            _isOptimizeIndicesEnabled = true;
        }

        [JSInvokable]
        public async Task CallOptimizeIndicesActions()
        {
            foreach (var action in _optimizeIndicesActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void serialize(CachedEntity serializationObject)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializationObject
                }
            );
        }

        public decimal[] setPositionsForCPUSkinning()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setPositionsForCPUSkinning" }
                }
            );
        }

        public decimal[] setNormalsForCPUSkinning()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setNormalsForCPUSkinning" }
                }
            );
        }

        public Mesh applySkeleton(Skeleton skeleton)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "applySkeleton" }, skeleton
                }
            );
        }

        public void addInstance(InstancedMesh instance)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addInstance" }, instance
                }
            );
        }

        public void removeInstance(InstancedMesh instance)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeInstance" }, instance
                }
            );
        }
        #endregion
    }
}