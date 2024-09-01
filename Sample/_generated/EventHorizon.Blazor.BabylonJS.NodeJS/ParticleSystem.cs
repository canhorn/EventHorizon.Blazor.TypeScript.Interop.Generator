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

    [JsonConverter(typeof(CachedEntityConverter<ParticleSystem>))]
    public class ParticleSystem : ThinParticleSystem
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal BILLBOARDMODE_Y
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_Y"
                );
            }
        }

        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_ALL"
                );
            }
        }

        public static decimal BILLBOARDMODE_STRETCHED
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_STRETCHED"
                );
            }
        }

        public static decimal BILLBOARDMODE_STRETCHED_LOCAL
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_STRETCHED_LOCAL"
                );
            }
        }
        #endregion

        #region Static Methods
        public static ParticleSystem Parse(
            object parsedParticleSystem,
            Scene sceneOrEngine,
            string rootUrl,
            System.Nullable<bool> doNotStart = null,
            System.Nullable<decimal> capacity = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleSystem", "Parse" },
                    parsedParticleSystem,
                    sceneOrEngine,
                    rootUrl,
                    doNotStart,
                    capacity
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public ParticleSystem[] subEmitters
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "subEmitters",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "subEmitters", value);
            }
        }

        public ParticleSystem[] activeSubSystems
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "activeSubSystems",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "activeSubSystems", value);
            }
        }
        #endregion

        #region Constructor
        public ParticleSystem()
            : base() { }

        public ParticleSystem(ICachedEntity entity)
            : base(entity) { }

        public ParticleSystem(
            string name,
            decimal capacity,
            Scene sceneOrEngine,
            Effect customEffect = null,
            System.Nullable<bool> isAnimationSheetEnabled = null,
            System.Nullable<decimal> epsilon = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name,
                capacity,
                sceneOrEngine,
                customEffect,
                isAnimationSheetEnabled,
                epsilon
            );
            ___guid = entity.___guid;
        }

        public ParticleSystem(string name)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public PointParticleEmitter createPointEmitter(Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInterop.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPointEmitter" },
                    direction1,
                    direction2
                }
            );
        }

        public HemisphericParticleEmitter createHemisphericEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> radiusRange = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createHemisphericEmitter" },
                    radius,
                    radiusRange
                }
            );
        }

        public SphereParticleEmitter createSphereEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> radiusRange = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createSphereEmitter" },
                    radius,
                    radiusRange
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedSphereEmitter(
            System.Nullable<decimal> radius = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" },
                    radius,
                    direction1,
                    direction2
                }
            );
        }

        public CylinderParticleEmitter createCylinderEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> height = null,
            System.Nullable<decimal> radiusRange = null,
            System.Nullable<decimal> directionRandomizer = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCylinderEmitter" },
                    radius,
                    height,
                    radiusRange,
                    directionRandomizer
                }
            );
        }

        public CylinderDirectedParticleEmitter createDirectedCylinderEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> height = null,
            System.Nullable<decimal> radiusRange = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<CylinderDirectedParticleEmitter>(
                entity => new CylinderDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" },
                    radius,
                    height,
                    radiusRange,
                    direction1,
                    direction2
                }
            );
        }

        public ConeParticleEmitter createConeEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> angle = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createConeEmitter" }, radius, angle }
            );
        }

        public ConeDirectedParticleEmitter createDirectedConeEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> angle = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ConeDirectedParticleEmitter>(
                entity => new ConeDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedConeEmitter" },
                    radius,
                    angle,
                    direction1,
                    direction2
                }
            );
        }

        public BoxParticleEmitter createBoxEmitter(
            Vector3 direction1,
            Vector3 direction2,
            Vector3 minEmitBox,
            Vector3 maxEmitBox
        )
        {
            return EventHorizonBlazorInterop.FuncClass<BoxParticleEmitter>(
                entity => new BoxParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBoxEmitter" },
                    direction1,
                    direction2,
                    minEmitBox,
                    maxEmitBox
                }
            );
        }

        public CachedEntity serialize(System.Nullable<bool> serializeTexture = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, serializeTexture }
            );
        }

        public ParticleSystem clone(
            string name,
            object newEmitter,
            System.Nullable<bool> cloneTexture = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" },
                    name,
                    newEmitter,
                    cloneTexture
                }
            );
        }
        #endregion
    }
}
