/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<GoldbergMesh>))]
    public class GoldbergMesh : Mesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<GoldbergMesh> Parse(object parsedMesh, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<GoldbergMesh>(
                entity => new GoldbergMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GoldbergMesh", "Parse" },
                    parsedMesh,
                    scene
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<CachedEntity> get_goldbergData()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "goldbergData",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_goldbergData(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "goldbergData", value);
        }
        #endregion

        #region Constructor
        public GoldbergMesh()
            : base() { }

        public GoldbergMesh(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<GoldbergMesh> NewGoldbergMesh(
            string name,
            Scene scene = null,
            Node parent = null,
            Mesh source = null,
            System.Nullable<bool> doNotCloneChildren = null,
            System.Nullable<bool> clonePhysicsImpostor = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GoldbergMesh" },
                name,
                scene,
                parent,
                source,
                doNotCloneChildren,
                clonePhysicsImpostor
            );

            return new GoldbergMesh(entity);
        }

        public static async ValueTask<GoldbergMesh> NewGoldbergMesh(string name, Scene scene = null)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GoldbergMesh" },
                name,
                scene
            );

            return new GoldbergMesh(entity);
        }

        public static async ValueTask<GoldbergMesh> NewGoldbergMesh(
            string name,
            Scene scene = null,
            System.Nullable<bool> isPure = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GoldbergMesh" },
                name,
                scene,
                isPure
            );

            return new GoldbergMesh(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> relatedGoldbergFace(
            decimal poleOrShared,
            System.Nullable<decimal> fromPole = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "relatedGoldbergFace" },
                    poleOrShared,
                    fromPole
                }
            );
        }

        public async ValueTask setGoldbergFaceColors(decimal colorRange)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setGoldbergFaceColors" }, colorRange }
            );
        }

        public async ValueTask updateGoldbergFaceColors(decimal colorRange)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateGoldbergFaceColors" },
                    colorRange
                }
            );
        }

        public async ValueTask setGoldbergFaceUVs(decimal uvRange)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setGoldbergFaceUVs" }, uvRange }
            );
        }

        public async ValueTask updateGoldbergFaceUVs(decimal uvRange)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateGoldbergFaceUVs" }, uvRange }
            );
        }

        public async ValueTask placeOnGoldbergFaceAt(Mesh mesh, decimal face, Vector3 position)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "placeOnGoldbergFaceAt" },
                    mesh,
                    face,
                    position
                }
            );
        }

        public async ValueTask serialize(object serializationObject)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, serializationObject }
            );
        }
        #endregion
    }
}
