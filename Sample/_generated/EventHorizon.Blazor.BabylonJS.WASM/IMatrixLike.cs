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
        
        public decimal updateFlag
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateFlag"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateFlag",
                    value
                );
            }
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
        public decimal[] toArray()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "toArray" }
                }
            );
        }
        #endregion
    }
}