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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PostProcess>))]
    public class PostProcess : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static PostProcess Parse(object parsedPostProcess, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "PostProcess", "Parse" }, parsedPostProcess, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
            }
        }

        private InternalTexture __inputTexture;
        public InternalTexture inputTexture
        {
            get
            {
            if(__inputTexture == null)
            {
                __inputTexture = EventHorizonBlazorInterop.GetClass<InternalTexture>(
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
            set
            {
__inputTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputTexture",
                    value
                );
            }
        }

        private Vector2 __texelSize;
        public Vector2 texelSize
        {
            get
            {
            if(__texelSize == null)
            {
                __texelSize = EventHorizonBlazorInterop.GetClass<Vector2>(
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
        }

        
        public bool isSupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
            }
        }

        
        public decimal aspectRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "aspectRatio"
                );
            }
        }
        #endregion

        #region Properties
        
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

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        private NodeMaterial __nodeMaterialSource;
        public NodeMaterial nodeMaterialSource
        {
            get
            {
            if(__nodeMaterialSource == null)
            {
                __nodeMaterialSource = EventHorizonBlazorInterop.GetClass<NodeMaterial>(
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
            set
            {
__nodeMaterialSource = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nodeMaterialSource",
                    value
                );
            }
        }

        
        public decimal renderTargetSamplingMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderTargetSamplingMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTargetSamplingMode",
                    value
                );
            }
        }

        private Color4 __clearColor;
        public Color4 clearColor
        {
            get
            {
            if(__clearColor == null)
            {
                __clearColor = EventHorizonBlazorInterop.GetClass<Color4>(
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
            set
            {
__clearColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
            }
        }

        
        public bool autoClear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
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

        private Color4 __alphaConstants;
        public Color4 alphaConstants
        {
            get
            {
            if(__alphaConstants == null)
            {
                __alphaConstants = EventHorizonBlazorInterop.GetClass<Color4>(
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
            set
            {
__alphaConstants = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaConstants",
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

        
        public bool enablePixelPerfectMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enablePixelPerfectMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enablePixelPerfectMode",
                    value
                );
            }
        }

        
        public bool forceFullscreenViewport
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceFullscreenViewport"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceFullscreenViewport",
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

        
        public decimal scaleMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaleMode",
                    value
                );
            }
        }

        
        public bool alwaysForcePOT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alwaysForcePOT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alwaysForcePOT",
                    value
                );
            }
        }

        
        public bool adaptScaleToCurrentViewport
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "adaptScaleToCurrentViewport"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "adaptScaleToCurrentViewport",
                    value
                );
            }
        }

        private Observable<Camera> __onActivateObservable;
        public Observable<Camera> onActivateObservable
        {
            get
            {
            if(__onActivateObservable == null)
            {
                __onActivateObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
            set
            {
__onActivateObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onActivateObservable",
                    value
                );
            }
        }

        private Observable<PostProcess> __onSizeChangedObservable;
        public Observable<PostProcess> onSizeChangedObservable
        {
            get
            {
            if(__onSizeChangedObservable == null)
            {
                __onSizeChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<PostProcess>>(
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
            set
            {
__onSizeChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onSizeChangedObservable",
                    value
                );
            }
        }

        private Observable<Effect> __onApplyObservable;
        public Observable<Effect> onApplyObservable
        {
            get
            {
            if(__onApplyObservable == null)
            {
                __onApplyObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
            set
            {
__onApplyObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onApplyObservable",
                    value
                );
            }
        }

        private Observable<Effect> __onBeforeRenderObservable;
        public Observable<Effect> onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
            set
            {
__onBeforeRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
            }
        }

        private Observable<Effect> __onAfterRenderObservable;
        public Observable<Effect> onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
            set
            {
__onAfterRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
            }
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

        public PostProcess(
            string name, string fragmentUrl, decimal options, Camera camera, string[] parameters = null, string[] samplers = null, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, string defines = null, System.Nullable<decimal> textureType = null, string vertexUrl = null, object indexParameters = null, System.Nullable<bool> blockCompilation = null, System.Nullable<decimal> textureFormat = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PostProcess" },
                name, fragmentUrl, parameters, samplers, options, camera, samplingMode, engine, reusable, defines, textureType, vertexUrl, indexParameters, blockCompilation, textureFormat
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getEffectName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getEffectName" }
                }
            );
        }

        public void restoreDefaultInputTexture()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "restoreDefaultInputTexture" }
                }
            );
        }

        public Camera getCamera()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCamera" }
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

        public Engine getEngine()
        {
            return EventHorizonBlazorInterop.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEngine" }
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

        public PostProcess shareOutputWith(PostProcess postProcess)
        {
            return EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "shareOutputWith" }, postProcess
                }
            );
        }

        public void useOwnOutput()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "useOwnOutput" }
                }
            );
        }

        public void updateEffect(string defines = null, string[] uniforms = null, string[] samplers = null, object indexParameters = null, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null, string vertexUrl = null, string fragmentUrl = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateEffect" }, defines, uniforms, samplers, indexParameters, onCompiled, onError, vertexUrl, fragmentUrl
                }
            );
        }

        public bool isReusable()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReusable" }
                }
            );
        }

        public void markTextureDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "markTextureDirty" }
                }
            );
        }

        public InternalTexture activate(Camera camera, InternalTexture sourceTexture = null, System.Nullable<bool> forceDepthStencil = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "activate" }, camera, sourceTexture, forceDepthStencil
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public Effect apply()
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "apply" }
                }
            );
        }

        public bool setPrePassRenderer(PrePassRenderer prePassRenderer)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "setPrePassRenderer" }, prePassRenderer
                }
            );
        }

        public void dispose(Camera camera = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, camera
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