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

        public async ValueTask<bool> get_is2D()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "is2D");
        }

        public ValueTask set_is2D(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "is2D", value);
        }

        public async ValueTask<bool> get_isIdentity()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isIdentity");
        }

        public ValueTask set_isIdentity(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isIdentity", value);
        }

        public async ValueTask<decimal> get_a()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "a");
        }

        public ValueTask set_a(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "a", value);
        }

        public async ValueTask<decimal> get_b()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "b");
        }

        public ValueTask set_b(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "b", value);
        }

        public async ValueTask<decimal> get_c()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "c");
        }

        public ValueTask set_c(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "c", value);
        }

        public async ValueTask<decimal> get_d()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "d");
        }

        public ValueTask set_d(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "d", value);
        }

        public async ValueTask<decimal> get_e()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "e");
        }

        public ValueTask set_e(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "e", value);
        }

        public async ValueTask<decimal> get_f()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "f");
        }

        public ValueTask set_f(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "f", value);
        }

        public async ValueTask<decimal> get_m11()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m11");
        }

        public ValueTask set_m11(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m11", value);
        }

        public async ValueTask<decimal> get_m12()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m12");
        }

        public ValueTask set_m12(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m12", value);
        }

        public async ValueTask<decimal> get_m13()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m13");
        }

        public ValueTask set_m13(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m13", value);
        }

        public async ValueTask<decimal> get_m14()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m14");
        }

        public ValueTask set_m14(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m14", value);
        }

        public async ValueTask<decimal> get_m21()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m21");
        }

        public ValueTask set_m21(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m21", value);
        }

        public async ValueTask<decimal> get_m22()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m22");
        }

        public ValueTask set_m22(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m22", value);
        }

        public async ValueTask<decimal> get_m23()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m23");
        }

        public ValueTask set_m23(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m23", value);
        }

        public async ValueTask<decimal> get_m24()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m24");
        }

        public ValueTask set_m24(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m24", value);
        }

        public async ValueTask<decimal> get_m31()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m31");
        }

        public ValueTask set_m31(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m31", value);
        }

        public async ValueTask<decimal> get_m32()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m32");
        }

        public ValueTask set_m32(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m32", value);
        }

        public async ValueTask<decimal> get_m33()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m33");
        }

        public ValueTask set_m33(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m33", value);
        }

        public async ValueTask<decimal> get_m34()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m34");
        }

        public ValueTask set_m34(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m34", value);
        }

        public async ValueTask<decimal> get_m41()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m41");
        }

        public ValueTask set_m41(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m41", value);
        }

        public async ValueTask<decimal> get_m42()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m42");
        }

        public ValueTask set_m42(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m42", value);
        }

        public async ValueTask<decimal> get_m43()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m43");
        }

        public ValueTask set_m43(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m43", value);
        }

        public async ValueTask<decimal> get_m44()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "m44");
        }

        public ValueTask set_m44(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "m44", value);
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
