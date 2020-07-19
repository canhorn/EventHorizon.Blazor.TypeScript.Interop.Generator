/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
                __particleSystem = EventHorizonBlazorInteropt.GetClass<ParticleSystem>(
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
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __position = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __direction = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __color = EventHorizonBlazorInteropt.GetClass<Color4>(
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
                EventHorizonBlazorInteropt.Set(
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
                __colorStep = EventHorizonBlazorInteropt.GetClass<Color4>(
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
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "lifeTime"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "age"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __scale = EventHorizonBlazorInteropt.GetClass<Vector2>(
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
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "angularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cellIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __remapData = EventHorizonBlazorInteropt.GetClass<Vector4>(
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
                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Particle" },
                particleSystem
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateCellIndex()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateCellIndex" }
                }
            );
        }

        public void copyTo(Particle other)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "copyTo" }, other
                }
            );
        }
        #endregion
    }
}