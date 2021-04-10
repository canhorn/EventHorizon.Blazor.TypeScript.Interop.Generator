/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Vector2WithInfo>))]
    public class Vector2WithInfo : Vector2
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
        
        public async ValueTask<decimal> get_buttonIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buttonIndex"
                );
        }
        public ValueTask set_buttonIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buttonIndex",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Vector2WithInfo() : base() { }

        public Vector2WithInfo(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Vector2WithInfo> NewVector2WithInfo(
            Vector2 source, System.Nullable<decimal> buttonIndex = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Vector2WithInfo" },
                source, buttonIndex
            );

            return new Vector2WithInfo(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}