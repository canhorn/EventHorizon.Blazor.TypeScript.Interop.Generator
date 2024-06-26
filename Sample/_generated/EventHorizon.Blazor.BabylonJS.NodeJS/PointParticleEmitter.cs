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

    [JsonConverter(typeof(CachedEntityConverter<PointParticleEmitter>))]
    public class PointParticleEmitter : CachedEntityObject, IParticleEmitterType
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
                if (__direction1 == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "direction1", value);
            }
        }

        private Vector3 __direction2;
        public Vector3 direction2
        {
            get
            {
                if (__direction2 == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "direction2", value);
            }
        }
        #endregion

        #region Constructor
        public PointParticleEmitter()
            : base() { }

        public PointParticleEmitter(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void startDirectionFunction(
            Matrix worldMatrix,
            Vector3 directionToUpdate,
            Particle particle,
            bool isLocal
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startDirectionFunction" },
                    worldMatrix,
                    directionToUpdate,
                    particle,
                    isLocal
                }
            );
        }

        public void startPositionFunction(
            Matrix worldMatrix,
            Vector3 positionToUpdate,
            Particle particle,
            bool isLocal
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startPositionFunction" },
                    worldMatrix,
                    positionToUpdate,
                    particle,
                    isLocal
                }
            );
        }

        public PointParticleEmitter clone()
        {
            return EventHorizonBlazorInterop.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public void applyToShader(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "applyToShader" }, effect }
            );
        }

        public string getEffectDefines()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getEffectDefines" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public void parse(object serializationObject)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, serializationObject }
            );
        }
        #endregion
    }
}
