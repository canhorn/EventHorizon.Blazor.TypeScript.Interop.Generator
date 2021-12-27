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

    
    
    [JsonConverter(typeof(CachedEntityConverter<CylinderParticleEmitter>))]
    public class CylinderParticleEmitter : CachedEntityObject, IParticleEmitterType
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

        
        public async ValueTask<decimal> get_radiusRange()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radiusRange"
                );
        }
        public ValueTask set_radiusRange(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radiusRange",
                    value
                );
        }

        
        public async ValueTask<decimal> get_directionRandomizer()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "directionRandomizer"
                );
        }
        public ValueTask set_directionRandomizer(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "directionRandomizer",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public CylinderParticleEmitter() : base() { }

        public CylinderParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<CylinderParticleEmitter> NewCylinderParticleEmitter(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, System.Nullable<decimal> directionRandomizer = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "CylinderParticleEmitter" },
                radius, height, radiusRange, directionRandomizer
            );

            return new CylinderParticleEmitter(entity);
        }
        #endregion

        #region Methods
        public async ValueTask startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate, Particle particle, bool isLocal)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "startDirectionFunction" }, worldMatrix, directionToUpdate, particle, isLocal
                }
            );
        }

        public async ValueTask startPositionFunction(Matrix worldMatrix, Vector3 positionToUpdate, Particle particle, bool isLocal)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "startPositionFunction" }, worldMatrix, positionToUpdate, particle, isLocal
                }
            );
        }

        public async ValueTask<CylinderParticleEmitter> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask applyToShader(Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "applyToShader" }, effect
                }
            );
        }

        public async ValueTask<string> getEffectDefines()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getEffectDefines" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public async ValueTask parse(object serializationObject)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "parse" }, serializationObject
                }
            );
        }
        #endregion
    }
}