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

    public interface IEffectFallbacks : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEffectFallbacksCachedEntity>))]
    public class IEffectFallbacksCachedEntity : CachedEntityObject, IEffectFallbacks
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
        
        public async ValueTask<bool> get_hasMoreFallbacks()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasMoreFallbacks"
                );
        }
        public ValueTask set_hasMoreFallbacks(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasMoreFallbacks",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IEffectFallbacksCachedEntity() : base() { }

        public IEffectFallbacksCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<string> reduce(string currentDefines, Effect effect)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "reduce" }, currentDefines, effect
                }
            );
        }

        public async ValueTask unBindMesh()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unBindMesh" }
                }
            );
        }
        #endregion
    }
}