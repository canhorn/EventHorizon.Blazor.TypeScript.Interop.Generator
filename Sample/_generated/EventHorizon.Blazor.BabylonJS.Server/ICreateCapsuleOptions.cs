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

    public interface ICreateCapsuleOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICreateCapsuleOptionsCachedEntity>))]
    public class ICreateCapsuleOptionsCachedEntity : CachedEntityObject, ICreateCapsuleOptions
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
        private Vector3 __orientation;
        public async ValueTask<Vector3> get_orientation()
        {
            if(__orientation == null)
            {
                __orientation = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "orientation",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __orientation;
        }
        public ValueTask set_orientation(Vector3 value)
        {
__orientation = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orientation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_subdivisions()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "subdivisions"
                );
        }
        public ValueTask set_subdivisions(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subdivisions",
                    value
                );
        }

        
        public async ValueTask<decimal> get_tessellation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "tessellation"
                );
        }
        public ValueTask set_tessellation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tessellation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }

        
        public async ValueTask<decimal> get_radius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
        }
        public ValueTask set_radius(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
        }

        
        public async ValueTask<decimal> get_capSubdivisions()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "capSubdivisions"
                );
        }
        public ValueTask set_capSubdivisions(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "capSubdivisions",
                    value
                );
        }

        
        public async ValueTask<decimal> get_radiusTop()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radiusTop"
                );
        }
        public ValueTask set_radiusTop(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radiusTop",
                    value
                );
        }

        
        public async ValueTask<decimal> get_radiusBottom()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radiusBottom"
                );
        }
        public ValueTask set_radiusBottom(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radiusBottom",
                    value
                );
        }

        
        public async ValueTask<decimal> get_topCapSubdivisions()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "topCapSubdivisions"
                );
        }
        public ValueTask set_topCapSubdivisions(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "topCapSubdivisions",
                    value
                );
        }

        
        public async ValueTask<decimal> get_bottomCapSubdivisions()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottomCapSubdivisions"
                );
        }
        public ValueTask set_bottomCapSubdivisions(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bottomCapSubdivisions",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ICreateCapsuleOptionsCachedEntity() : base() { }

        public ICreateCapsuleOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}