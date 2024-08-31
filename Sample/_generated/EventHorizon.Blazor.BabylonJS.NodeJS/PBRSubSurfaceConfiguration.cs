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
        public Color3 scatteringDiffusionProfile
        {
            get
            {
                if (__scatteringDiffusionProfile == null)
                {
                    __scatteringDiffusionProfile = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
                __scatteringDiffusionProfile = null;
                EventHorizonBlazorInterop.Set(this.___guid, "scatteringDiffusionProfile", value);
            }
        }

        public decimal volumeIndexOfRefraction
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "volumeIndexOfRefraction"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "volumeIndexOfRefraction", value);
            }
        }

        public bool disableAlphaBlending
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableAlphaBlending");
            }
        }
        #endregion

        #region Properties

        public bool isRefractionEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isRefractionEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isRefractionEnabled", value);
            }
        }

        public bool isTranslucencyEnabled
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTranslucencyEnabled");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isTranslucencyEnabled", value);
            }
        }

        public bool isDispersionEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDispersionEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isDispersionEnabled", value);
            }
        }

        public bool isScatteringEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isScatteringEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isScatteringEnabled", value);
            }
        }

        public decimal refractionIntensity
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "refractionIntensity");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "refractionIntensity", value);
            }
        }

        public decimal translucencyIntensity
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "translucencyIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "translucencyIntensity", value);
            }
        }

        public bool useAlbedoToTintRefraction
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlbedoToTintRefraction"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useAlbedoToTintRefraction", value);
            }
        }

        public bool useAlbedoToTintTranslucency
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlbedoToTintTranslucency"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useAlbedoToTintTranslucency", value);
            }
        }

        private BaseTexture __thicknessTexture;
        public BaseTexture thicknessTexture
        {
            get
            {
                if (__thicknessTexture == null)
                {
                    __thicknessTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __thicknessTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "thicknessTexture", value);
            }
        }

        private BaseTexture __refractionTexture;
        public BaseTexture refractionTexture
        {
            get
            {
                if (__refractionTexture == null)
                {
                    __refractionTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __refractionTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "refractionTexture", value);
            }
        }

        public decimal indexOfRefraction
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexOfRefraction");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "indexOfRefraction", value);
            }
        }

        public bool invertRefractionY
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "invertRefractionY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "invertRefractionY", value);
            }
        }

        public bool linkRefractionWithTransparency
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "linkRefractionWithTransparency"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linkRefractionWithTransparency",
                    value
                );
            }
        }

        public decimal minimumThickness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "minimumThickness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "minimumThickness", value);
            }
        }

        public decimal maximumThickness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maximumThickness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "maximumThickness", value);
            }
        }

        public bool useThicknessAsDepth
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useThicknessAsDepth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useThicknessAsDepth", value);
            }
        }

        private Color3 __tintColor;
        public Color3 tintColor
        {
            get
            {
                if (__tintColor == null)
                {
                    __tintColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
                __tintColor = null;
                EventHorizonBlazorInterop.Set(this.___guid, "tintColor", value);
            }
        }

        public decimal tintColorAtDistance
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "tintColorAtDistance");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "tintColorAtDistance", value);
            }
        }

        public decimal dispersion
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "dispersion"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "dispersion", value);
            }
        }

        private Color3 __diffusionDistance;
        public Color3 diffusionDistance
        {
            get
            {
                if (__diffusionDistance == null)
                {
                    __diffusionDistance = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
                __diffusionDistance = null;
                EventHorizonBlazorInterop.Set(this.___guid, "diffusionDistance", value);
            }
        }

        public bool useMaskFromThicknessTexture
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useMaskFromThicknessTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useMaskFromThicknessTexture", value);
            }
        }

        private BaseTexture __refractionIntensityTexture;
        public BaseTexture refractionIntensityTexture
        {
            get
            {
                if (__refractionIntensityTexture == null)
                {
                    __refractionIntensityTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __refractionIntensityTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "refractionIntensityTexture", value);
            }
        }

        private BaseTexture __translucencyIntensityTexture;
        public BaseTexture translucencyIntensityTexture
        {
            get
            {
                if (__translucencyIntensityTexture == null)
                {
                    __translucencyIntensityTexture =
                        EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __translucencyIntensityTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "translucencyIntensityTexture", value);
            }
        }

        private Color3 __translucencyColor;
        public Color3 translucencyColor
        {
            get
            {
                if (__translucencyColor == null)
                {
                    __translucencyColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
                __translucencyColor = null;
                EventHorizonBlazorInterop.Set(this.___guid, "translucencyColor", value);
            }
        }

        private BaseTexture __translucencyColorTexture;
        public BaseTexture translucencyColorTexture
        {
            get
            {
                if (__translucencyColorTexture == null)
                {
                    __translucencyColorTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __translucencyColorTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "translucencyColorTexture", value);
            }
        }

        public bool useGltfStyleTextures
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useGltfStyleTextures");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useGltfStyleTextures", value);
            }
        }
        #endregion

        #region Constructor
        public PBRSubSurfaceConfiguration()
            : base() { }

        public PBRSubSurfaceConfiguration(ICachedEntity entity)
            : base(entity) { }

        public PBRSubSurfaceConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRSubSurfaceConfiguration" },
                material,
                addToPluginList
            );
            ___guid = entity.___guid;
        }

        public PBRSubSurfaceConfiguration(
            Material material,
            string name,
            decimal priority,
            object defines = null,
            System.Nullable<bool> addToPluginList = null,
            System.Nullable<bool> enable = null,
            System.Nullable<bool> resolveIncludes = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRSubSurfaceConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReadyForSubMesh(MaterialSubSurfaceDefines defines, Scene scene)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public void prepareDefinesBeforeAttributes(MaterialSubSurfaceDefines defines, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefinesBeforeAttributes" },
                    defines,
                    scene
                }
            );
        }

        public void hardBindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            Engine engine,
            SubMesh subMesh
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void bindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            Engine engine,
            SubMesh subMesh
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void fillRenderTargetTextures(SmartArray<RenderTargetTexture> renderTargets)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillRenderTargetTextures" },
                    renderTargets
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
            );
        }

        public bool hasRenderTargetTextures()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasRenderTargetTextures" } }
            );
        }

        public void getActiveTextures(BaseTexture[] activeTextures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getActiveTextures" }, activeTextures }
            );
        }

        public void getAnimatables(IAnimatable[] animatables)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getAnimatables" }, animatables }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, forceDisposeTextures }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public decimal addFallbacks(
            MaterialSubSurfaceDefines defines,
            EffectFallbacks fallbacks,
            decimal currentRank
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "addFallbacks" },
                    defines,
                    fallbacks,
                    currentRank
                }
            );
        }

        public void getSamplers(string[] samplers)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getSamplers" }, samplers }
            );
        }

        public CachedEntity getUniforms()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getUniforms" } }
            );
        }
        #endregion
    }
}
