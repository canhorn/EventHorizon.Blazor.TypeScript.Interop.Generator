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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsJoint>))]
    public class PhysicsJoint : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal DistanceJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.DistanceJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.DistanceJoint", value);
            }
        }

        public static decimal HingeJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "PhysicsJoint.HingeJoint");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.HingeJoint", value);
            }
        }

        public static decimal BallAndSocketJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.BallAndSocketJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.BallAndSocketJoint", value);
            }
        }

        public static decimal WheelJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "PhysicsJoint.WheelJoint");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.WheelJoint", value);
            }
        }

        public static decimal SliderJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.SliderJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.SliderJoint", value);
            }
        }

        public static decimal PrismaticJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.PrismaticJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.PrismaticJoint", value);
            }
        }

        public static decimal UniversalJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.UniversalJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.UniversalJoint", value);
            }
        }

        public static decimal Hinge2Joint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.Hinge2Joint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.Hinge2Joint", value);
            }
        }

        public static decimal PointToPointJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.PointToPointJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.PointToPointJoint", value);
            }
        }

        public static decimal SpringJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PhysicsJoint.SpringJoint"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.SpringJoint", value);
            }
        }

        public static decimal LockJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "PhysicsJoint.LockJoint");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PhysicsJoint.LockJoint", value);
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public CachedEntity physicsJoint
        {
            get
            {
                return EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "physicsJoint");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "physicsJoint", value);
            }
        }
        #endregion

        #region Properties

        public decimal type
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        private PhysicsJointDataCachedEntity __jointData;
        public PhysicsJointDataCachedEntity jointData
        {
            get
            {
                if (__jointData == null)
                {
                    __jointData = EventHorizonBlazorInterop.GetClass<PhysicsJointDataCachedEntity>(
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
            set
            {
                __jointData = null;
                EventHorizonBlazorInterop.Set(this.___guid, "jointData", value);
            }
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

        public PhysicsJoint(decimal type, PhysicsJointData jointData)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsJoint" },
                type,
                jointData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void executeNativeFunction(ActionCallback<object, object> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "executeNativeFunction" }, func }
            );
        }
        #endregion
    }
}
