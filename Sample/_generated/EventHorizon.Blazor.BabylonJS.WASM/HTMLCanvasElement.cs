/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface HTMLCanvasElement : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isRecording"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "requestPointerLock" }
                }
            );
        }

        public void msRequestPointerLock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "msRequestPointerLock" }
                }
            );
        }

        public void mozRequestPointerLock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "mozRequestPointerLock" }
                }
            );
        }

        public void webkitRequestPointerLock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "webkitRequestPointerLock" }
                }
            );
        }

        public MediaStream captureStream(System.Nullable<decimal> fps = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<MediaStream>(
                entity => new MediaStream() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "captureStream" }, fps
                }
            );
        }
        #endregion
    }
}