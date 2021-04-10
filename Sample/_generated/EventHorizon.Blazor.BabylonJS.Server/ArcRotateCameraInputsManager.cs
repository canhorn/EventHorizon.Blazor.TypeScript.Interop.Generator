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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ArcRotateCameraInputsManager>))]
    public class ArcRotateCameraInputsManager : CameraInputsManager<ArcRotateCamera>
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
        public ArcRotateCameraInputsManager() : base() { }

        public ArcRotateCameraInputsManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ArcRotateCameraInputsManager> NewArcRotateCameraInputsManager(
            ArcRotateCamera camera
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ArcRotateCameraInputsManager" },
                camera
            );

            return new ArcRotateCameraInputsManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<ArcRotateCameraInputsManager> addMouseWheel()
        {
            return await EventHorizonBlazorInterop.FuncClass<ArcRotateCameraInputsManager>(
                entity => new ArcRotateCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addMouseWheel" }
                }
            );
        }

        public async ValueTask<ArcRotateCameraInputsManager> addPointers()
        {
            return await EventHorizonBlazorInterop.FuncClass<ArcRotateCameraInputsManager>(
                entity => new ArcRotateCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addPointers" }
                }
            );
        }

        public async ValueTask<ArcRotateCameraInputsManager> addKeyboard()
        {
            return await EventHorizonBlazorInterop.FuncClass<ArcRotateCameraInputsManager>(
                entity => new ArcRotateCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addKeyboard" }
                }
            );
        }
        #endregion
    }
}