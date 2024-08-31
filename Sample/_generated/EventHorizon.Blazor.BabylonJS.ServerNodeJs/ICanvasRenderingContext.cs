/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

        public async ValueTask<string> get_lineJoin()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "lineJoin");
        }

        public ValueTask set_lineJoin(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "lineJoin", value);
        }

        public async ValueTask<decimal> get_miterLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "miterLimit");
        }

        public ValueTask set_miterLimit(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "miterLimit", value);
        }

        public async ValueTask<string> get_font()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "font");
        }

        public ValueTask set_font(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "font", value);
        }

        public async ValueTask<string> get_strokeStyle()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "strokeStyle");
        }

        public ValueTask set_strokeStyle(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "strokeStyle", value);
        }

        public async ValueTask<string> get_fillStyle()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "fillStyle");
        }

        public ValueTask set_fillStyle(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fillStyle", value);
        }

        public async ValueTask<decimal> get_globalAlpha()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "globalAlpha");
        }

        public ValueTask set_globalAlpha(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "globalAlpha", value);
        }

        public async ValueTask<string> get_shadowColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "shadowColor");
        }

        public ValueTask set_shadowColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowColor", value);
        }

        public async ValueTask<decimal> get_shadowBlur()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowBlur");
        }

        public ValueTask set_shadowBlur(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowBlur", value);
        }

        public async ValueTask<decimal> get_shadowOffsetX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetX");
        }

        public ValueTask set_shadowOffsetX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetX", value);
        }

        public async ValueTask<decimal> get_shadowOffsetY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetY");
        }

        public ValueTask set_shadowOffsetY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetY", value);
        }

        public async ValueTask<decimal> get_lineWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "lineWidth");
        }

        public ValueTask set_lineWidth(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "lineWidth", value);
        }

        private ICanvasCachedEntity __canvas;

        public async ValueTask<ICanvasCachedEntity> get_canvas()
        {
            if (__canvas == null)
            {
                __canvas = await EventHorizonBlazorInterop.GetClass<ICanvasCachedEntity>(
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
        #endregion

        #region Constructor
        public ICanvasRenderingContextCachedEntity()
            : base() { }

        public ICanvasRenderingContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask clearRect(decimal x, decimal y, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clearRect" }, x, y, width, height }
            );
        }

        public async ValueTask save()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "save" } }
            );
        }

        public async ValueTask restore()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restore" } }
            );
        }

        public async ValueTask fillRect(decimal x, decimal y, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fillRect" }, x, y, width, height }
            );
        }

        public async ValueTask scale(decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, x, y }
            );
        }

        public async ValueTask rotate(decimal angle)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "rotate" }, angle }
            );
        }

        public async ValueTask translate(decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "translate" }, x, y }
            );
        }

        public async ValueTask strokeRect(decimal x, decimal y, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "strokeRect" }, x, y, width, height }
            );
        }

        public async ValueTask rect(decimal x, decimal y, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "rect" }, x, y, width, height }
            );
        }

        public async ValueTask clip()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "clip" } }
            );
        }

        public async ValueTask putImageData(ImageData imageData, decimal dx, decimal dy)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "putImageData" }, imageData, dx, dy }
            );
        }

        public async ValueTask arc(
            decimal x,
            decimal y,
            decimal radius,
            decimal startAngle,
            decimal endAngle,
            System.Nullable<bool> anticlockwise = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask beginPath()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "beginPath" } }
            );
        }

        public async ValueTask closePath()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "closePath" } }
            );
        }

        public async ValueTask moveTo(decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "moveTo" }, x, y }
            );
        }

        public async ValueTask lineTo(decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "lineTo" }, x, y }
            );
        }

        public async ValueTask quadraticCurveTo(decimal cpx, decimal cpy, decimal x, decimal y)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "quadraticCurveTo" }, cpx, cpy, x, y }
            );
        }

        public async ValueTask<ITextMetricsCachedEntity> measureText(string text)
        {
            return await EventHorizonBlazorInterop.FuncClass<ITextMetricsCachedEntity>(
                entity => new ITextMetricsCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "measureText" }, text }
            );
        }

        public async ValueTask stroke()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "stroke" } }
            );
        }

        public async ValueTask fill()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fill" } }
            );
        }

        public async ValueTask drawImage(
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
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<ImageData> getImageData(
            decimal sx,
            decimal sy,
            decimal sw,
            decimal sh
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ImageData>(
                entity => new ImageData() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getImageData" }, sx, sy, sw, sh }
            );
        }

        public async ValueTask setLineDash(decimal[] segments)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setLineDash" }, segments }
            );
        }

        public async ValueTask fillText(
            string text,
            decimal x,
            decimal y,
            System.Nullable<decimal> maxWidth = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fillText" }, text, x, y, maxWidth }
            );
        }

        public async ValueTask strokeText(
            string text,
            decimal x,
            decimal y,
            System.Nullable<decimal> maxWidth = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "strokeText" }, text, x, y, maxWidth }
            );
        }

        public async ValueTask<ICanvasGradientCachedEntity> createLinearGradient(
            decimal x0,
            decimal y0,
            decimal x1,
            decimal y1
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ICanvasGradientCachedEntity>(
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

        public async ValueTask<ICanvasGradientCachedEntity> createRadialGradient(
            decimal x0,
            decimal y0,
            decimal r0,
            decimal x1,
            decimal y1,
            decimal r1
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<ICanvasGradientCachedEntity>(
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

        public async ValueTask setTransform(
            decimal a,
            decimal b,
            decimal c,
            decimal d,
            decimal e,
            decimal f
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTransform" }, a, b, c, d, e, f }
            );
        }

        public async ValueTask<DOMMatrixCachedEntity> getTransform()
        {
            return await EventHorizonBlazorInterop.FuncClass<DOMMatrixCachedEntity>(
                entity => new DOMMatrixCachedEntity() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTransform" } }
            );
        }
        #endregion
    }
}
