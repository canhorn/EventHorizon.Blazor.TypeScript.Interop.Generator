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

    public interface IPhysicsEnginePlugin : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsEnginePluginCachedEntity>))]
    public class IPhysicsEnginePluginCachedEntity : CachedEntityObject, IPhysicsEnginePlugin
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

        public async ValueTask<CachedEntity> get_world()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "world",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_world(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "world", value);
        }

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }
        #endregion

        #region Constructor
        public IPhysicsEnginePluginCachedEntity()
            : base() { }

        public IPhysicsEnginePluginCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask setGravity(Vector3 gravity)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setGravity" }, gravity }
            );
        }

        public async ValueTask setTimeStep(decimal timeStep)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTimeStep" }, timeStep }
            );
        }

        public async ValueTask<decimal> getTimeStep()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getTimeStep" } }
            );
        }

        public async ValueTask executeStep(decimal delta, PhysicsImpostor[] impostors)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeStep" }, delta, impostors }
            );
        }

        public async ValueTask<decimal> getPluginVersion()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getPluginVersion" } }
            );
        }

        public async ValueTask applyImpulse(
            PhysicsImpostor impostor,
            Vector3 force,
            Vector3 contactPoint
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyImpulse" },
                    impostor,
                    force,
                    contactPoint
                }
            );
        }

        public async ValueTask applyForce(
            PhysicsImpostor impostor,
            Vector3 force,
            Vector3 contactPoint
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyForce" },
                    impostor,
                    force,
                    contactPoint
                }
            );
        }

        public async ValueTask generatePhysicsBody(PhysicsImpostor impostor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "generatePhysicsBody" }, impostor }
            );
        }

        public async ValueTask removePhysicsBody(PhysicsImpostor impostor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removePhysicsBody" }, impostor }
            );
        }

        public async ValueTask generateJoint(PhysicsImpostorJoint joint)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "generateJoint" }, joint }
            );
        }

        public async ValueTask removeJoint(PhysicsImpostorJoint joint)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeJoint" }, joint }
            );
        }

        public async ValueTask<bool> isSupported()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSupported" } }
            );
        }

        public async ValueTask setTransformationFromPhysicsBody(PhysicsImpostor impostor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransformationFromPhysicsBody" },
                    impostor
                }
            );
        }

        public async ValueTask setPhysicsBodyTransformation(
            PhysicsImpostor impostor,
            Vector3 newPosition,
            Quaternion newRotation
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPhysicsBodyTransformation" },
                    impostor,
                    newPosition,
                    newRotation
                }
            );
        }

        public async ValueTask setLinearVelocity(PhysicsImpostor impostor, Vector3 velocity)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearVelocity" },
                    impostor,
                    velocity
                }
            );
        }

        public async ValueTask setAngularVelocity(PhysicsImpostor impostor, Vector3 velocity)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" },
                    impostor,
                    velocity
                }
            );
        }

        public async ValueTask<Vector3> getLinearVelocity(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLinearVelocity" }, impostor }
            );
        }

        public async ValueTask<Vector3> getAngularVelocity(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAngularVelocity" }, impostor }
            );
        }

        public async ValueTask setBodyMass(PhysicsImpostor impostor, decimal mass)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setBodyMass" }, impostor, mass }
            );
        }

        public async ValueTask<decimal> getBodyMass(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyMass" }, impostor }
            );
        }

        public async ValueTask<decimal> getBodyFriction(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyFriction" }, impostor }
            );
        }

        public async ValueTask setBodyFriction(PhysicsImpostor impostor, decimal friction)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyFriction" },
                    impostor,
                    friction
                }
            );
        }

        public async ValueTask<decimal> getBodyRestitution(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyRestitution" }, impostor }
            );
        }

        public async ValueTask setBodyRestitution(PhysicsImpostor impostor, decimal restitution)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyRestitution" },
                    impostor,
                    restitution
                }
            );
        }

        public async ValueTask<decimal> getBodyPressure(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyPressure" }, impostor }
            );
        }

        public async ValueTask setBodyPressure(PhysicsImpostor impostor, decimal pressure)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyPressure" },
                    impostor,
                    pressure
                }
            );
        }

        public async ValueTask<decimal> getBodyStiffness(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyStiffness" }, impostor }
            );
        }

        public async ValueTask setBodyStiffness(PhysicsImpostor impostor, decimal stiffness)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyStiffness" },
                    impostor,
                    stiffness
                }
            );
        }

        public async ValueTask<decimal> getBodyVelocityIterations(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getBodyVelocityIterations" },
                    impostor
                }
            );
        }

        public async ValueTask setBodyVelocityIterations(
            PhysicsImpostor impostor,
            decimal velocityIterations
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyVelocityIterations" },
                    impostor,
                    velocityIterations
                }
            );
        }

        public async ValueTask<decimal> getBodyPositionIterations(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getBodyPositionIterations" },
                    impostor
                }
            );
        }

        public async ValueTask setBodyPositionIterations(
            PhysicsImpostor impostor,
            decimal positionIterations
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyPositionIterations" },
                    impostor,
                    positionIterations
                }
            );
        }

        public async ValueTask appendAnchor(
            PhysicsImpostor impostor,
            PhysicsImpostor otherImpostor,
            decimal width,
            decimal height,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "appendAnchor" },
                    impostor,
                    otherImpostor,
                    width,
                    height,
                    influence,
                    noCollisionBetweenLinkedBodies
                }
            );
        }

        public async ValueTask appendHook(
            PhysicsImpostor impostor,
            PhysicsImpostor otherImpostor,
            decimal length,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "appendHook" },
                    impostor,
                    otherImpostor,
                    length,
                    influence,
                    noCollisionBetweenLinkedBodies
                }
            );
        }

        public async ValueTask sleepBody(PhysicsImpostor impostor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "sleepBody" }, impostor }
            );
        }

        public async ValueTask wakeUpBody(PhysicsImpostor impostor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "wakeUpBody" }, impostor }
            );
        }

        public async ValueTask<PhysicsRaycastResult> raycast(Vector3 from, Vector3 to)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsRaycastResult>(
                entity => new PhysicsRaycastResult() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "raycast" }, from, to }
            );
        }

        public async ValueTask raycastToRef(Vector3 from, Vector3 to, PhysicsRaycastResult result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "raycastToRef" }, from, to, result }
            );
        }

        public async ValueTask updateDistanceJoint(
            PhysicsJoint joint,
            decimal maxDistance,
            System.Nullable<decimal> minDistance = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDistanceJoint" },
                    joint,
                    maxDistance,
                    minDistance
                }
            );
        }

        public async ValueTask setMotor(
            IMotorEnabledJoint joint,
            decimal speed,
            System.Nullable<decimal> maxForce = null,
            System.Nullable<decimal> motorIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMotor" },
                    joint,
                    speed,
                    maxForce,
                    motorIndex
                }
            );
        }

        public async ValueTask setLimit(
            IMotorEnabledJoint joint,
            decimal upperLimit,
            System.Nullable<decimal> lowerLimit = null,
            System.Nullable<decimal> motorIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLimit" },
                    joint,
                    upperLimit,
                    lowerLimit,
                    motorIndex
                }
            );
        }

        public async ValueTask<decimal> getRadius(PhysicsImpostor impostor)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRadius" }, impostor }
            );
        }

        public async ValueTask getBoxSizeToRef(PhysicsImpostor impostor, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getBoxSizeToRef" }, impostor, result }
            );
        }

        public async ValueTask syncMeshWithImpostor(AbstractMesh mesh, PhysicsImpostor impostor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncMeshWithImpostor" },
                    mesh,
                    impostor
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
