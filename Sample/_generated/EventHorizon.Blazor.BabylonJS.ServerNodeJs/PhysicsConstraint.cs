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

        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "type");
        }

        private PhysicsConstraintParametersCachedEntity __options;

        public async ValueTask<PhysicsConstraintParametersCachedEntity> get_options()
        {
            if (__options == null)
            {
                __options =
                    await EventHorizonBlazorInterop.GetClass<PhysicsConstraintParametersCachedEntity>(
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

        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled");
        }

        public ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
        }

        public async ValueTask<bool> get_isCollisionsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCollisionsEnabled");
        }

        public ValueTask set_isCollisionsEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isCollisionsEnabled", value);
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

        public static async ValueTask<PhysicsConstraint> NewPhysicsConstraint(
            int type,
            PhysicsConstraintParameters options,
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsConstraint" },
                type,
                options,
                scene
            );

            return new PhysicsConstraint(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<CachedEntity[]> getBodiesUsingConstraint()
        {
            return await EventHorizonBlazorInterop.FuncArray<CachedEntity>(
                new object[] { new string[] { this.___guid, "getBodiesUsingConstraint" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
