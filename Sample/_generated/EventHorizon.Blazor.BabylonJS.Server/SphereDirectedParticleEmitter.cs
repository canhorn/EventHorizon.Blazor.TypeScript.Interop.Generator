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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SphereDirectedParticleEmitter>))]
    public class SphereDirectedParticleEmitter : SphereParticleEmitter
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
        private Vector3 __direction1;
        public async ValueTask<Vector3> get_direction1()
        {
            if(__direction1 == null)
            {
                __direction1 = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction1",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction1;
        }
        public ValueTask set_direction1(Vector3 value)
        {
__direction1 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction1",
                    value
                );
        }

        private Vector3 __direction2;
        public async ValueTask<Vector3> get_direction2()
        {
            if(__direction2 == null)
            {
                __direction2 = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction2",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction2;
        }
        public ValueTask set_direction2(Vector3 value)
        {
__direction2 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction2",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public SphereDirectedParticleEmitter() : base() { }

        public SphereDirectedParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<SphereDirectedParticleEmitter> NewSphereDirectedParticleEmitter(
            System.Nullable<decimal> radius = null, Vector3 direction1 = null, Vector3 direction2 = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SphereDirectedParticleEmitter" },
                radius, direction1, direction2
            );

            return new SphereDirectedParticleEmitter(entity);
        }
        #endregion

        #region Methods
        public async ValueTask startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate, Particle particle)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "startDirectionFunction" }, worldMatrix, directionToUpdate, particle
                }
            );
        }

        public async ValueTask<SphereDirectedParticleEmitter> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
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