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

        public ArcRotateCameraInputsManager(
            ArcRotateCamera camera
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ArcRotateCameraInputsManager" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public ArcRotateCameraInputsManager addMouseWheel()
        {
            return EventHorizonBlazorInterop.FuncClass<ArcRotateCameraInputsManager>(
                entity => new ArcRotateCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMouseWheel" }
                }
            );
        }

        public ArcRotateCameraInputsManager addPointers()
        {
            return EventHorizonBlazorInterop.FuncClass<ArcRotateCameraInputsManager>(
                entity => new ArcRotateCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addPointers" }
                }
            );
        }

        public ArcRotateCameraInputsManager addKeyboard()
        {
            return EventHorizonBlazorInterop.FuncClass<ArcRotateCameraInputsManager>(
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