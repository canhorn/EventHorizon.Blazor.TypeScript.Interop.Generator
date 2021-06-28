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
        public Plane clipPlane
        {
            get
            {
            if(__clipPlane == null)
            {
                __clipPlane = EventHorizonBlazorInterop.GetClass<Plane>(
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
            set
            {
__clipPlane = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane",
                    value
                );
            }
        }

        private Plane __clipPlane2;
        public Plane clipPlane2
        {
            get
            {
            if(__clipPlane2 == null)
            {
                __clipPlane2 = EventHorizonBlazorInterop.GetClass<Plane>(
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
            set
            {
__clipPlane2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane2",
                    value
                );
            }
        }

        private Plane __clipPlane3;
        public Plane clipPlane3
        {
            get
            {
            if(__clipPlane3 == null)
            {
                __clipPlane3 = EventHorizonBlazorInterop.GetClass<Plane>(
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
            set
            {
__clipPlane3 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane3",
                    value
                );
            }
        }

        private Plane __clipPlane4;
        public Plane clipPlane4
        {
            get
            {
            if(__clipPlane4 == null)
            {
                __clipPlane4 = EventHorizonBlazorInterop.GetClass<Plane>(
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
            set
            {
__clipPlane4 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane4",
                    value
                );
            }
        }

        private Plane __clipPlane5;
        public Plane clipPlane5
        {
            get
            {
            if(__clipPlane5 == null)
            {
                __clipPlane5 = EventHorizonBlazorInterop.GetClass<Plane>(
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
            set
            {
__clipPlane5 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane5",
                    value
                );
            }
        }

        private Plane __clipPlane6;
        public Plane clipPlane6
        {
            get
            {
            if(__clipPlane6 == null)
            {
                __clipPlane6 = EventHorizonBlazorInterop.GetClass<Plane>(
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
            set
            {
__clipPlane6 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane6",
                    value
                );
            }
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