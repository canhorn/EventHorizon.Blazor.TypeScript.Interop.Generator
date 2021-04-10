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

    public interface IIOptionShadowDepthMaterial : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IIOptionShadowDepthMaterialCachedEntity>))]
    public class IIOptionShadowDepthMaterialCachedEntity : CachedEntityObject, IIOptionShadowDepthMaterial
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
        
        public async ValueTask<string[]> get_remappedVariables()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "remappedVariables"
                );
        }
        public ValueTask set_remappedVariables(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "remappedVariables",
                    value
                );
        }

        
        public async ValueTask<bool> get_standalone()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "standalone"
                );
        }
        public ValueTask set_standalone(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "standalone",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IIOptionShadowDepthMaterialCachedEntity() : base() { }

        public IIOptionShadowDepthMaterialCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}