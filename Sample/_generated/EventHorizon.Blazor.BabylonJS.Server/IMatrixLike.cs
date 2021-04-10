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

    public interface IMatrixLike : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IMatrixLikeCachedEntity>))]
    public class IMatrixLikeCachedEntity : CachedEntityObject, IMatrixLike
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
        
        public async ValueTask<decimal> get_updateFlag()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateFlag"
                );
        }
        public ValueTask set_updateFlag(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateFlag",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IMatrixLikeCachedEntity() : base() { }

        public IMatrixLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<decimal[]> toArray()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }
                }
            );
        }
        #endregion
    }
}