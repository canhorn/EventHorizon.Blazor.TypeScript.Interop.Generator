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

        public decimal diffuseBlendLevel
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "diffuseBlendLevel");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "diffuseBlendLevel", value);
            }
        }

        public decimal roughnessBlendLevel
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "roughnessBlendLevel");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "roughnessBlendLevel", value);
            }
        }

        public decimal bumpLevel
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "bumpLevel"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "bumpLevel", value);
            }
        }

        public decimal normalBlendMethod
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "normalBlendMethod");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "normalBlendMethod", value);
            }
        }

        public bool isEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
            }
        }
        #endregion

        #region Constructor
        public DetailMapConfiguration()
            : base() { }

        public DetailMapConfiguration(ICachedEntity entity)
            : base(entity) { }

        public DetailMapConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DetailMapConfiguration" },
                material,
                addToPluginList
            );
            ___guid = entity.___guid;
        }

        public DetailMapConfiguration(
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
                new string[] { "BABYLON", "DetailMapConfiguration" },
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
        public bool isReadyForSubMesh(MaterialDetailMapDefines defines, Scene scene, Engine engine)
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

        public void prepareDefines(MaterialDetailMapDefines defines, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepareDefines" }, defines, scene }
            );
        }

        public void bindForSubMesh(UniformBuffer uniformBuffer, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" },
                    uniformBuffer,
                    scene
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
