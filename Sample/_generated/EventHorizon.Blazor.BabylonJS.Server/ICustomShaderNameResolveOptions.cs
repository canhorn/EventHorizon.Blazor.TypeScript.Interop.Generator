/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface ICustomShaderNameResolveOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICustomShaderNameResolveOptionsCachedEntity>))]
    public class ICustomShaderNameResolveOptionsCachedEntity : CachedEntityObject, ICustomShaderNameResolveOptions
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
        
        public async ValueTask<ActionResultCallback<string, string, string>> get_processFinalCode()
        {
            return await EventHorizonBlazorInterop.Get<ActionResultCallback<string, string, string>>(
                    this.___guid,
                    "processFinalCode"
                );
        }
        public ValueTask set_processFinalCode(ActionResultCallback<string, string, string> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "processFinalCode",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ICustomShaderNameResolveOptionsCachedEntity() : base() { }

        public ICustomShaderNameResolveOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}