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

    [JsonConverter(typeof(CachedEntityConverter<PBRBaseMaterial>))]
    public class PBRBaseMaterial : PushMaterial
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_PBRMATERIAL_OPAQUE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.PBRMATERIAL_OPAQUE"
            );
        }

        public static async ValueTask<decimal> get_PBRMATERIAL_ALPHATEST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.PBRMATERIAL_ALPHATEST"
            );
        }

        public static async ValueTask<decimal> get_PBRMATERIAL_ALPHABLEND()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.PBRMATERIAL_ALPHABLEND"
            );
        }

        public static async ValueTask<decimal> get_PBRMATERIAL_ALPHATESTANDBLEND()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.PBRMATERIAL_ALPHATESTANDBLEND"
            );
        }

        public static async ValueTask<decimal> get_DEFAULT_AO_ON_ANALYTICAL_LIGHTS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.DEFAULT_AO_ON_ANALYTICAL_LIGHTS"
            );
        }

        public static ValueTask set_DEFAULT_AO_ON_ANALYTICAL_LIGHTS(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "PBRBaseMaterial.DEFAULT_AO_ON_ANALYTICAL_LIGHTS",
                value
            );
        }

        public static async ValueTask<decimal> get_LIGHTFALLOFF_PHYSICAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.LIGHTFALLOFF_PHYSICAL"
            );
        }

        public static async ValueTask<decimal> get_LIGHTFALLOFF_GLTF()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.LIGHTFALLOFF_GLTF"
            );
        }

        public static async ValueTask<decimal> get_LIGHTFALLOFF_STANDARD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "PBRBaseMaterial.LIGHTFALLOFF_STANDARD"
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_realTimeFiltering()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "realTimeFiltering");
        }

        public ValueTask set_realTimeFiltering(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "realTimeFiltering", value);
        }

        public async ValueTask<decimal> get_realTimeFilteringQuality()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "realTimeFilteringQuality"
            );
        }

        public ValueTask set_realTimeFilteringQuality(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "realTimeFilteringQuality", value);
        }

        public async ValueTask<bool> get_canRenderToMRT()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "canRenderToMRT");
        }

        public async ValueTask<bool> get_hasRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "hasRenderTargetTextures"
            );
        }

        public async ValueTask<bool> get_isPrePassCapable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPrePassCapable");
        }
        #endregion

        #region Properties

        public async ValueTask<decimal> get_debugMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "debugMode");
        }

        public ValueTask set_debugMode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "debugMode", value);
        }

        public async ValueTask<decimal> get_debugLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "debugLimit");
        }

        public ValueTask set_debugLimit(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "debugLimit", value);
        }

        public async ValueTask<decimal> get_debugFactor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "debugFactor");
        }

        public ValueTask set_debugFactor(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "debugFactor", value);
        }

        private PBRClearCoatConfiguration __clearCoat;

        public async ValueTask<PBRClearCoatConfiguration> get_clearCoat()
        {
            if (__clearCoat == null)
            {
                __clearCoat = await EventHorizonBlazorInterop.GetClass<PBRClearCoatConfiguration>(
                    this.___guid,
                    "clearCoat",
                    (entity) =>
                    {
                        return new PBRClearCoatConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearCoat;
        }

        private PBRIridescenceConfiguration __iridescence;

        public async ValueTask<PBRIridescenceConfiguration> get_iridescence()
        {
            if (__iridescence == null)
            {
                __iridescence =
                    await EventHorizonBlazorInterop.GetClass<PBRIridescenceConfiguration>(
                        this.___guid,
                        "iridescence",
                        (entity) =>
                        {
                            return new PBRIridescenceConfiguration() { ___guid = entity.___guid };
                        }
                    );
            }
            return __iridescence;
        }

        private PBRAnisotropicConfiguration __anisotropy;

        public async ValueTask<PBRAnisotropicConfiguration> get_anisotropy()
        {
            if (__anisotropy == null)
            {
                __anisotropy =
                    await EventHorizonBlazorInterop.GetClass<PBRAnisotropicConfiguration>(
                        this.___guid,
                        "anisotropy",
                        (entity) =>
                        {
                            return new PBRAnisotropicConfiguration() { ___guid = entity.___guid };
                        }
                    );
            }
            return __anisotropy;
        }

        private PBRBRDFConfiguration __brdf;

        public async ValueTask<PBRBRDFConfiguration> get_brdf()
        {
            if (__brdf == null)
            {
                __brdf = await EventHorizonBlazorInterop.GetClass<PBRBRDFConfiguration>(
                    this.___guid,
                    "brdf",
                    (entity) =>
                    {
                        return new PBRBRDFConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __brdf;
        }

        private PBRSheenConfiguration __sheen;

        public async ValueTask<PBRSheenConfiguration> get_sheen()
        {
            if (__sheen == null)
            {
                __sheen = await EventHorizonBlazorInterop.GetClass<PBRSheenConfiguration>(
                    this.___guid,
                    "sheen",
                    (entity) =>
                    {
                        return new PBRSheenConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __sheen;
        }

        private PBRSubSurfaceConfiguration __subSurface;

        public async ValueTask<PBRSubSurfaceConfiguration> get_subSurface()
        {
            if (__subSurface == null)
            {
                __subSurface = await EventHorizonBlazorInterop.GetClass<PBRSubSurfaceConfiguration>(
                    this.___guid,
                    "subSurface",
                    (entity) =>
                    {
                        return new PBRSubSurfaceConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __subSurface;
        }

        private PrePassConfiguration __prePassConfiguration;

        public async ValueTask<PrePassConfiguration> get_prePassConfiguration()
        {
            if (__prePassConfiguration == null)
            {
                __prePassConfiguration =
                    await EventHorizonBlazorInterop.GetClass<PrePassConfiguration>(
                        this.___guid,
                        "prePassConfiguration",
                        (entity) =>
                        {
                            return new PrePassConfiguration() { ___guid = entity.___guid };
                        }
                    );
            }
            return __prePassConfiguration;
        }

        private DetailMapConfiguration __detailMap;

        public async ValueTask<DetailMapConfiguration> get_detailMap()
        {
            if (__detailMap == null)
            {
                __detailMap = await EventHorizonBlazorInterop.GetClass<DetailMapConfiguration>(
                    this.___guid,
                    "detailMap",
                    (entity) =>
                    {
                        return new DetailMapConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __detailMap;
        }
        #endregion

        #region Constructor
        public PBRBaseMaterial()
            : base() { }

        public PBRBaseMaterial(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRBaseMaterial> NewPBRBaseMaterial(
            string name,
            Scene scene = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRBaseMaterial" },
                name,
                scene
            );

            return new PBRBaseMaterial(entity);
        }

        public static async ValueTask<PBRBaseMaterial> NewPBRBaseMaterial(
            string name,
            Scene scene = null,
            System.Nullable<bool> storeEffectOnSubMeshes = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRBaseMaterial" },
                name,
                scene,
                storeEffectOnSubMeshes
            );

            return new PBRBaseMaterial(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<bool> needAlphaBlending()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "needAlphaBlending" } }
            );
        }

        public async ValueTask<bool> needAlphaTesting()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "needAlphaTesting" } }
            );
        }

        public async ValueTask<BaseTexture> getAlphaTestTexture()
        {
            return await EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAlphaTestTexture" } }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(
            AbstractMesh mesh,
            SubMesh subMesh,
            System.Nullable<bool> useInstances = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" },
                    mesh,
                    subMesh,
                    useInstances
                }
            );
        }

        public async ValueTask<bool> isMetallicWorkflow()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isMetallicWorkflow" } }
            );
        }

        public async ValueTask forceCompilation(
            AbstractMesh mesh,
            ActionCallback<Material> onCompiled = null,
            IMaterialCompilationOptions options = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceCompilation" },
                    mesh,
                    onCompiled,
                    options
                }
            );
        }

        public async ValueTask buildUniformLayout()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "buildUniformLayout" } }
            );
        }

        public async ValueTask bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" },
                    world,
                    mesh,
                    subMesh
                }
            );
        }

        public async ValueTask<IAnimatableCachedEntity[]> getAnimatables()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimatables" } }
            );
        }

        public async ValueTask<BaseTexture[]> getActiveTextures()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getActiveTextures" } }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
            );
        }

        public async ValueTask<bool> setPrePassRenderer()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setPrePassRenderer" } }
            );
        }

        public async ValueTask dispose(
            System.Nullable<bool> forceDisposeEffect = null,
            System.Nullable<bool> forceDisposeTextures = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" },
                    forceDisposeEffect,
                    forceDisposeTextures
                }
            );
        }
        #endregion
    }
}
