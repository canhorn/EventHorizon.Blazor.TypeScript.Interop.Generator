/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Image : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal STRETCH_NONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_NONE"
                );
            }
        }

        
        public static decimal STRETCH_FILL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_FILL"
                );
            }
        }

        
        public static decimal STRETCH_UNIFORM
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_UNIFORM"
                );
            }
        }

        
        public static decimal STRETCH_EXTEND
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_EXTEND"
                );
            }
        }

        
        public static decimal STRETCH_NINE_PATCH
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_NINE_PATCH"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool isLoaded
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isLoaded"
                );
            }
        }

        
        public bool populateNinePatchSlicesFromImage
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "populateNinePatchSlicesFromImage"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "populateNinePatchSlicesFromImage",
                    value
                );
            }
        }

        
        public bool detectPointerOnOpaqueOnly
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "detectPointerOnOpaqueOnly"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "detectPointerOnOpaqueOnly",
                    value
                );
            }
        }

        
        public decimal sliceLeft
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sliceLeft"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sliceLeft",
                    value
                );
            }
        }

        
        public decimal sliceRight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sliceRight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sliceRight",
                    value
                );
            }
        }

        
        public decimal sliceTop
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sliceTop"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sliceTop",
                    value
                );
            }
        }

        
        public decimal sliceBottom
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sliceBottom"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sliceBottom",
                    value
                );
            }
        }

        
        public decimal sourceLeft
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sourceLeft"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sourceLeft",
                    value
                );
            }
        }

        
        public decimal sourceTop
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sourceTop"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sourceTop",
                    value
                );
            }
        }

        
        public decimal sourceWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sourceWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sourceWidth",
                    value
                );
            }
        }

        
        public decimal sourceHeight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sourceHeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sourceHeight",
                    value
                );
            }
        }

        
        public bool isSVG
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isSVG"
                );
            }
        }

        
        public bool svgAttributesComputationCompleted
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "svgAttributesComputationCompleted"
                );
            }
        }

        
        public bool autoScale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoScale"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "autoScale",
                    value
                );
            }
        }

        
        public decimal stretch
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stretch"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stretch",
                    value
                );
            }
        }

        private HTMLImageElement __domImage;
        public HTMLImageElement domImage
        {
            get
            {
            if(__domImage == null)
            {
                __domImage = EventHorizonBlazorInteropt.GetClass<HTMLImageElement>(
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
            set
            {
__domImage = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "domImage",
                    value
                );
            }
        }

        
        public decimal cellWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cellWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cellWidth",
                    value
                );
            }
        }

        
        public decimal cellHeight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cellHeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cellHeight",
                    value
                );
            }
        }

        
        public decimal cellId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cellId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cellId",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
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

        private Observable<Image> __onImageLoadedObservable;
        public Observable<Image> onImageLoadedObservable
        {
            get
            {
            if(__onImageLoadedObservable == null)
            {
                __onImageLoadedObservable = EventHorizonBlazorInteropt.GetClass<Observable<Image>>(
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
            set
            {
__onImageLoadedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onImageLoadedObservable",
                    value
                );
            }
        }

        private Observable<Image> __onSVGAttributesComputedObservable;
        public Observable<Image> onSVGAttributesComputedObservable
        {
            get
            {
            if(__onSVGAttributesComputedObservable == null)
            {
                __onSVGAttributesComputedObservable = EventHorizonBlazorInteropt.GetClass<Observable<Image>>(
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
            set
            {
__onSVGAttributesComputedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onSVGAttributesComputedObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Image() : base() { }

        public Image(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Image(
            string name = null, string url = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "Image" },
                name, url
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "contains" }, x, y
                }
            );
        }

        public void synchronizeSizeWithContent()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "synchronizeSizeWithContent" }
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