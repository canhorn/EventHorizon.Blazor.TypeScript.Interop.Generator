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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ColorGradient>))]
    public class ColorGradient : CachedEntityObject, IValueGradient
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

        private Color4 __color1;
        public async ValueTask<Color4> get_color1()
        {
            if(__color1 == null)
            {
                __color1 = await EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "color1",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color1;
        }
        public ValueTask set_color1(Color4 value)
        {
__color1 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color1",
                    value
                );
        }

        private Color4 __color2;
        public async ValueTask<Color4> get_color2()
        {
            if(__color2 == null)
            {
                __color2 = await EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "color2",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color2;
        }
        public ValueTask set_color2(Color4 value)
        {
__color2 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color2",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ColorGradient() : base() { }

        public ColorGradient(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ColorGradient> NewColorGradient(
            decimal gradient, Color4 color1, Color4 color2 = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ColorGradient" },
                gradient, color1, color2
            );

            return new ColorGradient(entity);
        }
        #endregion

        #region Methods
        public async ValueTask getColorToRef(Color4 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getColorToRef" }, result
                }
            );
        }
        #endregion
    }
}