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

    [JsonConverter(typeof(CachedEntityConverter<PrePassRenderer>))]
    public class PrePassRenderer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<CachedEntity[]> get_TextureFormats()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                "BABYLON",
                "PrePassRenderer.TextureFormats",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static ValueTask set_TextureFormats(CachedEntity[] value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PrePassRenderer.TextureFormats",
                value
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_generateNormalsInWorldSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "generateNormalsInWorldSpace"
            );
        }

        public ValueTask set_generateNormalsInWorldSpace(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "generateNormalsInWorldSpace",
                value
            );
        }

        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples");
        }

        public ValueTask set_samples(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
        }

        public async ValueTask<bool> get_useSpecificClearForDepthTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useSpecificClearForDepthTexture"
            );
        }

        public ValueTask set_useSpecificClearForDepthTexture(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useSpecificClearForDepthTexture",
                value
            );
        }

        public async ValueTask<bool> get_currentRTisSceneRT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "currentRTisSceneRT");
        }

        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled");
        }

        public async ValueTask<bool> get_isSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSupported");
        }
        #endregion

        #region Properties

        public async ValueTask<AbstractMesh[]> get_excludedSkinnedMesh()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                this.___guid,
                "excludedSkinnedMesh",
                (entity) =>
                {
                    return new AbstractMesh() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_excludedSkinnedMesh(AbstractMesh[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "excludedSkinnedMesh", value);
        }

        public async ValueTask<Material[]> get_excludedMaterials()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Material>(
                this.___guid,
                "excludedMaterials",
                (entity) =>
                {
                    return new Material() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_excludedMaterials(Material[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "excludedMaterials", value);
        }

        public async ValueTask<decimal> get_mrtCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mrtCount");
        }

        public ValueTask set_mrtCount(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mrtCount", value);
        }

        private PrePassRenderTarget __defaultRT;

        public async ValueTask<PrePassRenderTarget> get_defaultRT()
        {
            if (__defaultRT == null)
            {
                __defaultRT = await EventHorizonBlazorInterop.GetClass<PrePassRenderTarget>(
                    this.___guid,
                    "defaultRT",
                    (entity) =>
                    {
                        return new PrePassRenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultRT;
        }

        public ValueTask set_defaultRT(PrePassRenderTarget value)
        {
            __defaultRT = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "defaultRT", value);
        }

        public async ValueTask<bool> get_doNotUseGeometryRendererFallback()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "doNotUseGeometryRendererFallback"
            );
        }

        public ValueTask set_doNotUseGeometryRendererFallback(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "doNotUseGeometryRendererFallback",
                value
            );
        }

        public async ValueTask<PrePassRenderTarget[]> get_renderTargets()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<PrePassRenderTarget>(
                this.___guid,
                "renderTargets",
                (entity) =>
                {
                    return new PrePassRenderTarget() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_renderTargets(PrePassRenderTarget[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderTargets", value);
        }

        public async ValueTask<bool> get_disableGammaTransform()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableGammaTransform");
        }

        public ValueTask set_disableGammaTransform(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableGammaTransform", value);
        }
        #endregion

        #region Constructor
        public PrePassRenderer()
            : base() { }

        public PrePassRenderer(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PrePassRenderer> NewPrePassRenderer(Scene scene)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderer" },
                scene
            );

            return new PrePassRenderer(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> getIndex(decimal type)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getIndex" }, type }
            );
        }

        public async ValueTask<PrePassRenderTarget> getRenderTarget()
        {
            return await EventHorizonBlazorInterop.FuncClass<PrePassRenderTarget>(
                entity => new PrePassRenderTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRenderTarget" } }
            );
        }

        public async ValueTask bindAttachmentsForEffect(Effect effect, SubMesh subMesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAttachmentsForEffect" },
                    effect,
                    subMesh
                }
            );
        }

        public async ValueTask restoreAttachments()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreAttachments" } }
            );
        }

        public async ValueTask<bool> setCustomOutput(RenderTargetTexture rt)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setCustomOutput" }, rt }
            );
        }

        public async ValueTask<PrePassEffectConfigurationCachedEntity> addEffectConfiguration(
            PrePassEffectConfiguration cfg
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PrePassEffectConfigurationCachedEntity>(
                entity => new PrePassEffectConfigurationCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addEffectConfiguration" }, cfg }
            );
        }

        public async ValueTask<PrePassEffectConfigurationCachedEntity> getEffectConfiguration(
            string name
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<PrePassEffectConfigurationCachedEntity>(
                entity => new PrePassEffectConfigurationCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getEffectConfiguration" }, name }
            );
        }

        public async ValueTask markAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsDirty" } }
            );
        }

        public async ValueTask update()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
