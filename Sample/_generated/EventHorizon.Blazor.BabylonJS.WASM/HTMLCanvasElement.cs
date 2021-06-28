/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
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
        
        public bool isRecording
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRecording"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRecording",
                    value
                );
            }
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
        public void requestPointerLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "requestPointerLock" }
                }
            );
        }

        public void msRequestPointerLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "msRequestPointerLock" }
                }
            );
        }

        public void mozRequestPointerLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "mozRequestPointerLock" }
                }
            );
        }

        public void webkitRequestPointerLock()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "webkitRequestPointerLock" }
                }
            );
        }

        public MediaStream captureStream(System.Nullable<decimal> fps = null)
        {
            return EventHorizonBlazorInterop.FuncClass<MediaStream>(
                entity => new MediaStream() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "captureStream" }, fps
                }
            );
        }
    #endregion
}
