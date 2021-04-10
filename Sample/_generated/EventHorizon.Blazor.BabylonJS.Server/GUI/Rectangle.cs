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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Rectangle>))]
    public class Rectangle : Container
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_thickness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "thickness"
                );
        }
        public ValueTask set_thickness(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "thickness",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cornerRadius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cornerRadius"
                );
        }
        public ValueTask set_cornerRadius(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cornerRadius",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Rectangle() : base() { }

        public Rectangle(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Rectangle> NewRectangle(
            string name = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Rectangle" },
                name
            );

            return new Rectangle(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}