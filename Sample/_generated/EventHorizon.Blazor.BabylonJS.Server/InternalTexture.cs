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

    
    
    [JsonConverter(typeof(CachedEntityConverter<InternalTexture>))]
    public class InternalTexture : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<int> get_source()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "source"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_isReady()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isReady"
                );
        }
        public ValueTask set_isReady(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isReady",
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

        
        public async ValueTask<bool> get_isMultiview()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMultiview"
                );
        }
        public ValueTask set_isMultiview(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isMultiview",
                    value
                );
        }

        
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

        
        public async ValueTask<decimal> get_samplingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samplingMode"
                );
        }
        public ValueTask set_samplingMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samplingMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_generateMipMaps()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "generateMipMaps"
                );
        }
        public ValueTask set_generateMipMaps(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "generateMipMaps",
                    value
                );
        }

        
        public async ValueTask<decimal> get_samples()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "samples"
                );
        }
        public ValueTask set_samples(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samples",
                    value
                );
        }

        
        public async ValueTask<decimal> get_type()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
        }
        public ValueTask set_type(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
        }

        
        public async ValueTask<decimal> get_format()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "format"
                );
        }
        public ValueTask set_format(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "format",
                    value
                );
        }

        private Observable<InternalTexture> __onLoadedObservable;
        public async ValueTask<Observable<InternalTexture>> get_onLoadedObservable()
        {
            if(__onLoadedObservable == null)
            {
                __onLoadedObservable = await EventHorizonBlazorInterop.GetClass<Observable<InternalTexture>>(
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
        public ValueTask set_onLoadedObservable(Observable<InternalTexture> value)
        {
__onLoadedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLoadedObservable",
                    value
                );
        }

        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }

        
        public async ValueTask<decimal> get_depth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depth"
                );
        }
        public ValueTask set_depth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depth",
                    value
                );
        }

        
        public async ValueTask<decimal> get_baseWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baseWidth"
                );
        }
        public ValueTask set_baseWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseWidth",
                    value
                );
        }

        
        public async ValueTask<decimal> get_baseHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baseHeight"
                );
        }
        public ValueTask set_baseHeight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseHeight",
                    value
                );
        }

        
        public async ValueTask<decimal> get_baseDepth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "baseDepth"
                );
        }
        public ValueTask set_baseDepth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseDepth",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertY()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertY"
                );
        }
        public ValueTask set_invertY(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertY",
                    value
                );
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

        public static async ValueTask<InternalTexture> NewInternalTexture(
            ThinEngine engine, int source, System.Nullable<bool> delayAllocation = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InternalTexture" },
                engine, source, delayAllocation
            );

            return new InternalTexture(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<ThinEngine> getEngine()
        {
            return await EventHorizonBlazorInterop.FuncClass<ThinEngine>(
                entity => new ThinEngine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public async ValueTask incrementReferences()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "incrementReferences" }
                }
            );
        }

        public async ValueTask updateSize(decimal width, decimal height, System.Nullable<decimal> depth = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateSize" }, width, height, depth
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