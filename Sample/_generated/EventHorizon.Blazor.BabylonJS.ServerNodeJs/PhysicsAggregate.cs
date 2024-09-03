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

        public async ValueTask<TransformNode> get_transformNode()
        {
            if (__transformNode == null)
            {
                __transformNode = await EventHorizonBlazorInterop.GetClass<TransformNode>(
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

        public ValueTask set_transformNode(TransformNode value)
        {
            __transformNode = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "transformNode", value);
        }

        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "type");
        }

        public ValueTask set_type(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }

        private PhysicsBody __body;

        public async ValueTask<PhysicsBody> get_body()
        {
            if (__body == null)
            {
                __body = await EventHorizonBlazorInterop.GetClass<PhysicsBody>(
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

        public ValueTask set_body(PhysicsBody value)
        {
            __body = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "body", value);
        }

        private PhysicsShape __shape;

        public async ValueTask<PhysicsShape> get_shape()
        {
            if (__shape == null)
            {
                __shape = await EventHorizonBlazorInterop.GetClass<PhysicsShape>(
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

        public ValueTask set_shape(PhysicsShape value)
        {
            __shape = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "shape", value);
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
        #endregion

        #region Constructor
        public PhysicsAggregate()
            : base() { }

        public PhysicsAggregate(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PhysicsAggregate> NewPhysicsAggregate(
            TransformNode transformNode,
            int type,
            PhysicsAggregateParameters _options = null,
            Scene _scene = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PhysicsAggregate" },
                transformNode,
                type,
                _options,
                _scene
            );

            return new PhysicsAggregate(entity);
        }
        #endregion

        #region Methods
        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
