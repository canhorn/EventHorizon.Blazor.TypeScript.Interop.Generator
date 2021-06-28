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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ShadowGenerator>))]
    public class ShadowGenerator : CachedEntityObject, IShadowGenerator
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static string CLASSNAME
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ShadowGenerator.CLASSNAME"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ShadowGenerator.CLASSNAME",
                    value
                );
            }
        }

        
        public static decimal FILTER_NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_NONE"
                );
            }
        }

        
        public static decimal FILTER_EXPONENTIALSHADOWMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_EXPONENTIALSHADOWMAP"
                );
            }
        }

        
        public static decimal FILTER_POISSONSAMPLING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_POISSONSAMPLING"
                );
            }
        }

        
        public static decimal FILTER_BLUREXPONENTIALSHADOWMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_BLUREXPONENTIALSHADOWMAP"
                );
            }
        }

        
        public static decimal FILTER_CLOSEEXPONENTIALSHADOWMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_CLOSEEXPONENTIALSHADOWMAP"
                );
            }
        }

        
        public static decimal FILTER_BLURCLOSEEXPONENTIALSHADOWMAP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_BLURCLOSEEXPONENTIALSHADOWMAP"
                );
            }
        }

        
        public static decimal FILTER_PCF
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_PCF"
                );
            }
        }

        
        public static decimal FILTER_PCSS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_PCSS"
                );
            }
        }

        
        public static decimal QUALITY_HIGH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.QUALITY_HIGH"
                );
            }
        }

        
        public static decimal QUALITY_MEDIUM
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.QUALITY_MEDIUM"
                );
            }
        }

        
        public static decimal QUALITY_LOW
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.QUALITY_LOW"
                );
            }
        }
        #endregion

        #region Static Methods
        public static ShadowGenerator Parse(object parsedShadowGenerator, Scene scene, ActionResultCallback<decimal, IShadowLight, ShadowGenerator> constr = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ShadowGenerator", "Parse" }, parsedShadowGenerator, scene, constr
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal bias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bias",
                    value
                );
            }
        }

        
        public decimal normalBias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "normalBias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalBias",
                    value
                );
            }
        }

        
        public decimal blurBoxOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurBoxOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurBoxOffset",
                    value
                );
            }
        }

        
        public decimal blurScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurScale",
                    value
                );
            }
        }

        
        public decimal blurKernel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurKernel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurKernel",
                    value
                );
            }
        }

        
        public bool useKernelBlur
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useKernelBlur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useKernelBlur",
                    value
                );
            }
        }

        
        public decimal depthScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthScale",
                    value
                );
            }
        }

        
        public decimal filter
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "filter"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filter",
                    value
                );
            }
        }

        
        public bool usePoissonSampling
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "usePoissonSampling"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usePoissonSampling",
                    value
                );
            }
        }

        
        public bool useExponentialShadowMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useExponentialShadowMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useExponentialShadowMap",
                    value
                );
            }
        }

        
        public bool useBlurExponentialShadowMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBlurExponentialShadowMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBlurExponentialShadowMap",
                    value
                );
            }
        }

        
        public bool useCloseExponentialShadowMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCloseExponentialShadowMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCloseExponentialShadowMap",
                    value
                );
            }
        }

        
        public bool useBlurCloseExponentialShadowMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBlurCloseExponentialShadowMap"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBlurCloseExponentialShadowMap",
                    value
                );
            }
        }

        
        public bool usePercentageCloserFiltering
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "usePercentageCloserFiltering"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usePercentageCloserFiltering",
                    value
                );
            }
        }

        
        public decimal filteringQuality
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "filteringQuality"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filteringQuality",
                    value
                );
            }
        }

        
        public bool useContactHardeningShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useContactHardeningShadow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useContactHardeningShadow",
                    value
                );
            }
        }

        
        public decimal contactHardeningLightSizeUVRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "contactHardeningLightSizeUVRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contactHardeningLightSizeUVRatio",
                    value
                );
            }
        }

        
        public decimal darkness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "darkness"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "darkness",
                    value
                );
            }
        }

        
        public bool transparencyShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transparencyShadow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparencyShadow",
                    value
                );
            }
        }

        
        public decimal mapSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mapSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mapSize",
                    value
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

        private ICustomShaderOptionsCachedEntity __customShaderOptions;
        public ICustomShaderOptionsCachedEntity customShaderOptions
        {
            get
            {
            if(__customShaderOptions == null)
            {
                __customShaderOptions = EventHorizonBlazorInterop.GetClass<ICustomShaderOptionsCachedEntity>(
                    this.___guid,
                    "customShaderOptions",
                    (entity) =>
                    {
                        return new ICustomShaderOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __customShaderOptions;
            }
            set
            {
__customShaderOptions = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customShaderOptions",
                    value
                );
            }
        }

        private Observable<Effect> __onBeforeShadowMapRenderObservable;
        public Observable<Effect> onBeforeShadowMapRenderObservable
        {
            get
            {
            if(__onBeforeShadowMapRenderObservable == null)
            {
                __onBeforeShadowMapRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onBeforeShadowMapRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeShadowMapRenderObservable;
            }
            set
            {
__onBeforeShadowMapRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeShadowMapRenderObservable",
                    value
                );
            }
        }

        private Observable<Effect> __onAfterShadowMapRenderObservable;
        public Observable<Effect> onAfterShadowMapRenderObservable
        {
            get
            {
            if(__onAfterShadowMapRenderObservable == null)
            {
                __onAfterShadowMapRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onAfterShadowMapRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterShadowMapRenderObservable;
            }
            set
            {
__onAfterShadowMapRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterShadowMapRenderObservable",
                    value
                );
            }
        }

        private Observable<Mesh> __onBeforeShadowMapRenderMeshObservable;
        public Observable<Mesh> onBeforeShadowMapRenderMeshObservable
        {
            get
            {
            if(__onBeforeShadowMapRenderMeshObservable == null)
            {
                __onBeforeShadowMapRenderMeshObservable = EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
                    this.___guid,
                    "onBeforeShadowMapRenderMeshObservable",
                    (entity) =>
                    {
                        return new Observable<Mesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeShadowMapRenderMeshObservable;
            }
            set
            {
__onBeforeShadowMapRenderMeshObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeShadowMapRenderMeshObservable",
                    value
                );
            }
        }

        private Observable<Mesh> __onAfterShadowMapRenderMeshObservable;
        public Observable<Mesh> onAfterShadowMapRenderMeshObservable
        {
            get
            {
            if(__onAfterShadowMapRenderMeshObservable == null)
            {
                __onAfterShadowMapRenderMeshObservable = EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
                    this.___guid,
                    "onAfterShadowMapRenderMeshObservable",
                    (entity) =>
                    {
                        return new Observable<Mesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterShadowMapRenderMeshObservable;
            }
            set
            {
__onAfterShadowMapRenderMeshObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterShadowMapRenderMeshObservable",
                    value
                );
            }
        }

        
        public bool enableSoftTransparentShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableSoftTransparentShadow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableSoftTransparentShadow",
                    value
                );
            }
        }

        
        public decimal frustumEdgeFalloff
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frustumEdgeFalloff"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frustumEdgeFalloff",
                    value
                );
            }
        }

        
        public bool forceBackFacesOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceBackFacesOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceBackFacesOnly",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ShadowGenerator() : base() { }

        public ShadowGenerator(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ShadowGenerator(
            decimal mapSize, IShadowLight light, System.Nullable<bool> usefulFloatFirst = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ShadowGenerator" },
                mapSize, light, usefulFloatFirst
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region customAllowRendering TODO: Get Comments as metadata identification
        private bool _isCustomAllowRenderingEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customAllowRenderingActionMap = new Dictionary<string, Func<Task>>();

        public string customAllowRendering(
            Func<Task> callback
        )
        {
            SetupCustomAllowRenderingLoop();

            var handle = Guid.NewGuid().ToString();
            _customAllowRenderingActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customAllowRendering_Remove(
            string handle
        )
        {
            return _customAllowRenderingActionMap.Remove(
                handle
            );
        }

        private void SetupCustomAllowRenderingLoop()
        {
            if (_isCustomAllowRenderingEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customAllowRendering",
                "CallCustomAllowRenderingActions",
                _invokableReference
            );
            _isCustomAllowRenderingEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomAllowRenderingActions()
        {
            foreach (var action in _customAllowRenderingActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public decimal getDarkness()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDarkness" }
                }
            );
        }

        public ShadowGenerator setDarkness(decimal darkness)
        {
            return EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDarkness" }, darkness
                }
            );
        }

        public ShadowGenerator setTransparencyShadow(bool transparent)
        {
            return EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTransparencyShadow" }, transparent
                }
            );
        }

        public RenderTargetTexture getShadowMap()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public RenderTargetTexture getShadowMapForRendering()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShadowMapForRendering" }
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

        public ShadowGenerator addShadowCaster(AbstractMesh mesh, System.Nullable<bool> includeDescendants = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addShadowCaster" }, mesh, includeDescendants
                }
            );
        }

        public ShadowGenerator removeShadowCaster(AbstractMesh mesh, System.Nullable<bool> includeDescendants = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeShadowCaster" }, mesh, includeDescendants
                }
            );
        }

        public IShadowLightCachedEntity getLight()
        {
            return EventHorizonBlazorInterop.FuncClass<IShadowLightCachedEntity>(
                entity => new IShadowLightCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLight" }
                }
            );
        }

        public void forceCompilation(ActionCallback<IShadowGenerator> onCompiled = null, CachedEntity options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceCompilation" }, onCompiled, options
                }
            );
        }

        public async ValueTask forceCompilationAsync(CachedEntity options = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, options
                }
            );
        }

        public bool isReady(SubMesh subMesh, bool useInstances, bool isTransparent)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances, isTransparent
                }
            );
        }

        public void prepareDefines(object defines, decimal lightIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public void bindShadowLight(string lightIndex, Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public Matrix getTransformMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public void recreateShadowMap()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
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