/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<Measure>))]
    public class Measure : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask CombineToRef(Measure a, Measure b, Measure result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Measure", "CombineToRef" },
                    a,
                    b,
                    result
                }
            );
        }

        public static async ValueTask<Measure> Empty()
        {
            return await EventHorizonBlazorInterop.FuncClass<Measure>(
                entity => new Measure() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "GUI", "Measure", "Empty" } }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<decimal> get_left()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "left");
        }

        public ValueTask set_left(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "left", value);
        }

        public async ValueTask<decimal> get_top()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "top");
        }

        public ValueTask set_top(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "top", value);
        }

        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width");
        }

        public ValueTask set_width(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "width", value);
        }

        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height");
        }

        public ValueTask set_height(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "height", value);
        }
        #endregion

        #region Constructor
        public Measure()
            : base() { }

        public Measure(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Measure> NewMeasure(
            decimal left,
            decimal top,
            decimal width,
            decimal height
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Measure" },
                left,
                top,
                width,
                height
            );

            return new Measure(entity);
        }
        #endregion

        #region Methods
        public async ValueTask copyFrom(Measure other)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "copyFrom" }, other }
            );
        }

        public async ValueTask copyFromFloats(
            decimal left,
            decimal top,
            decimal width,
            decimal height
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyFromFloats" },
                    left,
                    top,
                    width,
                    height
                }
            );
        }

        public async ValueTask addAndTransformToRef(
            Matrix2D transform,
            decimal addX,
            decimal addY,
            decimal addWidth,
            decimal addHeight,
            Measure result
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addAndTransformToRef" },
                    transform,
                    addX,
                    addY,
                    addWidth,
                    addHeight,
                    result
                }
            );
        }

        public async ValueTask transformToRef(Matrix2D transform, Measure result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "transformToRef" }, transform, result }
            );
        }

        public async ValueTask<bool> isEqualsTo(Measure other)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isEqualsTo" }, other }
            );
        }
        #endregion
    }
}
