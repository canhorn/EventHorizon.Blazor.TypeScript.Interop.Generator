/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<Image>))]
    public class Image : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static CachedEntity SourceImgCache
        {
            get
            {
                return EventHorizonBlazorInterop.Get<CachedEntity>(
                    "BABYLON",
                    "GUI.Image.SourceImgCache"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "GUI.Image.SourceImgCache", value);
            }
        }

        public static decimal STRETCH_NONE
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "GUI.Image.STRETCH_NONE");
            }
        }

        public static decimal STRETCH_FILL
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>("BABYLON", "GUI.Image.STRETCH_FILL");
            }
        }

        public static decimal STRETCH_UNIFORM
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_UNIFORM"
                );
            }
        }

        public static decimal STRETCH_EXTEND
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_EXTEND"
                );
            }
        }

        public static decimal STRETCH_NINE_PATCH
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Image.STRETCH_NINE_PATCH"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void ResetImageCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { "BABYLON", "GUI", "Image", "ResetImageCache" } }
            );
        }
        #endregion

        #region Accessors

        public bool isLoaded
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isLoaded"); }
        }

        public bool detectPointerOnOpaqueOnly
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "detectPointerOnOpaqueOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "detectPointerOnOpaqueOnly", value);
            }
        }

        public decimal sliceLeft
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sliceLeft"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sliceLeft", value);
            }
        }

        public decimal sliceRight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sliceRight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sliceRight", value);
            }
        }

        public decimal sliceTop
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sliceTop"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sliceTop", value);
            }
        }

        public decimal sliceBottom
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sliceBottom"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sliceBottom", value);
            }
        }

        public decimal sourceLeft
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sourceLeft"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sourceLeft", value);
            }
        }

        public decimal sourceTop
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sourceTop"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sourceTop", value);
            }
        }

        public decimal sourceWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sourceWidth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sourceWidth", value);
            }
        }

        public decimal sourceHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "sourceHeight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "sourceHeight", value);
            }
        }

        public decimal imageWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "imageWidth"); }
        }

        public decimal imageHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "imageHeight"); }
        }

        public bool populateNinePatchSlicesFromImage
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "populateNinePatchSlicesFromImage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "populateNinePatchSlicesFromImage",
                    value
                );
            }
        }

        public bool isSVG
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSVG"); }
        }

        public bool svgAttributesComputationCompleted
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "svgAttributesComputationCompleted"
                );
            }
        }

        public bool autoScale
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "autoScale"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "autoScale", value);
            }
        }

        public decimal stretch
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "stretch"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "stretch", value);
            }
        }

        private IImageCachedEntity __domImage;
        public IImageCachedEntity domImage
        {
            get
            {
                if (__domImage == null)
                {
                    __domImage = EventHorizonBlazorInterop.GetClass<IImageCachedEntity>(
                        this.___guid,
                        "domImage",
                        (entity) =>
                        {
                            return new IImageCachedEntity() { ___guid = entity.___guid };
                        }
                    );
                }
                return __domImage;
            }
            set
            {
                __domImage = null;
                EventHorizonBlazorInterop.Set(this.___guid, "domImage", value);
            }
        }

        public string source
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "source"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "source", value);
            }
        }

        public decimal cellWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cellWidth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cellWidth", value);
            }
        }

        public decimal cellHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cellHeight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cellHeight", value);
            }
        }

        public decimal cellId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cellId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cellId", value);
            }
        }
        #endregion

        #region Properties

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public string alt
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "alt"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "alt", value);
            }
        }

        private Observable<Image> __onImageLoadedObservable;
        public Observable<Image> onImageLoadedObservable
        {
            get
            {
                if (__onImageLoadedObservable == null)
                {
                    __onImageLoadedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Image>
                    >(
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
                EventHorizonBlazorInterop.Set(this.___guid, "onImageLoadedObservable", value);
            }
        }

        private Observable<Image> __onSVGAttributesComputedObservable;
        public Observable<Image> onSVGAttributesComputedObservable
        {
            get
            {
                if (__onSVGAttributesComputedObservable == null)
                {
                    __onSVGAttributesComputedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Image>
                    >(
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onSVGAttributesComputedObservable",
                    value
                );
            }
        }

        private ReferrerPolicy __referrerPolicy;
        public ReferrerPolicy referrerPolicy
        {
            get
            {
                if (__referrerPolicy == null)
                {
                    __referrerPolicy = EventHorizonBlazorInterop.GetClass<ReferrerPolicy>(
                        this.___guid,
                        "referrerPolicy",
                        (entity) =>
                        {
                            return new ReferrerPolicy() { ___guid = entity.___guid };
                        }
                    );
                }
                return __referrerPolicy;
            }
            set
            {
                __referrerPolicy = null;
                EventHorizonBlazorInterop.Set(this.___guid, "referrerPolicy", value);
            }
        }
        #endregion

        #region Constructor
        public Image()
            : base() { }

        public Image(ICachedEntity entity)
            : base(entity) { }

        public Image(string name = null, string url = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Image" },
                name,
                url
            );
            ___guid = entity.___guid;
        }

        public Image(string name = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Image" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" } }
            );
        }

        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "contains" }, x, y }
            );
        }

        public void synchronizeSizeWithContent()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "synchronizeSizeWithContent" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
