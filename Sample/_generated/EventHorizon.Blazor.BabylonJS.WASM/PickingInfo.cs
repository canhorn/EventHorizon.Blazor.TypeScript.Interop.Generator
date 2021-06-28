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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PickingInfo>))]
    public class PickingInfo : CachedEntityObject
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
        
        public bool hit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hit",
                    value
                );
            }
        }

        
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

        private Vector3 __pickedPoint;
        public Vector3 pickedPoint
        {
            get
            {
            if(__pickedPoint == null)
            {
                __pickedPoint = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "pickedPoint",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __pickedPoint;
            }
            set
            {
__pickedPoint = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickedPoint",
                    value
                );
            }
        }

        private AbstractMesh __pickedMesh;
        public AbstractMesh pickedMesh
        {
            get
            {
            if(__pickedMesh == null)
            {
                __pickedMesh = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "pickedMesh",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __pickedMesh;
            }
            set
            {
__pickedMesh = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickedMesh",
                    value
                );
            }
        }

        
        public decimal bu
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bu"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bu",
                    value
                );
            }
        }

        
        public decimal bv
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bv"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bv",
                    value
                );
            }
        }

        
        public decimal faceId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "faceId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceId",
                    value
                );
            }
        }

        
        public decimal subMeshFaceId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subMeshFaceId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshFaceId",
                    value
                );
            }
        }

        
        public decimal subMeshId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subMeshId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshId",
                    value
                );
            }
        }

        private Sprite __pickedSprite;
        public Sprite pickedSprite
        {
            get
            {
            if(__pickedSprite == null)
            {
                __pickedSprite = EventHorizonBlazorInterop.GetClass<Sprite>(
                    this.___guid,
                    "pickedSprite",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
                );
            }
            return __pickedSprite;
            }
            set
            {
__pickedSprite = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickedSprite",
                    value
                );
            }
        }

        
        public decimal thinInstanceIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "thinInstanceIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "thinInstanceIndex",
                    value
                );
            }
        }

        private AbstractMesh __originMesh;
        public AbstractMesh originMesh
        {
            get
            {
            if(__originMesh == null)
            {
                __originMesh = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "originMesh",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __originMesh;
            }
            set
            {
__originMesh = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originMesh",
                    value
                );
            }
        }

        private Ray __ray;
        public Ray ray
        {
            get
            {
            if(__ray == null)
            {
                __ray = EventHorizonBlazorInterop.GetClass<Ray>(
                    this.___guid,
                    "ray",
                    (entity) =>
                    {
                        return new Ray() { ___guid = entity.___guid };
                    }
                );
            }
            return __ray;
            }
            set
            {
__ray = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ray",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PickingInfo() : base() { }

        public PickingInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public Vector3 getNormal(System.Nullable<bool> useWorldCoordinates = null, System.Nullable<bool> useVerticesNormals = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNormal" }, useWorldCoordinates, useVerticesNormals
                }
            );
        }

        public Vector2 getTextureCoordinates()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTextureCoordinates" }
                }
            );
        }
        #endregion
    }
}