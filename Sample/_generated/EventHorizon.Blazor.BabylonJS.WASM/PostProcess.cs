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
    public class PostProcess : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __inputTexture = EventHorizonBlazorInteropt.GetClass<InternalTexture>(
                    this.___guid,
                    "inputTexture",
                    (entity) =>
                    {
                        return new InternalTexture(entity);
                    }
                );
            }
            return __inputTexture;
            }
            set
            {
__inputTexture = null;
                EventHorizonBlazorInteropt.Set(
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
                __texelSize = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "texelSize",
                    (entity) =>
                    {
                        return new Vector2(entity);
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
            }
        }

        
        public decimal aspectRatio
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "aspectRatio"
                );
            }
        }
        #endregion

        #region Properties
        
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

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal renderTargetSamplingMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "renderTargetSamplingMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __clearColor = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "clearColor",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __clearColor;
            }
            set
            {
__clearColor = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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

        private Color4 __alphaConstants;
        public Color4 alphaConstants
        {
            get
            {
            if(__alphaConstants == null)
            {
                __alphaConstants = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "alphaConstants",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __alphaConstants;
            }
            set
            {
__alphaConstants = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation(entity);
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

        
        public bool enablePixelPerfectMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enablePixelPerfectMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "forceFullscreenViewport"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "forceFullscreenViewport",
                    value
                );
            }
        }

        
        public IInspectable[] inspectableCustomProperties
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IInspectable>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity(entity);
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

        
        public decimal scaleMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "scaleMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "alwaysForcePOT"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "adaptScaleToCurrentViewport"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "adaptScaleToCurrentViewport",
                    value
                );
            }
        }

        private Observable __onActivateObservable;
        public Observable onActivateObservable
        {
            get
            {
            if(__onActivateObservable == null)
            {
                __onActivateObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onActivateObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onActivateObservable;
            }
            set
            {
__onActivateObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onActivateObservable",
                    value
                );
            }
        }

        private Observable __onSizeChangedObservable;
        public Observable onSizeChangedObservable
        {
            get
            {
            if(__onSizeChangedObservable == null)
            {
                __onSizeChangedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onSizeChangedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onSizeChangedObservable;
            }
            set
            {
__onSizeChangedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onSizeChangedObservable",
                    value
                );
            }
        }

        private Observable __onApplyObservable;
        public Observable onApplyObservable
        {
            get
            {
            if(__onApplyObservable == null)
            {
                __onApplyObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onApplyObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onApplyObservable;
            }
            set
            {
__onApplyObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onApplyObservable",
                    value
                );
            }
        }

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
            set
            {
__onBeforeRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
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
            set
            {
__onAfterRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
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
            string name, string fragmentUrl, string[] parameters, string[] samplers, decimal options, Camera camera, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, string defines = null, System.Nullable<decimal> textureType = null, string vertexUrl = null, CachedEntity indexParameters = null, System.Nullable<bool> blockCompilation = null, System.Nullable<decimal> textureFormat = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "PostProcess" },
                name, fragmentUrl, parameters, samplers, options, camera, samplingMode, engine, reusable, defines, textureType, vertexUrl, indexParameters, blockCompilation, textureFormat
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getEffectName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getEffectName" }
                }
            );
        }

        public Camera getCamera()
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCamera" }
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

        public Engine getEngine()
        {
            return EventHorizonBlazorInteropt.FuncClass<Engine>(
                entity => new Engine(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public Effect getEffect()
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public PostProcess shareOutputWith(PostProcess postProcess)
        {
            return EventHorizonBlazorInteropt.FuncClass<PostProcess>(
                entity => new PostProcess(entity),
                new object[] 
                {
                    new string[] { this.___guid, "shareOutputWith" }, postProcess
                }
            );
        }

        public void useOwnOutput()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "useOwnOutput" }
                }
            );
        }

        #region updateEffect TODO: Get Comments as metadata identification
        private bool _isUpdateEffectEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateEffectActionMap = new Dictionary<string, Func<Task>>();

        public string updateEffect(
            Func<Task> callback
        )
        {
            SetupUpdateEffectLoop();

            var handle = Guid.NewGuid().ToString();
            _updateEffectActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateEffectLoop()
        {
            if (_isUpdateEffectEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateEffect",
                "CallUpdateEffectActions",
                _invokableReference
            );
            _isUpdateEffectEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateEffectActions()
        {
            foreach (var action in _updateEffectActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public bool isReusable()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReusable" }
                }
            );
        }

        public void markTextureDirty()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markTextureDirty" }
                }
            );
        }

        public InternalTexture activate(Camera camera, InternalTexture sourceTexture = null, System.Nullable<bool> forceDepthStencil = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "activate" }, camera, sourceTexture, forceDepthStencil
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public Effect apply()
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect(entity),
                new object[] 
                {
                    new string[] { this.___guid, "apply" }
                }
            );
        }

        public void dispose(Camera camera = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, camera
                }
            );
        }
        #endregion
    }
}