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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsImpostor>))]
    public class PhysicsImpostor : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Vector3 __DEFAULT_OBJECT_SIZE;
        public static Vector3 DEFAULT_OBJECT_SIZE
        {
            get
            {
                if (__DEFAULT_OBJECT_SIZE == null)
                {
                    __DEFAULT_OBJECT_SIZE = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
                __DEFAULT_OBJECT_SIZE = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PhysicsImpostor.DEFAULT_OBJECT_SIZE",
                    value
                );
            }
        }

        private static Quaternion __IDENTITY_QUATERNION;
        public static Quaternion IDENTITY_QUATERNION
        {
            get
            {
                if (__IDENTITY_QUATERNION == null)
                {
                    __IDENTITY_QUATERNION = EventHorizonBlazorInterop.GetClass<Quaternion>(
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
            set
            {
                __IDENTITY_QUATERNION = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PhysicsImpostor.IDENTITY_QUATERNION",
                    value
                );
            }
        }

        public static decimal NoImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.NoImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.NoImpostor", value);
            }
        }

        public static decimal SphereImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.SphereImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.SphereImpostor", value);
            }
        }

        public static decimal BoxImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.BoxImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.BoxImpostor", value);
            }
        }

        public static decimal PlaneImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.PlaneImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.PlaneImpostor", value);
            }
        }

        public static decimal MeshImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.MeshImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.MeshImpostor", value);
            }
        }

        public static decimal CapsuleImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.CapsuleImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.CapsuleImpostor", value);
            }
        }

        public static decimal CylinderImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.CylinderImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.CylinderImpostor", value);
            }
        }

        public static decimal ParticleImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.ParticleImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.ParticleImpostor", value);
            }
        }

        public static decimal HeightmapImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.HeightmapImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PhysicsImpostor.HeightmapImpostor",
                    value
                );
            }
        }

        public static decimal ConvexHullImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.ConvexHullImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PhysicsImpostor.ConvexHullImpostor",
                    value
                );
            }
        }

        public static decimal CustomImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.CustomImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.CustomImpostor", value);
            }
        }

        public static decimal RopeImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.RopeImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.RopeImpostor", value);
            }
        }

        public static decimal ClothImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.ClothImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.ClothImpostor", value);
            }
        }

        public static decimal SoftbodyImpostor
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsImpostor.SoftbodyImpostor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsImpostor.SoftbodyImpostor", value);
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool isDisposed
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDisposed"); }
        }

        public decimal mass
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mass"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mass", value);
            }
        }

        public decimal friction
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "friction"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "friction", value);
            }
        }

        public decimal restitution
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "restitution"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "restitution", value);
            }
        }

        public decimal pressure
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pressure"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pressure", value);
            }
        }

        public decimal stiffness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stiffness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stiffness", value);
            }
        }

        public decimal velocityIterations
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "velocityIterations");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "velocityIterations", value);
            }
        }

        public decimal positionIterations
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "positionIterations");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "positionIterations", value);
            }
        }

        public CachedEntity physicsBody
        {
            get { return EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "physicsBody"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "physicsBody", value);
            }
        }

        private PhysicsImpostor __parent;
        public PhysicsImpostor parent
        {
            get
            {
                if (__parent == null)
                {
                    __parent = EventHorizonBlazorInterop.GetClass<PhysicsImpostor>(
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
            set
            {
                __parent = null;
                EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
            }
        }
        #endregion

        #region Properties
        private IPhysicsEnabledObjectCachedEntity __object;
        public IPhysicsEnabledObjectCachedEntity @object
        {
            get
            {
                if (__object == null)
                {
                    __object =
                        EventHorizonBlazorInterop.GetClass<IPhysicsEnabledObjectCachedEntity>(
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
            set
            {
                __object = null;
                EventHorizonBlazorInterop.Set(this.___guid, "object", value);
            }
        }

        public decimal type
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        public decimal uniqueId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
            }
        }

        public bool soft
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "soft"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "soft", value);
            }
        }

        public decimal segments
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "segments"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "segments", value);
            }
        }

        public ActionCallback<PhysicsImpostor, PhysicsImpostor> onCollideEvent
        {
            get
            {
                return EventHorizonBlazorInterop.Get<
                    ActionCallback<PhysicsImpostor, PhysicsImpostor>
                >(this.___guid, "onCollideEvent");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "onCollideEvent", value);
            }
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

        public PhysicsImpostor(
            IPhysicsEnabledObject @object,
            decimal type,
            PhysicsImpostorParameters _options = null,
            Scene _scene = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsImpostor" },
                @object,
                type,
                _options,
                _scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isBodyInitRequired()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isBodyInitRequired" } }
            );
        }

        public void setScalingUpdated()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setScalingUpdated" } }
            );
        }

        public void forceUpdate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "forceUpdate" } }
            );
        }

        public void resetUpdateFlags()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetUpdateFlags" } }
            );
        }

        public Vector3 getObjectExtents()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getObjectExtents" } }
            );
        }

        public Vector3 getObjectCenter()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getObjectCenter" } }
            );
        }

        public CachedEntity getParam(string paramName)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getParam" }, paramName }
            );
        }

        public void setParam(string paramName, decimal value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setParam" }, paramName, value }
            );
        }

        public void setMass(decimal mass)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setMass" }, mass }
            );
        }

        public Vector3 getLinearVelocity()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLinearVelocity" } }
            );
        }

        public void setLinearVelocity(Vector3 velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setLinearVelocity" }, velocity }
            );
        }

        public Vector3 getAngularVelocity()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAngularVelocity" } }
            );
        }

        public void setAngularVelocity(Vector3 velocity)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setAngularVelocity" }, velocity }
            );
        }

        public void executeNativeFunction(ActionCallback<object, object> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeNativeFunction" }, func }
            );
        }

        public void registerBeforePhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "registerBeforePhysicsStep" }, func }
            );
        }

        public void unregisterBeforePhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unregisterBeforePhysicsStep" }, func }
            );
        }

        public void registerAfterPhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "registerAfterPhysicsStep" }, func }
            );
        }

        public void unregisterAfterPhysicsStep(ActionCallback<PhysicsImpostor> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unregisterAfterPhysicsStep" }, func }
            );
        }

        public void registerOnPhysicsCollide(
            PhysicsImpostor collideAgainst,
            ActionCallback<PhysicsImpostor, PhysicsImpostor, Vector3> func
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "registerOnPhysicsCollide" },
                    collideAgainst,
                    func
                }
            );
        }

        public void unregisterOnPhysicsCollide(PhysicsImpostor collideAgainst, PhysicsImpostor func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unregisterOnPhysicsCollide" },
                    collideAgainst,
                    func
                }
            );
        }

        public Quaternion getParentsRotation()
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getParentsRotation" } }
            );
        }

        public void beforeStep()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beforeStep" } }
            );
        }

        public void afterStep()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "afterStep" } }
            );
        }

        public void onCollide(object e)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onCollide" }, e }
            );
        }

        public PhysicsImpostor applyForce(Vector3 force, Vector3 contactPoint)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyForce" }, force, contactPoint }
            );
        }

        public PhysicsImpostor applyImpulse(Vector3 force, Vector3 contactPoint)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "applyImpulse" }, force, contactPoint }
            );
        }

        public PhysicsImpostor createJoint(
            PhysicsImpostor otherImpostor,
            decimal jointType,
            PhysicsJointData jointData
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
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

        public PhysicsImpostor addJoint(PhysicsImpostor otherImpostor, PhysicsJoint joint)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addJoint" }, otherImpostor, joint }
            );
        }

        public PhysicsImpostor addAnchor(
            PhysicsImpostor otherImpostor,
            decimal width,
            decimal height,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
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

        public PhysicsImpostor addHook(
            PhysicsImpostor otherImpostor,
            decimal length,
            decimal influence,
            bool noCollisionBetweenLinkedBodies
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
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

        public PhysicsImpostor sleep()
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "sleep" } }
            );
        }

        public PhysicsImpostor wakeUp()
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "wakeUp" } }
            );
        }

        public PhysicsImpostor clone(IPhysicsEnabledObject newObject)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, newObject }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public void setDeltaPosition(Vector3 position)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDeltaPosition" }, position }
            );
        }

        public void setDeltaRotation(Quaternion rotation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setDeltaRotation" }, rotation }
            );
        }

        public PhysicsImpostor getBoxSizeToRef(Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<PhysicsImpostor>(
                entity => new PhysicsImpostor() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoxSizeToRef" }, result }
            );
        }

        public decimal getRadius()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getRadius" } }
            );
        }

        public void syncBoneWithImpostor(
            Bone bone,
            AbstractMesh boneMesh,
            Vector3 jointPivot,
            System.Nullable<decimal> distToJoint = null,
            Quaternion adjustRotation = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void syncImpostorWithBone(
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
