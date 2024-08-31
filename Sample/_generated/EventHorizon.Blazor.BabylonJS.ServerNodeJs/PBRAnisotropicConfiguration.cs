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

    [JsonConverter(typeof(CachedEntityConverter<PBRAnisotropicConfiguration>))]
    public class PBRAnisotropicConfiguration : MaterialPluginBase
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<decimal> get_angle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "angle");
        }

        public ValueTask set_angle(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "angle", value);
        }
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

        private Vector2 __direction;

        public async ValueTask<Vector2> get_direction()
        {
            if (__direction == null)
            {
                __direction = await EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
        }

        public ValueTask set_direction(Vector2 value)
        {
            __direction = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "direction", value);
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

        public async ValueTask<bool> get_legacy()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "legacy");
        }

        public ValueTask set_legacy(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "legacy", value);
        }
        #endregion

        #region Constructor
        public PBRAnisotropicConfiguration()
            : base() { }

        public PBRAnisotropicConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRAnisotropicConfiguration> NewPBRAnisotropicConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRAnisotropicConfiguration" },
                material,
                addToPluginList
            );

            return new PBRAnisotropicConfiguration(entity);
        }

        public static async ValueTask<PBRAnisotropicConfiguration> NewPBRAnisotropicConfiguration(
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
                new string[] { "BABYLON", "PBRAnisotropicConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new PBRAnisotropicConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(
            MaterialAnisotropicDefines defines,
            Scene scene
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public async ValueTask prepareDefinesBeforeAttributes(
            MaterialAnisotropicDefines defines,
            Scene scene,
            AbstractMesh mesh
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefinesBeforeAttributes" },
                    defines,
                    scene,
                    mesh
                }
            );
        }

        public async ValueTask bindForSubMesh(UniformBuffer uniformBuffer, Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" },
                    uniformBuffer,
                    scene
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
            MaterialAnisotropicDefines defines,
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

        public async ValueTask parse(object source, Scene scene, string rootUrl)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, source, scene, rootUrl }
            );
        }
        #endregion
    }
}
