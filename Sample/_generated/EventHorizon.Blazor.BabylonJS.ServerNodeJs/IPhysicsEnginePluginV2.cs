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

    public interface IPhysicsEnginePluginV2 : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsEnginePluginV2CachedEntity>))]
    public class IPhysicsEnginePluginV2CachedEntity : CachedEntityObject, IPhysicsEnginePluginV2
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

        private Observable<IPhysicsCollisionEventCachedEntity> __onCollisionObservable;

        public async ValueTask<
            Observable<IPhysicsCollisionEventCachedEntity>
        > get_onCollisionObservable()
        {
            if (__onCollisionObservable == null)
            {
                __onCollisionObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<IPhysicsCollisionEventCachedEntity>
                >(
                    this.___guid,
                    "onCollisionObservable",
                    (entity) =>
                    {
                        return new Observable<IPhysicsCollisionEventCachedEntity>()
                        {
                            ___guid = entity.___guid
                        };
                    }
                );
            }
            return __onCollisionObservable;
        }

        public ValueTask set_onCollisionObservable(
            Observable<IPhysicsCollisionEventCachedEntity> value
        )
        {
            __onCollisionObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onCollisionObservable", value);
        }

        private Observable<IBasePhysicsCollisionEventCachedEntity> __onCollisionEndedObservable;

        public async ValueTask<
            Observable<IBasePhysicsCollisionEventCachedEntity>
        > get_onCollisionEndedObservable()
        {
            if (__onCollisionEndedObservable == null)
            {
                __onCollisionEndedObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<IBasePhysicsCollisionEventCachedEntity>
                >(
                    this.___guid,
                    "onCollisionEndedObservable",
                    (entity) =>
                    {
                        return new Observable<IBasePhysicsCollisionEventCachedEntity>()
                        {
                            ___guid = entity.___guid
                        };
                    }
                );
            }
            return __onCollisionEndedObservable;
        }

        public ValueTask set_onCollisionEndedObservable(
            Observable<IBasePhysicsCollisionEventCachedEntity> value
        )
        {
            __onCollisionEndedObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onCollisionEndedObservable", value);
        }

        private Observable<IBasePhysicsCollisionEventCachedEntity> __onTriggerCollisionObservable;

        public async ValueTask<
            Observable<IBasePhysicsCollisionEventCachedEntity>
        > get_onTriggerCollisionObservable()
        {
            if (__onTriggerCollisionObservable == null)
            {
                __onTriggerCollisionObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<IBasePhysicsCollisionEventCachedEntity>
                >(
                    this.___guid,
                    "onTriggerCollisionObservable",
                    (entity) =>
                    {
                        return new Observable<IBasePhysicsCollisionEventCachedEntity>()
                        {
                            ___guid = entity.___guid
                        };
                    }
                );
            }
            return __onTriggerCollisionObservable;
        }

        public ValueTask set_onTriggerCollisionObservable(
            Observable<IBasePhysicsCollisionEventCachedEntity> value
        )
        {
            __onTriggerCollisionObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onTriggerCollisionObservable",
                value
            );
        }
        #endregion

        #region Constructor
        public IPhysicsEnginePluginV2CachedEntity()
            : base() { }

        public IPhysicsEnginePluginV2CachedEntity(ICachedEntity entity)
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

        public async ValueTask executeStep(decimal delta, PhysicsBody[] bodies)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeStep" }, delta, bodies }
            );
        }

        public async ValueTask<decimal> getPluginVersion()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getPluginVersion" } }
            );
        }

        public async ValueTask setVelocityLimits(
            decimal maxLinearVelocity,
            decimal maxAngularVelocity
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVelocityLimits" },
                    maxLinearVelocity,
                    maxAngularVelocity
                }
            );
        }

        public async ValueTask<decimal> getMaxLinearVelocity()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getMaxLinearVelocity" } }
            );
        }

        public async ValueTask<decimal> getMaxAngularVelocity()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getMaxAngularVelocity" } }
            );
        }

        public async ValueTask initBody(
            PhysicsBody body,
            int motionType,
            Vector3 position,
            Quaternion orientation
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initBody" },
                    body,
                    motionType,
                    position,
                    orientation
                }
            );
        }

        public async ValueTask initBodyInstances(PhysicsBody body, int motionType, Mesh mesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initBodyInstances" },
                    body,
                    motionType,
                    mesh
                }
            );
        }

        public async ValueTask updateBodyInstances(PhysicsBody body, Mesh mesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateBodyInstances" }, body, mesh }
            );
        }

        public async ValueTask removeBody(PhysicsBody body)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeBody" }, body }
            );
        }

        public async ValueTask sync(PhysicsBody body)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "sync" }, body }
            );
        }

        public async ValueTask syncTransform(PhysicsBody body, TransformNode transformNode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "syncTransform" }, body, transformNode }
            );
        }

        public async ValueTask setShape(PhysicsBody body, PhysicsShape shape)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setShape" }, body, shape }
            );
        }

        public async ValueTask<PhysicsShape> getShape(PhysicsBody body)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsShape>(
                entity => new PhysicsShape() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getShape" }, body }
            );
        }

        public async ValueTask<int> getShapeType(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getShapeType" }, shape }
            );
        }

        public async ValueTask setEventMask(
            PhysicsBody body,
            decimal eventMask,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEventMask" },
                    body,
                    eventMask,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getEventMask(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getEventMask" }, body, instanceIndex }
            );
        }

        public async ValueTask setMotionType(
            PhysicsBody body,
            int motionType,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMotionType" },
                    body,
                    motionType,
                    instanceIndex
                }
            );
        }

        public async ValueTask<int> getMotionType(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getMotionType" }, body, instanceIndex }
            );
        }

        public async ValueTask<PhysicsMassPropertiesCachedEntity> computeMassProperties(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeMassProperties" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask setMassProperties(
            PhysicsBody body,
            PhysicsMassProperties massProps,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMassProperties" },
                    body,
                    massProps,
                    instanceIndex
                }
            );
        }

        public async ValueTask<PhysicsMassPropertiesCachedEntity> getMassProperties(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMassProperties" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask setLinearDamping(
            PhysicsBody body,
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearDamping" },
                    body,
                    damping,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getLinearDamping(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLinearDamping" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask setAngularDamping(
            PhysicsBody body,
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularDamping" },
                    body,
                    damping,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getAngularDamping(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAngularDamping" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask setLinearVelocity(
            PhysicsBody body,
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearVelocity" },
                    body,
                    linVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask getLinearVelocityToRef(
            PhysicsBody body,
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLinearVelocityToRef" },
                    body,
                    linVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask applyImpulse(
            PhysicsBody body,
            Vector3 impulse,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyImpulse" },
                    body,
                    impulse,
                    location,
                    instanceIndex
                }
            );
        }

        public async ValueTask applyAngularImpulse(
            PhysicsBody body,
            Vector3 angularImpulse,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyAngularImpulse" },
                    body,
                    angularImpulse,
                    instanceIndex
                }
            );
        }

        public async ValueTask applyForce(
            PhysicsBody body,
            Vector3 force,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyForce" },
                    body,
                    force,
                    location,
                    instanceIndex
                }
            );
        }

        public async ValueTask setAngularVelocity(
            PhysicsBody body,
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" },
                    body,
                    angVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask getAngularVelocityToRef(
            PhysicsBody body,
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAngularVelocityToRef" },
                    body,
                    angVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask<CachedEntity> getBodyGeometry(PhysicsBody body)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getBodyGeometry" }, body }
            );
        }

        public async ValueTask disposeBody(PhysicsBody body)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeBody" }, body }
            );
        }

        public async ValueTask setCollisionCallbackEnabled(
            PhysicsBody body,
            bool enabled,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCallbackEnabled" },
                    body,
                    enabled,
                    instanceIndex
                }
            );
        }

        public async ValueTask setCollisionEndedCallbackEnabled(
            PhysicsBody body,
            bool enabled,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionEndedCallbackEnabled" },
                    body,
                    enabled,
                    instanceIndex
                }
            );
        }

        public async ValueTask addConstraint(
            PhysicsBody body,
            PhysicsBody childBody,
            PhysicsConstraint constraint,
            System.Nullable<decimal> instanceIndex = null,
            System.Nullable<decimal> childInstanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addConstraint" },
                    body,
                    childBody,
                    constraint,
                    instanceIndex,
                    childInstanceIndex
                }
            );
        }

        public async ValueTask<
            Observable<IPhysicsCollisionEventCachedEntity>
        > getCollisionObservable(PhysicsBody body, System.Nullable<decimal> instanceIndex = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<
                Observable<IPhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IPhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[]
                {
                    new string[] { this.___guid, "getCollisionObservable" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask<
            Observable<IBasePhysicsCollisionEventCachedEntity>
        > getCollisionEndedObservable(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<
                Observable<IBasePhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IBasePhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[]
                {
                    new string[] { this.___guid, "getCollisionEndedObservable" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask setGravityFactor(
            PhysicsBody body,
            decimal factor,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setGravityFactor" },
                    body,
                    factor,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getGravityFactor(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getGravityFactor" },
                    body,
                    instanceIndex
                }
            );
        }

        public async ValueTask setTargetTransform(
            PhysicsBody body,
            Vector3 position,
            Quaternion rotation,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTargetTransform" },
                    body,
                    position,
                    rotation,
                    instanceIndex
                }
            );
        }

        public async ValueTask initShape(
            PhysicsShape shape,
            int type,
            PhysicsShapeParameters options
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "initShape" }, shape, type, options }
            );
        }

        public async ValueTask setShapeFilterMembershipMask(
            PhysicsShape shape,
            decimal membershipMask
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setShapeFilterMembershipMask" },
                    shape,
                    membershipMask
                }
            );
        }

        public async ValueTask<decimal> getShapeFilterMembershipMask(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getShapeFilterMembershipMask" },
                    shape
                }
            );
        }

        public async ValueTask setShapeFilterCollideMask(PhysicsShape shape, decimal collideMask)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setShapeFilterCollideMask" },
                    shape,
                    collideMask
                }
            );
        }

        public async ValueTask<decimal> getShapeFilterCollideMask(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getShapeFilterCollideMask" }, shape }
            );
        }

        public async ValueTask setMaterial(PhysicsShape shape, PhysicsMaterial material)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMaterial" }, shape, material }
            );
        }

        public async ValueTask<PhysicsMaterialCachedEntity> getMaterial(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsMaterialCachedEntity>(
                entity => new PhysicsMaterialCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getMaterial" }, shape }
            );
        }

        public async ValueTask setDensity(PhysicsShape shape, decimal density)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDensity" }, shape, density }
            );
        }

        public async ValueTask<decimal> getDensity(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDensity" }, shape }
            );
        }

        public async ValueTask addChild(
            PhysicsShape shape,
            PhysicsShape newChild,
            Vector3 translation = null,
            Quaternion rotation = null,
            Vector3 scale = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addChild" },
                    shape,
                    newChild,
                    translation,
                    rotation,
                    scale
                }
            );
        }

        public async ValueTask removeChild(PhysicsShape shape, decimal childIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeChild" }, shape, childIndex }
            );
        }

        public async ValueTask<decimal> getNumChildren(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getNumChildren" }, shape }
            );
        }

        public async ValueTask<BoundingBox> getBoundingBox(PhysicsShape shape)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingBox" }, shape }
            );
        }

        public async ValueTask<BoundingBox> getBodyBoundingBox(PhysicsBody body)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBodyBoundingBox" }, body }
            );
        }

        public async ValueTask disposeShape(PhysicsShape shape)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeShape" }, shape }
            );
        }

        public async ValueTask setTrigger(PhysicsShape shape, bool isTrigger)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTrigger" }, shape, isTrigger }
            );
        }

        public async ValueTask initConstraint(
            PhysicsConstraint constraint,
            PhysicsBody body,
            PhysicsBody childBody
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initConstraint" },
                    constraint,
                    body,
                    childBody
                }
            );
        }

        public async ValueTask setEnabled(PhysicsConstraint constraint, bool isEnabled)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setEnabled" }, constraint, isEnabled }
            );
        }

        public async ValueTask<bool> getEnabled(PhysicsConstraint constraint)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getEnabled" }, constraint }
            );
        }

        public async ValueTask setCollisionsEnabled(PhysicsConstraint constraint, bool isEnabled)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionsEnabled" },
                    constraint,
                    isEnabled
                }
            );
        }

        public async ValueTask<bool> getCollisionsEnabled(PhysicsConstraint constraint)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getCollisionsEnabled" }, constraint }
            );
        }

        public async ValueTask setAxisFriction(
            PhysicsConstraint constraint,
            int axis,
            decimal friction
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisFriction" },
                    constraint,
                    axis,
                    friction
                }
            );
        }

        public async ValueTask<decimal> getAxisFriction(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAxisFriction" }, constraint, axis }
            );
        }

        public async ValueTask setAxisMode(PhysicsConstraint constraint, int axis, int limitMode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMode" },
                    constraint,
                    axis,
                    limitMode
                }
            );
        }

        public async ValueTask<int> getAxisMode(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getAxisMode" }, constraint, axis }
            );
        }

        public async ValueTask setAxisMinLimit(
            PhysicsConstraint constraint,
            int axis,
            decimal minLimit
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMinLimit" },
                    constraint,
                    axis,
                    minLimit
                }
            );
        }

        public async ValueTask<decimal> getAxisMinLimit(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAxisMinLimit" }, constraint, axis }
            );
        }

        public async ValueTask setAxisMaxLimit(
            PhysicsConstraint constraint,
            int axis,
            decimal limit
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMaxLimit" },
                    constraint,
                    axis,
                    limit
                }
            );
        }

        public async ValueTask<decimal> getAxisMaxLimit(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAxisMaxLimit" }, constraint, axis }
            );
        }

        public async ValueTask setAxisMotorType(
            PhysicsConstraint constraint,
            int axis,
            int motorType
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMotorType" },
                    constraint,
                    axis,
                    motorType
                }
            );
        }

        public async ValueTask<int> getAxisMotorType(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getAxisMotorType" }, constraint, axis }
            );
        }

        public async ValueTask setAxisMotorTarget(
            PhysicsConstraint constraint,
            int axis,
            decimal target
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMotorTarget" },
                    constraint,
                    axis,
                    target
                }
            );
        }

        public async ValueTask<decimal> getAxisMotorTarget(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAxisMotorTarget" },
                    constraint,
                    axis
                }
            );
        }

        public async ValueTask setAxisMotorMaxForce(
            PhysicsConstraint constraint,
            int axis,
            decimal maxForce
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMotorMaxForce" },
                    constraint,
                    axis,
                    maxForce
                }
            );
        }

        public async ValueTask<decimal> getAxisMotorMaxForce(PhysicsConstraint constraint, int axis)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAxisMotorMaxForce" },
                    constraint,
                    axis
                }
            );
        }

        public async ValueTask disposeConstraint(PhysicsConstraint constraint)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeConstraint" }, constraint }
            );
        }

        public async ValueTask<CachedEntity[]> getBodiesUsingConstraint(
            PhysicsConstraint constraint
        )
        {
            return await EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getBodiesUsingConstraint" },
                    constraint
                }
            );
        }

        public async ValueTask raycast(
            Vector3 from,
            Vector3 to,
            PhysicsRaycastResult result,
            IRaycastQuery query = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "raycast" }, from, to, result, query }
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
