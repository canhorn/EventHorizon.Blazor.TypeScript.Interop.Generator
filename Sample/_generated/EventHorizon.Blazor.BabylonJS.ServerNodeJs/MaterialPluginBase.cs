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

    [JsonConverter(typeof(CachedEntityConverter<MaterialPluginBase>))]
    public class MaterialPluginBase : CachedEntityObject
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

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        public async ValueTask<decimal> get_priority()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "priority");
        }

        public ValueTask set_priority(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "priority", value);
        }

        public async ValueTask<bool> get_resolveIncludes()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "resolveIncludes");
        }

        public ValueTask set_resolveIncludes(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "resolveIncludes", value);
        }

        public async ValueTask<bool> get_registerForExtraEvents()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "registerForExtraEvents"
            );
        }

        public ValueTask set_registerForExtraEvents(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "registerForExtraEvents", value);
        }
        #endregion

        #region Constructor
        public MaterialPluginBase()
            : base() { }

        public MaterialPluginBase(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<MaterialPluginBase> NewMaterialPluginBase(
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
                new string[] { "BABYLON", "MaterialPluginBase" },
                material,
                name,
                priority,
                defines,
                addToPluginList,
                enable,
                resolveIncludes
            );

            return new MaterialPluginBase(entity);
        }
        #endregion

        #region Methods
        public async ValueTask markAllDefinesAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAllDefinesAsDirty" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(
            MaterialDefines defines,
            Scene scene,
            AbstractEngine engine,
            SubMesh subMesh
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" },
                    defines,
                    scene,
                    engine,
                    subMesh
                }
            );
        }

        public async ValueTask hardBindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            AbstractEngine engine,
            SubMesh subMesh
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask bindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            AbstractEngine engine,
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

        public async ValueTask dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, forceDisposeTextures }
            );
        }

        public async ValueTask<CachedEntity> getCustomCode(string shaderType)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getCustomCode" }, shaderType }
            );
        }

        public async ValueTask collectDefines(object defines)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "collectDefines" }, defines }
            );
        }

        public async ValueTask prepareDefinesBeforeAttributes(
            MaterialDefines defines,
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

        public async ValueTask prepareDefines(
            MaterialDefines defines,
            Scene scene,
            AbstractMesh mesh
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" },
                    defines,
                    scene,
                    mesh
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
            );
        }

        public async ValueTask<bool> hasRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasRenderTargetTextures" } }
            );
        }

        public async ValueTask fillRenderTargetTextures(
            SmartArray<RenderTargetTexture> renderTargets
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillRenderTargetTextures" },
                    renderTargets
                }
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

        public async ValueTask<decimal> addFallbacks(
            MaterialDefines defines,
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

        public async ValueTask getAttributes(string[] attributes, Scene scene, AbstractMesh mesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" },
                    attributes,
                    scene,
                    mesh
                }
            );
        }

        public async ValueTask getUniformBuffersNames(string[] ubos)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getUniformBuffersNames" }, ubos }
            );
        }

        public async ValueTask<CachedEntity> getUniforms()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getUniforms" } }
            );
        }

        public async ValueTask copyTo(MaterialPluginBase plugin)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "copyTo" }, plugin }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
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
