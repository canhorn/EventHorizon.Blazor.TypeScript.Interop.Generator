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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ColorCurves>))]
    public class ColorCurves : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask Bind(ColorCurves colorCurves, Effect effect, string positiveUniform = null, string neutralUniform = null, string negativeUniform = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ColorCurves", "Bind" }, colorCurves, effect, positiveUniform, neutralUniform, negativeUniform
                }
            );
        }

        public static async ValueTask PrepareUniforms(string[] uniformsList)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ColorCurves", "PrepareUniforms" }, uniformsList
                }
            );
        }

        public static async ValueTask<ColorCurves> Parse(object source)
        {
            return await EventHorizonBlazorInterop.FuncClass<ColorCurves>(
                entity => new ColorCurves() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ColorCurves", "Parse" }, source
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_globalHue()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "globalHue"
                );
        }
        public ValueTask set_globalHue(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalHue",
                    value
                );
        }

        
        public async ValueTask<decimal> get_globalDensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "globalDensity"
                );
        }
        public ValueTask set_globalDensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalDensity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_globalSaturation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "globalSaturation"
                );
        }
        public ValueTask set_globalSaturation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalSaturation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_globalExposure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "globalExposure"
                );
        }
        public ValueTask set_globalExposure(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "globalExposure",
                    value
                );
        }

        
        public async ValueTask<decimal> get_highlightsHue()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "highlightsHue"
                );
        }
        public ValueTask set_highlightsHue(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "highlightsHue",
                    value
                );
        }

        
        public async ValueTask<decimal> get_highlightsDensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "highlightsDensity"
                );
        }
        public ValueTask set_highlightsDensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "highlightsDensity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_highlightsSaturation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "highlightsSaturation"
                );
        }
        public ValueTask set_highlightsSaturation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "highlightsSaturation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_highlightsExposure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "highlightsExposure"
                );
        }
        public ValueTask set_highlightsExposure(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "highlightsExposure",
                    value
                );
        }

        
        public async ValueTask<decimal> get_midtonesHue()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "midtonesHue"
                );
        }
        public ValueTask set_midtonesHue(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "midtonesHue",
                    value
                );
        }

        
        public async ValueTask<decimal> get_midtonesDensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "midtonesDensity"
                );
        }
        public ValueTask set_midtonesDensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "midtonesDensity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_midtonesSaturation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "midtonesSaturation"
                );
        }
        public ValueTask set_midtonesSaturation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "midtonesSaturation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_midtonesExposure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "midtonesExposure"
                );
        }
        public ValueTask set_midtonesExposure(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "midtonesExposure",
                    value
                );
        }

        
        public async ValueTask<decimal> get_shadowsHue()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowsHue"
                );
        }
        public ValueTask set_shadowsHue(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowsHue",
                    value
                );
        }

        
        public async ValueTask<decimal> get_shadowsDensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowsDensity"
                );
        }
        public ValueTask set_shadowsDensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowsDensity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_shadowsSaturation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowsSaturation"
                );
        }
        public ValueTask set_shadowsSaturation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowsSaturation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_shadowsExposure()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowsExposure"
                );
        }
        public ValueTask set_shadowsExposure(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowsExposure",
                    value
                );
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
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<ColorCurves> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<ColorCurves>(
                entity => new ColorCurves() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}