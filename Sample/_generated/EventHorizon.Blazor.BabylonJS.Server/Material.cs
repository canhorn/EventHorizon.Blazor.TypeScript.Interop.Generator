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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Material>))]
    public class Material : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_TriangleFillMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleFillMode"
                );
        }

        
        public static async ValueTask<decimal> get_WireFrameFillMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.WireFrameFillMode"
                );
        }

        
        public static async ValueTask<decimal> get_PointFillMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.PointFillMode"
                );
        }

        
        public static async ValueTask<decimal> get_PointListDrawMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.PointListDrawMode"
                );
        }

        
        public static async ValueTask<decimal> get_LineListDrawMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LineListDrawMode"
                );
        }

        
        public static async ValueTask<decimal> get_LineLoopDrawMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LineLoopDrawMode"
                );
        }

        
        public static async ValueTask<decimal> get_LineStripDrawMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LineStripDrawMode"
                );
        }

        
        public static async ValueTask<decimal> get_TriangleStripDrawMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleStripDrawMode"
                );
        }

        
        public static async ValueTask<decimal> get_TriangleFanDrawMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TriangleFanDrawMode"
                );
        }

        
        public static async ValueTask<decimal> get_ClockWiseSideOrientation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.ClockWiseSideOrientation"
                );
        }

        
        public static async ValueTask<decimal> get_CounterClockWiseSideOrientation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.CounterClockWiseSideOrientation"
                );
        }

        
        public static async ValueTask<decimal> get_TextureDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.TextureDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_LightDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.LightDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_FresnelDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.FresnelDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_AttributesDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.AttributesDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_MiscDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MiscDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_PrePassDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.PrePassDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_AllDirtyFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.AllDirtyFlag"
                );
        }

        
        public static async ValueTask<decimal> get_MATERIAL_OPAQUE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MATERIAL_OPAQUE"
                );
        }

        
        public static async ValueTask<decimal> get_MATERIAL_ALPHATEST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MATERIAL_ALPHATEST"
                );
        }

        
        public static async ValueTask<decimal> get_MATERIAL_ALPHABLEND()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MATERIAL_ALPHABLEND"
                );
        }

        
        public static async ValueTask<decimal> get_MATERIAL_ALPHATESTANDBLEND()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MATERIAL_ALPHATESTANDBLEND"
                );
        }

        
        public static async ValueTask<decimal> get_MATERIAL_NORMALBLENDMETHOD_WHITEOUT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MATERIAL_NORMALBLENDMETHOD_WHITEOUT"
                );
        }

        
        public static async ValueTask<decimal> get_MATERIAL_NORMALBLENDMETHOD_RNM()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Material.MATERIAL_NORMALBLENDMETHOD_RNM"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<Material> Parse(object parsedMaterial, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Material", "Parse" }, parsedMaterial, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_canRenderToMRT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRenderToMRT"
                );
        }

        
        public async ValueTask<decimal> get_alpha()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
        }
        public ValueTask set_alpha(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
        }

        
        public async ValueTask<bool> get_backFaceCulling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "backFaceCulling"
                );
        }
        public ValueTask set_backFaceCulling(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backFaceCulling",
                    value
                );
        }

        
        public async ValueTask<bool> get_hasRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasRenderTargetTextures"
                );
        }

        private Observable<AbstractMesh> __onBindObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onBindObservable()
        {
            if(__onBindObservable == null)
            {
                __onBindObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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

        private Observable<Material> __onUnBindObservable;
        public async ValueTask<Observable<Material>> get_onUnBindObservable()
        {
            if(__onUnBindObservable == null)
            {
                __onUnBindObservable = await EventHorizonBlazorInterop.GetClass<Observable<Material>>(
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

        private Observable<CachedEntity> __onEffectCreatedObservable;
        public async ValueTask<Observable<CachedEntity>> get_onEffectCreatedObservable()
        {
            if(__onEffectCreatedObservable == null)
            {
                __onEffectCreatedObservable = await EventHorizonBlazorInterop.GetClass<Observable<CachedEntity>>(
                    this.___guid,
                    "onEffectCreatedObservable",
                    (entity) =>
                    {
                        return new Observable<CachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onEffectCreatedObservable;
        }

        
        public async ValueTask<decimal> get_alphaMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaMode"
                );
        }
        public ValueTask set_alphaMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_needDepthPrePass()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needDepthPrePass"
                );
        }
        public ValueTask set_needDepthPrePass(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needDepthPrePass",
                    value
                );
        }

        
        public async ValueTask<bool> get_fogEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
        }
        public ValueTask set_fogEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_wireframe()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "wireframe"
                );
        }
        public ValueTask set_wireframe(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wireframe",
                    value
                );
        }

        
        public async ValueTask<bool> get_pointsCloud()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "pointsCloud"
                );
        }
        public ValueTask set_pointsCloud(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointsCloud",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fillMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fillMode"
                );
        }
        public ValueTask set_fillMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fillMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_isFrozen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFrozen"
                );
        }

        
        public async ValueTask<decimal> get_transparencyMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transparencyMode"
                );
        }
        public ValueTask set_transparencyMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transparencyMode",
                    value
                );
        }
        #endregion

        #region Properties
        private ShadowDepthWrapper __shadowDepthWrapper;
        public async ValueTask<ShadowDepthWrapper> get_shadowDepthWrapper()
        {
            if(__shadowDepthWrapper == null)
            {
                __shadowDepthWrapper = await EventHorizonBlazorInterop.GetClass<ShadowDepthWrapper>(
                    this.___guid,
                    "shadowDepthWrapper",
                    (entity) =>
                    {
                        return new ShadowDepthWrapper() { ___guid = entity.___guid };
                    }
                );
            }
            return __shadowDepthWrapper;
        }
        public ValueTask set_shadowDepthWrapper(ShadowDepthWrapper value)
        {
__shadowDepthWrapper = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowDepthWrapper",
                    value
                );
        }

        
        public async ValueTask<bool> get_allowShaderHotSwapping()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowShaderHotSwapping"
                );
        }
        public ValueTask set_allowShaderHotSwapping(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowShaderHotSwapping",
                    value
                );
        }

        
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

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }
        public ValueTask set_uniqueId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
        }

        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_metadata()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_metadata(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metadata",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_reservedDataStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "reservedDataStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_reservedDataStore(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reservedDataStore",
                    value
                );
        }

        
        public async ValueTask<bool> get_checkReadyOnEveryCall()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkReadyOnEveryCall"
                );
        }
        public ValueTask set_checkReadyOnEveryCall(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkReadyOnEveryCall",
                    value
                );
        }

        
        public async ValueTask<bool> get_checkReadyOnlyOnce()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkReadyOnlyOnce"
                );
        }
        public ValueTask set_checkReadyOnlyOnce(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkReadyOnlyOnce",
                    value
                );
        }

        
        public async ValueTask<string> get_state()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "state"
                );
        }
        public ValueTask set_state(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
        }

        
        public async ValueTask<IInspectableCachedEntity[]> get_inspectableCustomProperties()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IInspectableCachedEntity>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_inspectableCustomProperties(IInspectableCachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sideOrientation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sideOrientation"
                );
        }
        public ValueTask set_sideOrientation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sideOrientation",
                    value
                );
        }

        
        public async ValueTask<ActionCallback<Effect>> get_onCompiled()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<Effect>>(
                    this.___guid,
                    "onCompiled"
                );
        }
        public ValueTask set_onCompiled(ActionCallback<Effect> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
        }

        
        public async ValueTask<ActionCallback<Effect, string>> get_onError()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<Effect, string>>(
                    this.___guid,
                    "onError"
                );
        }
        public ValueTask set_onError(ActionCallback<Effect, string> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onError",
                    value
                );
        }

        
        public async ValueTask<ActionCallback> get_getRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback>(
                    this.___guid,
                    "getRenderTargetTextures"
                );
        }
        public ValueTask set_getRenderTargetTextures(ActionCallback value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "getRenderTargetTextures",
                    value
                );
        }

        
        public async ValueTask<bool> get_doNotSerialize()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
        }
        public ValueTask set_doNotSerialize(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotSerialize",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

        private Observable<Material> __onDisposeObservable;
        public async ValueTask<Observable<Material>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Material>>(
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
        public ValueTask set_onDisposeObservable(Observable<Material> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableDepthWrite()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableDepthWrite"
                );
        }
        public ValueTask set_disableDepthWrite(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableDepthWrite",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableColorWrite()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableColorWrite"
                );
        }
        public ValueTask set_disableColorWrite(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableColorWrite",
                    value
                );
        }

        
        public async ValueTask<bool> get_forceDepthWrite()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceDepthWrite"
                );
        }
        public ValueTask set_forceDepthWrite(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceDepthWrite",
                    value
                );
        }

        
        public async ValueTask<decimal> get_depthFunction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthFunction"
                );
        }
        public ValueTask set_depthFunction(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthFunction",
                    value
                );
        }

        
        public async ValueTask<bool> get_separateCullingPass()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "separateCullingPass"
                );
        }
        public ValueTask set_separateCullingPass(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "separateCullingPass",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pointSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointSize"
                );
        }
        public ValueTask set_pointSize(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointSize",
                    value
                );
        }

        
        public async ValueTask<decimal> get_zOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zOffset"
                );
        }
        public ValueTask set_zOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zOffset",
                    value
                );
        }

        private AbstractMesh __meshMap;
        public async ValueTask<AbstractMesh> get_meshMap()
        {
            if(__meshMap == null)
            {
                __meshMap = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "meshMap",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __meshMap;
        }
        public ValueTask set_meshMap(AbstractMesh value)
        {
__meshMap = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "meshMap",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Material() : base() { }

        public Material(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Material> NewMaterial(
            string name, Scene scene, System.Nullable<bool> doNotAdd = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Material" },
                name, scene, doNotAdd
            );

            return new Material(entity);
        }
        #endregion

        #region Methods
        #region customShaderNameResolve TODO: Get Comments as metadata identification
        private bool _isCustomShaderNameResolveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customShaderNameResolveActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> customShaderNameResolve(
            Func<Task> callback
        )
        {
            await SetupCustomShaderNameResolveLoop();

            var handle = Guid.NewGuid().ToString();
            _customShaderNameResolveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCustomShaderNameResolveLoop()
        {
            if (_isCustomShaderNameResolveEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "customShaderNameResolve",
                "CallCustomShaderNameResolveActions",
                _invokableReference
            );
            _isCustomShaderNameResolveEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomShaderNameResolveActions()
        {
            foreach (var action in _customShaderNameResolveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
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

        public async ValueTask freeze()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeze" }
                }
            );
        }

        public async ValueTask unfreeze()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreeze" }
                }
            );
        }

        public async ValueTask<bool> isReady(AbstractMesh mesh = null, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, mesh, useInstances
                }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public async ValueTask<Effect> getEffect()
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public async ValueTask<bool> needAlphaBlending()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public async ValueTask<bool> needAlphaBlendingForMesh(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlendingForMesh" }, mesh
                }
            );
        }

        public async ValueTask<bool> needAlphaTesting()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public async ValueTask<BaseTexture> getAlphaTestTexture()
        {
            return await EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAlphaTestTexture" }
                }
            );
        }

        public async ValueTask markDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markDirty" }
                }
            );
        }

        public async ValueTask bind(Matrix world, Mesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, world, mesh
                }
            );
        }

        public async ValueTask bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public async ValueTask bindOnlyWorldMatrix(Matrix world)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public async ValueTask bindSceneUniformBuffer(Effect effect, UniformBuffer sceneUbo)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindSceneUniformBuffer" }, effect, sceneUbo
                }
            );
        }

        public async ValueTask bindView(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindView" }, effect
                }
            );
        }

        public async ValueTask bindViewProjection(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindViewProjection" }, effect
                }
            );
        }

        public async ValueTask unbind()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public async ValueTask<BaseTexture[]> getActiveTextures()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public async ValueTask<Material> clone(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public async ValueTask<AbstractMesh[]> getBindedMeshes()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBindedMeshes" }
                }
            );
        }

        public async ValueTask forceCompilation(AbstractMesh mesh, ActionCallback<Material> onCompiled = null, IMaterialCompilationOptions options = null, ActionCallback<string> onError = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilation" }, mesh, onCompiled, options, onError
                }
            );
        }

        public async ValueTask forceCompilationAsync(AbstractMesh mesh, IMaterialCompilationOptions options = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, mesh, options
                }
            );
        }

        public async ValueTask markAsDirty(decimal flag)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }, flag
                }
            );
        }

        public async ValueTask<bool> setPrePassRenderer(PrePassRenderer prePassRenderer)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "setPrePassRenderer" }, prePassRenderer
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> notBoundToMesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, notBoundToMesh
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