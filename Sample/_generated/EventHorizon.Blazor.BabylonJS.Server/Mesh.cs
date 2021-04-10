/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Mesh>))]
    public class Mesh : AbstractMesh, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_FRONTSIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FRONTSIDE"
                );
        }

        
        public static async ValueTask<decimal> get_BACKSIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.BACKSIDE"
                );
        }

        
        public static async ValueTask<decimal> get_DOUBLESIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.DOUBLESIDE"
                );
        }

        
        public static async ValueTask<decimal> get_DEFAULTSIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.DEFAULTSIDE"
                );
        }

        
        public static async ValueTask<decimal> get_NO_CAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.NO_CAP"
                );
        }

        
        public static async ValueTask<decimal> get_CAP_START()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CAP_START"
                );
        }

        
        public static async ValueTask<decimal> get_CAP_END()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CAP_END"
                );
        }

        
        public static async ValueTask<decimal> get_CAP_ALL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CAP_ALL"
                );
        }

        
        public static async ValueTask<decimal> get_NO_FLIP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.NO_FLIP"
                );
        }

        
        public static async ValueTask<decimal> get_FLIP_TILE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_TILE"
                );
        }

        
        public static async ValueTask<decimal> get_ROTATE_TILE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.ROTATE_TILE"
                );
        }

        
        public static async ValueTask<decimal> get_FLIP_ROW()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_ROW"
                );
        }

        
        public static async ValueTask<decimal> get_ROTATE_ROW()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.ROTATE_ROW"
                );
        }

        
        public static async ValueTask<decimal> get_FLIP_N_ROTATE_TILE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_N_ROTATE_TILE"
                );
        }

        
        public static async ValueTask<decimal> get_FLIP_N_ROTATE_ROW()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.FLIP_N_ROTATE_ROW"
                );
        }

        
        public static async ValueTask<decimal> get_CENTER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.CENTER"
                );
        }

        
        public static async ValueTask<decimal> get_LEFT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.LEFT"
                );
        }

        
        public static async ValueTask<decimal> get_RIGHT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.RIGHT"
                );
        }

        
        public static async ValueTask<decimal> get_TOP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.TOP"
                );
        }

        
        public static async ValueTask<decimal> get_BOTTOM()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Mesh.BOTTOM"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<Mesh> Parse(object parsedMesh, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "Parse" }, parsedMesh, scene, rootUrl
                }
            );
        }

        public static async ValueTask<Mesh> CreateRibbon(string name, Vector3[][] pathArray, bool closeArray, bool closePath, decimal offset, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateRibbon" }, name, pathArray, closeArray, closePath, offset, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static async ValueTask<Mesh> CreateDisc(string name, decimal radius, decimal tessellation, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateDisc" }, name, radius, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreateBox(string name, decimal size, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateBox" }, name, size, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreateSphere(string name, decimal segments, decimal diameter, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateSphere" }, name, segments, diameter, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreateHemisphere(string name, decimal segments, decimal diameter, Scene scene = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateHemisphere" }, name, segments, diameter, scene
                }
            );
        }

        public static async ValueTask<Mesh> CreateCylinder(string name, decimal height, decimal diameterTop, decimal diameterBottom, decimal tessellation, object subdivisions, Scene scene = null, object updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateCylinder" }, name, height, diameterTop, diameterBottom, tessellation, subdivisions, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreateTorus(string name, decimal diameter, decimal thickness, decimal tessellation, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTorus" }, name, diameter, thickness, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreateTorusKnot(string name, decimal radius, decimal tube, decimal radialSegments, decimal tubularSegments, decimal p, decimal q, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTorusKnot" }, name, radius, tube, radialSegments, tubularSegments, p, q, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<LinesMesh> CreateLines(string name, Vector3[] points, Scene scene = null, System.Nullable<bool> updatable = null, LinesMesh instance = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateLines" }, name, points, scene, updatable, instance
                }
            );
        }

        public static async ValueTask<LinesMesh> CreateDashedLines(string name, Vector3[] points, decimal dashSize, decimal gapSize, decimal dashNb, Scene scene = null, System.Nullable<bool> updatable = null, LinesMesh instance = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateDashedLines" }, name, points, dashSize, gapSize, dashNb, scene, updatable, instance
                }
            );
        }

        public static async ValueTask<Mesh> CreatePolygon(string name, Vector3[] shape, Scene scene, Vector3[][] holes = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, object earcutInjection = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreatePolygon" }, name, shape, scene, holes, updatable, sideOrientation, earcutInjection
                }
            );
        }

        public static async ValueTask<Mesh> ExtrudePolygon(string name, Vector3[] shape, decimal depth, Scene scene, Vector3[][] holes = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, object earcutInjection = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "ExtrudePolygon" }, name, shape, depth, scene, holes, updatable, sideOrientation, earcutInjection
                }
            );
        }

        public static async ValueTask<Mesh> ExtrudeShape(string name, Vector3[] shape, Vector3[] path, decimal scale, decimal rotation, decimal cap, Scene scene = null, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "ExtrudeShape" }, name, shape, path, scale, rotation, cap, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static async ValueTask<Mesh> CreateLathe(string name, Vector3[] shape, decimal radius, decimal tessellation, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateLathe" }, name, shape, radius, tessellation, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreatePlane(string name, decimal size, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreatePlane" }, name, size, scene, updatable, sideOrientation
                }
            );
        }

        public static async ValueTask<Mesh> CreateGround(string name, decimal width, decimal height, decimal subdivisions, Scene scene = null, System.Nullable<bool> updatable = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateGround" }, name, width, height, subdivisions, scene, updatable
                }
            );
        }

        public static async ValueTask<Mesh> CreateTiledGround(string name, decimal xmin, decimal zmin, decimal xmax, decimal zmax, object subdivisions, object precision, Scene scene, System.Nullable<bool> updatable = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTiledGround" }, name, xmin, zmin, xmax, zmax, subdivisions, precision, scene, updatable
                }
            );
        }

        public static async ValueTask<GroundMesh> CreateGroundFromHeightMap(string name, string url, decimal width, decimal height, decimal subdivisions, decimal minHeight, decimal maxHeight, Scene scene, System.Nullable<bool> updatable = null, ActionCallback<GroundMesh> onReady = null, System.Nullable<decimal> alphaFilter = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateGroundFromHeightMap" }, name, url, width, height, subdivisions, minHeight, maxHeight, scene, updatable, onReady, alphaFilter
                }
            );
        }

        public static async ValueTask<Mesh> CreateTube(string name, Vector3[] path, decimal radius, decimal tessellation, object radiusFunction, decimal cap, Scene scene, System.Nullable<bool> updatable = null, System.Nullable<decimal> sideOrientation = null, Mesh instance = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateTube" }, name, path, radius, tessellation, radiusFunction, cap, scene, updatable, sideOrientation, instance
                }
            );
        }

        public static async ValueTask<Mesh> CreatePolyhedron(string name, object options, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreatePolyhedron" }, name, options, scene
                }
            );
        }

        public static async ValueTask<Mesh> CreateIcoSphere(string name, object options, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateIcoSphere" }, name, options, scene
                }
            );
        }

        public static async ValueTask<Mesh> CreateDecal(string name, AbstractMesh sourceMesh, Vector3 position, Vector3 normal, Vector3 size, decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateDecal" }, name, sourceMesh, position, normal, size, angle
                }
            );
        }

        public static async ValueTask<Mesh> CreateCapsule(string name, ICreateCapsuleOptions options, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "CreateCapsule" }, name, options, scene
                }
            );
        }

        public static async ValueTask<CachedEntity> MinMax(AbstractMesh[] meshes)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "MinMax" }, meshes
                }
            );
        }

        public static async ValueTask<Vector3> Center(AbstractMesh[] meshesOrMinMaxVector)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "Center" }, meshesOrMinMaxVector
                }
            );
        }

        public static async ValueTask<Mesh> MergeMeshes(Mesh[] meshes, System.Nullable<bool> disposeSource = null, System.Nullable<bool> allow32BitsIndices = null, Mesh meshSubclass = null, System.Nullable<bool> subdivideWithSubMeshes = null, System.Nullable<bool> multiMultiMaterials = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Mesh", "MergeMeshes" }, meshes, disposeSource, allow32BitsIndices, meshSubclass, subdivideWithSubMeshes, multiMultiMaterials
                }
            );
        }


        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_computeBonesUsingShaders()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "computeBonesUsingShaders"
                );
        }
        public ValueTask set_computeBonesUsingShaders(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "computeBonesUsingShaders",
                    value
                );
        }

        private Observable<Mesh> __onBeforeRenderObservable;
        public async ValueTask<Observable<Mesh>> get_onBeforeRenderObservable()
        {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
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

        private Observable<Mesh> __onBeforeBindObservable;
        public async ValueTask<Observable<Mesh>> get_onBeforeBindObservable()
        {
            if(__onBeforeBindObservable == null)
            {
                __onBeforeBindObservable = await EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
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

        private Observable<Mesh> __onAfterRenderObservable;
        public async ValueTask<Observable<Mesh>> get_onAfterRenderObservable()
        {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
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

        private Observable<Mesh> __onBeforeDrawObservable;
        public async ValueTask<Observable<Mesh>> get_onBeforeDrawObservable()
        {
            if(__onBeforeDrawObservable == null)
            {
                __onBeforeDrawObservable = await EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
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

        
        public async ValueTask<bool> get_hasInstances()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasInstances"
                );
        }

        
        public async ValueTask<bool> get_hasThinInstances()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasThinInstances"
                );
        }

        private MorphTargetManager __morphTargetManager;
        public async ValueTask<MorphTargetManager> get_morphTargetManager()
        {
            if(__morphTargetManager == null)
            {
                __morphTargetManager = await EventHorizonBlazorInterop.GetClass<MorphTargetManager>(
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
        public ValueTask set_morphTargetManager(MorphTargetManager value)
        {
__morphTargetManager = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "morphTargetManager",
                    value
                );
        }

        private Mesh __source;
        public async ValueTask<Mesh> get_source()
        {
            if(__source == null)
            {
                __source = await EventHorizonBlazorInterop.GetClass<Mesh>(
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

        private Mesh __cloneMeshMap;
        public async ValueTask<Mesh> get_cloneMeshMap()
        {
            if(__cloneMeshMap == null)
            {
                __cloneMeshMap = await EventHorizonBlazorInterop.GetClass<Mesh>(
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

        
        public async ValueTask<bool> get_isUnIndexed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUnIndexed"
                );
        }
        public ValueTask set_isUnIndexed(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isUnIndexed",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_worldMatrixInstancedBuffer()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "worldMatrixInstancedBuffer"
                );
        }

        
        public async ValueTask<bool> get_manualUpdateOfWorldMatrixInstancedBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "manualUpdateOfWorldMatrixInstancedBuffer"
                );
        }
        public ValueTask set_manualUpdateOfWorldMatrixInstancedBuffer(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manualUpdateOfWorldMatrixInstancedBuffer",
                    value
                );
        }

        
        public async ValueTask<bool> get_hasLODLevels()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasLODLevels"
                );
        }

        private Geometry __geometry;
        public async ValueTask<Geometry> get_geometry()
        {
            if(__geometry == null)
            {
                __geometry = await EventHorizonBlazorInterop.GetClass<Geometry>(
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

        
        public async ValueTask<bool> get_isBlocked()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocked"
                );
        }

        
        public async ValueTask<bool> get_areNormalsFrozen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "areNormalsFrozen"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_delayLoadState()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
        }
        public ValueTask set_delayLoadState(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadState",
                    value
                );
        }

        
        public async ValueTask<InstancedMesh[]> get_instances()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<InstancedMesh>(
                    this.___guid,
                    "instances",
                    (entity) =>
                    {
                        return new InstancedMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_instances(InstancedMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "instances",
                    value
                );
        }

        
        public async ValueTask<string> get_delayLoadingFile()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "delayLoadingFile"
                );
        }
        public ValueTask set_delayLoadingFile(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadingFile",
                    value
                );
        }

        
        public async ValueTask<decimal> get_overrideMaterialSideOrientation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overrideMaterialSideOrientation"
                );
        }
        public ValueTask set_overrideMaterialSideOrientation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overrideMaterialSideOrientation",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Mesh() : base() { }

        public Mesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Mesh> NewMesh(
            string name, Scene scene = null, Node parent = null, Mesh source = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> clonePhysicsImpostor = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Mesh" },
                name, scene, parent, source, doNotCloneChildren, clonePhysicsImpostor
            );

            return new Mesh(entity);
        }
        #endregion

        #region Methods
        #region onLODLevelSelection TODO: Get Comments as metadata identification
        private bool _isOnLODLevelSelectionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onLODLevelSelectionActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onLODLevelSelection(
            Func<Task> callback
        )
        {
            await SetupOnLODLevelSelectionLoop();

            var handle = Guid.NewGuid().ToString();
            _onLODLevelSelectionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnLODLevelSelectionLoop()
        {
            if (_isOnLODLevelSelectionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<TransformNode> instantiateHierarchy(TransformNode newParent = null, object options = null, ActionCallback<TransformNode, TransformNode> onNewNodeCreated = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "instantiateHierarchy" }, newParent, options, onNewNodeCreated
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public async ValueTask<MeshLODLevel[]> getLODLevels()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<MeshLODLevel>(
                entity => new MeshLODLevel() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLODLevels" }
                }
            );
        }

        public async ValueTask<Mesh> addLODLevel(decimal distance, Mesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLODLevel" }, distance, mesh
                }
            );
        }

        public async ValueTask<Mesh> getLODLevelAtDistance(decimal distance)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLODLevelAtDistance" }, distance
                }
            );
        }

        public async ValueTask<Mesh> removeLODLevel(Mesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLODLevel" }, mesh
                }
            );
        }

        public async ValueTask<AbstractMesh> getLOD(Camera camera, BoundingSphere boundingSphere = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLOD" }, camera, boundingSphere
                }
            );
        }

        public async ValueTask<decimal> getTotalVertices()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public async ValueTask<decimal[]> getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public async ValueTask<VertexBuffer> getVertexBuffer(string kind)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexBuffer>(
                entity => new VertexBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getVertexBuffer" }, kind
                }
            );
        }

        public async ValueTask<bool> isVerticesDataPresent(string kind)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public async ValueTask<bool> isVertexBufferUpdatable(string kind)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVertexBufferUpdatable" }, kind
                }
            );
        }

        public async ValueTask<string[]> getVerticesDataKinds()
        {
            return await EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesDataKinds" }
                }
            );
        }

        public async ValueTask<decimal> getTotalIndices()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public async ValueTask<decimal[]> getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public async ValueTask<bool> isReady(System.Nullable<bool> completeCheck = null, System.Nullable<bool> forceInstanceSupport = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck, forceInstanceSupport
                }
            );
        }

        public async ValueTask<Mesh> freezeNormals()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "freezeNormals" }
                }
            );
        }

        public async ValueTask<Mesh> unfreezeNormals()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeNormals" }
                }
            );
        }

        public async ValueTask<Mesh> refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
                }
            );
        }

        public async ValueTask subdivide(decimal count)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "subdivide" }, count
                }
            );
        }

        public async ValueTask<AbstractMesh> setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public async ValueTask removeVerticesData(string kind)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeVerticesData" }, kind
                }
            );
        }

        public async ValueTask markVerticesDataAsUpdatable(string kind, System.Nullable<bool> updatable = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markVerticesDataAsUpdatable" }, kind, updatable
                }
            );
        }

        public async ValueTask<Mesh> setVerticesBuffer(VertexBuffer buffer)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesBuffer" }, buffer
                }
            );
        }

        public async ValueTask<AbstractMesh> updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public async ValueTask<Mesh> updateMeshPositions(ActionCallback<decimal[]> positionFunction, System.Nullable<bool> computeNormals = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateMeshPositions" }, positionFunction, computeNormals
                }
            );
        }

        public async ValueTask<Mesh> makeGeometryUnique()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "makeGeometryUnique" }
                }
            );
        }

        public async ValueTask<AbstractMesh> setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null, System.Nullable<bool> updatable = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
                }
            );
        }

        public async ValueTask<AbstractMesh> updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public async ValueTask<Mesh> toLeftHanded()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toLeftHanded" }
                }
            );
        }

        public async ValueTask<Mesh> registerBeforeRender(ActionCallback<AbstractMesh> func)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerBeforeRender" }, func
                }
            );
        }

        public async ValueTask<Mesh> unregisterBeforeRender(ActionCallback<AbstractMesh> func)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unregisterBeforeRender" }, func
                }
            );
        }

        public async ValueTask<Mesh> registerAfterRender(ActionCallback<AbstractMesh> func)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerAfterRender" }, func
                }
            );
        }

        public async ValueTask<Mesh> unregisterAfterRender(ActionCallback<AbstractMesh> func)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unregisterAfterRender" }, func
                }
            );
        }

        public async ValueTask<Mesh> render(SubMesh subMesh, bool enableAlphaMode, AbstractMesh effectiveMeshReplacement = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "render" }, subMesh, enableAlphaMode, effectiveMeshReplacement
                }
            );
        }

        public async ValueTask cleanMatrixWeights()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cleanMatrixWeights" }
                }
            );
        }

        public async ValueTask<CachedEntity> validateSkinning()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "validateSkinning" }
                }
            );
        }

        public async ValueTask<bool> isInFrustum(Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public async ValueTask<Mesh> setMaterialByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMaterialByID" }, id
                }
            );
        }

        public async ValueTask<IAnimatableCachedEntity[]> getAnimatables()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public async ValueTask<Mesh> bakeTransformIntoVertices(Matrix transform)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "bakeTransformIntoVertices" }, transform
                }
            );
        }

        public async ValueTask<Mesh> bakeCurrentTransformIntoVertices(System.Nullable<bool> bakeIndependenlyOfChildren = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "bakeCurrentTransformIntoVertices" }, bakeIndependenlyOfChildren
                }
            );
        }

        public async ValueTask<Mesh> clone(string name = null, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> clonePhysicsImpostor = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren, clonePhysicsImpostor
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public async ValueTask<Mesh> applyDisplacementMap(string url, decimal minHeight, decimal maxHeight, ActionCallback<Mesh> onSuccess = null, Vector2 uvOffset = null, Vector2 uvScale = null, System.Nullable<bool> forceUpdate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "applyDisplacementMap" }, url, minHeight, maxHeight, onSuccess, uvOffset, uvScale, forceUpdate
                }
            );
        }

        public async ValueTask<Mesh> applyDisplacementMapFromBuffer(decimal[] buffer, decimal heightMapWidth, decimal heightMapHeight, decimal minHeight, decimal maxHeight, Vector2 uvOffset = null, Vector2 uvScale = null, System.Nullable<bool> forceUpdate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "applyDisplacementMapFromBuffer" }, buffer, heightMapWidth, heightMapHeight, minHeight, maxHeight, uvOffset, uvScale, forceUpdate
                }
            );
        }

        public async ValueTask<Mesh> convertToFlatShadedMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "convertToFlatShadedMesh" }
                }
            );
        }

        public async ValueTask<Mesh> convertToUnIndexedMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "convertToUnIndexedMesh" }
                }
            );
        }

        public async ValueTask<Mesh> flipFaces(System.Nullable<bool> flipNormals = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "flipFaces" }, flipNormals
                }
            );
        }

        public async ValueTask increaseVertices(decimal numberPerEdge)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "increaseVertices" }, numberPerEdge
                }
            );
        }

        public async ValueTask forceSharedVertices()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceSharedVertices" }
                }
            );
        }

        public async ValueTask<InstancedMesh> createInstance(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createInstance" }, name
                }
            );
        }

        public async ValueTask<Mesh> synchronizeInstances()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "synchronizeInstances" }
                }
            );
        }

        public async ValueTask<Mesh> optimizeIndices(ActionCallback<Mesh> successCallback = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "optimizeIndices" }, successCallback
                }
            );
        }

        public async ValueTask serialize(object serializationObject)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializationObject
                }
            );
        }

        public async ValueTask<decimal[]> setPositionsForCPUSkinning()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setPositionsForCPUSkinning" }
                }
            );
        }

        public async ValueTask<decimal[]> setNormalsForCPUSkinning()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setNormalsForCPUSkinning" }
                }
            );
        }

        public async ValueTask<Mesh> applySkeleton(Skeleton skeleton)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "applySkeleton" }, skeleton
                }
            );
        }

        public async ValueTask addInstance(InstancedMesh instance)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addInstance" }, instance
                }
            );
        }

        public async ValueTask removeInstance(InstancedMesh instance)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeInstance" }, instance
                }
            );
        }
        #endregion
    }
}