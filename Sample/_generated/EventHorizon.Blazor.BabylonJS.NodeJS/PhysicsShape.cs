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

        public int type
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "type"); }
        }

        public decimal filterMembershipMask
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "filterMembershipMask");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "filterMembershipMask", value);
            }
        }

        public decimal filterCollideMask
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "filterCollideMask");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "filterCollideMask", value);
            }
        }

        private PhysicsMaterialCachedEntity __material;
        public PhysicsMaterialCachedEntity material
        {
            get
            {
                if (__material == null)
                {
                    __material = EventHorizonBlazorInterop.GetClass<PhysicsMaterialCachedEntity>(
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
            set
            {
                __material = null;
                EventHorizonBlazorInterop.Set(this.___guid, "material", value);
            }
        }

        public decimal density
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "density"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "density", value);
            }
        }

        public bool isTrigger
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTrigger"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isTrigger", value);
            }
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

        public PhysicsShape(PhysicShapeOptions options, Scene scene)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsShape" },
                options,
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void addChildFromParent(
            TransformNode parentTransform,
            PhysicsShape newChild,
            TransformNode childTransform
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addChildFromParent" },
                    parentTransform,
                    newChild,
                    childTransform
                }
            );
        }

        public void addChild(
            PhysicsShape newChild,
            Vector3 translation = null,
            Quaternion rotation = null,
            Vector3 scale = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void removeChild(decimal childIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeChild" }, childIndex }
            );
        }

        public decimal getNumChildren()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getNumChildren" } }
            );
        }

        public BoundingBox getBoundingBox()
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingBox>(
                entity => new BoundingBox() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingBox" } }
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
