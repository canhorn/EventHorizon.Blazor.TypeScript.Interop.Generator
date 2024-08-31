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

    [JsonConverter(typeof(CachedEntityConverter<PBRBaseMaterial>))]
    public class PBRBaseMaterial : PushMaterial
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal PBRMATERIAL_OPAQUE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.PBRMATERIAL_OPAQUE"
                );
            }
        }

        public static decimal PBRMATERIAL_ALPHATEST
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.PBRMATERIAL_ALPHATEST"
                );
            }
        }

        public static decimal PBRMATERIAL_ALPHABLEND
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.PBRMATERIAL_ALPHABLEND"
                );
            }
        }

        public static decimal PBRMATERIAL_ALPHATESTANDBLEND
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.PBRMATERIAL_ALPHATESTANDBLEND"
                );
            }
        }

        public static decimal DEFAULT_AO_ON_ANALYTICAL_LIGHTS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.DEFAULT_AO_ON_ANALYTICAL_LIGHTS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PBRBaseMaterial.DEFAULT_AO_ON_ANALYTICAL_LIGHTS",
                    value
                );
            }
        }

        public static decimal LIGHTFALLOFF_PHYSICAL
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.LIGHTFALLOFF_PHYSICAL"
                );
            }
        }

        public static decimal LIGHTFALLOFF_GLTF
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.LIGHTFALLOFF_GLTF"
                );
            }
        }

        public static decimal LIGHTFALLOFF_STANDARD
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "PBRBaseMaterial.LIGHTFALLOFF_STANDARD"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool realTimeFiltering
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "realTimeFiltering"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "realTimeFiltering", value);
            }
        }

        public decimal realTimeFilteringQuality
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "realTimeFilteringQuality"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "realTimeFilteringQuality", value);
            }
        }

        public bool canRenderToMRT
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "canRenderToMRT"); }
        }

        public bool hasRenderTargetTextures
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "hasRenderTargetTextures");
            }
        }

        public bool isPrePassCapable
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPrePassCapable"); }
        }
        #endregion

        #region Properties

        public decimal debugMode
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "debugMode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "debugMode", value);
            }
        }

        public decimal debugLimit
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "debugLimit"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "debugLimit", value);
            }
        }

        public decimal debugFactor
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "debugFactor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "debugFactor", value);
            }
        }

        private PBRClearCoatConfiguration __clearCoat;
        public PBRClearCoatConfiguration clearCoat
        {
            get
            {
                if (__clearCoat == null)
                {
                    __clearCoat = EventHorizonBlazorInterop.GetClass<PBRClearCoatConfiguration>(
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
        }

        private PBRIridescenceConfiguration __iridescence;
        public PBRIridescenceConfiguration iridescence
        {
            get
            {
                if (__iridescence == null)
                {
                    __iridescence = EventHorizonBlazorInterop.GetClass<PBRIridescenceConfiguration>(
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
        }

        private PBRAnisotropicConfiguration __anisotropy;
        public PBRAnisotropicConfiguration anisotropy
        {
            get
            {
                if (__anisotropy == null)
                {
                    __anisotropy = EventHorizonBlazorInterop.GetClass<PBRAnisotropicConfiguration>(
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
        }

        private PBRBRDFConfiguration __brdf;
        public PBRBRDFConfiguration brdf
        {
            get
            {
                if (__brdf == null)
                {
                    __brdf = EventHorizonBlazorInterop.GetClass<PBRBRDFConfiguration>(
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
        }

        private PBRSheenConfiguration __sheen;
        public PBRSheenConfiguration sheen
        {
            get
            {
                if (__sheen == null)
                {
                    __sheen = EventHorizonBlazorInterop.GetClass<PBRSheenConfiguration>(
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
        }

        private PBRSubSurfaceConfiguration __subSurface;
        public PBRSubSurfaceConfiguration subSurface
        {
            get
            {
                if (__subSurface == null)
                {
                    __subSurface = EventHorizonBlazorInterop.GetClass<PBRSubSurfaceConfiguration>(
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
        }

        private PrePassConfiguration __prePassConfiguration;
        public PrePassConfiguration prePassConfiguration
        {
            get
            {
                if (__prePassConfiguration == null)
                {
                    __prePassConfiguration =
                        EventHorizonBlazorInterop.GetClass<PrePassConfiguration>(
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
        }

        private DetailMapConfiguration __detailMap;
        public DetailMapConfiguration detailMap
        {
            get
            {
                if (__detailMap == null)
                {
                    __detailMap = EventHorizonBlazorInterop.GetClass<DetailMapConfiguration>(
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
        }
        #endregion

        #region Constructor
        public PBRBaseMaterial()
            : base() { }

        public PBRBaseMaterial(ICachedEntity entity)
            : base(entity) { }

        public PBRBaseMaterial(string name, Scene scene = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRBaseMaterial" },
                name,
                scene
            );
            ___guid = entity.___guid;
        }

        public PBRBaseMaterial(
            string name,
            Scene scene = null,
            System.Nullable<bool> storeEffectOnSubMeshes = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRBaseMaterial" },
                name,
                scene,
                storeEffectOnSubMeshes
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "needAlphaBlending" } }
            );
        }

        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "needAlphaTesting" } }
            );
        }

        public BaseTexture getAlphaTestTexture()
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAlphaTestTexture" } }
            );
        }

        public bool isReadyForSubMesh(
            AbstractMesh mesh,
            SubMesh subMesh,
            System.Nullable<bool> useInstances = null
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" },
                    mesh,
                    subMesh,
                    useInstances
                }
            );
        }

        public bool isMetallicWorkflow()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isMetallicWorkflow" } }
            );
        }

        public void forceCompilation(
            AbstractMesh mesh,
            ActionCallback<Material> onCompiled = null,
            IMaterialCompilationOptions options = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceCompilation" },
                    mesh,
                    onCompiled,
                    options
                }
            );
        }

        public void buildUniformLayout()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "buildUniformLayout" } }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" },
                    world,
                    mesh,
                    subMesh
                }
            );
        }

        public IAnimatableCachedEntity[] getAnimatables()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimatables" } }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getActiveTextures" } }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
            );
        }

        public bool setPrePassRenderer()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "setPrePassRenderer" } }
            );
        }

        public void dispose(
            System.Nullable<bool> forceDisposeEffect = null,
            System.Nullable<bool> forceDisposeTextures = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
