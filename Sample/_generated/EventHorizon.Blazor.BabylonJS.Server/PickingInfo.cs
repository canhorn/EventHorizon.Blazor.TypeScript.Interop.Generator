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
        
        public async ValueTask<bool> get_hit()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hit"
                );
        }
        public ValueTask set_hit(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hit",
                    value
                );
        }

        
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

        private Vector3 __pickedPoint;
        public async ValueTask<Vector3> get_pickedPoint()
        {
            if(__pickedPoint == null)
            {
                __pickedPoint = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_pickedPoint(Vector3 value)
        {
__pickedPoint = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickedPoint",
                    value
                );
        }

        private AbstractMesh __pickedMesh;
        public async ValueTask<AbstractMesh> get_pickedMesh()
        {
            if(__pickedMesh == null)
            {
                __pickedMesh = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
        public ValueTask set_pickedMesh(AbstractMesh value)
        {
__pickedMesh = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickedMesh",
                    value
                );
        }

        
        public async ValueTask<decimal> get_bu()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bu"
                );
        }
        public ValueTask set_bu(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bu",
                    value
                );
        }

        
        public async ValueTask<decimal> get_bv()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bv"
                );
        }
        public ValueTask set_bv(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bv",
                    value
                );
        }

        
        public async ValueTask<decimal> get_faceId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "faceId"
                );
        }
        public ValueTask set_faceId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "faceId",
                    value
                );
        }

        
        public async ValueTask<decimal> get_subMeshFaceId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subMeshFaceId"
                );
        }
        public ValueTask set_subMeshFaceId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshFaceId",
                    value
                );
        }

        
        public async ValueTask<decimal> get_subMeshId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subMeshId"
                );
        }
        public ValueTask set_subMeshId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshId",
                    value
                );
        }

        private Sprite __pickedSprite;
        public async ValueTask<Sprite> get_pickedSprite()
        {
            if(__pickedSprite == null)
            {
                __pickedSprite = await EventHorizonBlazorInterop.GetClass<Sprite>(
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
        public ValueTask set_pickedSprite(Sprite value)
        {
__pickedSprite = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pickedSprite",
                    value
                );
        }

        
        public async ValueTask<decimal> get_thinInstanceIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "thinInstanceIndex"
                );
        }
        public ValueTask set_thinInstanceIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "thinInstanceIndex",
                    value
                );
        }

        private AbstractMesh __originMesh;
        public async ValueTask<AbstractMesh> get_originMesh()
        {
            if(__originMesh == null)
            {
                __originMesh = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
        public ValueTask set_originMesh(AbstractMesh value)
        {
__originMesh = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "originMesh",
                    value
                );
        }

        private Ray __ray;
        public async ValueTask<Ray> get_ray()
        {
            if(__ray == null)
            {
                __ray = await EventHorizonBlazorInterop.GetClass<Ray>(
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
        public ValueTask set_ray(Ray value)
        {
__ray = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ray",
                    value
                );
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
        public async ValueTask<Vector3> getNormal(System.Nullable<bool> useWorldCoordinates = null, System.Nullable<bool> useVerticesNormals = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getNormal" }, useWorldCoordinates, useVerticesNormals
                }
            );
        }

        public async ValueTask<Vector2> getTextureCoordinates()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
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