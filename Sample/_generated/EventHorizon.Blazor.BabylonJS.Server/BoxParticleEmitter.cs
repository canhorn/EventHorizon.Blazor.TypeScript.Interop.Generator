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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BoxParticleEmitter>))]
    public class BoxParticleEmitter : CachedEntityObject, IParticleEmitterType
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

        private Vector3 __minEmitBox;
        public async ValueTask<Vector3> get_minEmitBox()
        {
            if(__minEmitBox == null)
            {
                __minEmitBox = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "minEmitBox",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __minEmitBox;
        }
        public ValueTask set_minEmitBox(Vector3 value)
        {
__minEmitBox = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minEmitBox",
                    value
                );
        }

        private Vector3 __maxEmitBox;
        public async ValueTask<Vector3> get_maxEmitBox()
        {
            if(__maxEmitBox == null)
            {
                __maxEmitBox = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "maxEmitBox",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __maxEmitBox;
        }
        public ValueTask set_maxEmitBox(Vector3 value)
        {
__maxEmitBox = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxEmitBox",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public BoxParticleEmitter() : base() { }

        public BoxParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
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

        public async ValueTask<BoxParticleEmitter> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<BoxParticleEmitter>(
                entity => new BoxParticleEmitter() { ___guid = entity.___guid },
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