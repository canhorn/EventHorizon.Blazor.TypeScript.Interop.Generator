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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Particle>))]
    public class Particle : CachedEntityObject
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
        private ParticleSystem __particleSystem;
        public ParticleSystem particleSystem
        {
            get
            {
            if(__particleSystem == null)
            {
                __particleSystem = EventHorizonBlazorInterop.GetClass<ParticleSystem>(
                    this.___guid,
                    "particleSystem",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
            }
            return __particleSystem;
            }
            set
            {
__particleSystem = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleSystem",
                    value
                );
            }
        }

        
        public decimal id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
            }
            set
            {
__direction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
        }

        private Color4 __color;
        public Color4 color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        private Color4 __colorStep;
        public Color4 colorStep
        {
            get
            {
            if(__colorStep == null)
            {
                __colorStep = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "colorStep",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorStep;
            }
            set
            {
__colorStep = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorStep",
                    value
                );
            }
        }

        
        public decimal lifeTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lifeTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lifeTime",
                    value
                );
            }
        }

        
        public decimal age
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "age"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "age",
                    value
                );
            }
        }

        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }

        private Vector2 __scale;
        public Vector2 scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal angularSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSpeed",
                    value
                );
            }
        }

        
        public decimal cellIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellIndex",
                    value
                );
            }
        }

        private Vector4 __remapData;
        public Vector4 remapData
        {
            get
            {
            if(__remapData == null)
            {
                __remapData = EventHorizonBlazorInterop.GetClass<Vector4>(
                    this.___guid,
                    "remapData",
                    (entity) =>
                    {
                        return new Vector4() { ___guid = entity.___guid };
                    }
                );
            }
            return __remapData;
            }
            set
            {
__remapData = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "remapData",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Particle() : base() { }

        public Particle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Particle(
            ParticleSystem particleSystem
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Particle" },
                particleSystem
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateCellIndex()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateCellIndex" }
                }
            );
        }

        public void copyTo(Particle other)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, other
                }
            );
        }
        #endregion
    }
}