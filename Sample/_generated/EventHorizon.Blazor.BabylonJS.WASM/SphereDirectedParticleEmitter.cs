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
        public Vector3 direction1
        {
            get
            {
            if(__direction1 == null)
            {
                __direction1 = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__direction1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction1",
                    value
                );
            }
        }

        private Vector3 __direction2;
        public Vector3 direction2
        {
            get
            {
            if(__direction2 == null)
            {
                __direction2 = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__direction2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SphereDirectedParticleEmitter() : base() { }

        public SphereDirectedParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SphereDirectedParticleEmitter(
            System.Nullable<decimal> radius = null, Vector3 direction1 = null, Vector3 direction2 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SphereDirectedParticleEmitter" },
                radius, direction1, direction2
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate, Particle particle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startDirectionFunction" }, worldMatrix, directionToUpdate, particle
                }
            );
        }

        public SphereDirectedParticleEmitter clone()
        {
            return EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void applyToShader(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyToShader" }, effect
                }
            );
        }

        public string getEffectDefines()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getEffectDefines" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void parse(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parse" }, serializationObject
                }
            );
        }
        #endregion
    }
}