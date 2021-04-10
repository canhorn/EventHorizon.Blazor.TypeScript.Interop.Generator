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

    
    
    [JsonConverter(typeof(CachedEntityConverter<GroundMesh>))]
    public class GroundMesh : Mesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<GroundMesh> Parse(object parsedMesh, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "GroundMesh", "Parse" }, parsedMesh, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_subdivisions()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisions"
                );
        }

        
        public async ValueTask<decimal> get_subdivisionsX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisionsX"
                );
        }

        
        public async ValueTask<decimal> get_subdivisionsY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisionsY"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_generateOctree()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateOctree"
                );
        }
        public ValueTask set_generateOctree(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateOctree",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public GroundMesh() : base() { }

        public GroundMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<GroundMesh> NewGroundMesh(
            string name, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GroundMesh" },
                name, scene
            );

            return new GroundMesh(entity);
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

        public async ValueTask optimize(decimal chunksCount, System.Nullable<decimal> octreeBlocksSize = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "optimize" }, chunksCount, octreeBlocksSize
                }
            );
        }

        public async ValueTask<decimal> getHeightAtCoordinates(decimal x, decimal z)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHeightAtCoordinates" }, x, z
                }
            );
        }

        public async ValueTask<Vector3> getNormalAtCoordinates(decimal x, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getNormalAtCoordinates" }, x, z
                }
            );
        }

        public async ValueTask<GroundMesh> getNormalAtCoordinatesToRef(decimal x, decimal z, Vector3 @ref)
        {
            return await EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getNormalAtCoordinatesToRef" }, x, z, @ref
                }
            );
        }

        public async ValueTask<GroundMesh> updateCoordinateHeights()
        {
            return await EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateCoordinateHeights" }
                }
            );
        }

        public async ValueTask serialize(object serializationObject)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializationObject
                }
            );
        }
        #endregion
    }
}