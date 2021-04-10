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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Color3Gradient>))]
    public class Color3Gradient : CachedEntityObject, IValueGradient
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
        
        public async ValueTask<decimal> get_gradient()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gradient"
                );
        }
        public ValueTask set_gradient(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gradient",
                    value
                );
        }

        private Color3 __color;
        public async ValueTask<Color3> get_color()
        {
            if(__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
        }
        public ValueTask set_color(Color3 value)
        {
__color = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Color3Gradient() : base() { }

        public Color3Gradient(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Color3Gradient> NewColor3Gradient(
            decimal gradient, Color3 color
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color3Gradient" },
                gradient, color
            );

            return new Color3Gradient(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}