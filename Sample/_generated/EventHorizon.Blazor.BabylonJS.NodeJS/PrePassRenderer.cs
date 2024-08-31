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

        public static CachedEntity[] TextureFormats
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<CachedEntity>(
                    "BABYLON",
                    "PrePassRenderer.TextureFormats",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "PrePassRenderer.TextureFormats", value);
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool generateNormalsInWorldSpace
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateNormalsInWorldSpace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateNormalsInWorldSpace", value);
            }
        }

        public decimal samples
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
            }
        }

        public bool useSpecificClearForDepthTexture
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useSpecificClearForDepthTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useSpecificClearForDepthTexture",
                    value
                );
            }
        }

        public bool currentRTisSceneRT
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "currentRTisSceneRT"); }
        }

        public bool enabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled"); }
        }

        public bool isSupported
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSupported"); }
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

                EventHorizonBlazorInterop.Set(this.___guid, "excludedSkinnedMesh", value);
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

                EventHorizonBlazorInterop.Set(this.___guid, "excludedMaterials", value);
            }
        }

        public decimal mrtCount
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mrtCount"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mrtCount", value);
            }
        }

        private PrePassRenderTarget __defaultRT;
        public PrePassRenderTarget defaultRT
        {
            get
            {
                if (__defaultRT == null)
                {
                    __defaultRT = EventHorizonBlazorInterop.GetClass<PrePassRenderTarget>(
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
            set
            {
                __defaultRT = null;
                EventHorizonBlazorInterop.Set(this.___guid, "defaultRT", value);
            }
        }

        public bool doNotUseGeometryRendererFallback
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotUseGeometryRendererFallback"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotUseGeometryRendererFallback",
                    value
                );
            }
        }

        public PrePassRenderTarget[] renderTargets
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<PrePassRenderTarget>(
                    this.___guid,
                    "renderTargets",
                    (entity) =>
                    {
                        return new PrePassRenderTarget() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderTargets", value);
            }
        }

        public bool disableGammaTransform
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableGammaTransform");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableGammaTransform", value);
            }
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

        public PrePassRenderer(Scene scene)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PrePassRenderer" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getIndex(decimal type)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getIndex" }, type }
            );
        }

        public PrePassRenderTarget getRenderTarget()
        {
            return EventHorizonBlazorInterop.FuncClass<PrePassRenderTarget>(
                entity => new PrePassRenderTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRenderTarget" } }
            );
        }

        public void bindAttachmentsForEffect(Effect effect, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindAttachmentsForEffect" },
                    effect,
                    subMesh
                }
            );
        }

        public void restoreAttachments()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreAttachments" } }
            );
        }

        public bool setCustomOutput(RenderTargetTexture rt)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setCustomOutput" }, rt }
            );
        }

        public PrePassEffectConfigurationCachedEntity addEffectConfiguration(
            PrePassEffectConfiguration cfg
        )
        {
            return EventHorizonBlazorInterop.FuncClass<PrePassEffectConfigurationCachedEntity>(
                entity => new PrePassEffectConfigurationCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addEffectConfiguration" }, cfg }
            );
        }

        public PrePassEffectConfigurationCachedEntity getEffectConfiguration(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<PrePassEffectConfigurationCachedEntity>(
                entity => new PrePassEffectConfigurationCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getEffectConfiguration" }, name }
            );
        }

        public void markAsDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsDirty" } }
            );
        }

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "update" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
