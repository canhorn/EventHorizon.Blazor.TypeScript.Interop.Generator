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

    [JsonConverter(typeof(CachedEntityConverter<InputManager>))]
    public class InputManager : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal DragMovementThreshold
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "InputManager.DragMovementThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "InputManager.DragMovementThreshold",
                    value
                );
            }
        }

        public static decimal LongPressDelay
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "InputManager.LongPressDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "InputManager.LongPressDelay", value);
            }
        }

        public static decimal DoubleClickDelay
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "InputManager.DoubleClickDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "InputManager.DoubleClickDelay", value);
            }
        }

        public static bool ExclusiveDoubleClickMode
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "InputManager.ExclusiveDoubleClickMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "InputManager.ExclusiveDoubleClickMode",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
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
        }

        private Vector2 __unTranslatedPointer;
        public Vector2 unTranslatedPointer
        {
            get
            {
                if (__unTranslatedPointer == null)
                {
                    __unTranslatedPointer = EventHorizonBlazorInterop.GetClass<Vector2>(
                        this.___guid,
                        "unTranslatedPointer",
                        (entity) =>
                        {
                            return new Vector2() { ___guid = entity.___guid };
                        }
                    );
                }
                return __unTranslatedPointer;
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
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public InputManager()
            : base() { }

        public InputManager(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InputManager(Scene scene = null)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InputManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public AbstractMesh getMeshUnderPointerByPointerId(decimal pointerId)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshUnderPointerByPointerId" },
                    pointerId
                }
            );
        }

        public void simulatePointerMove(
            PickingInfo pickResult,
            PointerEventInit pointerEventInit = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerMove" },
                    pickResult,
                    pointerEventInit
                }
            );
        }

        public void simulatePointerDown(
            PickingInfo pickResult,
            PointerEventInit pointerEventInit = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerDown" },
                    pickResult,
                    pointerEventInit
                }
            );
        }

        public void simulatePointerUp(
            PickingInfo pickResult,
            PointerEventInit pointerEventInit = null,
            System.Nullable<bool> doubleTap = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerUp" },
                    pickResult,
                    pointerEventInit,
                    doubleTap
                }
            );
        }

        public bool isPointerCaptured(System.Nullable<decimal> pointerId = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isPointerCaptured" }, pointerId }
            );
        }

        public void attachControl(
            System.Nullable<bool> attachUp = null,
            System.Nullable<bool> attachDown = null,
            System.Nullable<bool> attachMove = null,
            CachedEntity elementToAttachTo = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachControl" },
                    attachUp,
                    attachDown,
                    attachMove,
                    elementToAttachTo
                }
            );
        }

        public void detachControl()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "detachControl" } }
            );
        }

        public void setPointerOverMesh(
            AbstractMesh mesh,
            System.Nullable<decimal> pointerId = null,
            PickingInfo pickResult = null,
            IPointerEvent evt = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPointerOverMesh" },
                    mesh,
                    pointerId,
                    pickResult,
                    evt
                }
            );
        }

        public AbstractMesh getPointerOverMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getPointerOverMesh" } }
            );
        }
        #endregion
    }
}
