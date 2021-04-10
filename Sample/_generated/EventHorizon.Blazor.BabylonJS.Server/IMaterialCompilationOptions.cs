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

    public interface IMaterialCompilationOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IMaterialCompilationOptionsCachedEntity>))]
    public class IMaterialCompilationOptionsCachedEntity : CachedEntityObject, IMaterialCompilationOptions
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
        
        public async ValueTask<bool> get_clipPlane()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clipPlane"
                );
        }
        public ValueTask set_clipPlane(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane",
                    value
                );
        }

        
        public async ValueTask<bool> get_useInstances()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useInstances"
                );
        }
        public ValueTask set_useInstances(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useInstances",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IMaterialCompilationOptionsCachedEntity() : base() { }

        public IMaterialCompilationOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}