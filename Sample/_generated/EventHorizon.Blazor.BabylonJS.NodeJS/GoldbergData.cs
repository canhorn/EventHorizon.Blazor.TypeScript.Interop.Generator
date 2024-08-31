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

    [JsonConverter(typeof(CachedEntityConverter<GoldbergData>))]
    public class GoldbergData : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static Color4[] faceColors
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Color4>(
                    "BABYLON",
                    "GoldbergData.faceColors",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceColors", value);
            }
        }

        public static Vector3[] faceCenters
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    "BABYLON",
                    "GoldbergData.faceCenters",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceCenters", value);
            }
        }

        public static Vector3[] faceZaxis
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    "BABYLON",
                    "GoldbergData.faceZaxis",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceZaxis", value);
            }
        }

        public static Vector3[] faceXaxis
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    "BABYLON",
                    "GoldbergData.faceXaxis",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceXaxis", value);
            }
        }

        public static Vector3[] faceYaxis
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Vector3>(
                    "BABYLON",
                    "GoldbergData.faceYaxis",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.faceYaxis", value);
            }
        }

        // adjacentFaces is not supported by the platform yet


        public static decimal nbSharedFaces
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergData.nbSharedFaces"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbSharedFaces", value);
            }
        }

        public static decimal nbUnsharedFaces
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergData.nbUnsharedFaces"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbUnsharedFaces", value);
            }
        }

        public static decimal nbFaces
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "GoldbergData.nbFaces");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbFaces", value);
            }
        }

        public static decimal nbFacesAtPole
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GoldbergData.nbFacesAtPole"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GoldbergData.nbFacesAtPole", value);
            }
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
