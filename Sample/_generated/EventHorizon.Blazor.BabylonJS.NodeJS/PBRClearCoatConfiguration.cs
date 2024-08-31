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

    [JsonConverter(typeof(CachedEntityConverter<PBRClearCoatConfiguration>))]
    public class PBRClearCoatConfiguration : MaterialPluginBase
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

        public bool isEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
            }
        }

        public decimal intensity
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "intensity"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "intensity", value);
            }
        }

        public decimal roughness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "roughness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "roughness", value);
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

        private BaseTexture __texture;
        public BaseTexture texture
        {
            get
            {
                if (__texture == null)
                {
                    __texture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                        this.___guid,
                        "texture",
                        (entity) =>
                        {
                            return new BaseTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __texture;
            }
            set
            {
                __texture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "texture", value);
            }
        }

        public bool useRoughnessFromMainTexture
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRoughnessFromMainTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useRoughnessFromMainTexture", value);
            }
        }

        private BaseTexture __textureRoughness;
        public BaseTexture textureRoughness
        {
            get
            {
                if (__textureRoughness == null)
                {
                    __textureRoughness = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                        this.___guid,
                        "textureRoughness",
                        (entity) =>
                        {
                            return new BaseTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __textureRoughness;
            }
            set
            {
                __textureRoughness = null;
                EventHorizonBlazorInterop.Set(this.___guid, "textureRoughness", value);
            }
        }

        public bool remapF0OnInterfaceChange
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "remapF0OnInterfaceChange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "remapF0OnInterfaceChange", value);
            }
        }

        private BaseTexture __bumpTexture;
        public BaseTexture bumpTexture
        {
            get
            {
                if (__bumpTexture == null)
                {
                    __bumpTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                        this.___guid,
                        "bumpTexture",
                        (entity) =>
                        {
                            return new BaseTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __bumpTexture;
            }
            set
            {
                __bumpTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "bumpTexture", value);
            }
        }

        public bool isTintEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTintEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isTintEnabled", value);
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

        public decimal tintThickness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "tintThickness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "tintThickness", value);
            }
        }

        private BaseTexture __tintTexture;
        public BaseTexture tintTexture
        {
            get
            {
                if (__tintTexture == null)
                {
                    __tintTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                        this.___guid,
                        "tintTexture",
                        (entity) =>
                        {
                            return new BaseTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __tintTexture;
            }
            set
            {
                __tintTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "tintTexture", value);
            }
        }
        #endregion

        #region Constructor
        public PBRClearCoatConfiguration()
            : base() { }

        public PBRClearCoatConfiguration(ICachedEntity entity)
            : base(entity) { }

        public PBRClearCoatConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRClearCoatConfiguration" },
                material,
                addToPluginList
            );
            ___guid = entity.___guid;
        }

        public PBRClearCoatConfiguration(
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
                new string[] { "BABYLON", "PBRClearCoatConfiguration" },
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
        public bool isReadyForSubMesh(MaterialClearCoatDefines defines, Scene scene, Engine engine)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" },
                    defines,
                    scene,
                    engine
                }
            );
        }

        public void prepareDefinesBeforeAttributes(MaterialClearCoatDefines defines, Scene scene)
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

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
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
            MaterialClearCoatDefines defines,
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
