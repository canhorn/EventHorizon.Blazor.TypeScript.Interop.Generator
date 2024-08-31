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

    [JsonConverter(typeof(CachedEntityConverter<PBRIridescenceConfiguration>))]
    public class PBRIridescenceConfiguration : MaterialPluginBase
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
        #endregion

        #region Constructor
        public PBRIridescenceConfiguration()
            : base() { }

        public PBRIridescenceConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<PBRIridescenceConfiguration> NewPBRIridescenceConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRIridescenceConfiguration" },
                material,
                addToPluginList
            );

            return new PBRIridescenceConfiguration(entity);
        }

        public static async ValueTask<PBRIridescenceConfiguration> NewPBRIridescenceConfiguration(
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
                new string[] { "BABYLON", "PBRIridescenceConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new PBRIridescenceConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(
            MaterialIridescenceDefines defines,
            Scene scene
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public async ValueTask prepareDefinesBeforeAttributes(
            MaterialIridescenceDefines defines,
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
            MaterialIridescenceDefines defines,
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
