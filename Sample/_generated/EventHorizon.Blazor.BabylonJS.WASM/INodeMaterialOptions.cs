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

    public interface INodeMaterialOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<INodeMaterialOptionsCachedEntity>))]
    public class INodeMaterialOptionsCachedEntity : CachedEntityObject, INodeMaterialOptions
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
        
        public bool emitComments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emitComments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitComments",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public INodeMaterialOptionsCachedEntity() : base() { }

        public INodeMaterialOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}