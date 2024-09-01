/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRSessionEventInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRSessionEventInitCachedEntity>))]
public class XRSessionEventInitCachedEntity : CachedEntityObject, XRSessionEventInit
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

    public ValueTask set_session(XRSession value)
    {
        __session = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "session", value);
    }
    #endregion

    #region Constructor
    public XRSessionEventInitCachedEntity()
        : base() { }

    public XRSessionEventInitCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods

    #endregion
}
