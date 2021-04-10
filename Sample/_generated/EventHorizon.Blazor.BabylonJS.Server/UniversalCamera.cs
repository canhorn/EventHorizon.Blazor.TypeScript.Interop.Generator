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

    
    
    [JsonConverter(typeof(CachedEntityConverter<UniversalCamera>))]
    public class UniversalCamera : TouchCamera
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_gamepadAngularSensibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gamepadAngularSensibility"
                );
        }
        public ValueTask set_gamepadAngularSensibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gamepadAngularSensibility",
                    value
                );
        }

        
        public async ValueTask<decimal> get_gamepadMoveSensibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gamepadMoveSensibility"
                );
        }
        public ValueTask set_gamepadMoveSensibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gamepadMoveSensibility",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public UniversalCamera() : base() { }

        public UniversalCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<UniversalCamera> NewUniversalCamera(
            string name, Vector3 position, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "UniversalCamera" },
                name, position, scene
            );

            return new UniversalCamera(entity);
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