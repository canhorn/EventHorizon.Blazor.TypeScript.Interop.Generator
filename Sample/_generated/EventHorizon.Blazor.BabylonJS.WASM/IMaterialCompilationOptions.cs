/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IMaterialCompilationOptions { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "clipPlane"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useInstances"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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