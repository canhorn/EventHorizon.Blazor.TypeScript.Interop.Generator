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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsImpostor>))]
    public class PhysicsImpostor : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Vector3 __DEFAULT_OBJECT_SIZE;

        public static async ValueTask<Vector3> get_DEFAULT_OBJECT_SIZE()
        {
            if (__DEFAULT_OBJECT_SIZE == null)
            {
                __DEFAULT_OBJECT_SIZE = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "PhysicsImpostor.DEFAULT_OBJECT_SIZE",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __DEFAULT_OBJECT_SIZE;
        }

        public static ValueTask set_DEFAULT_OBJECT_SIZE(Vector3 value)
        {
            __DEFAULT_OBJECT_SIZE = null;
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.DEFAULT_OBJECT_SIZE",
                value
            );
        }

        private static Quaternion __IDENTITY_QUATERNION;

        public static async ValueTask<Quaternion> get_IDENTITY_QUATERNION()
        {
            if (__IDENTITY_QUATERNION == null)
            {
                __IDENTITY_QUATERNION = await EventHorizonBlazorInterop.GetClass<Quaternion>(
                    "BABYLON",
                    "PhysicsImpostor.IDENTITY_QUATERNION",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __IDENTITY_QUATERNION;
        }

        public static ValueTask set_IDENTITY_QUATERNION(Quaternion value)
        {
            __IDENTITY_QUATERNION = null;
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.IDENTITY_QUATERNION",
                value
            );
        }

        public static async ValueTask<decimal> get_NoImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.NoImpostor"
            );
        }

        public static ValueTask set_NoImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.NoImpostor", value);
        }

        public static async ValueTask<decimal> get_SphereImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.SphereImpostor"
            );
        }

        public static ValueTask set_SphereImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.SphereImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_BoxImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.BoxImpostor"
            );
        }

        public static ValueTask set_BoxImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.BoxImpostor", value);
        }

        public static async ValueTask<decimal> get_PlaneImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.PlaneImpostor"
            );
        }

        public static ValueTask set_PlaneImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.PlaneImpostor", value);
        }

        public static async ValueTask<decimal> get_MeshImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.MeshImpostor"
            );
        }

        public static ValueTask set_MeshImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.MeshImpostor", value);
        }

        public static async ValueTask<decimal> get_CapsuleImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.CapsuleImpostor"
            );
        }

        public static ValueTask set_CapsuleImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.CapsuleImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_CylinderImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.CylinderImpostor"
            );
        }

        public static ValueTask set_CylinderImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.CylinderImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_ParticleImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.ParticleImpostor"
            );
        }

        public static ValueTask set_ParticleImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.ParticleImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_HeightmapImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.HeightmapImpostor"
            );
        }

        public static ValueTask set_HeightmapImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.HeightmapImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_ConvexHullImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.ConvexHullImpostor"
            );
        }

        public static ValueTask set_ConvexHullImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.ConvexHullImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_CustomImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.CustomImpostor"
            );
        }

        public static ValueTask set_CustomImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.CustomImpostor",
                value
            );
        }

        public static async ValueTask<decimal> get_RopeImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.RopeImpostor"
            );
        }

        public static ValueTask set_RopeImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.RopeImpostor", value);
        }

        public static async ValueTask<decimal> get_ClothImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.ClothImpostor"
            );
        }

        public static ValueTask set_ClothImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.ClothImpostor", value);
        }

        public static async ValueTask<decimal> get_SoftbodyImpostor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsImpostor.SoftbodyImpostor"
            );
        }

        public static ValueTask set_SoftbodyImpostor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsImpostor.SoftbodyImpostor",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_isDisposed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed");
        }

        public async ValueTask<decimal> get_mass()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass");
        }

        public ValueTask set_mass(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
        }

        public async ValueTask<decimal> get_friction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction");
        }

        public ValueTask set_friction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
        }

        public async ValueTask<decimal> get_restitution()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution");
        }

        public ValueTask set_restitution(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
        }

        public async ValueTask<decimal> get_pressure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pressure");
        }

        public ValueTask set_pressure(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pressure", value);
        }

        public async ValueTask<decimal> get_stiffness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stiffness");
        }

        public ValueTask set_stiffness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "stiffness", value);
        }

        public async ValueTask<decimal> get_velocityIterations()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "velocityIterations");
        }

        public ValueTask set_velocityIterations(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "velocityIterations", value);
        }

        public async ValueTask<decimal> get_positionIterations()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "positionIterations");
        }

        public ValueTask set_positionIterations(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "positionIterations", value);
        }

        public async ValueTask<CachedEntity> get_physicsBody()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "physicsBody");
        }

        public ValueTask set_physicsBody(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "physicsBody", value);
        }

        private PhysicsImpostor __parent;

        public async ValueTask<PhysicsImpostor> get_parent()
        {
            if (__parent == null)
            {
                __parent = await EventHorizonBlazorInterop.GetClass<PhysicsImpostor>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new PhysicsImpostor() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
        }

        public ValueTask set_parent(PhysicsImpostor value)
        {
            __parent = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
        }
        #endregion

        #region Properties
        private IPhysicsEnabledObjectCachedEntity __object;

        public async ValueTask<IPhysicsEnabledObjectCachedEntity> get_object()
        {
            if (__object == null)
            {
                __object =
                    await EventHorizonBlazorInterop.GetClass<IPhysicsEnabledObjectCachedEntity>(
                        this.___guid,
                        "object",
                        (entity) =>
                        {
                            return new IPhysicsEnabledObjectCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __object;
        }

        public ValueTask set_object(IPhysicsEnabledObjectCachedEntity value)
        {
            __object = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "object", value);
        }

        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type");
        }

        public ValueTask set_type(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }

        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId");
        }

        public ValueTask set_uniqueId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
        }

        public async ValueTask<bool> get_soft()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "soft");
        }

        public ValueTask set_soft(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "soft", value);
        }

        public async ValueTask<decimal> get_segments()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "segments");
        }

        public ValueTask set_segments(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "segments", value);
        }

        public async ValueTask<
            ActionCallback<PhysicsImpostor, PhysicsImpostor>
        > get_onCollideEvent()
        {
            return await EventHorizonBlazorInterop.Get<
                ActionCallback<PhysicsImpostor, PhysicsImpostor>
            >(this.___guid, "onCollideEvent");
        }

        public ValueTask set_onCollideEvent(ActionCallback<PhysicsImpostor, PhysicsImpostor> value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "onCollideEvent", value);
        }
        #endregion

        #region Constructor
        public PhysicsImpostor()
            : base() { }

        public PhysicsImpostor(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PhysicsImpostor> NewPhysicsImpostor(
            IPhysicsEnabledObject @object,
            decimal type,
            PhysicsImpostorParameters _options = null,
            Scene _scene = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsImpostor" },
                @object,
                type,
                _options,
                _scene
            );

            return new PhysicsImpostor(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isBodyInitRequired()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isBodyInitRequired" } }
            );
        }

        public async ValueTask setScalingUpdated()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setScalingUpdated" } }
            );
        }

        public async ValueTask forceUpdate()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "forceUpdate" } }
            );
        }

        public async ValueTask resetUpdateFlags()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetUpdateFlags" } }
            );
        }

        public async ValueTask<Vector3> getObjectExtents()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getObjectExtents" } }
            );
        }

        public async ValueTask<Vector3> getObjectCenter()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getObjectCenter" } }
            );
        }

        public async ValueTask<CachedEntity> getParam(string paramName)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getParam" }, paramName }
            );
        }

        public async ValueTask setParam(string paramName, decimal value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setParam" }, paramName, value }
            );
        }

        public async ValueTask setMass(decimal mass)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMass" }, mass }
            );
        }

        public async ValueTask<Vector3> getLinearVelocity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLinearVelocity" } }
            );
        }

        public async ValueTask setLinearVelocity(Vector3 velocity)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setLinearVelocity" }, velocity }
            );
        }

        public async ValueTask<Vector3> getAngularVelocity()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAngularVelocity" } }
            );
        }

        public async ValueTask setAngularVelocity(Vector3 velocity)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setAngularVelocity" }, velocity }
            );
        }

        public async ValueTask executeNativeFunction(ActionCallback<object, object> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeNativeFunction" }, func }
            );
        }

        public async ValueTask registerBeforePhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "registerBeforePhysicsStep" }, func }
            );
        }

        public async ValueTask unregisterBeforePhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unregisterBeforePhysicsStep" }, func }
            );
        }

        public async ValueTask registerAfterPhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "registerAfterPhysicsStep" }, func }
            );
        }

        public async ValueTask unregisterAfterPhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unregisterAfterPhysicsStep" }, func }
            );
        }

        public async ValueTask registerOnPhysicsCollide(
            PhysicsImpostor collideAgainst,
            ActionCallback<PhysicsImpostor, PhysicsImpostor, Vector3> func
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "registerOnPhysicsCollide" },
                    collideAgainst,
                    func
                }
            );
        }

        public async ValueTask unregisterOnPhysicsCollide(
            PhysicsImpostor collideAgainst,
            PhysicsImpostor func
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unregisterOnPhysicsCollide" },
                    collideAgainst,
                    func
                }
            );
        }

        public async ValueTask<Quaternion> getParentsRotation()
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getParentsRotation" } }
            );
        }

        public async ValueTask beforeStep()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beforeStep" } }
            );
        }

        public async ValueTask afterStep()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "afterStep" } }
            );
        }

        public async ValueTask onCollide(object e)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onCollide" }, e }
            );
        }

        public async ValueTask<PhysicsImpostor> applyForce(Vector3 force, Vector3 contactPoint)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyForce" }, force, contactPoint }
            );
        }

        public async ValueTask<PhysicsImpostor> applyImpulse(Vector3 force, Vector3 contactPoint)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyImpulse" }, force, contactPoint }
            );
        }

        public async ValueTask<PhysicsImpostor> createJoint(
            PhysicsImpostor otherImpostor,
            decimal jointType,
            PhysicsJointData jointData
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createJoint" },
                    otherImpostor,
                    jointType,
                    jointData
                }
            );
        }

        public async ValueTask<PhysicsImpostor> addJoint(
            PhysicsImpostor otherImpostor,
            PhysicsJoint joint
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addJoint" }, otherImpostor, joint }
            );
        }

        public async ValueTask<PhysicsImpostor> addAnchor(
            PhysicsImpostor otherImpostor,
            decimal width,
            decimal height,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addAnchor" },
                    otherImpostor,
                    width,
                    height,
                    influence,
                    noCollisionBetweenLinkedBodies
                }
            );
        }

        public async ValueTask<PhysicsImpostor> addHook(
            PhysicsImpostor otherImpostor,
            decimal length,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addHook" },
                    otherImpostor,
                    length,
                    influence,
                    noCollisionBetweenLinkedBodies
                }
            );
        }

        public async ValueTask<PhysicsImpostor> sleep()
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "sleep" } }
            );
        }

        public async ValueTask<PhysicsImpostor> wakeUp()
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "wakeUp" } }
            );
        }

        public async ValueTask<PhysicsImpostor> clone(IPhysicsEnabledObject newObject)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, newObject }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask setDeltaPosition(Vector3 position)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDeltaPosition" }, position }
            );
        }

        public async ValueTask setDeltaRotation(Quaternion rotation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDeltaRotation" }, rotation }
            );
        }

        public async ValueTask<PhysicsImpostor> getBoxSizeToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoxSizeToRef" }, result }
            );
        }

        public async ValueTask<decimal> getRadius()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRadius" } }
            );
        }

        public async ValueTask syncBoneWithImpostor(
            Bone bone,
            AbstractMesh boneMesh,
            Vector3 jointPivot,
            System.Nullable<decimal> distToJoint = null,
            Quaternion adjustRotation = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "syncBoneWithImpostor" },
                    bone,
                    boneMesh,
                    jointPivot,
                    distToJoint,
                    adjustRotation
                }
            );
        }

        public async ValueTask syncImpostorWithBone(
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
                    new string[] { this.___guid, "syncImpostorWithBone" },
                    bone,
                    boneMesh,
                    jointPivot,
                    distToJoint,
                    adjustRotation,
                    boneAxis
                }
            );
        }
        #endregion
    }
}
