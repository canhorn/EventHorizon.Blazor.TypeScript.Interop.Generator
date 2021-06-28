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
        
        public string[] remappedVariables
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "remappedVariables"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "remappedVariables",
                    value
                );
            }
        }

        
        public bool standalone
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "standalone"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "standalone",
                    value
                );
            }
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