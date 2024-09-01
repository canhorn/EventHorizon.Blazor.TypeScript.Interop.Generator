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

        public decimal minimumThickness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "minimumThickness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "minimumThickness", value);
            }
        }

        public decimal maximumThickness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maximumThickness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "maximumThickness", value);
            }
        }

        public decimal indexOfRefraction
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "indexOfRefraction");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "indexOfRefraction", value);
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

        private BaseTexture __thicknessTexture;
        public BaseTexture thicknessTexture
        {
            get
            {
                if (__thicknessTexture == null)
                {
                    __thicknessTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __thicknessTexture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "thicknessTexture", value);
            }
        }
        #endregion

        #region Constructor
        public PBRIridescenceConfiguration()
            : base() { }

        public PBRIridescenceConfiguration(ICachedEntity entity)
            : base(entity) { }

        public PBRIridescenceConfiguration(
            PBRBaseMaterial material,
            System.Nullable<bool> addToPluginList = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PBRIridescenceConfiguration" },
                material,
                addToPluginList
            );
            ___guid = entity.___guid;
        }

        public PBRIridescenceConfiguration(
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
                new string[] { "BABYLON", "PBRIridescenceConfiguration" },
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
        public bool isReadyForSubMesh(MaterialIridescenceDefines defines, Scene scene)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene }
            );
        }

        public void prepareDefinesBeforeAttributes(MaterialIridescenceDefines defines, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefinesBeforeAttributes" },
                    defines,
                    scene
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
            MaterialIridescenceDefines defines,
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
        #endregion
    }
}
