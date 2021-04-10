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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ShadowGenerator>))]
    public class ShadowGenerator : CachedEntityObject, IShadowGenerator
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<string> get_CLASSNAME()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ShadowGenerator.CLASSNAME"
                );
        }
        public static ValueTask set_CLASSNAME(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ShadowGenerator.CLASSNAME",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_NONE"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_EXPONENTIALSHADOWMAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_EXPONENTIALSHADOWMAP"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_POISSONSAMPLING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_POISSONSAMPLING"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_BLUREXPONENTIALSHADOWMAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_BLUREXPONENTIALSHADOWMAP"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_CLOSEEXPONENTIALSHADOWMAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_CLOSEEXPONENTIALSHADOWMAP"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_BLURCLOSEEXPONENTIALSHADOWMAP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_BLURCLOSEEXPONENTIALSHADOWMAP"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_PCF()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_PCF"
                );
        }

        
        public static async ValueTask<decimal> get_FILTER_PCSS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.FILTER_PCSS"
                );
        }

        
        public static async ValueTask<decimal> get_QUALITY_HIGH()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.QUALITY_HIGH"
                );
        }

        
        public static async ValueTask<decimal> get_QUALITY_MEDIUM()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.QUALITY_MEDIUM"
                );
        }

        
        public static async ValueTask<decimal> get_QUALITY_LOW()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ShadowGenerator.QUALITY_LOW"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<ShadowGenerator> Parse(object parsedShadowGenerator, Scene scene, ActionCallback<decimal, IShadowLight> constr = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ShadowGenerator", "Parse" }, parsedShadowGenerator, scene, constr
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_bias()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bias"
                );
        }
        public ValueTask set_bias(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bias",
                    value
                );
        }

        
        public async ValueTask<decimal> get_normalBias()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "normalBias"
                );
        }
        public ValueTask set_normalBias(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalBias",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blurBoxOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurBoxOffset"
                );
        }
        public ValueTask set_blurBoxOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurBoxOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blurScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurScale"
                );
        }
        public ValueTask set_blurScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blurKernel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurKernel"
                );
        }
        public ValueTask set_blurKernel(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurKernel",
                    value
                );
        }

        
        public async ValueTask<bool> get_useKernelBlur()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useKernelBlur"
                );
        }
        public ValueTask set_useKernelBlur(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useKernelBlur",
                    value
                );
        }

        
        public async ValueTask<decimal> get_depthScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthScale"
                );
        }
        public ValueTask set_depthScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_filter()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "filter"
                );
        }
        public ValueTask set_filter(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filter",
                    value
                );
        }

        
        public async ValueTask<bool> get_usePoissonSampling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "usePoissonSampling"
                );
        }
        public ValueTask set_usePoissonSampling(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usePoissonSampling",
                    value
                );
        }

        
        public async ValueTask<bool> get_useExponentialShadowMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useExponentialShadowMap"
                );
        }
        public ValueTask set_useExponentialShadowMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useExponentialShadowMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_useBlurExponentialShadowMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBlurExponentialShadowMap"
                );
        }
        public ValueTask set_useBlurExponentialShadowMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBlurExponentialShadowMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_useCloseExponentialShadowMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCloseExponentialShadowMap"
                );
        }
        public ValueTask set_useCloseExponentialShadowMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCloseExponentialShadowMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_useBlurCloseExponentialShadowMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBlurCloseExponentialShadowMap"
                );
        }
        public ValueTask set_useBlurCloseExponentialShadowMap(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBlurCloseExponentialShadowMap",
                    value
                );
        }

        
        public async ValueTask<bool> get_usePercentageCloserFiltering()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "usePercentageCloserFiltering"
                );
        }
        public ValueTask set_usePercentageCloserFiltering(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "usePercentageCloserFiltering",
                    value
                );
        }

        
        public async ValueTask<decimal> get_filteringQuality()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "filteringQuality"
                );
        }
        public ValueTask set_filteringQuality(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "filteringQuality",
                    value
                );
        }

        
        public async ValueTask<bool> get_useContactHardeningShadow()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useContactHardeningShadow"
                );
        }
        public ValueTask set_useContactHardeningShadow(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useContactHardeningShadow",
                    value
                );
        }

        
        public async ValueTask<decimal> get_contactHardeningLightSizeUVRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "contactHardeningLightSizeUVRatio"
                );
        }
        public ValueTask set_contactHardeningLightSizeUVRatio(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "contactHardeningLightSizeUVRatio",
                    value
                );
        }

        
        public async ValueTask<decimal> get_darkness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "darkness"
                );
        }
        public ValueTask set_darkness(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "darkness",
                    value
                );
        }

        
        public async ValueTask<bool> get_transparencyShadow()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "transparencyShadow"
                );
        }
        public ValueTask set_transparencyShadow(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparencyShadow",
                    value
                );
        }

        
        public async ValueTask<decimal> get_mapSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mapSize"
                );
        }
        public ValueTask set_mapSize(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mapSize",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }

        private ICustomShaderOptionsCachedEntity __customShaderOptions;
        public async ValueTask<ICustomShaderOptionsCachedEntity> get_customShaderOptions()
        {
            if(__customShaderOptions == null)
            {
                __customShaderOptions = await EventHorizonBlazorInterop.GetClass<ICustomShaderOptionsCachedEntity>(
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
        public ValueTask set_customShaderOptions(ICustomShaderOptionsCachedEntity value)
        {
__customShaderOptions = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customShaderOptions",
                    value
                );
        }

        private Observable<Effect> __onBeforeShadowMapRenderObservable;
        public async ValueTask<Observable<Effect>> get_onBeforeShadowMapRenderObservable()
        {
            if(__onBeforeShadowMapRenderObservable == null)
            {
                __onBeforeShadowMapRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
        public ValueTask set_onBeforeShadowMapRenderObservable(Observable<Effect> value)
        {
__onBeforeShadowMapRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeShadowMapRenderObservable",
                    value
                );
        }

        private Observable<Effect> __onAfterShadowMapRenderObservable;
        public async ValueTask<Observable<Effect>> get_onAfterShadowMapRenderObservable()
        {
            if(__onAfterShadowMapRenderObservable == null)
            {
                __onAfterShadowMapRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
        public ValueTask set_onAfterShadowMapRenderObservable(Observable<Effect> value)
        {
__onAfterShadowMapRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterShadowMapRenderObservable",
                    value
                );
        }

        private Observable<Mesh> __onBeforeShadowMapRenderMeshObservable;
        public async ValueTask<Observable<Mesh>> get_onBeforeShadowMapRenderMeshObservable()
        {
            if(__onBeforeShadowMapRenderMeshObservable == null)
            {
                __onBeforeShadowMapRenderMeshObservable = await EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
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
        public ValueTask set_onBeforeShadowMapRenderMeshObservable(Observable<Mesh> value)
        {
__onBeforeShadowMapRenderMeshObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeShadowMapRenderMeshObservable",
                    value
                );
        }

        private Observable<Mesh> __onAfterShadowMapRenderMeshObservable;
        public async ValueTask<Observable<Mesh>> get_onAfterShadowMapRenderMeshObservable()
        {
            if(__onAfterShadowMapRenderMeshObservable == null)
            {
                __onAfterShadowMapRenderMeshObservable = await EventHorizonBlazorInterop.GetClass<Observable<Mesh>>(
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
        public ValueTask set_onAfterShadowMapRenderMeshObservable(Observable<Mesh> value)
        {
__onAfterShadowMapRenderMeshObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterShadowMapRenderMeshObservable",
                    value
                );
        }

        
        public async ValueTask<bool> get_enableSoftTransparentShadow()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableSoftTransparentShadow"
                );
        }
        public ValueTask set_enableSoftTransparentShadow(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableSoftTransparentShadow",
                    value
                );
        }

        
        public async ValueTask<decimal> get_frustumEdgeFalloff()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frustumEdgeFalloff"
                );
        }
        public ValueTask set_frustumEdgeFalloff(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frustumEdgeFalloff",
                    value
                );
        }

        
        public async ValueTask<bool> get_forceBackFacesOnly()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceBackFacesOnly"
                );
        }
        public ValueTask set_forceBackFacesOnly(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceBackFacesOnly",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ShadowGenerator() : base() { }

        public ShadowGenerator(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ShadowGenerator> NewShadowGenerator(
            decimal mapSize, IShadowLight light, System.Nullable<bool> usefulFloatFirst = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ShadowGenerator" },
                mapSize, light, usefulFloatFirst
            );

            return new ShadowGenerator(entity);
        }
        #endregion

        #region Methods
        #region customAllowRendering TODO: Get Comments as metadata identification
        private bool _isCustomAllowRenderingEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customAllowRenderingActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> customAllowRendering(
            Func<Task> callback
        )
        {
            await SetupCustomAllowRenderingLoop();

            var handle = Guid.NewGuid().ToString();
            _customAllowRenderingActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCustomAllowRenderingLoop()
        {
            if (_isCustomAllowRenderingEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<decimal> getDarkness()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDarkness" }
                }
            );
        }

        public async ValueTask<ShadowGenerator> setDarkness(decimal darkness)
        {
            return await EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDarkness" }, darkness
                }
            );
        }

        public async ValueTask<ShadowGenerator> setTransparencyShadow(bool transparent)
        {
            return await EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setTransparencyShadow" }, transparent
                }
            );
        }

        public async ValueTask<RenderTargetTexture> getShadowMap()
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public async ValueTask<RenderTargetTexture> getShadowMapForRendering()
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowMapForRendering" }
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

        public async ValueTask<ShadowGenerator> addShadowCaster(AbstractMesh mesh, System.Nullable<bool> includeDescendants = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addShadowCaster" }, mesh, includeDescendants
                }
            );
        }

        public async ValueTask<ShadowGenerator> removeShadowCaster(AbstractMesh mesh, System.Nullable<bool> includeDescendants = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ShadowGenerator>(
                entity => new ShadowGenerator() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeShadowCaster" }, mesh, includeDescendants
                }
            );
        }

        public async ValueTask<IShadowLightCachedEntity> getLight()
        {
            return await EventHorizonBlazorInterop.FuncClass<IShadowLightCachedEntity>(
                entity => new IShadowLightCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLight" }
                }
            );
        }

        public async ValueTask forceCompilation(ActionCallback<IShadowGenerator> onCompiled = null, CachedEntity options = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<bool> isReady(SubMesh subMesh, bool useInstances, bool isTransparent)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances, isTransparent
                }
            );
        }

        public async ValueTask prepareDefines(object defines, decimal lightIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public async ValueTask bindShadowLight(string lightIndex, Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public async ValueTask<Matrix> getTransformMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public async ValueTask recreateShadowMap()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}