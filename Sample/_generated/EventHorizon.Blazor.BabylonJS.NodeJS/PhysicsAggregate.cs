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

    [JsonConverter(typeof(CachedEntityConverter<PhysicsAggregate>))]
    public class PhysicsAggregate : CachedEntityObject
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
        private TransformNode __transformNode;
        public TransformNode transformNode
        {
            get
            {
                if (__transformNode == null)
                {
                    __transformNode = EventHorizonBlazorInterop.GetClass<TransformNode>(
                        this.___guid,
                        "transformNode",
                        (entity) =>
                        {
                            return new TransformNode() { ___guid = entity.___guid };
                        }
                    );
                }
                return __transformNode;
            }
            set
            {
                __transformNode = null;
                EventHorizonBlazorInterop.Set(this.___guid, "transformNode", value);
            }
        }

        public int type
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        private PhysicsBody __body;
        public PhysicsBody body
        {
            get
            {
                if (__body == null)
                {
                    __body = EventHorizonBlazorInterop.GetClass<PhysicsBody>(
                        this.___guid,
                        "body",
                        (entity) =>
                        {
                            return new PhysicsBody() { ___guid = entity.___guid };
                        }
                    );
                }
                return __body;
            }
            set
            {
                __body = null;
                EventHorizonBlazorInterop.Set(this.___guid, "body", value);
            }
        }

        private PhysicsShape __shape;
        public PhysicsShape shape
        {
            get
            {
                if (__shape == null)
                {
                    __shape = EventHorizonBlazorInterop.GetClass<PhysicsShape>(
                        this.___guid,
                        "shape",
                        (entity) =>
                        {
                            return new PhysicsShape() { ___guid = entity.___guid };
                        }
                    );
                }
                return __shape;
            }
            set
            {
                __shape = null;
                EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
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
        #endregion

        #region Constructor
        public PhysicsAggregate()
            : base() { }

        public PhysicsAggregate(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public PhysicsAggregate(
            TransformNode transformNode,
            int type,
            PhysicsAggregateParameters _options = null,
            Scene _scene = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsAggregate" },
                transformNode,
                type,
                _options,
                _scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
