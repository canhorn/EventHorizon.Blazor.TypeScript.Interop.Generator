/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<DetailMapConfiguration>))]
    public class DetailMapConfiguration : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask AddUniforms(string[] uniforms)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "DetailMapConfiguration", "AddUniforms" }, uniforms
                }
            );
        }

        public static async ValueTask AddSamplers(string[] samplers)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "DetailMapConfiguration", "AddSamplers" }, samplers
                }
            );
        }

        public static async ValueTask PrepareUniformBuffer(UniformBuffer uniformBuffer)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "DetailMapConfiguration", "PrepareUniformBuffer" }, uniformBuffer
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private BaseTexture __texture;
        public async ValueTask<BaseTexture> get_texture()
        {
            if(__texture == null)
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
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
        }

        
        public async ValueTask<decimal> get_diffuseBlendLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "diffuseBlendLevel"
                );
        }
        public ValueTask set_diffuseBlendLevel(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuseBlendLevel",
                    value
                );
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

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roughnessBlendLevel",
                    value
                );
        }

        
        public async ValueTask<decimal> get_bumpLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bumpLevel"
                );
        }
        public ValueTask set_bumpLevel(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bumpLevel",
                    value
                );
        }

        
        public async ValueTask<decimal> get_normalBlendMethod()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "normalBlendMethod"
                );
        }
        public ValueTask set_normalBlendMethod(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalBlendMethod",
                    value
                );
        }

        
        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
        }
        public ValueTask set_isEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public DetailMapConfiguration() : base() { } 

        public DetailMapConfiguration(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<DetailMapConfiguration> NewDetailMapConfiguration(
            ActionCallback markAllSubMeshesAsTexturesDirty
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DetailMapConfiguration" },
                markAllSubMeshesAsTexturesDirty
            );

            return new DetailMapConfiguration(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReadyForSubMesh(IMaterialDetailMapDefines defines, Scene scene)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene
                }
            );
        }

        public async ValueTask prepareDefines(IMaterialDetailMapDefines defines, Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, scene
                }
            );
        }

        public async ValueTask bindForSubMesh(UniformBuffer uniformBuffer, Scene scene, bool isFrozen)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, uniformBuffer, scene, isFrozen
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public async ValueTask getActiveTextures(BaseTexture[] activeTextures)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveTextures" }, activeTextures
                }
            );
        }

        public async ValueTask getAnimatables(IAnimatable[] animatables)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getAnimatables" }, animatables
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeTextures
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask copyTo(DetailMapConfiguration detailMap)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "copyTo" }, detailMap
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public async ValueTask parse(object source, Scene scene, string rootUrl)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "parse" }, source, scene, rootUrl
                }
            );
        }
        #endregion
    }
}