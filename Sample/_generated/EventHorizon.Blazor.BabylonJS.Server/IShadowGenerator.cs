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

    public interface IShadowGenerator : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IShadowGeneratorCachedEntity>))]
    public class IShadowGeneratorCachedEntity : CachedEntityObject, IShadowGenerator
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
        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IShadowGeneratorCachedEntity() : base() { }

        public IShadowGeneratorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<RenderTargetTexture> getShadowMap()
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public async ValueTask<bool> isReady(SubMesh subMesh, bool useInstances, bool isTransparent)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances, isTransparent
                }
            );
        }

        public async ValueTask prepareDefines(MaterialDefines defines, decimal lightIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public async ValueTask bindShadowLight(string lightIndex, Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public async ValueTask<Matrix> getTransformMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public async ValueTask recreateShadowMap()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        public async ValueTask forceCompilation(ActionCallback<IShadowGenerator> onCompiled = null, CachedEntity options = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilation" }, onCompiled, options
                }
            );
        }

        public async ValueTask forceCompilationAsync(CachedEntity options = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, options
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