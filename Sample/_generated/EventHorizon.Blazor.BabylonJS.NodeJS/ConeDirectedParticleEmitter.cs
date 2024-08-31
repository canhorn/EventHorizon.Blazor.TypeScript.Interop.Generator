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

    [JsonConverter(typeof(CachedEntityConverter<ConeDirectedParticleEmitter>))]
    public class ConeDirectedParticleEmitter : ConeParticleEmitter
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
        public ConeDirectedParticleEmitter()
            : base() { }

        public ConeDirectedParticleEmitter(ICachedEntity entity)
            : base(entity) { }

        public ConeDirectedParticleEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> angle = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ConeDirectedParticleEmitter" },
                radius,
                angle,
                direction1,
                direction2
            );
            ___guid = entity.___guid;
        }

        public ConeDirectedParticleEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> angle = null,
            System.Nullable<decimal> directionRandomizer = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ConeDirectedParticleEmitter" },
                radius,
                angle,
                directionRandomizer
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startDirectionFunction" },
                    worldMatrix,
                    directionToUpdate
                }
            );
        }

        public ConeDirectedParticleEmitter clone()
        {
            return EventHorizonBlazorInterop.FuncClass<ConeDirectedParticleEmitter>(
                entity => new ConeDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public void applyToShader(UniformBufferEffectCommonAccessor uboOrEffect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "applyToShader" }, uboOrEffect }
            );
        }

        public void buildUniformLayout(UniformBuffer ubo)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "buildUniformLayout" }, ubo }
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
