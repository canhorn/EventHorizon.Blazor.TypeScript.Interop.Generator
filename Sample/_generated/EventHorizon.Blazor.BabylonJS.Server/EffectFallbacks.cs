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

    
    
    [JsonConverter(typeof(CachedEntityConverter<EffectFallbacks>))]
    public class EffectFallbacks : CachedEntityObject, IEffectFallbacks
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_hasMoreFallbacks()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasMoreFallbacks"
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public EffectFallbacks() : base() { }

        public EffectFallbacks(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask unBindMesh()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unBindMesh" }
                }
            );
        }

        public async ValueTask addFallback(decimal rank, string define)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addFallback" }, rank, define
                }
            );
        }

        public async ValueTask addCPUSkinningFallback(decimal rank, AbstractMesh mesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addCPUSkinningFallback" }, rank, mesh
                }
            );
        }

        public async ValueTask<string> reduce(string currentDefines, Effect effect)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "reduce" }, currentDefines, effect
                }
            );
        }
        #endregion
    }
}