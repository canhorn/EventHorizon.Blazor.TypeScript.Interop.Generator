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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MeshLODLevel>))]
    public class MeshLODLevel : CachedEntityObject
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

        private Mesh __mesh;
        public async ValueTask<Mesh> get_mesh()
        {
            if(__mesh == null)
            {
                __mesh = await EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "mesh",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __mesh;
        }
        public ValueTask set_mesh(Mesh value)
        {
__mesh = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mesh",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public MeshLODLevel() : base() { } 

        public MeshLODLevel(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<MeshLODLevel> NewMeshLODLevel(
            decimal distance, Mesh mesh
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MeshLODLevel" },
                distance, mesh
            );

            return new MeshLODLevel(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}