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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationPropertiesOverride>))]
    public class AnimationPropertiesOverride : CachedEntityObject
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
        
        public async ValueTask<bool> get_enableBlending()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableBlending"
                );
        }
        public ValueTask set_enableBlending(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableBlending",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blendingSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendingSpeed"
                );
        }
        public ValueTask set_blendingSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendingSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_loopMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopMode"
                );
        }
        public ValueTask set_loopMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopMode",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public AnimationPropertiesOverride() : base() { } 

        public AnimationPropertiesOverride(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}