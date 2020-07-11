/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface Window { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class WindowCachedEntity : CachedEntityObject, Window
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private IDBFactory __mozIndexedDB;
        public IDBFactory mozIndexedDB
        {
            get
            {
            if(__mozIndexedDB == null)
            {
                __mozIndexedDB = EventHorizonBlazorInteropt.GetClass<IDBFactory>(
                    this.___guid,
                    "mozIndexedDB",
                    (entity) =>
                    {
                        return new IDBFactory(entity);
                    }
                );
            }
            return __mozIndexedDB;
            }
            set
            {
__mozIndexedDB = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "mozIndexedDB",
                    value
                );
            }
        }

        private IDBFactory __webkitIndexedDB;
        public IDBFactory webkitIndexedDB
        {
            get
            {
            if(__webkitIndexedDB == null)
            {
                __webkitIndexedDB = EventHorizonBlazorInteropt.GetClass<IDBFactory>(
                    this.___guid,
                    "webkitIndexedDB",
                    (entity) =>
                    {
                        return new IDBFactory(entity);
                    }
                );
            }
            return __webkitIndexedDB;
            }
            set
            {
__webkitIndexedDB = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "webkitIndexedDB",
                    value
                );
            }
        }

        private IDBFactory __msIndexedDB;
        public IDBFactory msIndexedDB
        {
            get
            {
            if(__msIndexedDB == null)
            {
                __msIndexedDB = EventHorizonBlazorInteropt.GetClass<IDBFactory>(
                    this.___guid,
                    "msIndexedDB",
                    (entity) =>
                    {
                        return new IDBFactory(entity);
                    }
                );
            }
            return __msIndexedDB;
            }
            set
            {
__msIndexedDB = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "msIndexedDB",
                    value
                );
            }
        }

        private URL __webkitURL;
        public URL webkitURL
        {
            get
            {
            if(__webkitURL == null)
            {
                __webkitURL = EventHorizonBlazorInteropt.GetClass<URL>(
                    this.___guid,
                    "webkitURL",
                    (entity) =>
                    {
                        return new URL(entity);
                    }
                );
            }
            return __webkitURL;
            }
            set
            {
__webkitURL = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "webkitURL",
                    value
                );
            }
        }

        private WebGLRenderingContext __WebGLRenderingContext;
        public WebGLRenderingContext WebGLRenderingContext
        {
            get
            {
            if(__WebGLRenderingContext == null)
            {
                __WebGLRenderingContext = EventHorizonBlazorInteropt.GetClass<WebGLRenderingContext>(
                    this.___guid,
                    "WebGLRenderingContext",
                    (entity) =>
                    {
                        return new WebGLRenderingContextCachedEntity(entity);
                    }
                );
            }
            return __WebGLRenderingContext;
            }
            set
            {
__WebGLRenderingContext = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "WebGLRenderingContext",
                    value
                );
            }
        }

        private MSGesture __MSGesture;
        public MSGesture MSGesture
        {
            get
            {
            if(__MSGesture == null)
            {
                __MSGesture = EventHorizonBlazorInteropt.GetClass<MSGesture>(
                    this.___guid,
                    "MSGesture",
                    (entity) =>
                    {
                        return new MSGesture(entity);
                    }
                );
            }
            return __MSGesture;
            }
            set
            {
__MSGesture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "MSGesture",
                    value
                );
            }
        }

        
        public CachedEntity CANNON
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "CANNON"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "CANNON",
                    value
                );
            }
        }

        private AudioContext __AudioContext;
        public AudioContext AudioContext
        {
            get
            {
            if(__AudioContext == null)
            {
                __AudioContext = EventHorizonBlazorInteropt.GetClass<AudioContext>(
                    this.___guid,
                    "AudioContext",
                    (entity) =>
                    {
                        return new AudioContext(entity);
                    }
                );
            }
            return __AudioContext;
            }
            set
            {
__AudioContext = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "AudioContext",
                    value
                );
            }
        }

        private AudioContext __webkitAudioContext;
        public AudioContext webkitAudioContext
        {
            get
            {
            if(__webkitAudioContext == null)
            {
                __webkitAudioContext = EventHorizonBlazorInteropt.GetClass<AudioContext>(
                    this.___guid,
                    "webkitAudioContext",
                    (entity) =>
                    {
                        return new AudioContext(entity);
                    }
                );
            }
            return __webkitAudioContext;
            }
            set
            {
__webkitAudioContext = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "webkitAudioContext",
                    value
                );
            }
        }

        
        public CachedEntity PointerEvent
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "PointerEvent"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "PointerEvent",
                    value
                );
            }
        }

        private Math __Math;
        public Math Math
        {
            get
            {
            if(__Math == null)
            {
                __Math = EventHorizonBlazorInteropt.GetClass<Math>(
                    this.___guid,
                    "Math",
                    (entity) =>
                    {
                        return new MathCachedEntity(entity);
                    }
                );
            }
            return __Math;
            }
            set
            {
__Math = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "Math",
                    value
                );
            }
        }

        private Uint8ArrayConstructor __Uint8Array;
        public Uint8ArrayConstructor Uint8Array
        {
            get
            {
            if(__Uint8Array == null)
            {
                __Uint8Array = EventHorizonBlazorInteropt.GetClass<Uint8ArrayConstructor>(
                    this.___guid,
                    "Uint8Array",
                    (entity) =>
                    {
                        return new Uint8ArrayConstructor(entity);
                    }
                );
            }
            return __Uint8Array;
            }
            set
            {
__Uint8Array = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "Uint8Array",
                    value
                );
            }
        }

        private Float32ArrayConstructor __Float32Array;
        public Float32ArrayConstructor Float32Array
        {
            get
            {
            if(__Float32Array == null)
            {
                __Float32Array = EventHorizonBlazorInteropt.GetClass<Float32ArrayConstructor>(
                    this.___guid,
                    "Float32Array",
                    (entity) =>
                    {
                        return new Float32ArrayConstructor(entity);
                    }
                );
            }
            return __Float32Array;
            }
            set
            {
__Float32Array = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "Float32Array",
                    value
                );
            }
        }

        private URL __mozURL;
        public URL mozURL
        {
            get
            {
            if(__mozURL == null)
            {
                __mozURL = EventHorizonBlazorInteropt.GetClass<URL>(
                    this.___guid,
                    "mozURL",
                    (entity) =>
                    {
                        return new URL(entity);
                    }
                );
            }
            return __mozURL;
            }
            set
            {
__mozURL = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "mozURL",
                    value
                );
            }
        }

        private URL __msURL;
        public URL msURL
        {
            get
            {
            if(__msURL == null)
            {
                __msURL = EventHorizonBlazorInteropt.GetClass<URL>(
                    this.___guid,
                    "msURL",
                    (entity) =>
                    {
                        return new URL(entity);
                    }
                );
            }
            return __msURL;
            }
            set
            {
__msURL = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "msURL",
                    value
                );
            }
        }

        
        public CachedEntity VRFrameData
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "VRFrameData"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "VRFrameData",
                    value
                );
            }
        }

        
        public CachedEntity DracoDecoderModule
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "DracoDecoderModule"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "DracoDecoderModule",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WindowCachedEntity() : base() { }

        public WindowCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public decimal mozRequestAnimationFrame(FrameRequestCallback callback)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "mozRequestAnimationFrame" }, callback
                }
            );
        }

        public decimal oRequestAnimationFrame(FrameRequestCallback callback)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "oRequestAnimationFrame" }, callback
                }
            );
        }

        #region setImmediate TODO: Get Comments as metadata identification
        private bool _isSetImmediateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _setImmediateActionMap = new Dictionary<string, Func<Task>>();

        public string setImmediate(
            Func<Task> callback
        )
        {
            SetupSetImmediateLoop();

            var handle = Guid.NewGuid().ToString();
            _setImmediateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupSetImmediateLoop()
        {
            if (_isSetImmediateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "setImmediate",
                "CallSetImmediateActions",
                _invokableReference
            );
            _isSetImmediateEnabled = true;
        }

        [JSInvokable]
        public async Task CallSetImmediateActions()
        {
            foreach (var action in _setImmediateActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}