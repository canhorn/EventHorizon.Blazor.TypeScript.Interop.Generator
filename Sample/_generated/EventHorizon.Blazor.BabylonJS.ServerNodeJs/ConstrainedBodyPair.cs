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

    [JsonConverter(typeof(CachedEntityConverter<ConstrainedBodyPair>))]
    public class ConstrainedBodyPair : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static PhysicsBody __parentBody;

        public static async ValueTask<PhysicsBody> get_parentBody()
        {
            if (__parentBody == null)
            {
                __parentBody = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                    "BABYLON",
                    "ConstrainedBodyPair.parentBody",
                    (entity) =>
                    {
                        return new PhysicsBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __parentBody;
        }

        public static ValueTask set_parentBody(PhysicsBody value)
        {
            __parentBody = null;
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "ConstrainedBodyPair.parentBody",
                value
            );
        }

        private static PhysicsBody __childBody;

        public static async ValueTask<PhysicsBody> get_childBody()
        {
            if (__childBody == null)
            {
                __childBody = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                    "BABYLON",
                    "ConstrainedBodyPair.childBody",
                    (entity) =>
                    {
                        return new PhysicsBody() { ___guid = entity.___guid };
                    }
                );
            }
            return __childBody;
        }

        public static ValueTask set_childBody(PhysicsBody value)
        {
            __childBody = null;
            return EventHorizonBlazorInterop.Set("BABYLON", "ConstrainedBodyPair.childBody", value);
        }

        public static async ValueTask<decimal> get_parentBodyIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "ConstrainedBodyPair.parentBodyIndex"
            );
        }

        public static ValueTask set_parentBodyIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "ConstrainedBodyPair.parentBodyIndex",
                value
            );
        }

        public static async ValueTask<decimal> get_childBodyIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "ConstrainedBodyPair.childBodyIndex"
            );
        }

        public static ValueTask set_childBodyIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "ConstrainedBodyPair.childBodyIndex",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public ConstrainedBodyPair()
            : base() { }

        public ConstrainedBodyPair(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
