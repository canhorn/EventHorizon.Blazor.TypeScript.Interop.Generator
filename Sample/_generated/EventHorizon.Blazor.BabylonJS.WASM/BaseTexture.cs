/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class BaseTexture : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal DEFAULT_ANISOTROPIC_FILTERING_LEVEL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".BaseTexture.DEFAULT_ANISOTROPIC_FILTERING_LEVEL"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".BaseTexture.DEFAULT_ANISOTROPIC_FILTERING_LEVEL",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        #region WhenAllReady TODO: Get Comments as metadata identification
        private static bool IsWhenAllReadyEnabled = false;
        private static readonly IDictionary<string, Func<Task>> WhenAllReadyActionMap = new Dictionary<string, Func<Task>>();

        public static string WhenAllReady(
            Func<Task> callback
        )
        {
            SetupWhenAllReadyStaticLoop();

            var handle = Guid.NewGuid().ToString();
            WhenAllReadyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupWhenAllReadyStaticLoop()
        {
            if (IsWhenAllReadyEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.BaseTexture.WhenAllReady",
                "CallWhenAllReadyStaticActions"
            );
            IsWhenAllReadyEnabled = true;
        }

        [JSInvokable]
        public static async Task CallWhenAllReadyStaticActions()
        {
            foreach (var action in WhenAllReadyActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion

        #region Accessors
        
        public bool hasAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "hasAlpha",
                    value
                );
            }
        }

        
        public decimal coordinatesMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "coordinatesMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "coordinatesMode",
                    value
                );
            }
        }

        
        public bool isCube
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isCube"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isCube",
                    value
                );
            }
        }

        
        public bool is3D
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "is3D"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "is3D",
                    value
                );
            }
        }

        
        public bool is2DArray
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "is2DArray"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "is2DArray",
                    value
                );
            }
        }

        
        public bool isRGBD
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isRGBD"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isRGBD",
                    value
                );
            }
        }

        
        public bool noMipmap
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "noMipmap"
                );
            }
        }

        
        public decimal lodGenerationOffset
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "lodGenerationOffset"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "lodGenerationOffset",
                    value
                );
            }
        }

        
        public decimal lodGenerationScale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "lodGenerationScale"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "lodGenerationScale",
                    value
                );
            }
        }

        
        public bool linearSpecularLOD
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "linearSpecularLOD"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "linearSpecularLOD",
                    value
                );
            }
        }

        private BaseTexture __irradianceTexture;
        public BaseTexture irradianceTexture
        {
            get
            {
            if(__irradianceTexture == null)
            {
                __irradianceTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
                    this.___guid,
                    "irradianceTexture",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            return __irradianceTexture;
            }
            set
            {
__irradianceTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "irradianceTexture",
                    value
                );
            }
        }

        
        public string uid
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "uid"
                );
            }
        }

        
        public bool isBlocking
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBlocking"
                );
            }
        }

        
        public bool canRescale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
            }
        }

        
        public decimal textureType
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "textureType"
                );
            }
        }

        
        public decimal textureFormat
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "textureFormat"
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public CachedEntity metadata
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "metadata"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "metadata",
                    value
                );
            }
        }

        
        public CachedEntity reservedDataStore
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "reservedDataStore"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "reservedDataStore",
                    value
                );
            }
        }

        
        public bool getAlphaFromRGB
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "getAlphaFromRGB"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "getAlphaFromRGB",
                    value
                );
            }
        }

        
        public decimal level
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "level"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "level",
                    value
                );
            }
        }

        
        public decimal coordinatesIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "coordinatesIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "coordinatesIndex",
                    value
                );
            }
        }

        
        public decimal wrapU
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "wrapU"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "wrapU",
                    value
                );
            }
        }

        
        public decimal wrapV
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "wrapV"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "wrapV",
                    value
                );
            }
        }

        
        public decimal wrapR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "wrapR"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "wrapR",
                    value
                );
            }
        }

        
        public decimal anisotropicFilteringLevel
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "anisotropicFilteringLevel"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "anisotropicFilteringLevel",
                    value
                );
            }
        }

        
        public bool gammaSpace
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "gammaSpace"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "gammaSpace",
                    value
                );
            }
        }

        
        public bool invertZ
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "invertZ"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertZ",
                    value
                );
            }
        }

        
        public bool lodLevelInAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "lodLevelInAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "lodLevelInAlpha",
                    value
                );
            }
        }

        
        public bool isRenderTarget
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isRenderTarget"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isRenderTarget",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        private Observable __onDisposeObservable;
        public Observable onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        
        public decimal delayLoadState
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "delayLoadState",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public BaseTexture() : base() { }

        public BaseTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BaseTexture(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "BaseTexture" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public Matrix getTextureMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTextureMatrix" }
                }
            );
        }

        public Matrix getReflectionTextureMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getReflectionTextureMatrix" }
                }
            );
        }

        public InternalTexture getInternalTexture()
        {
            return EventHorizonBlazorInteropt.FuncClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getInternalTexture" }
                }
            );
        }

        public bool isReadyOrNotBlocking()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyOrNotBlocking" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public ISize getSize()
        {
            return EventHorizonBlazorInteropt.FuncClass<ISize>(
                entity => new ISizeCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getSize" }
                }
            );
        }

        public ISize getBaseSize()
        {
            return EventHorizonBlazorInteropt.FuncClass<ISize>(
                entity => new ISizeCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBaseSize" }
                }
            );
        }

        public void updateSamplingMode(decimal samplingMode)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateSamplingMode" }, samplingMode
                }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public void delayLoad()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "delayLoad" }
                }
            );
        }

        public BaseTexture clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<BaseTexture>(
                entity => new BaseTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public ArrayBufferView readPixels(System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> level = null, ArrayBufferView buffer = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ArrayBufferView>(
                entity => new ArrayBufferView(entity),
                new object[] 
                {
                    new string[] { this.___guid, "readPixels" }, faceIndex, level, buffer
                }
            );
        }

        public void releaseInternalTexture()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseInternalTexture" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}