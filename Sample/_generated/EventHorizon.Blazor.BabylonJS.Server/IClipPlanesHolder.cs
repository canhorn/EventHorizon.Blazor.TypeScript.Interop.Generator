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

    public interface IClipPlanesHolder : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IClipPlanesHolderCachedEntity>))]
    public class IClipPlanesHolderCachedEntity : CachedEntityObject, IClipPlanesHolder
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
        private Plane __clipPlane;
        public async ValueTask<Plane> get_clipPlane()
        {
            if(__clipPlane == null)
            {
                __clipPlane = await EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane;
        }
        public ValueTask set_clipPlane(Plane value)
        {
__clipPlane = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane",
                    value
                );
        }

        private Plane __clipPlane2;
        public async ValueTask<Plane> get_clipPlane2()
        {
            if(__clipPlane2 == null)
            {
                __clipPlane2 = await EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane2",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane2;
        }
        public ValueTask set_clipPlane2(Plane value)
        {
__clipPlane2 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane2",
                    value
                );
        }

        private Plane __clipPlane3;
        public async ValueTask<Plane> get_clipPlane3()
        {
            if(__clipPlane3 == null)
            {
                __clipPlane3 = await EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane3",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane3;
        }
        public ValueTask set_clipPlane3(Plane value)
        {
__clipPlane3 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane3",
                    value
                );
        }

        private Plane __clipPlane4;
        public async ValueTask<Plane> get_clipPlane4()
        {
            if(__clipPlane4 == null)
            {
                __clipPlane4 = await EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane4",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane4;
        }
        public ValueTask set_clipPlane4(Plane value)
        {
__clipPlane4 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane4",
                    value
                );
        }

        private Plane __clipPlane5;
        public async ValueTask<Plane> get_clipPlane5()
        {
            if(__clipPlane5 == null)
            {
                __clipPlane5 = await EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane5",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane5;
        }
        public ValueTask set_clipPlane5(Plane value)
        {
__clipPlane5 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane5",
                    value
                );
        }

        private Plane __clipPlane6;
        public async ValueTask<Plane> get_clipPlane6()
        {
            if(__clipPlane6 == null)
            {
                __clipPlane6 = await EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane6",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane6;
        }
        public ValueTask set_clipPlane6(Plane value)
        {
__clipPlane6 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane6",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IClipPlanesHolderCachedEntity() : base() { }

        public IClipPlanesHolderCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}