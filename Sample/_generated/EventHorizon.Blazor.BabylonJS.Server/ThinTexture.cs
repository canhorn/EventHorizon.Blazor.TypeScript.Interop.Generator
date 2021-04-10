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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ThinTexture>))]
    public class ThinTexture : CachedEntityObject
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
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wrapU"
                );
        }
        public ValueTask set_wrapU(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapU",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wrapV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wrapV"
                );
        }
        public ValueTask set_wrapV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapV",
                    value
                );
        }

        
        public async ValueTask<decimal> get_coordinatesMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "coordinatesMode"
                );
        }

        
        public async ValueTask<bool> get_isCube()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCube"
                );
        }
        public ValueTask set_isCube(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isCube",
                    value
                );
        }

        
        public async ValueTask<bool> get_is3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "is3D"
                );
        }
        public ValueTask set_is3D(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "is3D",
                    value
                );
        }

        
        public async ValueTask<bool> get_is2DArray()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "is2DArray"
                );
        }
        public ValueTask set_is2DArray(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "is2DArray",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_wrapR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wrapR"
                );
        }
        public ValueTask set_wrapR(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapR",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anisotropicFilteringLevel",
                    value
                );
        }

        
        public async ValueTask<decimal> get_delayLoadState()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
        }
        public ValueTask set_delayLoadState(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadState",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ThinTexture() : base() { } 

        public ThinTexture(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<ThinTexture> NewThinTexture(
            InternalTexture internalTexture
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ThinTexture" },
                internalTexture
            );

            return new ThinTexture(entity);
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

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask delayLoad()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "delayLoad" }
                }
            );
        }

        public async ValueTask<InternalTexture> getInternalTexture()
        {
            return await EventHorizonBlazorInterop.FuncClass<InternalTexture>(
                entity => new InternalTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getInternalTexture" }
                }
            );
        }

        public async ValueTask<ISizeCachedEntity> getSize()
        {
            return await EventHorizonBlazorInterop.FuncClass<ISizeCachedEntity>(
                entity => new ISizeCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSize" }
                }
            );
        }

        public async ValueTask<ISizeCachedEntity> getBaseSize()
        {
            return await EventHorizonBlazorInterop.FuncClass<ISizeCachedEntity>(
                entity => new ISizeCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBaseSize" }
                }
            );
        }

        public async ValueTask updateSamplingMode(decimal samplingMode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateSamplingMode" }, samplingMode
                }
            );
        }

        public async ValueTask releaseInternalTexture()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseInternalTexture" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}