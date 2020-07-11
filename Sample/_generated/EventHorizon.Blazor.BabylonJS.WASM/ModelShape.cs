/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ModelShape : CachedEntityObject
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
        
        public decimal shapeID
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shapeID"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shapeID",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ModelShape() : base() { } 

        public ModelShape(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ModelShape(
            decimal id, Vector3[] shape, decimal[] indices, decimal[] normals, decimal[] colors, decimal[] shapeUV, SolidParticle posFunction, Vector3 vtxFunction, Material material
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "ModelShape" },
                id, shape, indices, normals, colors, shapeUV, posFunction, vtxFunction, material
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}