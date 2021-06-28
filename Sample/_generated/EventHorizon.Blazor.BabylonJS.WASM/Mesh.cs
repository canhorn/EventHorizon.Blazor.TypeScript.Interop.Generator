/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Mesh>))]
    public class Mesh : AbstractMesh, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal FRONTSIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FRONTSIDE"
                );
            }
        }

        
        public static decimal BACKSIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.BACKSIDE"
                );
            }
        }

        
        public static decimal DOUBLESIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.DOUBLESIDE"
                );
            }
        }

        
        public static decimal DEFAULTSIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.DEFAULTSIDE"
                );
            }
        }

        
        public static decimal NO_CAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.NO_CAP"
                );
            }
        }

        
        public static decimal CAP_START
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CAP_START"
                );
            }
        }

        
        public static decimal CAP_END
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CAP_END"
                );
            }
        }

        
        public static decimal CAP_ALL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CAP_ALL"
                );
            }
        }

        
        public static decimal NO_FLIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.NO_FLIP"
                );
            }
        }

        
        public static decimal FLIP_TILE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_TILE"
                );
            }
        }

        
        public static decimal ROTATE_TILE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.ROTATE_TILE"
                );
            }
        }

        
        public static decimal FLIP_ROW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_ROW"
                );
            }
        }

        
        public static decimal ROTATE_ROW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.ROTATE_ROW"
                );
            }
        }

        
        public static decimal FLIP_N_ROTATE_TILE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_N_ROTATE_TILE"
                );
            }
        }

        
        public static decimal FLIP_N_ROTATE_ROW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_N_ROTATE_ROW"
                );
            }
        }

        
        public static decimal CENTER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CENTER"
                );
            }
        }

        
        public static decimal LEFT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.LEFT"
                );
            }
        }

        
        public static decimal RIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.RIGHT"
                );
            }
        }

        
        public static decimal TOP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.TOP"
                );
            }
        }

        
        public static decimal BOTTOM
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.BOTTOM"
                );
            }
        }
        #endregion

        #region Static Methods
        public static Mesh Parse(object parsedMesh, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "Parse" }, parsedMesh, scene, rootUrl
                }
            );
        }

        public static Mesh CreateRibbon(string name, Vector3[][] pathArray, bool closeArray, bool closePath, decimal offset, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateRibbon" }, name, pathArray, closeArray, closePath, offset, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static Mesh CreateDisc(string name, decimal radius, decimal tessellation, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateDisc" }, name, radius, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateBox(string name, decimal size, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateBox" }, name, size, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateSphere(string name, decimal segments, decimal diameter, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateSphere" }, name, segments, diameter, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateHemisphere(string name, decimal segments, decimal diameter, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateHemisphere" }, name, segments, diameter, scene
                }
            );
        }

        public static Mesh CreateCylinder(string name, decimal height, decimal diameterTop, decimal diameterBottom, decimal tessellation, object subdivisions, Scene scene = null, object updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateCylinder" }, name, height, diameterTop, diameterBottom, tessellation, subdivisions, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateTorus(string name, decimal diameter, decimal thickness, decimal tessellation, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateTorus" }, name, diameter, thickness, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateTorusKnot(string name, decimal radius, decimal tube, decimal radialSegments, decimal tubularSegments, decimal p, decimal q, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateTorusKnot" }, name, radius, tube, radialSegments, tubularSegments, p, q, scene, updatable, sideOrientation
                }
            );
        }

        public static LinesMesh CreateLines(string name, Vector3[] points, Scene scene = null, System.Nullable<bool> updatable = null, LinesMesh instance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateLines" }, name, points, scene, updatable, instance
                }
            );
        }

        public static LinesMesh CreateDashedLines(string name, Vector3[] points, decimal dashSize, decimal gapSize, decimal dashNb, Scene scene = null, System.Nullable<bool> updatable = null, LinesMesh instance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateDashedLines" }, name, points, dashSize, gapSize, dashNb, scene, updatable, instance
                }
            );
        }

        public static Mesh CreatePolygon(string name, Vector3[] shape, Scene scene, Vector3[][] holes = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, object earcutInjection = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreatePolygon" }, name, shape, scene, holes, updatable, sideOrientation, earcutInjection
                }
            );
        }

        public static Mesh ExtrudePolygon(string name, Vector3[] shape, decimal depth, Scene scene, Vector3[][] holes = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, object earcutInjection = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "ExtrudePolygon" }, name, shape, depth, scene, holes, updatable, sideOrientation, earcutInjection
                }
            );
        }

        public static Mesh ExtrudeShape(string name, Vector3[] shape, Vector3[] path, decimal scale, decimal rotation, decimal cap, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "ExtrudeShape" }, name, shape, path, scale, rotation, cap, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static Mesh CreateLathe(string name, Vector3[] shape, decimal radius, decimal tessellation, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateLathe" }, name, shape, radius, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreatePlane(string name, decimal size, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreatePlane" }, name, size, scene, updatable, sideOrientation
                }
            );
        }

        public static Mesh CreateGround(string name, decimal width, decimal height, decimal subdivisions, Scene scene = null, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateGround" }, name, width, height, subdivisions, scene, updatable
                }
            );
        }

        public static Mesh CreateTiledGround(string name, decimal xmin, decimal zmin, decimal xmax, decimal zmax, object subdivisions, object precision, Scene scene, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateTiledGround" }, name, xmin, zmin, xmax, zmax, subdivisions, precision, scene, updatable
                }
            );
        }

        public static GroundMesh CreateGroundFromHeightMap(string name, string url, decimal width, decimal height, decimal subdivisions, decimal minHeight, decimal maxHeight, Scene scene, System.Nullable<bool> updatable = null, ActionCallback<GroundMesh> onReady = null, System.Nullable<decimal> alphaFilter = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateGroundFromHeightMap" }, name, url, width, height, subdivisions, minHeight, maxHeight, scene, updatable, onReady, alphaFilter
                }
            );
        }

        public static Mesh CreateTube(string name, Vector3[] path, decimal radius, decimal tessellation, object radiusFunction, decimal cap, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateTube" }, name, path, radius, tessellation, radiusFunction, cap, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static Mesh CreatePolyhedron(string name, object options, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreatePolyhedron" }, name, options, scene
                }
            );
        }

        public static Mesh CreateIcoSphere(string name, object options, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateIcoSphere" }, name, options, scene
                }
            );
        }

        public static Mesh CreateDecal(string name, AbstractMesh sourceMesh, Vector3 position, Vector3 normal, Vector3 size, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateDecal" }, name, sourceMesh, position, normal, size, angle
                }
            );
        }

        public static Mesh CreateCapsule(string name, ICreateCapsuleOptions options, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "CreateCapsule" }, name, options, scene
                }
            );
        }

        public static CachedEntity MinMax(AbstractMesh[] meshes)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "MinMax" }, meshes
                }
            );
        }

        public static Vector3 Center(AbstractMesh[] meshesOrMinMaxVector)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "Center" }, meshesOrMinMaxVector
                }
            );
        }

        public static Mesh MergeMeshes(Mesh[] meshes, System.Nullable<bool> disposeSource = null, System.Nullable<bool> allow32BitsIndices = null, Mesh meshSubclass = null, System.Nullable<bool> subdivideWithSubMeshes = null, System.Nullable<bool> multiMultiMaterials = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Mesh", "MergeMeshes" }, meshes, disposeSource, allow32BitsIndices, meshSubclass, subdivideWithSubMeshes, multiMultiMaterials
                }
            );
        }


        #endregion

        #region Accessors
        
        public bool computeBonesUsingShaders
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "computeBonesUsingShaders"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "computeBonesUsingShaders",
                    value
                );
            }
        }

        private Observable<Mesh> __onBeforeRenderObservable;
        public Observable<Mesh> onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Mesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeRenderObservable;
            }
        }

        private Observable<Mesh> __onBeforeBindObservable;
        public Observable<Mesh> onBeforeBindObservable
        {
            get
            {
            if(__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
                    this.___guid,
                    "onBeforeBindObservable",
                    (entity) =>
                    {
                        return new Observable<Mesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeBindObservable;
            }
        }

        private Observable<Mesh> __onAfterRenderObservable;
        public Observable<Mesh> onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Mesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderObservable;
            }
        }

        private Observable<Mesh> __onBeforeDrawObservable;
        public Observable<Mesh> onBeforeDrawObservable
        {
            get
            {
            if(__onBeforeDrawObservable == null)
            {
                __onBeforeDrawObservable = EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
                    this.___guid,
                    "onBeforeDrawObservable",
                    (entity) =>
                    {
                        return new Observable<Mesh>() { ___guid = entity.___guid };
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasInstances"
                );
            }
        }

        
        public bool hasThinInstances
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasThinInstances"
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
                __morphTargetManager = EventHorizonBlazorInterop.GetClass<MorphTargetManager>(
                    this.___guid,
                    "morphTargetManager",
                    (entity) =>
                    {
                        return new MorphTargetManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __morphTargetManager;
            }
            set
            {
__morphTargetManager = null;
                EventHorizonBlazorInterop.Set(
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
                __source = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __source;
            }
        }

        private Mesh __cloneMeshMap;
        public Mesh cloneMeshMap
        {
            get
            {
            if(__cloneMeshMap == null)
            {
                __cloneMeshMap = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "cloneMeshMap",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __cloneMeshMap;
            }
        }

        
        public bool isUnIndexed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUnIndexed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "worldMatrixInstancedBuffer"
                );
            }
        }

        
        public bool manualUpdateOfWorldMatrixInstancedBuffer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "manualUpdateOfWorldMatrixInstancedBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
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
                __geometry = EventHorizonBlazorInterop.GetClass<Geometry>(
                    this.___guid,
                    "geometry",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocked"
                );
            }
        }

        
        public bool areNormalsFrozen
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetArrayClass<InstancedMesh>(
                    this.___guid,
                    "instances",
                    (entity) =>
                    {
                        return new InstancedMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "delayLoadingFile"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overrideMaterialSideOrientation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            var entity = EventHorizonBlazorInterop.New(
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

        public bool onLODLevelSelection_Remove(
            string handle
        )
        {
            return _onLODLevelSelectionActionMap.Remove(
                handle
            );
        }

        private void SetupOnLODLevelSelectionLoop()
        {
            if (_isOnLODLevelSelectionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public TransformNode instantiateHierarchy(TransformNode newParent = null, object options = null, ActionCallback<TransformNode, TransformNode> onNewNodeCreated = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "instantiateHierarchy" }, newParent, options, onNewNodeCreated
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public MeshLODLevel[] getLODLevels()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<MeshLODLevel>(
                entity => new MeshLODLevel() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLODLevels" }
                }
            );
        }

        public Mesh addLODLevel(decimal distance, Mesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addLODLevel" }, distance, mesh
                }
            );
        }

        public Mesh getLODLevelAtDistance(decimal distance)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLODLevelAtDistance" }, distance
                }
            );
        }

        public Mesh removeLODLevel(Mesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeLODLevel" }, mesh
                }
            );
        }

        public AbstractMesh getLOD(Camera camera, BoundingSphere boundingSphere = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLOD" }, camera, boundingSphere
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal[] getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public VertexBuffer getVertexBuffer(string kind)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexBuffer>(
                entity => new VertexBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVertexBuffer" }, kind
                }
            );
        }

        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public bool isVertexBufferUpdatable(string kind)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVertexBufferUpdatable" }, kind
                }
            );
        }

        public string[] getVerticesDataKinds()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesDataKinds" }
                }
            );
        }

        public decimal getTotalIndices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public decimal[] getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public bool isReady(System.Nullable<bool> completeCheck = null, System.Nullable<bool> forceInstanceSupport = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }, completeCheck, forceInstanceSupport
                }
            );
        }

        public Mesh freezeNormals()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "freezeNormals" }
                }
            );
        }

        public Mesh unfreezeNormals()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unfreezeNormals" }
                }
            );
        }

        public Mesh refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
                }
            );
        }

        public void subdivide(decimal count)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "subdivide" }, count
                }
            );
        }

        public AbstractMesh setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public void removeVerticesData(string kind)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeVerticesData" }, kind
                }
            );
        }

        public void markVerticesDataAsUpdatable(string kind, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "markVerticesDataAsUpdatable" }, kind, updatable
                }
            );
        }

        public Mesh setVerticesBuffer(VertexBuffer buffer)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVerticesBuffer" }, buffer
                }
            );
        }

        public AbstractMesh updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public Mesh updateMeshPositions(ActionCallback<decimal[]> positionFunction, System.Nullable<bool> computeNormals = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateMeshPositions" }, positionFunction, computeNormals
                }
            );
        }

        public Mesh makeGeometryUnique()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "makeGeometryUnique" }
                }
            );
        }

        public AbstractMesh setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
                }
            );
        }

        public AbstractMesh updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public Mesh toLeftHanded()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toLeftHanded" }
                }
            );
        }

        public Mesh registerBeforeRender(ActionCallback<AbstractMesh> func)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerBeforeRender" }, func
                }
            );
        }

        public Mesh unregisterBeforeRender(ActionCallback<AbstractMesh> func)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unregisterBeforeRender" }, func
                }
            );
        }

        public Mesh registerAfterRender(ActionCallback<AbstractMesh> func)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerAfterRender" }, func
                }
            );
        }

        public Mesh unregisterAfterRender(ActionCallback<AbstractMesh> func)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unregisterAfterRender" }, func
                }
            );
        }

        public Mesh render(SubMesh subMesh, bool enableAlphaMode, AbstractMesh effectiveMeshReplacement = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "render" }, subMesh, enableAlphaMode, effectiveMeshReplacement
                }
            );
        }

        public void cleanMatrixWeights()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cleanMatrixWeights" }
                }
            );
        }

        public CachedEntity validateSkinning()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "validateSkinning" }
                }
            );
        }

        public bool isInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public Mesh setMaterialByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMaterialByID" }, id
                }
            );
        }

        public IAnimatableCachedEntity[] getAnimatables()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public Mesh bakeTransformIntoVertices(Matrix transform)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bakeTransformIntoVertices" }, transform
                }
            );
        }

        public Mesh bakeCurrentTransformIntoVertices(System.Nullable<bool> bakeIndependenlyOfChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "bakeCurrentTransformIntoVertices" }, bakeIndependenlyOfChildren
                }
            );
        }

        public Mesh clone(string name = null, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> clonePhysicsImpostor = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren, clonePhysicsImpostor
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public Mesh applyDisplacementMap(string url, decimal minHeight, decimal maxHeight, ActionCallback<Mesh> onSuccess = null, Vector2 uvOffset = null, Vector2 uvScale = null, System.Nullable<bool> forceUpdate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyDisplacementMap" }, url, minHeight, maxHeight, onSuccess, uvOffset, uvScale, forceUpdate
                }
            );
        }

        public Mesh applyDisplacementMapFromBuffer(decimal[] buffer, decimal heightMapWidth, decimal heightMapHeight, decimal minHeight, decimal maxHeight, Vector2 uvOffset = null, Vector2 uvScale = null, System.Nullable<bool> forceUpdate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyDisplacementMapFromBuffer" }, buffer, heightMapWidth, heightMapHeight, minHeight, maxHeight, uvOffset, uvScale, forceUpdate
                }
            );
        }

        public Mesh convertToFlatShadedMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "convertToFlatShadedMesh" }
                }
            );
        }

        public Mesh convertToUnIndexedMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "convertToUnIndexedMesh" }
                }
            );
        }

        public Mesh flipFaces(System.Nullable<bool> flipNormals = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "flipFaces" }, flipNormals
                }
            );
        }

        public void increaseVertices(decimal numberPerEdge)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "increaseVertices" }, numberPerEdge
                }
            );
        }

        public void forceSharedVertices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceSharedVertices" }
                }
            );
        }

        public InstancedMesh createInstance(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createInstance" }, name
                }
            );
        }

        public Mesh synchronizeInstances()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "synchronizeInstances" }
                }
            );
        }

        public Mesh optimizeIndices(ActionCallback<Mesh> successCallback = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "optimizeIndices" }, successCallback
                }
            );
        }

        public void serialize(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, serializationObject
                }
            );
        }

        public decimal[] setPositionsForCPUSkinning()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setPositionsForCPUSkinning" }
                }
            );
        }

        public decimal[] setNormalsForCPUSkinning()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setNormalsForCPUSkinning" }
                }
            );
        }

        public Mesh applySkeleton(Skeleton skeleton)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applySkeleton" }, skeleton
                }
            );
        }

        public void addInstance(InstancedMesh instance)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addInstance" }, instance
                }
            );
        }

        public void removeInstance(InstancedMesh instance)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeInstance" }, instance
                }
            );
        }
        #endregion
    }
}