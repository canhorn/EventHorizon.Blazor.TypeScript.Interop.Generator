/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using Microsoft.JSInterop;

public interface HTMLCanvasElement : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<HTMLCanvasElementCachedEntity>))]
public class HTMLCanvasElementCachedEntity : CachedEntityObject, HTMLCanvasElement
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
        
        public async ValueTask<bool> get_isRecording()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRecording"
                );
        }
        public ValueTask set_isRecording(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRecording",
                    value
                );
        }
    #endregion
    
    #region Constructor
        public HTMLCanvasElementCachedEntity() : base() { }

        public HTMLCanvasElementCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public async ValueTask requestPointerLock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "requestPointerLock" }
                }
            );
        }

        public async ValueTask msRequestPointerLock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "msRequestPointerLock" }
                }
            );
        }

        public async ValueTask mozRequestPointerLock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "mozRequestPointerLock" }
                }
            );
        }

        public async ValueTask webkitRequestPointerLock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "webkitRequestPointerLock" }
                }
            );
        }

        public async ValueTask<MediaStream> captureStream(System.Nullable<decimal> fps = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<MediaStream>(
                entity => new MediaStream() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "captureStream" }, fps
                }
            );
        }
    #endregion
}