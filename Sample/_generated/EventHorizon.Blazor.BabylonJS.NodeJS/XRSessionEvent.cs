/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<XRSessionEvent>))]
public class XRSessionEvent : CachedEntityObject
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
    private XRSession __session;
    public XRSession session
    {
        get
        {
            if (__session == null)
            {
                __session = EventHorizonBlazorInterop.GetClass<XRSession>(
                    this.___guid,
                    "session",
                    (entity) =>
                    {
                        return new XRSession() { ___guid = entity.___guid };
                    }
                );
            }
            return __session;
        }
    }
    #endregion

    #region Constructor
    public XRSessionEvent()
        : base() { }

    public XRSessionEvent(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    public XRSessionEvent(CachedEntity type, XRSessionEventInit eventInitDict = null)
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "XRSessionEvent" },
            type,
            eventInitDict
        );
        ___guid = entity.___guid;
    }
    #endregion

    #region Methods

    #endregion
}
