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

    [JsonConverter(typeof(CachedEntityConverter<PBRSheenConfiguration>))]
    public class PBRSheenConfiguration : MaterialPluginBase
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

        public bool linkSheenWithAlbedo
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "linkSheenWithAlbedo"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "linkSheenWithAlbedo", value);
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

        private Color3 __color;
        public Color3 color
        {
            get
            {
                if (__color == null)
                {
                    __color = EventHorizonBlazorInterop.GetClass<Color3>(
                        this.___guid,
                        "color",
                        (entity) =>
                        {
                            return new Color3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __color;
            }
            set
            {
                __color = null;
                EventHorizonBlazorInterop.Set(this.___guid, "color", value);
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

        public decimal roughness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "roughness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "roughness", value);
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

        public bool albedoScaling
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "albedoScaling"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "albedoScaling", value);
            }
        }
        #endregion

        #region Constructor
        public PBRSheenConfiguration()
            : base() { }

        public PBRSheenConfiguration(ICachedEntity entity)
            : base(entity) { }

        public PBRSheenConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRSheenConfiguration" },
                material,
                addToPluginList
            );
            ___guid = entity.___guid;
        }

        public PBRSheenConfiguration(
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
                new string[] { "BABYLON", "PBRSheenConfiguration" },
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
        public bool isReadyForSubMesh(MaterialSheenDefines defines, Scene scene)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public void prepareDefinesBeforeAttributes(MaterialSheenDefines defines, Scene scene)
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
            MaterialSheenDefines defines,
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
