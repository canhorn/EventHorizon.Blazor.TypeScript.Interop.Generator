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

        private Color3 __color;
        public Color3 color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Color3Gradient() : base() { }

        public Color3Gradient(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Color3Gradient(
            decimal gradient, Color3 color
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Color3Gradient" },
                gradient, color
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}