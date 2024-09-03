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

    [JsonConverter(typeof(CachedEntityConverter<ActionEvent>))]
    public class ActionEvent : CachedEntityObject, IActionEvent
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<ActionEvent> CreateNew(
            AbstractMesh source,
            object evt = null,
            object additionalData = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ActionEvent>(
                entity => new ActionEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ActionEvent", "CreateNew" },
                    source,
                    evt,
                    additionalData
                }
            );
        }

        public static async ValueTask<ActionEvent> CreateNewFromSprite(
            Sprite source,
            Scene scene,
            object evt = null,
            object additionalData = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ActionEvent>(
                entity => new ActionEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ActionEvent", "CreateNewFromSprite" },
                    source,
                    scene,
                    evt,
                    additionalData
                }
            );
        }

        public static async ValueTask<ActionEvent> CreateNewFromScene(Scene scene, object evt)
        {
            return await EventHorizonBlazorInterop.FuncClass<ActionEvent>(
                entity => new ActionEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ActionEvent", "CreateNewFromScene" },
                    scene,
                    evt
                }
            );
        }

        public static async ValueTask<ActionEvent> CreateNewFromPrimitive(
            object prim,
            Vector2 pointerPos,
            Event evt = null,
            object additionalData = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ActionEvent>(
                entity => new ActionEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ActionEvent", "CreateNewFromPrimitive" },
                    prim,
                    pointerPos,
                    evt,
                    additionalData
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<CachedEntity> get_source()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "source",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_source(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "source", value);
        }

        public async ValueTask<decimal> get_pointerX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pointerX");
        }

        public ValueTask set_pointerX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pointerX", value);
        }

        public async ValueTask<decimal> get_pointerY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pointerY");
        }

        public ValueTask set_pointerY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "pointerY", value);
        }

        private AbstractMesh __meshUnderPointer;

        public async ValueTask<AbstractMesh> get_meshUnderPointer()
        {
            if (__meshUnderPointer == null)
            {
                __meshUnderPointer = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "meshUnderPointer",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __meshUnderPointer;
        }

        public ValueTask set_meshUnderPointer(AbstractMesh value)
        {
            __meshUnderPointer = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "meshUnderPointer", value);
        }

        public async ValueTask<CachedEntity> get_sourceEvent()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "sourceEvent",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_sourceEvent(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "sourceEvent", value);
        }

        public async ValueTask<CachedEntity> get_additionalData()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "additionalData",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_additionalData(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "additionalData", value);
        }
        #endregion

        #region Constructor
        public ActionEvent()
            : base() { }

        public ActionEvent(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<ActionEvent> NewActionEvent(
            object source,
            decimal pointerX,
            decimal pointerY,
            AbstractMesh meshUnderPointer,
            object sourceEvent = null,
            object additionalData = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ActionEvent" },
                source,
                pointerX,
                pointerY,
                meshUnderPointer,
                sourceEvent,
                additionalData
            );

            return new ActionEvent(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}
