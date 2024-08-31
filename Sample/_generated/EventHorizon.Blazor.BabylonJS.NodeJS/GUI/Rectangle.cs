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

    [JsonConverter(typeof(CachedEntityConverter<Rectangle>))]
    public class Rectangle : Container
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public decimal thickness
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "thickness"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "thickness", value);
            }
        }

        public decimal cornerRadius
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cornerRadius"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cornerRadius", value);
            }
        }

        public decimal cornerRadiusX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cornerRadiusX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cornerRadiusX", value);
            }
        }

        public decimal cornerRadiusY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cornerRadiusY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cornerRadiusY", value);
            }
        }

        public decimal cornerRadiusZ
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cornerRadiusZ"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cornerRadiusZ", value);
            }
        }

        public decimal cornerRadiusW
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "cornerRadiusW"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cornerRadiusW", value);
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
        #endregion

        #region Constructor
        public Rectangle()
            : base() { }

        public Rectangle(ICachedEntity entity)
            : base(entity) { }

        public Rectangle(string name = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Rectangle" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}
