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

        public async ValueTask<PhysicsImpostor> get_mainImpostor()
        {
            if (__mainImpostor == null)
            {
                __mainImpostor = await EventHorizonBlazorInterop.GetClass<PhysicsImpostor>(
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

        public ValueTask set_mainImpostor(PhysicsImpostor value)
        {
            __mainImpostor = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "mainImpostor", value);
        }

        private PhysicsImpostor __connectedImpostor;

        public async ValueTask<PhysicsImpostor> get_connectedImpostor()
        {
            if (__connectedImpostor == null)
            {
                __connectedImpostor = await EventHorizonBlazorInterop.GetClass<PhysicsImpostor>(
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

        public ValueTask set_connectedImpostor(PhysicsImpostor value)
        {
            __connectedImpostor = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "connectedImpostor", value);
        }

        private PhysicsJoint __joint;

        public async ValueTask<PhysicsJoint> get_joint()
        {
            if (__joint == null)
            {
                __joint = await EventHorizonBlazorInterop.GetClass<PhysicsJoint>(
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

        public ValueTask set_joint(PhysicsJoint value)
        {
            __joint = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "joint", value);
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
