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

    [JsonConverter(typeof(CachedEntityConverter<ConstrainedBodyPair>))]
    public class ConstrainedBodyPair : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static PhysicsBody __parentBody;
        public static PhysicsBody parentBody
        {
            get
            {
                if (__parentBody == null)
                {
                    __parentBody = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
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
            set
            {
                __parentBody = null;
                EventHorizonBlazorInterop.Set("BABYLON", "ConstrainedBodyPair.parentBody", value);
            }
        }

        private static PhysicsBody __childBody;
        public static PhysicsBody childBody
        {
            get
            {
                if (__childBody == null)
                {
                    __childBody = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
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
            set
            {
                __childBody = null;
                EventHorizonBlazorInterop.Set("BABYLON", "ConstrainedBodyPair.childBody", value);
            }
        }

        public static decimal parentBodyIndex
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ConstrainedBodyPair.parentBodyIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ConstrainedBodyPair.parentBodyIndex",
                    value
                );
            }
        }

        public static decimal childBodyIndex
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ConstrainedBodyPair.childBodyIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ConstrainedBodyPair.childBodyIndex",
                    value
                );
            }
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
