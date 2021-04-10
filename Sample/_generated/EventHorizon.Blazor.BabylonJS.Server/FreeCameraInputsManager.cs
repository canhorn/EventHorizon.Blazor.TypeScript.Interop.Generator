/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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

        public static async ValueTask<FreeCameraInputsManager> NewFreeCameraInputsManager(
            FreeCamera camera
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FreeCameraInputsManager" },
                camera
            );

            return new FreeCameraInputsManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<FreeCameraInputsManager> addKeyboard()
        {
            return await EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addKeyboard" }
                }
            );
        }

        public async ValueTask<FreeCameraInputsManager> addMouse(System.Nullable<bool> touchEnabled = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addMouse" }, touchEnabled
                }
            );
        }

        public async ValueTask<FreeCameraInputsManager> removeMouse()
        {
            return await EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeMouse" }
                }
            );
        }

        public async ValueTask<FreeCameraInputsManager> addMouseWheel()
        {
            return await EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addMouseWheel" }
                }
            );
        }

        public async ValueTask<FreeCameraInputsManager> removeMouseWheel()
        {
            return await EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeMouseWheel" }
                }
            );
        }

        public async ValueTask<FreeCameraInputsManager> addTouch()
        {
            return await EventHorizonBlazorInterop.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addTouch" }
                }
            );
        }

        public async ValueTask clear()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }
        #endregion
    }
}