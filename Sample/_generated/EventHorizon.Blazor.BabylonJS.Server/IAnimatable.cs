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

    public interface IAnimatable : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IAnimatableCachedEntity>))]
    public class IAnimatableCachedEntity : CachedEntityObject, IAnimatable
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
        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IAnimatableCachedEntity() : base() { }

        public IAnimatableCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}