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

    public interface IAnimationKey : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IAnimationKeyCachedEntity>))]
    public class IAnimationKeyCachedEntity : CachedEntityObject, IAnimationKey
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
        
        public async ValueTask<decimal> get_frame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frame"
                );
        }
        public ValueTask set_frame(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frame",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_value()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "value",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_value(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_inTangent()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "inTangent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_inTangent(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inTangent",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_outTangent()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "outTangent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_outTangent(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outTangent",
                    value
                );
        }

        
        public async ValueTask<int> get_interpolation()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "interpolation"
                );
        }
        public ValueTask set_interpolation(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interpolation",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IAnimationKeyCachedEntity() : base() { }

        public IAnimationKeyCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}