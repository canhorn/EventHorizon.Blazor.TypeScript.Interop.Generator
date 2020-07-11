/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ICullable { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ICullableCachedEntity : CachedEntityObject, ICullable
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

        #endregion
        
        #region Constructor
        public ICullableCachedEntity() : base() { }

        public ICullableCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public bool isInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public bool isCompletelyInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, frustumPlanes
                }
            );
        }
        #endregion
    }
}