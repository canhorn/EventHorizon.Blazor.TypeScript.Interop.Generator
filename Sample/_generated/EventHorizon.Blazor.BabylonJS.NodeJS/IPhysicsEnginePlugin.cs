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

        public CachedEntity world
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "world",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "world", value);
            }
        }

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }
        #endregion

        #region Constructor
        public IPhysicsEnginePluginCachedEntity()
            : base() { }

        public IPhysicsEnginePluginCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void setGravity(Vector3 gravity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setGravity" }, gravity }
            );
        }

        public void setTimeStep(decimal timeStep)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTimeStep" }, timeStep }
            );
        }

        public decimal getTimeStep()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getTimeStep" } }
            );
        }

        public void executeStep(decimal delta, PhysicsImpostor[] impostors)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeStep" }, delta, impostors }
            );
        }

        public decimal getPluginVersion()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getPluginVersion" } }
            );
        }

        public void applyImpulse(PhysicsImpostor impostor, Vector3 force, Vector3 contactPoint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyImpulse" },
                    impostor,
                    force,
                    contactPoint
                }
            );
        }

        public void applyForce(PhysicsImpostor impostor, Vector3 force, Vector3 contactPoint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyForce" },
                    impostor,
                    force,
                    contactPoint
                }
            );
        }

        public void generatePhysicsBody(PhysicsImpostor impostor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "generatePhysicsBody" }, impostor }
            );
        }

        public void removePhysicsBody(PhysicsImpostor impostor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removePhysicsBody" }, impostor }
            );
        }

        public void generateJoint(PhysicsImpostorJoint joint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "generateJoint" }, joint }
            );
        }

        public void removeJoint(PhysicsImpostorJoint joint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeJoint" }, joint }
            );
        }

        public bool isSupported()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSupported" } }
            );
        }

        public void setTransformationFromPhysicsBody(PhysicsImpostor impostor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransformationFromPhysicsBody" },
                    impostor
                }
            );
        }

        public void setPhysicsBodyTransformation(
            PhysicsImpostor impostor,
            Vector3 newPosition,
            Quaternion newRotation
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPhysicsBodyTransformation" },
                    impostor,
                    newPosition,
                    newRotation
                }
            );
        }

        public void setLinearVelocity(PhysicsImpostor impostor, Vector3 velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearVelocity" },
                    impostor,
                    velocity
                }
            );
        }

        public void setAngularVelocity(PhysicsImpostor impostor, Vector3 velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" },
                    impostor,
                    velocity
                }
            );
        }

        public Vector3 getLinearVelocity(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLinearVelocity" }, impostor }
            );
        }

        public Vector3 getAngularVelocity(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAngularVelocity" }, impostor }
            );
        }

        public void setBodyMass(PhysicsImpostor impostor, decimal mass)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setBodyMass" }, impostor, mass }
            );
        }

        public decimal getBodyMass(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyMass" }, impostor }
            );
        }

        public decimal getBodyFriction(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyFriction" }, impostor }
            );
        }

        public void setBodyFriction(PhysicsImpostor impostor, decimal friction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyFriction" },
                    impostor,
                    friction
                }
            );
        }

        public decimal getBodyRestitution(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyRestitution" }, impostor }
            );
        }

        public void setBodyRestitution(PhysicsImpostor impostor, decimal restitution)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyRestitution" },
                    impostor,
                    restitution
                }
            );
        }

        public decimal getBodyPressure(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyPressure" }, impostor }
            );
        }

        public void setBodyPressure(PhysicsImpostor impostor, decimal pressure)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyPressure" },
                    impostor,
                    pressure
                }
            );
        }

        public decimal getBodyStiffness(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getBodyStiffness" }, impostor }
            );
        }

        public void setBodyStiffness(PhysicsImpostor impostor, decimal stiffness)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyStiffness" },
                    impostor,
                    stiffness
                }
            );
        }

        public decimal getBodyVelocityIterations(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getBodyVelocityIterations" },
                    impostor
                }
            );
        }

        public void setBodyVelocityIterations(PhysicsImpostor impostor, decimal velocityIterations)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyVelocityIterations" },
                    impostor,
                    velocityIterations
                }
            );
        }

        public decimal getBodyPositionIterations(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getBodyPositionIterations" },
                    impostor
                }
            );
        }

        public void setBodyPositionIterations(PhysicsImpostor impostor, decimal positionIterations)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBodyPositionIterations" },
                    impostor,
                    positionIterations
                }
            );
        }

        public void appendAnchor(
            PhysicsImpostor impostor,
            PhysicsImpostor otherImpostor,
            decimal width,
            decimal height,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void appendHook(
            PhysicsImpostor impostor,
            PhysicsImpostor otherImpostor,
            decimal length,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void sleepBody(PhysicsImpostor impostor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "sleepBody" }, impostor }
            );
        }

        public void wakeUpBody(PhysicsImpostor impostor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "wakeUpBody" }, impostor }
            );
        }

        public PhysicsRaycastResult raycast(Vector3 from, Vector3 to)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsRaycastResult>(
                entity => new PhysicsRaycastResult() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "raycast" }, from, to }
            );
        }

        public void raycastToRef(Vector3 from, Vector3 to, PhysicsRaycastResult result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "raycastToRef" }, from, to, result }
            );
        }

        public void updateDistanceJoint(
            PhysicsJoint joint,
            decimal maxDistance,
            System.Nullable<decimal> minDistance = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateDistanceJoint" },
                    joint,
                    maxDistance,
                    minDistance
                }
            );
        }

        public void setMotor(
            IMotorEnabledJoint joint,
            decimal speed,
            System.Nullable<decimal> maxForce = null,
            System.Nullable<decimal> motorIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setLimit(
            IMotorEnabledJoint joint,
            decimal upperLimit,
            System.Nullable<decimal> lowerLimit = null,
            System.Nullable<decimal> motorIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public decimal getRadius(PhysicsImpostor impostor)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRadius" }, impostor }
            );
        }

        public void getBoxSizeToRef(PhysicsImpostor impostor, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getBoxSizeToRef" }, impostor, result }
            );
        }

        public void syncMeshWithImpostor(AbstractMesh mesh, PhysicsImpostor impostor)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncMeshWithImpostor" },
                    mesh,
                    impostor
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
