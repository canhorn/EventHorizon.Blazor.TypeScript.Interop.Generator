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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TouchCamera>))]
    public class TouchCamera : FreeCamera
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_touchAngularSensibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "touchAngularSensibility"
                );
        }
        public ValueTask set_touchAngularSensibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "touchAngularSensibility",
                    value
                );
        }

        
        public async ValueTask<decimal> get_touchMoveSensibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "touchMoveSensibility"
                );
        }
        public ValueTask set_touchMoveSensibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "touchMoveSensibility",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public TouchCamera() : base() { }

        public TouchCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<TouchCamera> NewTouchCamera(
            string name, Vector3 position, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TouchCamera" },
                name, position, scene
            );

            return new TouchCamera(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}