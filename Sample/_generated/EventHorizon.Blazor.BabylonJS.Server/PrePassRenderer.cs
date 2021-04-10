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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PrePassRenderer>))]
    public class PrePassRenderer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
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

        
        public async ValueTask<bool> get_useGeometryBufferFallback()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useGeometryBufferFallback"
                );
        }
        public ValueTask set_useGeometryBufferFallback(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useGeometryBufferFallback",
                    value
                );
        }

        
        public async ValueTask<bool> get_isSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedSkinnedMesh",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedMaterials",
                    value
                );
        }

        
        public async ValueTask<decimal> get_mrtCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mrtCount"
                );
        }
        public ValueTask set_mrtCount(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mrtCount",
                    value
                );
        }

        private MultiRenderTarget __prePassRT;
        public async ValueTask<MultiRenderTarget> get_prePassRT()
        {
            if(__prePassRT == null)
            {
                __prePassRT = await EventHorizonBlazorInterop.GetClass<MultiRenderTarget>(
                    this.___guid,
                    "prePassRT",
                    (entity) =>
                    {
                        return new MultiRenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            return __prePassRT;
        }
        public ValueTask set_prePassRT(MultiRenderTarget value)
        {
__prePassRT = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prePassRT",
                    value
                );
        }

        private ImageProcessingPostProcess __imageProcessingPostProcess;
        public async ValueTask<ImageProcessingPostProcess> get_imageProcessingPostProcess()
        {
            if(__imageProcessingPostProcess == null)
            {
                __imageProcessingPostProcess = await EventHorizonBlazorInterop.GetClass<ImageProcessingPostProcess>(
                    this.___guid,
                    "imageProcessingPostProcess",
                    (entity) =>
                    {
                        return new ImageProcessingPostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageProcessingPostProcess;
        }
        public ValueTask set_imageProcessingPostProcess(ImageProcessingPostProcess value)
        {
__imageProcessingPostProcess = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingPostProcess",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableGammaTransform()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableGammaTransform"
                );
        }
        public ValueTask set_disableGammaTransform(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableGammaTransform",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public PrePassRenderer() : base() { } 

        public PrePassRenderer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PrePassRenderer> NewPrePassRenderer(
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderer" },
                scene
            );

            return new PrePassRenderer(entity);
        }
        #endregion

        #region Methods
        public async ValueTask bindAttachmentsForEffect(Effect effect, SubMesh subMesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindAttachmentsForEffect" }, effect, subMesh
                }
            );
        }

        public async ValueTask restoreAttachments()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreAttachments" }
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

        public async ValueTask<PrePassEffectConfigurationCachedEntity> addEffectConfiguration(PrePassEffectConfiguration cfg)
        {
            return await EventHorizonBlazorInterop.FuncClass<PrePassEffectConfigurationCachedEntity>(
                entity => new PrePassEffectConfigurationCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addEffectConfiguration" }, cfg
                }
            );
        }

        public async ValueTask<decimal> getIndex(decimal type)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getIndex" }, type
                }
            );
        }

        public async ValueTask markAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }
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