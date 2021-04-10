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

    
    
    [JsonConverter(typeof(CachedEntityConverter<IntersectionInfo>))]
    public class IntersectionInfo : CachedEntityObject
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
        
        public async ValueTask<decimal> get_bu()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bu"
                );
        }
        public ValueTask set_bu(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bu",
                    value
                );
        }

        
        public async ValueTask<decimal> get_bv()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bv"
                );
        }
        public ValueTask set_bv(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bv",
                    value
                );
        }

        
        public async ValueTask<decimal> get_distance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distance"
                );
        }
        public ValueTask set_distance(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distance",
                    value
                );
        }

        
        public async ValueTask<decimal> get_faceId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "faceId"
                );
        }
        public ValueTask set_faceId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceId",
                    value
                );
        }

        
        public async ValueTask<decimal> get_subMeshId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subMeshId"
                );
        }
        public ValueTask set_subMeshId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshId",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IntersectionInfo() : base() { } 

        public IntersectionInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<IntersectionInfo> NewIntersectionInfo(
            decimal distance, System.Nullable<decimal> bu = null, System.Nullable<decimal> bv = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "IntersectionInfo" },
                bu, bv, distance
            );

            return new IntersectionInfo(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}