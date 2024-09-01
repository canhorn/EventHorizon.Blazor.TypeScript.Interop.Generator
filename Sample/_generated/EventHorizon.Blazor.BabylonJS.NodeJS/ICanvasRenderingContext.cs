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

    public interface ICanvasRenderingContext : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ICanvasRenderingContextCachedEntity>))]
    public class ICanvasRenderingContextCachedEntity : CachedEntityObject, ICanvasRenderingContext
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

        public string lineJoin
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "lineJoin"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "lineJoin", value);
            }
        }

        public decimal miterLimit
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "miterLimit"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "miterLimit", value);
            }
        }

        public string font
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "font"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "font", value);
            }
        }

        public string strokeStyle
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "strokeStyle"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "strokeStyle", value);
            }
        }

        public string fillStyle
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "fillStyle"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fillStyle", value);
            }
        }

        public decimal globalAlpha
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "globalAlpha"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "globalAlpha", value);
            }
        }

        public string shadowColor
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "shadowColor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowColor", value);
            }
        }

        public decimal shadowBlur
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowBlur"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowBlur", value);
            }
        }

        public decimal shadowOffsetX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetX", value);
            }
        }

        public decimal shadowOffsetY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetY", value);
            }
        }

        public decimal lineWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "lineWidth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "lineWidth", value);
            }
        }

        private ICanvasCachedEntity __canvas;
        public ICanvasCachedEntity canvas
        {
            get
            {
                if (__canvas == null)
                {
                    __canvas = EventHorizonBlazorInterop.GetClass<ICanvasCachedEntity>(
                        this.___guid,
                        "canvas",
                        (entity) =>
                        {
                            return new ICanvasCachedEntity() { ___guid = entity.___guid };
                        }
                    );
                }
                return __canvas;
            }
        }
        #endregion

        #region Constructor
        public ICanvasRenderingContextCachedEntity()
            : base() { }

        public ICanvasRenderingContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void clearRect(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearRect" }, x, y, width, height }
            );
        }

        public void save()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "save" } }
            );
        }

        public void restore()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restore" } }
            );
        }

        public void fillRect(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fillRect" }, x, y, width, height }
            );
        }

        public void scale(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, x, y }
            );
        }

        public void rotate(decimal angle)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "rotate" }, angle }
            );
        }

        public void translate(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "translate" }, x, y }
            );
        }

        public void strokeRect(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "strokeRect" }, x, y, width, height }
            );
        }

        public void rect(decimal x, decimal y, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "rect" }, x, y, width, height }
            );
        }

        public void clip()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clip" } }
            );
        }

        public void putImageData(ImageData imageData, decimal dx, decimal dy)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "putImageData" }, imageData, dx, dy }
            );
        }

        public void arc(
            decimal x,
            decimal y,
            decimal radius,
            decimal startAngle,
            decimal endAngle,
            System.Nullable<bool> anticlockwise = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "arc" },
                    x,
                    y,
                    radius,
                    startAngle,
                    endAngle,
                    anticlockwise
                }
            );
        }

        public void beginPath()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beginPath" } }
            );
        }

        public void closePath()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "closePath" } }
            );
        }

        public void moveTo(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "moveTo" }, x, y }
            );
        }

        public void lineTo(decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "lineTo" }, x, y }
            );
        }

        public void quadraticCurveTo(decimal cpx, decimal cpy, decimal x, decimal y)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "quadraticCurveTo" }, cpx, cpy, x, y }
            );
        }

        public ITextMetricsCachedEntity measureText(string text)
        {
            return EventHorizonBlazorInterop.FuncClass<ITextMetricsCachedEntity>(
                entity => new ITextMetricsCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "measureText" }, text }
            );
        }

        public void stroke()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "stroke" } }
            );
        }

        public void fill()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fill" } }
            );
        }

        public void drawImage(
            object image,
            decimal sx,
            decimal sy,
            decimal sWidth,
            decimal sHeight,
            decimal dx,
            decimal dy,
            decimal dWidth,
            decimal dHeight
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawImage" },
                    image,
                    sx,
                    sy,
                    sWidth,
                    sHeight,
                    dx,
                    dy,
                    dWidth,
                    dHeight
                }
            );
        }

        public ImageData getImageData(decimal sx, decimal sy, decimal sw, decimal sh)
        {
            return EventHorizonBlazorInterop.FuncClass<ImageData>(
                entity => new ImageData() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getImageData" }, sx, sy, sw, sh }
            );
        }

        public void setLineDash(decimal[] segments)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setLineDash" }, segments }
            );
        }

        public void fillText(
            string text,
            decimal x,
            decimal y,
            System.Nullable<decimal> maxWidth = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fillText" }, text, x, y, maxWidth }
            );
        }

        public void strokeText(
            string text,
            decimal x,
            decimal y,
            System.Nullable<decimal> maxWidth = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "strokeText" }, text, x, y, maxWidth }
            );
        }

        public ICanvasGradientCachedEntity createLinearGradient(
            decimal x0,
            decimal y0,
            decimal x1,
            decimal y1
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ICanvasGradientCachedEntity>(
                entity => new ICanvasGradientCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createLinearGradient" },
                    x0,
                    y0,
                    x1,
                    y1
                }
            );
        }

        public ICanvasGradientCachedEntity createRadialGradient(
            decimal x0,
            decimal y0,
            decimal r0,
            decimal x1,
            decimal y1,
            decimal r1
        )
        {
            return EventHorizonBlazorInterop.FuncClass<ICanvasGradientCachedEntity>(
                entity => new ICanvasGradientCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRadialGradient" },
                    x0,
                    y0,
                    r0,
                    x1,
                    y1,
                    r1
                }
            );
        }

        public void setTransform(decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTransform" }, a, b, c, d, e, f }
            );
        }

        public DOMMatrixCachedEntity getTransform()
        {
            return EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTransform" } }
            );
        }
        #endregion
    }
}
