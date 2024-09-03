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

    [JsonConverter(typeof(CachedEntityConverter<HavokPlugin>))]
    public class HavokPlugin : CachedEntityObject, IPhysicsEnginePluginV2
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public CachedEntity numBodies
        {
            get { return EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "numBodies"); }
        }
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

        private Observable<IPhysicsCollisionEventCachedEntity> __onCollisionObservable;
        public Observable<IPhysicsCollisionEventCachedEntity> onCollisionObservable
        {
            get
            {
                if (__onCollisionObservable == null)
                {
                    __onCollisionObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onCollisionObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onCollisionObservable", value);
            }
        }

        private Observable<IBasePhysicsCollisionEventCachedEntity> __onCollisionEndedObservable;
        public Observable<IBasePhysicsCollisionEventCachedEntity> onCollisionEndedObservable
        {
            get
            {
                if (__onCollisionEndedObservable == null)
                {
                    __onCollisionEndedObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onCollisionEndedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onCollisionEndedObservable", value);
            }
        }

        private Observable<IBasePhysicsCollisionEventCachedEntity> __onTriggerCollisionObservable;
        public Observable<IBasePhysicsCollisionEventCachedEntity> onTriggerCollisionObservable
        {
            get
            {
                if (__onTriggerCollisionObservable == null)
                {
                    __onTriggerCollisionObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onTriggerCollisionObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onTriggerCollisionObservable", value);
            }
        }
        #endregion

        #region Constructor
        public HavokPlugin()
            : base() { }

        public HavokPlugin(ICachedEntity entity)
            : base(entity) { }

        public HavokPlugin(
            System.Nullable<bool> _useDeltaForWorldStep = null,
            object hpInjection = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "HavokPlugin" },
                _useDeltaForWorldStep,
                hpInjection
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isSupported()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSupported" } }
            );
        }

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

        public void executeStep(decimal delta, PhysicsBody[] physicsBodies)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeStep" }, delta, physicsBodies }
            );
        }

        public decimal getPluginVersion()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getPluginVersion" } }
            );
        }

        public void setVelocityLimits(decimal maxLinearVelocity, decimal maxAngularVelocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVelocityLimits" },
                    maxLinearVelocity,
                    maxAngularVelocity
                }
            );
        }

        public decimal getMaxLinearVelocity()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getMaxLinearVelocity" } }
            );
        }

        public decimal getMaxAngularVelocity()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getMaxAngularVelocity" } }
            );
        }

        public void initBody(
            PhysicsBody body,
            int motionType,
            Vector3 position,
            Quaternion orientation
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void removeBody(PhysicsBody body)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeBody" }, body }
            );
        }

        public void initBodyInstances(PhysicsBody body, int motionType, Mesh mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initBodyInstances" },
                    body,
                    motionType,
                    mesh
                }
            );
        }

        public void updateBodyInstances(PhysicsBody body, Mesh mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateBodyInstances" }, body, mesh }
            );
        }

        public void sync(PhysicsBody body)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "sync" }, body }
            );
        }

        public void syncTransform(PhysicsBody body, TransformNode transformNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "syncTransform" }, body, transformNode }
            );
        }

        public void setShape(PhysicsBody body, PhysicsShape shape)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setShape" }, body, shape }
            );
        }

        public PhysicsShape getShape(PhysicsBody body)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsShape>(
                entity => new PhysicsShape() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getShape" }, body }
            );
        }

        public int getShapeType(PhysicsShape shape)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getShapeType" }, shape }
            );
        }

        public void setEventMask(
            PhysicsBody body,
            decimal eventMask,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEventMask" },
                    body,
                    eventMask,
                    instanceIndex
                }
            );
        }

        public decimal getEventMask(PhysicsBody body, System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getEventMask" }, body, instanceIndex }
            );
        }

        public void setMotionType(
            PhysicsBody body,
            int motionType,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMotionType" },
                    body,
                    motionType,
                    instanceIndex
                }
            );
        }

        public int getMotionType(PhysicsBody body, System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getMotionType" }, body, instanceIndex }
            );
        }

        public void setActivationControl(PhysicsBody body, int controlMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setActivationControl" },
                    body,
                    controlMode
                }
            );
        }

        public PhysicsMassPropertiesCachedEntity computeMassProperties(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeMassProperties" },
                    body,
                    instanceIndex
                }
            );
        }

        public void setMassProperties(
            PhysicsBody body,
            PhysicsMassProperties massProps,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMassProperties" },
                    body,
                    massProps,
                    instanceIndex
                }
            );
        }

        public PhysicsMassPropertiesCachedEntity getMassProperties(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMassProperties" },
                    body,
                    instanceIndex
                }
            );
        }

        public void setLinearDamping(
            PhysicsBody body,
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearDamping" },
                    body,
                    damping,
                    instanceIndex
                }
            );
        }

        public decimal getLinearDamping(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getLinearDamping" },
                    body,
                    instanceIndex
                }
            );
        }

        public void setAngularDamping(
            PhysicsBody body,
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularDamping" },
                    body,
                    damping,
                    instanceIndex
                }
            );
        }

        public decimal getAngularDamping(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAngularDamping" },
                    body,
                    instanceIndex
                }
            );
        }

        public void setLinearVelocity(
            PhysicsBody body,
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearVelocity" },
                    body,
                    linVel,
                    instanceIndex
                }
            );
        }

        public void getLinearVelocityToRef(
            PhysicsBody body,
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLinearVelocityToRef" },
                    body,
                    linVel,
                    instanceIndex
                }
            );
        }

        public void applyImpulse(
            PhysicsBody body,
            Vector3 impulse,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void applyAngularImpulse(
            PhysicsBody body,
            Vector3 angularImpulse,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyAngularImpulse" },
                    body,
                    angularImpulse,
                    instanceIndex
                }
            );
        }

        public void applyForce(
            PhysicsBody body,
            Vector3 force,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setAngularVelocity(
            PhysicsBody body,
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" },
                    body,
                    angVel,
                    instanceIndex
                }
            );
        }

        public void getAngularVelocityToRef(
            PhysicsBody body,
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAngularVelocityToRef" },
                    body,
                    angVel,
                    instanceIndex
                }
            );
        }

        public void setPhysicsBodyTransformation(PhysicsBody body, TransformNode node)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPhysicsBodyTransformation" },
                    body,
                    node
                }
            );
        }

        public void setTargetTransform(
            PhysicsBody body,
            Vector3 position,
            Quaternion rotation,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setGravityFactor(
            PhysicsBody body,
            decimal factor,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setGravityFactor" },
                    body,
                    factor,
                    instanceIndex
                }
            );
        }

        public decimal getGravityFactor(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getGravityFactor" },
                    body,
                    instanceIndex
                }
            );
        }

        public void disposeBody(PhysicsBody body)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeBody" }, body }
            );
        }

        public void initShape(PhysicsShape shape, int type, PhysicsShapeParameters options)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "initShape" }, shape, type, options }
            );
        }

        public void setShapeFilterMembershipMask(PhysicsShape shape, decimal membershipMask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setShapeFilterMembershipMask" },
                    shape,
                    membershipMask
                }
            );
        }

        public decimal getShapeFilterMembershipMask(PhysicsShape shape)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getShapeFilterMembershipMask" },
                    shape
                }
            );
        }

        public void setShapeFilterCollideMask(PhysicsShape shape, decimal collideMask)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setShapeFilterCollideMask" },
                    shape,
                    collideMask
                }
            );
        }

        public decimal getShapeFilterCollideMask(PhysicsShape shape)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getShapeFilterCollideMask" }, shape }
            );
        }

        public void setMaterial(PhysicsShape shape, PhysicsMaterial material)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMaterial" }, shape, material }
            );
        }

        public PhysicsMaterialCachedEntity getMaterial(PhysicsShape shape)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsMaterialCachedEntity>(
                entity => new PhysicsMaterialCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getMaterial" }, shape }
            );
        }

        public void setDensity(PhysicsShape shape, decimal density)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDensity" }, shape, density }
            );
        }

        public decimal getDensity(PhysicsShape shape)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDensity" }, shape }
            );
        }

        public void addChild(
            PhysicsShape shape,
            PhysicsShape newChild,
            Vector3 translation = null,
            Quaternion rotation = null,
            Vector3 scale = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void removeChild(PhysicsShape shape, decimal childIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeChild" }, shape, childIndex }
            );
        }

        public decimal getNumChildren(PhysicsShape shape)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getNumChildren" }, shape }
            );
        }

        public void setTrigger(PhysicsShape shape, bool isTrigger)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTrigger" }, shape, isTrigger }
            );
        }

        public BoundingBox getBoundingBox(PhysicsShape _shape)
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingBox" }, _shape }
            );
        }

        public BoundingBox getBodyBoundingBox(PhysicsBody body)
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBodyBoundingBox" }, body }
            );
        }

        public CachedEntity getBodyGeometry(PhysicsBody body)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getBodyGeometry" }, body }
            );
        }

        public void disposeShape(PhysicsShape shape)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeShape" }, shape }
            );
        }

        public void initConstraint(
            PhysicsConstraint constraint,
            PhysicsBody body,
            PhysicsBody childBody,
            System.Nullable<decimal> instanceIndex = null,
            System.Nullable<decimal> childInstanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initConstraint" },
                    constraint,
                    body,
                    childBody,
                    instanceIndex,
                    childInstanceIndex
                }
            );
        }

        public CachedEntity[] getBodiesUsingConstraint(PhysicsConstraint constraint)
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getBodiesUsingConstraint" },
                    constraint
                }
            );
        }

        public void addConstraint(
            PhysicsBody body,
            PhysicsBody childBody,
            PhysicsConstraint constraint,
            System.Nullable<decimal> instanceIndex = null,
            System.Nullable<decimal> childInstanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setEnabled(PhysicsConstraint constraint, bool isEnabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setEnabled" }, constraint, isEnabled }
            );
        }

        public bool getEnabled(PhysicsConstraint constraint)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getEnabled" }, constraint }
            );
        }

        public void setCollisionsEnabled(PhysicsConstraint constraint, bool isEnabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionsEnabled" },
                    constraint,
                    isEnabled
                }
            );
        }

        public bool getCollisionsEnabled(PhysicsConstraint constraint)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "getCollisionsEnabled" }, constraint }
            );
        }

        public void setAxisFriction(PhysicsConstraint constraint, int axis, decimal friction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisFriction" },
                    constraint,
                    axis,
                    friction
                }
            );
        }

        public decimal getAxisFriction(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAxisFriction" }, constraint, axis }
            );
        }

        public void setAxisMode(PhysicsConstraint constraint, int axis, int limitMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMode" },
                    constraint,
                    axis,
                    limitMode
                }
            );
        }

        public int getAxisMode(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getAxisMode" }, constraint, axis }
            );
        }

        public void setAxisMinLimit(PhysicsConstraint constraint, int axis, decimal limit)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMinLimit" },
                    constraint,
                    axis,
                    limit
                }
            );
        }

        public decimal getAxisMinLimit(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAxisMinLimit" }, constraint, axis }
            );
        }

        public void setAxisMaxLimit(PhysicsConstraint constraint, int axis, decimal limit)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMaxLimit" },
                    constraint,
                    axis,
                    limit
                }
            );
        }

        public decimal getAxisMaxLimit(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAxisMaxLimit" }, constraint, axis }
            );
        }

        public void setAxisMotorType(PhysicsConstraint constraint, int axis, int motorType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMotorType" },
                    constraint,
                    axis,
                    motorType
                }
            );
        }

        public int getAxisMotorType(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getAxisMotorType" }, constraint, axis }
            );
        }

        public void setAxisMotorTarget(PhysicsConstraint constraint, int axis, decimal target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMotorTarget" },
                    constraint,
                    axis,
                    target
                }
            );
        }

        public decimal getAxisMotorTarget(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAxisMotorTarget" },
                    constraint,
                    axis
                }
            );
        }

        public void setAxisMotorMaxForce(PhysicsConstraint constraint, int axis, decimal maxForce)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisMotorMaxForce" },
                    constraint,
                    axis,
                    maxForce
                }
            );
        }

        public decimal getAxisMotorMaxForce(PhysicsConstraint constraint, int axis)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAxisMotorMaxForce" },
                    constraint,
                    axis
                }
            );
        }

        public void disposeConstraint(PhysicsConstraint constraint)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "disposeConstraint" }, constraint }
            );
        }

        public void raycast(
            Vector3 from,
            Vector3 to,
            PhysicsRaycastResult result,
            IRaycastQuery query = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "raycast" }, from, to, result, query }
            );
        }

        public void pointProximity(IPhysicsPointProximityQuery query, ProximityCastResult result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pointProximity" }, query, result }
            );
        }

        public void shapeProximity(
            IPhysicsShapeProximityCastQuery query,
            ProximityCastResult inputShapeResult,
            ProximityCastResult hitShapeResult
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shapeProximity" },
                    query,
                    inputShapeResult,
                    hitShapeResult
                }
            );
        }

        public void shapeCast(
            IPhysicsShapeCastQuery query,
            ShapeCastResult inputShapeResult,
            ShapeCastResult hitShapeResult
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "shapeCast" },
                    query,
                    inputShapeResult,
                    hitShapeResult
                }
            );
        }

        public Observable<IPhysicsCollisionEventCachedEntity> getCollisionObservable(
            PhysicsBody body
        )
        {
            return EventHorizonBlazorInterop.FuncClass<
                Observable<IPhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IPhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[] { new string[] { this.___guid, "getCollisionObservable" }, body }
            );
        }

        public Observable<IBasePhysicsCollisionEventCachedEntity> getCollisionEndedObservable(
            PhysicsBody body
        )
        {
            return EventHorizonBlazorInterop.FuncClass<
                Observable<IBasePhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IBasePhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[] { new string[] { this.___guid, "getCollisionEndedObservable" }, body }
            );
        }

        public void setCollisionCallbackEnabled(PhysicsBody body, bool enabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCallbackEnabled" },
                    body,
                    enabled
                }
            );
        }

        public void setCollisionEndedCallbackEnabled(PhysicsBody body, bool enabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionEndedCallbackEnabled" },
                    body,
                    enabled
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
