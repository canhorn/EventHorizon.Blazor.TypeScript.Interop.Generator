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

    
    
    [JsonConverter(typeof(CachedEntityConverter<GroundMesh>))]
    public class GroundMesh : Mesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static GroundMesh Parse(object parsedMesh, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GroundMesh", "Parse" }, parsedMesh, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal subdivisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisions"
                );
            }
        }

        
        public decimal subdivisionsX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisionsX"
                );
            }
        }

        
        public decimal subdivisionsY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisionsY"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool generateOctree
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateOctree"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateOctree",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public GroundMesh() : base() { }

        public GroundMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public GroundMesh(
            string name, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GroundMesh" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void optimize(decimal chunksCount, System.Nullable<decimal> octreeBlocksSize = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "optimize" }, chunksCount, octreeBlocksSize
                }
            );
        }

        public decimal getHeightAtCoordinates(decimal x, decimal z)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHeightAtCoordinates" }, x, z
                }
            );
        }

        public Vector3 getNormalAtCoordinates(decimal x, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNormalAtCoordinates" }, x, z
                }
            );
        }

        public GroundMesh getNormalAtCoordinatesToRef(decimal x, decimal z, Vector3 @ref)
        {
            return EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNormalAtCoordinatesToRef" }, x, z, @ref
                }
            );
        }

        public GroundMesh updateCoordinateHeights()
        {
            return EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateCoordinateHeights" }
                }
            );
        }

        public void serialize(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, serializationObject
                }
            );
        }
        #endregion
    }
}