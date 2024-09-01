/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<PointerEventTypes>))]
public class PointerEventTypes : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    public static decimal POINTERDOWN
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERDOWN"); }
    }

    public static decimal POINTERUP
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERUP"); }
    }

    public static decimal POINTERMOVE
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERMOVE"); }
    }

    public static decimal POINTERWHEEL
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERWHEEL"); }
    }

    public static decimal POINTERPICK
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERPICK"); }
    }

    public static decimal POINTERTAP
    {
        get { return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERTAP"); }
    }

    public static decimal POINTERDOUBLETAP
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>("PointerEventTypes", "POINTERDOUBLETAP");
        }
    }
    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties

    #endregion

    #region Constructor
    public PointerEventTypes()
        : base() { }

    public PointerEventTypes(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    #endregion

    #region Methods

    #endregion
}
