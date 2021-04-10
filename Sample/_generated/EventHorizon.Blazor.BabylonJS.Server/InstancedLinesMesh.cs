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

    
    
    [JsonConverter(typeof(CachedEntityConverter<InstancedLinesMesh>))]
    public class InstancedLinesMesh : InstancedMesh
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
        
        public async ValueTask<decimal> get_intersectionThreshold()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intersectionThreshold"
                );
        }
        public ValueTask set_intersectionThreshold(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intersectionThreshold",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public InstancedLinesMesh() : base() { }

        public InstancedLinesMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<InstancedLinesMesh> NewInstancedLinesMesh(
            string name, LinesMesh source
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedLinesMesh" },
                name, source
            );

            return new InstancedLinesMesh(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}