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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MultiRenderTarget>))]
    public class MultiRenderTarget : RenderTargetTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
        }

        
        public async ValueTask<Texture[]> get_textures()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Texture>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<decimal> get_count()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
        }

        private Texture __depthTexture;
        public async ValueTask<Texture> get_depthTexture()
        {
            if(__depthTexture == null)
            {
                __depthTexture = await EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "depthTexture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __depthTexture;
        }

        
        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
        }
        public ValueTask set_samples(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public MultiRenderTarget() : base() { }

        public MultiRenderTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<MultiRenderTarget> NewMultiRenderTarget(
            string name, object size, decimal count, Scene scene, IMultiRenderTargetOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MultiRenderTarget" },
                name, size, count, scene, options
            );

            return new MultiRenderTarget(entity);
        }
        #endregion

        #region Methods
        public async ValueTask replaceTexture(Texture texture, decimal index)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "replaceTexture" }, texture, index
                }
            );
        }

        public async ValueTask resize(object size)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }, size
                }
            );
        }

        public async ValueTask updateCount(decimal count, IMultiRenderTargetOptions options = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateCount" }, count, options
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

        public async ValueTask releaseInternalTextures()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseInternalTextures" }
                }
            );
        }
        #endregion
    }
}