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
    public class ColorCurves : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void Bind(ColorCurves colorCurves, Effect effect, string positiveUniform = null, string neutralUniform = null, string negativeUniform = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ColorCurves", "Bind" }, colorCurves, effect, positiveUniform, neutralUniform, negativeUniform
                }
            );
        }

        public static void PrepareUniforms(string[] uniformsList)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ColorCurves", "PrepareUniforms" }, uniformsList
                }
            );
        }

        public static ColorCurves Parse(object source)
        {
            return EventHorizonBlazorInteropt.FuncClass<ColorCurves>(
                entity => new ColorCurves() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ColorCurves", "Parse" }, source
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal globalHue
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "globalHue"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "globalHue",
                    value
                );
            }
        }

        
        public decimal globalDensity
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "globalDensity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "globalDensity",
                    value
                );
            }
        }

        
        public decimal globalSaturation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "globalSaturation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "globalSaturation",
                    value
                );
            }
        }

        
        public decimal globalExposure
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "globalExposure"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "globalExposure",
                    value
                );
            }
        }

        
        public decimal highlightsHue
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "highlightsHue"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "highlightsHue",
                    value
                );
            }
        }

        
        public decimal highlightsDensity
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "highlightsDensity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "highlightsDensity",
                    value
                );
            }
        }

        
        public decimal highlightsSaturation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "highlightsSaturation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "highlightsSaturation",
                    value
                );
            }
        }

        
        public decimal highlightsExposure
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "highlightsExposure"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "highlightsExposure",
                    value
                );
            }
        }

        
        public decimal midtonesHue
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "midtonesHue"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "midtonesHue",
                    value
                );
            }
        }

        
        public decimal midtonesDensity
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "midtonesDensity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "midtonesDensity",
                    value
                );
            }
        }

        
        public decimal midtonesSaturation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "midtonesSaturation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "midtonesSaturation",
                    value
                );
            }
        }

        
        public decimal midtonesExposure
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "midtonesExposure"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "midtonesExposure",
                    value
                );
            }
        }

        
        public decimal shadowsHue
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowsHue"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowsHue",
                    value
                );
            }
        }

        
        public decimal shadowsDensity
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowsDensity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowsDensity",
                    value
                );
            }
        }

        
        public decimal shadowsSaturation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowsSaturation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowsSaturation",
                    value
                );
            }
        }

        
        public decimal shadowsExposure
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowsExposure"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowsExposure",
                    value
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public ColorCurves() : base() { } 

        public ColorCurves(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public ColorCurves clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<ColorCurves>(
                entity => new ColorCurves() { ___guid = entity.___guid },
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