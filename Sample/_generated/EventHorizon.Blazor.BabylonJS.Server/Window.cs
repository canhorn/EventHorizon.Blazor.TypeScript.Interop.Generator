/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        public async ValueTask<IDBFactory> get_mozIndexedDB()
        {
            if(__mozIndexedDB == null)
            {
                __mozIndexedDB = await EventHorizonBlazorInterop.GetClass<IDBFactory>(
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
        public ValueTask set_mozIndexedDB(IDBFactory value)
        {
__mozIndexedDB = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mozIndexedDB",
                    value
                );
        }

        private IDBFactory __webkitIndexedDB;
        public async ValueTask<IDBFactory> get_webkitIndexedDB()
        {
            if(__webkitIndexedDB == null)
            {
                __webkitIndexedDB = await EventHorizonBlazorInterop.GetClass<IDBFactory>(
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
        public ValueTask set_webkitIndexedDB(IDBFactory value)
        {
__webkitIndexedDB = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "webkitIndexedDB",
                    value
                );
        }

        private IDBFactory __msIndexedDB;
        public async ValueTask<IDBFactory> get_msIndexedDB()
        {
            if(__msIndexedDB == null)
            {
                __msIndexedDB = await EventHorizonBlazorInterop.GetClass<IDBFactory>(
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
        public ValueTask set_msIndexedDB(IDBFactory value)
        {
__msIndexedDB = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "msIndexedDB",
                    value
                );
        }

        private URL __webkitURL;
        public async ValueTask<URL> get_webkitURL()
        {
            if(__webkitURL == null)
            {
                __webkitURL = await EventHorizonBlazorInterop.GetClass<URL>(
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
        public ValueTask set_webkitURL(URL value)
        {
__webkitURL = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "webkitURL",
                    value
                );
        }

        private WebGLRenderingContextCachedEntity __WebGLRenderingContext;
        public async ValueTask<WebGLRenderingContextCachedEntity> get_WebGLRenderingContext()
        {
            if(__WebGLRenderingContext == null)
            {
                __WebGLRenderingContext = await EventHorizonBlazorInterop.GetClass<WebGLRenderingContextCachedEntity>(
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
        public ValueTask set_WebGLRenderingContext(WebGLRenderingContextCachedEntity value)
        {
__WebGLRenderingContext = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "WebGLRenderingContext",
                    value
                );
        }

        private MSGesture __MSGesture;
        public async ValueTask<MSGesture> get_MSGesture()
        {
            if(__MSGesture == null)
            {
                __MSGesture = await EventHorizonBlazorInterop.GetClass<MSGesture>(
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
        public ValueTask set_MSGesture(MSGesture value)
        {
__MSGesture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MSGesture",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_CANNON()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "CANNON",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_CANNON(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "CANNON",
                    value
                );
        }

        private AudioContext __AudioContext;
        public async ValueTask<AudioContext> get_AudioContext()
        {
            if(__AudioContext == null)
            {
                __AudioContext = await EventHorizonBlazorInterop.GetClass<AudioContext>(
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
        public ValueTask set_AudioContext(AudioContext value)
        {
__AudioContext = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "AudioContext",
                    value
                );
        }

        private AudioContext __webkitAudioContext;
        public async ValueTask<AudioContext> get_webkitAudioContext()
        {
            if(__webkitAudioContext == null)
            {
                __webkitAudioContext = await EventHorizonBlazorInterop.GetClass<AudioContext>(
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
        public ValueTask set_webkitAudioContext(AudioContext value)
        {
__webkitAudioContext = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "webkitAudioContext",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_PointerEvent()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "PointerEvent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_PointerEvent(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "PointerEvent",
                    value
                );
        }

        private MathCachedEntity __Math;
        public async ValueTask<MathCachedEntity> get_Math()
        {
            if(__Math == null)
            {
                __Math = await EventHorizonBlazorInterop.GetClass<MathCachedEntity>(
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
        public ValueTask set_Math(MathCachedEntity value)
        {
__Math = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "Math",
                    value
                );
        }

        private Uint8ArrayConstructor __Uint8Array;
        public async ValueTask<Uint8ArrayConstructor> get_Uint8Array()
        {
            if(__Uint8Array == null)
            {
                __Uint8Array = await EventHorizonBlazorInterop.GetClass<Uint8ArrayConstructor>(
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
        public ValueTask set_Uint8Array(Uint8ArrayConstructor value)
        {
__Uint8Array = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "Uint8Array",
                    value
                );
        }

        private Float32ArrayConstructor __Float32Array;
        public async ValueTask<Float32ArrayConstructor> get_Float32Array()
        {
            if(__Float32Array == null)
            {
                __Float32Array = await EventHorizonBlazorInterop.GetClass<Float32ArrayConstructor>(
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
        public ValueTask set_Float32Array(Float32ArrayConstructor value)
        {
__Float32Array = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "Float32Array",
                    value
                );
        }

        private URL __mozURL;
        public async ValueTask<URL> get_mozURL()
        {
            if(__mozURL == null)
            {
                __mozURL = await EventHorizonBlazorInterop.GetClass<URL>(
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
        public ValueTask set_mozURL(URL value)
        {
__mozURL = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mozURL",
                    value
                );
        }

        private URL __msURL;
        public async ValueTask<URL> get_msURL()
        {
            if(__msURL == null)
            {
                __msURL = await EventHorizonBlazorInterop.GetClass<URL>(
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
        public ValueTask set_msURL(URL value)
        {
__msURL = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "msURL",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_VRFrameData()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "VRFrameData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_VRFrameData(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "VRFrameData",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_DracoDecoderModule()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "DracoDecoderModule",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_DracoDecoderModule(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DracoDecoderModule",
                    value
                );
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
        public async ValueTask<decimal> mozRequestAnimationFrame(FrameRequestCallback callback)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "mozRequestAnimationFrame" }, callback
                }
            );
        }

        public async ValueTask<decimal> oRequestAnimationFrame(FrameRequestCallback callback)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "oRequestAnimationFrame" }, callback
                }
            );
        }

        public async ValueTask<decimal> setImmediate(ActionCallback<CachedEntity[]> handler)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "setImmediate" }, handler
                }
            );
        }
    #endregion
}