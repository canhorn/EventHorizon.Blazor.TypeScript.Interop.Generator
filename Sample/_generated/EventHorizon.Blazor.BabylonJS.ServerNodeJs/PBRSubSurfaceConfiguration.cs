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

    [JsonConverter(typeof(CachedEntityConverter<PBRSubSurfaceConfiguration>))]
    public class PBRSubSurfaceConfiguration : MaterialPluginBase
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Color3 __scatteringDiffusionProfile;

        public async ValueTask<Color3> get_scatteringDiffusionProfile()
        {
            if (__scatteringDiffusionProfile == null)
            {
                __scatteringDiffusionProfile = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "scatteringDiffusionProfile",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __scatteringDiffusionProfile;
        }

        public ValueTask set_scatteringDiffusionProfile(Color3 value)
        {
            __scatteringDiffusionProfile = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "scatteringDiffusionProfile", value);
        }

        public async ValueTask<decimal> get_volumeIndexOfRefraction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "volumeIndexOfRefraction"
            );
        }

        public ValueTask set_volumeIndexOfRefraction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "volumeIndexOfRefraction", value);
        }

        public async ValueTask<bool> get_disableAlphaBlending()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableAlphaBlending");
        }
        #endregion

        #region Properties

        public async ValueTask<bool> get_isRefractionEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isRefractionEnabled");
        }

        public ValueTask set_isRefractionEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isRefractionEnabled", value);
        }

        public async ValueTask<bool> get_isTranslucencyEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTranslucencyEnabled");
        }

        public ValueTask set_isTranslucencyEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isTranslucencyEnabled", value);
        }

        public async ValueTask<bool> get_isDispersionEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDispersionEnabled");
        }

        public ValueTask set_isDispersionEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isDispersionEnabled", value);
        }

        public async ValueTask<bool> get_isScatteringEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isScatteringEnabled");
        }

        public ValueTask set_isScatteringEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isScatteringEnabled", value);
        }

        public async ValueTask<decimal> get_refractionIntensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "refractionIntensity"
            );
        }

        public ValueTask set_refractionIntensity(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "refractionIntensity", value);
        }

        public async ValueTask<decimal> get_translucencyIntensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "translucencyIntensity"
            );
        }

        public ValueTask set_translucencyIntensity(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "translucencyIntensity", value);
        }

        public async ValueTask<bool> get_useAlbedoToTintRefraction()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useAlbedoToTintRefraction"
            );
        }

        public ValueTask set_useAlbedoToTintRefraction(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useAlbedoToTintRefraction", value);
        }

        public async ValueTask<bool> get_useAlbedoToTintTranslucency()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useAlbedoToTintTranslucency"
            );
        }

        public ValueTask set_useAlbedoToTintTranslucency(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useAlbedoToTintTranslucency",
                value
            );
        }

        private BaseTexture __thicknessTexture;

        public async ValueTask<BaseTexture> get_thicknessTexture()
        {
            if (__thicknessTexture == null)
            {
                __thicknessTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "thicknessTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __thicknessTexture;
        }

        public ValueTask set_thicknessTexture(BaseTexture value)
        {
            __thicknessTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "thicknessTexture", value);
        }

        private BaseTexture __refractionTexture;

        public async ValueTask<BaseTexture> get_refractionTexture()
        {
            if (__refractionTexture == null)
            {
                __refractionTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "refractionTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __refractionTexture;
        }

        public ValueTask set_refractionTexture(BaseTexture value)
        {
            __refractionTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "refractionTexture", value);
        }

        public async ValueTask<decimal> get_indexOfRefraction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexOfRefraction");
        }

        public ValueTask set_indexOfRefraction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "indexOfRefraction", value);
        }

        public async ValueTask<bool> get_invertRefractionY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "invertRefractionY");
        }

        public ValueTask set_invertRefractionY(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "invertRefractionY", value);
        }

        public async ValueTask<bool> get_linkRefractionWithTransparency()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "linkRefractionWithTransparency"
            );
        }

        public ValueTask set_linkRefractionWithTransparency(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "linkRefractionWithTransparency",
                value
            );
        }

        public async ValueTask<decimal> get_minimumThickness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "minimumThickness");
        }

        public ValueTask set_minimumThickness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "minimumThickness", value);
        }

        public async ValueTask<decimal> get_maximumThickness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maximumThickness");
        }

        public ValueTask set_maximumThickness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maximumThickness", value);
        }

        public async ValueTask<bool> get_useThicknessAsDepth()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useThicknessAsDepth");
        }

        public ValueTask set_useThicknessAsDepth(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useThicknessAsDepth", value);
        }

        private Color3 __tintColor;

        public async ValueTask<Color3> get_tintColor()
        {
            if (__tintColor == null)
            {
                __tintColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "tintColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __tintColor;
        }

        public ValueTask set_tintColor(Color3 value)
        {
            __tintColor = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "tintColor", value);
        }

        public async ValueTask<decimal> get_tintColorAtDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "tintColorAtDistance"
            );
        }

        public ValueTask set_tintColorAtDistance(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "tintColorAtDistance", value);
        }

        public async ValueTask<decimal> get_dispersion()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "dispersion");
        }

        public ValueTask set_dispersion(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "dispersion", value);
        }

        private Color3 __diffusionDistance;

        public async ValueTask<Color3> get_diffusionDistance()
        {
            if (__diffusionDistance == null)
            {
                __diffusionDistance = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "diffusionDistance",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __diffusionDistance;
        }

        public ValueTask set_diffusionDistance(Color3 value)
        {
            __diffusionDistance = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "diffusionDistance", value);
        }

        public async ValueTask<bool> get_useMaskFromThicknessTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useMaskFromThicknessTexture"
            );
        }

        public ValueTask set_useMaskFromThicknessTexture(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useMaskFromThicknessTexture",
                value
            );
        }

        private BaseTexture __refractionIntensityTexture;

        public async ValueTask<BaseTexture> get_refractionIntensityTexture()
        {
            if (__refractionIntensityTexture == null)
            {
                __refractionIntensityTexture =
                    await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                        this.___guid,
                        "refractionIntensityTexture",
                        (entity) =>
                        {
                            return new BaseTexture() { ___guid = entity.___guid };
                        }
                    );
            }
            return __refractionIntensityTexture;
        }

        public ValueTask set_refractionIntensityTexture(BaseTexture value)
        {
            __refractionIntensityTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "refractionIntensityTexture", value);
        }

        private BaseTexture __translucencyIntensityTexture;

        public async ValueTask<BaseTexture> get_translucencyIntensityTexture()
        {
            if (__translucencyIntensityTexture == null)
            {
                __translucencyIntensityTexture =
                    await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                        this.___guid,
                        "translucencyIntensityTexture",
                        (entity) =>
                        {
                            return new BaseTexture() { ___guid = entity.___guid };
                        }
                    );
            }
            return __translucencyIntensityTexture;
        }

        public ValueTask set_translucencyIntensityTexture(BaseTexture value)
        {
            __translucencyIntensityTexture = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "translucencyIntensityTexture",
                value
            );
        }

        private Color3 __translucencyColor;

        public async ValueTask<Color3> get_translucencyColor()
        {
            if (__translucencyColor == null)
            {
                __translucencyColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "translucencyColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __translucencyColor;
        }

        public ValueTask set_translucencyColor(Color3 value)
        {
            __translucencyColor = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "translucencyColor", value);
        }

        private BaseTexture __translucencyColorTexture;

        public async ValueTask<BaseTexture> get_translucencyColorTexture()
        {
            if (__translucencyColorTexture == null)
            {
                __translucencyColorTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "translucencyColorTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __translucencyColorTexture;
        }

        public ValueTask set_translucencyColorTexture(BaseTexture value)
        {
            __translucencyColorTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "translucencyColorTexture", value);
        }

        public async ValueTask<bool> get_useGltfStyleTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useGltfStyleTextures");
        }

        public ValueTask set_useGltfStyleTextures(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useGltfStyleTextures", value);
        }
        #endregion

        #region Constructor
        public PBRSubSurfaceConfiguration()
            : base() { }

        public PBRSubSurfaceConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRSubSurfaceConfiguration> NewPBRSubSurfaceConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRSubSurfaceConfiguration" },
                material,
                addToPluginList
            );

            return new PBRSubSurfaceConfiguration(entity);
        }

        public static async ValueTask<PBRSubSurfaceConfiguration> NewPBRSubSurfaceConfiguration(
            Material material,
            string name,
            decimal priority,
            object defines = null,
            System.Nullable<bool> addToPluginList = null,
            System.Nullable<bool> enable = null,
            System.Nullable<bool> resolveIncludes = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRSubSurfaceConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new PBRSubSurfaceConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(
            MaterialSubSurfaceDefines defines,
            Scene scene
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public async ValueTask prepareDefinesBeforeAttributes(
            MaterialSubSurfaceDefines defines,
            Scene scene
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefinesBeforeAttributes" },
                    defines,
                    scene
                }
            );
        }

        public async ValueTask hardBindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            Engine engine,
            SubMesh subMesh
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "hardBindForSubMesh" },
                    uniformBuffer,
                    scene,
                    engine,
                    subMesh
                }
            );
        }

        public async ValueTask bindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            Engine engine,
            SubMesh subMesh
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" },
                    uniformBuffer,
                    scene,
                    engine,
                    subMesh
                }
            );
        }

        public async ValueTask fillRenderTargetTextures(
            SmartArray<RenderTargetTexture> renderTargets
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillRenderTargetTextures" },
                    renderTargets
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
            );
        }

        public async ValueTask<bool> hasRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasRenderTargetTextures" } }
            );
        }

        public async ValueTask getActiveTextures(BaseTexture[] activeTextures)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getActiveTextures" }, activeTextures }
            );
        }

        public async ValueTask getAnimatables(IAnimatable[] animatables)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getAnimatables" }, animatables }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, forceDisposeTextures }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<decimal> addFallbacks(
            MaterialSubSurfaceDefines defines,
            EffectFallbacks fallbacks,
            decimal currentRank
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "addFallbacks" },
                    defines,
                    fallbacks,
                    currentRank
                }
            );
        }

        public async ValueTask getSamplers(string[] samplers)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getSamplers" }, samplers }
            );
        }

        public async ValueTask<CachedEntity> getUniforms()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getUniforms" } }
            );
        }
        #endregion
    }
}
