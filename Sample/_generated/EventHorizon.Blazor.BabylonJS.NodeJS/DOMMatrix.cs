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

    public interface DOMMatrix : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<DOMMatrixCachedEntity>))]
    public class DOMMatrixCachedEntity : CachedEntityObject, DOMMatrix
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

        public bool is2D
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "is2D"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "is2D", value);
            }
        }

        public bool isIdentity
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isIdentity"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isIdentity", value);
            }
        }

        public decimal a
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "a"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "a", value);
            }
        }

        public decimal b
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "b"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "b", value);
            }
        }

        public decimal c
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "c"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "c", value);
            }
        }

        public decimal d
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "d"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "d", value);
            }
        }

        public decimal e
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "e"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "e", value);
            }
        }

        public decimal f
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "f"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "f", value);
            }
        }

        public decimal m11
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m11"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m11", value);
            }
        }

        public decimal m12
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m12"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m12", value);
            }
        }

        public decimal m13
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m13"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m13", value);
            }
        }

        public decimal m14
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m14"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m14", value);
            }
        }

        public decimal m21
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m21"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m21", value);
            }
        }

        public decimal m22
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m22"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m22", value);
            }
        }

        public decimal m23
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m23"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m23", value);
            }
        }

        public decimal m24
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m24"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m24", value);
            }
        }

        public decimal m31
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m31"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m31", value);
            }
        }

        public decimal m32
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m32"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m32", value);
            }
        }

        public decimal m33
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m33"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m33", value);
            }
        }

        public decimal m34
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m34"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m34", value);
            }
        }

        public decimal m41
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m41"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m41", value);
            }
        }

        public decimal m42
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m42"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m42", value);
            }
        }

        public decimal m43
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m43"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m43", value);
            }
        }

        public decimal m44
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m44"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "m44", value);
            }
        }
        #endregion

        #region Constructor
        public DOMMatrixCachedEntity()
            : base() { }

        public DOMMatrixCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
