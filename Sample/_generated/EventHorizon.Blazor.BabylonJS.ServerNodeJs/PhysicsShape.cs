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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsShape>))]
    public class PhysicsShape : CachedEntityObject
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

        public async ValueTask<decimal> get_filterMembershipMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "filterMembershipMask"
            );
        }

        public ValueTask set_filterMembershipMask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "filterMembershipMask", value);
        }

        public async ValueTask<decimal> get_filterCollideMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "filterCollideMask");
        }

        public ValueTask set_filterCollideMask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "filterCollideMask", value);
        }

        private PhysicsMaterialCachedEntity __material;

        public async ValueTask<PhysicsMaterialCachedEntity> get_material()
        {
            if (__material == null)
            {
                __material = await EventHorizonBlazorInterop.GetClass<PhysicsMaterialCachedEntity>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new PhysicsMaterialCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
        }

        public ValueTask set_material(PhysicsMaterialCachedEntity value)
        {
            __material = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "material", value);
        }

        public async ValueTask<decimal> get_density()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "density");
        }

        public ValueTask set_density(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "density", value);
        }

        public async ValueTask<bool> get_isTrigger()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTrigger");
        }

        public ValueTask set_isTrigger(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isTrigger", value);
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PhysicsShape()
            : base() { }

        public PhysicsShape(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PhysicsShape> NewPhysicsShape(
            PhysicShapeOptions options,
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsShape" },
                options,
                scene
            );

            return new PhysicsShape(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask addChildFromParent(
            TransformNode parentTransform,
            PhysicsShape newChild,
            TransformNode childTransform
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addChildFromParent" },
                    parentTransform,
                    newChild,
                    childTransform
                }
            );
        }

        public async ValueTask addChild(
            PhysicsShape newChild,
            Vector3 translation = null,
            Quaternion rotation = null,
            Vector3 scale = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addChild" },
                    newChild,
                    translation,
                    rotation,
                    scale
                }
            );
        }

        public async ValueTask removeChild(decimal childIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeChild" }, childIndex }
            );
        }

        public async ValueTask<decimal> getNumChildren()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getNumChildren" } }
            );
        }

        public async ValueTask<BoundingBox> getBoundingBox()
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingBox" } }
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
