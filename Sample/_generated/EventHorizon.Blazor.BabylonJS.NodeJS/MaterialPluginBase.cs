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

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public decimal priority
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "priority"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "priority", value);
            }
        }

        public bool resolveIncludes
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "resolveIncludes"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "resolveIncludes", value);
            }
        }

        public bool registerForExtraEvents
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "registerForExtraEvents");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "registerForExtraEvents", value);
            }
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

        public MaterialPluginBase(
            Material material,
            string name,
            decimal priority,
            object defines = null,
            System.Nullable<bool> addToPluginList = null,
            System.Nullable<bool> enable = null,
            System.Nullable<bool> resolveIncludes = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MaterialPluginBase" },
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
        public void markAllDefinesAsDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAllDefinesAsDirty" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public bool isReadyForSubMesh(
            MaterialDefines defines,
            Scene scene,
            AbstractEngine engine,
            SubMesh subMesh
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
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

        public void hardBindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            AbstractEngine engine,
            SubMesh subMesh
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void bindForSubMesh(
            UniformBuffer uniformBuffer,
            Scene scene,
            AbstractEngine engine,
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

        public void dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, forceDisposeTextures }
            );
        }

        public CachedEntity getCustomCode(string shaderType)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getCustomCode" }, shaderType }
            );
        }

        public void collectDefines(object defines)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "collectDefines" }, defines }
            );
        }

        public void prepareDefinesBeforeAttributes(
            MaterialDefines defines,
            Scene scene,
            AbstractMesh mesh
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefinesBeforeAttributes" },
                    defines,
                    scene,
                    mesh
                }
            );
        }

        public void prepareDefines(MaterialDefines defines, Scene scene, AbstractMesh mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" },
                    defines,
                    scene,
                    mesh
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTexture" }, texture }
            );
        }

        public bool hasRenderTargetTextures()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasRenderTargetTextures" } }
            );
        }

        public void fillRenderTargetTextures(SmartArray<RenderTargetTexture> renderTargets)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillRenderTargetTextures" },
                    renderTargets
                }
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

        public decimal addFallbacks(
            MaterialDefines defines,
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

        public void getAttributes(string[] attributes, Scene scene, AbstractMesh mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" },
                    attributes,
                    scene,
                    mesh
                }
            );
        }

        public void getUniformBuffersNames(string[] ubos)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getUniformBuffersNames" }, ubos }
            );
        }

        public CachedEntity getUniforms()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getUniforms" } }
            );
        }

        public void copyTo(MaterialPluginBase plugin)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "copyTo" }, plugin }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public void parse(object source, Scene scene, string rootUrl)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, source, scene, rootUrl }
            );
        }
        #endregion
    }
}
