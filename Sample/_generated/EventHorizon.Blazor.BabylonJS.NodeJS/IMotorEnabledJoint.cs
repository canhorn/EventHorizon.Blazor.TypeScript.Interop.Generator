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

    public interface IMotorEnabledJoint : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMotorEnabledJointCachedEntity>))]
    public class IMotorEnabledJointCachedEntity : CachedEntityObject, IMotorEnabledJoint
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

        public CachedEntity physicsJoint
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "physicsJoint",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "physicsJoint", value);
            }
        }
        #endregion

        #region Constructor
        public IMotorEnabledJointCachedEntity()
            : base() { }

        public IMotorEnabledJointCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void setMotor(
            System.Nullable<decimal> force = null,
            System.Nullable<decimal> maxForce = null,
            System.Nullable<decimal> motorIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMotor" },
                    force,
                    maxForce,
                    motorIndex
                }
            );
        }

        public void setLimit(
            decimal upperLimit,
            System.Nullable<decimal> lowerLimit = null,
            System.Nullable<decimal> motorIndex = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setLimit" },
                    upperLimit,
                    lowerLimit,
                    motorIndex
                }
            );
        }
        #endregion
    }
}
