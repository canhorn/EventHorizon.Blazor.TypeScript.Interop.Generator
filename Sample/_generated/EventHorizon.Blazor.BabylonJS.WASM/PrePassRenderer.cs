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
        
        public bool enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enabled"
                );
            }
        }

        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
            }
        }

        
        public bool useGeometryBufferFallback
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useGeometryBufferFallback"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useGeometryBufferFallback",
                    value
                );
            }
        }

        
        public bool isSupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
            }
        }
        #endregion

        #region Properties
        
        public AbstractMesh[] excludedSkinnedMesh
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "excludedSkinnedMesh",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedSkinnedMesh",
                    value
                );
            }
        }

        
        public Material[] excludedMaterials
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Material>(
                    this.___guid,
                    "excludedMaterials",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedMaterials",
                    value
                );
            }
        }

        
        public decimal mrtCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mrtCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mrtCount",
                    value
                );
            }
        }

        private MultiRenderTarget __prePassRT;
        public MultiRenderTarget prePassRT
        {
            get
            {
            if(__prePassRT == null)
            {
                __prePassRT = EventHorizonBlazorInterop.GetClass<MultiRenderTarget>(
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
            set
            {
__prePassRT = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prePassRT",
                    value
                );
            }
        }

        private ImageProcessingPostProcess __imageProcessingPostProcess;
        public ImageProcessingPostProcess imageProcessingPostProcess
        {
            get
            {
            if(__imageProcessingPostProcess == null)
            {
                __imageProcessingPostProcess = EventHorizonBlazorInterop.GetClass<ImageProcessingPostProcess>(
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
            set
            {
__imageProcessingPostProcess = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingPostProcess",
                    value
                );
            }
        }

        
        public bool disableGammaTransform
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableGammaTransform"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableGammaTransform",
                    value
                );
            }
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

        public PrePassRenderer(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderer" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void bindAttachmentsForEffect(Effect effect, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAttachmentsForEffect" }, effect, subMesh
                }
            );
        }

        public void restoreAttachments()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "restoreAttachments" }
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

        public PrePassEffectConfigurationCachedEntity addEffectConfiguration(PrePassEffectConfiguration cfg)
        {
            return EventHorizonBlazorInterop.FuncClass<PrePassEffectConfigurationCachedEntity>(
                entity => new PrePassEffectConfigurationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addEffectConfiguration" }, cfg
                }
            );
        }

        public decimal getIndex(decimal type)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }, type
                }
            );
        }

        public void markAsDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "markAsDirty" }
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