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

    [JsonConverter(typeof(CachedEntityConverter<InputManager>))]
    public class InputManager : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_DragMovementThreshold()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "InputManager.DragMovementThreshold"
            );
        }

        public static ValueTask set_DragMovementThreshold(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "InputManager.DragMovementThreshold",
                value
            );
        }

        public static async ValueTask<decimal> get_LongPressDelay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "InputManager.LongPressDelay"
            );
        }

        public static ValueTask set_LongPressDelay(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "InputManager.LongPressDelay", value);
        }

        public static async ValueTask<decimal> get_DoubleClickDelay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "InputManager.DoubleClickDelay"
            );
        }

        public static ValueTask set_DoubleClickDelay(decimal value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "InputManager.DoubleClickDelay", value);
        }

        public static async ValueTask<bool> get_ExclusiveDoubleClickMode()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "InputManager.ExclusiveDoubleClickMode"
            );
        }

        public static ValueTask set_ExclusiveDoubleClickMode(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "InputManager.ExclusiveDoubleClickMode",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
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

        private Vector2 __unTranslatedPointer;

        public async ValueTask<Vector2> get_unTranslatedPointer()
        {
            if (__unTranslatedPointer == null)
            {
                __unTranslatedPointer = await EventHorizonBlazorInterop.GetClass<Vector2>(
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

        public static async ValueTask<InputManager> NewInputManager(Scene scene = null)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InputManager" },
                scene
            );

            return new InputManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<AbstractMesh> getMeshUnderPointerByPointerId(decimal pointerId)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshUnderPointerByPointerId" },
                    pointerId
                }
            );
        }

        public async ValueTask simulatePointerMove(
            PickingInfo pickResult,
            PointerEventInit pointerEventInit = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerMove" },
                    pickResult,
                    pointerEventInit
                }
            );
        }

        public async ValueTask simulatePointerDown(
            PickingInfo pickResult,
            PointerEventInit pointerEventInit = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerDown" },
                    pickResult,
                    pointerEventInit
                }
            );
        }

        public async ValueTask simulatePointerUp(
            PickingInfo pickResult,
            PointerEventInit pointerEventInit = null,
            System.Nullable<bool> doubleTap = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerUp" },
                    pickResult,
                    pointerEventInit,
                    doubleTap
                }
            );
        }

        public async ValueTask<bool> isPointerCaptured(System.Nullable<decimal> pointerId = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isPointerCaptured" }, pointerId }
            );
        }

        public async ValueTask attachControl(
            System.Nullable<bool> attachUp = null,
            System.Nullable<bool> attachDown = null,
            System.Nullable<bool> attachMove = null,
            CachedEntity elementToAttachTo = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask detachControl()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "detachControl" } }
            );
        }

        public async ValueTask setPointerOverMesh(
            AbstractMesh mesh,
            System.Nullable<decimal> pointerId = null,
            PickingInfo pickResult = null,
            IPointerEvent evt = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<AbstractMesh> getPointerOverMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getPointerOverMesh" } }
            );
        }
        #endregion
    }
}
