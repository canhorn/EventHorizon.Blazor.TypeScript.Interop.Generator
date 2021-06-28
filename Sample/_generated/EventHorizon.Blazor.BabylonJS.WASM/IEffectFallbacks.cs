/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
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
        
        public bool hasMoreFallbacks
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasMoreFallbacks"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasMoreFallbacks",
                    value
                );
            }
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
        public string reduce(string currentDefines, Effect effect)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "reduce" }, currentDefines, effect
                }
            );
        }

        public void unBindMesh()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unBindMesh" }
                }
            );
        }
        #endregion
    }
}