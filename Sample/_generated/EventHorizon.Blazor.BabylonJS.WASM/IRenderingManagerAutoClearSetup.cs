/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IRenderingManagerAutoClearSetup { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IRenderingManagerAutoClearSetupCachedEntity : CachedEntityObject, IRenderingManagerAutoClearSetup
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

        
        public bool depth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public bool stencil
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "stencil"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencil",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IRenderingManagerAutoClearSetupCachedEntity() : base() { }

        public IRenderingManagerAutoClearSetupCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}