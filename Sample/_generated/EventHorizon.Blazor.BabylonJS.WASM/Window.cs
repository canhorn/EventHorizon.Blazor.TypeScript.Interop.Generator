/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface Window : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WindowCachedEntity>))]
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
                __mozIndexedDB = EventHorizonBlazorInterop.GetClass<IDBFactory>(
                    this.___guid,
                    "mozIndexedDB",
                    (entity) =>
                    {
                        return new IDBFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __mozIndexedDB;
            }
            set
            {
__mozIndexedDB = null;
                EventHorizonBlazorInterop.Set(
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
                __webkitIndexedDB = EventHorizonBlazorInterop.GetClass<IDBFactory>(
                    this.___guid,
                    "webkitIndexedDB",
                    (entity) =>
                    {
                        return new IDBFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __webkitIndexedDB;
            }
            set
            {
__webkitIndexedDB = null;
                EventHorizonBlazorInterop.Set(
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
                __msIndexedDB = EventHorizonBlazorInterop.GetClass<IDBFactory>(
                    this.___guid,
                    "msIndexedDB",
                    (entity) =>
                    {
                        return new IDBFactory() { ___guid = entity.___guid };
                    }
                );
            }
            return __msIndexedDB;
            }
            set
            {
__msIndexedDB = null;
                EventHorizonBlazorInterop.Set(
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
                __webkitURL = EventHorizonBlazorInterop.GetClass<URL>(
                    this.___guid,
                    "webkitURL",
                    (entity) =>
                    {
                        return new URL() { ___guid = entity.___guid };
                    }
                );
            }
            return __webkitURL;
            }
            set
            {
__webkitURL = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "webkitURL",
                    value
                );
            }
        }

        private WebGLRenderingContextCachedEntity __WebGLRenderingContext;
        public WebGLRenderingContextCachedEntity WebGLRenderingContext
        {
            get
            {
            if(__WebGLRenderingContext == null)
            {
                __WebGLRenderingContext = EventHorizonBlazorInterop.GetClass<WebGLRenderingContextCachedEntity>(
                    this.___guid,
                    "WebGLRenderingContext",
                    (entity) =>
                    {
                        return new WebGLRenderingContextCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __WebGLRenderingContext;
            }
            set
            {
__WebGLRenderingContext = null;
                EventHorizonBlazorInterop.Set(
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
                __MSGesture = EventHorizonBlazorInterop.GetClass<MSGesture>(
                    this.___guid,
                    "MSGesture",
                    (entity) =>
                    {
                        return new MSGesture() { ___guid = entity.___guid };
                    }
                );
            }
            return __MSGesture;
            }
            set
            {
__MSGesture = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "CANNON",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __AudioContext = EventHorizonBlazorInterop.GetClass<AudioContext>(
                    this.___guid,
                    "AudioContext",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __AudioContext;
            }
            set
            {
__AudioContext = null;
                EventHorizonBlazorInterop.Set(
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
                __webkitAudioContext = EventHorizonBlazorInterop.GetClass<AudioContext>(
                    this.___guid,
                    "webkitAudioContext",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __webkitAudioContext;
            }
            set
            {
__webkitAudioContext = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "PointerEvent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PointerEvent",
                    value
                );
            }
        }

        private MathCachedEntity __Math;
        public MathCachedEntity Math
        {
            get
            {
            if(__Math == null)
            {
                __Math = EventHorizonBlazorInterop.GetClass<MathCachedEntity>(
                    this.___guid,
                    "Math",
                    (entity) =>
                    {
                        return new MathCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __Math;
            }
            set
            {
__Math = null;
                EventHorizonBlazorInterop.Set(
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
                __Uint8Array = EventHorizonBlazorInterop.GetClass<Uint8ArrayConstructor>(
                    this.___guid,
                    "Uint8Array",
                    (entity) =>
                    {
                        return new Uint8ArrayConstructor() { ___guid = entity.___guid };
                    }
                );
            }
            return __Uint8Array;
            }
            set
            {
__Uint8Array = null;
                EventHorizonBlazorInterop.Set(
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
                __Float32Array = EventHorizonBlazorInterop.GetClass<Float32ArrayConstructor>(
                    this.___guid,
                    "Float32Array",
                    (entity) =>
                    {
                        return new Float32ArrayConstructor() { ___guid = entity.___guid };
                    }
                );
            }
            return __Float32Array;
            }
            set
            {
__Float32Array = null;
                EventHorizonBlazorInterop.Set(
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
                __mozURL = EventHorizonBlazorInterop.GetClass<URL>(
                    this.___guid,
                    "mozURL",
                    (entity) =>
                    {
                        return new URL() { ___guid = entity.___guid };
                    }
                );
            }
            return __mozURL;
            }
            set
            {
__mozURL = null;
                EventHorizonBlazorInterop.Set(
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
                __msURL = EventHorizonBlazorInterop.GetClass<URL>(
                    this.___guid,
                    "msURL",
                    (entity) =>
                    {
                        return new URL() { ___guid = entity.___guid };
                    }
                );
            }
            return __msURL;
            }
            set
            {
__msURL = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "VRFrameData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "DracoDecoderModule",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "mozRequestAnimationFrame" }, callback
                }
            );
        }

        public decimal oRequestAnimationFrame(FrameRequestCallback callback)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "oRequestAnimationFrame" }, callback
                }
            );
        }

        public decimal setImmediate(ActionCallback<CachedEntity[]> handler)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "setImmediate" }, handler
                }
            );
        }
    #endregion
}
