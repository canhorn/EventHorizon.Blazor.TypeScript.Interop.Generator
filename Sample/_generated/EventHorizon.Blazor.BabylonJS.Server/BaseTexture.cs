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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseTexture>))]
    public class BaseTexture : ThinTexture, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_DEFAULT_ANISOTROPIC_FILTERING_LEVEL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseTexture.DEFAULT_ANISOTROPIC_FILTERING_LEVEL"
                );
        }
        public static ValueTask set_DEFAULT_ANISOTROPIC_FILTERING_LEVEL(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseTexture.DEFAULT_ANISOTROPIC_FILTERING_LEVEL",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask WhenAllReady(BaseTexture[] textures, ActionCallback callback)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "BaseTexture", "WhenAllReady" }, textures, callback
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_hasAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasAlpha"
                );
        }
        public ValueTask set_hasAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasAlpha",
                    value
                );
        }

        
        public async ValueTask<decimal> get_coordinatesMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "coordinatesMode"
                );
        }
        public ValueTask set_coordinatesMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "coordinatesMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wrapU()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wrapU"
                );
        }
        public ValueTask set_wrapU(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapU",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wrapV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wrapV"
                );
        }
        public ValueTask set_wrapV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapV",
                    value
                );
        }

        
        public async ValueTask<bool> get_isCube()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isCube"
                );
        }
        public ValueTask set_isCube(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isCube",
                    value
                );
        }

        
        public async ValueTask<bool> get_is3D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "is3D"
                );
        }
        public ValueTask set_is3D(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "is3D",
                    value
                );
        }

        
        public async ValueTask<bool> get_is2DArray()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "is2DArray"
                );
        }
        public ValueTask set_is2DArray(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "is2DArray",
                    value
                );
        }

        
        public async ValueTask<bool> get_gammaSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "gammaSpace"
                );
        }
        public ValueTask set_gammaSpace(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gammaSpace",
                    value
                );
        }

        
        public async ValueTask<bool> get_isRGBD()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRGBD"
                );
        }
        public ValueTask set_isRGBD(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRGBD",
                    value
                );
        }

        
        public async ValueTask<bool> get_noMipmap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "noMipmap"
                );
        }

        
        public async ValueTask<decimal> get_lodGenerationOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lodGenerationOffset"
                );
        }
        public ValueTask set_lodGenerationOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lodGenerationOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lodGenerationScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lodGenerationScale"
                );
        }
        public ValueTask set_lodGenerationScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lodGenerationScale",
                    value
                );
        }

        
        public async ValueTask<bool> get_linearSpecularLOD()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "linearSpecularLOD"
                );
        }
        public ValueTask set_linearSpecularLOD(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "linearSpecularLOD",
                    value
                );
        }

        private BaseTexture __irradianceTexture;
        public async ValueTask<BaseTexture> get_irradianceTexture()
        {
            if(__irradianceTexture == null)
            {
                __irradianceTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "irradianceTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __irradianceTexture;
        }
        public ValueTask set_irradianceTexture(BaseTexture value)
        {
__irradianceTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "irradianceTexture",
                    value
                );
        }

        
        public async ValueTask<string> get_uid()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uid"
                );
        }

        
        public async ValueTask<bool> get_isBlocking()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocking"
                );
        }

        
        public async ValueTask<bool> get_canRescale()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
        }

        
        public async ValueTask<decimal> get_textureType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textureType"
                );
        }

        
        public async ValueTask<decimal> get_textureFormat()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textureFormat"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }
        public ValueTask set_uniqueId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
        }

        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_metadata()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_metadata(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metadata",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_reservedDataStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "reservedDataStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_reservedDataStore(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reservedDataStore",
                    value
                );
        }

        
        public async ValueTask<bool> get_getAlphaFromRGB()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "getAlphaFromRGB"
                );
        }
        public ValueTask set_getAlphaFromRGB(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "getAlphaFromRGB",
                    value
                );
        }

        
        public async ValueTask<decimal> get_level()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "level"
                );
        }
        public ValueTask set_level(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "level",
                    value
                );
        }

        
        public async ValueTask<decimal> get_coordinatesIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "coordinatesIndex"
                );
        }
        public ValueTask set_coordinatesIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "coordinatesIndex",
                    value
                );
        }

        
        public async ValueTask<decimal> get_wrapR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "wrapR"
                );
        }
        public ValueTask set_wrapR(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wrapR",
                    value
                );
        }

        
        public async ValueTask<decimal> get_anisotropicFilteringLevel()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "anisotropicFilteringLevel"
                );
        }
        public ValueTask set_anisotropicFilteringLevel(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anisotropicFilteringLevel",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertZ()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertZ"
                );
        }
        public ValueTask set_invertZ(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertZ",
                    value
                );
        }

        
        public async ValueTask<bool> get_lodLevelInAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lodLevelInAlpha"
                );
        }
        public ValueTask set_lodLevelInAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lodLevelInAlpha",
                    value
                );
        }

        
        public async ValueTask<bool> get_isRenderTarget()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRenderTarget"
                );
        }
        public ValueTask set_isRenderTarget(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRenderTarget",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

        private Observable<BaseTexture> __onDisposeObservable;
        public async ValueTask<Observable<BaseTexture>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<BaseTexture>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<BaseTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
        }
        public ValueTask set_onDisposeObservable(Observable<BaseTexture> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public BaseTexture() : base() { }

        public BaseTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<BaseTexture> NewBaseTexture(
            Scene sceneOrEngine
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BaseTexture" },
                sceneOrEngine
            );

            return new BaseTexture(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
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

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public async ValueTask<bool> checkTransformsAreIdentical(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "checkTransformsAreIdentical" }, texture
                }
            );
        }

        public async ValueTask<Matrix> getTextureMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTextureMatrix" }
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

        public async ValueTask<bool> isReadyOrNotBlocking()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyOrNotBlocking" }
                }
            );
        }

        public async ValueTask scale(decimal ratio)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public async ValueTask<BaseTexture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<ArrayBufferView> readPixels(System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> level = null, ArrayBufferView buffer = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ArrayBufferView>(
                entity => new ArrayBufferView() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "readPixels" }, faceIndex, level, buffer
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

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}