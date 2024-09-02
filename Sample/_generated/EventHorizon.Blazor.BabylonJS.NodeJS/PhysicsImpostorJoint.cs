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

    public interface PhysicsImpostorJoint : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PhysicsImpostorJointCachedEntity>))]
    public class PhysicsImpostorJointCachedEntity : CachedEntityObject, PhysicsImpostorJoint
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
        private PhysicsImpostor __mainImpostor;
        public PhysicsImpostor mainImpostor
        {
            get
            {
                if (__mainImpostor == null)
                {
                    __mainImpostor = EventHorizonBlazorInterop.GetClass<PhysicsImpostor>(
                        this.___guid,
                        "mainImpostor",
                        (entity) =>
                        {
                            return new PhysicsImpostor() { ___guid = entity.___guid };
                        }
                    );
                }
                return __mainImpostor;
            }
            set
            {
                __mainImpostor = null;
                EventHorizonBlazorInterop.Set(this.___guid, "mainImpostor", value);
            }
        }

        private PhysicsImpostor __connectedImpostor;
        public PhysicsImpostor connectedImpostor
        {
            get
            {
                if (__connectedImpostor == null)
                {
                    __connectedImpostor = EventHorizonBlazorInterop.GetClass<PhysicsImpostor>(
                        this.___guid,
                        "connectedImpostor",
                        (entity) =>
                        {
                            return new PhysicsImpostor() { ___guid = entity.___guid };
                        }
                    );
                }
                return __connectedImpostor;
            }
            set
            {
                __connectedImpostor = null;
                EventHorizonBlazorInterop.Set(this.___guid, "connectedImpostor", value);
            }
        }

        private PhysicsJoint __joint;
        public PhysicsJoint joint
        {
            get
            {
                if (__joint == null)
                {
                    __joint = EventHorizonBlazorInterop.GetClass<PhysicsJoint>(
                        this.___guid,
                        "joint",
                        (entity) =>
                        {
                            return new PhysicsJoint() { ___guid = entity.___guid };
                        }
                    );
                }
                return __joint;
            }
            set
            {
                __joint = null;
                EventHorizonBlazorInterop.Set(this.___guid, "joint", value);
            }
        }
        #endregion

        #region Constructor
        public PhysicsImpostorJointCachedEntity()
            : base() { }

        public PhysicsImpostorJointCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
