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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FreeCameraInputsManager>))]
    public class FreeCameraInputsManager : CameraInputsManager<FreeCamera>
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

        #endregion
        
        #region Constructor
        public FreeCameraInputsManager() : base() { }

        public FreeCameraInputsManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FreeCameraInputsManager(
            FreeCamera camera
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FreeCameraInputsManager" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FreeCameraInputsManager addKeyboard()
        {
            return EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addKeyboard" }
                }
            );
        }

        public FreeCameraInputsManager addMouse(System.Nullable<bool> touchEnabled = null)
        {
            return EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMouse" }, touchEnabled
                }
            );
        }

        public FreeCameraInputsManager removeMouse()
        {
            return EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeMouse" }
                }
            );
        }

        public FreeCameraInputsManager addMouseWheel()
        {
            return EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMouseWheel" }
                }
            );
        }

        public FreeCameraInputsManager removeMouseWheel()
        {
            return EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeMouseWheel" }
                }
            );
        }

        public FreeCameraInputsManager addTouch()
        {
            return EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addTouch" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }
        #endregion
    }
}