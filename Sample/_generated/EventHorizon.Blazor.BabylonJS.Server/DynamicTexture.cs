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
        
        public async ValueTask<bool> get_canRescale()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
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

        public static async ValueTask<DynamicTexture> NewDynamicTexture(
            string name, object options, bool generateMipMaps, Scene scene = null, System.Nullable<decimal> samplingMode = null, System.Nullable<decimal> format = null, System.Nullable<bool> invertY = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DynamicTexture" },
                name, options, scene, generateMipMaps, samplingMode, format, invertY
            );

            return new DynamicTexture(entity);
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

        public async ValueTask scale(decimal ratio)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public async ValueTask scaleTo(decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scaleTo" }, width, height
                }
            );
        }

        public async ValueTask<CanvasRenderingContext2DCachedEntity> getContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<CanvasRenderingContext2DCachedEntity>(
                entity => new CanvasRenderingContext2DCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getContext" }
                }
            );
        }

        public async ValueTask clear()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public async ValueTask update(System.Nullable<bool> invertY = null, System.Nullable<bool> premulAlpha = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }, invertY, premulAlpha
                }
            );
        }

        public async ValueTask drawText(string text, string font, string clearColor, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, string color = null, System.Nullable<bool> invertY = null, System.Nullable<bool> update = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawText" }, text, x, y, font, color, clearColor, invertY, update
                }
            );
        }

        public async ValueTask<DynamicTexture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<DynamicTexture>(
                entity => new DynamicTexture() { ___guid = entity.___guid },
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