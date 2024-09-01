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

    [JsonConverter(typeof(CachedEntityConverter<Measure>))]
    public class Measure : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void CombineToRef(Measure a, Measure b, Measure result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Measure", "CombineToRef" },
                    a,
                    b,
                    result
                }
            );
        }

        public static Measure Empty()
        {
            return EventHorizonBlazorInterop.FuncClass<Measure>(
                entity => new Measure() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "GUI", "Measure", "Empty" } }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public decimal left
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "left"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "left", value);
            }
        }

        public decimal top
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "top"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "top", value);
            }
        }

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "width", value);
            }
        }

        public decimal height
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "height", value);
            }
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

        public Measure(decimal left, decimal top, decimal width, decimal height)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Measure" },
                left,
                top,
                width,
                height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void copyFrom(Measure other)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "copyFrom" }, other }
            );
        }

        public void copyFromFloats(decimal left, decimal top, decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void addAndTransformToRef(
            Matrix2D transform,
            decimal addX,
            decimal addY,
            decimal addWidth,
            decimal addHeight,
            Measure result
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void transformToRef(Matrix2D transform, Measure result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "transformToRef" }, transform, result }
            );
        }

        public bool isEqualsTo(Measure other)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isEqualsTo" }, other }
            );
        }
        #endregion
    }
}
