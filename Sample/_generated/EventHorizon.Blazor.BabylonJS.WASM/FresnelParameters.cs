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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FresnelParameters>))]
    public class FresnelParameters : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static FresnelParameters Parse(CachedEntity parsedFresnelParameters)
        {
            return EventHorizonBlazorInterop.FuncClass<FresnelParameters>(
                entity => new FresnelParameters() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "FresnelParameters", "Parse" }, parsedFresnelParameters
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Color3 __leftColor;
        public Color3 leftColor
        {
            get
            {
            if(__leftColor == null)
            {
                __leftColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "leftColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __leftColor;
            }
            set
            {
__leftColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leftColor",
                    value
                );
            }
        }

        private Color3 __rightColor;
        public Color3 rightColor
        {
            get
            {
            if(__rightColor == null)
            {
                __rightColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "rightColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __rightColor;
            }
            set
            {
__rightColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rightColor",
                    value
                );
            }
        }

        
        public decimal bias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bias",
                    value
                );
            }
        }

        
        public decimal power
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "power"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "power",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FresnelParameters() : base() { }

        public FresnelParameters(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public FresnelParameters(
            CachedEntity options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FresnelParameters" },
                options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FresnelParameters clone()
        {
            return EventHorizonBlazorInterop.FuncClass<FresnelParameters>(
                entity => new FresnelParameters() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public bool equals(FresnelParameters otherFresnelParameters)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, otherFresnelParameters
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}