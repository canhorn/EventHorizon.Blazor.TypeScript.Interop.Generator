/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Image>))]
    public class Image : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_STRETCH_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_NONE"
                );
        }

        
        public static async ValueTask<decimal> get_STRETCH_FILL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_FILL"
                );
        }

        
        public static async ValueTask<decimal> get_STRETCH_UNIFORM()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_UNIFORM"
                );
        }

        
        public static async ValueTask<decimal> get_STRETCH_EXTEND()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_EXTEND"
                );
        }

        
        public static async ValueTask<decimal> get_STRETCH_NINE_PATCH()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_NINE_PATCH"
                );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isLoaded()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLoaded"
                );
        }

        
        public async ValueTask<bool> get_populateNinePatchSlicesFromImage()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "populateNinePatchSlicesFromImage"
                );
        }
        public ValueTask set_populateNinePatchSlicesFromImage(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "populateNinePatchSlicesFromImage",
                    value
                );
        }

        
        public async ValueTask<bool> get_detectPointerOnOpaqueOnly()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "detectPointerOnOpaqueOnly"
                );
        }
        public ValueTask set_detectPointerOnOpaqueOnly(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "detectPointerOnOpaqueOnly",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sliceLeft()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sliceLeft"
                );
        }
        public ValueTask set_sliceLeft(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sliceLeft",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sliceRight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sliceRight"
                );
        }
        public ValueTask set_sliceRight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sliceRight",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sliceTop()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sliceTop"
                );
        }
        public ValueTask set_sliceTop(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sliceTop",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sliceBottom()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sliceBottom"
                );
        }
        public ValueTask set_sliceBottom(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sliceBottom",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sourceLeft()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceLeft"
                );
        }
        public ValueTask set_sourceLeft(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceLeft",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sourceTop()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceTop"
                );
        }
        public ValueTask set_sourceTop(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceTop",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sourceWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceWidth"
                );
        }
        public ValueTask set_sourceWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceWidth",
                    value
                );
        }

        
        public async ValueTask<decimal> get_sourceHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "sourceHeight"
                );
        }
        public ValueTask set_sourceHeight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceHeight",
                    value
                );
        }

        
        public async ValueTask<bool> get_isSVG()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSVG"
                );
        }

        
        public async ValueTask<bool> get_svgAttributesComputationCompleted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "svgAttributesComputationCompleted"
                );
        }

        
        public async ValueTask<bool> get_autoScale()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoScale"
                );
        }
        public ValueTask set_autoScale(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoScale",
                    value
                );
        }

        
        public async ValueTask<decimal> get_stretch()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "stretch"
                );
        }
        public ValueTask set_stretch(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "stretch",
                    value
                );
        }

        private HTMLImageElement __domImage;
        public async ValueTask<HTMLImageElement> get_domImage()
        {
            if(__domImage == null)
            {
                __domImage = await EventHorizonBlazorInterop.GetClass<HTMLImageElement>(
                    this.___guid,
                    "domImage",
                    (entity) =>
                    {
                        return new HTMLImageElement() { ___guid = entity.___guid };
                    }
                );
            }
            return __domImage;
        }
        public ValueTask set_domImage(HTMLImageElement value)
        {
__domImage = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "domImage",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellWidth"
                );
        }
        public ValueTask set_cellWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellWidth",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellHeight"
                );
        }
        public ValueTask set_cellHeight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellHeight",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellId"
                );
        }
        public ValueTask set_cellId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellId",
                    value
                );
        }
        #endregion

        #region Properties
        
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

        private Observable<Image> __onImageLoadedObservable;
        public async ValueTask<Observable<Image>> get_onImageLoadedObservable()
        {
            if(__onImageLoadedObservable == null)
            {
                __onImageLoadedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Image>>(
                    this.___guid,
                    "onImageLoadedObservable",
                    (entity) =>
                    {
                        return new Observable<Image>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onImageLoadedObservable;
        }
        public ValueTask set_onImageLoadedObservable(Observable<Image> value)
        {
__onImageLoadedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onImageLoadedObservable",
                    value
                );
        }

        private Observable<Image> __onSVGAttributesComputedObservable;
        public async ValueTask<Observable<Image>> get_onSVGAttributesComputedObservable()
        {
            if(__onSVGAttributesComputedObservable == null)
            {
                __onSVGAttributesComputedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Image>>(
                    this.___guid,
                    "onSVGAttributesComputedObservable",
                    (entity) =>
                    {
                        return new Observable<Image>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onSVGAttributesComputedObservable;
        }
        public ValueTask set_onSVGAttributesComputedObservable(Observable<Image> value)
        {
__onSVGAttributesComputedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onSVGAttributesComputedObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Image() : base() { }

        public Image(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Image> NewImage(
            string name = null, string url = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Image" },
                name, url
            );

            return new Image(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> contains(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "contains" }, x, y
                }
            );
        }

        public async ValueTask synchronizeSizeWithContent()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "synchronizeSizeWithContent" }
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