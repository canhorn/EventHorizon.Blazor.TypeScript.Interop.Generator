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
        public async ValueTask<ParticleSystem> get_particleSystem()
        {
            if(__particleSystem == null)
            {
                __particleSystem = await EventHorizonBlazorInterop.GetClass<ParticleSystem>(
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
        public ValueTask set_particleSystem(ParticleSystem value)
        {
__particleSystem = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleSystem",
                    value
                );
        }

        
        public async ValueTask<decimal> get_id()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }

        private Vector3 __position;
        public async ValueTask<Vector3> get_position()
        {
            if(__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_position(Vector3 value)
        {
__position = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
        }

        private Vector3 __direction;
        public async ValueTask<Vector3> get_direction()
        {
            if(__direction == null)
            {
                __direction = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_direction(Vector3 value)
        {
__direction = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
        }

        private Color4 __color;
        public async ValueTask<Color4> get_color()
        {
            if(__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_color(Color4 value)
        {
__color = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
        }

        private Color4 __colorStep;
        public async ValueTask<Color4> get_colorStep()
        {
            if(__colorStep == null)
            {
                __colorStep = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_colorStep(Color4 value)
        {
__colorStep = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorStep",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lifeTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lifeTime"
                );
        }
        public ValueTask set_lifeTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lifeTime",
                    value
                );
        }

        
        public async ValueTask<decimal> get_age()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "age"
                );
        }
        public ValueTask set_age(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "age",
                    value
                );
        }

        
        public async ValueTask<decimal> get_size()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
        }
        public ValueTask set_size(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
        }

        private Vector2 __scale;
        public async ValueTask<Vector2> get_scale()
        {
            if(__scale == null)
            {
                __scale = await EventHorizonBlazorInterop.GetClass<Vector2>(
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
        public ValueTask set_scale(Vector2 value)
        {
__scale = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_angle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
        }
        public ValueTask set_angle(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
        }

        
        public async ValueTask<decimal> get_angularSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angularSpeed"
                );
        }
        public ValueTask set_angularSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angularSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellIndex"
                );
        }
        public ValueTask set_cellIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellIndex",
                    value
                );
        }

        private Vector4 __remapData;
        public async ValueTask<Vector4> get_remapData()
        {
            if(__remapData == null)
            {
                __remapData = await EventHorizonBlazorInterop.GetClass<Vector4>(
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
        public ValueTask set_remapData(Vector4 value)
        {
__remapData = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "remapData",
                    value
                );
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

        public static async ValueTask<Particle> NewParticle(
            ParticleSystem particleSystem
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Particle" },
                particleSystem
            );

            return new Particle(entity);
        }
        #endregion

        #region Methods
        public async ValueTask updateCellIndex()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateCellIndex" }
                }
            );
        }

        public async ValueTask copyTo(Particle other)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "copyTo" }, other
                }
            );
        }
        #endregion
    }
}