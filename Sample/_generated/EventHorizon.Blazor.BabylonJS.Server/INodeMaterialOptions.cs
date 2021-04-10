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
        
        public async ValueTask<bool> get_emitComments()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emitComments"
                );
        }
        public ValueTask set_emitComments(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitComments",
                    value
                );
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