/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Material>))]
    public class Material : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal TriangleFillMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleFillMode"
                );
            }
        }

        
        public static decimal WireFrameFillMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.WireFrameFillMode"
                );
            }
        }

        
        public static decimal PointFillMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.PointFillMode"
                );
            }
        }

        
        public static decimal PointListDrawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.PointListDrawMode"
                );
            }
        }

        
        public static decimal LineListDrawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LineListDrawMode"
                );
            }
        }

        
        public static decimal LineLoopDrawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LineLoopDrawMode"
                );
            }
        }

        
        public static decimal LineStripDrawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LineStripDrawMode"
                );
            }
        }

        
        public static decimal TriangleStripDrawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleStripDrawMode"
                );
            }
        }

        
        public static decimal TriangleFanDrawMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleFanDrawMode"
                );
            }
        }

        
        public static decimal ClockWiseSideOrientation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.ClockWiseSideOrientation"
                );
            }
        }

        
        public static decimal CounterClockWiseSideOrientation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.CounterClockWiseSideOrientation"
                );
            }
        }

        
        public static decimal TextureDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TextureDirtyFlag"
                );
            }
        }

        
        public static decimal LightDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LightDirtyFlag"
                );
            }
        }

        
        public static decimal FresnelDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.FresnelDirtyFlag"
                );
            }
        }

        
        public static decimal AttributesDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.AttributesDirtyFlag"
                );
            }
        }

        
        public static decimal MiscDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MiscDirtyFlag"
                );
            }
        }

        
        public static decimal AllDirtyFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.AllDirtyFlag"
                );
            }
        }
        #endregion

        #region Static Methods
        public static Material Parse(object parsedMaterial, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "backFaceCulling"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
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
                __onBindObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
                __onUnBindObservable = EventHorizonBlazorInterop.GetClass<Observable<Material>>(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needDepthPrePass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wireframe"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pointsCloud"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "metadata"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "reservedDataStore"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkReadyOnEveryCall"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkReadyOnlyOnce"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetArrayClass<IInspectableCachedEntity>(
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

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sideOrientation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sideOrientation",
                    value
                );
            }
        }

        
        public ActionCallback<Effect> onCompiled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<Effect>>(
                    this.___guid,
                    "onCompiled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
            }
        }

        
        public ActionCallback<Effect, string> onError
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<Effect, string>>(
                    this.___guid,
                    "onError"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onError",
                    value
                );
            }
        }

        
        public ActionCallback getRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback>(
                    this.___guid,
                    "getRenderTargetTextures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetArrayClass<Animation>(
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

                EventHorizonBlazorInterop.Set(
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
                __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<Material>>(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthFunction"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "separateCullingPass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "meshMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Material" },
                name, scene, doNotAdd
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
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

        public void freeze()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeze" }
                }
            );
        }

        public void unfreeze()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreeze" }
                }
            );
        }

        public bool isReady(AbstractMesh mesh = null, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, mesh, useInstances
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, BaseSubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public Effect getEffect()
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public bool needAlphaBlendingForMesh(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlendingForMesh" }, mesh
                }
            );
        }

        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public BaseTexture getAlphaTestTexture()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAlphaTestTexture" }
                }
            );
        }

        public void markDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markDirty" }
                }
            );
        }

        public void bind(Matrix world, Mesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, world, mesh
                }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public void bindOnlyWorldMatrix(Matrix world)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public void bindSceneUniformBuffer(Effect effect, UniformBuffer sceneUbo)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindSceneUniformBuffer" }, effect, sceneUbo
                }
            );
        }

        public void bindView(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindView" }, effect
                }
            );
        }

        public void bindViewProjection(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindViewProjection" }, effect
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public Material clone(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public AbstractMesh[] getBindedMeshes()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBindedMeshes" }
                }
            );
        }

        public void forceCompilation(AbstractMesh mesh, ActionCallback<Material> onCompiled = null, IMaterialCompilationOptionsCachedEntity options = null, ActionCallback<string> onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilation" }, mesh, onCompiled, options, onError
                }
            );
        }

        public void forceCompilationAsync(AbstractMesh mesh, IMaterialCompilationOptionsCachedEntity options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, mesh, options
                }
            );
        }

        public void markAsDirty(decimal flag)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }, flag
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> notBoundToMesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, notBoundToMesh
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}