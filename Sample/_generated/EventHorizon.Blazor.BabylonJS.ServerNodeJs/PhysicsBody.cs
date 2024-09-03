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

        public async ValueTask<bool> get_disablePreStep()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disablePreStep");
        }

        public ValueTask set_disablePreStep(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disablePreStep", value);
        }

        public async ValueTask<decimal> get_numInstances()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numInstances");
        }

        public async ValueTask<int> get_motionType()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "motionType");
        }

        private PhysicsShape __shape;

        public async ValueTask<PhysicsShape> get_shape()
        {
            if (__shape == null)
            {
                __shape = await EventHorizonBlazorInterop.GetClass<PhysicsShape>(
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

        public ValueTask set_shape(PhysicsShape value)
        {
            __shape = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
        }

        public async ValueTask<bool> get_isDisposed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed");
        }
        #endregion

        #region Properties
        private TransformNode __transformNode;

        public async ValueTask<TransformNode> get_transformNode()
        {
            if (__transformNode == null)
            {
                __transformNode = await EventHorizonBlazorInterop.GetClass<TransformNode>(
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

        public ValueTask set_transformNode(TransformNode value)
        {
            __transformNode = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "transformNode", value);
        }

        public async ValueTask<bool> get_disableSync()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableSync");
        }

        public ValueTask set_disableSync(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableSync", value);
        }

        public async ValueTask<bool> get_startAsleep()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "startAsleep");
        }

        public ValueTask set_startAsleep(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "startAsleep", value);
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

        public static async ValueTask<PhysicsBody> NewPhysicsBody(
            TransformNode transformNode,
            int motionType,
            bool startsAsleep,
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsBody" },
                transformNode,
                motionType,
                startsAsleep,
                scene
            );

            return new PhysicsBody(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<PhysicsBody> clone(TransformNode transformNode)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsBody>(
                entity => new PhysicsBody() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, transformNode }
            );
        }

        public async ValueTask updateBodyInstances()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateBodyInstances" } }
            );
        }

        public async ValueTask<BoundingBox> getBoundingBox()
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingBox" } }
            );
        }

        public async ValueTask setEventMask(
            decimal eventMask,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEventMask" },
                    eventMask,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getEventMask(System.Nullable<decimal> instanceIndex = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getEventMask" }, instanceIndex }
            );
        }

        public async ValueTask setMotionType(
            int motionType,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMotionType" },
                    motionType,
                    instanceIndex
                }
            );
        }

        public async ValueTask<int> getMotionType(System.Nullable<decimal> instanceIndex = null)
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getMotionType" }, instanceIndex }
            );
        }

        public async ValueTask setPrestepType(int prestepType)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setPrestepType" }, prestepType }
            );
        }

        public async ValueTask<int> getPrestepType()
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] { new string[] { this.___guid, "getPrestepType" } }
            );
        }

        public async ValueTask<PhysicsMassPropertiesCachedEntity> computeMassProperties(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeMassProperties" },
                    instanceIndex
                }
            );
        }

        public async ValueTask setMassProperties(
            PhysicsMassProperties massProps,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMassProperties" },
                    massProps,
                    instanceIndex
                }
            );
        }

        public async ValueTask<PhysicsMassPropertiesCachedEntity> getMassProperties(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsMassPropertiesCachedEntity>(
                entity => new PhysicsMassPropertiesCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getMassProperties" }, instanceIndex }
            );
        }

        public async ValueTask setLinearDamping(
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearDamping" },
                    damping,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getLinearDamping(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getLinearDamping" }, instanceIndex }
            );
        }

        public async ValueTask setAngularDamping(
            decimal damping,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularDamping" },
                    damping,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getAngularDamping(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getAngularDamping" }, instanceIndex }
            );
        }

        public async ValueTask setLinearVelocity(
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLinearVelocity" },
                    linVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask getLinearVelocityToRef(
            Vector3 linVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLinearVelocityToRef" },
                    linVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask<Vector3> getLinearVelocity(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLinearVelocity" }, instanceIndex }
            );
        }

        public async ValueTask setAngularVelocity(
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAngularVelocity" },
                    angVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask getAngularVelocityToRef(
            Vector3 angVel,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAngularVelocityToRef" },
                    angVel,
                    instanceIndex
                }
            );
        }

        public async ValueTask<Vector3> getAngularVelocity(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAngularVelocity" }, instanceIndex }
            );
        }

        public async ValueTask applyImpulse(
            Vector3 impulse,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyImpulse" },
                    impulse,
                    location,
                    instanceIndex
                }
            );
        }

        public async ValueTask applyAngularImpulse(
            Vector3 angularImpulse,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyAngularImpulse" },
                    angularImpulse,
                    instanceIndex
                }
            );
        }

        public async ValueTask applyForce(
            Vector3 force,
            Vector3 location,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyForce" },
                    force,
                    location,
                    instanceIndex
                }
            );
        }

        public async ValueTask<CachedEntity> getGeometry()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getGeometry" } }
            );
        }

        public async ValueTask<
            Observable<IPhysicsCollisionEventCachedEntity>
        > getCollisionObservable()
        {
            return await EventHorizonBlazorInterop.FuncClass<
                Observable<IPhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IPhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[] { new string[] { this.___guid, "getCollisionObservable" } }
            );
        }

        public async ValueTask<
            Observable<IBasePhysicsCollisionEventCachedEntity>
        > getCollisionEndedObservable()
        {
            return await EventHorizonBlazorInterop.FuncClass<
                Observable<IBasePhysicsCollisionEventCachedEntity>
            >(
                entity => new Observable<IBasePhysicsCollisionEventCachedEntity>()
                {
                    ___guid = entity.___guid
                },
                new object[] { new string[] { this.___guid, "getCollisionEndedObservable" } }
            );
        }

        public async ValueTask setCollisionCallbackEnabled(bool enabled)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionCallbackEnabled" },
                    enabled
                }
            );
        }

        public async ValueTask setCollisionEndedCallbackEnabled(bool enabled)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCollisionEndedCallbackEnabled" },
                    enabled
                }
            );
        }

        public async ValueTask<Vector3> getObjectCenterWorld(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectCenterWorld" },
                    instanceIndex
                }
            );
        }

        public async ValueTask<Vector3> getObjectCenterWorldToRef(
            Vector3 @ref,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getObjectCenterWorldToRef" },
                    @ref,
                    instanceIndex
                }
            );
        }

        public async ValueTask addConstraint(
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
                    childBody,
                    constraint,
                    instanceIndex,
                    childInstanceIndex
                }
            );
        }

        public async ValueTask syncWithBone(
            Bone bone,
            AbstractMesh boneMesh,
            Vector3 jointPivot,
            System.Nullable<decimal> distToJoint = null,
            Quaternion adjustRotation = null,
            Vector3 boneAxis = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<string> iterateOverAllInstances(
            Func<PhysicsBody, System.Nullable<decimal>, Task> callback
        )
        {
            await SetupIterateOverAllInstancesLoop();

            var handle = Guid.NewGuid().ToString();
            _iterateOverAllInstancesActionMap.Add(handle, callback);

            return handle;
        }

        private async ValueTask SetupIterateOverAllInstancesLoop()
        {
            if (_isIterateOverAllInstancesEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask setGravityFactor(
            decimal factor,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setGravityFactor" },
                    factor,
                    instanceIndex
                }
            );
        }

        public async ValueTask<decimal> getGravityFactor(
            System.Nullable<decimal> instanceIndex = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getGravityFactor" }, instanceIndex }
            );
        }

        public async ValueTask setTargetTransform(
            Vector3 position,
            Quaternion rotation,
            System.Nullable<decimal> instanceIndex = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTargetTransform" },
                    position,
                    rotation,
                    instanceIndex
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
