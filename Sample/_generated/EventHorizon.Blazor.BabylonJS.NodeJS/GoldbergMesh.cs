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

    [JsonConverter(typeof(CachedEntityConverter<GoldbergMesh>))]
    public class GoldbergMesh : Mesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static GoldbergMesh Parse(object parsedMesh, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<GoldbergMesh>(
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

        public CachedEntity goldbergData
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "goldbergData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "goldbergData", value);
            }
        }
        #endregion

        #region Constructor
        public GoldbergMesh()
            : base() { }

        public GoldbergMesh(ICachedEntity entity)
            : base(entity) { }

        public GoldbergMesh(
            string name,
            Scene scene = null,
            Node parent = null,
            Mesh source = null,
            System.Nullable<bool> doNotCloneChildren = null,
            System.Nullable<bool> clonePhysicsImpostor = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GoldbergMesh" },
                name,
                scene,
                parent,
                source,
                doNotCloneChildren,
                clonePhysicsImpostor
            );
            ___guid = entity.___guid;
        }

        public GoldbergMesh(string name, Scene scene = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GoldbergMesh" },
                name,
                scene
            );
            ___guid = entity.___guid;
        }

        public GoldbergMesh(string name, Scene scene = null, System.Nullable<bool> isPure = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GoldbergMesh" },
                name,
                scene,
                isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal relatedGoldbergFace(
            decimal poleOrShared,
            System.Nullable<decimal> fromPole = null
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "relatedGoldbergFace" },
                    poleOrShared,
                    fromPole
                }
            );
        }

        public void setGoldbergFaceColors(decimal colorRange)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setGoldbergFaceColors" }, colorRange }
            );
        }

        public void updateGoldbergFaceColors(decimal colorRange)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateGoldbergFaceColors" },
                    colorRange
                }
            );
        }

        public void setGoldbergFaceUVs(decimal uvRange)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setGoldbergFaceUVs" }, uvRange }
            );
        }

        public void updateGoldbergFaceUVs(decimal uvRange)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateGoldbergFaceUVs" }, uvRange }
            );
        }

        public void placeOnGoldbergFaceAt(Mesh mesh, decimal face, Vector3 position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "placeOnGoldbergFaceAt" },
                    mesh,
                    face,
                    position
                }
            );
        }

        public void serialize(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, serializationObject }
            );
        }
        #endregion
    }
}
