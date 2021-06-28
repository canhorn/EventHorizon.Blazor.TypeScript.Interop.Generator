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
    public class DetailMapConfiguration : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddUniforms(string[] uniforms)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "DetailMapConfiguration", "AddUniforms" }, uniforms
                }
            );
        }

        public static void AddSamplers(string[] samplers)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "DetailMapConfiguration", "AddSamplers" }, samplers
                }
            );
        }

        public static void PrepareUniformBuffer(UniformBuffer uniformBuffer)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
        public BaseTexture texture
        {
            get
            {
            if(__texture == null)
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public decimal diffuseBlendLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "diffuseBlendLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuseBlendLevel",
                    value
                );
            }
        }

        
        public decimal roughnessBlendLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "roughnessBlendLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "roughnessBlendLevel",
                    value
                );
            }
        }

        
        public decimal bumpLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bumpLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bumpLevel",
                    value
                );
            }
        }

        
        public decimal normalBlendMethod
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "normalBlendMethod"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalBlendMethod",
                    value
                );
            }
        }

        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
            }
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

        public DetailMapConfiguration(
            ActionCallback markAllSubMeshesAsTexturesDirty
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DetailMapConfiguration" },
                markAllSubMeshesAsTexturesDirty
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReadyForSubMesh(IMaterialDetailMapDefines defines, Scene scene)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, defines, scene
                }
            );
        }

        public void prepareDefines(IMaterialDetailMapDefines defines, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, scene
                }
            );
        }

        public void bindForSubMesh(UniformBuffer uniformBuffer, Scene scene, bool isFrozen)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" }, uniformBuffer, scene, isFrozen
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public void getActiveTextures(BaseTexture[] activeTextures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }, activeTextures
                }
            );
        }

        public void getAnimatables(IAnimatable[] animatables)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }, animatables
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeTextures
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void copyTo(DetailMapConfiguration detailMap)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyTo" }, detailMap
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void parse(object source, Scene scene, string rootUrl)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parse" }, source, scene, rootUrl
                }
            );
        }
        #endregion
    }
}