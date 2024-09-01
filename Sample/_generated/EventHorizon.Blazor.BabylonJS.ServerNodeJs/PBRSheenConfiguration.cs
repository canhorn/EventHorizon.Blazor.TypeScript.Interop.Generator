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

        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled");
        }

        public ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
        }

        public async ValueTask<bool> get_linkSheenWithAlbedo()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "linkSheenWithAlbedo");
        }

        public ValueTask set_linkSheenWithAlbedo(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "linkSheenWithAlbedo", value);
        }

        public async ValueTask<decimal> get_intensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "intensity");
        }

        public ValueTask set_intensity(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "intensity", value);
        }

        private Color3 __color;

        public async ValueTask<Color3> get_color()
        {
            if (__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<Color3>(
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

        public ValueTask set_color(Color3 value)
        {
            __color = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "color", value);
        }

        private BaseTexture __texture;

        public async ValueTask<BaseTexture> get_texture()
        {
            if (__texture == null)
            {
                __texture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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

        public ValueTask set_texture(BaseTexture value)
        {
            __texture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "texture", value);
        }

        public async ValueTask<bool> get_useRoughnessFromMainTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useRoughnessFromMainTexture"
            );
        }

        public ValueTask set_useRoughnessFromMainTexture(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useRoughnessFromMainTexture",
                value
            );
        }

        public async ValueTask<decimal> get_roughness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "roughness");
        }

        public ValueTask set_roughness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "roughness", value);
        }

        private BaseTexture __textureRoughness;

        public async ValueTask<BaseTexture> get_textureRoughness()
        {
            if (__textureRoughness == null)
            {
                __textureRoughness = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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

        public ValueTask set_textureRoughness(BaseTexture value)
        {
            __textureRoughness = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "textureRoughness", value);
        }

        public async ValueTask<bool> get_albedoScaling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "albedoScaling");
        }

        public ValueTask set_albedoScaling(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "albedoScaling", value);
        }
        #endregion

        #region Constructor
        public PBRSheenConfiguration()
            : base() { }

        public PBRSheenConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRSheenConfiguration> NewPBRSheenConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRSheenConfiguration" },
                material,
                addToPluginList
            );

            return new PBRSheenConfiguration(entity);
        }

        public static async ValueTask<PBRSheenConfiguration> NewPBRSheenConfiguration(
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
                new string[] { "BABYLON", "PBRSheenConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new PBRSheenConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(MaterialSheenDefines defines, Scene scene)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public async ValueTask prepareDefinesBeforeAttributes(
            MaterialSheenDefines defines,
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

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
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
            MaterialSheenDefines defines,
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
