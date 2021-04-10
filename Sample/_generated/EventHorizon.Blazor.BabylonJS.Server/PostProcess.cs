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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PostProcess>))]
    public class PostProcess : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<PostProcess> Parse(object parsedPostProcess, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "PostProcess", "Parse" }, parsedPostProcess, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
        }
        public ValueTask set_samples(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
        }

        private InternalTexture __inputTexture;
        public async ValueTask<InternalTexture> get_inputTexture()
        {
            if(__inputTexture == null)
            {
                __inputTexture = await EventHorizonBlazorInterop.GetClass<InternalTexture>(
                    this.___guid,
                    "inputTexture",
                    (entity) =>
                    {
                        return new InternalTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputTexture;
        }
        public ValueTask set_inputTexture(InternalTexture value)
        {
__inputTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputTexture",
                    value
                );
        }

        private Vector2 __texelSize;
        public async ValueTask<Vector2> get_texelSize()
        {
            if(__texelSize == null)
            {
                __texelSize = await EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "texelSize",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __texelSize;
        }

        
        public async ValueTask<bool> get_isSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
        }

        
        public async ValueTask<decimal> get_aspectRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aspectRatio"
                );
        }
        #endregion

        #region Properties
        
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

        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }

        private NodeMaterial __nodeMaterialSource;
        public async ValueTask<NodeMaterial> get_nodeMaterialSource()
        {
            if(__nodeMaterialSource == null)
            {
                __nodeMaterialSource = await EventHorizonBlazorInterop.GetClass<NodeMaterial>(
                    this.___guid,
                    "nodeMaterialSource",
                    (entity) =>
                    {
                        return new NodeMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            return __nodeMaterialSource;
        }
        public ValueTask set_nodeMaterialSource(NodeMaterial value)
        {
__nodeMaterialSource = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nodeMaterialSource",
                    value
                );
        }

        
        public async ValueTask<decimal> get_renderTargetSamplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderTargetSamplingMode"
                );
        }
        public ValueTask set_renderTargetSamplingMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTargetSamplingMode",
                    value
                );
        }

        private Color4 __clearColor;
        public async ValueTask<Color4> get_clearColor()
        {
            if(__clearColor == null)
            {
                __clearColor = await EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "clearColor",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearColor;
        }
        public ValueTask set_clearColor(Color4 value)
        {
__clearColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
        }

        
        public async ValueTask<bool> get_autoClear()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
        }
        public ValueTask set_autoClear(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
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

        private Color4 __alphaConstants;
        public async ValueTask<Color4> get_alphaConstants()
        {
            if(__alphaConstants == null)
            {
                __alphaConstants = await EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "alphaConstants",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __alphaConstants;
        }
        public ValueTask set_alphaConstants(Color4 value)
        {
__alphaConstants = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaConstants",
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

        
        public async ValueTask<bool> get_enablePixelPerfectMode()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enablePixelPerfectMode"
                );
        }
        public ValueTask set_enablePixelPerfectMode(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enablePixelPerfectMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_forceFullscreenViewport()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceFullscreenViewport"
                );
        }
        public ValueTask set_forceFullscreenViewport(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceFullscreenViewport",
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

        
        public async ValueTask<decimal> get_scaleMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleMode"
                );
        }
        public ValueTask set_scaleMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_alwaysForcePOT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alwaysForcePOT"
                );
        }
        public ValueTask set_alwaysForcePOT(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alwaysForcePOT",
                    value
                );
        }

        
        public async ValueTask<bool> get_adaptScaleToCurrentViewport()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "adaptScaleToCurrentViewport"
                );
        }
        public ValueTask set_adaptScaleToCurrentViewport(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "adaptScaleToCurrentViewport",
                    value
                );
        }

        private Observable<Camera> __onActivateObservable;
        public async ValueTask<Observable<Camera>> get_onActivateObservable()
        {
            if(__onActivateObservable == null)
            {
                __onActivateObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onActivateObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onActivateObservable;
        }
        public ValueTask set_onActivateObservable(Observable<Camera> value)
        {
__onActivateObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onActivateObservable",
                    value
                );
        }

        private Observable<PostProcess> __onSizeChangedObservable;
        public async ValueTask<Observable<PostProcess>> get_onSizeChangedObservable()
        {
            if(__onSizeChangedObservable == null)
            {
                __onSizeChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<PostProcess>>(
                    this.___guid,
                    "onSizeChangedObservable",
                    (entity) =>
                    {
                        return new Observable<PostProcess>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onSizeChangedObservable;
        }
        public ValueTask set_onSizeChangedObservable(Observable<PostProcess> value)
        {
__onSizeChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onSizeChangedObservable",
                    value
                );
        }

        private Observable<Effect> __onApplyObservable;
        public async ValueTask<Observable<Effect>> get_onApplyObservable()
        {
            if(__onApplyObservable == null)
            {
                __onApplyObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onApplyObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onApplyObservable;
        }
        public ValueTask set_onApplyObservable(Observable<Effect> value)
        {
__onApplyObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onApplyObservable",
                    value
                );
        }

        private Observable<Effect> __onBeforeRenderObservable;
        public async ValueTask<Observable<Effect>> get_onBeforeRenderObservable()
        {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeRenderObservable;
        }
        public ValueTask set_onBeforeRenderObservable(Observable<Effect> value)
        {
__onBeforeRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
        }

        private Observable<Effect> __onAfterRenderObservable;
        public async ValueTask<Observable<Effect>> get_onAfterRenderObservable()
        {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderObservable;
        }
        public ValueTask set_onAfterRenderObservable(Observable<Effect> value)
        {
__onAfterRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public PostProcess() : base() { } 

        public PostProcess(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PostProcess> NewPostProcess(
            string name, string fragmentUrl, decimal options, Camera camera, string[] parameters = null, string[] samplers = null, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, string defines = null, System.Nullable<decimal> textureType = null, string vertexUrl = null, object indexParameters = null, System.Nullable<bool> blockCompilation = null, System.Nullable<decimal> textureFormat = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PostProcess" },
                name, fragmentUrl, parameters, samplers, options, camera, samplingMode, engine, reusable, defines, textureType, vertexUrl, indexParameters, blockCompilation, textureFormat
            );

            return new PostProcess(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getEffectName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getEffectName" }
                }
            );
        }

        public async ValueTask restoreDefaultInputTexture()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreDefaultInputTexture" }
                }
            );
        }

        public async ValueTask<Camera> getCamera()
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCamera" }
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

        public async ValueTask<Engine> getEngine()
        {
            return await EventHorizonBlazorInterop.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
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

        public async ValueTask<PostProcess> shareOutputWith(PostProcess postProcess)
        {
            return await EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "shareOutputWith" }, postProcess
                }
            );
        }

        public async ValueTask useOwnOutput()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "useOwnOutput" }
                }
            );
        }

        public async ValueTask updateEffect(string defines = null, string[] uniforms = null, string[] samplers = null, object indexParameters = null, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null, string vertexUrl = null, string fragmentUrl = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateEffect" }, defines, uniforms, samplers, indexParameters, onCompiled, onError, vertexUrl, fragmentUrl
                }
            );
        }

        public async ValueTask<bool> isReusable()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReusable" }
                }
            );
        }

        public async ValueTask markTextureDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markTextureDirty" }
                }
            );
        }

        public async ValueTask<InternalTexture> activate(Camera camera, InternalTexture sourceTexture = null, System.Nullable<bool> forceDepthStencil = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "activate" }, camera, sourceTexture, forceDepthStencil
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask<Effect> apply()
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "apply" }
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

        public async ValueTask dispose(Camera camera = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, camera
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