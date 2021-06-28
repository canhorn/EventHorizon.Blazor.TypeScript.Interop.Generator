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
        
        public decimal gradient
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "gradient"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gradient",
                    value
                );
            }
        }

        private Color4 __color1;
        public Color4 color1
        {
            get
            {
            if(__color1 == null)
            {
                __color1 = EventHorizonBlazorInterop.GetClass<Color4>(
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
            set
            {
__color1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color1",
                    value
                );
            }
        }

        private Color4 __color2;
        public Color4 color2
        {
            get
            {
            if(__color2 == null)
            {
                __color2 = EventHorizonBlazorInterop.GetClass<Color4>(
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
            set
            {
__color2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ColorGradient() : base() { }

        public ColorGradient(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ColorGradient(
            decimal gradient, Color4 color1, Color4 color2 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ColorGradient" },
                gradient, color1, color2
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void getColorToRef(Color4 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getColorToRef" }, result
                }
            );
        }
        #endregion
    }
}