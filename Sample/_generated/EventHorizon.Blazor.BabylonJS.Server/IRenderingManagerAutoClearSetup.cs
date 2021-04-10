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

    public interface IRenderingManagerAutoClearSetup : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IRenderingManagerAutoClearSetupCachedEntity>))]
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

        
        public async ValueTask<bool> get_depth()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depth"
                );
        }
        public ValueTask set_depth(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
        }

        
        public async ValueTask<bool> get_stencil()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "stencil"
                );
        }
        public ValueTask set_stencil(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stencil",
                    value
                );
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