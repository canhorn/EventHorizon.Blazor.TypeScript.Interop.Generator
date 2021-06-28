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
        
        public decimal distance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "distance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "distance",
                    value
                );
            }
        }

        private Mesh __mesh;
        public Mesh mesh
        {
            get
            {
            if(__mesh == null)
            {
                __mesh = EventHorizonBlazorInterop.GetClass<Mesh>(
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
            set
            {
__mesh = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mesh",
                    value
                );
            }
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

        public MeshLODLevel(
            decimal distance, Mesh mesh
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MeshLODLevel" },
                distance, mesh
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}