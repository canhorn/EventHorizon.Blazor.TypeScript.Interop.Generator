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
    public class InternalTexture : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private InternalTextureSource __source;
        public InternalTextureSource source
        {
            get
            {
            if(__source == null)
            {
                __source = EventHorizonBlazorInteropt.GetClass<InternalTextureSource>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new InternalTextureSource() { ___guid = entity.___guid };
                    }
                );
            }
            return __source;
            }
        }
        #endregion

        #region Properties
        
        public bool isReady
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isReady"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isReady",
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

        
        public bool isMultiview
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isMultiview"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isMultiview",
                    value
                );
            }
        }

        
        public string url
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "url"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "url",
                    value
                );
            }
        }

        
        public decimal samplingMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "samplingMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "samplingMode",
                    value
                );
            }
        }

        
        public bool generateMipMaps
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "generateMipMaps"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "generateMipMaps",
                    value
                );
            }
        }

        
        public decimal samples
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "samples"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "samples",
                    value
                );
            }
        }

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal format
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "format"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "format",
                    value
                );
            }
        }

        private Observable<InternalTexture> __onLoadedObservable;
        public Observable<InternalTexture> onLoadedObservable
        {
            get
            {
            if(__onLoadedObservable == null)
            {
                __onLoadedObservable = EventHorizonBlazorInteropt.GetClass<Observable<InternalTexture>>(
                    this.___guid,
                    "onLoadedObservable",
                    (entity) =>
                    {
                        return new Observable<InternalTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLoadedObservable;
            }
            set
            {
__onLoadedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onLoadedObservable",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal depth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "depth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "depth",
                    value
                );
            }
        }

        
        public decimal baseWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "baseWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "baseWidth",
                    value
                );
            }
        }

        
        public decimal baseHeight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "baseHeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "baseHeight",
                    value
                );
            }
        }

        
        public decimal baseDepth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "baseDepth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "baseDepth",
                    value
                );
            }
        }

        
        public bool invertY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "invertY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertY",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public InternalTexture() : base() { } 

        public InternalTexture(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public InternalTexture(
            ThinEngine engine, InternalTextureSource source, System.Nullable<bool> delayAllocation = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "InternalTexture" },
                engine, source, delayAllocation
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public ThinEngine getEngine()
        {
            return EventHorizonBlazorInteropt.FuncClass<ThinEngine>(
                entity => new ThinEngine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public void incrementReferences()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "incrementReferences" }
                }
            );
        }

        public void updateSize(int width, int height, System.Nullable<int> depth = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateSize" }, width, height, depth
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
        #endregion
    }
}