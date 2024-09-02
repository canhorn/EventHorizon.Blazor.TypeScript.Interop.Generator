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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsJoint>))]
    public class PhysicsJoint : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_DistanceJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.DistanceJoint"
            );
        }

        public static ValueTask set_DistanceJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.DistanceJoint", value);
        }

        public static async ValueTask<decimal> get_HingeJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.HingeJoint"
            );
        }

        public static ValueTask set_HingeJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.HingeJoint", value);
        }

        public static async ValueTask<decimal> get_BallAndSocketJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.BallAndSocketJoint"
            );
        }

        public static ValueTask set_BallAndSocketJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsJoint.BallAndSocketJoint",
                value
            );
        }

        public static async ValueTask<decimal> get_WheelJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.WheelJoint"
            );
        }

        public static ValueTask set_WheelJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.WheelJoint", value);
        }

        public static async ValueTask<decimal> get_SliderJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.SliderJoint"
            );
        }

        public static ValueTask set_SliderJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.SliderJoint", value);
        }

        public static async ValueTask<decimal> get_PrismaticJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.PrismaticJoint"
            );
        }

        public static ValueTask set_PrismaticJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.PrismaticJoint", value);
        }

        public static async ValueTask<decimal> get_UniversalJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.UniversalJoint"
            );
        }

        public static ValueTask set_UniversalJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.UniversalJoint", value);
        }

        public static async ValueTask<decimal> get_Hinge2Joint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.Hinge2Joint"
            );
        }

        public static ValueTask set_Hinge2Joint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.Hinge2Joint", value);
        }

        public static async ValueTask<decimal> get_PointToPointJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.PointToPointJoint"
            );
        }

        public static ValueTask set_PointToPointJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PhysicsJoint.PointToPointJoint",
                value
            );
        }

        public static async ValueTask<decimal> get_SpringJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.SpringJoint"
            );
        }

        public static ValueTask set_SpringJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.SpringJoint", value);
        }

        public static async ValueTask<decimal> get_LockJoint()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PhysicsJoint.LockJoint"
            );
        }

        public static ValueTask set_LockJoint(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.LockJoint", value);
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<CachedEntity> get_physicsJoint()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "physicsJoint");
        }

        public ValueTask set_physicsJoint(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "physicsJoint", value);
        }
        #endregion

        #region Properties

        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type");
        }

        public ValueTask set_type(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }

        private PhysicsJointDataCachedEntity __jointData;

        public async ValueTask<PhysicsJointDataCachedEntity> get_jointData()
        {
            if (__jointData == null)
            {
                __jointData =
                    await EventHorizonBlazorInterop.GetClass<PhysicsJointDataCachedEntity>(
                        this.___guid,
                        "jointData",
                        (entity) =>
                        {
                            return new PhysicsJointDataCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __jointData;
        }

        public ValueTask set_jointData(PhysicsJointDataCachedEntity value)
        {
            __jointData = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "jointData", value);
        }
        #endregion

        #region Constructor
        public PhysicsJoint()
            : base() { }

        public PhysicsJoint(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PhysicsJoint> NewPhysicsJoint(
            decimal type,
            PhysicsJointData jointData
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsJoint" },
                type,
                jointData
            );

            return new PhysicsJoint(entity);
        }
        #endregion

        #region Methods
        public async ValueTask executeNativeFunction(ActionCallback<object, object> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeNativeFunction" }, func }
            );
        }
        #endregion
    }
}
