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
        
        public bool clipPlane
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clipPlane"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane",
                    value
                );
            }
        }

        
        public bool useInstances
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useInstances"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useInstances",
                    value
                );
            }
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