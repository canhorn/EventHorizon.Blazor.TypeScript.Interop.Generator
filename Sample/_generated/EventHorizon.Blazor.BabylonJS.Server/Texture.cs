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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Texture>))]
    public class Texture : BaseTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<bool> get_SerializeBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Texture.SerializeBuffers"
                );
        }
        public static ValueTask set_SerializeBuffers(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Texture.SerializeBuffers",
                    value
                );
        }

        
        public static async ValueTask<bool> get_ForceSerializeBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Texture.ForceSerializeBuffers"
                );
        }
        public static ValueTask set_ForceSerializeBuffers(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Texture.ForceSerializeBuffers",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_SAMPLINGMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_SAMPLINGMODE"
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_NEAREST_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_NEAREST_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_BILINEAR_SAMPLINGMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.BILINEAR_SAMPLINGMODE"
                );
        }

        
        public static async ValueTask<decimal> get_LINEAR_LINEAR_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_LINEAR_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_TRILINEAR_SAMPLINGMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.TRILINEAR_SAMPLINGMODE"
                );
        }

        
        public static async ValueTask<decimal> get_LINEAR_LINEAR_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_LINEAR_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_NEAREST_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_NEAREST_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_LINEAR_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_LINEAR_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_LINEAR_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_LINEAR_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_LINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_NEAREST_NEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.NEAREST_NEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_LINEAR_NEAREST_MIPNEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_NEAREST_MIPNEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_LINEAR_NEAREST_MIPLINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_NEAREST_MIPLINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_LINEAR_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_LINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_LINEAR_NEAREST()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.LINEAR_NEAREST"
                );
        }

        
        public static async ValueTask<decimal> get_EXPLICIT_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.EXPLICIT_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_SPHERICAL_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.SPHERICAL_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_PLANAR_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.PLANAR_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_CUBIC_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.CUBIC_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_PROJECTION_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.PROJECTION_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_SKYBOX_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.SKYBOX_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_INVCUBIC_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.INVCUBIC_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_EQUIRECTANGULAR_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.EQUIRECTANGULAR_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_FIXED_EQUIRECTANGULAR_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.FIXED_EQUIRECTANGULAR_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_FIXED_EQUIRECTANGULAR_MIRRORED_MODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.FIXED_EQUIRECTANGULAR_MIRRORED_MODE"
                );
        }

        
        public static async ValueTask<decimal> get_CLAMP_ADDRESSMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.CLAMP_ADDRESSMODE"
                );
        }

        
        public static async ValueTask<decimal> get_WRAP_ADDRESSMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.WRAP_ADDRESSMODE"
                );
        }

        
        public static async ValueTask<decimal> get_MIRROR_ADDRESSMODE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Texture.MIRROR_ADDRESSMODE"
                );
        }

        
        public static async ValueTask<bool> get_UseSerializedUrlIfAny()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Texture.UseSerializedUrlIfAny"
                );
        }
        public static ValueTask set_UseSerializedUrlIfAny(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Texture.UseSerializedUrlIfAny",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<BaseTexture> Parse(object parsedTexture, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Texture", "Parse" }, parsedTexture, scene, rootUrl
                }
            );
        }

        public static async ValueTask<Texture> CreateFromBase64String(string data, string name, Scene scene, System.Nullable<bool> noMipmap = null, System.Nullable<bool> invertY = null, System.Nullable<decimal> samplingMode = null, ActionCallback onLoad = null, ActionCallback onError = null, System.Nullable<decimal> format = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Texture", "CreateFromBase64String" }, data, name, scene, noMipmap, invertY, samplingMode, onLoad, onError, format
                }
            );
        }

        public static async ValueTask<Texture> LoadFromDataString(string name, object buffer, Scene scene, System.Nullable<bool> deleteBuffer = null, System.Nullable<bool> noMipmap = null, System.Nullable<bool> invertY = null, System.Nullable<decimal> samplingMode = null, ActionCallback onLoad = null, ActionCallback<string, CachedEntity> onError = null, System.Nullable<decimal> format = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Texture", "LoadFromDataString" }, name, buffer, scene, deleteBuffer, noMipmap, invertY, samplingMode, onLoad, onError, format
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_noMipmap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noMipmap"
                );
        }

        
        public async ValueTask<string> get_mimeType()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "mimeType"
                );
        }

        
        public async ValueTask<bool> get_isBlocking()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocking"
                );
        }
        public ValueTask set_isBlocking(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBlocking",
                    value
                );
        }

        
        public async ValueTask<decimal> get_samplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samplingMode"
                );
        }

        
        public async ValueTask<bool> get_invertY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertY"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_url()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "url"
                );
        }
        public ValueTask set_url(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "url",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uOffset"
                );
        }
        public ValueTask set_uOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vOffset"
                );
        }
        public ValueTask set_vOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uScale"
                );
        }
        public ValueTask set_uScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vScale"
                );
        }
        public ValueTask set_vScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uAng()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uAng"
                );
        }
        public ValueTask set_uAng(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uAng",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vAng()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vAng"
                );
        }
        public ValueTask set_vAng(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vAng",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wAng()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wAng"
                );
        }
        public ValueTask set_wAng(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wAng",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uRotationCenter()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uRotationCenter"
                );
        }
        public ValueTask set_uRotationCenter(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uRotationCenter",
                    value
                );
        }

        
        public async ValueTask<decimal> get_vRotationCenter()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "vRotationCenter"
                );
        }
        public ValueTask set_vRotationCenter(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vRotationCenter",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wRotationCenter()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wRotationCenter"
                );
        }
        public ValueTask set_wRotationCenter(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wRotationCenter",
                    value
                );
        }

        
        public async ValueTask<bool> get_homogeneousRotationInUVTransform()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "homogeneousRotationInUVTransform"
                );
        }
        public ValueTask set_homogeneousRotationInUVTransform(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "homogeneousRotationInUVTransform",
                    value
                );
        }

        
        public async ValueTask<IInspectableCachedEntity[]> get_inspectableCustomProperties()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IInspectableCachedEntity>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_inspectableCustomProperties(IInspectableCachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
        }

        private Observable<Texture> __onLoadObservable;
        public async ValueTask<Observable<Texture>> get_onLoadObservable()
        {
            if(__onLoadObservable == null)
            {
                __onLoadObservable = await EventHorizonBlazorInterop.GetClass<Observable<Texture>>(
                    this.___guid,
                    "onLoadObservable",
                    (entity) =>
                    {
                        return new Observable<Texture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLoadObservable;
        }
        public ValueTask set_onLoadObservable(Observable<Texture> value)
        {
__onLoadObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLoadObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Texture() : base() { }

        public Texture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Texture> NewTexture(
            Scene sceneOrEngine, string url = null, System.Nullable<bool> noMipmap = null, System.Nullable<bool> invertY = null, System.Nullable<decimal> samplingMode = null, ActionCallback onLoad = null, ActionCallback<string, CachedEntity> onError = null, string buffer = null, System.Nullable<bool> deleteBuffer = null, System.Nullable<decimal> format = null, string mimeType = null, object loaderOptions = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Texture" },
                url, sceneOrEngine, noMipmap, invertY, samplingMode, onLoad, onError, buffer, deleteBuffer, format, mimeType, loaderOptions
            );

            return new Texture(entity);
        }
        #endregion

        #region Methods
        public async ValueTask updateURL(string url, string buffer = null, ActionCallback onLoad = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateURL" }, url, buffer, onLoad
                }
            );
        }

        public async ValueTask delayLoad()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "delayLoad" }
                }
            );
        }

        public async ValueTask<bool> checkTransformsAreIdentical(Texture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "checkTransformsAreIdentical" }, texture
                }
            );
        }

        public async ValueTask<Matrix> getTextureMatrix(System.Nullable<decimal> uBase = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTextureMatrix" }, uBase
                }
            );
        }

        public async ValueTask<Matrix> getReflectionTextureMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getReflectionTextureMatrix" }
                }
            );
        }

        public async ValueTask<Texture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Texture>(
                entity => new Texture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}