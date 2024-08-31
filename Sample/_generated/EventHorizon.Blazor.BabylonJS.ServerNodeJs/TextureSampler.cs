/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<TextureSampler>))]
    public class TextureSampler : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<decimal> get_wrapU()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "wrapU");
        }

        public ValueTask set_wrapU(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "wrapU", value);
        }

        public async ValueTask<decimal> get_wrapV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "wrapV");
        }

        public ValueTask set_wrapV(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "wrapV", value);
        }

        public async ValueTask<decimal> get_wrapR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "wrapR");
        }

        public ValueTask set_wrapR(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "wrapR", value);
        }

        public async ValueTask<decimal> get_anisotropicFilteringLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "anisotropicFilteringLevel"
            );
        }

        public ValueTask set_anisotropicFilteringLevel(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "anisotropicFilteringLevel", value);
        }

        public async ValueTask<decimal> get_comparisonFunction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "comparisonFunction");
        }

        public ValueTask set_comparisonFunction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "comparisonFunction", value);
        }

        public async ValueTask<bool> get_useMipMaps()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useMipMaps");
        }

        public ValueTask set_useMipMaps(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useMipMaps", value);
        }
        #endregion

        #region Properties

        public async ValueTask<decimal> get_samplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samplingMode");
        }

        public ValueTask set_samplingMode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "samplingMode", value);
        }

        public async ValueTask<string> get_label()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "label");
        }

        public ValueTask set_label(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "label", value);
        }
        #endregion

        #region Constructor
        public TextureSampler()
            : base() { }

        public TextureSampler(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods
        public async ValueTask<TextureSampler> setParameters(
            System.Nullable<decimal> wrapU = null,
            System.Nullable<decimal> wrapV = null,
            System.Nullable<decimal> wrapR = null,
            System.Nullable<decimal> anisotropicFilteringLevel = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> comparisonFunction = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TextureSampler>(
                entity => new TextureSampler() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setParameters" },
                    wrapU,
                    wrapV,
                    wrapR,
                    anisotropicFilteringLevel,
                    samplingMode,
                    comparisonFunction
                }
            );
        }

        public async ValueTask<bool> compareSampler(TextureSampler other)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "compareSampler" }, other }
            );
        }
        #endregion
    }
}
