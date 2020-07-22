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
    public class Material : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal TriangleFillMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleFillMode"
                );
            }
        }

        
        public static decimal WireFrameFillMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.WireFrameFillMode"
                );
            }
        }

        
        public static decimal PointFillMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.PointFillMode"
                );
            }
        }

        
        public static decimal PointListDrawMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.PointListDrawMode"
                );
            }
        }

        
        public static decimal LineListDrawMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.LineListDrawMode"
                );
            }
        }

        
        public static decimal LineLoopDrawMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.LineLoopDrawMode"
                );
            }
        }

        
        public static decimal LineStripDrawMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.LineStripDrawMode"
                );
            }
        }

        
        public static decimal TriangleStripDrawMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleStripDrawMode"
                );
            }
        }

        
        public static decimal TriangleFanDrawMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleFanDrawMode"
                );
            }
        }

        
        public static decimal ClockWiseSideOrientation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.ClockWiseSideOrientation"
                );
            }
        }

        
        public static decimal CounterClockWiseSideOrientation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.CounterClockWiseSideOrientation"
                );
            }
        }

        
        public static decimal TextureDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.TextureDirtyFlag"
                );
            }
        }

        
        public static decimal LightDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.LightDirtyFlag"
                );
            }
        }

        
        public static decimal FresnelDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.FresnelDirtyFlag"
                );
            }
        }

        
        public static decimal AttributesDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.AttributesDirtyFlag"
                );
            }
        }

        
        public static decimal MiscDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.MiscDirtyFlag"
                );
            }
        }

        
        public static decimal AllDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Material.AllDirtyFlag"
                );
            }
        }
        #endregion

        #region Static Methods
        public static Material Parse(object parsedMaterial, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Material", "Parse" }, parsedMaterial, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public bool backFaceCulling
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "backFaceCulling"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "backFaceCulling",
                    value
                );
            }
        }

        
        public bool hasRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasRenderTargetTextures"
                );
            }
        }

        private Observable<AbstractMesh> __onBindObservable;
        public Observable<AbstractMesh> onBindObservable
        {
            get
            {
            if(__onBindObservable == null)
            {
                __onBindObservable = EventHorizonBlazorInteropt.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onBindObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBindObservable;
            }
        }

        private Observable<Material> __onUnBindObservable;
        public Observable<Material> onUnBindObservable
        {
            get
            {
            if(__onUnBindObservable == null)
            {
                __onUnBindObservable = EventHorizonBlazorInteropt.GetClass<Observable<Material>>(
                    this.___guid,
                    "onUnBindObservable",
                    (entity) =>
                    {
                        return new Observable<Material>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onUnBindObservable;
            }
        }

        
        public decimal alphaMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "alphaMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alphaMode",
                    value
                );
            }
        }

        
        public bool needDepthPrePass
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "needDepthPrePass"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "needDepthPrePass",
                    value
                );
            }
        }

        
        public bool fogEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fogEnabled",
                    value
                );
            }
        }

        
        public bool wireframe
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "wireframe"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "wireframe",
                    value
                );
            }
        }

        
        public bool pointsCloud
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "pointsCloud"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pointsCloud",
                    value
                );
            }
        }

        
        public decimal fillMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fillMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fillMode",
                    value
                );
            }
        }

        
        public bool isFrozen
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isFrozen"
                );
            }
        }
        #endregion

        #region Properties
        
        public string id
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public CachedEntity metadata
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "metadata"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "metadata",
                    value
                );
            }
        }

        
        public CachedEntity reservedDataStore
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "reservedDataStore"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "reservedDataStore",
                    value
                );
            }
        }

        
        public bool checkReadyOnEveryCall
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "checkReadyOnEveryCall"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "checkReadyOnEveryCall",
                    value
                );
            }
        }

        
        public bool checkReadyOnlyOnce
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "checkReadyOnlyOnce"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "checkReadyOnlyOnce",
                    value
                );
            }
        }

        
        public string state
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        
        public IInspectableCachedEntity[] inspectableCustomProperties
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IInspectableCachedEntity>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
            }
        }

        
        public decimal sideOrientation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sideOrientation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sideOrientation",
                    value
                );
            }
        }

        
        public CachedEntity onCompiled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onCompiled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
            }
        }

        
        public CachedEntity onError
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onError"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onError",
                    value
                );
            }
        }

        
        public CachedEntity getRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "getRenderTargetTextures"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "getRenderTargetTextures",
                    value
                );
            }
        }

        
        public bool doNotSerialize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "doNotSerialize",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        private Observable<Material> __onDisposeObservable;
        public Observable<Material> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInteropt.GetClass<Observable<Material>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<Material>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        
        public bool disableDepthWrite
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disableDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disableDepthWrite",
                    value
                );
            }
        }

        
        public bool forceDepthWrite
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "forceDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "forceDepthWrite",
                    value
                );
            }
        }

        
        public decimal depthFunction
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "depthFunction"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "depthFunction",
                    value
                );
            }
        }

        
        public bool separateCullingPass
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "separateCullingPass"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "separateCullingPass",
                    value
                );
            }
        }

        
        public decimal pointSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "pointSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pointSize",
                    value
                );
            }
        }

        
        public decimal zOffset
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "zOffset"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "zOffset",
                    value
                );
            }
        }

        
        public CachedEntity meshMap
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "meshMap"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "meshMap",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Material() : base() { }

        public Material(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Material(
            string name, Scene scene, System.Nullable<bool> doNotAdd = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Material" },
                name, scene, doNotAdd
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void freeze()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeze" }
                }
            );
        }

        public void unfreeze()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreeze" }
                }
            );
        }

        public bool isReady(AbstractMesh mesh = null, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, mesh, useInstances
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, BaseSubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public Effect getEffect()
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public bool needAlphaBlendingForMesh(AbstractMesh mesh)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlendingForMesh" }, mesh
                }
            );
        }

        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public BaseTexture getAlphaTestTexture()
        {
            return EventHorizonBlazorInteropt.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAlphaTestTexture" }
                }
            );
        }

        public void markDirty()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markDirty" }
                }
            );
        }

        public void bind(Matrix world, Mesh mesh = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, world, mesh
                }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public void bindOnlyWorldMatrix(Matrix world)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public void bindSceneUniformBuffer(Effect effect, UniformBuffer sceneUbo)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindSceneUniformBuffer" }, effect, sceneUbo
                }
            );
        }

        public void bindView(Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindView" }, effect
                }
            );
        }

        public void bindViewProjection(Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindViewProjection" }, effect
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public Material clone(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public AbstractMesh[] getBindedMeshes()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBindedMeshes" }
                }
            );
        }

// forceCompilation is not supported by the platform yet

        public void forceCompilationAsync(AbstractMesh mesh, IMaterialCompilationOptionsCachedEntity options = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, mesh, options
                }
            );
        }

        public void markAsDirty(decimal flag)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }, flag
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> notBoundToMesh = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, notBoundToMesh
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}