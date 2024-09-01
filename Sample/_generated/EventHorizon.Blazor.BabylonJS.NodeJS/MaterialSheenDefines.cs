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

    [JsonConverter(typeof(CachedEntityConverter<MaterialSheenDefines>))]
    public class MaterialSheenDefines : MaterialDefines
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

        public bool SHEEN
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN", value);
            }
        }

        public bool SHEEN_TEXTURE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_TEXTURE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_TEXTURE", value);
            }
        }

        public bool SHEEN_GAMMATEXTURE
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_GAMMATEXTURE"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_GAMMATEXTURE", value);
            }
        }

        public bool SHEEN_TEXTURE_ROUGHNESS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_TEXTURE_ROUGHNESS");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_TEXTURE_ROUGHNESS", value);
            }
        }

        public decimal SHEEN_TEXTUREDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SHEEN_TEXTUREDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_TEXTUREDIRECTUV", value);
            }
        }

        public decimal SHEEN_TEXTURE_ROUGHNESSDIRECTUV
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SHEEN_TEXTURE_ROUGHNESSDIRECTUV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SHEEN_TEXTURE_ROUGHNESSDIRECTUV",
                    value
                );
            }
        }

        public bool SHEEN_LINKWITHALBEDO
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_LINKWITHALBEDO");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_LINKWITHALBEDO", value);
            }
        }

        public bool SHEEN_ROUGHNESS
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_ROUGHNESS"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_ROUGHNESS", value);
            }
        }

        public bool SHEEN_ALBEDOSCALING
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "SHEEN_ALBEDOSCALING"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "SHEEN_ALBEDOSCALING", value);
            }
        }

        public bool SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SHEEN_USE_ROUGHNESS_FROM_MAINTEXTURE",
                    value
                );
            }
        }
        #endregion

        #region Constructor
        public MaterialSheenDefines()
            : base() { }

        public MaterialSheenDefines(ICachedEntity entity)
            : base(entity) { }

        public MaterialSheenDefines(object externalProperties = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialSheenDefines" },
                externalProperties
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
