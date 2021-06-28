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
        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
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
        public RenderTargetTexture getShadowMap()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public bool isReady(SubMesh subMesh, bool useInstances, bool isTransparent)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances, isTransparent
                }
            );
        }

        public void prepareDefines(MaterialDefines defines, decimal lightIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public void bindShadowLight(string lightIndex, Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public Matrix getTransformMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public void recreateShadowMap()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        public void forceCompilation(ActionCallback<IShadowGenerator> onCompiled = null, CachedEntity options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}