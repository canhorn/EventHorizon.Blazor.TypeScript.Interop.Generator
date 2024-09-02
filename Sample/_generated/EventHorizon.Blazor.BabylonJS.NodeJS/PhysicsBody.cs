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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsBody>))]
    public class PhysicsBody : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool disablePreStep
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disablePreStep"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disablePreStep", value);
            }
        }

        public decimal numInstances
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numInstances"); }
        }

        public int motionType
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "motionType"); }
        }

        private PhysicsShape __shape;
        public PhysicsShape shape
        {
            get
            {
                if (__shape == null)
                {
                    __shape = EventHorizonBlazorInterop.GetClass<PhysicsShape>(
                        this.___guid,
                        "shape",
                        (entity) =>
                        {
                            return new PhysicsShape() { ___guid = entity.___guid };
                        }
                    );
                }
                return __shape;
            }
            set
            {
                __shape = null;
                EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
            }
        }

        public bool isDisposed
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed"); }
        }
        #endregion

        #region Properties
        private TransformNode __transformNode;
        public TransformNode transformNode
        {
            get
            {
                if (__transformNode == null)
                {
                    __transformNode = EventHorizonBlazorInterop.GetClass<TransformNode>(
                        this.___guid,
                        "transformNode",
                        (entity) =>
                        {
                            return new TransformNode() { ___guid = entity.___guid };
                        }
                    );
                }
                return __transformNode;
            }
            set
            {
                __transformNode = null;
                EventHorizonBlazorInterop.Set(this.___guid, "transformNode", value);
            }
        }

        public bool disableSync
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableSync"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableSync", value);
            }
        }

        public bool startAsleep
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "startAsleep"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "startAsleep", value);
            }
        }
        #endregion

        #region Constructor
        public PhysicsBody()
            : base() { }

        public PhysicsBody(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PhysicsBody(
            TransformNode transformNode,
            int motionType,
            bool startsAsleep,
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsBody" },
                transformNode,
                motionType,
                startsAsleep,
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public PhysicsBody clone(TransformNode transformNode)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsBody>(
                entity => new PhysicsBody() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, transformNode }
            );
        }

        public void updateBodyInstances()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateBodyInstances" } }
            );
        }

        public BoundingBox getBoundingBox()
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingBox" } }
            );
        }

        public void setEventMask(decimal eventMask, System.Nullable<decimal> instanceIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEventMask" },
                    eventMask,
                    instanceIndex
                }
            );
        }

        public decimal getEventMask(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getEventMask" }, instanceIndex }
            );
        }

        public void setMotionType(int motionType, System.Nullable<decimal> instanceIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMotionType" },
                    motionType,
                    instanceIndex
                }
            );
        }

        public int getMotionType(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getMotionType" }, instanceIndex }
            );
        }

        public void setPrestepType(int prestepType)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setPrestepType" }, prestepType }
            );
        }

        public int getPrestepType()
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getPrestepType" } }
            );
        }

        public PhysicsMassPropertiesCachedEntity computeMassProperties(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeMassProperties" },
                    instanceIndex
                }
            );
        }

        public void setMassProperties(
            PhysicsMassProperties massProps,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMassProperties" },
                    massProps,
                    instanceIndex
                }
            );
        }

        public PhysicsMassPropertiesCachedEntity getMassProperties(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getMassProperties" }, instanceIndex }
            );
        }

        public void setLinearDamping(decimal damping, System.Nullable<decimal> instanceIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearDamping" },
                    damping,
                    instanceIndex
                }
            );
        }

        public decimal getLinearDamping(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getLinearDamping" }, instanceIndex }
            );
        }

        public void setAngularDamping(
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularDamping" },
                    damping,
                    instanceIndex
                }
            );
        }

        public decimal getAngularDamping(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAngularDamping" }, instanceIndex }
            );
        }

        public void setLinearVelocity(Vector3 linVel, System.Nullable<decimal> instanceIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearVelocity" },
                    linVel,
                    instanceIndex
                }
            );
        }

        public void getLinearVelocityToRef(
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLinearVelocityToRef" },
                    linVel,
                    instanceIndex
                }
            );
        }

        public Vector3 getLinearVelocity(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLinearVelocity" }, instanceIndex }
            );
        }

        public void setAngularVelocity(
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" },
                    angVel,
                    instanceIndex
                }
            );
        }

        public void getAngularVelocityToRef(
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAngularVelocityToRef" },
                    angVel,
                    instanceIndex
                }
            );
        }

        public Vector3 getAngularVelocity(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAngularVelocity" }, instanceIndex }
            );
        }

        public void applyImpulse(
            Vector3 impulse,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyImpulse" },
                    impulse,
                    location,
                    instanceIndex
                }
            );
        }

        public void applyAngularImpulse(
            Vector3 angularImpulse,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyAngularImpulse" },
                    angularImpulse,
                    instanceIndex
                }
            );
        }

        public void applyForce(
            Vector3 force,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyForce" },
                    force,
                    location,
                    instanceIndex
                }
            );
        }

        public CachedEntity getGeometry()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getGeometry" } }
            );
        }

        public Observable<IPhysicsCollisionEventCachedEntity> getCollisionObservable()
        {
            return EventHorizonBlazorInterop.FuncClass<
                Observable<IPhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IPhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[] { new string[] { this.___guid, "getCollisionObservable" } }
            );
        }

        public Observable<IBasePhysicsCollisionEventCachedEntity> getCollisionEndedObservable()
        {
            return EventHorizonBlazorInterop.FuncClass<
                Observable<IBasePhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IBasePhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[] { new string[] { this.___guid, "getCollisionEndedObservable" } }
            );
        }

        public void setCollisionCallbackEnabled(bool enabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCallbackEnabled" },
                    enabled
                }
            );
        }

        public void setCollisionEndedCallbackEnabled(bool enabled)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionEndedCallbackEnabled" },
                    enabled
                }
            );
        }

        public Vector3 getObjectCenterWorld(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectCenterWorld" },
                    instanceIndex
                }
            );
        }

        public Vector3 getObjectCenterWorldToRef(
            Vector3 @ref,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectCenterWorldToRef" },
                    @ref,
                    instanceIndex
                }
            );
        }

        public void addConstraint(
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
                    childBody,
                    constraint,
                    instanceIndex,
                    childInstanceIndex
                }
            );
        }

        public void syncWithBone(
            Bone bone,
            AbstractMesh boneMesh,
            Vector3 jointPivot,
            System.Nullable<decimal> distToJoint = null,
            Quaternion adjustRotation = null,
            Vector3 boneAxis = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncWithBone" },
                    bone,
                    boneMesh,
                    jointPivot,
                    distToJoint,
                    adjustRotation,
                    boneAxis
                }
            );
        }

        #region iterateOverAllInstances TODO: Get Comments as metadata identification
        private bool _isIterateOverAllInstancesEnabled = false;
        private readonly IDictionary<
            string,
            Func<PhysicsBody, System.Nullable<decimal>, Task>
        > _iterateOverAllInstancesActionMap =
            new Dictionary<string, Func<PhysicsBody, System.Nullable<decimal>, Task>>();

        public string iterateOverAllInstances(
            Func<PhysicsBody, System.Nullable<decimal>, Task> callback
        )
        {
            SetupIterateOverAllInstancesLoop();

            var handle = Guid.NewGuid().ToString();
            _iterateOverAllInstancesActionMap.Add(handle, callback);

            return handle;
        }

        public bool iterateOverAllInstances_Remove(string handle)
        {
            return _iterateOverAllInstancesActionMap.Remove(handle);
        }

        private void SetupIterateOverAllInstancesLoop()
        {
            if (_isIterateOverAllInstancesEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "iterateOverAllInstances",
                "CallIterateOverAllInstancesActions",
                _invokableReference
            );
            _isIterateOverAllInstancesEnabled = true;
        }

        [JSInvokable]
        public async Task CallIterateOverAllInstancesActions(
            PhysicsBody body,
            System.Nullable<decimal> instanceIndex
        )
        {
            foreach (var action in _iterateOverAllInstancesActionMap.Values)
            {
                await action(body, instanceIndex);
            }
        }
        #endregion

        public void setGravityFactor(decimal factor, System.Nullable<decimal> instanceIndex = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setGravityFactor" },
                    factor,
                    instanceIndex
                }
            );
        }

        public decimal getGravityFactor(System.Nullable<decimal> instanceIndex = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getGravityFactor" }, instanceIndex }
            );
        }

        public void setTargetTransform(
            Vector3 position,
            Quaternion rotation,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTargetTransform" },
                    position,
                    rotation,
                    instanceIndex
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
