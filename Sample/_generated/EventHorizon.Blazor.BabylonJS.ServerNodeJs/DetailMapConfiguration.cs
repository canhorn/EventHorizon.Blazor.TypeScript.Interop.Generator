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

    [JsonConverter(typeof(CachedEntityConverter<DetailMapConfiguration>))]
    public class DetailMapConfiguration : MaterialPluginBase
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

        public async ValueTask<decimal> get_diffuseBlendLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "diffuseBlendLevel");
        }

        public ValueTask set_diffuseBlendLevel(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "diffuseBlendLevel", value);
        }

        public async ValueTask<decimal> get_roughnessBlendLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "roughnessBlendLevel"
            );
        }

        public ValueTask set_roughnessBlendLevel(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "roughnessBlendLevel", value);
        }

        public async ValueTask<decimal> get_bumpLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "bumpLevel");
        }

        public ValueTask set_bumpLevel(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "bumpLevel", value);
        }

        public async ValueTask<decimal> get_normalBlendMethod()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "normalBlendMethod");
        }

        public ValueTask set_normalBlendMethod(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "normalBlendMethod", value);
        }

        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled");
        }

        public ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
        }
        #endregion

        #region Constructor
        public DetailMapConfiguration()
            : base() { }

        public DetailMapConfiguration(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<DetailMapConfiguration> NewDetailMapConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DetailMapConfiguration" },
                material,
                addToPluginList
            );

            return new DetailMapConfiguration(entity);
        }

        public static async ValueTask<DetailMapConfiguration> NewDetailMapConfiguration(
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
                new string[] { "BABYLON", "DetailMapConfiguration" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new DetailMapConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(
            MaterialDetailMapDefines defines,
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

        public async ValueTask prepareDefines(MaterialDetailMapDefines defines, Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepareDefines" }, defines, scene }
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
