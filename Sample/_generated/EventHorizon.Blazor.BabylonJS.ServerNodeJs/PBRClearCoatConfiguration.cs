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

        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled");
        }

        public ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
        }

        public async ValueTask<decimal> get_intensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "intensity");
        }

        public ValueTask set_intensity(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "intensity", value);
        }

        public async ValueTask<decimal> get_roughness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "roughness");
        }

        public ValueTask set_roughness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "roughness", value);
        }

        public async ValueTask<decimal> get_indexOfRefraction()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexOfRefraction");
        }

        public ValueTask set_indexOfRefraction(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "indexOfRefraction", value);
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

        public async ValueTask<bool> get_remapF0OnInterfaceChange()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "remapF0OnInterfaceChange"
            );
        }

        public ValueTask set_remapF0OnInterfaceChange(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "remapF0OnInterfaceChange", value);
        }

        private BaseTexture __bumpTexture;

        public async ValueTask<BaseTexture> get_bumpTexture()
        {
            if (__bumpTexture == null)
            {
                __bumpTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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

        public ValueTask set_bumpTexture(BaseTexture value)
        {
            __bumpTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "bumpTexture", value);
        }

        public async ValueTask<bool> get_isTintEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isTintEnabled");
        }

        public ValueTask set_isTintEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isTintEnabled", value);
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

        public async ValueTask<decimal> get_tintThickness()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "tintThickness");
        }

        public ValueTask set_tintThickness(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "tintThickness", value);
        }

        private BaseTexture __tintTexture;

        public async ValueTask<BaseTexture> get_tintTexture()
        {
            if (__tintTexture == null)
            {
                __tintTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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

        public ValueTask set_tintTexture(BaseTexture value)
        {
            __tintTexture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "tintTexture", value);
        }
        #endregion

        #region Constructor
        public PBRClearCoatConfiguration()
            : base() { }

        public PBRClearCoatConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRClearCoatConfiguration> NewPBRClearCoatConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRClearCoatConfiguration" },
                material,
                addToPluginList
            );

            return new PBRClearCoatConfiguration(entity);
        }

        public static async ValueTask<PBRClearCoatConfiguration> NewPBRClearCoatConfiguration(
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
                new string[] { "BABYLON", "PBRClearCoatConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new PBRClearCoatConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(
            MaterialClearCoatDefines defines,
            Scene scene,
            Engine engine
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" },
                    defines,
                    scene,
                    engine
                }
            );
        }

        public async ValueTask prepareDefinesBeforeAttributes(
            MaterialClearCoatDefines defines,
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
            MaterialClearCoatDefines defines,
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
