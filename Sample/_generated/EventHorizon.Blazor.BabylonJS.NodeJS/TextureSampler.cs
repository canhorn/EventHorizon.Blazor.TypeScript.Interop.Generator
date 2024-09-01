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

        public decimal wrapU
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "wrapU"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "wrapU", value);
            }
        }

        public decimal wrapV
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "wrapV"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "wrapV", value);
            }
        }

        public decimal wrapR
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "wrapR"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "wrapR", value);
            }
        }

        public decimal anisotropicFilteringLevel
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "anisotropicFilteringLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "anisotropicFilteringLevel", value);
            }
        }

        public decimal comparisonFunction
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "comparisonFunction");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "comparisonFunction", value);
            }
        }

        public bool useMipMaps
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useMipMaps"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useMipMaps", value);
            }
        }
        #endregion

        #region Properties

        public decimal samplingMode
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samplingMode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samplingMode", value);
            }
        }

        public string label
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "label"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "label", value);
            }
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
        public TextureSampler setParameters(
            System.Nullable<decimal> wrapU = null,
            System.Nullable<decimal> wrapV = null,
            System.Nullable<decimal> wrapR = null,
            System.Nullable<decimal> anisotropicFilteringLevel = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> comparisonFunction = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<TextureSampler>(
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

        public bool compareSampler(TextureSampler other)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "compareSampler" }, other }
            );
        }
        #endregion
    }
}
