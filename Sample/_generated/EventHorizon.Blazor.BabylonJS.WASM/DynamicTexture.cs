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

    
    
    [JsonConverter(typeof(CachedEntityConverter<DynamicTexture>))]
    public class DynamicTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool canRescale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public DynamicTexture() : base() { }

        public DynamicTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DynamicTexture(
            string name, object options, bool generateMipMaps, Scene scene = null, System.Nullable<decimal> samplingMode = null, System.Nullable<decimal> format = null, System.Nullable<bool> invertY = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                name, options, scene, generateMipMaps, samplingMode, format, invertY
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public void scaleTo(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scaleTo" }, width, height
                }
            );
        }

        public CanvasRenderingContext2DCachedEntity getContext()
        {
            return EventHorizonBlazorInterop.FuncClass<CanvasRenderingContext2DCachedEntity>(
                entity => new CanvasRenderingContext2DCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContext" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void update(System.Nullable<bool> invertY = null, System.Nullable<bool> premulAlpha = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }, invertY, premulAlpha
                }
            );
        }

        public void drawText(string text, string font, string clearColor, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string color = null, System.Nullable<bool> invertY = null, System.Nullable<bool> update = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawText" }, text, x, y, font, color, clearColor, invertY, update
                }
            );
        }

        public DynamicTexture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<DynamicTexture>(
                entity => new DynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
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