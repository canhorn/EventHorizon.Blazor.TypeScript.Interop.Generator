/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
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
        
        public bool hasMoreFallbacks
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasMoreFallbacks"
                );
            }
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
        public void unBindMesh()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unBindMesh" }
                }
            );
        }

        public void addFallback(decimal rank, string define)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addFallback" }, rank, define
                }
            );
        }

        public void addCPUSkinningFallback(decimal rank, AbstractMesh mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCPUSkinningFallback" }, rank, mesh
                }
            );
        }

        public string reduce(string currentDefines, Effect effect)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "reduce" }, currentDefines, effect
                }
            );
        }
        #endregion
    }
}