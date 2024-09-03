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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsConstraint>))]
    public class PhysicsConstraint : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public int type
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "type"); }
        }

        private PhysicsConstraintParametersCachedEntity __options;
        public PhysicsConstraintParametersCachedEntity options
        {
            get
            {
                if (__options == null)
                {
                    __options =
                        EventHorizonBlazorInterop.GetClass<PhysicsConstraintParametersCachedEntity>(
                            this.___guid,
                            "options",
                            (entity) =>
                            {
                                return new PhysicsConstraintParametersCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __options;
            }
        }

        public bool isEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
            }
        }

        public bool isCollisionsEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCollisionsEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isCollisionsEnabled", value);
            }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PhysicsConstraint()
            : base() { }

        public PhysicsConstraint(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PhysicsConstraint(int type, PhysicsConstraintParameters options, Scene scene)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsConstraint" },
                type,
                options,
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CachedEntity[] getBodiesUsingConstraint()
        {
            return EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[] { new string[] { this.___guid, "getBodiesUsingConstraint" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
