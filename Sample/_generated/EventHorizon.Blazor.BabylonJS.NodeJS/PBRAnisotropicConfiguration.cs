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

        public decimal angle
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "angle"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "angle", value);
            }
        }
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

        public decimal intensity
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "intensity"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "intensity", value);
            }
        }

        private Vector2 __direction;
        public Vector2 direction
        {
            get
            {
                if (__direction == null)
                {
                    __direction = EventHorizonBlazorInterop.GetClass<Vector2>(
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
            set
            {
                __direction = null;
                EventHorizonBlazorInterop.Set(this.___guid, "direction", value);
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

        public bool legacy
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "legacy"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "legacy", value);
            }
        }
        #endregion

        #region Constructor
        public PBRAnisotropicConfiguration()
            : base() { }

        public PBRAnisotropicConfiguration(ICachedEntity entity)
            : base(entity) { }

        public PBRAnisotropicConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRAnisotropicConfiguration" },
                material,
                addToPluginList
            );
            ___guid = entity.___guid;
        }

        public PBRAnisotropicConfiguration(
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
                new string[] { "BABYLON", "PBRAnisotropicConfiguration" },
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
        public bool isReadyForSubMesh(MaterialAnisotropicDefines defines, Scene scene)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public void prepareDefinesBeforeAttributes(
            MaterialAnisotropicDefines defines,
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

        public decimal addFallbacks(
            MaterialAnisotropicDefines defines,
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

        public void parse(object source, Scene scene, string rootUrl)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "parse" }, source, scene, rootUrl }
            );
        }
        #endregion
    }
}
