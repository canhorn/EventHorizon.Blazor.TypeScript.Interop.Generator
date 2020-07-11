/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "gradient"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __color1 = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color1",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __color1;
            }
            set
            {
__color1 = null;
                EventHorizonBlazorInteropt.Set(
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
                __color2 = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color2",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __color2;
            }
            set
            {
__color2 = null;
                EventHorizonBlazorInteropt.Set(
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


        #endregion

        #region Methods
        public void getColorToRef(Color4 result)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getColorToRef" }, result
                }
            );
        }
        #endregion
    }
}