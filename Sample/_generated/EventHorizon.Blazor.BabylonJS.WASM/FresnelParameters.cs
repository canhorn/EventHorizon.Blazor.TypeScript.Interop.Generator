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
    public class FresnelParameters : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static FresnelParameters Parse(object parsedFresnelParameters)
        {
            return EventHorizonBlazorInteropt.FuncClass<FresnelParameters>(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __leftColor = EventHorizonBlazorInteropt.GetClass<Color3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __rightColor = EventHorizonBlazorInteropt.GetClass<Color3>(
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
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "bias"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "power"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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


        #endregion

        #region Methods
        public FresnelParameters clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<FresnelParameters>(
                entity => new FresnelParameters() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}