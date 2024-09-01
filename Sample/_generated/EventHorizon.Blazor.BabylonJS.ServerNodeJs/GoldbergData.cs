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

    [JsonConverter(typeof(CachedEntityConverter<GoldbergData>))]
    public class GoldbergData : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<Color4[]> get_faceColors()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Color4>(
                "BABYLON",
                "GoldbergData.faceColors",
                (entity) =>
                {
                    return new Color4() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_faceColors(Color4[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceColors", value);
        }

        public static async ValueTask<Vector3[]> get_faceCenters()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                "BABYLON",
                "GoldbergData.faceCenters",
                (entity) =>
                {
                    return new Vector3() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_faceCenters(Vector3[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceCenters", value);
        }

        public static async ValueTask<Vector3[]> get_faceZaxis()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                "BABYLON",
                "GoldbergData.faceZaxis",
                (entity) =>
                {
                    return new Vector3() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_faceZaxis(Vector3[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceZaxis", value);
        }

        public static async ValueTask<Vector3[]> get_faceXaxis()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                "BABYLON",
                "GoldbergData.faceXaxis",
                (entity) =>
                {
                    return new Vector3() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_faceXaxis(Vector3[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceXaxis", value);
        }

        public static async ValueTask<Vector3[]> get_faceYaxis()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                "BABYLON",
                "GoldbergData.faceYaxis",
                (entity) =>
                {
                    return new Vector3() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_faceYaxis(Vector3[] value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceYaxis", value);
        }

        // adjacentFaces is not supported by the platform yet


        public static async ValueTask<decimal> get_nbSharedFaces()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergData.nbSharedFaces"
            );
        }

        public static ValueTask set_nbSharedFaces(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbSharedFaces", value);
        }

        public static async ValueTask<decimal> get_nbUnsharedFaces()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergData.nbUnsharedFaces"
            );
        }

        public static ValueTask set_nbUnsharedFaces(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbUnsharedFaces", value);
        }

        public static async ValueTask<decimal> get_nbFaces()
        {
            return await EventHorizonBlazorInterop.Get<decimal>("BABYLON", "GoldbergData.nbFaces");
        }

        public static ValueTask set_nbFaces(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbFaces", value);
        }

        public static async ValueTask<decimal> get_nbFacesAtPole()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GoldbergData.nbFacesAtPole"
            );
        }

        public static ValueTask set_nbFacesAtPole(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbFacesAtPole", value);
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public GoldbergData()
            : base() { }

        public GoldbergData(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
