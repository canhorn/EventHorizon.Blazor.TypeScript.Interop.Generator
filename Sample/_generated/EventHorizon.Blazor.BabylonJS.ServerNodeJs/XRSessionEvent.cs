/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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

    public async ValueTask<XRSession> get_session()
    {
        if (__session == null)
        {
            __session = await EventHorizonBlazorInterop.GetClass<XRSession>(
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
    #endregion

    #region Constructor
    public XRSessionEvent()
        : base() { }

    public XRSessionEvent(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    public static async ValueTask<XRSessionEvent> NewXRSessionEvent(
        CachedEntity type,
        XRSessionEventInit eventInitDict = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "XRSessionEvent" },
            type,
            eventInitDict
        );

        return new XRSessionEvent(entity);
    }
    #endregion

    #region Methods

    #endregion
}
