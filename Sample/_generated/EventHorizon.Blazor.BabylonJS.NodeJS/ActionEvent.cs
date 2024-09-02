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

    [JsonConverter(typeof(CachedEntityConverter<ActionEvent>))]
    public class ActionEvent : CachedEntityObject, IActionEvent
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static ActionEvent CreateNew(
            AbstractMesh source,
            object evt = null,
            object additionalData = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ActionEvent>(
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

        public static ActionEvent CreateNewFromSprite(
            Sprite source,
            Scene scene,
            object evt = null,
            object additionalData = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ActionEvent>(
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

        public static ActionEvent CreateNewFromScene(Scene scene, object evt)
        {
            return EventHorizonBlazorInterop.FuncClass<ActionEvent>(
                entity => new ActionEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ActionEvent", "CreateNewFromScene" },
                    scene,
                    evt
                }
            );
        }

        public static ActionEvent CreateNewFromPrimitive(
            object prim,
            Vector2 pointerPos,
            Event evt = null,
            object additionalData = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ActionEvent>(
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

        public CachedEntity source
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "source", value);
            }
        }

        public decimal pointerX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pointerX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pointerX", value);
            }
        }

        public decimal pointerY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "pointerY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "pointerY", value);
            }
        }

        private AbstractMesh __meshUnderPointer;
        public AbstractMesh meshUnderPointer
        {
            get
            {
                if (__meshUnderPointer == null)
                {
                    __meshUnderPointer = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
            set
            {
                __meshUnderPointer = null;
                EventHorizonBlazorInterop.Set(this.___guid, "meshUnderPointer", value);
            }
        }

        public CachedEntity sourceEvent
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "sourceEvent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sourceEvent", value);
            }
        }

        public CachedEntity additionalData
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "additionalData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "additionalData", value);
            }
        }
        #endregion

        #region Constructor
        public ActionEvent()
            : base() { }

        public ActionEvent(ICachedEntity entity)
            : base(entity) { }

        public ActionEvent(
            object source,
            decimal pointerX,
            decimal pointerY,
            AbstractMesh meshUnderPointer,
            object sourceEvent = null,
            object additionalData = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ActionEvent" },
                source,
                pointerX,
                pointerY,
                meshUnderPointer,
                sourceEvent,
                additionalData
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
