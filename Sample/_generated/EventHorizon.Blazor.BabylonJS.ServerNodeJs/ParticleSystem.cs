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

    [JsonConverter(typeof(CachedEntityConverter<ParticleSystem>))]
    public class ParticleSystem : ThinParticleSystem
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_BILLBOARDMODE_Y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "ParticleSystem.BILLBOARDMODE_Y"
            );
        }

        public static async ValueTask<decimal> get_BILLBOARDMODE_ALL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "ParticleSystem.BILLBOARDMODE_ALL"
            );
        }

        public static async ValueTask<decimal> get_BILLBOARDMODE_STRETCHED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "ParticleSystem.BILLBOARDMODE_STRETCHED"
            );
        }

        public static async ValueTask<decimal> get_BILLBOARDMODE_STRETCHED_LOCAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "ParticleSystem.BILLBOARDMODE_STRETCHED_LOCAL"
            );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<ParticleSystem> Parse(
            object parsedParticleSystem,
            Scene sceneOrEngine,
            string rootUrl,
            System.Nullable<bool> doNotStart = null,
            System.Nullable<decimal> capacity = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
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

        public async ValueTask<ParticleSystem[]> get_subEmitters()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                this.___guid,
                "subEmitters",
                (entity) =>
                {
                    return new ParticleSystem() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_subEmitters(ParticleSystem[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "subEmitters", value);
        }

        public async ValueTask<ParticleSystem[]> get_activeSubSystems()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                this.___guid,
                "activeSubSystems",
                (entity) =>
                {
                    return new ParticleSystem() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_activeSubSystems(ParticleSystem[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "activeSubSystems", value);
        }
        #endregion

        #region Constructor
        public ParticleSystem()
            : base() { }

        public ParticleSystem(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<ParticleSystem> NewParticleSystem(
            string name,
            decimal capacity,
            Scene sceneOrEngine,
            Effect customEffect = null,
            System.Nullable<bool> isAnimationSheetEnabled = null,
            System.Nullable<decimal> epsilon = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name,
                capacity,
                sceneOrEngine,
                customEffect,
                isAnimationSheetEnabled,
                epsilon
            );

            return new ParticleSystem(entity);
        }

        public static async ValueTask<ParticleSystem> NewParticleSystem(string name)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name
            );

            return new ParticleSystem(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<PointParticleEmitter> createPointEmitter(
            Vector3 direction1,
            Vector3 direction2
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPointEmitter" },
                    direction1,
                    direction2
                }
            );
        }

        public async ValueTask<HemisphericParticleEmitter> createHemisphericEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> radiusRange = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createHemisphericEmitter" },
                    radius,
                    radiusRange
                }
            );
        }

        public async ValueTask<SphereParticleEmitter> createSphereEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> radiusRange = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createSphereEmitter" },
                    radius,
                    radiusRange
                }
            );
        }

        public async ValueTask<SphereDirectedParticleEmitter> createDirectedSphereEmitter(
            System.Nullable<decimal> radius = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
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

        public async ValueTask<CylinderParticleEmitter> createCylinderEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> height = null,
            System.Nullable<decimal> radiusRange = null,
            System.Nullable<decimal> directionRandomizer = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
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

        public async ValueTask<CylinderDirectedParticleEmitter> createDirectedCylinderEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> height = null,
            System.Nullable<decimal> radiusRange = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<CylinderDirectedParticleEmitter>(
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

        public async ValueTask<ConeParticleEmitter> createConeEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> angle = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createConeEmitter" }, radius, angle }
            );
        }

        public async ValueTask<ConeDirectedParticleEmitter> createDirectedConeEmitter(
            System.Nullable<decimal> radius = null,
            System.Nullable<decimal> angle = null,
            Vector3 direction1 = null,
            Vector3 direction2 = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ConeDirectedParticleEmitter>(
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

        public async ValueTask<BoxParticleEmitter> createBoxEmitter(
            Vector3 direction1,
            Vector3 direction2,
            Vector3 minEmitBox,
            Vector3 maxEmitBox
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<BoxParticleEmitter>(
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

        public async ValueTask<CachedEntity> serialize(
            System.Nullable<bool> serializeTexture = null
        )
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, serializeTexture }
            );
        }

        public async ValueTask<ParticleSystem> clone(
            string name,
            object newEmitter,
            System.Nullable<bool> cloneTexture = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
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
